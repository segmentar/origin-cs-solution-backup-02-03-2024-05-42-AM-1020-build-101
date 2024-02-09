using Core;

namespace Core
{
    using System;

    [Expressionxportableisc]
    public partial struct Expressionxportablecharactersafe
    {
        public Char Value;

        public Char ValueSafe;

        [Expressionxportableism]
        public static Expressionxportablecharactersafe ForgeDefault(Char value_CHARACTER)
        {
            Expressionxportablecharactersafe safeResult = default;

            Char value, valueSafe;

            value = value_CHARACTER;

            valueSafe = Expressionxportablesafe.GroupCharacter(value_CHARACTER);

            Expressionxportablecharactersafe safe;

            safe = new Expressionxportablecharactersafe();

            safe.Value = value;

            safe.ValueSafe = valueSafe;

            safeResult = safe;

            return safeResult;
        }
    }
}
