using Core;

namespace Core
{
    using System;

    using System.Threading;

    public partial class ScopexportableasyncMessageout
    {
        public static Thread GroupThread(ScopexportablecontextMessageout value_SCOPEXPORTABLEMESSAGEOUTASYNC)
        {
            Thread threadResult = default;

            ThreadStart threadStart;

            threadStart = new ThreadStart(GroupAction(value_SCOPEXPORTABLEMESSAGEOUTASYNC));

            Thread thread;

            if (value_SCOPEXPORTABLEMESSAGEOUTASYNC.IsSTA)
            {
                thread = new Thread(threadStart);

                thread.SetApartmentState(ApartmentState.STA);
            }
            else if (value_SCOPEXPORTABLEMESSAGEOUTASYNC.IsMTA)
            {
                thread = new Thread(threadStart);

                thread.SetApartmentState(ApartmentState.MTA);
            }
            else
            {
                thread = default;
            }

            threadResult = thread;

            return threadResult;
        }
    }
}
