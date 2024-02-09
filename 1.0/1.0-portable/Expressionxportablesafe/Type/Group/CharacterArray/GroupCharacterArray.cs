using Core;

namespace Core
{
    using System;

    public partial class Expressionxportablesafe
    {
        public static Char[] GroupCharacterArray(Char[] array_CHARACTER)
        {
            Char[] arrayResult = default;

            var aoth = array_CHARACTER.Length;

            var array = new Char[aoth];

            array_CHARACTER.CopyTo(array, ExpressionxportablePolicy.ExpressionxportableIndexPolicy);

            var indexer = 0;

            foreach (Char character in array)
            {
                var result = GroupCharacter(character);

                array[indexer] = result;

                indexer = indexer + 1;

                continue;
            }

            arrayResult = array;

            return arrayResult;
        }
    }
}
