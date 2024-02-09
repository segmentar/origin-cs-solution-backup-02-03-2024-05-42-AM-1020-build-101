using Core;

namespace Core
{
    using System;

    using System.Collections;

    using System.Collections.Generic;
    using System.Collections.ObjectModel;

    public partial class ScopexportablemoduleHeader
    {
        public partial class XSingle
        {
            public static IList<ScopexportableijklmnHeaderX_pqrstY> FunctionIjklmnSet(Scopexportableformcoordinate[] array_SCOPEXPORTABLEFORMCOORDINATE, Object[] array_OBJECT)
            {
                ICollection<ScopexportableijklmnHeaderX_pqrstY> collectionResult = default;

                collectionResult = new Collection<ScopexportableijklmnHeaderX_pqrstY>();

                var indexer = 0;

                foreach (Scopexportableformcoordinate value_SCOPEXPORTABLEEXTRACTFORM in array_SCOPEXPORTABLEFORMCOORDINATE)
                {
                    ScopexportableijklmnHeaderX_pqrstY ijklmn;

                    ijklmn = new ScopexportableijklmnHeaderX_pqrstY();

                    ijklmn.Object = array_OBJECT[indexer];

                    ijklmn.DirectoryInfo = value_SCOPEXPORTABLEEXTRACTFORM.DirectoryInfo;

                    ijklmn.FileInfo = value_SCOPEXPORTABLEEXTRACTFORM.FileInfo;

                    ijklmn.Text = value_SCOPEXPORTABLEEXTRACTFORM.Text;

                    ijklmn.Start = value_SCOPEXPORTABLEEXTRACTFORM.Start;

                    ijklmn.End = value_SCOPEXPORTABLEEXTRACTFORM.End;

                    collectionResult.Add(ijklmn);

                    indexer = indexer + 1;

                    continue;
                }

                return new List<ScopexportableijklmnHeaderX_pqrstY>(collectionResult);
            }
        }
    }
}