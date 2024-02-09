using Core;

namespace Core
{
    using System;

    public partial class Expressionxportableapi
    {
        public static Expressionxportable ReloadInExpressionSystemFull(Expressionxportable expressionxportable)
        {
            Expressionxportable expressionxportableResult = default;

            expressionxportableResult = Expressionxportablereload.GroupReloadInExpressionSystemFull(expressionxportable);

            return expressionxportableResult;
        }
    }
}
