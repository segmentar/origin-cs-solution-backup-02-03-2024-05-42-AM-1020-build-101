using Core;

namespace Core
{
    using System;

    public partial class ScopexportablemoduleHeader
    {
        public partial class XDecuple
        {
            public static ScopexportableijklmnHeaderUopq_stV[] FunctionIjklmnSetSurface(ScopexportableijklmnHeaderUop_rstV[] Level_ARRAY)
            {
                ScopexportableijklmnHeaderUopq_stV[] arrayResult = default;

                var list = FunctionIjklmnSet(Level_ARRAY);

                var array = new ScopexportableijklmnHeaderUopq_stV[list.Count];

                list.CopyTo(array, ScopexportablePolicy.ScopexportableIndexPolicy);

                arrayResult = array;

                return arrayResult;
            }
        }
    }
}
