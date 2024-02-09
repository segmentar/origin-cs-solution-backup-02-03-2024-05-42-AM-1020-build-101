using Core;

namespace Core
{
    using System;

    public partial class ScopexportablemoduleHierarchy
    {
        public partial class XSingle
        {
            public static ScopexportablelevelHierarchyX_pqrstY[] FunctionLevelSetSurface(Scopexportableformcoordinate[] array_SCOPEXPORTABLEEXTRACTFORM, Object[] array_OBJECT)
            {
                ScopexportablelevelHierarchyX_pqrstY[] arrayResult = default;

                var list = FunctionLevelSet(array_SCOPEXPORTABLEEXTRACTFORM, array_OBJECT);

                var array = new ScopexportablelevelHierarchyX_pqrstY[list.Count];

                list.CopyTo(array, ScopexportablePolicy.ScopexportableIndexPolicy);

                arrayResult = array;

                return arrayResult;
            }
        }
    }
}
