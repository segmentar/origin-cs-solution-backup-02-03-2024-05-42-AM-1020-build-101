using Core;

namespace Core
{
    using System;

    using System.Collections;

    using System.Collections.Generic;
    using System.Collections.ObjectModel;

    public partial class ScopexportablemoduleScan
    {
        public partial class XQuadruple
        {
            public static IList<Scopexportablescansolid> FunctionLevelSet(ScopexportablelevelScanXop_rstY[] Level_ARRAY)
            {
                ICollection<Scopexportablescansolid> collectionResult = default;

                collectionResult = new Collection<Scopexportablescansolid>();

                foreach (ScopexportablelevelScanXop_rstY Level_VALUE in Level_ARRAY)
                {
                    Scopexportablescansolid scopexportablescansolid;

                    scopexportablescansolid = new Scopexportablescansolid();

                    scopexportablescansolid.DirectoryInfo = Level_VALUE.DirectoryInfo;

                    scopexportablescansolid.FileInfo = Level_VALUE.FileInfo;

                    scopexportablescansolid.Text = Level_VALUE.Text;

                    collectionResult.Add(scopexportablescansolid);

                    continue;
                }

                return new List<Scopexportablescansolid>(collectionResult);
            }
        }
    }
}
