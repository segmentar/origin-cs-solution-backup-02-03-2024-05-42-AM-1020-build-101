using Core;

namespace Core
{
    using System;

    public partial class ScopexportablemoduleScan
    {
        public partial class XSingle
        {
            public static ScopexportablelevelScanX_pqrstY[] FunctionLevelSetSurface(String DirectoryFullName___VALUE)
            {
                ScopexportablelevelScanX_pqrstY[] arrayResult = default;

                var list = FunctionLevelSet(DirectoryFullName___VALUE);

                var array = new ScopexportablelevelScanX_pqrstY[list.Count];

                list.CopyTo(array, ScopexportablePolicy.ScopexportableIndexPolicy);

                arrayResult = array;

                return arrayResult;
            }
        }
    }
}
