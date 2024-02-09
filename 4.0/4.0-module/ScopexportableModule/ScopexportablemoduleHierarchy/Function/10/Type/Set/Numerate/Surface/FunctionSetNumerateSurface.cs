using Core;

namespace Core
{
    using System;

    public partial class ScopexportablemoduleHierarchy
    {
        public partial class XDecuple
        {
            public static Scopexportablehierarchynumeratesolid[] FunctionNumerateSetSurface(ScopexportablelevelHierarchyUop_rstV Level_VALUE)
            {
                Scopexportablehierarchynumeratesolid[] arrayResult = default;

                var list = FunctionNumerateSet(Level_VALUE);

                var array = new Scopexportablehierarchynumeratesolid[list.Count];

                list.CopyTo(array, ScopexportablePolicy.ScopexportableIndexPolicy);

                arrayResult = array;

                return arrayResult;
            }
        }
    }
}
