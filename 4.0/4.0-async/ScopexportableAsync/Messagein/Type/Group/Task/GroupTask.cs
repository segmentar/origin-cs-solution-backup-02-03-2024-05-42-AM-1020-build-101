using Core;

namespace Core
{
    using System;

    using System.Threading;
    using System.Threading.Tasks;

    public partial class ScopexportableasyncMessagein
    {
        public static Task GroupTask(ScopexportablecontextMessagein value_SCOPEXPORTABLEMESSAGEINASYNC)
        {
            Task taskResult = default;

            Task task;

            if (value_SCOPEXPORTABLEMESSAGEINASYNC.HasSchedule)
            {
                task = new Task(GroupAction());
            }
            else if (value_SCOPEXPORTABLEMESSAGEINASYNC.HasPool)
            {
                task = Task.Run(GroupAction());
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
