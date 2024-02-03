using Core;

namespace Core
{
    using System;

    public partial class ScopexportablemoduleScan
    {
        public partial class XTriple
        {
            public static ScopexportablelevelScanXop_rstY[] FunctionLevelSetSurface(ScopexportablelevelScanXo_qrstY[] Level_ARRAY)
            {
                ScopexportablelevelScanXop_rstY[] arrayResult = default;

                var list = FunctionLevelSet(Level_ARRAY);

                var array = new ScopexportablelevelScanXop_rstY[list.Count];

                list.CopyTo(array, ScopexportablePolicy.ScopexportableIndexPolicy);

                arrayResult = array;

                return arrayResult;
            }
        }
    }
}
