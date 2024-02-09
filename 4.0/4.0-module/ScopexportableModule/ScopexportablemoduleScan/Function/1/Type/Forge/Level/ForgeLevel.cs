using Core;

namespace Core
{
    using System;

    public partial class ScopexportablemoduleScan
    {
        public partial class XSingle
        {
            public static XSingle ForgeLevel(String DirectoryFullName___VALUE)
            {
                XSingle xsingleResult = default;

                var array = FunctionLevelSetSurface(DirectoryFullName___VALUE);

                XSingle xsingle;

                xsingle = new XSingle(array);

                xsingleResult = xsingle;

                return xsingleResult;
            }
        }
    }
}
