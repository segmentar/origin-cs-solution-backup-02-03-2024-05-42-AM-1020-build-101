using Core;

namespace Core
{
    using System;

    public partial class ScopexportablemoduleHierarchy
    {
        public partial struct XSeptuple
        {
            public static XSeptuple[] FunctionDefaultSetSurface(ScopexportablelevelHierarchyXopqrs_Y Level_VALUE)
            {
                XSeptuple[] arrayResult = default;

                var list = FunctionDefaultSet(Level_VALUE);

                var array = new XSeptuple[list.Count];

                list.CopyTo(array, ScopexportablePolicy.ScopexportableIndexPolicy);

                arrayResult = array;

                return arrayResult;
            }
        }
    }
}
