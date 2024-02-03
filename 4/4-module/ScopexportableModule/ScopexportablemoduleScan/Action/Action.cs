using Core;

namespace Core
{
    using System;

    public partial class ScopexportablemoduleScan
    {
        public static ScopexportablemoduleScan Action()
        {
            ScopexportablemoduleScan moduleResult = default;

            moduleResult = Default();

            if (ScopexportableModule.ScopexportablemoduleScan is true)
            {
                try
                {
                    Scopexportablerender.GroupRender($"{ScopexportableCode.ProductPath.Core_Scopexportable_Render}-{nameof(ScopexportablemoduleScan)}-0", ScopexportablemoduleScancycle.XZeroth);

                    Scopexportablerender.GroupRender($"{ScopexportableCode.ProductPath.Core_Scopexportable_Render}-{nameof(ScopexportablemoduleScan)}-1", ScopexportablemoduleScancycle.XPrimary.XSingle);

                    Scopexportablerender.GroupRender($"{ScopexportableCode.ProductPath.Core_Scopexportable_Render}-{nameof(ScopexportablemoduleScan)}-2", ScopexportablemoduleScancycle.XSecondary.XDouble);

                    Scopexportablerender.GroupRender($"{ScopexportableCode.ProductPath.Core_Scopexportable_Render}-{nameof(ScopexportablemoduleScan)}-3", ScopexportablemoduleScancycle.XTertiary.XTriple);

                    Scopexportablerender.GroupRender($"{ScopexportableCode.ProductPath.Core_Scopexportable_Render}-{nameof(ScopexportablemoduleScan)}-4", ScopexportablemoduleScancycle.XQuaternary.XQuadruple);

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
