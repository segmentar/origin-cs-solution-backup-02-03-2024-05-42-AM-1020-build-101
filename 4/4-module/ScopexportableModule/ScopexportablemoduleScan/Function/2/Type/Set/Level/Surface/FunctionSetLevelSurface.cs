using Core;

namespace Core
{
    using System;

    public partial class ScopexportablemoduleScan
    {
        public partial class XDouble
        {
            public static ScopexportablelevelScanXo_qrstY[] FunctionLevelSetSurface(ScopexportablelevelScanX_pqrstY[] Level_ARRAY)
            {
                ScopexportablelevelScanXo_qrstY[] arrayResult = default;

                var list = FunctionLevelSet(Level_ARRAY);

                var array = new ScopexportablelevelScanXo_qrstY[list.Count];

                list.CopyTo(array, ScopexportablePolicy.ScopexportableIndexPolicy);

                arrayResult = array;

                return arrayResult;
            }
        }
    }
}
