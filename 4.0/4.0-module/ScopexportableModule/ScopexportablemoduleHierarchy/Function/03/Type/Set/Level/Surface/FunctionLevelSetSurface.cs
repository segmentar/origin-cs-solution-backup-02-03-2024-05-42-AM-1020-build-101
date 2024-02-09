using Core;

namespace Core
{
    using System;

    public partial class ScopexportablemoduleHierarchy
    {
        public partial struct XTriple
        {
            public static ScopexportablelevelHierarchyXop_rstY[] FunctionLevelSetSurface(ScopexportablelevelHierarchyXo_qrstY[] Level_ARRAY, Scopexportableformbodysolid[] array_SCOPEXPORTABLEBODYSOLID)
            {
                ScopexportablelevelHierarchyXop_rstY[] arrayResult = default;

                var list = FunctionLevelSet(Level_ARRAY, array_SCOPEXPORTABLEBODYSOLID);

                var array = new ScopexportablelevelHierarchyXop_rstY[list.Count];

                list.CopyTo(array, ScopexportablePolicy.ScopexportableIndexPolicy);

                arrayResult = array;

                return arrayResult;
            }
        }
    }
}
