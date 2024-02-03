using Core;

namespace Core
{
    using System;

    public partial class ScopexportablemoduleHeader
    {
        public partial class XSeptuple
        {
            public static ScopexportablelevelHeaderU_pqrstV[] FunctionLevelSetSurface(ScopexportablelevelHeaderXopqrs_Y[] Level_ARRAY)
            {
                ScopexportablelevelHeaderU_pqrstV[] arrayResult = default;

                var list = FunctionLevelSet(Level_ARRAY);

                var array = new ScopexportablelevelHeaderU_pqrstV[list.Count];

                list.CopyTo(array, ScopexportablePolicy.ScopexportableIndexPolicy);

                arrayResult = array;

                return arrayResult;
            }
        }
    }
}
