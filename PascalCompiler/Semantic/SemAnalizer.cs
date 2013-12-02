using Antlr.Runtime;
using Antlr.Runtime.Tree;
using PascalCompiler.Semantic.ProgramContext;
using PascalCompiler.Semantic.ProgramContext.Methods;
using PascalCompiler.Semantic.ProgramContext.Variables;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using AstNodeType = PascalCompiler.PascalGrammarParser;

namespace PascalCompiler.Semantic
{
    class SemAnalizer
    {
        public SemAnalizer(ITree program)
        {
            if (program.Type != AstNodeType.PROGRAM)
                throw new SemanticException("This tree is not a programm");
            this.program = program;

        }

        private ITree program = null;

        private VariableType GetTypeFromString(string type)
        {
            type = type.Replace(" ", "").Replace(":", "");
            switch (type)
            {
                case "integer":
                    return VariableType.INT;
                case "boolean":
                    return VariableType.BOOL;
                case "real":
                    return VariableType.FLOAT;
                case "string":
                    return VariableType.STRING;
                default:
                    throw new SemanticException(String.Format("Unknown type definition {0}", type));
            }
        }

        private string GetStringTypeFromType(VariableType type)
        {
            switch (type)
            {
                case VariableType.BOOL:
                    return "boolean";
                case VariableType.FLOAT:
                    return "real";
                case VariableType.INT:
                    return "integer";
                case VariableType.STRING:
                    return "string";
                default:
                    return "none_type";
            }
        }

        private void AnalizeFunctionDefinition(ITree node, Context context)
        {
            Context currentContext = new Context(context);
            currentContext.PutVar("result", GetTypeFromString(node.GetChild(0).Text));
            Function func = new Function(((FunctionAstNode)node).Name, GetTypeFromString(node.GetChild(0).Text));
            for (int i = 1; i < node.ChildCount - 1; i++)
            {
                if(node.GetChild(i).Type == AstNodeType.PARAMS)
                {
                    for (int j = 0; j < node.GetChild(i).ChildCount; j++)
                    {
                        for (int k = 0; k < node.GetChild(i).GetChild(j).ChildCount; k++)
                            func.addParamType(GetTypeFromString(node.GetChild(i).GetChild(j).Text));
                    }
                    AnalizeVariablesDefinition(node.GetChild(i), currentContext);
                }
            }
            for (int i = 1; i < node.ChildCount - 1; i++)
            {
                    if (node.GetChild(i).Type == AstNodeType.VAR)
                    {
                        AnalizeVariablesDefinition(node.GetChild(i), currentContext);
                    }
            }
            for (int i = 1; i < node.ChildCount - 1; i++)
            {
                if (node.GetChild(i).Type == AstNodeType.METHODS)
                {
                    AnalizeMethodsDefinition(node.GetChild(i), currentContext);
                }
            }
            context.PutMethod(func);
            AnalizeImplementation(node.GetChild(node.ChildCount - 1), currentContext);
        }

        private void AnalizeProcedureDefinition(ITree node, Context context)
        {
            Context currentContext = context;
            bool contextChanged = false;
            Procedure proc = new Procedure(((ProcedureAstNode)node).Name);
            for (int i = 0; i < node.ChildCount - 1; i++)
            {
                if (node.GetChild(i).Type == AstNodeType.PARAMS) 
                {
                    if (!contextChanged)
                    {
                        currentContext = new Context(currentContext);
                        contextChanged = true;
                    }
                    for (int j = 0; j < node.GetChild(i).ChildCount; j++)
                    {
                        for (int k = 0; k < node.GetChild(i).GetChild(j).ChildCount; k++)
                            proc.addParamType(GetTypeFromString(node.GetChild(i).GetChild(j).Text));
                    }
                    AnalizeVariablesDefinition(node.GetChild(i), currentContext);
                }
            }
            for (int i = 0; i < node.ChildCount - 1; i++)
            {
                if (node.GetChild(i).Type == AstNodeType.VAR)
                {
                    if (!contextChanged)
                    {
                        currentContext = new Context(currentContext);
                        contextChanged = true;
                    }
                    AnalizeVariablesDefinition(node.GetChild(i), currentContext);
                }
            }
            for (int i = 0; i < node.ChildCount - 1; i++)
            {
                if (node.GetChild(i).Type == AstNodeType.METHODS)
                {
                        AnalizeMethodsDefinition(node.GetChild(i), currentContext);
                }
            }
            context.PutMethod(proc);
            AnalizeImplementation(node.GetChild(node.ChildCount - 1), currentContext);
        }

        private void AnalizeMethodsDefinition(ITree node, Context context)
        {
            for (int i = 0; i < node.ChildCount; i++)
            {
                switch (node.GetChild(i).Type)
                {
                    case AstNodeType.PROCEDURE:
                        AnalizeProcedureDefinition(node.GetChild(i), context);
                        break;
                    case AstNodeType.FUNCTION:
                        AnalizeFunctionDefinition(node.GetChild(i), context);
                        break;
                }
            }
        }

        private void AnalizeVariablesDefinition(ITree node, Context context)
        {
            for (int i = 0; i < node.ChildCount; i++)
            {
                string type = node.GetChild(i).Text;
                switch (type)
                {
                    case "integer":
                        for (int v = 0; v < node.GetChild(i).ChildCount; v++)
                        {
                            context.PutVar(node.GetChild(i).GetChild(v).Text, VariableType.INT);
                        }
                        break;
                    case "boolean":
                        for (int v = 0; v < node.GetChild(i).ChildCount; v++)
                        {
                            context.PutVar(node.GetChild(i).GetChild(v).Text, VariableType.BOOL);
                        }
                        break;
                    case "real":
                        for (int v = 0; v < node.GetChild(i).ChildCount; v++)
                        {
                            context.PutVar(node.GetChild(i).GetChild(v).Text, VariableType.FLOAT);
                        }
                        break;
                    case "string":
                        for (int v = 0; v < node.GetChild(i).ChildCount; v++)
                        {
                            context.PutVar(node.GetChild(i).GetChild(v).Text, VariableType.STRING);
                        }
                        break;
                    default:
                        throw new SemanticException("Unknown type definition");
                }
            }
        }

        private void AnalizeDefinition(ITree node, Context context)
        {
            Console.WriteLine("Definition analize started");
            switch (node.Type)
            {
                case AstNodeType.METHODS:
                    AnalizeMethodsDefinition(node, context);
                    break;
                case AstNodeType.VAR:
                    AnalizeVariablesDefinition(node, context);
                    break;
                default:
                    throw new SemanticException("Unknown definition member");
            }
        }

        private void AnalizeConvertTypes(ITree node, VariableType nodeType, VariableType target)
        {
            ConvType ct = ConvertTable.IsConvertable(nodeType, target);
            if (ct == ConvType.not_alowed)
                throw new SemanticException(String.Format("{0} Can not convert the type of variable to target", node.Line));
            if (ct != ConvType.none)
                CreateConvertNode(node, ct);
        }

        private void CreateConvertNode(ITree node, ConvType conv)
        {
            AstNode nnode = new ConvertAstNode(AstNodeType.CONVERT, conv);
           // nnode.AddChild(node);
            int pos = node.ChildIndex;
            ITree par = node.Parent;
            par.SetChild(pos, nnode);
            nnode.AddChild(node);
        }

        /// <summary>
        /// Анализ выражения (математическое/пр) которое дает значение 
        /// </summary>
        /// <param name="target">Целевая переменная</param>
        /// <param name="node">Узел для анализа</param>
        /// <param name="context">Контекст программы</param>
        private VariableType AnalizeTerm(ITree node, Context context, int line)
        {
            switch (node.Type)
            {
                //Переменная
                case AstNodeType.IDENT:
                    Variable source = context.FindVar(node.Text); //Ищем переменную в контексте
                    if (source == null) // если нету
                    {
                        Function func = context.findFunc(node.Text); //Ищем функцию
                        if (func == null) // Если нет - ошщибка
                            throw new SemanticException(String.Format("{1} Undefined function or variable {0}", node.Text, node.Line));
                        else
                        {  
                            //Меняем узел
                            AstNode nnode = new AstNode(new CommonToken(AstNodeType.FUNC_CALL, "FUNC_CALL"));
                            nnode.AddChild(new AstNode(new CommonToken(AstNodeType.IDENT, func.Name)));
                            int pos = node.ChildIndex;
                            ITree par = node.Parent;
                            par.SetChild(pos, nnode);
                            //Анализируем снова но уже как фкнкцию
                            return AnalizeTerm(nnode, context, line);
                        }
                    }
                    else //Иначе - если нашли переменную
                        return source.Type;
                    break;
                //Логическая константа
                case AstNodeType.BOOLEAN:
                    return VariableType.BOOL;
                    break;
                //Вызов функции
                #region func_call
                case AstNodeType.FUNC_CALL:
                    {
                        //Ищем функцию
                        Function func = context.findFunc(node.GetChild(0).Text);
                        if (func == null) //не нашли - ошибка
                            throw new SemanticException(String.Format("{1} Undefined function {0}", node.GetChild(0).Text, node.Line));
                        else
                        { 
                            if (node.ChildCount > 1) //Фактические параметры
                            {
                                if (func.ParamsTypes.Count != node.GetChild(1).ChildCount)
                                    throw new SemanticException(String.Format("{1} Unallowed count of parameters in func {0}", func.Name, node.Line));
                                for (int i = 0; i < node.GetChild(1).ChildCount; i++)
                                {
                                    AnalizeConvertTypes(node.GetChild(1).GetChild(i), AnalizeTerm(node.GetChild(1).GetChild(i), context, node.Line), func.ParamsTypes[i]);
                                    //ConvType ct = ConvertTable.IsConvertable(AnalizeTerm(node.GetChild(1).GetChild(i), context, line), func.ParamsTypes[i]);
                                    //if (ct == ConvType.not_alowed)
                                    //    throw new SemanticException(String.Format("{0} Can not convert the parametr of function", node.Line));
                                    //if (ct != ConvType.none)
                                    //    CreateConvertNode(node.GetChild(1).GetChild(i), ct);

                                }
                            }
                            else
                                if (func.ParamsTypes.Count > 0) //нет фактических тно есть формальные
                                    throw new SemanticException(String.Format("{1} Unallowed count of parameters in func {0}", func.Name, node.Line));
                            return func.ReturnType;
                        }
                        break;
                    }
                #endregion
                //Строковая константа
                case AstNodeType.STRING:
                    return VariableType.STRING;
                    break;
                //Числовая константа
                case AstNodeType.NUMBER:
                    NumAstNode n = (NumAstNode)node;
                    if (n.Value != (int)n.Value) return VariableType.FLOAT;
                    else return VariableType.INT;
                    break;
                case AstNodeType.ADD:
                case AstNodeType.SUB:
                case AstNodeType.MUL:
                case AstNodeType.DIV:
                    VariableType t1 = AnalizeTerm(node.GetChild(0), context, line);
                    VariableType t2 = AnalizeTerm(node.GetChild(1), context, line);
                    ConvType f1t2 = ConvertTable.IsConvertable(t1, t2);
                    ConvType f2t1 = ConvertTable.IsConvertable(t2, t1);
                    if (f1t2 == ConvType.not_alowed && f2t1 == ConvType.not_alowed)
                        throw new SemanticException("Can not convert types");
                    if (f1t2 != ConvType.not_alowed && f1t2 != ConvType.none)
                    {
                        CreateConvertNode(node.GetChild(0), f1t2);
                        return t2;
                    } else 
                        if (f2t1 != ConvType.not_alowed && f2t1 != ConvType.none)
                        {
                            CreateConvertNode(node.GetChild(1), f2t1);
                            return t1;
                        }
                    return VariableType.BOOL;
                    break;
                case AstNodeType.COMPARE:
                    if (AnalizeTerm(node.GetChild(0), context, line) != AnalizeTerm(node.GetChild(1), context, line))
                        throw new SemanticException("Illegal comparision");
                    return VariableType.BOOL;
                    break;
                default:
                    return VariableType.BOOL;
            }
        }


        /// <summary>
        /// Анализ выражения
        /// </summary>
        /// <param name="node">Узел для анализа</param>
        /// <param name="context">Контекст программы</param>
        private void AnalizeExpression(ITree node, Context context, int line)
        {
            switch (node.Type)
            {
                //Присваивание
                case AstNodeType.ASSIGN:
                    Variable v = context.FindVar(node.GetChild(0).Text);
                    if (v == null) //переменной нет в контексте
                        throw new SemanticException(String.Format("{1} Undefined variable {0}", node.GetChild(0).Text, node.Line));
                    //Анализ выражения которое присваивается к переменной
                    //ConvType ct = ConvertTable.IsConvertable(AnalizeTerm(node.GetChild(1), context, line), v.Type);
                    //if (ct == ConvType.not_alowed)
                    //    throw new SemanticException(String.Format("{0} Different types in assign", node.Line));
                    //if (ct != ConvType.none)
                    //    CreateConvertNode(node.GetChild(1), ct);
                    AnalizeConvertTypes(node.GetChild(1), AnalizeTerm(node.GetChild(1), context, line), v.Type);
                    //v.Init();
                    break;
                //Блок
                case AstNodeType.BLOCK:
                    //Анализ внутреннего блока имплементации
                    AnalizeImplementation(node, context);
                    break;
                //Идентефикатор
                case AstNodeType.IDENT:
                    if (context.FindVar(node.Text) != null) //Если есть такая переменная то огибка использования
                        throw new SemanticException(String.Format("{1} Illegal use of Variable {0}", node.Text, node.Line));
                    Procedure p = context.findMethod(node.Text);
                    if (p != null) //Есть процедура или функция с таким именем
                    {
                        //Заменяем узел идентефикатора в дереве на ид вызова функции
                        AstNode nnode = new AstNode(new CommonToken(AstNodeType.FUNC_CALL, "FUNC_CALL"));
                        nnode.AddChild(new AstNode(new CommonToken(AstNodeType.IDENT, p.Name)));
                        int pos = node.ChildIndex;
                        ITree par = node.Parent;
                        par.SetChild(pos, nnode);
                        //И анализируем этот же узел с новыми параметрами
                        AnalizeExpression(nnode, context, line);
                    }
                    else
                        throw new SemanticException(String.Format("{1} The {0} function is not found in a curren context", node.Text, node.Line));
                    break;
                //Вызов функции
                case AstNodeType.FUNC_CALL:
                    Procedure proc = context.findMethod(node.GetChild(0).Text);
                    if (proc == null) //нет процедуры - ошибка
                        throw new SemanticException(String.Format("{1} Undefined function or procedure {0}", node.GetChild(0).Text, node.Line));
                    if (node.ChildCount > 1) //Если есть параметры при вызове
                    {
                        if (proc.ParamsTypes.Count != node.GetChild(1).ChildCount) //Если список формальных и фактических различен
                            throw new SemanticException(String.Format("{1} Unallowed count of parameters in func {0}", proc.Name, node.Line));
                        //анализируем каждый параметр который передаем
                        for (int i = 0; i < node.GetChild(1).ChildCount; i++)
                        {
                            //ct = ConvertTable.IsConvertable(AnalizeTerm(node.GetChild(1).GetChild(i), context, line), proc.ParamsTypes[i]);
                            //if (ct == ConvType.not_alowed)
                            //    throw new SemanticException(String.Format("{0} Can not convert the {1} parametr of procedure function", node.Line, i));
                            //if (ct != ConvType.none)
                            //    CreateConvertNode(node.GetChild(1).GetChild(i), ct);
                            //Console.WriteLine(node.GetChild(1).GetChild(i) + " __ " + ct.ToString());
                            AnalizeConvertTypes(node.GetChild(1).GetChild(i), AnalizeTerm(node.GetChild(1).GetChild(i), context, node.Line), proc.ParamsTypes[i]);
                        }
                    }
                    else //нет параметров при вызове
                        if (proc.ParamsTypes.Count > 0) // но есть формальные
                            throw new SemanticException(String.Format("Unallowed count of parameters in func {0}", proc.Name));
                    break;
#warning тут конструкции языка
                case AstNodeType.IF:
                    if (AnalizeTerm(node.GetChild(0), context , node.GetChild(0).Line) != VariableType.BOOL)
                        throw new SemanticException(String.Format("{0} The condition in operator\"if\" only must be BOOLEAN", node.GetChild(0).Line.ToString()));
                        AnalizeExpression(node.GetChild(1), context, node.GetChild(1).Line);

                    if (node.ChildCount == 3)
                        AnalizeExpression(node.GetChild(2), context, node.GetChild(2).Line);
                    break;
                case AstNodeType.WHILE:
                    if (AnalizeTerm(node.GetChild(0), context , node.GetChild(0).Line) != VariableType.BOOL)
                        throw new SemanticException(String.Format("{0} The condition in operator\"while\" only must be BOOLEAN", node.GetChild(0).Line.ToString()));
                        AnalizeExpression(node.GetChild(1), context, node.GetChild(1).Line);
                    break;
                case AstNodeType.DO:
                    if (AnalizeTerm(node.GetChild(1), context , node.GetChild(1).Line) != VariableType.BOOL)
                        throw new SemanticException(String.Format("{0} The condition in operator\"while\" only must be BOOLEAN", node.GetChild(1).Line.ToString()));
                        AnalizeExpression(node.GetChild(0), context, node.GetChild(0).Line);
                    break;
                case AstNodeType.FOR:
                    Variable var = context.FindVar(node.GetChild(0).Text);
                    if (var == null)
                        throw new SemanticException(String.Format("{1} Undefined variable {0}", node.GetChild(0).Text, node.Line));
                    AnalizeConvertTypes(node.GetChild(1), AnalizeTerm(node.GetChild(1), context, node.Line), var.Type);
                    AnalizeConvertTypes(node.GetChild(2), AnalizeTerm(node.GetChild(2), context, node.Line), var.Type);
                    AnalizeExpression(node.GetChild(3), context, node.Line);
                    break;

            }
        }

        /// <summary>
        /// Анализ блока имплементации(в методе или самой программе)
        /// </summary>
        /// <param name="node">Узел для анализа</param>
        /// <param name="context">Контекст программы</param>
        private void AnalizeImplementation(ITree node, Context context)
        {
            if (node.Type != AstNodeType.BLOCK)
                throw new SemanticException("The block expected");
            //Анализ каждого выражения в блоке
            for (int i = 0; i < node.ChildCount; i++)
                AnalizeExpression(node.GetChild(i), context, node.Line);
        }

        /// <summary>
        /// Начало анализа
        /// Создается начальный контекст
        /// Анализируется описание переменных, функций и блока описания
        /// </summary>
        public void Analize()
        {
            Context progContext = new Context();
            if (program.ChildCount < 1 || program.GetChild(program.ChildCount-1).Type != AstNodeType.BLOCK)
                throw new SemanticException("The implementation block expected");
            //Анализ описания переменных
            for (int i = 0; i < program.ChildCount - 1; i++)
                if (program.GetChild(i).Type == AstNodeType.VAR) 
                    AnalizeDefinition(program.GetChild(i), progContext);
            //Анализ описания методов
            for (int i = 0; i < program.ChildCount - 1; i++)
                if (program.GetChild(i).Type == AstNodeType.METHODS) 
                    AnalizeDefinition(program.GetChild(i), progContext);
            //Анализ имплементации
            AnalizeImplementation(program.GetChild(program.ChildCount - 1), progContext);
        }
    }
}
