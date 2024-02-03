using Core;

namespace Core
{
    using System;

    public partial class ScopexportablemoduleHeader
    {
        public partial class XNonuple
        {
            public static ScopexportablelevelHeaderUop_rstV[] FunctionLevelSetSurface(ScopexportablelevelHeaderUo_qrstV[] Level_ARRAY)
            {
                ScopexportablelevelHeaderUop_rstV[] arrayResult = default;

                var list = FunctionLevelSet(Level_ARRAY);

                var array = new ScopexportablelevelHeaderUop_rstV[list.Count];

                list.CopyTo(array, ScopexportablePolicy.ScopexportableIndexPolicy);

                arrayResult = array;

                return arrayResult;
            }
        }
    }
}
