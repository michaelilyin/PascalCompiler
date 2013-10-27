using Antlr.Runtime.Tree;
using PascalCompiler.Semantic.ProgramContext;
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

        private void AnalizeNode(ITree node)
        {

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
                        //find func
                        throw new SemanticException(String.Format("Undefined function or variable {0}", node.Text));
                    else
                        if (!source.IsInit)
                            throw new SemanticException(String.Format("The variable {0} is not initialized", source.Name));
                    if (source.Type > 0 && target.Type > 0)
                    {
                        if (source.Type > target.Type)
                            throw new SemanticException(String.Format("Illegal assign {0} to {1}", source.Type.ToString(), target.Type.ToString()));
                    }
                    else
                        if (!(source.Type == VariableType.BOOL && target.Type == VariableType.BOOL))
                            throw new SemanticException("Illegal assign bool and none bool");
                    break;
                case AstNodeType.BOOLEAN:
                    if (target.Type != VariableType.BOOL)
                        throw new SemanticException("The boolean value must be assignrd only to bolean variable");
                    break;
                case AstNodeType.FUNC_CALL:
                    break;
                case AstNodeType.STRING:
                    if (target.Type != VariableType.STRING)
                        throw new SemanticException("The string value must be assigned only to string variable");
                    break;
                case AstNodeType.NUMBER:
                    NumAstNode n = (NumAstNode)node;
                    switch (target.Type)
                    {
                        case VariableType.INT:
                            try
                            {
                                int a = Convert.ToInt32(n.Value);
                            }
                            catch (Exception ex)
                            {
                                throw new SemanticException(String.Format("Can not convert {0} value to integer", n.Value));
                            }
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
                    v.Init();
                    break;
                case AstNodeType.BLOCK:
                    Console.WriteLine("Inner block");
                    AnalizeImplementation(node, context);
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
                Console.WriteLine("Analize {0} program children", i);
                AnalizeDefinition(program.GetChild(i), progContext);
            }
            AnalizeImplementation(program.GetChild(program.ChildCount - 1), progContext);
            AnalizeNode(program);
        }
    }
}
