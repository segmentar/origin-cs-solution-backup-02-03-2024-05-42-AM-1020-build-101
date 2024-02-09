using Core;

namespace Core
{
    using System;

    public partial class ScopexportablemoduleBody
    {
        public partial class XTriple
        {
            public static ScopexportablelevelBodyXop_rstY[] FunctionLevelSetSurface(ScopexportablelevelBodyXo_qrstY[] Level_ARRAY, Scopexportableformheadersolid[] array_SCOPEXPORTABLEHEADERSOLID)
            {
                ScopexportablelevelBodyXop_rstY[] arrayResult = default;

                var list = FunctionLevelSet(Level_ARRAY, array_SCOPEXPORTABLEHEADERSOLID);

                var array = new ScopexportablelevelBodyXop_rstY[list.Count];

                list.CopyTo(array, ScopexportablePolicy.ScopexportableIndexPolicy);

                arrayResult = array;

                return arrayResult;
            }
        }
    }
}
