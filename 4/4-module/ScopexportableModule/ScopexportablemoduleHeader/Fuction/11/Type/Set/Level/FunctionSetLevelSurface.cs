using Core;

namespace Core
{
    using System;

    public partial class ScopexportablemoduleHeader
    {
        public static Scopexportableheadersolid[] FunctionLevelSetSurface(ScopexportablelevelHeaderUopq_stV[] Level_ARRAY)
        {
            Scopexportableheadersolid[] arrayResult = default;

            var list = FunctionLevelSet(Level_ARRAY);

            var array = new Scopexportableheadersolid[list.Count];

            list.CopyTo(array, ScopexportablePolicy.ScopexportableIndexPolicy);

            arrayResult = array;

            return arrayResult;
        }
    }
}
