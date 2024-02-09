using Core;

namespace Core
{
    using System;

    public partial class ScopexportablemoduleHeader
    {
        public partial class XSextuple
        {
            public static ScopexportableijklmnHeaderXopqrs_Y[] FunctionIjklmnSetSurface(ScopexportableijklmnHeaderXopqr_tY[] Level_ARRAY)
            {
                ScopexportableijklmnHeaderXopqrs_Y[] arrayResult = default;

                var list = FunctionIjklmnSet(Level_ARRAY);

                var array = new ScopexportableijklmnHeaderXopqrs_Y[list.Count];

                list.CopyTo(array, ScopexportablePolicy.ScopexportableIndexPolicy);

                arrayResult = array;

                return arrayResult;
            }
        }
    }
}
