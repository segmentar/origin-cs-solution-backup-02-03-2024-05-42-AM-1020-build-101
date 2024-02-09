using Core;

namespace Core
{
    using System;

    public partial class Bootxportablemonitor
    {
        public static String Monitor()
        {
            String stringResult = default;

            var value = Expressionxportableapi.LoadFromExpressionSystemFull().ToString();

            stringResult = value;

            return stringResult;
        }
    }
}
