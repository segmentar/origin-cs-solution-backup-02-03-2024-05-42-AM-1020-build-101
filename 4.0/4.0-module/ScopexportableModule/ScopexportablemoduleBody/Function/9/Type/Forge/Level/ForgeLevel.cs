using Core;

namespace Core
{
    using System;

    public partial class ScopexportablemoduleBody
    {
        public partial class XNonuple
        {
            public static XNonuple ForgeLevel(ScopexportablelevelBodyUo_qrstV[] Level_ARRAY)
            {
                XNonuple xnonupleResult = default;

                var array = FunctionLevelSetSurface(Level_ARRAY);

                XNonuple xnonuple;

                xnonuple = new XNonuple(array);

                xnonupleResult = xnonuple;

                return xnonupleResult;
            }
        }
    }
}
