using Core;

namespace Core
{
    using System;

    public partial class Bootxportableopcode
    {
        public static void CategoryLog(Expressionxportable value_EXPRESSIONXPORTABLE, String[] array_STRING)
        {            
            var first = array_STRING[0];

            var value = Expressionxportableformat.DashlessFormat(first);

            var list = Expressionxportablemagic.ExpressionxportablemagicArrayListCastDispenser(value_EXPRESSIONXPORTABLE.LayerArrayListObject);

            foreach (Expressionxportable expressionxportable in list)
            {
                Boolean isEqualCheck, shouldContinueCheck;

                isEqualCheck = Object.Equals(((Expressionxportablestringsafe)expressionxportable.StringIdentity).Value, value) is true;

                shouldContinueCheck = isEqualCheck is false;

                if (shouldContinueCheck is true)
                {
                    continue;
                }
                else
                    "false".ToString();

                var result = Expressionxportableformat.RepresentString(expressionxportable, 1);

                Expressionxportablelog.Log(result);

                continue;
            }

            return;
        }
    }
}
