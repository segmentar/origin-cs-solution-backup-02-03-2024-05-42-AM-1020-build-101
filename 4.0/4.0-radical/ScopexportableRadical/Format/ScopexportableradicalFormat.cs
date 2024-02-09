using Core;

namespace Core
{
    using System;

    public partial class ScopexportableradicalFormat
    {
        public static Int32[] FormatIntegerArray = new Int32[3] { Scopexportableascii.EntityWhitespace, Scopexportableascii.EntityDash, Scopexportableascii.EntityUnderscore };

        public static Char[] FormatCharacterArray = new Char[3] { (Char)FormatIntegerArray[0], (Char)FormatIntegerArray[1], (Char)FormatIntegerArray[2] };

        public static String FormatConcatenate = String.Concat(FormatCharacterArray);
    }
}
