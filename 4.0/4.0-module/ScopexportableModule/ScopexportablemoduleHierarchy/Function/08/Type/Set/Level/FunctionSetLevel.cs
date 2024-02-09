using Core;

namespace Core
{
    using System;

    using System.Collections;

    using System.Collections.Generic;
    using System.Collections.ObjectModel;

    public partial class ScopexportablemoduleHierarchy
    {
        public partial struct XOctuple
        {
            public static IList<ScopexportablelevelHierarchyUo_qrstV> FunctionLevelSet(ScopexportablelevelHierarchyU_pqrstV[] Level_ARRAY, Scopexportableformheadersolid[] array_SCOPEXPORTABLEHEADERSOLID, Scopexportableformbodysolid[] array_SCOPEXPORTABLEBODYSOLID)
            {
                ICollection<ScopexportablelevelHierarchyUo_qrstV> collectionResult = default;

                collectionResult = new Collection<ScopexportablelevelHierarchyUo_qrstV>();

                foreach (ScopexportablelevelHierarchyU_pqrstV Level_VALUE in Level_ARRAY)
                {
                    foreach (Scopexportableformheadersolid value_SCOPEXPORTABLEHEADERSOLID in array_SCOPEXPORTABLEHEADERSOLID)
                    {
                        foreach (Scopexportableformbodysolid value_SCOPEXPORTABLEBODYSOLID in array_SCOPEXPORTABLEBODYSOLID)
                        {
                            var boolean = true;

                            boolean = boolean && Object.ReferenceEquals(value_SCOPEXPORTABLEHEADERSOLID.Object, Level_VALUE.Object) is true;

                            boolean = boolean && Object.ReferenceEquals(value_SCOPEXPORTABLEBODYSOLID.Object, Level_VALUE.Object) is true;

                            Boolean isReferenceCheck, shouldContinueCheck;

                            isReferenceCheck = boolean is true;

                            shouldContinueCheck = isReferenceCheck is false;

                            if (shouldContinueCheck is true)
                            {
                                continue;
                            }
                            else
                                "false".ToString();

                            var array = FunctionDefaultSetSurface(Level_VALUE, value_SCOPEXPORTABLEHEADERSOLID, value_SCOPEXPORTABLEBODYSOLID);

                            ScopexportablelevelHierarchyUo_qrstV level;

                            level = new ScopexportablelevelHierarchyUo_qrstV();

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

                            level.XOctupleArray = array;

                            collectionResult.Add(level);

                            continue;
                        }

                        continue;
                    }

                    continue;
                }

                return new List<ScopexportablelevelHierarchyUo_qrstV>(collectionResult);
            }
        }
    }
}
