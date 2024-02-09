using Core;

namespace Core
{
    using System;

    public partial class ExpressionxportablereadbuildModule
    {
        public static ExpressionxportablereadXopq_stY[] FunctionLevelSetSurface(ExpressionxportablereadXop_rstY[] Level_ARRAY)
        {
            ExpressionxportablereadXopq_stY[] arrayResult = default;

            var list = FunctionLevelSet(Level_ARRAY);

            var array = new ExpressionxportablereadXopq_stY[list.Count];

            list.CopyTo(array, ExpressionxportablePolicy.ExpressionxportableIndexPolicy);

            arrayResult = array;

            return arrayResult;
        }
    }
}
