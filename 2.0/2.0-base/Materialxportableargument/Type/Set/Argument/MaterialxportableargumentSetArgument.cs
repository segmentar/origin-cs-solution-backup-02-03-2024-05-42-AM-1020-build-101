using Core;

namespace Core
{
    using System;

    using System.Collections;

    using System.Collections.Generic;
    using System.Collections.ObjectModel;

    public partial class Materialxportableargument
    {
        public static IList<Object> MaterialxportableargumentArgumentSet(Materialxportable materialxportable)
        {
            ICollection<Object> collectionResult = default;

            collectionResult = new LinkedList<Object>();

            foreach (Materialxportable value in (Materialxportable[])materialxportable.SegmentArrayObject)
            {
                Boolean isDefaultCheck, shouldContinueCheck;

                isDefaultCheck = (value == default).Equals(true);

                shouldContinueCheck = isDefaultCheck is true;

                if (shouldContinueCheck is true)
                {
                    continue;
                }
                else
                    "false".ToString();

                var array = MaterialxportableargumentArgumentSetSurface(materialxportable);

                foreach (Object value_OBJECT in array)
                {
                    collectionResult.Add(value_OBJECT);

                    continue;
                }

                continue;
            }

            return new List<Object>(collectionResult);
        }
    }
}
