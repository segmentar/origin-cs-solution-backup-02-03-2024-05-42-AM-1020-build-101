using Core;

namespace Core
{
    using System;

    public partial class ScopexportablemoduleBody
    {
        public partial class XDouble
        {
            public static ScopexportablelevelBodyXo_qrstY[] FunctionLevelSetSurface(ScopexportablelevelBodyX_pqrstY[] Level_ARRAY)
            {
                ScopexportablelevelBodyXo_qrstY[] arrayResult = default;

                var list = FunctionLevelSet(Level_ARRAY);

                var array = new ScopexportablelevelBodyXo_qrstY[list.Count];

                list.CopyTo(array, ScopexportablePolicy.ScopexportableIndexPolicy);

                arrayResult = array;

                return arrayResult;
            }
        }
    }
}
