using Core;

namespace Core
{
    using System;

    public partial class ScopexportablemoduleBody
    {
        public partial class XTriple
        {
            public static XTriple ForgeLevel(ScopexportablelevelBodyXo_qrstY[] Level_ARRAY, Scopexportableformheadersolid[] array_SCOPEXPORTABLEHEADERSOLID)
            {
                XTriple xtripleResult = default;

                var array = FunctionLevelSetSurface(Level_ARRAY, array_SCOPEXPORTABLEHEADERSOLID);

                XTriple xtriple;

                xtriple = new XTriple(array);

                xtripleResult = xtriple;

                return xtripleResult;
            }
        }
    }
}
