using Core;

namespace Core
{
    using System;

    public partial class ScopexportablemoduleBody
    {
        public partial class XDouble
        {
            public static XDouble ForgeLevel(ScopexportablelevelBodyX_pqrstY[] Level_ARRAY)
            {
                XDouble xdoubleResult = default;

                var array = FunctionLevelSetSurface(Level_ARRAY);

                XDouble xdouble;

                xdouble = new XDouble(array);

                xdoubleResult = xdouble;

                return xdoubleResult;
            }
        }
    }
}
