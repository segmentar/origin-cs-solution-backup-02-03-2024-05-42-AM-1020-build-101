using Core;

namespace Core
{
    using System;

    public partial class ScopexportablemoduleBody
    {
        public partial class XNonuple
        {
            public static Scopexportablebodysolid[] FunctionLevelSetSurface(ScopexportablelevelBodyUo_qrstV[] Level_ARRAY)
            {
                Scopexportablebodysolid[] arrayResult = default;

                var list = FunctionLevelSet(Level_ARRAY);

                var array = new Scopexportablebodysolid[list.Count];

                list.CopyTo(array, ScopexportablePolicy.ScopexportableIndexPolicy);

                arrayResult = array;

                return arrayResult;
            }
        }
    }
}
