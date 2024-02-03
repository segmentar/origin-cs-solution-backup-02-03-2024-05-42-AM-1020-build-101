using Core;

namespace Core
{
    using System;

    public partial class ExpressionxportablereadfileModule
    {
        public static ExpressionxportablereadfileModule Action(String Filename_VALUE)
        {
            ExpressionxportablereadfileModule moduleResult = default;

            moduleResult = Default(Filename_VALUE);

            if (ExpressionxportableModule.ExpressionxportablereadfilePolicy is true)
            {
                try
                {
                    Expressionxportablerender.Render($"{ExpressionxportableCode.ProductPath.Core_Expressionxportable_Render}-{ExpressionxportableIdentity.ExpressionxportableOrdinalIdentity}x{ExpressionxportableIdentity.ExpressionxportableNameIdentity}-{nameof(ExpressionxportablereadfileModule)}-0", ExpressionxportablreadfileCycle.XZeroth);

                    Expressionxportablerender.Render($"{ExpressionxportableCode.ProductPath.Core_Expressionxportable_Render}-{ExpressionxportableIdentity.ExpressionxportableOrdinalIdentity}x{ExpressionxportableIdentity.ExpressionxportableNameIdentity}-{nameof(ExpressionxportablereadfileModule)}-1", ExpressionxportablreadfileCycle.XPrimary.XSingle);
                }
                catch (Exception exception)
                {
                    Expressionxportablerender.Render($"{ExpressionxportableCode.ProductPath.Core_Expressionxportable_Fatal}", exception);
                }
            }
            else
                "false".ToString();

            return moduleResult;
        }
    }
}
