using Core;

namespace Core
{
    using System;

    public partial class ScopexportablemoduleHierarchy
    {
        public partial struct XTriple
        {
            public static XTriple[] FunctionDefaultSetSurface(ScopexportablelevelHierarchyXo_qrstY Level_VALUE, Scopexportableformbodysolid value_SCOPEXPORTABLEBODYSOLID)
            {
                XTriple[] arrayResult = default;

                var list = FunctionDefaultSet(Level_VALUE, value_SCOPEXPORTABLEBODYSOLID);

                var array = new XTriple[list.Count];

                list.CopyTo(array, ScopexportablePolicy.ScopexportableIndexPolicy);

                arrayResult = array;

                return arrayResult;
            }
        }
    }
}
