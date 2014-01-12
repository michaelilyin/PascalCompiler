using Antlr.Runtime;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PascalCompiler
{
    class ProcedureAstNode : AstNode
    {
        private String name = "unknown";


        public ProcedureAstNode(IToken t)
            : base(t)
        {
        }


        public ProcedureAstNode(int ttype, String name)
            : base(new CommonToken(ttype))
        {
            Name = name;
        }


        public virtual String Name
        {
            get
            {
                return name;
            }
            set
            {
                this.name = value;
            }
        }


        public override string ToString()
        {
            return "proc " + name;
        }
    }
}
