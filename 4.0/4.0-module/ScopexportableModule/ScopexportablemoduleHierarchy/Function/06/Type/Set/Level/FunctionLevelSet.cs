using Core;

namespace Core
{
    using System;

    using System.Collections;

    using System.Collections.Generic;
    using System.Collections.ObjectModel;

    public partial class ScopexportablemoduleHierarchy
    {
        public partial struct XSextuple
        {
            public static IList<ScopexportablelevelHierarchyXopqrs_Y> FunctionLevelSet(ScopexportablelevelHierarchyXopqr_tY[] Level_ARRAY, Scopexportableformheadersolid[] array_SCOPEXPORTABLEHEADERSOLID)
            {
                ICollection<ScopexportablelevelHierarchyXopqrs_Y> collectionResult = default;

                collectionResult = new Collection<ScopexportablelevelHierarchyXopqrs_Y>();

                foreach (ScopexportablelevelHierarchyXopqr_tY Level_VALUE in Level_ARRAY)
                {
                    foreach (Scopexportableformheadersolid value_SCOPEXPORTABLEHEADERSOLID in array_SCOPEXPORTABLEHEADERSOLID)
                    {
                        Boolean isReferenceCheck, shouldContinueCheck;

                        isReferenceCheck = Object.ReferenceEquals(value_SCOPEXPORTABLEHEADERSOLID.Object, Level_VALUE.Object) is true;

                        shouldContinueCheck = isReferenceCheck is false;

                        if (shouldContinueCheck is true)
                        {
                            continue;
                        }
                        else
                            "false".ToString();

                        var array = FunctionDefaultSetSurface(Level_VALUE, value_SCOPEXPORTABLEHEADERSOLID);

                        ScopexportablelevelHierarchyXopqrs_Y level;

                        level = new ScopexportablelevelHierarchyXopqrs_Y();

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

                        level.XSextupleArray = array;

                        collectionResult.Add(level);

                        continue;
                    }

                    continue;
                }

                return new List<ScopexportablelevelHierarchyXopqrs_Y>(collectionResult);
            }
        }
    }
}
