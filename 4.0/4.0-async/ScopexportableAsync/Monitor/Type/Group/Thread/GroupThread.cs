using Core;

namespace Core
{
    using System;
    using System.Diagnostics.Eventing.Reader;
    using System.Threading;

    public partial class ScopexportableasyncMonitor
    {
        public static Thread GroupThread(ScopexportablecontextMonitor value_SCOPEXPORTABLEMONITORASYNC)
        {
            Thread threadResult = default;

            ThreadStart threadStart;

            threadStart = new ThreadStart(GroupAction(value_SCOPEXPORTABLEMONITORASYNC));

            Thread thread;

            if (value_SCOPEXPORTABLEMONITORASYNC.IsSTA)
            {
                thread = new Thread(threadStart);

                thread.SetApartmentState(ApartmentState.STA);

            }
            else if (value_SCOPEXPORTABLEMONITORASYNC.IsMTA){

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
