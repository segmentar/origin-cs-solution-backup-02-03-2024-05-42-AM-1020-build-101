using Core;

namespace Core
{
    using System;

    public partial class ScopexportableradicalNewLine
    {
        public static Int32[] NewLineIntegerArray = new Int32[2] { Scopexportableascii.EntityCarriageReturn, Scopexportableascii.EntityLineFeed };

        public static Char[] NewLineCharacterArray = new Char[2] { (Char)NewLineIntegerArray[0], (Char)NewLineIntegerArray[1] };

        public static String NewLineConcatenate = String.Concat(NewLineCharacterArray);

        public static String[] NewLineStringArray = new String[1] { NewLineConcatenate };
    }
}
