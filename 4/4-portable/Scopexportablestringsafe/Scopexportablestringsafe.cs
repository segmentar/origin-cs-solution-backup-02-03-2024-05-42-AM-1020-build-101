using Core;

namespace Core
{
    using System;

    [Scopexportableisc]
    public partial struct Scopexportablestringsafe
    {
        public String Value;

        public String ValueSafe;

        [Scopexportableism]
        public static Scopexportablestringsafe ForgeDefault(String value_STRING)
        {
            Scopexportablestringsafe safeResult = default;

            String value, valueSafe;

            value = value_STRING;

            valueSafe = Scopexportablesafe.GroupString(value_STRING);

            Scopexportablestringsafe safe;

            safe = new Scopexportablestringsafe();

            safe.Value = value;

            safe.ValueSafe = valueSafe;

            safeResult = safe;

            return safeResult;
        }
    }
}
