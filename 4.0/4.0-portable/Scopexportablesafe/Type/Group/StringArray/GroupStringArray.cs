using Core;

namespace Core
{
    using System;

    public partial class Scopexportablesafe
    {
        public static String[] GroupStringArray(String[] array_STRING)
        {
            String[] arrayResult = default;

            var aoth = array_STRING.Length;

            var array = new String[aoth];

            array_STRING.CopyTo(array, ScopexportablePolicy.ScopexportableIndexPolicy);

            var index = 0;

            foreach (String stringValue in array)
            {
                var value = GroupString(stringValue);

                array[index] = value;

                index = index + 1;

                continue;
            }

            arrayResult = array;

            return arrayResult;
        }
    }
}
