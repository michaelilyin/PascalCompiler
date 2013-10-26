using Antlr.Runtime;
using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PascalCompiler
{
    public class NumAstNode : AstNode
    {
        // "культуронезависимый" формат для чисел (с разделителем точкой)
        public static readonly NumberFormatInfo NFI = new NumberFormatInfo();


        private double value = 0;


        public NumAstNode(IToken t)
            : base(t)
        {
        }


        public NumAstNode(int ttype, double value)
            : base(new CommonToken(ttype))
        {
            Value = value;
        }


        public virtual double Value
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
            return value.ToString(NFI);
        }
    }
}
