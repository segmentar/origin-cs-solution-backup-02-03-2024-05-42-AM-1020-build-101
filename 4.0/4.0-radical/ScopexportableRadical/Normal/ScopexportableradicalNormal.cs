using Core;

namespace Core
{
    using System;

    public partial class ScopexportableradicalNormal
    {
        public static Int32[] NormalIntegerArray = new Int32[4] { Scopexportableascii.EntityTab, Scopexportableascii.EntityLineFeed, Scopexportableascii.EntityCarriageReturn, Scopexportableascii.EntityWhitespace };

        public static Char[] NormalCharacterArray = new Char[4] { (Char)NormalIntegerArray[0], (Char)NormalIntegerArray[1], (Char)NormalIntegerArray[2], (Char)NormalIntegerArray[3] };

        public static String NormalConcatenate = String.Concat(NormalCharacterArray);
    }
}
