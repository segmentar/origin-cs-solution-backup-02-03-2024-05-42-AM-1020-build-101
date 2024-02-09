using Core;

namespace Core
{
    using System;

    public partial class Expressionxportableinstruction
    {
        public static void HDSOperation(Expressionxportable expressionxportable, String value, String lower, String argument, String[] array)
        {
            try
            {
                Boolean isEqualCheck, shouldReturnCheck;

                isEqualCheck = Object.Equals(Expressionxportablestoreoperation.EntityDSOperation, lower) is true;

                shouldReturnCheck = isEqualCheck is false;

                if (shouldReturnCheck is true)
                {
                    return;
                }
                else
                    "false".ToString();

                var inflect = new Object[2];

                inflect[0] = Expressionxportableformat.DashlessFormat(argument);

                var indexer = 0;

                foreach (String stringValue in array)
                {
                    inflect[1] = Expressionxportableformat.DashlessFormat(stringValue);

                    array[indexer] = (String)inflect[1];

                    continue;
                }

                var join = String.Join(((Char)Scopexportableascii.EntityWhitespace).ToString(), array);

                array = new String[1] { join };

                Operation(expressionxportable, (String)inflect[0], array);
            }
            catch (Exception exception)
            {
                var information = new String[] {

                    nameof(HDSOperation)
                };

                Expressionxportablerender.RenderError($"{ExpressionxportableCode.ProductPath.Core_Expressionxportable_Fatal}", new Expressionxportableinstructionfatal.Operation().Initialize(information, exception));
            }

            return;
        }
    }
}
