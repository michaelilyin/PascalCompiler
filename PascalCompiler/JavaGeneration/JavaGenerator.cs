using Antlr.Runtime.Tree;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PascalCompiler.JavaGeneration
{
    class JavaGenerator : Generator
    {
        public JavaGenerator(ITree program)
            : base(program)
        {

        }

        public override string Generate()
        {
            throw new NotImplementedException();
        }
    }
}
