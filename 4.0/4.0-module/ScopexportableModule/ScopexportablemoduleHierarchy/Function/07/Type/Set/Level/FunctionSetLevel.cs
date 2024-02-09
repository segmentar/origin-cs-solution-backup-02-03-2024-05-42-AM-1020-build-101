using Core;

namespace Core
{
    using System;

    using System.Collections;

    using System.Collections.Generic;
    using System.Collections.ObjectModel;

    public partial class ScopexportablemoduleHierarchy
    {
        public partial struct XSeptuple
        {
            public static IList<ScopexportablelevelHierarchyU_pqrstV> FunctionLevelSet(ScopexportablelevelHierarchyXopqrs_Y[] Level_ARRAY)
            {
                ICollection<ScopexportablelevelHierarchyU_pqrstV> collectionResult = default;

                collectionResult = new Collection<ScopexportablelevelHierarchyU_pqrstV>();

                foreach (ScopexportablelevelHierarchyXopqrs_Y Level_VALUE in Level_ARRAY)
                {
                    var array = FunctionDefaultSetSurface(Level_VALUE);

                    ScopexportablelevelHierarchyU_pqrstV level;

                    level = new ScopexportablelevelHierarchyU_pqrstV();

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

                    level.XSeptupleArray = array;

                    collectionResult.Add(level);

                    continue;
                }

                return new List<ScopexportablelevelHierarchyU_pqrstV>(collectionResult);
            }
        }
    }
}
