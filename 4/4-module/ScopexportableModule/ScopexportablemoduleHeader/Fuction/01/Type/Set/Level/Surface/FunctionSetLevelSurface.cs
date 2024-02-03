using Core;

namespace Core
{
    using System;

    public partial class ScopexportablemoduleHeader
    {
        public partial class XSingle
        {
            public static ScopexportablelevelHeaderX_pqrstY[] FunctionLeveLSetSurface(Scopexportableextractform[] array_SCOPEXPORTABLEEXTRACTFORM, Object[] array_OBJECT)
            {
                ScopexportablelevelHeaderX_pqrstY[] arrayResult = default;

                var list = FunctionLeveLSet(array_SCOPEXPORTABLEEXTRACTFORM, array_OBJECT);

                var array = new ScopexportablelevelHeaderX_pqrstY[list.Count];

                list.CopyTo(array, ScopexportablePolicy.ScopexportableIndexPolicy);

                arrayResult = array;

                return arrayResult;
            }
        }
    }
}