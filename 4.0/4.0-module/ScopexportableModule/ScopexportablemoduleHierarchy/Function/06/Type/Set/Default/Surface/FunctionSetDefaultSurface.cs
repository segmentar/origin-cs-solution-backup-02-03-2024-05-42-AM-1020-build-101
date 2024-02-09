using Core;

namespace Core
{
    using System;

    public partial class ScopexportablemoduleHierarchy
    {
        public partial struct XSextuple
        {
            public static XSextuple[] FunctionDefaultSetSurface(ScopexportablelevelHierarchyXopqr_tY Level_VALUE, Scopexportableformheadersolid value_SCOPEXPORTABLEHEADERSOLID)
            {
                XSextuple[] arrayResult = default;

                var list = FunctionDefaultSet(Level_VALUE, value_SCOPEXPORTABLEHEADERSOLID);

                var array = new XSextuple[list.Count];

                list.CopyTo(array, ScopexportablePolicy.ScopexportableIndexPolicy);

                arrayResult = array;

                return arrayResult;
            }
        }
    }
}
