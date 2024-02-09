using Core;

namespace Core
{
    using System;

    public partial class ExpressionxportablereadbuildModule
    {
        public partial class XTriple
        {
            public static ExpressionxportablereadXop_rstY[] FunctionLevelSetSurface(ExpressionxportablereadXo_qrstY[] Level_ARRAY)
            {
                ExpressionxportablereadXop_rstY[] arrayResult = default;

                var list = FunctionLevelSet(Level_ARRAY);

                var array = new ExpressionxportablereadXop_rstY[list.Count];

                list.CopyTo(array, ExpressionxportablePolicy.ExpressionxportableIndexPolicy);

                arrayResult = array;

                return arrayResult;
            }
        }
    }
}
