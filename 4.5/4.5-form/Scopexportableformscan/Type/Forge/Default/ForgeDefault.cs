using Core;

namespace Core
{
    using System;

    public partial class Scopexportableformscan
    {
        public static Scopexportableformscansolid[] ForgeDefault()
        {
            Scopexportableformscansolid[] arrayResult = default;

            var array = Scan();

            var reflect = (ScopexportablemoduleScan)(array[0] as Object);

            var result = reflect.ScopexportableportScan.ScopexportablescansolidArray;

            arrayResult = result;

            return arrayResult;
        }
    }
}
