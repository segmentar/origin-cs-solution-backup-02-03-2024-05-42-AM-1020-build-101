using Core;

namespace Core
{
    using System;

    public partial class ScopexportablemoduleBody
    {
        public partial class XSeptuple
        {
            public static String[] FunctionStringSetSurface(ScopexportablelevelBodyXopqrs_Y Level_VALUE, Scopexportableheadersolid value_SCOPEXPORTABLEHEADERSOLID)
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