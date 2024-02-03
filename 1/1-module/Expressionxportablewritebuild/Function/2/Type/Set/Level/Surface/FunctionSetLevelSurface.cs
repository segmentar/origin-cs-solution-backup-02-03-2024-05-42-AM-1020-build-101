using Core;

namespace Core
{
    using System;

    public partial class ExpressionxportablewritebuildModule
    {
        public partial class XDouble
        {
            public static ExpressionxportablewriteXo_qrstY[] FunctionLevelSetSurface(ExpressionxportablewriteX_pqrstY[] Level_ARRAY)
            {
                ExpressionxportablewriteXo_qrstY[] arrayResult = default;

                var list = FunctionLevelSet(Level_ARRAY);

                var array = new ExpressionxportablewriteXo_qrstY[list.Count];

                list.CopyTo(array, ExpressionxportablePolicy.ExpressionxportableIndexPolicy);

                arrayResult = array;

                return arrayResult;
            }
        }
    }
}
