using Core;

namespace Core
{
    using System;

    public partial class ExpressionxportablewritebuildModule
    {
        public partial class XTriple
        {
            public static ExpressionxportablewriteXop_rstY[] FunctionLevelSetSurface(ExpressionxportablewriteXo_qrstY[] Level_ARRAY, Expressionxportable[] array_EXPRESSIONXPORTABLE)
            {
                ExpressionxportablewriteXop_rstY[] arrayResult = default;
                
                var list = FunctionLevelSet(Level_ARRAY, array_EXPRESSIONXPORTABLE);

                var array = new ExpressionxportablewriteXop_rstY[list.Count];

                list.CopyTo(array, ExpressionxportablePolicy.ExpressionxportableIndexPolicy);

                arrayResult = array;

                return arrayResult;
            }
        }
    }
}
