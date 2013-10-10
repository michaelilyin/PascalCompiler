using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Antlr.Runtime;
using Antlr.Runtime.Tree;
using System.IO;

namespace PascalCompiler
{
    class Program
    {
        static void Main(string[] args)
        {
            // в зависимости от наличия параметров командной строки разбираем
            // либо файл с именем, переданным первым параметром, либо стандартный ввод
            ICharStream input = args.Length >= 1 ? (ICharStream)new ANTLRFileStream(args[0])
                                                 : (ICharStream)new ANTLRReaderStream(Console.In);
            TextWriter output = args.Length >= 2 ? new StreamWriter(new FileStream(args[1], FileMode.Create))
                                                 : Console.Out;
            PascalGrammarLexer lexer = new PascalGrammarLexer(input);
            CommonTokenStream tokens = new CommonTokenStream(lexer);
            PascalGrammarParser parser = new PascalGrammarParser(tokens);
            ITree program = (ITree)parser.execute().Tree;
            TreePrinter.Print(program, output);
            Console.ReadKey();
        }
    }
}
