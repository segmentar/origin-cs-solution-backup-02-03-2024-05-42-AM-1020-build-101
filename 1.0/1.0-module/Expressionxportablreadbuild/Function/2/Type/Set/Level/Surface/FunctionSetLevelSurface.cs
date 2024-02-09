using Core;

namespace Core
{
    using System;

    using System.IO;

    public partial class ExpressionxportablereadbuildModule
    {
        public partial class XDouble
        {
            public static ExpressionxportablereadXo_qrstY[] FunctionLevelSetSurface(BinaryReader value_BINARYREADER, ExpressionxportablereadX_pqrstY[] Level_ARRAY)
            {
                ExpressionxportablereadXo_qrstY[] arrayResult = default;

                var list = FunctionLevelSet(value_BINARYREADER, Level_ARRAY);

                var array = new ExpressionxportablereadXo_qrstY[list.Count];

                list.CopyTo(array, ExpressionxportablePolicy.ExpressionxportableIndexPolicy);

                arrayResult = array;

                return arrayResult;
            }
        }
    }
}
