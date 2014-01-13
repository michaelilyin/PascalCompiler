using Antlr.Runtime.Tree;
using PascalCompiler.MSILGeneration.GenerationContext;
using PascalCompiler.MSILGeneration.GenerationContext.Variables;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using AstNodeType = PascalCompiler.PascalGrammarParser;


namespace PascalCompiler.JavaGeneration
{
    class JavaGenerator : Generator
    {
        private StringBuilder jasmin;
        public JavaGenerator(ITree program)
            : base(program)
        {
            jasmin = new StringBuilder("");
        }


        private string JavaTypes(String pasType)
        {
            switch (pasType)
            {
                case "integer":
                    return "I";
                    break;
                case "real":
                    return "float";
                    break;
                case "boolean":
                    return "Z";
                    break;
                case "string":
                    return "String";
                    break;
                default:
                    return "";
            }
        }

        private string JavaPrefixes(String pasType)
        {
            switch (pasType)
            {
                case "integer":
                    return "i";
                    break;
                case "real":
                    return "f";
                    break;
                case "boolean":
                    return "z";
                    break;
          
                default:
                    return "";
            }
        }


        private void GenerateVars(ITree root, Context context)
        {
            for (int i = 0; i < root.ChildCount; i++)
            {
                ITree node = root.GetChild(i);
                if (node.Type == AstNodeType.VAR)
                {
                    for (int j = 0; j < node.ChildCount; j++)
                    {
                        string type = JavaTypes(node.GetChild(j).Text);
                        for (int k = 0; k < node.GetChild(j).ChildCount; k++)
                        {
                            jasmin.Append(String.Format(".field private static {1} {0}\n", type, node.GetChild(j).GetChild(k).Text));
                            context.AddVar(node.GetChild(j).GetChild(k).Text, type);
                        }
                    }
                }
            }
        }



        private void Generate(ITree node, Context context) { 
            switch (node.Type) {

                case AstNodeType.BLOCK:
                    for (int i = 0; i < node.ChildCount; i++)
                        Generate(node.GetChild(i), context);
                    break;


                case AstNodeType.ASSIGN:
                    Variable v = context.FindVar(node.GetChild(0).Text);
                   
                    Generate(node.GetChild(1), context);
                    jasmin.Append(string.Format("putstatic {1} {0}\n\n", v.Type, v.FullName));
                    break;

                case AstNodeType.NUMBER:
                    int num;
                    if (Int32.TryParse(((NumAstNode)node).ToString(), out num))
                        
                        jasmin.Append(string.Format("iconst_{0}\n", ((NumAstNode)node).ToString()) ); 
                    else
                        jasmin.Append(string.Format("fconst_{0}\n", ((NumAstNode)node).ToString())); 
                    break;

                case AstNodeType.BOOLEAN:
                    if (node.Text == "true")
                        jasmin.Append(string.Format("iconst_0\n")); 
                    else
                        jasmin.Append(string.Format("iconst_1\n")); 
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
#warning expect new version with type
                    Generate(node.GetChild(0), context);
                    Generate(node.GetChild(1), context);
                    jasmin.Append(string.Format("{0}{1}\n",JavaPrefixes(null),  oper));
                    break;

            }

        }

        

        public override string Generate()
        {
            Console.WriteLine(program);
            Context context = new Context(null, "Program");
            jasmin.Append(String.Format(".class     public Program\n") );
            jasmin.Append(String.Format(".super     java/lang/Object\n") );

            GenerateVars(program, context);

            jasmin.Append(
                    @"
                   .method                  public <init>()V
                        .limit stack          1
                        .limit locals         1
                        aload_0               
                        invokespecial         java/lang/Object/<init>()V
                        return                
                   .end method              
            ");

            jasmin.Append(@".method                  public static main([Ljava/lang/String;)V
                    .limit stack          1
                    .limit locals         1
            ");
            Generate(program.GetChild(program.ChildCount - 1), context);
            jasmin.Append(@" return                
                    .end method  ");
            return jasmin.ToString();
        }



    }
}
