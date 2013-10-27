using PascalCompiler.Semantic.ProgramContext.Variables;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PascalCompiler.Semantic.ProgramContext
{
    internal class Context
    {
        private List<Variable> variables;
        private Context parentContext;

        public Context()
            : this(null)
        {

        }

        public Context(Context parentContext)
        {
            variables = new List<Variable>();
            this.parentContext = parentContext;
        }

        public void PutVar(string name, VariableType type)
        {
            if (variables.Exists((a) => a.Name == name))
            {
                throw new SemanticException(String.Format("The multiple description of variable {0}", name));
            }
            switch (type)
            {
                case VariableType.INT:
                    variables.Add(new IntVar(name));
                    break;
                case VariableType.FLOAT:
                    variables.Add(new FloatVar(name));
                    break;
                case VariableType.BOOL:
                    variables.Add(new BoolVar(name));
                    break;
                case VariableType.STRING:
                    variables.Add(new StringVar(name));
                    break;
            }
        }

        public Variable FindVar(string name)
        {
            Variable v = variables.Find(a => a.Name == name);
            if (v == null)
                if (parentContext == null)
                    return null;
                else
                    return parentContext.FindVar(name);
            else
                return v;
        }
    }
}
