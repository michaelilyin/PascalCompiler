using Antlr.Runtime.Tree;
using PascalCompiler.MSILGeneration.GenerationContext;
using PascalCompiler.MSILGeneration.GenerationContext.Variables;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using AstNodeType = PascalCompiler.PascalGrammarParser;

namespace PascalCompiler.MSILGeneration
{
    class MSILGenerator
    {
        private ITree program;
        private StringBuilder msil;
        private int strIndex;

        public MSILGenerator(ITree program) 
        {
            this.program = program;
            msil = new StringBuilder("");
        }

        private void GenerateGlobalVars(Context context)
        {
            for (int i = 0; i < program.ChildCount; i++)
            {
                ITree node = program.GetChild(i);
                if (node.Type == AstNodeType.VAR)
                {
                    for (int j = 0; j < node.ChildCount; j++)
                    {
                        string type = "";
                        switch (node.GetChild(j).Text)
                        {
                            case "integer":
                                type = "int32";
                                break;
                            case "real":
                                type = "float32";
                                break;
                            case "boolean":
                                type = "bool";
                                break;
                            case "string":
                                type = "string";
                                break;
                        }
                        msil.Append(String.Format(@"    .field private static {0} ", type));
                        for (int k = 0; k < node.GetChild(j).ChildCount; k++)
                        {
                            if (k != 0)
                                msil.Append(", ");
                            msil.Append(node.GetChild(j).GetChild(k).Text);
                            context.AddVar(node.GetChild(j).GetChild(k).Text, type);
                        }
                        msil.Append(";\n");
                    }
                }
            }
        }

        private void Generate(ITree node, Context context) 
        {
            switch (node.Type)
            {
                case AstNodeType.BLOCK:
                    for (int i = 0; i < node.ChildCount; i++)
                        Generate(node.GetChild(i), context);
                    break;
                case AstNodeType.ASSIGN:
                    Generate(node.GetChild(1), context);
                    Variable v = context.FindVar(node.GetChild(0).Text);
                    msil.Append(string.Format("        IL_{0:X4}: stsfld {1} {2}\n", strIndex++, v.Type, v.FullName));
                    break;
                case AstNodeType.ADD:
                case AstNodeType.SUB:
                case AstNodeType.MUL:
                case AstNodeType.DIV:
                    string oper = node.Type == AstNodeType.ADD ? "add" :
                                  node.Type == AstNodeType.SUB ? "sub" :
                                  node.Type == AstNodeType.MUL ? "mul" :
                                  node.Type == AstNodeType.DIV ? "div" :
                                  "unknown";

                    Generate(node.GetChild(0), context);
                    Generate(node.GetChild(1), context);
                    msil.Append(string.Format("        IL_{0:X4}: {1}\n", strIndex++, oper));
                    break;
                case AstNodeType.NUMBER:
                    int num;
                    if (Int32.TryParse(((NumAstNode)node).ToString(), out num))
                        msil.Append(string.Format("        IL_{0:X4}: ldc.i4.s {1}\n", strIndex++, ((NumAstNode)node).ToString()));
                    else
                        msil.Append(string.Format("        IL_{0:X4}: ldc.r4 {1}\n", strIndex++, ((NumAstNode)node).ToString()));
                    break;
                case AstNodeType.BOOLEAN:
                    if (node.Text == "true")
                        msil.Append(string.Format("        IL_{0:X4}: ldc.i4.1\n", strIndex++));
                    else
                        msil.Append(string.Format("        IL_{0:X4}: ldc.i4.0\n", strIndex++));
                    break;
                case AstNodeType.STRING:
                    msil.Append(string.Format("        IL_{0:X4}: ldstr \"{1}", strIndex++, ((StringAstNode)node).Value)).Append("\"\n");
                    break;
            }
        }

        private void Generate()
        {
            Context context = new Context(null, "Program");
            msil = new StringBuilder();
            strIndex = 0;
            msil.Append(@"
.assembly program
{
}

.class public Program
{   
");
            GenerateGlobalVars(context);
            msil.Append(@"
    .method public static void Main() cil managed
    {
        .entrypoint
    
");
            Generate(program.GetChild(program.ChildCount - 1), context);
            msil.Append(string.Format("        IL_{0:X4}: ret", strIndex++));
            msil.Append(@"
    }
}
");
        }

        public static string GenerateMSIL(ITree programNode)
        {
            MSILGenerator g = new MSILGenerator(programNode);
            g.Generate();
            return g.msil.ToString();
        }
    }
}
