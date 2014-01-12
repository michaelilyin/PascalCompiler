using PascalCompiler.Semantic.ProgramContext.Variables;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PascalCompiler.Semantic.ProgramContext.Methods
{
    class Function : Procedure
    {   
        public Function(string name, VariableType returnType)
            :base(name)
        {
            this.returnType = returnType;
        }

        private VariableType returnType;

        internal VariableType ReturnType
        {
            get { return returnType; }
        }

    }
}
