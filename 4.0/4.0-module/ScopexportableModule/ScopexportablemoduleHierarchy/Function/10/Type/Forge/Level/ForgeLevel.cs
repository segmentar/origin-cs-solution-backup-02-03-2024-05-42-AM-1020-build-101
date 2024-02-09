using Core;

namespace Core
{
    using System;

    public partial class ScopexportablemoduleHierarchy
    {
        public partial class XDecuple
        {
            public static XDecuple ForgeLevel(ScopexportablelevelHierarchyUop_rstV[] Level_ARRAY)
            {
                XDecuple xdecupleResult = default;

                var array = FunctionLevelSetSurface(Level_ARRAY);

                XDecuple xdecuple;

                xdecuple = new XDecuple(array);

                xdecupleResult = xdecuple;

                return xdecupleResult;
            }
        }
    }
}
