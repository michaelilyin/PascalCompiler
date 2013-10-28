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

        public Variable(string name)
        {
            this.name = name;
        }

        public Variable(VariableType type)
        {
            this.type = type;
        }

        public string Name
        {
            get { return name; }
        }

        internal VariableType Type
        {
            get { return type; }
        }

    }
}
