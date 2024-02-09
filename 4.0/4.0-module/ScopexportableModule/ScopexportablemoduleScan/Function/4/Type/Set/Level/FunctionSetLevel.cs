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
            public static IList<Scopexportableformscansolid> FunctionLevelSet(ScopexportablelevelScanXop_rstY[] Level_ARRAY)
            {
                ICollection<Scopexportableformscansolid> collectionResult = default;

                collectionResult = new Collection<Scopexportableformscansolid>();

                foreach (ScopexportablelevelScanXop_rstY Level_VALUE in Level_ARRAY)
                {
                    Scopexportableformscansolid scopexportablescansolid;

                    scopexportablescansolid = new Scopexportableformscansolid();

                    scopexportablescansolid.DirectoryInfo = Level_VALUE.DirectoryInfo;

                    scopexportablescansolid.FileInfo = Level_VALUE.FileInfo;

                    scopexportablescansolid.Text = Level_VALUE.Text;

                    collectionResult.Add(scopexportablescansolid);

                    continue;
                }

                return new List<Scopexportableformscansolid>(collectionResult);
            }
        }
    }
}
