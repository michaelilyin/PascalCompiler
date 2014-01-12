using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PascalCompiler.MSILGeneration.GenerationContext.Variables
{
    class Variable
    {
        public string Name { get; private set; }
        public string Type { get; private set; }
        public string FullName { get; private set; }

        public Variable(string name, string type, string fullName)
        {
            Name = name;
            Type = type;
            FullName = fullName;
        }
    }
}
