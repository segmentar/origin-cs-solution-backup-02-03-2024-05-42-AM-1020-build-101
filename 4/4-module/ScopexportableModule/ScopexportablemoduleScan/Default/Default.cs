using Core;

namespace Core
{
    using System;

    public partial class ScopexportablemoduleScan
    {
        public static ScopexportablemoduleScan Default()
        {
            ScopexportablemoduleScan moduleResult = default;

            var inflect = new Object[0];

            XZeroth xzeroth;

            xzeroth = new XZeroth(inflect);

            ScopexportablemoduleScancycle.XZeroth = xzeroth;

            ScopexportablemoduleScan module;

            module = new ScopexportablemoduleScan();

            module.XOne();

            module.XTwo();

            module.XThree();

            module.XFour();

            ScopexportableportScan scopexportableportScan;

            scopexportableportScan = new ScopexportableportScan();

            scopexportableportScan.Level = ScopexportablemoduleScancycle.XPrimary.XSingle.LevelArray;

            scopexportableportScan.LevelLevel = ScopexportablemoduleScancycle.XSecondary.XDouble.LevelArray;

            scopexportableportScan.LevelLevelLevel = ScopexportablemoduleScancycle.XTertiary.XTriple.LevelArray;

            scopexportableportScan.ScopexportablescansolidArray = ScopexportablemoduleScancycle.XQuaternary.XQuadruple.ScopexportablescansolidArray;

            module.ScopexportableportScan = scopexportableportScan;

            moduleResult = module;

            return moduleResult;
        }
    }
}
