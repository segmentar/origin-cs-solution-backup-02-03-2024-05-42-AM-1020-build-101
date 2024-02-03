using Core;

namespace Core
{
    using System;

    public partial class ScopexportablemoduleBody
    {
        public partial class XQuintuple
        {
            public static ScopexportablelevelBodyXopqr_tY[] FunctionLevelSetSurface(ScopexportablelevelBodyXopq_stY[] Level_ARRAY)
            {
                ScopexportablelevelBodyXopqr_tY[] arrayResult = default;

                var list = FunctionLevelSet(Level_ARRAY);

                var array = new ScopexportablelevelBodyXopqr_tY[list.Count];

                list.CopyTo(array, ScopexportablePolicy.ScopexportableIndexPolicy);

                arrayResult = array;

                return arrayResult;
            }
        }
    }
}
