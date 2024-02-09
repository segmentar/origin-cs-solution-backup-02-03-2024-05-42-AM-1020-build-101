using Core;

namespace Core
{
    using System;

    public partial class Bootxportableinline
    {
        public static Materialxportable Inline(String[] array_STRING)
        {
            Materialxportable materialxportableResult = default;

            var value = Materialxportableapi.Root();

            var indexer = 0;

            foreach (String value_STRING in array_STRING)
            {
                if (Object.Equals(indexer, 0))
                {
                    Materialxportableapi.DTAK(value, value_STRING);
                }
                else if (Object.Equals(indexer, 1))
                {
                    Materialxportableapi.DHAM(value, value_STRING);
                }
                else if (Object.Equals(indexer, 2))
                {
                    Materialxportableapi.DMAN(value, value_STRING);
                }
                else if (Object.Equals(indexer, 3))
                {
                    Materialxportableapi.DNAL(value, value_STRING);
                }
                else if (Object.Equals(indexer, 4))
                {
                    Materialxportableapi.DSAJ(value, value_STRING);
                }
                else if (Object.Equals(indexer, 5))
                {
                    Materialxportableapi.DKAI(value, value_STRING);
                }

                indexer = indexer + 1;

                continue;
            }

            materialxportableResult = value;

            return materialxportableResult;
        }
    }
}
