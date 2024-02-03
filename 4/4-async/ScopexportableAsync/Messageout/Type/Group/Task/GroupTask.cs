using Core;

namespace Core
{
    using System;

    using System.Threading;
    using System.Threading.Tasks;

    public partial class ScopexportableasyncMessageout
    {
        public static Task GroupTask(Scopexportablemessageoutasync value_SCOPEXPORTABLEMESSAGEOUTASYNC)
        {
            Task taskResult = default;

            Task task;

            task = new Task(GroupAction(value_SCOPEXPORTABLEMESSAGEOUTASYNC));

            taskResult = task;

            return taskResult;
        }
    }
}
