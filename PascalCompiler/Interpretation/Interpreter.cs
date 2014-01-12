using Antlr.Runtime.Tree;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PascalCompiler.Interpretation
{
    class Interpreter
    {
        private ITree program;

        public Interpreter(ITree program)
        {
            this.program = program;
        }

        public void Process(TextWriter output)
        {
            output.WriteLine("I am an interpreter");
            output.Flush();
        }
    }
}
