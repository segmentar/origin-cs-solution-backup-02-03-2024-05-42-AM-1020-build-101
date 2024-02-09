using Core;

namespace Core
{
    using System;

    public partial class Bootxportableopcode
    {
        public static void GroupInline(Expressionxportable value_EXPRESSIONXPORTABLE, String[] array_STRING)
        {
            Boolean isEqualCheck, shouldReturnCheck;

            isEqualCheck = (array_STRING.Length < 1).Equals(true);

            shouldReturnCheck = isEqualCheck is true;

            if (shouldReturnCheck is true)
            {
                return;
            }
            else
                "false".ToString();

            CategoryInline(value_EXPRESSIONXPORTABLE, array_STRING);

            return;
        }
    }
}
