using Core;

namespace Core
{
    using System;

    public partial class ScopexportablemoduleHierarchy
    {
        public partial struct XQuadruple
        {
            public static XQuadruple[] FunctionDefaultSetSurface(ScopexportablelevelHierarchyXop_rstY Level_VALUE)
            {
                XQuadruple[] arrayResult = default;

                var list = FunctionDefaultSet(Level_VALUE);

                var array = new XQuadruple[list.Count];

                list.CopyTo(array, ScopexportablePolicy.ScopexportableIndexPolicy);

                arrayResult = array;

                return arrayResult;
            }
        }
    }
}
