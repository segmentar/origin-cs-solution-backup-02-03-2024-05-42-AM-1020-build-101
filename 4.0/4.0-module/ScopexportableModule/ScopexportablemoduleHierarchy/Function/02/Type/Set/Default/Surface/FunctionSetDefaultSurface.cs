using Core;

namespace Core
{
    using System;

    public partial class ScopexportablemoduleHierarchy
    {
        public partial struct XDouble
        {
            public static XDouble[] FunctionDefaultSetSurface(ScopexportablelevelHierarchyX_pqrstY Level_VALUE, Scopexportableformheadersolid value_SCOPEXPORTABLEHEADERSOLID, Scopexportableformbodysolid value_SCOPEXPORTABLEBODYSOLID)
            {
                XDouble[] arrayResult = default;

                var list = FunctionDefaultSet(Level_VALUE, value_SCOPEXPORTABLEHEADERSOLID, value_SCOPEXPORTABLEBODYSOLID);

                var array = new XDouble[list.Count];

                list.CopyTo(array, ScopexportablePolicy.ScopexportableIndexPolicy);

                arrayResult = array;

                return arrayResult;
            }
        }
    }
}
