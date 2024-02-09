using Core;

namespace Core
{
    using System;

    using System.Collections;

    using System.Collections.Generic;
    using System.Collections.ObjectModel;

    public partial class ScopexportablemoduleBody
    {
        public partial class XSingle
        {
            public static IList<ScopexportablelevelBodyX_pqrstY> FunctionLevelSet(Scopexportableformcoordinate[] array_SCOPEXPORTABLEEXTRACTFORM, Object[] array_OBJECT)
            {
                ICollection<ScopexportablelevelBodyX_pqrstY> collectionResult = default;

                collectionResult = new Collection<ScopexportablelevelBodyX_pqrstY>();

                var indexer = 0;

                foreach (Scopexportableformcoordinate scopexportableextractform in array_SCOPEXPORTABLEEXTRACTFORM)
                {
                    var value = array_OBJECT[indexer];

                    ScopexportablelevelBodyX_pqrstY level;

                    level = new ScopexportablelevelBodyX_pqrstY();

                    level.Object = value;

                    level.DirectoryInfo = scopexportableextractform.DirectoryInfo;

                    level.FileInfo = scopexportableextractform.FileInfo;

                    level.Text = scopexportableextractform.Text;

                    level.Start = scopexportableextractform.Start;

                    level.End = scopexportableextractform.End;

                    collectionResult.Add(level);

                    indexer = indexer + 1;

                    continue;
                }

                return new List<ScopexportablelevelBodyX_pqrstY>(collectionResult);
            }
        }
    }
}
