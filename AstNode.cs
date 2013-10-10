using Antlr.Runtime;
using Antlr.Runtime.Tree;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PascalCompiler
{
    public class AstNode : CommonTree
    {
        public AstNode()
            : base()
        {
        }

        public AstNode(IToken t)
            : base(t)
        {
        }

        public AstNode(CommonTree node)
            : base(node)
        {
        }
    }
}
