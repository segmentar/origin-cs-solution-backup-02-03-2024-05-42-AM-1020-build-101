using Core;

namespace Core
{
    using System;

    public partial class ExpressionxportablewritebuildModule
    {
        public partial class XSeptuple
        {
            public static ExpressionxportablewriteU_pqrstV[] FunctionLevelSetSurface(ExpressionxportablewriteXopqrs_Y[] Level_ARRAY)
            {
                ExpressionxportablewriteU_pqrstV[] arrayResult = default;

                var list = FunctionLevelSet(Level_ARRAY);

                var array = new ExpressionxportablewriteU_pqrstV[list.Count];

                list.CopyTo(array, ExpressionxportablePolicy.ExpressionxportableIndexPolicy);

                arrayResult = array;

                return arrayResult;
            }
        }
    }
}
