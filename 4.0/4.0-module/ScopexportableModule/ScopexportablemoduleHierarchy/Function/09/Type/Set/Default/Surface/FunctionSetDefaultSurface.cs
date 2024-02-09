using Core;

namespace Core
{
    using System;

    using System.Collections;

    using System.Collections.Generic;
    using System.Collections.ObjectModel;

    public partial class ScopexportablemoduleHierarchy
    {
        public partial struct XNonuple
        {
            public static XNonuple[] FunctionDefaultSetSurface(ScopexportablelevelHierarchyUo_qrstV Level_VALUE)
            {
                XNonuple[] arrayResult = default;

                var list = FunctionDefaultSet(Level_VALUE);

                var array = new XNonuple[list.Count];

                list.CopyTo(array, ScopexportablePolicy.ScopexportableIndexPolicy);

                arrayResult = array;

                return arrayResult;
            }
        }
    }
}
