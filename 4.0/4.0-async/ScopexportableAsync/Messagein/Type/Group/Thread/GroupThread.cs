using Core;

namespace Core
{
    using System;

    using System.Threading;

    public partial class ScopexportableasyncMessagein
    {
        public static Thread GroupThread(ScopexportablecontextMessagein value_SCOPEXPORTABLEMESSAGEINASYNC)
        {
            Thread threadResult = default;

            ThreadStart threadStart;

            threadStart = new ThreadStart(GroupAction());

            Thread thread;

            if (value_SCOPEXPORTABLEMESSAGEINASYNC.IsSTA)
            {
                thread = new Thread(threadStart);

                thread.SetApartmentState(ApartmentState.STA);
            }
            else if (value_SCOPEXPORTABLEMESSAGEINASYNC.IsMTA)
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
