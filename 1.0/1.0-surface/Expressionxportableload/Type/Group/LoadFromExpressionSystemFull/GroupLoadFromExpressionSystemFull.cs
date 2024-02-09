using Core;

namespace Core
{
    using System;

    public partial class Expressionxportableload
    {
        public static Expressionxportable GroupLoadFromExpressionSystemFull()
        {
            Expressionxportable expressionxportableResult = default;

            var inflect = new Object[2];

            inflect[0] = Expressionxportableloadcontext.Data();

            inflect[1] = Expressionxportablereadclose.Data();

            var result = GroupLoadFromExpressionSystem((Expressionxportableloadcontext)inflect[0], (Expressionxportablereadclose)inflect[1]);

            expressionxportableResult = result;

            return expressionxportableResult;
        }
    }
}
