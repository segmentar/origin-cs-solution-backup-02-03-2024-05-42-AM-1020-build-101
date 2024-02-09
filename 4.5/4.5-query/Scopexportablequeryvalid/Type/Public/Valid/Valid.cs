using Core;

namespace Core
{
    using System;

    public partial class Scopexportablequeryvalid
    {
        public static void Valid()
        {
            foreach (Scopexportableformbuildsolid scopexportableaccumulatesolid in Scopexportablemonitorvalid.Scopexportablevalid.ScopexportableaccumulatesolidArray)
            {
                var valid = true;

                foreach (Scopexportablehierarchynumeratesolid scopexportablehierarchynumeratesolid in scopexportableaccumulatesolid.ScopexportablehierarchynumeratesolidArray)
                {
                    valid = valid && Scopexportablemonitorvalid.Scopexportablevalid.Scopexportablevalidnumerate.Valid[scopexportablehierarchynumeratesolid];

                    continue;
                }

                Boolean isEqualCheck, shouldContinueCheck;

                isEqualCheck = valid is true;

                shouldContinueCheck = isEqualCheck is false;

                if (shouldContinueCheck is true)
                {
                    continue;
                }
                else
                    "false".ToString();

                Scopexportablemonitorvalid.Scopexportablevalid.Scopexportablevalidenum.Valid[scopexportableaccumulatesolid] = true;

                continue;
            }

            return;
        }
    }
}
