using Core;

namespace Core
{
    using System;

    public partial class ScopexportablemoduleBody
    {
        public partial class XSeptuple
        {
            public static XSeptuple ForgeLevel(ScopexportablelevelBodyXopqrs_Y[] Level_ARRAY, Scopexportableheadersolid[] array_SCOPEXPORTABLEHEADERSOLID)
            {
                XSeptuple xseptupleResult = default;

                var array = FunctionLevelSetSurface(Level_ARRAY, array_SCOPEXPORTABLEHEADERSOLID);

                XSeptuple xseptuple;

                xseptuple = new XSeptuple(array);

                xseptupleResult = xseptuple;

                return xseptupleResult;
            }
        }
    }
}
