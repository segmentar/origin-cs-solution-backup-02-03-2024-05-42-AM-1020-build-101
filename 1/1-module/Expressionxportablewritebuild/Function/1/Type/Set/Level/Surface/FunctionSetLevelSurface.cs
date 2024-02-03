using Core;

namespace Core
{
    using System;

    public partial class ExpressionxportablewritebuildModule
    {
        public partial class XSingle
        {
            public static ExpressionxportablewriteX_pqrstY[] FunctionLevelSetSurface(Expressionxportable[] array_EXPRESSIONXPORTABLE)
            {
                ExpressionxportablewriteX_pqrstY[] arrayResult = default;
                
                var list = FunctionLevelSet(array_EXPRESSIONXPORTABLE);

                var array = new ExpressionxportablewriteX_pqrstY[list.Count];

                list.CopyTo(array, ExpressionxportablePolicy.ExpressionxportableIndexPolicy);

                arrayResult = array;

                return arrayResult;
            }
        }
    }
}
