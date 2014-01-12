using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Antlr.Runtime;
using Antlr.Runtime.Tree;
using System.IO;
using PascalCompiler.Semantic;
using PascalCompiler.MSILGeneration;
using PascalCompiler.JavaGeneration;
using PascalCompiler.Interpretation;

namespace PascalCompiler
{

    public enum Action 
    {
        cil, java, interp
    }

    class Program
    {
        private static bool _printTree = false;

        static void Main(string[] args)
        {
            IList<string> arguments = args.ToList();
            Action act = Action.interp;
            Generator generator;
            if (arguments.Contains("-cil"))
                act = Action.cil;
            else if (arguments.Contains("-java"))
                act = Action.java;
            if (arguments.Contains("-t")) _printTree = true;
            int inpos = arguments.IndexOf("-src") + 1;
            int logpos = arguments.IndexOf("-log") + 1;
            int @out = arguments.IndexOf("-out") + 1;
            ICharStream input = inpos > 0 ? (ICharStream)new ANTLRFileStream(args[inpos])
                                                 : (ICharStream)new ANTLRReaderStream(Console.In);
            TextWriter output = logpos > 0 ? new StreamWriter(new FileStream(args[logpos], FileMode.Create))
                                                 : Console.Out;
            TextWriter code = @out > 0 ? new StreamWriter(new FileStream(args[@out], FileMode.Create))
                                                 : Console.Out;
            output.WriteLine("Compilation started");
            output.Write("Syntax....");
            output.Flush();
            PascalGrammarLexer lexer = new PascalGrammarLexer(input);
            CommonTokenStream tokens = new CommonTokenStream(lexer);
            PascalGrammarParser parser = new PascalGrammarParser(tokens);
            ITree program = (ITree)parser.execute().Tree;
            output.WriteLine("OK!");
            output.Write("Semantic....");
            output.Flush();
            try
            {
                SemAnalizer semAnalizer = new SemAnalizer(program);
                semAnalizer.Analize();
                output.WriteLine("OK!");
                output.Flush();
                output.WriteLine("Completed Successfuly");
                output.Flush();
                if (_printTree)
                    TreePrinter.Print(program, output);
                Generator gen = null;
                if (act != Action.interp)
                {
                    switch (act)
                    {
                        case Action.cil:
                            gen = new MSILGenerator(program);
                            break;
                        case Action.java:
                            gen = new JavaGenerator(program);
                            break;
                    }
                    string list = gen.Generate();
                    char[] chs = list.ToArray();
                    foreach (char ch in chs)
                    {
                        code.Write(ch);
                        code.Flush();
                    }
                    code.Close();
                }
                else
                {
                    Interpreter interpreter = new Interpreter(program);
                    interpreter.Process(code);
                }
            } 
            catch (SemanticException ex)
            {
                output.WriteLine("Semantic error! " + ex.Message);
                output.Flush();
            }
            catch (Exception ex)
            {
                output.WriteLine("Unknown error! " + ex.Message);
                output.WriteLine(ex.StackTrace);
                output.Flush();
            }
            if (logpos <= 0)
                Console.ReadKey();
        }
    }
}
