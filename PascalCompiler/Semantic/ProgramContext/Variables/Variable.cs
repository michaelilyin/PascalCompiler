using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PascalCompiler.Semantic.ProgramContext.Variables
{
    internal class Variable
    {
        protected VariableType type;
        private string name;
        protected bool isInit = false;

        public Variable(string name)
        {
            this.name = name;
        }

        public string Name
        {
            get { return name; }
        }

        internal VariableType Type
        {
            get { return type; }
        }

        public void Init()
        {
            isInit = true;
        }

    }
}
