using Core;

namespace Core
{
    using System;

    using System.Threading;

    public partial class Scopexportableupdate
    {
        public static void Update()
        {
            while (true)
            {
                Boolean isEqualCheck, shouldBreakCheck;

                isEqualCheck = Scopexportablemonitorstate.IsPause is true;

                shouldBreakCheck = isEqualCheck is false;

                if (shouldBreakCheck is true)
                {
                    break;
                }
                else
                    "false".ToString();

                continue;
            }

            Thread.Sleep(Scopexportablemonitorstate.Interval);

            Scopexportableunpause.Unpause();

            Scopexportablemonitorframe.Pointer = Scopexportablemonitorframe.Pointer + 1;

            Scopexportablemonitorframe.LinkedList.AddLast(Scopexportablemonitortransaction.Data());

            return;
        }
    }
}
