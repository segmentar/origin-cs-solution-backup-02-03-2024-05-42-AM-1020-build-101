using Core;

namespace Core
{
    using System;

    using System.Threading;

    public partial class ScopexportableasyncMessagein
    {
        public static Thread GroupThread()
        {
            Thread threadResult = default;

            ThreadStart threadStart;

            threadStart = new ThreadStart(GroupAction());

            Thread thread;

            thread = new Thread(threadStart);

            threadResult = thread;

            return threadResult;
        }
    }
}
