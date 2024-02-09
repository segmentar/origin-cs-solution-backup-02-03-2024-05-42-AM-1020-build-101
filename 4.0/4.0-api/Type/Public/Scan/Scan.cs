using Core;

namespace Core
{
    using System;

    public partial class Scopexportableapi
    {
        public static Object Scan()
        {
            Object[] arrayResult = default;

            arrayResult = Scopexportableformscan.Scan();

            return arrayResult;
        }
    }
}
