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
        public partial class XTriple
        {
            public static IList<ScopexportablelevelScanXop_rstY> FunctionLevelSet(ScopexportablelevelScanXo_qrstY[] Level_ARRAY)
            {
                ICollection<ScopexportablelevelScanXop_rstY> collectionResult = default;

                collectionResult = new Collection<ScopexportablelevelScanXop_rstY>();

                foreach (ScopexportablelevelScanXo_qrstY Level_VALUE in Level_ARRAY)
                {
                    var value = File.ReadAllText(Level_VALUE.FileInfo.FullName);

                    var result = Scopexportablestringsafe.ForgeDefault(value);

                    ScopexportablelevelScanXop_rstY level;

                    level = new ScopexportablelevelScanXop_rstY();

                    level.DirectoryInfo = Level_VALUE.DirectoryInfo;

                    level.FileInfo = Level_VALUE.FileInfo;

                    level.Text = result;

                    collectionResult.Add(level);

                    continue;
                }

                return new List<ScopexportablelevelScanXop_rstY>(collectionResult);
            }
        }
    }
}
