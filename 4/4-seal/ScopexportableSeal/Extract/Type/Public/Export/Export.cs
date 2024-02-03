using Core;

namespace Core
{
    using System;

    public partial class ScopexportablesealExtract
    {
        public static ScopexportableextractUnit Export()
        {
            ScopexportableextractUnit unitResult = default;

            ScopexportableextractUnit unit;

            unit = new ScopexportableextractUnit();

            unit.Scopexportablescansolid = ScopexportablescansolidValue;

            unit.StringValue = StringValue;

            unit.Index = Index;

            unit.Start = Start;

            unit.End = End;

            unit.StartHas = StartHas;

            unit.EndHas = EndHas;

            unit.Difference = Difference;

            unit.DifferenceHas = DifferenceHas;

            unit.StepHas = StepHas;

            unit.ValidIs = ValidIs;

            unit.Scopexportableform = ScopexportableformValue;

            unit.ScopexportableformArray = ScopexportableformArray;

            unitResult = unit;

            return unitResult;
        }
    }
}
