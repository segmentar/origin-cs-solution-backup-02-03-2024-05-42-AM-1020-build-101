using Core;

namespace Core
{
    using System;

    using System.IO;

    using System.Collections;

    using System.Collections.Generic;
    using System.Collections.ObjectModel;

    public partial class ScopexportablemoduleScan
    {
        public partial class XDouble
        {
            public static IList<ScopexportablelevelScanXo_qrstY> FunctionLevelSet(ScopexportablelevelScanX_pqrstY[] Level_ARRAY)
            {
                ICollection<ScopexportablelevelScanXo_qrstY> collectionResult = default;

                collectionResult = new Collection<ScopexportablelevelScanXo_qrstY>();

                foreach (ScopexportablelevelScanX_pqrstY Level_VALUE in Level_ARRAY)
                {
                    var array = Directory.GetFiles(Level_VALUE.DirectoryInfo.FullName);

                    foreach (String stringValue in array)
                    {
                        FileInfo fileInfo;

                        fileInfo = new FileInfo(stringValue);

                        ScopexportablelevelScanXo_qrstY level;

                        level = new ScopexportablelevelScanXo_qrstY();

                        level.DirectoryInfo = Level_VALUE.DirectoryInfo;

                        level.FileInfo = fileInfo;

                        collectionResult.Add(level);

                        continue;
                    }

                    continue;
                }

                return new List<ScopexportablelevelScanXo_qrstY>(collectionResult);
            }
        }
    }
}
