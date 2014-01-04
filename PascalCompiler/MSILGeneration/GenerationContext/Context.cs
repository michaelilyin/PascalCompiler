using PascalCompiler.MSILGeneration.GenerationContext.Methods;
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
        public List<Method> MethodsCash { get; private set; }
        public int strIndex;

        private List<Variables.Variable> variables;
        private List<Method> methods;

        public Context(Context parent, string name)
        {
            strIndex = 0;
            if (parent == null)
                ContextName = name;
            else
                ContextName = parent.ContextName + "/" + name;
            ParentContext = parent;
            variables = new List<Variables.Variable>();
            methods = new List<Method>();
        }

        public void AddVar(string name, string type)
        {
            variables.Add(new Variables.Variable(name, type, ContextName + "::" + name));
        }

        public void AddArg(string name, string type)
        {

        }

        public void AddMeth(string name, List<string> types, string @return)
        {
            methods.Add(new Method(name, types, @return, ContextName + "/" + name));
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

        public bool ContainsVar(string name)
        {
            return variables.Exists(a => a.Name == name);
        }

        public Method FindMethod(string name)
        {
            Method meth = methods.Find(m => m.Name == name);
            if (meth == null)
                if (ParentContext == null)
                    return null;
                else
                    return ParentContext.FindMethod(name);
            else
                return meth;
        }

        private List<Method> GetAllMethods()
        {
            List<Method> buf = new List<Method>(methods);
            if (ParentContext != null)
                buf.AddRange(ParentContext.GetAllMethods());
            return buf;
        }

        public void GenerateMethodsCash()
        {
            MethodsCash = GetAllMethods();
        }
    }
}
