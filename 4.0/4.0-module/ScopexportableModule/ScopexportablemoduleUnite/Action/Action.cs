using Core;

namespace Core
{
    using System;

    public partial class ScopexportablemoduleUnite
    {
        public static ScopexportablemoduleUnite Action(Scopexportableformcoordinate[] array_SCOPEXPORTABLEEXTRACTFORM, Object[] array_OBJECT, Scopexportableformheadersolid[] array_SCOPEXPORTABLEHEADERSOLID, Scopexportableformbodysolid[] array_SCOPEXPORTABLEBODYSOLID, Scopexportablehierarchysolid[] array_SCOPEXPORTABLEHIERARCHYSOLID)
        {
            ScopexportablemoduleUnite moduleResult = default;

            moduleResult = Default(array_SCOPEXPORTABLEEXTRACTFORM, array_OBJECT, array_SCOPEXPORTABLEHEADERSOLID, array_SCOPEXPORTABLEBODYSOLID, array_SCOPEXPORTABLEHIERARCHYSOLID);

            if (ScopexportableModule.ScopexportablemoduleUnite is true)
            {
                try
                {
                    Scopexportablerender.GroupRender($"{ScopexportableCode.ProductPath.Core_Scopexportable_Render}-{ScopexportableIdentity.ScopexprotableOrdinalIdentity}x{ScopexportableIdentity.ScopexportableNameIdentity}-{nameof(ScopexportablemoduleUnite)}-0", ScopexportablemoduleUnitecycle.XZeroth);

                    Scopexportablerender.GroupRender($"{ScopexportableCode.ProductPath.Core_Scopexportable_Render}-{ScopexportableIdentity.ScopexprotableOrdinalIdentity}x{ScopexportableIdentity.ScopexportableNameIdentity}-{nameof(ScopexportablemoduleUnite)}-1", ScopexportablemoduleUnitecycle.XPrimary.XSingle);
                }
                catch (Exception exception)
                {
                    Scopexportablerender.GroupRender($"{ScopexportableCode.ProductPath.Core_Scopexportable_Fatal}", exception);
                }
            }
            else
                "false".ToString();

            return moduleResult;
        }
    }
}
