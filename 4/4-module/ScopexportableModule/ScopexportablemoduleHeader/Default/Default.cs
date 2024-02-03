using Core;

namespace Core
{
    using System;

    public partial class ScopexportablemoduleHeader
    {
        public static ScopexportablemoduleHeader Default(Scopexportableextractform[] array_SCOPEXPORTABLEEXTRACTFORM, Object[] array_OBJECT)
        {
            ScopexportablemoduleHeader moduleResult = default;

            var inflect = new Object[2];

            inflect[0] = array_SCOPEXPORTABLEEXTRACTFORM;

            inflect[1] = array_OBJECT;

            XZeroth xzeroth;

            xzeroth = new XZeroth(inflect);

            ScopexportablemoduleHeadercycle.XZeroth = xzeroth;

            ScopexportablemoduleHeader module;

            module = new ScopexportablemoduleHeader();

            module.XOne();

            module.XTwo();

            module.XThree();
            
            module.XFour();
            
            module.XFive();
            
            module.XSix();
            
            module.XSeven();
            
            module.XEight();
            
            module.XNine();

            module.XTen();

            module.XEleven();

            ScopexportableportHeader scopexportableportHeader;

            scopexportableportHeader = new ScopexportableportHeader();

            scopexportableportHeader.Level = ScopexportablemoduleHeadercycle.XPrimary.XSingle.LevelArray;

            scopexportableportHeader.LevelLevel = ScopexportablemoduleHeadercycle.XSecondary.XDouble.LevelArray;

            scopexportableportHeader.LevelLevelLevel = ScopexportablemoduleHeadercycle.XTertiary.XTriple.LevelArray;

            scopexportableportHeader.LevelLevelLevelLevel = ScopexportablemoduleHeadercycle.XQuaternary.XQuadruple.LevelArray;

            scopexportableportHeader.LevelLevelLevelLevelLevel = ScopexportablemoduleHeadercycle.XQuinary.XQuintuple.LevelArray;

            scopexportableportHeader.LevelLevelLevelLevelLevelLevel = ScopexportablemoduleHeadercycle.XSenary.XSextuple.LevelArray;

            scopexportableportHeader.LevelLevelLevelLevelLevelLevelLevel = ScopexportablemoduleHeadercycle.XSeptenary.XSeptuple.LevelArray;

            scopexportableportHeader.LevelLevelLevelLevelLevelLevelLevelLevel = ScopexportablemoduleHeadercycle.XOctonary.XOctuple.LevelArray;

            scopexportableportHeader.LevelLevelLevelLevelLevelLevelLevelLevelLevel = ScopexportablemoduleHeadercycle.XNonary.XNonuple.LevelArray;

            scopexportableportHeader.LevelLevelLevelLevelLevelLevelLevelLevelLevelLevel = ScopexportablemoduleHeadercycle.XDenary.XDecuple.LevelArray;

            scopexportableportHeader.ScopexportableheadersolidArray = ScopexportablemoduleHeadercycle.XUndenary.XUndecuple.ScopexportableheadersolidArray;

            module.ScopexportableportHeader = scopexportableportHeader;

            moduleResult = module;

            return moduleResult;
        }
    }
}
