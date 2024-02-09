using Core;

namespace Core
{
    using System;

    public partial class Expressionxportablesave
    {
        public static void GroupSaveToExpressionSystemFull(Expressionxportable value_EXPRESSIONXPORTABLE)
        {
            var inflect = new Object[2];

            inflect[0] = Expressionxportablesavecontext.Data();

            inflect[1] = Expressionxportablewriteclose.Data();

            GroupSaveToExpressionSystem(value_EXPRESSIONXPORTABLE, (Expressionxportablesavecontext)inflect[0], (Expressionxportablewriteclose)inflect[1]);

            return;
        }
    }
}
