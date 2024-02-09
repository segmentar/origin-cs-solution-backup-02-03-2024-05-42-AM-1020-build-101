using Core;

namespace Core
{
    using System;

    public partial class ScopexportablemoduleHeader
    {
        public partial class XDouble
        {
            public static ScopexportableijklmnHeaderXo_qrstY[] FunctionIjklmnSetSurface(ScopexportableijklmnHeaderX_pqrstY[] Ijklmn_ARRAY)
            {
                ScopexportableijklmnHeaderXo_qrstY[] arrayResult = default;

                var list = FunctionIjklmnSet(Ijklmn_ARRAY);

                var array = new ScopexportableijklmnHeaderXo_qrstY[list.Count];

                list.CopyTo(array, ScopexportablePolicy.ScopexportableIndexPolicy);

                arrayResult = array;

                return arrayResult;
            }
        }
    }
}
