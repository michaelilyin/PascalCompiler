using Antlr.Runtime;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PascalCompiler
{
    class StringAstNode : AstNode
    {
        private string value;

        public StringAstNode(IToken t)
            : base(t)
        {
        }


        public StringAstNode(int ttype, string value)
            : base(new CommonToken(ttype))
        {
            Value = value.Substring(1, value.Length - 2);
        }


        public virtual string Value
        {
            get
            {
                return value;
            }
            set
            {
                this.value = value.Substring(1, value.Length - 2).Replace("\\\"", "\""); ;
            }
        }


        public override string ToString()
        {
            return value;
        }
    }
}
