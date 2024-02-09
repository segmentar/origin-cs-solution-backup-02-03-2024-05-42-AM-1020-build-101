using Core;

namespace Core
{
    using System;

    using System.Threading;
    using System.Threading.Tasks;

    public partial class ScopexportableasyncMessageout
    {
        public static Task GroupTask(ScopexportablecontextMessageout value_SCOPEXPORTABLEMESSAGEOUTASYNC)
        {
            Task taskResult = default;

            Task task;

            if (value_SCOPEXPORTABLEMESSAGEOUTASYNC.HasSchedule)
            {
                task = new Task(GroupAction(value_SCOPEXPORTABLEMESSAGEOUTASYNC));
            }
            else if (value_SCOPEXPORTABLEMESSAGEOUTASYNC.HasPool)
            {
                task = Task.Run(GroupAction(value_SCOPEXPORTABLEMESSAGEOUTASYNC));
            }
            else
            {
                task = default;
            }

            taskResult = task;

            return taskResult;
        }
    }
}
