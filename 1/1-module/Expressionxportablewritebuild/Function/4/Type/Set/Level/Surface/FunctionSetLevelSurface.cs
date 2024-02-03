using Core;

namespace Core
{
    using System;

    public partial class ExpressionxportablewritebuildModule
    {
        public partial class XQuadruple
        {
            public static ExpressionxportablewriteXopq_stY[] FunctionLevelSetSurface(ExpressionxportablewriteXop_rstY[] LeveL_ARRAY)
            {
                ExpressionxportablewriteXopq_stY[] arrayResult = default;

                var list = FunctionLevelSet(LeveL_ARRAY);

                var array = new ExpressionxportablewriteXopq_stY[list.Count];

                list.CopyTo(array, ExpressionxportablePolicy.ExpressionxportableIndexPolicy);

                arrayResult = array;    

                return arrayResult;
            }
        }
    }
}
