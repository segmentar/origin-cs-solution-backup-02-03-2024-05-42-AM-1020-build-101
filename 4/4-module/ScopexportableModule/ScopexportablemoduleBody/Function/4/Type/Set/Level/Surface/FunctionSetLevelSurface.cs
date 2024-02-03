using Core;

namespace Core
{
    using System;

    public partial class ScopexportablemoduleBody
    {
        public partial class XQuadruple
        {
            public static ScopexportablelevelBodyXopq_stY[] FunctionLevelSetSurface(ScopexportablelevelBodyXop_rstY[] Level_ARRAY)
            {
                ScopexportablelevelBodyXopq_stY[] arrayResult = default;

                var list = FunctionLevelSet(Level_ARRAY);

                var array = new ScopexportablelevelBodyXopq_stY[list.Count];

                list.CopyTo(array, ScopexportablePolicy.ScopexportableIndexPolicy);

                arrayResult = array;

                return arrayResult;
            }
        }
    }
}
