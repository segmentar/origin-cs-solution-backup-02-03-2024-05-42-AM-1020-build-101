using Core;

namespace Core
{
    using System;

    public partial class ScopexportablemoduleHierarchy
    {
        public partial struct XOctuple
        {
            public static XOctuple[] FunctionDefaultSetSurface(ScopexportablelevelHierarchyU_pqrstV Level_VALUE, Scopexportableformheadersolid value_SCOPEXPORTABLEHEADERSOLID, Scopexportableformbodysolid value_SCOPEXPORTABLEBODYSOLID)
            {
                XOctuple[] arrayResult = default;

                var list = FunctionDefaultSet(Level_VALUE, value_SCOPEXPORTABLEHEADERSOLID, value_SCOPEXPORTABLEBODYSOLID);

                var array = new XOctuple[list.Count];

                list.CopyTo(array, ScopexportablePolicy.ScopexportableIndexPolicy);

                arrayResult = array;

                return arrayResult;
            }
        }
    }
}
