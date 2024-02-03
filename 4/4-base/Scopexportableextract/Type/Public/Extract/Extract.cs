using Core;

namespace Core
{
    using System;

    public partial class Scopexportableextract
    {
        public static Scopexportableextractform[] Extract()
        {
            Scopexportableextractform[] arrayResult = default;

            var array = Scopexportablescan.GroupScansolid();

            var result = ScopexportablesealExtract.ZeroZeroth(array);

            arrayResult = result.ScopexportableformArray;

            return arrayResult;
        }
    }
}
