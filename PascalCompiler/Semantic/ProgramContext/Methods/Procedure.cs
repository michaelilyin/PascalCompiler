using PascalCompiler.Semantic.ProgramContext.Variables;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PascalCompiler.Semantic.ProgramContext.Methods
{
    class Procedure
    {
        private string name;

        public string Name
        {
            get { return name; }
        }
        private List<VariableType> paramsTypes;

        internal List<VariableType> ParamsTypes
        {
            get { return paramsTypes; }
        }

        public Procedure(string name)
        {
            this.name = name;
            paramsTypes = new List<VariableType>();
        }

        public void addParamType(VariableType type)
        {
            paramsTypes.Add(type);
        }

    }
}
