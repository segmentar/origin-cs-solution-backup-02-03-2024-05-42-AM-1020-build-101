using Core;

namespace Core
{
    using System;

    public partial class ExpressionxportablewritebuildModule
    {
        public partial class XSextuple
        {
            public static ExpressionxportablewriteXopqrs_Y[] FunctionLevelSetSurface(ExpressionxportablewriteXopqr_tY[] Level_ARRAY, Expressionxportablelayout value_EXPRESSIONXPORTABLELAYOUT)
            {
                ExpressionxportablewriteXopqrs_Y[] arrayResult = default;

                var list = FunctionLevelSet(Level_ARRAY, value_EXPRESSIONXPORTABLELAYOUT);

                var array = new ExpressionxportablewriteXopqrs_Y[list.Count];

                list.CopyTo(array, ExpressionxportablePolicy.ExpressionxportableIndexPolicy);

                arrayResult = array;

                return arrayResult;
            }
        }
    }
}
