using Core;

namespace Core
{
    using System;

    public partial class ScopexportablemoduleScan
    {
        public partial class XQuadruple
        {
            public static Scopexportableformscansolid[] FunctionLevelSetSurface(ScopexportablelevelScanXop_rstY[] Level_ARRAY)
            {
                Scopexportableformscansolid[] arrayResult = default;

                var list = FunctionLevelSet(Level_ARRAY);

                var array = new Scopexportableformscansolid[list.Count];

                list.CopyTo(array, ScopexportablePolicy.ScopexportableIndexPolicy);

                arrayResult = array;

                return arrayResult;
            }
        }
    }
}
