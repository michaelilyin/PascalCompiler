using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PascalCompiler.Semantic.ProgramContext.Variables
{
    class IntVar : Variable
    {
        private int value;

        public int Value
        {
            get
            {
                if (!isInit)
                    throw new SemanticException(String.Format("The variable {0} is not initialized", Name));
                return this.value; 
            }
            set 
            {
                this.value = value; 
            }
        }

        public IntVar(string name)
            :base(name)
        {
            this.type = VariableType.INT;
        }
    }
}
