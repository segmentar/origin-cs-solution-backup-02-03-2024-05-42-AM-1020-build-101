using Core;

namespace Core
{
    using System;

    public partial class ScopexportablemoduleHierarchy
    {
        public static ScopexportablemoduleHierarchy Action(Scopexportableextractform[] array_SCOPEXPORTABLEEXTRACTFORM, Object[] array_OBJECT, Scopexportableheadersolid[] array_SCOPEXPORTABLEHEADERSOLID, Scopexportablebodysolid[] array_SCOPEXPORTABLEBODYSOLID)
        {
            ScopexportablemoduleHierarchy moduleResult = default;

            moduleResult = Default(array_SCOPEXPORTABLEEXTRACTFORM, array_OBJECT, array_SCOPEXPORTABLEHEADERSOLID, array_SCOPEXPORTABLEBODYSOLID);

            if (ScopexportableModule.ScopexportablemoduleHierarchy is true)
            {
                try
                {
                    Scopexportablerender.GroupRender($"{ScopexportableCode.ProductPath.Core_Scopexportable_Render}-{ScopexportableIdentity.ScopexprotableOrdinalIdentity}x{ScopexportableIdentity.ScopexportableNameIdentity}-{nameof(ScopexportablemoduleHierarchy)}-0", ScopexportablemoduleHierarchycycle.XZeroth);

                    Scopexportablerender.GroupRender($"{ScopexportableCode.ProductPath.Core_Scopexportable_Render}-{ScopexportableIdentity.ScopexprotableOrdinalIdentity}x{ScopexportableIdentity.ScopexportableNameIdentity}-{nameof(ScopexportablemoduleHierarchy)}-1", ScopexportablemoduleHierarchycycle.XPrimary.XSingle);
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
