using Core;

namespace Core
{
    using System;

    using System.Threading;
    using System.Threading.Tasks;

    public partial class ScopexportableasyncMonitor
    {
        public static Task GroupTask(ScopexportablecontextMonitor value_SCOPEXPORTABLEMONITORASYNC)
        {
            Task taskResult = default;

            Task task;

            if (value_SCOPEXPORTABLEMONITORASYNC.HasSchedule)
            {
                task = new Task(GroupAction(value_SCOPEXPORTABLEMONITORASYNC));

            }
            else if (value_SCOPEXPORTABLEMONITORASYNC.HasPool)
            {
                task = Task.Run(GroupAction(value_SCOPEXPORTABLEMONITORASYNC));
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
