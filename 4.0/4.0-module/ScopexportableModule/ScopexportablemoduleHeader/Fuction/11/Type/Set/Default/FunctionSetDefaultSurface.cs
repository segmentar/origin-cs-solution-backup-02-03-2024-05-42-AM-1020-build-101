using Core;

namespace Core
{
    using System;

    public partial class ScopexportablemoduleHeader
    {
        public static Scopexportableformheadersolid[] FunctionDefaultSetSurface(ScopexportableijklmnHeaderUopq_stV[] Level_ARRAY)
        {
            Scopexportableformheadersolid[] arrayResult = default;

            var list = FunctionDefaultSet(Level_ARRAY);

            var array = new Scopexportableformheadersolid[list.Count];

            list.CopyTo(array, ScopexportablePolicy.ScopexportableIndexPolicy);

            arrayResult = array;

            return arrayResult;
        }
    }
}
