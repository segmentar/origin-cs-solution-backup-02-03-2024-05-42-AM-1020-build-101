using Core;

namespace Core
{
    using System;

    public partial class Scopexportablescan
    {
        public static Scopexportablescansolid[] GroupScansolid()
        {
            Scopexportablescansolid[] arrayResult = default;

            var array = GroupScan();

            var reflect = (ScopexportablemoduleScan)(array[0] as Object);

            var result = reflect.ScopexportableportScan.ScopexportablescansolidArray;

            arrayResult = result;

            return arrayResult;
        }
    }
}
