using Core;

namespace Core
{
    using System;

    public partial class ScopexportablemoduleHeader
    {
        public partial class XQuadruple
        {
            public static ScopexportablelevelHeaderXopq_stY[] FunctionLevelSetSurface(ScopexportablelevelHeaderXop_rstY[] Level_ARRAY)
            {
                ScopexportablelevelHeaderXopq_stY[] arrayResult = default;

                var list = FunctionLevelSet(Level_ARRAY);

                var array = new ScopexportablelevelHeaderXopq_stY[list.Count];

                list.CopyTo(array, ScopexportablePolicy.ScopexportableIndexPolicy);

                arrayResult = array;

                return arrayResult;
            }
        }
    }
}
