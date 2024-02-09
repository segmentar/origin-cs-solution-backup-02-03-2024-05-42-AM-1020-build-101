using Core;

namespace Core
{
    using System;

    public partial class ScopexportablemoduleHierarchy
    {
        public partial struct XDouble
        {
            public static ScopexportablelevelHierarchyXo_qrstY[] FunctionLevelSetSurface(ScopexportablelevelHierarchyX_pqrstY[] Level_ARRAY, Scopexportableformheadersolid[] array_SCOPEXPORTABLEHEADERSOLID, Scopexportableformbodysolid[] array_SCOPEXPORTABLEBODYSOLID)
            {
                ScopexportablelevelHierarchyXo_qrstY[] arrayResult = default;

                var list = FunctionLevelSet(Level_ARRAY, array_SCOPEXPORTABLEHEADERSOLID, array_SCOPEXPORTABLEBODYSOLID);

                var array = new ScopexportablelevelHierarchyXo_qrstY[list.Count];

                list.CopyTo(array, ScopexportablePolicy.ScopexportableIndexPolicy);

                arrayResult = array;

                return arrayResult;
            }
        }
    }
}