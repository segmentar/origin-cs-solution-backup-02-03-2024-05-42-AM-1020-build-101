using Core;

namespace Core
{
    using System;

    public partial class ScopexportablemoduleScan
    {
        public partial class XTriple
        {
            public static XTriple ForgeLevel(ScopexportablelevelScanXo_qrstY[] LevelArray)
            {
                XTriple xtripleResult = default;

                var array = FunctionLevelSetSurface(LevelArray);

                XTriple xtriple;

                xtriple = new XTriple(array);

                xtripleResult = xtriple;

                return xtripleResult;
            }
        }
    }
}
