using Core;

namespace Core
{
    using System;

    public partial class ScopexportablemoduleBody
    {
        public partial class XSextuple
        {
            public static String[] FunctionStringSetSurface(ScopexportablelevelBodyXopqr_tY Level_VALUE, Scopexportableformheadersolid value_SCOPEXPORTABLEHEADERSOLID)
            {
                String[] arrayResult = default;

                var list = FunctionStringSet(Level_VALUE, value_SCOPEXPORTABLEHEADERSOLID);

                var array = new String[list.Count];

                list.CopyTo(array, ScopexportablePolicy.ScopexportableIndexPolicy);

                arrayResult = array;

                return arrayResult;
            }
        }
    }
}