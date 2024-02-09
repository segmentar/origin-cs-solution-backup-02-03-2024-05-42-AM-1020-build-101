using Core;

namespace Core
{
    using System;

    public partial class ScopexportablemoduleBody
    {
        public partial class XSextuple
        {
            public static XSextuple ForgeLevel(ScopexportablelevelBodyXopqr_tY[] Level_ARRAY, Scopexportableformheadersolid[] array_SCOPEXPORTABLEHEADERSOLID)
            {
                XSextuple xsextupleResult = default;

                var array = FunctionLevelSetSurface(Level_ARRAY, array_SCOPEXPORTABLEHEADERSOLID);

                XSextuple xsextuple;

                xsextuple = new XSextuple(array);

                xsextupleResult = xsextuple;

                return xsextupleResult;
            }
        }
    }
}
