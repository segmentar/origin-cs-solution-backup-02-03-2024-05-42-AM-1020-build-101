using Core;

namespace Core
{
    using System;

    using System.Collections;

    using System.Collections.Generic;
    using System.Collections.ObjectModel;

    public partial class ScopexportablemoduleHierarchy
    {
        public partial class XDecuple
        {
            public static IList<Scopexportablehierarchysolid> FunctionLevelSet(ScopexportablelevelHierarchyUop_rstV[] Level_ARRAY)
            {
                ICollection<Scopexportablehierarchysolid> collectionResult = default;

                collectionResult = new Collection<Scopexportablehierarchysolid>();

                foreach (ScopexportablelevelHierarchyUop_rstV Level_VALUE in Level_ARRAY)
                {
                    var array = FunctionNumerateSetSurface(Level_VALUE);

                    Scopexportablehierarchysolid scopexportablehierarchysolid;

                    scopexportablehierarchysolid = new Scopexportablehierarchysolid();

                    scopexportablehierarchysolid.Object = Level_VALUE.Object;

                    scopexportablehierarchysolid.ScopexportablehierarchynumeratesolidArray = array;

                    collectionResult.Add(scopexportablehierarchysolid);

                    continue;
                }

                return new List<Scopexportablehierarchysolid>(collectionResult);
            }
        }
    }
}
