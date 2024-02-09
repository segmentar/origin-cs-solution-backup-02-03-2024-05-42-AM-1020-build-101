using Core;

namespace Core
{
    using System;

    public partial class ScopexportableradicalBody
    { 
        public static Int32[] BodyIntegerArray = new Int32[2] { Scopexportableascii.EntityComma, Scopexportableascii.EntityComma };

        public static Char[] BodyCharacterArray = new Char[2] { (Char)BodyIntegerArray[0], (Char)BodyIntegerArray[1] };

        public static String BodyCharacterConcatenate = String.Concat(BodyCharacterArray);
    }
}
