using Core;

namespace Core
{
    using System;

    using System.Collections;

    using System.Collections.Generic;
    using System.Collections.ObjectModel;

    public partial class ScopexportablemoduleHierarchy
    {
        public partial struct XQuintuple
        {
            public static IList<ScopexportablelevelHierarchyXopqr_tY> FunctionLevelSet(ScopexportablelevelHierarchyXopq_stY[] Level_ARRAY)
            {
                ICollection<ScopexportablelevelHierarchyXopqr_tY> collectionResult = default;

                collectionResult = new Collection<ScopexportablelevelHierarchyXopqr_tY>();

                foreach (ScopexportablelevelHierarchyXopq_stY Level_VALUE in Level_ARRAY)
                {
                    var array = FunctionDefaultSetSurface(Level_VALUE);

                    ScopexportablelevelHierarchyXopqr_tY level;

                    level = new ScopexportablelevelHierarchyXopqr_tY();

                    level.Object = Level_VALUE.Object;

                    level.DirectoryInfo = Level_VALUE.DirectoryInfo;

                    level.FileInfo = Level_VALUE.FileInfo;

                    level.Text = Level_VALUE.Text;

                    level.Start = Level_VALUE.Start;

                    level.End = Level_VALUE.End;

                    level.XDoubleArray = Level_VALUE.XDoubleArray;

                    level.XTripleArray = Level_VALUE.XTripleArray;

                    level.XQuadrupleArray = Level_VALUE.XQuadrupleArray;

                    level.XQuintupleArray = array;

                    collectionResult.Add(level);

                    continue;
                }

                return new List<ScopexportablelevelHierarchyXopqr_tY>(collectionResult);
            }
        }
    }
}
