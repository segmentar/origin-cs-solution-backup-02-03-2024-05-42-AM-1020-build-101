using Core;

namespace Core
{
    using System;

    public partial class ScopexportablemoduleHierarchy
    {
        public partial struct XNonuple
        {
            public static ScopexportablelevelHierarchyUop_rstV[] FunctionLevelSetSurface(ScopexportablelevelHierarchyUo_qrstV[] Level_ARRAY)
            {
                ScopexportablelevelHierarchyUop_rstV[] arrayResult = default;

                var list = FunctionLevelSet(Level_ARRAY);

                var array = new ScopexportablelevelHierarchyUop_rstV[list.Count];

                list.CopyTo(array, ScopexportablePolicy.ScopexportableIndexPolicy);

                arrayResult = array;

                return arrayResult;
            }
        }
    }
}
