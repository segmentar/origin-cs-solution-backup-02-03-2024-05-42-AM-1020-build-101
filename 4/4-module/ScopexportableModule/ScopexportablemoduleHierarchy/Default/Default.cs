using Core;

namespace Core
{
    using System;

    public partial class ScopexportablemoduleHierarchy
    {
        public static ScopexportablemoduleHierarchy Default(Scopexportableextractform[] array_SCOPEXPORTABLEEXTRACTFORM, Object[] array_OBJECT, Scopexportableheadersolid[] array_SCOPEXPORTABLEHEADERSOLID, Scopexportablebodysolid[] array_SCOPEXPORTABLEBODYSOLID)
        {
            ScopexportablemoduleHierarchy moduleResult = default;

            var inflect = new Object[4];

            inflect[0] = array_SCOPEXPORTABLEEXTRACTFORM;

            inflect[1] = array_OBJECT;

            inflect[2] = array_SCOPEXPORTABLEHEADERSOLID;

            inflect[3] = array_SCOPEXPORTABLEBODYSOLID;

            XZeroth xzeroth;

            xzeroth = new XZeroth(inflect);

            ScopexportablemoduleHierarchycycle.XZeroth = xzeroth;

            ScopexportablemoduleHierarchy module;

            module = new ScopexportablemoduleHierarchy();

            module.XOne();

            ScopexportableportHierarchy scopexportableportHierarchy;

            scopexportableportHierarchy = new ScopexportableportHierarchy();

            module.ScopexportableportHierarchy = scopexportableportHierarchy;

            moduleResult = module;

            return moduleResult;
        }
    }
}
