using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PascalCompiler.Semantic
{
    class SemanticException : Exception
    {
        public SemanticException(string message)
            :base(message)
        {

        }
    }
}
