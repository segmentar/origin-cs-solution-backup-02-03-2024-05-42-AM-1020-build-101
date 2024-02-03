using Core;

namespace Core
{
    using System;

    using System.Threading;

    public partial class ScopexportableasyncMessageout
    {
        public static Thread GroupThread(Scopexportablemessageoutasync value_SCOPEXPORTABLEMESSAGEOUTASYNC)
        {
            Thread threadResult = default;

            ThreadStart threadStart;

            threadStart = new ThreadStart(GroupAction(value_SCOPEXPORTABLEMESSAGEOUTASYNC));

            Thread thread;

            thread = new Thread(threadStart);

            threadResult = thread;

            return threadResult;
        }
    }
}
