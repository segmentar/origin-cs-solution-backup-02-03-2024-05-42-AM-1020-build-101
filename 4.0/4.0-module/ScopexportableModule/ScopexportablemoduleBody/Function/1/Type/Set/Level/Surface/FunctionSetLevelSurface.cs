using Core;

namespace Core
{
    using System;

    public partial class ScopexportablemoduleBody
    {
        public partial class XSingle
        {
            public static ScopexportablelevelBodyX_pqrstY[] FunctionLevelSetSurface(Scopexportableformcoordinate[] array_SCOPEXPORTABLEEXTRACTFORM, Object[] array_OBJECT)
            {
                ScopexportablelevelBodyX_pqrstY[] arrayResult = default;

                var list = FunctionLevelSet(array_SCOPEXPORTABLEEXTRACTFORM, array_OBJECT);

                var array = new ScopexportablelevelBodyX_pqrstY[list.Count];

                list.CopyTo(array, ScopexportablePolicy.ScopexportableIndexPolicy);

                arrayResult = array;

                return arrayResult;
            }
        }
    }
}
