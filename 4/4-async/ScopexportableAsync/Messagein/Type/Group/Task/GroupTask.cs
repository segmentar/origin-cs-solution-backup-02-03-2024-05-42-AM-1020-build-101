using Core;

namespace Core
{
    using System;

    using System.Threading;
    using System.Threading.Tasks;

    public partial class ScopexportableasyncMessagein
    {
        public static Task GroupTask()
        {
            Task taskResult = default;

            Task task;

            task = new Task(GroupAction());

            taskResult = task;

            return taskResult;
        }
    }
}
