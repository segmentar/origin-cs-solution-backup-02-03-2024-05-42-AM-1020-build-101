using Core;

namespace Core
{
    using System;

    public partial class ScopexportableasyncMonitor
    {
        public static Object GroupDepth(Boolean answer_TASK_should, Boolean answer_THREAD_should, Boolean answer_STA_is, Boolean answer_MTA_is, Boolean answer_SCHEDULE_has, Boolean answer_POOL_has)
        {
            Object objectResult = default;

            ScopexportablecontextMonitor scopexportablemonitorasync;

            scopexportablemonitorasync = new ScopexportablecontextMonitor();

            if (answer_TASK_should is true)
            {
                scopexportablemonitorasync.TaskShould = true;
            }
            else
                "false".ToString();

            if (answer_THREAD_should is true)
            {
                scopexportablemonitorasync.ThreadShould = true;
            }
            else
                "false".ToString();

            if (answer_STA_is is true)
            {
                scopexportablemonitorasync.IsSTA = true;
            }
            else
                "false".ToString();

            if (answer_MTA_is is true)
            {
                scopexportablemonitorasync.IsMTA = true;
            }
            else
                "false".ToString();

            if (answer_SCHEDULE_has is true)
            {
                scopexportablemonitorasync.HasSchedule = true;
            }
            else
                "false".ToString();

            if (answer_POOL_has is true)
            {
                scopexportablemonitorasync.HasPool = true;
            }
            else
                "false".ToString();

            var result = GroupSurface(scopexportablemonitorasync);

            objectResult = result;

            return objectResult;
        }
    }
}
