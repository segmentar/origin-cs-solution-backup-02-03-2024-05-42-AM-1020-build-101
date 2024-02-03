using Core;

namespace Core
{
    using System;

    public partial class ScopexportablemoduleHeader
    {
        public partial class XSextuple
        {
            public static ScopexportablelevelHeaderXopqrs_Y[] FunctionLevelSetSurface(ScopexportablelevelHeaderXopqr_tY[] Level_ARRAY)
            {
                ScopexportablelevelHeaderXopqrs_Y[] arrayResult = default;

                var list = FunctionLevelSet(Level_ARRAY);

                var array = new ScopexportablelevelHeaderXopqrs_Y[list.Count];

                list.CopyTo(array, ScopexportablePolicy.ScopexportableIndexPolicy);

                arrayResult = array;

                return arrayResult;
            }
        }
    }
}
