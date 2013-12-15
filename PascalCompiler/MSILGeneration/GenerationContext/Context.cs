using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PascalCompiler.MSILGeneration.GenerationContext
{
    class Context
    {
        public string ContextName { get; private set; }
        public Context ParentContext { get; private set; }

        private List<Variables.Variable> variables;

        public Context(Context parent, string name)
        {
            if (parent == null)
                ContextName = name;
            else
                ContextName = parent.ContextName + "." + name;
            ParentContext = parent;
            variables = new List<Variables.Variable>();
        }

        public void AddVar(string name, string type)
        {
            variables.Add(new Variables.Variable(name, type, ContextName + "::" + name));
        }

        public Variables.Variable FindVar(string name)
        {
            Variables.Variable v = variables.Find(a => a.Name == name);
            if (v == null)
                if (ParentContext == null)
                    return null;
                else
                    return ParentContext.FindVar(name);
            else
                return v;
        }
    }
}
