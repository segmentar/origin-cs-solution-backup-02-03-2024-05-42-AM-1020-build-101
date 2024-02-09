using Core;

namespace Core
{
    using System;

    public partial class Expressionxportableinstruction
    {
        public static void HSOperation(Expressionxportable expressionxportable, String value, String lower, String argument, String[] array)
        {
            try
            {
                Boolean isEqualCheck, shouldReturnCheck;

                isEqualCheck = Object.Equals(Expressionxportablestoreoperation.EntitySOperation, lower) is true;

                shouldReturnCheck = isEqualCheck is false;

                if (shouldReturnCheck is true)
                {
                    return;
                }
                else
                    "false".ToString();

                var inflect = new Object[2];

                inflect[0] = Expressionxportableformat.DashlessFormat(argument);

                var join = String.Join(((Char)Scopexportableascii.EntityWhitespace).ToString(), array);

                array = new String[1] { join };

                Operation(expressionxportable, (String)inflect[0], array);
            }
            catch (Exception exception)
            {
                var information = new String[] {

                    nameof(HSOperation)
                };

                Expressionxportablerender.RenderError($"{ExpressionxportableCode.ProductPath.Core_Expressionxportable_Fatal}", new Expressionxportableinstructionfatal.Operation().Initialize(information, exception));
            }

            return;
        }
    }
}
