using Core;

namespace Core
{
    using System;

    public partial class ScopexportablemoduleBody
    {
        public static ScopexportablemoduleBody Action(Scopexportableformcoordinate[] array_SCOPEXPORTABLEEXTRACTFORM, Object[] array_OBJECT, Scopexportableformheadersolid[] array_SCOPEXPORTABLEHEADERSOLID)
        {
            ScopexportablemoduleBody moduleResult = default;

            if (ScopexportableModule.ScopexportablemoduleBody)
            {
                try
                {
                    moduleResult = Default(array_SCOPEXPORTABLEEXTRACTFORM, array_OBJECT, array_SCOPEXPORTABLEHEADERSOLID);
                }
                catch (Exception exception)
                {
                    Scopexportablerender.GroupRender($"{ScopexportableCode.ProductPath.Core_Scopexportable_Fatal}", exception);
                }

                try
                {
                    Scopexportablerender.GroupRender($"{ScopexportableCode.ProductPath.Core_Scopexportable_Render}-{ScopexportableIdentity.ScopexprotableOrdinalIdentity}x{ScopexportableIdentity.ScopexportableNameIdentity}-{nameof(ScopexportablemoduleBody)}-0", ScopexportablemoduleBodycycle.XZeroth);

                    Scopexportablerender.GroupRender($"{ScopexportableCode.ProductPath.Core_Scopexportable_Render}-{ScopexportableIdentity.ScopexprotableOrdinalIdentity}x{ScopexportableIdentity.ScopexportableNameIdentity}-{nameof(ScopexportablemoduleBody)}-1", ScopexportablemoduleBodycycle.XPrimary.XSingle);

                    Scopexportablerender.GroupRender($"{ScopexportableCode.ProductPath.Core_Scopexportable_Render}-{ScopexportableIdentity.ScopexprotableOrdinalIdentity}x{ScopexportableIdentity.ScopexportableNameIdentity}-{nameof(ScopexportablemoduleBody)}-2", ScopexportablemoduleBodycycle.XSecondary.XDouble);

                    Scopexportablerender.GroupRender($"{ScopexportableCode.ProductPath.Core_Scopexportable_Render}-{ScopexportableIdentity.ScopexprotableOrdinalIdentity}x{ScopexportableIdentity.ScopexportableNameIdentity}-{nameof(ScopexportablemoduleBody)}-3", ScopexportablemoduleBodycycle.XTertiary.XTriple);

                    Scopexportablerender.GroupRender($"{ScopexportableCode.ProductPath.Core_Scopexportable_Render}-{ScopexportableIdentity.ScopexprotableOrdinalIdentity}x{ScopexportableIdentity.ScopexportableNameIdentity}-{nameof(ScopexportablemoduleBody)}-4", ScopexportablemoduleBodycycle.XQuaternary.XQuadruple);

                    Scopexportablerender.GroupRender($"{ScopexportableCode.ProductPath.Core_Scopexportable_Render}-{ScopexportableIdentity.ScopexprotableOrdinalIdentity}x{ScopexportableIdentity.ScopexportableNameIdentity}-{nameof(ScopexportablemoduleBody)}-5", ScopexportablemoduleBodycycle.XQuinary.XQuintuple);

                    Scopexportablerender.GroupRender($"{ScopexportableCode.ProductPath.Core_Scopexportable_Render}-{ScopexportableIdentity.ScopexprotableOrdinalIdentity}x{ScopexportableIdentity.ScopexportableNameIdentity}-{nameof(ScopexportablemoduleBody)}-6", ScopexportablemoduleBodycycle.XSenary.XSextuple);

                    Scopexportablerender.GroupRender($"{ScopexportableCode.ProductPath.Core_Scopexportable_Render}-{ScopexportableIdentity.ScopexprotableOrdinalIdentity}x{ScopexportableIdentity.ScopexportableNameIdentity}-{nameof(ScopexportablemoduleBody)}-7", ScopexportablemoduleBodycycle.XSeptenary.XSeptuple);

                    Scopexportablerender.GroupRender($"{ScopexportableCode.ProductPath.Core_Scopexportable_Render}-{ScopexportableIdentity.ScopexprotableOrdinalIdentity}x{ScopexportableIdentity.ScopexportableNameIdentity}-{nameof(ScopexportablemoduleBody)}-8", ScopexportablemoduleBodycycle.XOctonary.XOctuple);

                    Scopexportablerender.GroupRender($"{ScopexportableCode.ProductPath.Core_Scopexportable_Render}-{ScopexportableIdentity.ScopexprotableOrdinalIdentity}x{ScopexportableIdentity.ScopexportableNameIdentity}-{nameof(ScopexportablemoduleBody)}-9", ScopexportablemoduleBodycycle.XNonary.XNonuple);
                }
                catch (Exception exception)
                {
                    Scopexportablerender.GroupRender($"{ScopexportableCode.ProductPath.Core_Scopexportable_Fatal}", exception);
                }
            }
            else
            {
                moduleResult = Default(array_SCOPEXPORTABLEEXTRACTFORM, array_OBJECT, array_SCOPEXPORTABLEHEADERSOLID);
            }

            return moduleResult;
        }
    }
}
