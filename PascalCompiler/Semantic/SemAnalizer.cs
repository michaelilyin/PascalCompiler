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

        private void AnalizeExpression(ITree node)
        {

        }

        private void AnalizeImplementation(ITree node)
        {
            if (node.Type != AstNodeType.BLOCK)
                throw new SemanticException("The block expected");
            for (int i = 0; i < node.ChildCount; i++)
            {
                AnalizeExpression(node);
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
            AnalizeImplementation(program.GetChild(program.ChildCount - 1));
            AnalizeNode(program);
        }
    }
}
