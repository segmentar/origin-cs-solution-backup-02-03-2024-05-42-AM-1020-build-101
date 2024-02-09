using Core;

namespace Core
{
    using System;

    public partial class ScopexportablemoduleUnite
    {
        public partial class XSingle
        {
            public static XSingle ForgeLevel(Object[] array_OBJECT, Scopexportableformcoordinate[] array_SCOPEXPORTABLEEXTRACTFORM, Scopexportableformheadersolid[] array_SCOPEXPORTABLEHEADERSOLID, Scopexportableformbodysolid[] array_SCOPEXPORTABLEBODYSOLID, Scopexportablehierarchysolid[] array_SCOPEXPORTABLEHIERARCHYSOLID)
            {
                XSingle xsingleResult = default;

                var array = FunctionLevelSetSurface(array_OBJECT, array_SCOPEXPORTABLEEXTRACTFORM, array_SCOPEXPORTABLEHEADERSOLID, array_SCOPEXPORTABLEBODYSOLID, array_SCOPEXPORTABLEHIERARCHYSOLID);

                XSingle xsingle;

                xsingle = new XSingle(array);

                xsingleResult = xsingle;

                return xsingleResult;
            }
        }
    }
}
