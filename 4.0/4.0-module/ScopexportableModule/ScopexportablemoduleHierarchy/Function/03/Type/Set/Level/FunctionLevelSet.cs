using Core;

namespace Core
{
    using System;

    using System.Collections;

    using System.Collections.Generic;
    using System.Collections.ObjectModel;

    public partial class ScopexportablemoduleHierarchy
    {
        public partial struct XTriple
        {
            public static IList<ScopexportablelevelHierarchyXop_rstY> FunctionLevelSet(ScopexportablelevelHierarchyXo_qrstY[] Level_ARRAY, Scopexportableformbodysolid[] array_SCOPEXPORTABLEBODYSOLID)
            {
                ICollection<ScopexportablelevelHierarchyXop_rstY> collectionResult = default;

                collectionResult = new Collection<ScopexportablelevelHierarchyXop_rstY>();

                foreach (ScopexportablelevelHierarchyXo_qrstY Level_VALUE in Level_ARRAY)
                {
                    foreach (Scopexportableformbodysolid value_SCOPEXPORTABLEBODYSOLID in array_SCOPEXPORTABLEBODYSOLID)
                    {
                        Boolean isReferenceCheck, shouldContinueCheck;

                        isReferenceCheck = Object.ReferenceEquals(value_SCOPEXPORTABLEBODYSOLID.Object, Level_VALUE.Object) is true;

                        shouldContinueCheck = isReferenceCheck is false;

                        if (shouldContinueCheck is true)
                        {
                            continue;
                        }
                        else
                            "false".ToString();

                        var array = FunctionDefaultSetSurface(Level_VALUE, value_SCOPEXPORTABLEBODYSOLID);

                        ScopexportablelevelHierarchyXop_rstY level;

                        level = new ScopexportablelevelHierarchyXop_rstY();

                        level.Object = Level_VALUE.Object;

                        level.DirectoryInfo = Level_VALUE.DirectoryInfo;

                        level.FileInfo = Level_VALUE.FileInfo;

                        level.Text = Level_VALUE.Text;

                        level.Start = Level_VALUE.Start;

                        level.End = Level_VALUE.End;

                        level.XDoubleArray = Level_VALUE.XDoubleArray;

                        level.XTripleArray = array;

                        collectionResult.Add(level);

                        continue;
                    }

                    continue;
                }

                return new List<ScopexportablelevelHierarchyXop_rstY>(collectionResult);
            }
        }
    }
}
