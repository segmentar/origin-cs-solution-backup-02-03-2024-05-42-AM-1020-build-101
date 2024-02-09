using Core;

namespace Core
{
    using System;

    public partial class ScopexportablemoduleBody
    {
        public partial class XNonuple
        {
            public static Scopexportableformbodysolid[] FunctionLevelSetSurface(ScopexportablelevelBodyUo_qrstV[] Level_ARRAY)
            {
                Scopexportableformbodysolid[] arrayResult = default;

                var list = FunctionLevelSet(Level_ARRAY);

                var array = new Scopexportableformbodysolid[list.Count];

                list.CopyTo(array, ScopexportablePolicy.ScopexportableIndexPolicy);

                arrayResult = array;

                return arrayResult;
            }
        }
    }
}
