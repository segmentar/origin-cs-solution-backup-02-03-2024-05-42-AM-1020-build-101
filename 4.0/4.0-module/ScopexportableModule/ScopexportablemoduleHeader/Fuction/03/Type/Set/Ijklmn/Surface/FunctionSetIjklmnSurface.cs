using Core;

namespace Core
{
    using System;

    public partial class ScopexportablemoduleHeader
    {
        public partial class XTriple
        {
            public static ScopexportableijklmnHeaderXop_rstY[] FunctionIjklmnSetSurface(ScopexportableijklmnHeaderXo_qrstY[] Ijklmn_ARRAY)
            {
                ScopexportableijklmnHeaderXop_rstY[] arrayResult = default;

                var list = FunctionIjklmnSet(Ijklmn_ARRAY);

                var array = new ScopexportableijklmnHeaderXop_rstY[list.Count];

                list.CopyTo(array, ScopexportablePolicy.ScopexportableIndexPolicy);

                arrayResult = array;

                return arrayResult;
            }
        }
    }
}
