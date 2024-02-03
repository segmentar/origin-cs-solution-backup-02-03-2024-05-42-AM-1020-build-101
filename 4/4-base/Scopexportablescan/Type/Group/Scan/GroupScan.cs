using Core;

namespace Core
{
    using System;

    public partial class Scopexportablescan
    {
        public static Object[] GroupScan()
        {
            Object[] arrayResult;

            ScopexportablemoduleScan scopexportablemoduleScan = ScopexportablemoduleScan.Action();

            var inflect = new Object[1];

            inflect[0] = scopexportablemoduleScan;

            var result = inflect;

            arrayResult = result;

            return arrayResult;
        }
    }
}
