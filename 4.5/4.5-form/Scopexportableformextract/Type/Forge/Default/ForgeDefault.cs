using Core;

namespace Core
{
    using System;

    public partial class Scopexportableformextract
    {
        public static Scopexportableformcoordinate[] ForgeDefault(Scopexportableformscansolid[] array_SCOPEXPORTABLESCANSOLID)
        {
            Scopexportableformcoordinate[] arrayResult = default;

            var value = Extract(array_SCOPEXPORTABLESCANSOLID);

            var result = value.ScopexportableformArray;

            arrayResult = result;

            return arrayResult;
        }
    }
}
