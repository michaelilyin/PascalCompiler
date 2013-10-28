using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Antlr.Runtime;
using Antlr.Runtime.Tree;
using System.IO;
using PascalCompiler.Semantic;

namespace PascalCompiler
{
    class Program
    {
        static void Main(string[] args)
        {
            ICharStream input = args.Length >= 1 ? (ICharStream)new ANTLRFileStream(args[0])
                                                 : (ICharStream)new ANTLRReaderStream(Console.In);
            TextWriter output = args.Length >= 2 ? new StreamWriter(new FileStream(args[1], FileMode.Create))
                                                 : Console.Out;

            output.WriteLine("Compilation started");
            output.Write("Syntax....");
            output.Flush();
            PascalGrammarLexer lexer = new PascalGrammarLexer(input);
            CommonTokenStream tokens = new CommonTokenStream(lexer);
            PascalGrammarParser parser = new PascalGrammarParser(tokens);
            ITree program = (ITree)parser.execute().Tree;
            output.WriteLine("OK!");
            TreePrinter.Print(program, output);
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
                TreePrinter.Print(program, output);
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
            Console.ReadKey();
        }
    }
}
