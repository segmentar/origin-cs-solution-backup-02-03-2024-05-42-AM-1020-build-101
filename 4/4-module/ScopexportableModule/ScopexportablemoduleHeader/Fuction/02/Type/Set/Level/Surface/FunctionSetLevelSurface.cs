using Core;

namespace Core
{
    using System;

    public partial class ScopexportablemoduleHeader
    {
        public partial class XDouble
        {
            public static ScopexportablelevelHeaderXo_qrstY[] FunctionLevelSetSurface(ScopexportablelevelHeaderX_pqrstY[] Level_ARRAY)
            {
                ScopexportablelevelHeaderXo_qrstY[] arrayResult = default;

                var list = FunctionLevelSet(Level_ARRAY);

                var array = new ScopexportablelevelHeaderXo_qrstY[list.Count];

                list.CopyTo(array, ScopexportablePolicy.ScopexportableIndexPolicy);

                arrayResult = array;

                return arrayResult;
            }
        }
    }
}
