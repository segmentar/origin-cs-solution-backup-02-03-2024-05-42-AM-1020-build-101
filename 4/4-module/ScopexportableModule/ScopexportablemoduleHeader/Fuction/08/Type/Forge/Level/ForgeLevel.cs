using Core;

namespace Core
{
    using System;

    public partial class ScopexportablemoduleHeader
    {
        public partial class XOctuple
        {
            public static XOctuple ForgeLevel(ScopexportablelevelHeaderU_pqrstV[] Level_ARRAY)
            {
                XOctuple xoctupleResult = default;

                var array = FunctionLevelSetSurface(Level_ARRAY);

                XOctuple xoctuple;

                xoctuple = new XOctuple(array);

                xoctupleResult = xoctuple;

                return xoctupleResult;
            }
        }
    }
}
