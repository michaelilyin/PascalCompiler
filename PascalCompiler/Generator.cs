using Antlr.Runtime.Tree;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PascalCompiler
{
    abstract class Generator
    {

        protected ITree program;

        public Generator(ITree program)
        {
            this.program = program;
        }
        public abstract string Generate();
    }
}
