using Core;

namespace Core
{
    using System;

    public partial class Expressionxportableapi
    {
        public static Expressionxportable ReloadInExpressionSystem(Expressionxportable expressionxportable, Expressionxportablesavecontext expressionxportablesavecontext, Expressionxportablewriteclose expressionxportablewriteclose, Expressionxportableloadcontext expressionxportableloadcontext, Expressionxportablereadclose expressionxportablereadclose, Expressionxportablereloadcontext expressionxportablereloadcontext)
        {
            Expressionxportable expressionxportableResult = default;

            expressionxportableResult = Expressionxportablereload.GroupReloadInExpressionSystem(expressionxportable, expressionxportablesavecontext, expressionxportablewriteclose, expressionxportableloadcontext, expressionxportablereadclose, expressionxportablereloadcontext);

            return expressionxportableResult;
        }
    }
}
