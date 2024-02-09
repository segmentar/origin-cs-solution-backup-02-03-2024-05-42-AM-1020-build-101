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
            public static IList<ScopexportablelevelHierarchyUop_rstV> FunctionLevelSet(ScopexportablelevelHierarchyUo_qrstV[] Level_ARRAY)
            {
                ICollection<ScopexportablelevelHierarchyUop_rstV> collectionResult = default;

                collectionResult = new Collection<ScopexportablelevelHierarchyUop_rstV>();

                foreach (ScopexportablelevelHierarchyUo_qrstV Level_VALUE in Level_ARRAY)
                {
                    var array = FunctionDefaultSetSurface(Level_VALUE);

                    ScopexportablelevelHierarchyUop_rstV level;

                    level = new ScopexportablelevelHierarchyUop_rstV();

                    level.Object = Level_VALUE.Object;

                    level.DirectoryInfo = Level_VALUE.DirectoryInfo;

                    level.FileInfo = Level_VALUE.FileInfo;

                    level.Text = Level_VALUE.Text;

                    level.Start = Level_VALUE.Start;

                    level.End = Level_VALUE.End;

                    level.XDoubleArray = Level_VALUE.XDoubleArray;

                    level.XTripleArray = Level_VALUE.XTripleArray;

                    level.XQuadrupleArray = Level_VALUE.XQuadrupleArray;

                    level.XQuintupleArray = Level_VALUE.XQuintupleArray;

                    level.XSextupleArray = Level_VALUE.XSextupleArray;

                    level.XSeptupleArray = Level_VALUE.XSeptupleArray;

                    level.XOctupleArray = Level_VALUE.XOctupleArray;

                    level.XNonupleArray = array;

                    collectionResult.Add(level);

                    continue;
                }

                return new List<ScopexportablelevelHierarchyUop_rstV>(collectionResult);
            }
        }
    }
}
