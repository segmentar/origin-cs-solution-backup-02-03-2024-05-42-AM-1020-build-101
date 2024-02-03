using Core;

namespace Core
{
    using System;

    public partial class ScopexportablemoduleHeader
    {
        public partial class XOctuple
        {
            public static ScopexportablelevelHeaderUo_qrstV[] FunctionLevelSetSurface(ScopexportablelevelHeaderU_pqrstV[] Level_ARRAY)
            {
                ScopexportablelevelHeaderUo_qrstV[] arrayResult = default;

                var list = FunctionLevelSet(Level_ARRAY);

                var array = new ScopexportablelevelHeaderUo_qrstV[list.Count];

                list.CopyTo(array, ScopexportablePolicy.ScopexportableIndexPolicy);

                arrayResult = array;

                return arrayResult;
            }
        }
    }
}
