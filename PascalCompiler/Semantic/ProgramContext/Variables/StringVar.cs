using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PascalCompiler.Semantic.ProgramContext.Variables
{
    class StringVar : Variable
    {
        private string value;

        public string Value
        {
            get
            {
                //if (!IsInit)
                //    throw new SemanticException(String.Format("The variable {0} is not initialized", Name));
                return this.value; 
            }
            set 
            {
                this.value = value; 
            }
        }

        public StringVar(string name)
            :base(name)
        {
            this.type = VariableType.STRING;
        }
    }
}
