using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PascalCompiler.Semantic.ProgramContext.Variables
{
    class BoolVar : Variable
    {
        private bool value;

        public bool Value
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

        public BoolVar(string name)
            :base(name)
        {
            this.type = VariableType.BOOL;
        }
    }
}
