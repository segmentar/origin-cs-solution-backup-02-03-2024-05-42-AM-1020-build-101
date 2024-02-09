using Core;

namespace Core
{
    using System;

    public partial class ScopexportablemoduleHierarchy
    {
        public partial struct XQuadruple
        {
            public static ScopexportablelevelHierarchyXopq_stY[] FunctionLevelSetSurface(ScopexportablelevelHierarchyXop_rstY[] Level_ARRAY)
            {
                ScopexportablelevelHierarchyXopq_stY[] arrayResult = default;

                var list = FunctionLevelSet(Level_ARRAY);

                var array = new ScopexportablelevelHierarchyXopq_stY[list.Count];

                list.CopyTo(array, ScopexportablePolicy.ScopexportableIndexPolicy);

                arrayResult = array;

                return arrayResult;
            }
        }
    }
}
