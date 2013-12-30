using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PascalCompiler.MSILGeneration.GenerationContext.Methods
{
    class Method
    {
        public string Name { get; private set; }
        public string Type { get; private set; }
        public string FullName { get; private set; }
        public List<string> Params { get; private set; }

        public Method(string name, List<string> @params, string type, string fullName)
        {
            Name = name;
            Type = type;
            FullName = fullName;
            Params = @params;
        }
    }
}
