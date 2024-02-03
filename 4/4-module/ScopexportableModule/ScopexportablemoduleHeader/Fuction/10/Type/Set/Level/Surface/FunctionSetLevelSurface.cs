using Core;

namespace Core
{
    using System;

    public partial class ScopexportablemoduleHeader
    {
        public partial class XDecuple
        {
            public static ScopexportablelevelHeaderUopq_stV[] FunctionLevelSetSurface(ScopexportablelevelHeaderUop_rstV[] Level_ARRAY)
            {
                ScopexportablelevelHeaderUopq_stV[] arrayResult = default;

                var list = FunctionLevelSet(Level_ARRAY);

                var array = new ScopexportablelevelHeaderUopq_stV[list.Count];

                list.CopyTo(array, ScopexportablePolicy.ScopexportableIndexPolicy);

                arrayResult = array;

                return arrayResult;
            }
        }
    }
}
