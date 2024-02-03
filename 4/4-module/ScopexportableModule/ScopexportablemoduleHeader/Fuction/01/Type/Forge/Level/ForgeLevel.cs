using Core;

namespace Core
{
    using System;

    public partial class ScopexportablemoduleHeader
    {
        public partial class XSingle
        {
            public static XSingle ForgeLevel(Scopexportableextractform[] array_SCOPEXPORTABLEEXTRACTFORM, Object[] array_OBJECT)
            {
                XSingle xsingleResult = default;

                var array = FunctionLeveLSetSurface(array_SCOPEXPORTABLEEXTRACTFORM, array_OBJECT);

                XSingle xsingle;

                xsingle = new XSingle(array);

                xsingleResult = xsingle;

                return xsingleResult;
            }
        }
    }
}
