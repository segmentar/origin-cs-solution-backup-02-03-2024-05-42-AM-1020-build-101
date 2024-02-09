using Core;

namespace Core
{
    using System;

    public partial class ScopexportablesealExtract
    {
        public static void Import(ScopexportableextractUnit Unit_VALUE)
        {
            ScopexportablescansolidValue = Unit_VALUE.Scopexportablescansolid;

            StringValue = Unit_VALUE.StringValue;

            Index = Unit_VALUE.Index;

            Start = Unit_VALUE.Start;

            End = Unit_VALUE.End;

            StartHas = Unit_VALUE.StartHas;

            EndHas = Unit_VALUE.EndHas;

            Difference = Unit_VALUE.Difference;

            DifferenceHas = Unit_VALUE.DifferenceHas;

            StepHas = Unit_VALUE.StepHas;

            ValidIs = Unit_VALUE.ValidIs;

            ScopexportableformValue = Unit_VALUE.Scopexportableform;

            ScopexportableformArray = Unit_VALUE.ScopexportableformArray;

            return;
        }
    }
}
