using Antlr.Runtime;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PascalCompiler
{
    class ProgAstNode : AstNode
    {
        private String value = "unknown";


        public ProgAstNode(IToken t)
            : base(t)
        {
        }


        public ProgAstNode(int ttype, String value)
            : base(new CommonToken(ttype))
        {
            Value = value;
        }


        public virtual String Value
        {
            get
            {
                return value;
            }
            set
            {
                this.value = value;
            }
        }


        public override string ToString()
        {
            return value;
        }
    }
}
