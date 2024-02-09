using Core;

namespace Core
{
    using System;

    public partial class ExpressionxportablewritebuildModule
    {
        public partial class XQuintuple
        {
            public static ExpressionxportablewriteXopqr_tY[] FunctionLevelSetSurface(ExpressionxportablewriteXopq_stY[] Level_ARRAY, Expressionxportablelayout value_EXPRESSIONXPORTABLELAYOUT)
            {
                ExpressionxportablewriteXopqr_tY[] arrayResult = default;

                var list = FunctionLevelSet(Level_ARRAY, value_EXPRESSIONXPORTABLELAYOUT);

                var array = new ExpressionxportablewriteXopqr_tY[list.Count];

                list.CopyTo(array, ExpressionxportablePolicy.ExpressionxportableIndexPolicy);

                arrayResult = array;

                return arrayResult;
            }
        }
    }
}
