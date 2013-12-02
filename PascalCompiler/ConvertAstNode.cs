using Antlr.Runtime;
using PascalCompiler.Semantic.ProgramContext.Variables;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PascalCompiler
{
    class ConvertAstNode : AstNode
    {
        ConvType type;

        public ConvertAstNode(IToken t)
            : base(t)
        {
        }


        public ConvertAstNode(int ttype, ConvType type)
            : base(new CommonToken(ttype))
        {
            this.type = type;
        }

        public override string ToString()
        {
            return "CONVERT: " + type.ToString(); 
        }
    }
}
