using Core;

namespace Core
{
    using System;

    public partial class ScopexportablemoduleHierarchy
    {
        public partial struct XOctuple
        {
            public static ScopexportablelevelHierarchyUo_qrstV[] FunctionLevelSetSurface(ScopexportablelevelHierarchyU_pqrstV[] Level_ARRAY, Scopexportableformheadersolid[] array_SCOPEXPORTABLEHEADERSOLID, Scopexportableformbodysolid[] array_SCOPEXPORTABLEBODYSOLID)
            {
                ScopexportablelevelHierarchyUo_qrstV[] arrayResult = default;

                var list = FunctionLevelSet(Level_ARRAY, array_SCOPEXPORTABLEHEADERSOLID, array_SCOPEXPORTABLEBODYSOLID);

                var array = new ScopexportablelevelHierarchyUo_qrstV[list.Count];

                list.CopyTo(array, ScopexportablePolicy.ScopexportableIndexPolicy);

                arrayResult = array;

                return arrayResult;
            }
        }
    }
}
