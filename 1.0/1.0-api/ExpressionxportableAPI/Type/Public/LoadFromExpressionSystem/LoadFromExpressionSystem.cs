using Core;

namespace Core
{
    using System;

    public partial class Expressionxportableapi
    {
        public static Expressionxportable LoadFromExpressionSystem(Expressionxportableloadcontext expressionxportableloadcontext, Expressionxportablereadclose expressionxportablereadclose)
        {
            Expressionxportable expressionxportableResult = default;

            expressionxportableResult = Expressionxportableload.GroupLoadFromExpressionSystem(expressionxportableloadcontext, expressionxportablereadclose);

            return expressionxportableResult;
        }
    }
}
