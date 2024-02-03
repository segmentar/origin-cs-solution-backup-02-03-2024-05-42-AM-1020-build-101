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
        public partial class XSingle
        {
            public static IList<ScopexportablelevelScanX_pqrstY> FunctionLevelSet(String DirectoryFullName___VALUE)
            {
                ICollection<ScopexportablelevelScanX_pqrstY> collectionResult = default;

                collectionResult = new Collection<ScopexportablelevelScanX_pqrstY>();

                var array = Scopexportableio.ScopexportableioFolderSetSurface(DirectoryFullName___VALUE, true);

                foreach (DirectoryInfo directoryInfo in array)
                {
                    ScopexportablelevelScanX_pqrstY level;

                    level = new ScopexportablelevelScanX_pqrstY();

                    level.DirectoryInfo = directoryInfo;

                    collectionResult.Add(level);

                    continue;
                }

                return new List<ScopexportablelevelScanX_pqrstY>(collectionResult);
            }
        }
    }
}
