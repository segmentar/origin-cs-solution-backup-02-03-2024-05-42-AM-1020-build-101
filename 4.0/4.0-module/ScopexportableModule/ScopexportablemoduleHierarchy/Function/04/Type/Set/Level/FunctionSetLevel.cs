using Core;

namespace Core
{
    using System;

    using System.Collections;

    using System.Collections.Generic;
    using System.Collections.ObjectModel;

    public partial class ScopexportablemoduleHierarchy
    {
        public partial struct XQuadruple
        {
            public static IList<ScopexportablelevelHierarchyXopq_stY> FunctionLevelSet(ScopexportablelevelHierarchyXop_rstY[] Level_ARRAY)
            {
                ICollection<ScopexportablelevelHierarchyXopq_stY> collectionResult = default;

                collectionResult = new Collection<ScopexportablelevelHierarchyXopq_stY>();

                foreach (ScopexportablelevelHierarchyXop_rstY Level_VALUE in Level_ARRAY)
                {
                    var array = FunctionDefaultSetSurface(Level_VALUE);

                    ScopexportablelevelHierarchyXopq_stY level;

                    level = new ScopexportablelevelHierarchyXopq_stY();

                    level.Object = Level_VALUE.Object;

                    level.DirectoryInfo = Level_VALUE.DirectoryInfo;

                    level.FileInfo = Level_VALUE.FileInfo;

                    level.Text = Level_VALUE.Text;

                    level.Start = Level_VALUE.Start;

                    level.End = Level_VALUE.End;

                    level.XDoubleArray = Level_VALUE.XDoubleArray;

                    level.XTripleArray = Level_VALUE.XTripleArray;

                    level.XQuadrupleArray = array;

                    collectionResult.Add(level);

                    continue;
                }

                return new List<ScopexportablelevelHierarchyXopq_stY>(collectionResult);
            }
        }
    }
}
