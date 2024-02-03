using Core;

namespace Core
{
    using System;

    public partial class ExpressionxportableradicalNewLine
    {
        public static Char[] EntityNewLineCharacterSeparator = new Char[2] { (Char)Expressionxportableascii.EntityCarriageReturn, (Char)Expressionxportableascii.EntityLineFeed };

        public static String EntityNewLineCharacterConcatenate = String.Concat(EntityNewLineCharacterSeparator);

        public static String[] EntityNewLineStringSeparator = new String[1] { EntityNewLineCharacterConcatenate };
    }
}