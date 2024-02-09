using Core;

namespace Core
{
    using System;

    public partial class ScopexportablemoduleBody
    {
        public partial class XQuintuple
        {
            public static XQuintuple ForgeLevel(ScopexportablelevelBodyXopq_stY[] Level_ARRAY, Scopexportableformheadersolid[] array_SCOPEXPORTABLEHEADERSOLID)
            {
                XQuintuple xquintupleResult = default;

                var array = FunctionLevelSetSurface(Level_ARRAY, array_SCOPEXPORTABLEHEADERSOLID);

                XQuintuple xquintuple;

                xquintuple = new XQuintuple(array);

                xquintupleResult = xquintuple;

                return xquintupleResult;
            }
        }
    }
}
