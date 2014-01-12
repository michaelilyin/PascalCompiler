using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PascalCompiler.Semantic.ProgramContext.Variables
{
    public enum ConvType 
    {
        none, 
        bool_to_str, 
        float_to_str, 
        int_to_float, 
        int_to_str,
        not_alowed
    }

    public static class ConvertTable
    {
        private static Dictionary<VariableType, Dictionary<VariableType, ConvType>> table;

        static ConvertTable()
        {
            table = new Dictionary<VariableType, Dictionary<VariableType, ConvType>>();

            table[VariableType.BOOL] = new Dictionary<VariableType, ConvType>();
            table[VariableType.BOOL][VariableType.BOOL] = ConvType.none;
            table[VariableType.BOOL][VariableType.FLOAT] = ConvType.not_alowed;
            table[VariableType.BOOL][VariableType.INT] = ConvType.not_alowed;
            table[VariableType.BOOL][VariableType.STRING] = ConvType.bool_to_str;

            table[VariableType.FLOAT] = new Dictionary<VariableType, ConvType>();
            table[VariableType.FLOAT][VariableType.BOOL] = ConvType.not_alowed;
            table[VariableType.FLOAT][VariableType.FLOAT] = ConvType.none;
            table[VariableType.FLOAT][VariableType.INT] = ConvType.not_alowed;
            table[VariableType.FLOAT][VariableType.STRING] = ConvType.float_to_str;

            table[VariableType.INT] = new Dictionary<VariableType, ConvType>();
            table[VariableType.INT][VariableType.BOOL] = ConvType.not_alowed;
            table[VariableType.INT][VariableType.FLOAT] = ConvType.int_to_float;
            table[VariableType.INT][VariableType.INT] = ConvType.none;
            table[VariableType.INT][VariableType.STRING] = ConvType.int_to_str;

            table[VariableType.STRING] = new Dictionary<VariableType, ConvType>();
            table[VariableType.STRING][VariableType.BOOL] = ConvType.not_alowed;
            table[VariableType.STRING][VariableType.FLOAT] = ConvType.not_alowed;
            table[VariableType.STRING][VariableType.INT] = ConvType.not_alowed;
            table[VariableType.STRING][VariableType.STRING] = ConvType.none;
        }

        public static ConvType IsConvertable(VariableType from, VariableType to)
        {
            return table[from][to];
        }
    }
}
