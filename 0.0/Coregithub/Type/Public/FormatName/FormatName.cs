using Core;

namespace Core
{
    using System;

    public partial class Coregithub
    {
        public static String FormatName(String item_STRING, String entry_STRING)
        {
            String stringResult = default;

            var separator = new Char[1];

            separator[0] = (Char)Coreascii.EntityDash;

            var split = item_STRING.Split(separator, StringSplitOptions.None);

            var aoth = split.Length;

            var roth = (aoth - 1);

            var eoth = split[roth];

            Boolean isEqualContagentCheck;

            isEqualContagentCheck = Object.Equals(split.Length, Corename.EntitySegmentCount) is true;

            String stringValue;

            if (isEqualContagentCheck)
            {
                var join = String.Join(((Char)Coreascii.EntityDash).ToString(), entry_STRING);

                stringValue = join;
            }
            else
            {
                var join = String.Join(((Char)Coreascii.EntityDash).ToString(), entry_STRING, eoth);

                stringValue = join;
            }

            var result = stringValue;

            stringResult = result;

            return stringResult;
        }
    }
}
