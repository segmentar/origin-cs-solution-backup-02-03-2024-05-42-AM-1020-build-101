using Core;

namespace Core
{
    using System;

    public partial class ScopexportableasyncMessagein
    {
        public static Object GroupDepth(Boolean answer_TASK_should, Boolean answer_THREAD_should, Boolean answer_STA_is, Boolean answer_MTA_is, Boolean answer_SCHEDULE_has, Boolean answer_POOL_has)
        {
            Object objectResult = default;

            ScopexportablecontextMessagein scopexportablemessageinasync;

            scopexportablemessageinasync = new ScopexportablecontextMessagein();

            if (answer_TASK_should is true)
            {
                scopexportablemessageinasync.TaskShould = true;
            }
            else
                "false".ToString();

            if (answer_THREAD_should is true)
            {
                scopexportablemessageinasync.ThreadShould = true;
            }
            else
                "false".ToString();

            if (answer_STA_is is true)
            {
                scopexportablemessageinasync.IsSTA = true;
            }
            else
                "false".ToString();

            if (answer_MTA_is is true)
            {
                scopexportablemessageinasync.IsMTA = true;
            }
            else
                "false".ToString();


            if (answer_SCHEDULE_has is true)
            {
                scopexportablemessageinasync.HasSchedule = true;
            }
            else
                "false".ToString();

            if (answer_POOL_has is true)
            {
                scopexportablemessageinasync.HasPool = true;
            }
            else
                "false".ToString();

            var result = GroupSurface(scopexportablemessageinasync);

            objectResult = result;

            return objectResult;
        }
    }
}
