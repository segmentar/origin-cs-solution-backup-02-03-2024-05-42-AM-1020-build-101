using Core;

namespace Core
{
    using System;

    [Scopexportableisc]
    public partial struct Scopexportablecharactersafe
    {
        public Char Value;

        public Char ValueSafe;

        [Scopexportableism]
        public static Scopexportablecharactersafe ForgeDefault(Char value_CHARACTER)
        {
            Scopexportablecharactersafe safeResult = default;

            Char value, valueSafe;

            value = value_CHARACTER;

            valueSafe = Scopexportablesafe.GroupCharacter(value_CHARACTER);

            Scopexportablecharactersafe safe;

            safe = new Scopexportablecharactersafe();

            safe.Value = value;

            safe.ValueSafe = valueSafe;

            safeResult = safe;

            return safeResult;
        }
    }
}
