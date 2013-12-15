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

namespace PascalCompiler
{
    class Program
    {
        private static bool _printTree = false;

        static void Main(string[] args)
        {
            IList<string> arguments = args.ToList();
            if (arguments.Contains("-t")) _printTree = true;
            int inpos = arguments.IndexOf("-src") + 1;
            int outpos = arguments.IndexOf("-out") + 1;
            int logpos = arguments.IndexOf("-log") + 1;
            ICharStream input = inpos > 0 ? (ICharStream)new ANTLRFileStream(args[inpos])
                                                 : (ICharStream)new ANTLRReaderStream(Console.In);
            TextWriter output = logpos > 0 ? new StreamWriter(new FileStream(args[logpos], FileMode.Create))
                                                 : Console.Out;
            TextWriter code = outpos > 0 ? new StreamWriter(new FileStream(args[outpos], FileMode.Create))
                                                 : Console.Out;
            output.WriteLine("Compilation started");
            output.Write("Syntax....");
            output.Flush();
            PascalGrammarLexer lexer = new PascalGrammarLexer(input);
            CommonTokenStream tokens = new CommonTokenStream(lexer);
            PascalGrammarParser parser = new PascalGrammarParser(tokens);
            ITree program = (ITree)parser.execute().Tree;
            output.WriteLine("OK!");
            //TreePrinter.Print(program, output);
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
                string msil = MSILGenerator.GenerateMSIL(program);
                char[] chs = msil.ToArray();
                foreach (char ch in chs)
                {
                    code.Write(ch);
                    code.Flush();
                }
                code.Close();
            }
            catch (SemanticException ex)
            {
                output.WriteLine("Semantic error! " + ex.Message);
                output.Flush();
            }
            catch (Exception ex)
            {
                output.WriteLine("Unknown error! " + ex.Message);
                output.Flush();
            }
            if (logpos <= 0)
                Console.ReadKey();
        }
    }
}
