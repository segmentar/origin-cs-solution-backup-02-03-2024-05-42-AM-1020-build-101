using Core;

namespace Core
{
    using System;

    [Scopexportableisc]
    public partial struct Scopexportablecharacterarraysafe
    {
        public Char[] Value;

        public Char[] ValueSafe;

        [Scopexportableism]
        public static Scopexportablecharacterarraysafe ForgeDefault(Char[] array_CHARACTER)
        {
            Scopexportablecharacterarraysafe safeResult = default;

            Char[] value, valueSafe;

            value = array_CHARACTER;

            valueSafe = Scopexportablesafe.GroupCharacterArray(array_CHARACTER);

            Scopexportablecharacterarraysafe safe;

            safe = new Scopexportablecharacterarraysafe();

            safe.Value = value;

            safe.ValueSafe = valueSafe;

            safeResult = safe;

            return safeResult;
        }
    }
}
