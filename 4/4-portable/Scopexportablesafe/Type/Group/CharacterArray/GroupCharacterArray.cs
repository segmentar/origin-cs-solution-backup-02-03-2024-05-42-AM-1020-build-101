using Core;

namespace Core
{
    using System;

    public partial class Scopexportablesafe
    {
        public static Char[] GroupCharacterArray(Char[] array_CHARACTER)
        {
            Char[] arrayResult = default;

            var aoth = array_CHARACTER.Length;

            var array = new Char[aoth];

            array_CHARACTER.CopyTo(array, ScopexportablePolicy.ScopexportableIndexPolicy);

            var index = 0;

            foreach (Char character in array)
            {
                var value = GroupCharacter(character);

                array[index] = value;

                index = index + 1;

                continue;
            }

            arrayResult = array;

            return arrayResult;
        }
    }
}
