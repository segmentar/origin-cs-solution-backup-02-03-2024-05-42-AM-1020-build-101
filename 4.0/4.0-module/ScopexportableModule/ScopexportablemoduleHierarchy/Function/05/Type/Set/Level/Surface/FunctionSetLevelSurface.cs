using Core;

namespace Core
{
    using System;

    public partial class ScopexportablemoduleHierarchy
    {
        public partial struct XQuintuple
        {
            public static ScopexportablelevelHierarchyXopqr_tY[] FunctionLevelSetSurface(ScopexportablelevelHierarchyXopq_stY[] Level_ARRAY)
            {
                ScopexportablelevelHierarchyXopqr_tY[] arrayResult = default;

                var list = FunctionLevelSet(Level_ARRAY);

                var array = new ScopexportablelevelHierarchyXopqr_tY[list.Count];

                list.CopyTo(array, ScopexportablePolicy.ScopexportableIndexPolicy);

                arrayResult = array;

                return arrayResult;
            }
        }
    }
}
