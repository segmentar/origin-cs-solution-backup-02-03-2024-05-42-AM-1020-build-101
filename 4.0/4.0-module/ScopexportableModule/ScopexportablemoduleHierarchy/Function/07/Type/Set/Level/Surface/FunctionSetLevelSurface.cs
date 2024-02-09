using Core;

namespace Core
{
    using System;

    public partial class ScopexportablemoduleHierarchy
    {
        public partial struct XSeptuple
        {
            public static ScopexportablelevelHierarchyU_pqrstV[] FunctionLevelSetSurface(ScopexportablelevelHierarchyXopqrs_Y[] Level_ARRAY)
            {
                ScopexportablelevelHierarchyU_pqrstV[] arrayResult = default;

                var list = FunctionLevelSet(Level_ARRAY);

                var array = new ScopexportablelevelHierarchyU_pqrstV[list.Count];

                list.CopyTo(array, ScopexportablePolicy.ScopexportableIndexPolicy);

                arrayResult = array;

                return arrayResult;
            }
        }
    }
}
