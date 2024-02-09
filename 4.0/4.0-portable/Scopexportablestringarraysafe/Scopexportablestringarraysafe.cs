using Core;

namespace Core
{
    using System;

    [Scopexportableisc]
    public partial struct Scopexportablestringarraysafe
    {
        public String[] Value;

        public String[] ValueSafe;


        [Scopexportableism]
        public static Scopexportablestringarraysafe ForgeDefault(String[] array_STRING)
        {
            Scopexportablestringarraysafe safeResult = default;

            String[] value, valueSafe;

            value = array_STRING;

            valueSafe = Scopexportablesafe.GroupStringArray(array_STRING);

            Scopexportablestringarraysafe safe;

            safe = new Scopexportablestringarraysafe();

            safe.Value = value;

            safe.ValueSafe = valueSafe;

            safeResult = safe;

            return safeResult;
        }
    }
}
