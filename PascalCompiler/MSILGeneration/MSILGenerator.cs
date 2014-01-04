using Antlr.Runtime.Tree;
using PascalCompiler.MSILGeneration.GenerationContext;
using PascalCompiler.MSILGeneration.GenerationContext.Methods;
using PascalCompiler.MSILGeneration.GenerationContext.Variables;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using AstNodeType = PascalCompiler.PascalGrammarParser;

namespace PascalCompiler.MSILGeneration
{
    class MSILGenerator : Generator
    {
        private StringBuilder msil;
        private int strIndex;

        private int whileCondCount;
        private int forCondCount;
        private Stack<string> whileCondStack;
        private Stack<int> whileBodyStack;
        private Stack<int> doBodyStack;
        private Stack<string> forCondStack;
        private Stack<int> forBodyStack;

        public MSILGenerator(ITree program) 
            : base(program)
        {
            msil = new StringBuilder("");
        }

        private string ToCSTypes(String pasType)
        {
            switch (pasType)
            {
                case "integer":
                    return "int32";
                    break;
                case "real":
                    return "float32";
                    break;
                case "boolean":
                    return "bool";
                    break;
                case "string":
                    return "string";
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
                        string type = ToCSTypes(node.GetChild(j).Text);      
                        for (int k = 0; k < node.GetChild(j).ChildCount; k++)
                        {
                            msil.Append(String.Format("    .field private {0} {1}\n", type, node.GetChild(j).GetChild(k).Text));
                            context.AddVar(node.GetChild(j).GetChild(k).Text, type);
                        }
                    }
                }
            }
        }

        private void GenerateMethods(ITree node, Context context)
        {
            for (int i = 0; i < node.ChildCount; i++)
            {
                ITree child = node.GetChild(i);
                if (child.Type == AstNodeType.METHODS)
                {
                    for (int j = 0; j < child.ChildCount; j++)
                    {
                        ITree m = child.GetChild(j);
                        int ind = 0;
                        string ret = "";
                        string name = "";
                        if (m.Type == AstNodeType.FUNCTION)
                        {
                            ret = ToCSTypes(m.GetChild(ind++).Text);
                            name = ((FunctionAstNode)m).Name;
                        }
                        else
                        {
                            ret = "void";
                            name = ((ProcedureAstNode)m).Name;
                        }
                        msil.Append(String.Format("\n.class auto ansi nested private beforefieldinit {0} extends [mscorlib]System.Object\n", name));
                        msil.Append(@"{
");                     
                        List<string> types = new List<string>();
                        ITree nod = m.GetChild(ind);
                        if (nod.Type == AstNodeType.PARAMS)
                        {
                            for (int k = 0; k < nod.ChildCount; k++)
                            {
                                ITree type = nod.GetChild(k);
                                for (int d = 0; d < type.ChildCount; d++)
                                {
                                    types.Add(ToCSTypes(type.Text));
                                }
                            }
                            ind++;
                        }
                        context.AddMeth(name, types, ret);
                        Context nCon = new Context(context, name);
                        if (m.Type == AstNodeType.FUNCTION)
                        {
                            nCon.AddVar("result", ret);
                            msil.Append(String.Format("    .field private {0} {1}\n", ret, "result"));
                        }
                        GenerateVars(m, nCon);
                        msil.Append(String.Format("    .field private class {0} __p__\n", context.ContextName));
                        nCon.AddVar("__p__", context.ContextName);
                        GenerateMethods(m, nCon);

                        msil.Append(String.Format("    .method public hidebysig instance {0} Run(class {1}) cil managed\n", ret, context.ContextName));
                        msil.Append("   {\n");
/*--- */                       GenerateLocalMethods(nCon);
                        msil.Append(string.Format("        IL_{0:X4}: ldarg.0\n", strIndex++));
                        msil.Append(string.Format("        IL_{0:X4}: ldarg.1\n", strIndex++));
                        msil.Append(string.Format("        IL_{0:X4}: stfld class {1} {2}\n\n", strIndex++, context.ContextName, nCon.FindVar("__p__").FullName));
                        Generate(m.GetChild(m.ChildCount - 1), nCon);
                        if (m.Type == AstNodeType.FUNCTION)
                        {
                            msil.Append(string.Format("        IL_{0:X4}: ldarg.0\n", strIndex++));
                            Variable v = nCon.FindVar("result");
                            msil.Append(string.Format("        IL_{0:X4}: ldfld {1} {2}\n", strIndex++, v.Type, v.FullName));
                        }
                        msil.Append(string.Format("        IL_{0:X4}: ret\n", strIndex++));
                        msil.Append("   }\n");
                        msil.Append(@"
    .method public hidebysig specialname rtspecialname instance void .ctor() cil managed
    {
        IL_0000:  ldarg.0
        IL_0001:  call instance void [mscorlib]System.Object::.ctor()
        IL_0003:  ret
    }
}
");
                    }
                }
            }
        }

        private void LoadFieldData(Context context, String name)
        {
            msil.Append(string.Format("        IL_{0:X4}: ldarg.0\n", strIndex++));
            while (!context.ContainsVar(name))
            {
                msil.Append(string.Format("        IL_{0:X4}: ldfld class {1} {2}\n", strIndex++, context.ParentContext.ContextName, context.FindVar("__p__").FullName));
                context = context.ParentContext;
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
                    Variable v = context.FindVar(node.GetChild(0).Text);
                    //msil.Append(string.Format("        IL_{0:X4}: ldarg.0\n", strIndex++));
                    LoadFieldData(context, v.Name);
                    Generate(node.GetChild(1), context);                    
                    msil.Append(string.Format("        IL_{0:X4}: stfld {1} {2}\n\n", strIndex++, v.Type, v.FullName));
                    break;
#region math
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
#endregion
#region constants
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
#endregion
                case AstNodeType.IDENT:
                    v = context.FindVar(node.Text);
                    LoadFieldData(context, v.Name);
                    //msil.Append(string.Format("        IL_{0:X4}: ldarg.0\n", strIndex++));
                    msil.Append(string.Format("        IL_{0:X4}: ldfld {1} {2} \n", strIndex++, v.Type, v.FullName));
                    break;
                case AstNodeType.FUNC_CALL:
#warning TODO function calls
#warning Outer context access
                    if (node.GetChild(0).Text == "write")
                    {
                        Generate(node.GetChild(1).GetChild(0), context);
                        msil.Append(string.Format("        IL_{0:X4}: call void [mscorlib]System.Console::WriteLine(string)\n", strIndex++));
                        msil.Append(string.Format("        IL_{0:X4}: nop\n\n", strIndex++));
                    } 
                    else
                    {
                        Method m = context.FindMethod(node.GetChild(0).Text);
                        int ind = context.MethodsCash.IndexOf(m);
                        msil.Append(string.Format("        IL_{0:X4}: newobj instance void {1}::.ctor()\n", strIndex++, m.FullName));
                        msil.Append(string.Format("        IL_{0:X4}: ldarg.0\n", strIndex++));
                        msil.Append(string.Format("        IL_{0:X4}: call instance {1} {2}::Run(class {3})\n\n", strIndex++, m.Type, m.FullName, context.ContextName));
                    }
                    break;
#region convert
                case AstNodeType.CONVERT:
                    //Generate(node.GetChild(0), context);
#warning TODO notmal universal convertion
                    switch (node.GetChild(0).Type)
                    {
                        case AstNodeType.IDENT:
                            v = context.FindVar(node.GetChild(0).Text);
                            LoadFieldData(context, v.Name);
                            //msil.Append(string.Format("        IL_{0:X4}: ldarg.0\n", strIndex++));
                            msil.Append(string.Format("        IL_{0:X4}: ldflda {1} {2} \n", strIndex++, v.Type, v.FullName));
                            break;
                    }
                    switch (((ConvertAstNode)node).Type)
                    {
                        case Semantic.ProgramContext.Variables.ConvType.bool_to_str:
                            //v = context.FindVar(node.GetChild(0).Text);
                            //msil.Append(String.Format("        IL_{0:X4}: ldsflda {1} {2}\n", strIndex++, v.Type, v.FullName));
                            msil.Append(String.Format("        IL_{0:X4}: call instance string [mscorlib]System.Boolean::ToString()\n", strIndex++));
                            break;
                        case Semantic.ProgramContext.Variables.ConvType.float_to_str:
                            //v = context.FindVar(node.GetChild(0).Text);
                            //msil.Append(String.Format("        IL_{0:X4}: ldsflda {1} {2}\n", strIndex++, v.Type, v.FullName));
                            msil.Append(String.Format("        IL_{0:X4}: call instance string [mscorlib]System.Single::ToString()\n", strIndex++));
                            break;
                        case Semantic.ProgramContext.Variables.ConvType.int_to_str:
                            //v = context.FindVar(node.GetChild(0).Text);
                            //msil.Append(String.Format("        IL_{0:X4}: ldsflda {1} {2}\n", strIndex++, v.Type, v.FullName));
                            msil.Append(String.Format("        IL_{0:X4}: call instance string [mscorlib]System.Int32::ToString()\n", strIndex++));
                            break;
                        case Semantic.ProgramContext.Variables.ConvType.int_to_float:
                            //v = context.FindVar(node.GetChild(0).Text);
                            //msil.Append(String.Format("        IL_{0:X4}: ldsfld {1} {2}\n", strIndex++, v.Type, v.FullName));
                            msil.Append(String.Format("        IL_{0:X4}: conv.r4\n", strIndex++));
                            break;
                    }
                    break;
#endregion
#region comparision
                case AstNodeType.COMPARE:
                    Generate(node.GetChild(0), context);
                    Generate(node.GetChild(1), context);
                    switch (node.Text)
                    {
                        case ">":
                            msil.Append(string.Format("        IL_{0:X4}: cgt\n", strIndex++));
                            break;
                        case "<":
                            msil.Append(string.Format("        IL_{0:X4}: clt\n", strIndex++));
                            break;
                        case "=":
                            msil.Append(string.Format("        IL_{0:X4}: ceq\n", strIndex++));
                            break;
                        case "<>":
                            msil.Append(string.Format("        IL_{0:X4}: ceq\n", strIndex++));
                            msil.Append(string.Format("        IL_{0:X4}: ldc.i4.0\n", strIndex++));
                            msil.Append(string.Format("        IL_{0:X4}: ceq\n", strIndex++));
                            break;
                        case ">=":
                            msil.Append(string.Format("        IL_{0:X4}: clt\n", strIndex++));
                            msil.Append(string.Format("        IL_{0:X4}: ldc.i4.0\n", strIndex++));
                            msil.Append(string.Format("        IL_{0:X4}: ceq\n", strIndex++));
                            break;
                        case "<=":
                            msil.Append(string.Format("        IL_{0:X4}: cgt\n", strIndex++));
                            msil.Append(string.Format("        IL_{0:X4}: ldc.i4.0\n", strIndex++));
                            msil.Append(string.Format("        IL_{0:X4}: ceq\n", strIndex++));
                            break;
                    }
                    break;
#endregion
#region loops
                case AstNodeType.WHILE:
                    whileCondStack.Push(string.Format("while_{0}", whileCondCount++));
                    msil.Append(string.Format("        IL_{0:X4}: br.s {1}\n", strIndex++, whileCondStack.Peek()));
                    whileBodyStack.Push(strIndex);
                    Generate(node.GetChild(1), context);
                    msil.Replace(whileCondStack.Pop(), string.Format("IL_{0:X4}", strIndex));
#warning incrementation
                    whileCondCount--; 
                    Generate(node.GetChild(0), context);
                    msil.Append(string.Format("        IL_{0:X4}: brtrue.s IL_{1:X4}\n\n", strIndex++, whileBodyStack.Pop()));
                    break;
                case AstNodeType.DO:
                    doBodyStack.Push(strIndex);
                    Generate(node.GetChild(0), context);
                    Generate(node.GetChild(1), context);
                    msil.Append(string.Format("        IL_{0:X4}: brtrue.s IL_{1:X4}\n\n", strIndex++, doBodyStack.Pop()));
                    break;
                case AstNodeType.FOR:
                    v = context.FindVar(node.GetChild(0).Text);
                    LoadFieldData(context, v.Name);
                    //msil.Append(string.Format("        IL_{0:X4}: ldarg.0\n", strIndex++));
                    Generate(node.GetChild(1), context);
                    msil.Append(string.Format("        IL_{0:X4}: stfld {1} {2} \n", strIndex++, v.Type, v.FullName));
                    forCondStack.Push(string.Format("for_{0}", forCondCount++));
                    msil.Append(string.Format("        IL_{0:X4}: br.s {1}\n", strIndex++, forCondStack.Peek()));
                    msil.Append(string.Format("        IL_{0:X4}: nop\n", strIndex++));
                    forBodyStack.Push(strIndex);
                    Generate(node.GetChild(3), context);
                    msil.Append(string.Format("        IL_{0:X4}: nop\n", strIndex++));
                    //msil.Append(string.Format("        IL_{0:X4}: ldarg.0\n", strIndex++));
                    LoadFieldData(context, v.Name);
                    //msil.Append(string.Format("        IL_{0:X4}: ldarg.0\n", strIndex++));
                    LoadFieldData(context, v.Name);
                    msil.Append(string.Format("        IL_{0:X4}: ldfld {1} {2} \n", strIndex++, v.Type, v.FullName));
                    msil.Append(string.Format("        IL_{0:X4}: ldc.i4.1\n", strIndex++));
                    msil.Append(string.Format("        IL_{0:X4}: add\n", strIndex++));
                    msil.Append(string.Format("        IL_{0:X4}: stfld {1} {2} \n", strIndex++, v.Type, v.FullName));
                    msil.Replace(forCondStack.Pop(), string.Format("IL_{0:X4}", strIndex));
                    //msil.Append(string.Format("        IL_{0:X4}: ldarg.0\n", strIndex++));
                    LoadFieldData(context, v.Name);
                    msil.Append(string.Format("        IL_{0:X4}: ldfld {1} {2} \n", strIndex++, v.Type, v.FullName));
                    Generate(node.GetChild(2), context);
                    msil.Append(string.Format("        IL_{0:X4}: clt\n", strIndex++));
                    msil.Append(string.Format("        IL_{0:X4}: brtrue.s IL_{1:X4}\n\n", strIndex++, forBodyStack.Pop()));
                    break;
#endregion
            }
        }

        private void GenerateLocalMethods(Context context)
        {
            context.GenerateMethodsCash();
            msil.Append("       .locals init (\n");
            for (int i = 0; i < context.MethodsCash.Count; i++)
            {
                msil.Append(String.Format("            [{0}] class {1} {2}", i, context.MethodsCash[i].FullName, context.MethodsCash[i].Name));
                if (i != context.MethodsCash.Count - 1)
                    msil.Append(",\n");
            }
            msil.Append("\n       )\n");
        }

        public override string Generate()
        {
            Context context = new Context(null, "Program");
            msil = new StringBuilder();
            strIndex = 0;
            whileCondCount = 0;
            forCondCount = 0;
            whileCondStack = new Stack<string>();
            whileBodyStack = new Stack<int>();
            doBodyStack = new Stack<int>();
            forBodyStack = new Stack<int>();
            forCondStack = new Stack<string>();
            msil.Append(@".assembly program
{
}

.class public Program extends [mscorlib]System.Object
{   
");
            GenerateVars(program, context);
            GenerateMethods(program, context);
            msil.Append(@"
    .method public hidebysig instance void  Run() cil managed
    {
");
            GenerateLocalMethods(context);
            msil.Append(string.Format("        IL_{0:X4}: nop\n", strIndex++));
            Generate(program.GetChild(program.ChildCount - 1), context);
            msil.Append(string.Format("        IL_{0:X4}: ret", strIndex++));
            msil.Append(@"
    }

    .method private hidebysig static void  Main(string[] args) cil managed
    {
        .entrypoint
        .locals init ([0] class Program program)
        IL_0000:  nop
        IL_0001:  newobj instance void Program::.ctor()
        IL_0006:  stloc.0

        IL_0007:  ldloc.0
        IL_0008:  callvirt instance void Program::Run()
        IL_000d:  nop
        IL_000e:  ret
    }

    .method public hidebysig specialname rtspecialname instance void .ctor() cil managed
    {
        IL_0000:  ldarg.0
        IL_0001:  call instance void [mscorlib]System.Object::.ctor()
        IL_0006:  ret
    }
}
");
            return msil.ToString();
        }
    }
}
