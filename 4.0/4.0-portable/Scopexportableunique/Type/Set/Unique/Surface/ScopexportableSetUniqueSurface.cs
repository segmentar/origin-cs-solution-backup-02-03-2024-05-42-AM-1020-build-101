using Core;

namespace Core
{
    using System;

    public partial class Scopexportableunique
    {
        public static Object[] ScopexportableUniqueSetSurface(Int32 Count_VALUE)
        {
            Object[] arrayResult = default;

            var list = ScopexportableUniqueSet(Count_VALUE);

            var array = new Object[list.Count];

            list.CopyTo(array, ScopexportablePolicy.ScopexportableIndexPolicy);

            arrayResult = array;

            return arrayResult;
        }
    }
}
