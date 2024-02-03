using Core;

namespace Core
{
    using System;

    public partial class ScopexportablemoduleScan
    {
        public partial class XQuadruple
        {
            public static Scopexportablescansolid[] FunctionLevelSetSurface(ScopexportablelevelScanXop_rstY[] Level_ARRAY)
            {
                Scopexportablescansolid[] arrayResult = default;

                var list = FunctionLevelSet(Level_ARRAY);

                var array = new Scopexportablescansolid[list.Count];

                list.CopyTo(array, ScopexportablePolicy.ScopexportableIndexPolicy);

                arrayResult = array;

                return arrayResult;
            }
        }
    }
}
