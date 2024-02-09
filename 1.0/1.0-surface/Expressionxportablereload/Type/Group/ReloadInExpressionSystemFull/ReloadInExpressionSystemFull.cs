using Core;

namespace Core
{
    using System;

    public partial class Expressionxportablereload
    {
        public static Expressionxportable GroupReloadInExpressionSystemFull(Expressionxportable value_EXPRESSIONXPORTABLE)
        {
            Expressionxportable expressionxportableResult = default;

            var inflect = new Object[5];

            inflect[0] = Expressionxportablesavecontext.Data();

            inflect[1] = Expressionxportablewriteclose.Data();

            inflect[2] = Expressionxportableloadcontext.Data();

            inflect[3] = Expressionxportablereadclose.Data();

            inflect[4] = Expressionxportablereloadcontext.Data();

            var result = GroupReloadInExpressionSystem(value_EXPRESSIONXPORTABLE, (Expressionxportablesavecontext)inflect[0], (Expressionxportablewriteclose)inflect[1], (Expressionxportableloadcontext)inflect[2], (Expressionxportablereadclose)inflect[3], (Expressionxportablereloadcontext)inflect[4]);

            expressionxportableResult = result;

            return expressionxportableResult;
        }
    }
}
