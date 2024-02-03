using Core;

namespace Core
{
    using System;

    public partial class ScopexportablemoduleHeader
    {
        public partial class XQuintuple
        {
            public static ScopexportablelevelHeaderXopqr_tY[] FunctionLevelSetSurface(ScopexportablelevelHeaderXopq_stY[] Level_ARRAY)
            {
                ScopexportablelevelHeaderXopqr_tY[] arrayResult = default;

                var list = FunctionLevelSet(Level_ARRAY);

                var array = new ScopexportablelevelHeaderXopqr_tY[list.Count];

                list.CopyTo(array, ScopexportablePolicy.ScopexportableIndexPolicy);

                arrayResult = array;

                return arrayResult;
            }
        }
    }
}
