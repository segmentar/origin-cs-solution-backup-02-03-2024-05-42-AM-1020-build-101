using Core;

namespace Core
{
    using System;

    using System.Collections;

    using System.Collections.Generic;
    using System.Collections.ObjectModel;

    public partial class ScopexportablemoduleHierarchy
    {
        public partial class XSingle
        {
            public static IList<ScopexportablelevelHierarchyX_pqrstY> FunctionLevelSet(Scopexportableformcoordinate[] array_SCOPEXPORTABLEEXTRACTFORM, Object[] array_OBJECT)
            {
                ICollection<ScopexportablelevelHierarchyX_pqrstY> collectionResult = default;

                collectionResult = new Collection<ScopexportablelevelHierarchyX_pqrstY>();

                var indexer = 0;

                foreach (Scopexportableformcoordinate value_SCOPEXPORTABLEEXTRACTFORM in array_SCOPEXPORTABLEEXTRACTFORM)
                {
                    var value = array_OBJECT[indexer];

                    ScopexportablelevelHierarchyX_pqrstY level;

                    level = new ScopexportablelevelHierarchyX_pqrstY();

                    level.Object = value;

                    level.DirectoryInfo = value_SCOPEXPORTABLEEXTRACTFORM.DirectoryInfo;

                    level.FileInfo = value_SCOPEXPORTABLEEXTRACTFORM.FileInfo;

                    level.Text = value_SCOPEXPORTABLEEXTRACTFORM.Text;

                    level.Start = value_SCOPEXPORTABLEEXTRACTFORM.Start;

                    level.End = value_SCOPEXPORTABLEEXTRACTFORM.End;

                    collectionResult.Add(level);

                    indexer = indexer + 1;

                    continue;
                }

                return new List<ScopexportablelevelHierarchyX_pqrstY>(collectionResult);
            }
        }
    }
}
