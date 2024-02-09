using Core;

namespace Core
{
    using System;

    public partial class ScopexportablemoduleUnite
    {
        public static ScopexportablemoduleUnite Default(Scopexportableformcoordinate[] array_SCOPEXPORTABLEEXTRACTFORM, Object[] array_OBJECT, Scopexportableformheadersolid[] array_SCOPEXPORTABLEHEADERSOLID, Scopexportableformbodysolid[] array_SCOPEXPORTABLEBODYSOLID, Scopexportablehierarchysolid[] array_SCOPEXPORTABLEHIERARCHYSOLID)
        {
            ScopexportablemoduleUnite moduleResult = default;

            var inflect = new Object[5];

            inflect[0] = array_SCOPEXPORTABLEEXTRACTFORM;

            inflect[1] = array_OBJECT;

            inflect[2] = array_SCOPEXPORTABLEHEADERSOLID;

            inflect[3] = array_SCOPEXPORTABLEBODYSOLID;

            inflect[4] = array_SCOPEXPORTABLEHIERARCHYSOLID;

            XZeroth xzeroth;

            xzeroth = new XZeroth(inflect);

            ScopexportablemoduleUnitecycle.XZeroth = xzeroth;

            ScopexportablemoduleUnite module;

            module = new ScopexportablemoduleUnite();

            module.XOne();

            ScopexportableportUnite scopexportableportUnite;

            scopexportableportUnite = new ScopexportableportUnite();

            scopexportableportUnite.ScopexportableaccumulatesolidArray = ScopexportablemoduleUnitecycle.XPrimary.XSingle.ScopexportableaccumulatesolidArray;

            module.ScopexportableportUnite = scopexportableportUnite;

            moduleResult = module;

            return moduleResult;
        }
    }
}
