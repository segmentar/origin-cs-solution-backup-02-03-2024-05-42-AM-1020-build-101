using Core;

namespace Core
{
    using System;

    public partial class ScopexportablemoduleUnite
    {
        public partial class XSingle
        {
            public static Scopexportableformbuildsolid[] FunctionLevelSetSurface(Object[] array_OBJECT, Scopexportableformcoordinate[] array_SCOPEXPORTABLEEXTRACTFORM, Scopexportableformheadersolid[] array_SCOPEXPORTABLEHEADERSOLID, Scopexportableformbodysolid[] array_SCOPEXPORTABLEBODYSOLID, Scopexportablehierarchysolid[] array_SCOPEXPORTABLEHIERARCHYSOLID)
            {
                Scopexportableformbuildsolid[] arrayResult = default;

                var list = FunctionLevelSet(array_OBJECT, array_SCOPEXPORTABLEEXTRACTFORM, array_SCOPEXPORTABLEHEADERSOLID, array_SCOPEXPORTABLEBODYSOLID, array_SCOPEXPORTABLEHIERARCHYSOLID);

                var array = new Scopexportableformbuildsolid[list.Count];

                list.CopyTo(array, ScopexportablePolicy.ScopexportableIndexPolicy);

                arrayResult = array;

                return arrayResult;
            }
        }
    }
}
