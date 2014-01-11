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
        private int thenCount, endIfCount;
        private int boolFirstCount, boolSecondCount;
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

        private string GenerateParams(ITree node, Context context)
        {
            string @params = "";

            ITree p;
            int i = 0;
            do
            {
                p = node.GetChild(i++);
            } while (p.Type != AstNodeType.PARAMS && i < node.ChildCount);
            if (p.Type != AstNodeType.PARAMS)
                return @params;
            for (i = 0; i < p.ChildCount; i++)
            {
                ITree @type = p.GetChild(i);
                for (int j = 0; j < @type.ChildCount; j++)
                {
                    ITree var = @type.GetChild(j);
                    context.AddVar(var.Text, ToCSTypes(@type.Text));
                    msil.Append(String.Format("    .field private {0} {1}\n", ToCSTypes(@type.Text), var.Text));
                    @params += ToCSTypes(@type.Text) + " " + var.Text + ",";
                }
            }
                //    nCon.AddVar("result", ret);
                //msil.Append(String.Format("    .field private {0} {1}\n", ret, "result"));
            @params = @params.Remove(@params.Length - 1);
            return @params;
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
                        List<string> names = new List<string>();
                        ITree nod = m.GetChild(ind);
                        if (nod.Type == AstNodeType.PARAMS)
                        {
                            for (int k = 0; k < nod.ChildCount; k++)
                            {
                                ITree type = nod.GetChild(k);
                                for (int d = 0; d < type.ChildCount; d++)
                                {
                                    types.Add(ToCSTypes(type.Text));
                                    names.Add(type.GetChild(d).Text);
                                }
                            }
                            ind++;
                        }
                        Context nCon = new Context(context, name);
                        string p = GenerateParams(m, nCon);
                        context.AddMeth(name, names, types, p, ret);
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
                        msil.Append(String.Format("\n    .method public hidebysig specialname rtspecialname instance void .ctor({0}) cil managed", p));
                        msil.Append(@"
    {
        IL_0000:  ldarg.0
        IL_0001:  call instance void [mscorlib]System.Object::.ctor()
");
                        for (int c = 0; c < names.Count; c++)
                        {
                            Variable v = nCon.FindVar(names[c]);
                            LoadFieldData(nCon, v.Name);
                            msil.Append(string.Format("        IL_{0:X4}: ldarg.{1}\n", strIndex++, c+1));
                            msil.Append(string.Format("        IL_{0:X4}: stfld {1} {2}\n\n", strIndex++, v.Type, v.FullName));

                        }
                        msil.Append(@"        IL_0003:  ret
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

        private bool GenerateSysCall(ITree node, Context context)
        {
            if (node.Type == AstNodeType.FUNC_CALL)
            {
                switch (node.GetChild(0).Text)
                {
                    case "writeln":
                        Generate(node.GetChild(1).GetChild(0), context);
                        msil.Append(string.Format("        IL_{0:X4}: call void [mscorlib]System.Console::WriteLine(string)\n", strIndex++));
                        msil.Append(string.Format("        IL_{0:X4}: nop\n\n", strIndex++));
                        return true;
                    case "write":
                        Generate(node.GetChild(1).GetChild(0), context);
                        msil.Append(string.Format("        IL_{0:X4}: call void [mscorlib]System.Console::Write(string)\n", strIndex++));
                        msil.Append(string.Format("        IL_{0:X4}: nop\n\n", strIndex++));
                        return true;
                    case "readln":
                        msil.Append(string.Format("        IL_{0:X4}: call string [mscorlib]System.Console::ReadLine()\n", strIndex++));
                        msil.Append(string.Format("        IL_{0:X4}: nop\n\n", strIndex++));
                        return true;
                }
            }
            return false;
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
                case AstNodeType.AND:
                    Generate(node.GetChild(0), context);
                    msil.Append(string.Format("        IL_{0:X4}: brfalse.s BOOL_1_{1} \n", strIndex++, boolFirstCount++));
                    Generate(node.GetChild(1), context);
                    msil.Append(string.Format("        IL_{0:X4}: br.s BOOL_2_{1} \n", strIndex++, boolSecondCount++));
                    msil.Replace(String.Format("BOOL_1_{0}", --boolFirstCount), String.Format("IL_{0:X4}", strIndex));
                    msil.Append(string.Format("        IL_{0:X4}: ldc.i4.0 \n", strIndex++));
                    msil.Replace(String.Format("BOOL_2_{0}", --boolSecondCount), String.Format("IL_{0:X4}", strIndex));
                    msil.Append(string.Format("        IL_{0:X4}: nop \n\n", strIndex++));
                    break;
                case AstNodeType.OR:
                    Generate(node.GetChild(0), context);
                    msil.Append(string.Format("        IL_{0:X4}: brtrue.s BOOL_1_{1}\n", strIndex++, boolFirstCount++));
                    Generate(node.GetChild(1), context);
                    msil.Append(string.Format("        IL_{0:X4}: br.s BOOL_2_{1}\n", strIndex++, boolSecondCount++));
                    msil.Replace(String.Format("BOOL_1_{0}", --boolFirstCount), String.Format("IL_{0:X4}", strIndex));
                    msil.Append(string.Format("        IL_{0:X4}: ldc.i4.1 \n", strIndex++));
                    msil.Replace(String.Format("BOOL_2_{0}", --boolSecondCount), String.Format("IL_{0:X4}", strIndex));
                    msil.Append(string.Format("        IL_{0:X4}: nop \n\n", strIndex++));
                    break;
                case AstNodeType.NOT:
                    Generate(node.GetChild(0), context);
                    msil.Append(string.Format("        IL_{0:X4}:  ldc.i4.0 \n", strIndex++));
                    msil.Append(string.Format("        IL_{0:X4}:  ceq \n", strIndex++));
                    break;
#endregion
#region constants
                case AstNodeType.NUMBER:
                    int num;
                    if (Int32.TryParse(((NumAstNode)node).ToString(), out num))
                        msil.Append(string.Format("        IL_{0:X4}: ldc.i4 {1}\n", strIndex++, ((NumAstNode)node).ToString()));
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
#region funccall
                case AstNodeType.FUNC_CALL:
#warning TODO system_calls
                    //if (node.GetChild(0).Text == "write")
                    //{
                    //    Generate(node.GetChild(1).GetChild(0), context);
                    //    msil.Append(string.Format("        IL_{0:X4}: call void [mscorlib]System.Console::WriteLine(string)\n", strIndex++));
                    //    msil.Append(string.Format("        IL_{0:X4}: nop\n\n", strIndex++));
                    //} 
                    if (GenerateSysCall(node, context))
                    {
                        ;
                    }
                    else
                    {
                        Method m = context.FindMethod(node.GetChild(0).Text);
                        int ind = context.MethodsCash.IndexOf(m);
                        if (node.ChildCount == 2) 
                        {
                            ITree p = node.GetChild(1);
                            for (int i = 0; i < p.ChildCount; i++)
                                Generate(p.GetChild(i), context);
                        }
                        msil.Append(string.Format("        IL_{0:X4}: newobj instance void {1}::.ctor({2})\n", strIndex++, m.FullName, m.ParamsStr));
                        //if (context.ContainsMeth(m.Name))
                        //{
                        //    msil.Append(string.Format("        IL_{0:X4}: ldarg.0\n", strIndex++));
                        //    msil.Append(string.Format("        IL_{0:X4}: call instance {1} {2}::Run(class {3})\n\n", strIndex++, m.Type, m.FullName, context.ContextName));
                        //}
                        //else
                        //{
                            msil.Append(string.Format("        IL_{0:X4}: ldarg.0\n", strIndex++));
                            Context cont = context;
                            string cn = context.ContextName;
#warning maybee dont work
                            while (!cont.ContainsMeth(m.Name))
                            {
                                msil.Append(string.Format("        IL_{0:X4}: ldfld class {1} {2}\n", strIndex++, context.ParentContext.ContextName, context.FindVar("__p__").FullName));
                                cont = cont.ParentContext;
                                cn = cont.ContextName;
                            }
                            //msil.Append(string.Format("        IL_{0:X4}: ldfld class {1} {2}::__p__\n", strIndex++, context.ParentContext.ContextName, context.ContextName));
                            msil.Append(string.Format("        IL_{0:X4}: call instance {1} {2}::Run(class {3})\n", strIndex++, m.Type, m.FullName, cn));
                            if (m.Type != "void" && (node.Parent.Type == AstNodeType.BLOCK
                                    || node.Parent.Type == AstNodeType.WHILE
                                    || node.Parent.Type == AstNodeType.DO
                                    || node.Parent.Type == AstNodeType.FOR
                                    || node.Parent.Type == AstNodeType.IF
                                    ))
                            {
                                msil.Append(string.Format("        IL_{0:X4}: pop\n\n", strIndex++));
                            }
                        //}
                    }
                    break;
#endregion
#region convert
                case AstNodeType.CONVERT:
                    //Generate(node.GetChild(0), context);
#warning TODO notmal universal convertion
                    //switch (node.GetChild(0).Type)
                    //{
                    //    case AstNodeType.IDENT:
                    //        v = context.FindVar(node.GetChild(0).Text);
                    //        LoadFieldData(context, v.Name);
                    //        //msil.Append(string.Format("        IL_{0:X4}: ldarg.0\n", strIndex++));
                    //        msil.Append(string.Format("        IL_{0:X4}: ldflda {1} {2} \n", strIndex++, v.Type, v.FullName));
                    //        break;
                    //}
                    Generate(node.GetChild(0), context);

                    switch (((ConvertAstNode)node).Type)
                    {
                        case Semantic.ProgramContext.Variables.ConvType.bool_to_str:
                            //v = context.FindVar(node.GetChild(0).Text);
                            //msil.Append(String.Format("        IL_{0:X4}: ldsflda {1} {2}\n", strIndex++, v.Type, v.FullName));
                            //msil.Append(String.Format("        IL_{0:X4}: stloc.{1}\n", strIndex++, ));
                            msil.Append(String.Format("        IL_{0:X4}: stloc.{1}\n", strIndex++, locals.IndexOf("bool")));
                            msil.Append(String.Format("        IL_{0:X4}: ldloca.s {1}\n", strIndex++, String.Format("__loc_{0}__", locals.IndexOf("bool"))));
                            msil.Append(String.Format("        IL_{0:X4}: call instance string [mscorlib]System.Boolean::ToString()\n", strIndex++));
                            //msil.Append(String.Format("        IL_{0:X4}: pop\n", strIndex++));
                            break;
                        case Semantic.ProgramContext.Variables.ConvType.float_to_str:
                            //v = context.FindVar(node.GetChild(0).Text);
                            //msil.Append(String.Format("        IL_{0:X4}: ldsflda {1} {2}\n", strIndex++, v.Type, v.FullName));
                            msil.Append(String.Format("        IL_{0:X4}: stloc.{1}\n", strIndex++, locals.IndexOf("float32")));
                            msil.Append(String.Format("        IL_{0:X4}: ldloca.s {1}\n", strIndex++, String.Format("__loc_{0}__", locals.IndexOf("float32"))));
                            msil.Append(String.Format("        IL_{0:X4}: call instance string [mscorlib]System.Single::ToString()\n", strIndex++));
                           // msil.Append(String.Format("        IL_{0:X4}: pop\n", strIndex++));
                            break;
                        case Semantic.ProgramContext.Variables.ConvType.int_to_str:
                            //v = context.FindVar(node.GetChild(0).Text);
                            //msil.Append(String.Format("        IL_{0:X4}: ldsflda {1} {2}\n", strIndex++, v.Type, v.FullName));
                            msil.Append(String.Format("        IL_{0:X4}: stloc.{1}\n", strIndex++, locals.IndexOf("int32")));
                            msil.Append(String.Format("        IL_{0:X4}: ldloca.s {1}\n", strIndex++, String.Format("__loc_{0}__", locals.IndexOf("int32"))));
                            msil.Append(String.Format("        IL_{0:X4}: call instance string [mscorlib]System.Int32::ToString()\n", strIndex++));
                            //msil.Append(String.Format("        IL_{0:X4}: pop\n", strIndex++));
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
                case AstNodeType.IF:
                    Generate(node.GetChild(0), context);
                    msil.Append(string.Format("        IL_{0:X4}: brtrue.s THEN_{1:X4}\n\n", strIndex++, thenCount++));
                    if (node.ChildCount == 3)
                        Generate(node.GetChild(2), context);
                    msil.Append(string.Format("        IL_{0:X4}: br.s ENDIF_{1:X4}\n\n", strIndex++, endIfCount++));
                    msil.Replace(String.Format("THEN_{0:X4}", --thenCount), String.Format("IL_{0:X4}", strIndex));
                    Generate(node.GetChild(1), context);
                    msil.Replace(String.Format("ENDIF_{0:X4}", --endIfCount), String.Format("IL_{0:X4}", strIndex));
                    break;
            }
        }

        private List<string> locals;

        private void InitLocalDictionary()
        {
            locals = new List<string>();
            locals.Add("int32");
            locals.Add("float32");
            locals.Add("bool");
            locals.Add("string");
        }

        private void GenerateLocalMethods(Context context)
        {
            context.GenerateMethodsCash();
            //msil.Append("       .maxstack  2\n");
            msil.Append("       .locals init (\n");
            for (int i = 0; i < locals.Count; i++)
            {
                msil.Append(String.Format("            [{0}] {1} __loc_{2}__", i, locals[i], i));
                if (i < locals.Count - 1) msil.Append(", \n");
            }
                //for (int i = 0; i < context.MethodsCash.Count; i++)
                //{
                //    msil.Append(String.Format("            [{0}] class {1} {2}", i, context.MethodsCash[i].FullName, context.MethodsCash[i].Name));
                //    if (i != context.MethodsCash.Count - 1)
                //        msil.Append(",\n");
                //}
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
            boolFirstCount = 0;
            boolSecondCount = 0;
            thenCount = 0;
            endIfCount = 0;
            InitLocalDictionary();
            msil.Append(@".assembly extern mscorlib
{
    .publickeytoken = (B7 7A 5C 56 19 34 E0 89 )      
    .ver 4:0:0:0
}
.assembly program
{
}

.class private auto ansi beforefieldinit Program extends [mscorlib]System.Object
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
