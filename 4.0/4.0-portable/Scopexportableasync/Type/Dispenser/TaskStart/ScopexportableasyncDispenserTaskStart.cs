using Core;

namespace Core
{
    using System;

    using System.Threading;
    using System.Threading.Tasks;

    public partial class Scopexportableasync
    {
        public static Task ScopexportableasyncTaskStartDispenser(Object reflect_OBJECT, Int32 Linger_VALUE)
        {
            Task taskResult = default;

            var result = (Task)(reflect_OBJECT as Object);

            result.Wait(Linger_VALUE);

            taskResult = result;

            return taskResult;
        }
    }
}
