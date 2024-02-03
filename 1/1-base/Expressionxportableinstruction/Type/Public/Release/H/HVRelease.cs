using Core;

namespace Core
{
    using System;

    public partial class Expressionxportableinstruction
    {
        public static void HVRelease(Expressionxportable expressionxportable, String value, String lower, String argument, String[] array)
        {
            try
            {
                Boolean isEqualCheck, shouldReturnCheck;

                isEqualCheck = Object.Equals(Expressionxportablestorerelease.EntityVRelease, lower) is true;

                shouldReturnCheck = isEqualCheck is false;

                if (shouldReturnCheck is true)
                {
                    return;
                }
                else
                    "false".ToString();

                VRelease(expressionxportable);
            }
            catch (Exception exception)
            {
                var information = new String[] {

                    nameof(HVRelease)
                };

                Expressionxportablerender.RenderError($"{ExpressionxportableCode.ProductPath.Core_Expressionxportable_Fatal}", new Expressionxportableinstructionfatal.Release().Initialize(information, exception));
            }

            return;
        }
    }
}
