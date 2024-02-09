using Core;

namespace Core
{
    using System;

    public partial class Expressionxportableapi
    {
        public static void SaveToExpressionSystem(Expressionxportable expressionxportable, Expressionxportablesavecontext expressionxportablesavecontext, Expressionxportablewriteclose expressionxportablewriteclose)
        {
            Expressionxportablesave.GroupSaveToExpressionSystem(expressionxportable, expressionxportablesavecontext, expressionxportablewriteclose);

            return;
        }
    }
}
