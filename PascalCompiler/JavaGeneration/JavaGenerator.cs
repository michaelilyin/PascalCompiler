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

        private int whileCondCount;
        private int forCondCount;
        private int thenCount, endIfCount;
        private int boolFirstCount, boolSecondCount;
        private Stack<string> whileCondStack;
        private Stack<int> whileBodyStack;
        private Stack<int> doBodyStack;
        private Stack<string> forCondStack;
        private Stack<int> forBodyStack;

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
                    return "F";
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

        private GenType VarTypeToGenType(string v)
        {
            switch (v)
            {
                case "Z":
                    return GenType.@bool;
                case "F":
                    return GenType.@float;
                case "I":
                    return GenType.@int;
                case "V":
                    return GenType.@void;
                default:
                    return GenType.none;
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

        private string PasType(GenType genType)
        {
            switch (genType)
            {
                case GenType.@int:
                    return "integer";
                    break;
                case GenType.@float:
                    return "real";
                    break;
                case GenType.@bool:
                    return "boolean";
                    break;
                default:
                    return "";
            }
        }

        private string JavaPrefixes(GenType genType)
        {
            switch (genType)
            {
                case GenType.@int:
                    return "i";
                    break;
                case GenType.@float:
                    return "f";
                    break;
                case GenType.@bool:
                    return "z";
                    break;
                default:
                    return "";
            }
        }

        public enum GenType { @int, @float, @bool, @string, @void, none }

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

        private bool GenerateSysCall(ITree node, Context context, out GenType t)
        {
            if (node.Type == AstNodeType.FUNC_CALL)
            {
                switch (node.GetChild(0).Text)
                {
                    case "writeln":
                        jasmin.Append(string.Format("   getstatic java/lang/System/out Ljava/io/PrintStream;\n"));
                        GenType tt = Generate(node.GetChild(1).GetChild(0), context);
                        jasmin.Append(string.Format("   invokevirtual java/io/PrintStream/println({0})V\n", JavaTypes(PasType(tt))));
                        t = GenType.@void;
                        return true;
                    //case "write":
                    //    Generate(node.GetChild(1).GetChild(0), context);
                    //    msil.Append(string.Format("        IL_{0:X4}: call void [mscorlib]System.Console::Write(string)\n", strIndex++));
                    //    msil.Append(string.Format("        IL_{0:X4}: nop\n\n", strIndex++));
                    //    t = GenType.@void;
                    //    return true;
                    //case "readln":
                    //    msil.Append(string.Format("        IL_{0:X4}: call string [mscorlib]System.Console::ReadLine()\n", strIndex++));
                    //    msil.Append(string.Format("        IL_{0:X4}: nop\n\n", strIndex++));
                    //    t = GenType.@string;
                    //    return true;
                }
            }
            t = GenType.none;
            return false;
        }

        private GenType Generate(ITree node, Context context) { 
            switch (node.Type) {

                case AstNodeType.BLOCK:
                    for (int i = 0; i < node.ChildCount; i++)
                        Generate(node.GetChild(i), context);
                    return GenType.none;


                case AstNodeType.ASSIGN:
                    Variable v = context.FindVar(node.GetChild(0).Text);
                   
                    Generate(node.GetChild(1), context);
                    jasmin.Append(string.Format("   putstatic {1} {0}\n\n", v.Type, v.FullName));
                    return GenType.none;

                case AstNodeType.CONVERT:
                    GenType tt = Generate(node.GetChild(0), context);
                    switch (((ConvertAstNode)node).Type)
                    {
                        case Semantic.ProgramContext.Variables.ConvType.int_to_float:
                            jasmin.Append(String.Format("   i2f\n"));
                            return GenType.@float;
                    }
                    return tt;

                case AstNodeType.NUMBER:
                    int num;
                    if (Int32.TryParse(((NumAstNode)node).ToString(), out num))
                    {
                        jasmin.Append(string.Format("   iconst_{0}\n", ((NumAstNode)node).ToString()));
                        return GenType.@int;
                    }
                    else
                    {
                        jasmin.Append(string.Format("   fconst_{0}\n", ((NumAstNode)node).ToString()));
                        return GenType.@float;
                    }
                case AstNodeType.FUNC_CALL:
                    GenType __t;
                    if (GenerateSysCall(node, context, out __t))
                    {
                        return __t;
                    }
                    return GenType.none;
                case AstNodeType.BOOLEAN:
                    if (node.Text == "true")
                        jasmin.Append(string.Format("   iconst_0\n")); 
                    else
                        jasmin.Append(string.Format("   iconst_1\n"));
                    return GenType.@bool;

                case AstNodeType.IDENT:
                    v = context.FindVar(node.Text);
                    //LoadFieldData(context, v.Name);
                    //msil.Append(string.Format("        IL_{0:X4}: ldarg.0\n", strIndex++));
                    jasmin.Append(string.Format("   getstatic {1} {0} \n", v.Type, v.FullName));
                    return VarTypeToGenType(v.Type);

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
                    GenType t = Generate(node.GetChild(0), context);
                    Generate(node.GetChild(1), context);
                    jasmin.Append(string.Format("   {0}{1}\n",JavaPrefixes(t),  oper));
                    return t;

                case AstNodeType.IF:
                    Generate(node.GetChild(0), context);
                    jasmin.Append(string.Format("   ifeq THEN_{0:X4}\n\n", thenCount++));
                    if (node.ChildCount == 3)
                        Generate(node.GetChild(2), context);
                    jasmin.Append(string.Format("   goto ENDIF_{0:X4}\n\n",  endIfCount++));
                    jasmin.Append(String.Format("   THEN_{0:X4}:\n", --thenCount));
                    Generate(node.GetChild(1), context);
                    //wat?
                    jasmin.Append(String.Format("   ENDIF_{0:X4}:\n", --endIfCount));
                    return GenType.none;

                case AstNodeType.WHILE:
                    //whileCondStack.Push(string.Format("while_{0}", whileCondCount++));
                    //jasmin.Append(string.Format("goto {1}\n", strIndex++, whileCondStack.Peek()));
                    //whileBodyStack.Push(strIndex);
                    //Generate(node.GetChild(1), context);
                    //jasmin.Replace(whileCondStack.Pop(), string.Format("IL_{0:X4}", strIndex));
                    //whileCondCount--;
                    //Generate(node.GetChild(0), context);
                    //jasmin.Append(string.Format("        IL_{0:X4}: ifeq IL_{1:X4}\n\n", strIndex++, whileBodyStack.Pop()));
                    return GenType.none;
                default:
                    return GenType.none;

            }

        }

        

        public override string Generate()
        {
            Console.WriteLine(program);
            Context context = new Context(null, "Program");
            jasmin.Append(String.Format(".class public Program\n") );
            jasmin.Append(String.Format(".super java/lang/Object\n") );

            GenerateVars(program, context);

            jasmin.Append(@"
.method public <init>()V
    .limit stack 1
    .limit locals 1
    aload_0               
    invokespecial java/lang/Object/<init>()V
    return                
.end method              
");

            jasmin.Append(@"
.method public static main([Ljava/lang/String;)V
    .limit stack 3000
    .limit locals 1
");
            Generate(program.GetChild(program.ChildCount - 1), context);
            jasmin.Append(@"
    return                
.end method  ");
            return jasmin.ToString();
        }



    }
}