using Core;

namespace Core
{
    using System;

    public partial class ScopexportablemoduleBody
    {
        public partial class XSextuple
        {
            public static ScopexportablelevelBodyXopqrs_Y[] FunctionLevelSetSurface(ScopexportablelevelBodyXopqr_tY[] Level_ARRAY, Scopexportableformheadersolid[] array_SCOPEXPORTABLEHEADERSOLID)
            {
                ScopexportablelevelBodyXopqrs_Y[] arrayResult = default;

                var list = FunctionLevelSet(Level_ARRAY, array_SCOPEXPORTABLEHEADERSOLID);

                var array = new ScopexportablelevelBodyXopqrs_Y[list.Count];

                list.CopyTo(array, ScopexportablePolicy.ScopexportableIndexPolicy);

                arrayResult = array;

                return arrayResult;
            }
        }
    }
}
