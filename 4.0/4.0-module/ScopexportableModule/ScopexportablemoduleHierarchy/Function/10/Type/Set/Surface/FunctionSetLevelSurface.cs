using Core;

namespace Core
{
    using System;

    public partial class ScopexportablemoduleHierarchy
    {
        public partial class XDecuple
        {
            public static Scopexportablehierarchysolid[] FunctionLevelSetSurface(ScopexportablelevelHierarchyUop_rstV[] Level_ARRAY)
            {
                Scopexportablehierarchysolid[] arrayResult = default;

                var list = FunctionLevelSet(Level_ARRAY);

                var array = new Scopexportablehierarchysolid[list.Count];

                list.CopyTo(array, ScopexportablePolicy.ScopexportableIndexPolicy);

                arrayResult = array;

                return arrayResult;
            }
        }
    }
}
