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
            public static IList<ScopexportablelevelHeaderX_pqrstY> FunctionLeveLSet(Scopexportableextractform[] array_SCOPEXPORTABLEEXTRACTFORM, Object[] array_OBJECT)
            {
                ICollection<ScopexportablelevelHeaderX_pqrstY> collectionResult = default;

                collectionResult = new Collection<ScopexportablelevelHeaderX_pqrstY>();

                var index = 0;

                foreach (Scopexportableextractform value_SCOPEXPORTABLEEXTRACTFORM in array_SCOPEXPORTABLEEXTRACTFORM)
                {
                    ScopexportablelevelHeaderX_pqrstY level;

                    level = new ScopexportablelevelHeaderX_pqrstY();

                    level.Object = array_OBJECT[index];

                    level.DirectoryInfo = value_SCOPEXPORTABLEEXTRACTFORM.DirectoryInfo;

                    level.FileInfo = value_SCOPEXPORTABLEEXTRACTFORM.FileInfo;

                    level.Text = value_SCOPEXPORTABLEEXTRACTFORM.Text;

                    level.Start = value_SCOPEXPORTABLEEXTRACTFORM.Start;

                    level.End = value_SCOPEXPORTABLEEXTRACTFORM.End;

                    collectionResult.Add(level);

                    index = index + 1;

                    continue;
                }

                return new List<ScopexportablelevelHeaderX_pqrstY>(collectionResult);
            }
        }
    }
}