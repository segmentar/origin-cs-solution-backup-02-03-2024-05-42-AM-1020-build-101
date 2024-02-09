using Core;

namespace Core
{
    using System;

    using System.Collections;

    using System.Collections.Generic;
    using System.Collections.ObjectModel;

    public partial class ScopexportablemoduleHierarchy
    {
        public partial struct XDouble
        {
            public static IList<ScopexportablelevelHierarchyXo_qrstY> FunctionLevelSet(ScopexportablelevelHierarchyX_pqrstY[] Level_ARRAY, Scopexportableformheadersolid[] array_SCOPEXPORTABLEHEADERSOLID, Scopexportableformbodysolid[] array_SCOPEXPORTABLEBODYSOLID)
            {
                ICollection<ScopexportablelevelHierarchyXo_qrstY> collectionResult = default;

                collectionResult = new Collection<ScopexportablelevelHierarchyXo_qrstY>();

                foreach (ScopexportablelevelHierarchyX_pqrstY Level_VALUE in Level_ARRAY)
                {
                    foreach (Scopexportableformheadersolid value_SCOPEXPORTABLEHEADERSOLID in array_SCOPEXPORTABLEHEADERSOLID)
                    {
                        foreach (Scopexportableformbodysolid value_SCOPEXPORTABLEBODYSOLID in array_SCOPEXPORTABLEBODYSOLID)
                        {
                            var boolean = true;

                            boolean = boolean && Object.ReferenceEquals(value_SCOPEXPORTABLEHEADERSOLID.Object, Level_VALUE.Object) is true;

                            boolean = boolean && Object.ReferenceEquals(value_SCOPEXPORTABLEBODYSOLID.Object, Level_VALUE.Object) is true;

                            Boolean isEqualCheck, shouldContinueCheck;

                            isEqualCheck = boolean is true;

                            shouldContinueCheck = isEqualCheck is false;

                            if (shouldContinueCheck is true)
                            {
                                continue;
                            }
                            else
                                "false".ToString();

                            var array = FunctionDefaultSetSurface(Level_VALUE, value_SCOPEXPORTABLEHEADERSOLID, value_SCOPEXPORTABLEBODYSOLID);

                            ScopexportablelevelHierarchyXo_qrstY level;

                            level = new ScopexportablelevelHierarchyXo_qrstY();

                            level.Object = Level_VALUE.Object;

                            level.DirectoryInfo = Level_VALUE.DirectoryInfo;

                            level.FileInfo = Level_VALUE.FileInfo;

                            level.Text = Level_VALUE.Text;

                            level.Start = Level_VALUE.Start;

                            level.End = Level_VALUE.End;

                            level.XDoubleArray = array;

                            collectionResult.Add(level);

                            continue;
                        }

                        continue;
                    }

                    continue;
                }

                return new List<ScopexportablelevelHierarchyXo_qrstY>(collectionResult);
            }
        }
    }
}