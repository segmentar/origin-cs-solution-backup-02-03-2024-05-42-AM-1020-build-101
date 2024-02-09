using Core;

namespace Core
{
    using System;

    public partial class ScopexportablemoduleHierarchy
    {
        public static ScopexportablemoduleHierarchy Default(Scopexportableformcoordinate[] array_SCOPEXPORTABLEEXTRACTFORM, Object[] array_OBJECT, Scopexportableformheadersolid[] array_SCOPEXPORTABLEHEADERSOLID, Scopexportableformbodysolid[] array_SCOPEXPORTABLEBODYSOLID)
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

            module.XTwo();

            module.XThree();

            module.XFour();

            module.XFive();

            module.XSix();

            module.XSeven();

            module.XEight();
            
            module.XNine();
            
            module.XTen();

            ScopexportableportHierarchy scopexportableportHierarchy;

            scopexportableportHierarchy = new ScopexportableportHierarchy();

            scopexportableportHierarchy.Level = ScopexportablemoduleHierarchycycle.XPrimary.LevelArray;

            scopexportableportHierarchy.LevelLevel = ScopexportablemoduleHierarchycycle.XSecondary.LevelArray;

            scopexportableportHierarchy.LevelLevelLevel = ScopexportablemoduleHierarchycycle.XTertiary.LevelArray;

            scopexportableportHierarchy.LevelLevelLevelLevel = ScopexportablemoduleHierarchycycle.XQuaternary.LevelArray;

            scopexportableportHierarchy.LevelLevelLevelLevelLevel = ScopexportablemoduleHierarchycycle.XQuinary.LevelArray;

            scopexportableportHierarchy.LevelLevelLevelLevelLevelLevel = ScopexportablemoduleHierarchycycle.XSenary.LevelArray;

            scopexportableportHierarchy.LevelLevelLevelLevelLevelLevelLevel = ScopexportablemoduleHierarchycycle.XSeptenary.LevelArray;

            scopexportableportHierarchy.LevelLevelLevelLevelLevelLevelLevelLevel = ScopexportablemoduleHierarchycycle.XOctonary.LevelArray;

            scopexportableportHierarchy.LevelLevelLevelLevelLevelLevelLevelLevelLevel = ScopexportablemoduleHierarchycycle.XNonary.LevelArray;

            scopexportableportHierarchy.ScopexportablehierarchysolidArray = ScopexportablemoduleHierarchycycle.XDenary.XDecuple.ScopexportablehierarchysolidArray;

            module.ScopexportableportHierarchy = scopexportableportHierarchy;

            moduleResult = module;

            return moduleResult;
        }
    }
}
