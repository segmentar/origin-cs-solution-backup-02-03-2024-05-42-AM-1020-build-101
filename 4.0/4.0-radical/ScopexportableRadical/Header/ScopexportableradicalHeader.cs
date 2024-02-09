using Core;

namespace Core
{
    using System;

    public partial class ScopexportableradicalHeader
    {
        public static Int32[] HeaderIntegerArray = new Int32[3] { Scopexportableascii.EntityComma, Scopexportableascii.EntityComma, Scopexportableascii.EntityComma };

        public static Char[] HeaderCharacterArray = new Char[3] { (Char)HeaderIntegerArray[0], (Char)HeaderIntegerArray[1], (Char)HeaderIntegerArray[2] };

        public static String HeaderCharacterConcatenate = String.Concat(HeaderCharacterArray);
    }
}
