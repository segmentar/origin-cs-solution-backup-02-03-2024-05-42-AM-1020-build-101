using Core;

namespace Core
{
    using System;

    public partial class Expressionxportableapi
    {
        public static Expressionxportable LoadFromExpressionSystemFull()
        {
            Expressionxportable expressionxportableResult = default;

            expressionxportableResult = Expressionxportableload.GroupLoadFromExpressionSystemFull();

            return expressionxportableResult;
        }
    }
}
