using Antlr.Runtime;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PascalCompiler
{
    class FunctionAstNode : AstNode
    {
        private String name = "unknown";
        private String returnType = "none";

        public String ReturnType
        {
            get { return returnType; }
            set { returnType = value; }
        }


        public FunctionAstNode(IToken t)
            : base(t)
        {
        }


        public FunctionAstNode(int ttype, String name, String returnType)
            : base(new CommonToken(ttype))
        {
            Name = name;
            ReturnType = returnType;
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
            return "func " + name;// +" : " + returnType;
        }
    }
}
