using Core;

namespace Core
{
    using System;

    using System.Linq;

    using System.Collections;

    public partial class Coregithub
    {
        public static T[] CoregithubRebaseContainerSurface<T>(String[] Filesystem_ARRAY, String Rebase_ITEM, String Rebase_ENTRY)
        {
            T[] arrayResult = default;

            IEnumerable enumerable;

            enumerable = CoregithubRebaseContainer(Filesystem_ARRAY, Rebase_ITEM, Rebase_ENTRY);

            enumerable = enumerable.OfType<T>();

            var result = enumerable.Cast<T>();

            var array = result.ToArray<T>();

            arrayResult = array;

            return arrayResult;
        }
    }
}
