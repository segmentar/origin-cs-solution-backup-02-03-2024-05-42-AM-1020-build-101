using Core;

namespace Core
{
    using System;

    public partial class Scopexportableprocess
    {
        public static void Process(Scopexportableformbuildsolid[] array_SCOPEXPORTABLEACCUMULATESOLID, Boolean answer_MONITOR_should)
        {
            start:
            {
                Scopexportablemonitorexpression.Sync();

                Scopexportablemonitorparameter.Import(Scopexportablemonitorparameter.Data(array_SCOPEXPORTABLEACCUMULATESOLID));

                Scopexportablemonitorstate.Import(Scopexportablemonitorstate.Data());

                Scopexportablemonitorframe.Import(Scopexportablemonitorframe.Data());

                Scopexportablemonitorfilearray.Import(Scopexportablemonitorfilearray.Data());

                Scopexportablemonitorvalid.Import(Scopexportablemonitorvalid.Data(array_SCOPEXPORTABLEACCUMULATESOLID));

                Scopexportablemonitortext.Import(Scopexportablemonitortext.Data());

                Scopexportablemonitorquery.Import(Scopexportablemonitorquery.Data());

                Scopexportablemonitortransform.Import(Scopexportablemonitortransform.Data());

                Scopexportablemonitorframe.LinkedList.AddFirst(Scopexportablemonitortransaction.Data());
            }

            if (answer_MONITOR_should is true)
            {
                Scopexportablemonitor.Monitor();

                answer_MONITOR_should = false;
            }
            else
                "false".ToString();

            Scopexportablemonitorvalid.Idle = false;

            while (true)
            {
                Boolean isEqualCheck, shouldBreakCheck;

                isEqualCheck = Scopexportablemonitorstate.IsRun is false;

                shouldBreakCheck = isEqualCheck is true;

                if (shouldBreakCheck is true)
                {
                    break;
                }
                else
                    "false".ToString();

                if (Scopexportablemonitorstate.RestartShould is true)
                {
                    goto start;
                }
                else
                    "false".ToString();

                Scopexportableupdate.Update();

                continue;
            }

            return;
        }
    }
}
