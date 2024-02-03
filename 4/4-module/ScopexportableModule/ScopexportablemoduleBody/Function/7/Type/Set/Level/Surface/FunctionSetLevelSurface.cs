using Core;

namespace Core
{
    using System;

    public partial class ScopexportablemoduleBody
    {
        public partial class XSeptuple
        {
            public static ScopexportablelevelBodyU_pqrstV[] FunctionLevelSetSurface(ScopexportablelevelBodyXopqrs_Y[] Level_ARRAY, Scopexportableheadersolid[] array_SCOPEXPORTABLEHEADERSOLID)
            {
                ScopexportablelevelBodyU_pqrstV[] arrayResult = default;

                var list = FunctionLevelSet(Level_ARRAY, array_SCOPEXPORTABLEHEADERSOLID);

                var array = new ScopexportablelevelBodyU_pqrstV[list.Count];

                list.CopyTo(array, ScopexportablePolicy.ScopexportableIndexPolicy);

                arrayResult = array;

                return arrayResult;
            }
        }
    }
}
