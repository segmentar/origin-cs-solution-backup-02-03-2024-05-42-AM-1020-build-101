using Core;

namespace Core
{
    using System;

    public partial class ScopexportablemoduleBody
    {
        public static ScopexportablemoduleBody Default(Scopexportableformcoordinate[] array_SCOPEXPORTABLEEXTRACTFORM, Object[] array_OBJECT, Scopexportableformheadersolid[] array_SCOPEXPORTABLEHEADERSOLID)
        {
            ScopexportablemoduleBody moduleResult = default;

            var inflect = new Object[3];

            inflect[0] = array_SCOPEXPORTABLEEXTRACTFORM;

            inflect[1] = array_OBJECT;

            inflect[2] = array_SCOPEXPORTABLEHEADERSOLID;

            XZeroth xzeroth;

            xzeroth = new XZeroth(inflect);

            ScopexportablemoduleBodycycle.XZeroth = xzeroth;

            ScopexportablemoduleBody module;

            module = new ScopexportablemoduleBody();

            module.XOne();

            module.XTwo();

            module.XThree();

            module.XFour();

            module.XFive();

            module.XSix();

            module.XSeven();

            module.XEight();

            module.XNine();

            ScopexportableportBody scopexportableportBody;

            scopexportableportBody = new ScopexportableportBody();

            scopexportableportBody.Level = ScopexportablemoduleBodycycle.XPrimary.XSingle.LevelArray;

            scopexportableportBody.LevelLevel = ScopexportablemoduleBodycycle.XSecondary.XDouble.LevelArray;

            scopexportableportBody.LevelLevelLevel = ScopexportablemoduleBodycycle.XTertiary.XTriple.LevelArray;

            scopexportableportBody.LevelLevelLevelLevel = ScopexportablemoduleBodycycle.XQuaternary.XQuadruple.LevelArray;

            scopexportableportBody.LevelLevelLevelLevelLevel = ScopexportablemoduleBodycycle.XQuinary.XQuintuple.LevelArray;

            scopexportableportBody.LevelLevelLevelLevelLevelLevel = ScopexportablemoduleBodycycle.XSenary.XSextuple.LevelArray;

            scopexportableportBody.LevelLevelLevelLevelLevelLevelLevel = ScopexportablemoduleBodycycle.XSeptenary.XSeptuple.LevelArray;

            scopexportableportBody.LevelLevelLevelLevelLevelLevelLevelLevel = ScopexportablemoduleBodycycle.XOctonary.XOctuple.LevelArray;

            scopexportableportBody.ScopexportablebodysolidArray = ScopexportablemoduleBodycycle.XNonary.XNonuple.ScopexportablebodysolidArray;

            module.ScopexportableportBody = scopexportableportBody;

            moduleResult = module;
            
            return moduleResult;
        }
    }
}
