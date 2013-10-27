using PascalCompiler.Semantic.ProgramContext.Methods;
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
        private List<Procedure> methods;
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
                throw new SemanticException(String.Format("The multiple description of variable {0}", name));
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

        public void PutMethod(Procedure meth)
        {
            if (methods.Exists(m => m.Name == meth.Name))
                throw new SemanticException(String.Format("The multiple description of method {0}", meth.Name));
            methods.Add(meth);
        }

        public Procedure findMethod(string name)
        {
            Procedure meth = methods.Find(m => m.Name == name);
            if (meth == null)
                if (parentContext == null)
                    return null;
                else
                    return parentContext.findMethod(name);
            else
                return meth;
        }

        public Function findFunc(string name)
        {
            Procedure m = findMethod(name);
            if (m == null)
                if (parentContext == null)
                    return null;
                else
                    return parentContext.findFunc(name);
            else
                if (m is Function)
                    return m as Function;     
            throw new SemanticException(String.Format("The {0} is procedure", name));
        }
    }
}
