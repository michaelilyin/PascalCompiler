using Antlr.Runtime.Tree;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PascalCompiler
{
    class TreePrinter
    {
        public const byte ConnectCharDosCode = 0xB3,
                          MiddleNodeCharDosCode = 0xC3,
                          LastNodeCharDosCode = 0xC0;

        public static readonly char ConnectChar = '|',
                                    MiddleNodeChar = '*',
                                    LastNodeChar = '-';


        static TreePrinter()
        {
            Encoding dosEncoding = null;
            try
            {
                dosEncoding = Encoding.GetEncoding("cp866");
            }
            catch { }
            if (dosEncoding != null)
            {
                ConnectChar = dosEncoding.GetChars(new byte[] { ConnectCharDosCode })[0];
                MiddleNodeChar = dosEncoding.GetChars(new byte[] { MiddleNodeCharDosCode })[0];
                LastNodeChar = dosEncoding.GetChars(new byte[] { LastNodeCharDosCode })[0];
            }
        }


        private static string getStringSubTree(ITree node, string indent, bool root)
        {
            if (node == null)
                return "";

            string result = indent;
            if (!root)
                if (node.ChildIndex < node.Parent.ChildCount - 1)
                {
                    result += MiddleNodeChar + " ";
                    indent += ConnectChar + " ";
                }
                else
                {
                    result += LastNodeChar + " ";
                    indent += "  ";
                }
            result += node + "\n";
            for (int i = 0; i < node.ChildCount; i++)
                result += getStringSubTree(node.GetChild(i), indent, false);

            return result;
        }


        public static string astNodeToAdvancedDosStringTree(ITree node)
        {
            return getStringSubTree(node, "", true);
        }


        public static void Print(ITree node, TextWriter output)
        {
            string tree = astNodeToAdvancedDosStringTree(node);
            char[] chs = tree.ToArray();
            foreach (char ch in chs)
            {
                output.Write(ch);
                output.Flush();
            }
            //Console.WriteLine(tree);
        }
    }
}
