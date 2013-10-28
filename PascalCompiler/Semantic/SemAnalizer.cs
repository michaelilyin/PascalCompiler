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
            Console.WriteLine("I am a function!!");
            Context currentContext = new Context(context);
            currentContext.PutVar("result", GetTypeFromString(node.GetChild(0).Text));
            Function func = new Function(((FunctionAstNode)node).Name, GetTypeFromString(node.GetChild(0).Text));
            for (int i = 1; i < node.ChildCount - 1; i++)
            {
                if(node.GetChild(i).Type == AstNodeType.PARAMS)
                {
                    Console.WriteLine("~~Analize params");
                    for (int j = 0; j < node.GetChild(i).ChildCount; j++)
                    {
                        func.addParamType(GetTypeFromString(node.GetChild(i).GetChild(j).Text));
                    }
                    AnalizeVariablesDefinition(node.GetChild(i), currentContext);
                }
            }
            for (int i = 1; i < node.ChildCount - 1; i++)
            {
                    if (node.GetChild(i).Type == AstNodeType.VAR)
                    {
                        Console.WriteLine("~~Analize variables");
                        AnalizeVariablesDefinition(node.GetChild(i), currentContext);
                    }
            }
            for (int i = 1; i < node.ChildCount - 1; i++)
            {
                if (node.GetChild(i).Type == AstNodeType.METHODS)
                {
                    Console.WriteLine("~~Analize inner methods");
                    AnalizeMethodsDefinition(node.GetChild(i), currentContext);
                }
            }
            context.PutMethod(func);
            AnalizeImplementation(node.GetChild(node.ChildCount - 1), currentContext);
        }

        private void AnalizeProcedureDefinition(ITree node, Context context)
        {
            Console.WriteLine("I am a procedure!!");
            Context currentContext = context;
            bool contextChanged = false;
            Procedure proc = new Procedure(((ProcedureAstNode)node).Name);
            for (int i = 0; i < node.ChildCount - 1; i++)
            {
                if (node.GetChild(i).Type == AstNodeType.PARAMS) 
                {
                    Console.WriteLine("~~Analize params");
                    if (!contextChanged)
                    {
                        currentContext = new Context(currentContext);
                        contextChanged = true;
                    }
                    for (int j = 0; j < node.GetChild(i).ChildCount; j++)
                    {
                        proc.addParamType(GetTypeFromString(node.GetChild(i).GetChild(j).Text));
                    }
                    AnalizeVariablesDefinition(node.GetChild(i), currentContext);
                }
            }
            for (int i = 0; i < node.ChildCount - 1; i++)
            {
                if (node.GetChild(i).Type == AstNodeType.VAR)
                {
                    Console.WriteLine("~~Analize variables");
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
                        Console.WriteLine("~~Analize inner methods");
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
                Console.WriteLine("Variavles with type {0}", node.GetChild(i).Text);
                string type = node.GetChild(i).Text;
                switch (type)
                {
                    case "integer":
                        for (int v = 0; v < node.GetChild(i).ChildCount; v++)
                        {
                            context.PutVar(node.GetChild(i).GetChild(v).Text, VariableType.INT);
                            Console.WriteLine("Put int variable {0}", node.GetChild(i).GetChild(v).Text);
                        }
                        break;
                    case "boolean":
                        for (int v = 0; v < node.GetChild(i).ChildCount; v++)
                        {
                            context.PutVar(node.GetChild(i).GetChild(v).Text, VariableType.BOOL);
                            Console.WriteLine("Put boolean variable {0}", node.GetChild(i).GetChild(v).Text);
                        }
                        break;
                    case "real":
                        for (int v = 0; v < node.GetChild(i).ChildCount; v++)
                        {
                            context.PutVar(node.GetChild(i).GetChild(v).Text, VariableType.FLOAT);
                            Console.WriteLine("Put float variable {0}", node.GetChild(i).GetChild(v).Text);
                        }
                        break;
                    case "string":
                        for (int v = 0; v < node.GetChild(i).ChildCount; v++)
                        {
                            context.PutVar(node.GetChild(i).GetChild(v).Text, VariableType.STRING);
                            Console.WriteLine("Put string variable {0}", node.GetChild(i).GetChild(v).Text);
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
                    Console.WriteLine("Is methods definitions");
                    AnalizeMethodsDefinition(node, context);
                    break;
                case AstNodeType.VAR:
                    Console.WriteLine("Is variables definitions");
                    AnalizeVariablesDefinition(node, context);
                    break;
                default:
                    throw new SemanticException("Unknown definition member");
            }
        }

        private void AnalizeTerm(Variable target, ITree node, Context context)
        {
            switch (node.Type)
            {
                case AstNodeType.IDENT:
                    Variable source = context.FindVar(node.Text);
                    if (source == null)
                    {
                        Function func = context.findFunc(node.Text);
                        if (func == null)
                            throw new SemanticException(String.Format("Undefined function or variable {0}", node.Text));
                        else
                        {
                            if (func.ReturnType > target.Type || (func.ReturnType == VariableType.BOOL && target.Type != VariableType.BOOL))
                                throw new SemanticException(String.Format("Coud not assign the return function value to {0} variable", target.Type));
                            //node.Type = AstNodeType.FUNC_CALL;
                            //node.
                            AstNode nnode = new AstNode(new CommonToken(AstNodeType.FUNC_CALL, "FUNC_CALL"));
                            nnode.AddChild(new AstNode(new CommonToken(AstNodeType.IDENT, func.Name)));
                            int pos = node.ChildIndex;
                            Console.WriteLine(pos + "!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!");
                            ITree par = node.Parent;
                            par.SetChild(pos, nnode);
                            AnalizeTerm(target, nnode, context);
#warning ololo
                        }
                    }
                    else
                    {
                        //    if (!source.IsInit)
                        //        throw new SemanticException(String.Format("The variable {0} is not initialized", source.Name));
                        if (source.Type > 0 && target.Type > 0)
                        {
                            if (source.Type > target.Type)
                                throw new SemanticException(String.Format("Illegal assign {0} to {1}", source.Type.ToString(), target.Type.ToString()));
                        }
                        else
                            if (!(source.Type == VariableType.BOOL && target.Type == VariableType.BOOL))
                                throw new SemanticException("Illegal assign bool and none bool");
                    }
                    break;
                case AstNodeType.BOOLEAN:
                    if (target.Type != VariableType.BOOL)
                        throw new SemanticException("The boolean value must be assignrd only to bolean variable");
                    break;
                case AstNodeType.FUNC_CALL:
                    {
                        Function func = context.findFunc(node.GetChild(0).Text);
#warning check params
                        //проверить параметры!
                        if (func == null)
                            throw new SemanticException(String.Format("Undefined function {0}", node.GetChild(0).Text));
                        else
                            if (func.ReturnType > target.Type || (func.ReturnType == VariableType.BOOL && target.Type != VariableType.BOOL))
                                throw new SemanticException(String.Format("Coud not assign the return function value to {0} variable", target.Type));
                        break;
                    }
                case AstNodeType.STRING:
                    if (target.Type != VariableType.STRING)
                        throw new SemanticException("The string value must be assigned only to string variable");
                    break;
                case AstNodeType.NUMBER:
                    NumAstNode n = (NumAstNode)node;
                    switch (target.Type)
                    {
                        case VariableType.INT:
                            if (n.Value != (int)n.Value)
                                throw new SemanticException(String.Format("Can not convert {0} value to integer", n.Value));      
                            break;
                        case VariableType.FLOAT:
                            break;
                        case VariableType.STRING:
                            break;
                        default:
                            throw new SemanticException(String.Format("Can not assign {0} value to variable {1}:{2}", n.Value, target.Name, target.Type));
                    }
                    break;
                case AstNodeType.ADD:
                    AnalizeTerm(target, node.GetChild(0), context);
                    AnalizeTerm(target, node.GetChild(1), context);
                    break;
                case AstNodeType.SUB:
                    AnalizeTerm(target, node.GetChild(0), context);
                    AnalizeTerm(target, node.GetChild(1), context);
                    break;
                case AstNodeType.MUL:
                    AnalizeTerm(target, node.GetChild(0), context);
                    AnalizeTerm(target, node.GetChild(1), context);
                    break;
                case AstNodeType.DIV:
                    AnalizeTerm(target, node.GetChild(0), context);
                    AnalizeTerm(target, node.GetChild(1), context);
                    break;
                case AstNodeType.COMPARE:
                    break;
            }
        }

        private void AnalizeExpression(ITree node, Context context)
        {
            switch (node.Type)
            {
                case AstNodeType.ASSIGN:
                    Variable v = context.FindVar(node.GetChild(0).Text);
                    if (v == null)
                        throw new SemanticException(String.Format("Undefined variable {0}", node.GetChild(0).Text));
                    AnalizeTerm(v, node.GetChild(1), context);
                    //v.Init();
                    break;
                case AstNodeType.BLOCK:
                    Console.WriteLine("Inner block");
                    AnalizeImplementation(node, context);
                    break;
                case AstNodeType.IDENT:
                    if (context.FindVar(node.Text) != null)
                        throw new SemanticException(String.Format("Illegal use of Variable {0}", node.Text));
                    Procedure p = context.findMethod(node.Text);
                    if (p != null)
                    {
#warning заменить узел на FUNC_CALL и проанализировать
                    }
                    else
                        throw new SemanticException(String.Format("The {0} function is not found in a curren context", node.Text));
                    break;
                case AstNodeType.FUNC_CALL:
#warning function parameters
                    Procedure proc = context.findMethod(node.GetChild(0).Text);
                    if (proc == null)
                        throw new SemanticException(String.Format("Undefined function or procedure {0}", node.GetChild(0).Text));
                    if (proc.ParamsTypes.Count != node.GetChild(1).ChildCount)
                        throw new SemanticException(String.Format("Unallowed count of parameters in func {0}", proc.Name));
                    for (int i = 0; i < node.GetChild(1).ChildCount; i++)
                    {
                        Variable par = context.FindVar(node.GetChild(1).GetChild(i).Text);
                        if (par == null) 
                            throw new SemanticException(String.Format("Undefined variable {0}", node.GetChild(1).GetChild(i).Text));
                        if (par.Type > proc.ParamsTypes[i]
                            || (par.Type == VariableType.BOOL && proc.ParamsTypes[i] != VariableType.BOOL))
                            throw new SemanticException("NESOVMESTIMIE PARAMETRI V ROT IH!");
                    }
                    break;
            }
        }

        private void AnalizeImplementation(ITree node, Context context)
        {
            if (node.Type != AstNodeType.BLOCK)
                throw new SemanticException("The block expected");
            Console.WriteLine("This block has {0} operations", node.ChildCount);
            for (int i = 0; i < node.ChildCount; i++)
            {
                AnalizeExpression(node.GetChild(i), context);
            }
        }

        public void Analize()
        {
            Context progContext = new Context();
            Console.WriteLine("Sem analize started");
            Console.WriteLine("The program has {0} childs", program.ChildCount);
            if (program.ChildCount < 1 || program.GetChild(program.ChildCount-1).Type != AstNodeType.BLOCK)
                throw new SemanticException("The implementation block expected");
            for (int i = 0; i < program.ChildCount - 1; i++)
            {
                if (program.GetChild(i).Type == AstNodeType.VAR) 
                {
                    Console.WriteLine("Analize {0} program children", i);
                    AnalizeDefinition(program.GetChild(i), progContext);
                }
            }
            for (int i = 0; i < program.ChildCount - 1; i++)
            {
                if (program.GetChild(i).Type == AstNodeType.METHODS) 
                {
                    Console.WriteLine("Analize {0} program children", i);
                    AnalizeDefinition(program.GetChild(i), progContext);
                }
            }
            AnalizeImplementation(program.GetChild(program.ChildCount - 1), progContext);
        }
    }
}
