using Core;

namespace Core
{
    using System;

    public partial class ScopexportablemoduleHierarchy
    {
        public partial struct XSextuple
        {
            public static ScopexportablelevelHierarchyXopqrs_Y[] FunctionLevelSetSurface(ScopexportablelevelHierarchyXopqr_tY[] Level_ARRAY, Scopexportableformheadersolid[] array_SCOPEXPORTABLEHEADERSOLID)
            {
                ScopexportablelevelHierarchyXopqrs_Y[] arrayResult = default;

                var list = FunctionLevelSet(Level_ARRAY, array_SCOPEXPORTABLEHEADERSOLID);

                var array = new ScopexportablelevelHierarchyXopqrs_Y[list.Count];

                list.CopyTo(array, ScopexportablePolicy.ScopexportableIndexPolicy);

                arrayResult = array;

                return arrayResult;
            }
        }
    }
}
