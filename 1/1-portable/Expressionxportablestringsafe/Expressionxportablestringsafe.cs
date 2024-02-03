using Core;

namespace Core
{
    using System;

    [Expressionxportableisc]
    public partial struct Expressionxportablestringsafe
    {
        public String Value;

        public String ValueSafe;

        [Expressionxportableism]
        public static Expressionxportablestringsafe ForgeDefault(String value_STRING)
        {
            Expressionxportablestringsafe safeResult = default;

            String value, valueSafe;

            value = value_STRING;

            valueSafe = Expressionxportablesafe.GroupString(value_STRING);

            Expressionxportablestringsafe safe;

            safe = new Expressionxportablestringsafe();

            safe.Value = value;

            safe.ValueSafe = valueSafe;

            safeResult = safe;

            return safeResult;
        }
    }
}
