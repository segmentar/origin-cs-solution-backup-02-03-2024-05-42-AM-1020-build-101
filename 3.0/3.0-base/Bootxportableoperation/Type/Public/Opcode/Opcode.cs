using Core;

namespace Core
{
    using System;

    public partial class Bootxportableopcode
    {
        public static void Operation(Expressionxportable value_EXPRESSIONXPORTABLE, String Operation_VALUE, String[] Argument_ARRAY)
        {
            switch (Operation_VALUE)
            {
                case Bootxportablestoreopcode.EntityConvert:
                    GroupConvert(value_EXPRESSIONXPORTABLE, Argument_ARRAY);
                    break;

                case Bootxportablestoreopcode.EntityMessage:
                    GroupMessage(value_EXPRESSIONXPORTABLE, Argument_ARRAY);
                    break;

                case Bootxportablestoreopcode.EntityLog:
                    GroupLog(value_EXPRESSIONXPORTABLE, Argument_ARRAY);
                    break;

                case Bootxportablestoreopcode.EntityInline:
                    GroupInline(value_EXPRESSIONXPORTABLE, Argument_ARRAY);
                    break;

                default:
                    break;
            }

            return;
        }
    }
}
