using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PascalCompiler.Semantic.ProgramContext.Variables
{
    class FloatVar : Variable
    {
        private float value;
        private bool isInit = false;


        public float Value
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

        public FloatVar(string name)
            :base(name)
        {
            this.type = VariableType.FLOAT;
        }
    }
}
