using Core;

namespace Core
{
    using System;

    public partial class ScopexportablemoduleScan
    {
        public partial class XQuadruple
        {
            public static XQuadruple ForgeLevel(ScopexportablelevelScanXop_rstY[] Level_ARRAY)
            {
                XQuadruple xquadrupleResult = default;

                var array = FunctionLevelSetSurface(Level_ARRAY);

                XQuadruple xquadruple;

                xquadruple = new XQuadruple(array);

                xquadrupleResult = xquadruple;

                return xquadrupleResult;
            }
        }
    }
}
