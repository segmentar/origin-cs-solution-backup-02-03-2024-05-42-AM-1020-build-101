using Core;

namespace Core
{
    using System;

    public partial class Bootxportableopcode
    {
        public static void CategoryConvert(Expressionxportable value_EXPRESSIONXPORTABLE, String[] array_STRING)
        {
            System.Windows.Forms.MessageBox.Show("conv");

            var first = array_STRING[0];

            var value = Expressionxportableformat.DashlessFormat(first);

            var array = Expressionxportableset.ExpressionxportableAllSetSurface(value_EXPRESSIONXPORTABLE, true);

            foreach (Expressionxportable expressionxportable in array)
            {
                var reflect = (Expressionxportablestringsafe)(expressionxportable.StringIdentity as Object);

                Boolean isEqualCheck, shouldContinueCheck;

                isEqualCheck = Object.Equals(reflect.Value, value) is true;

                shouldContinueCheck = isEqualCheck is false;

                if (shouldContinueCheck is true)
                {
                    continue;
                }
                else
                    "false".ToString();

                var item = Materialxportable.MaterialxportableRootVariation();

                var result = Bootxportableconvert.Convert(expressionxportable, item);

                expressionxportable.ObjectIdentity = result;

                continue;
            }

            return;
        }
    }
}
