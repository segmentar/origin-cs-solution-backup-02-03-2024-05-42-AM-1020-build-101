using Core;

namespace Core
{
    using System;

    public partial class ScopexportablemoduleHeader
    {
        public partial class XTriple
        {
            public static ScopexportablelevelHeaderXop_rstY[] FunctionLevelSetSurface(ScopexportablelevelHeaderXo_qrstY[] Level_ARRAY)
            {
                ScopexportablelevelHeaderXop_rstY[] arrayResult = default;

                var list = FunctionLevelSet(Level_ARRAY);

                var array = new ScopexportablelevelHeaderXop_rstY[list.Count];

                list.CopyTo(array, ScopexportablePolicy.ScopexportableIndexPolicy);

                arrayResult = array;

                return arrayResult;
            }
        }
    }
}
