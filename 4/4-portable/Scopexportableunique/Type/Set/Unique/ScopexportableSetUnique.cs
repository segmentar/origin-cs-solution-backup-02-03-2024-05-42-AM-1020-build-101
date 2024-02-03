using Core;

namespace Core
{
    using System;

    using System.Collections;

    using System.Collections.Generic;
    using System.Collections.ObjectModel;

    public partial class Scopexportableunique
    {
        public static IList<Object> ScopexportableUniqueSet(Int32 Count_VALUE)
        {
            ICollection<Object> collectionResult = default;

            collectionResult = new Collection<Object>();

            var index = 0;

            while (true)
            {
                Boolean isEqualCheck, shouldBreakCheck;

                isEqualCheck = Object.Equals(Count_VALUE, index) is true;

                shouldBreakCheck = isEqualCheck is true;

                if (shouldBreakCheck is true)
                {
                    break;
                }
                else
                    "false".ToString();

                var value = new Object();

                collectionResult.Add(value);

                index = index + 1;

                continue;
            }

            return new List<Object>(collectionResult);
        }
    }
}
