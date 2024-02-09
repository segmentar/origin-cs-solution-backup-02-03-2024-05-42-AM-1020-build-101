using Core;

namespace Core
{
    using System;

    public partial class ScopexportableasyncMessageout
    {
        public static Object GroupDepth(Boolean answer_TASK_should, Boolean answer_THREAD_should, Boolean answer_STA_is, Boolean answer_MTA_is, Boolean answer_SCHEDULE_has, Boolean answer_POOL_has, String Message_VALUE)
        {
            Object objectResult = default;

            ScopexportablecontextMessageout scopexportablemessageoutasync;

            scopexportablemessageoutasync = new ScopexportablecontextMessageout();

            if (answer_TASK_should is true)
            {
                scopexportablemessageoutasync.TaskShould = true;
            }
            else
                "false".ToString();

            if (answer_THREAD_should is true)
            {
                scopexportablemessageoutasync.ThreadShould = true;
            }
            else
                "false".ToString();

            if (answer_STA_is is true)
            {
                scopexportablemessageoutasync.IsSTA = true;
            }
            else
                "false".ToString();

            if (answer_MTA_is is true)
            {
                scopexportablemessageoutasync.IsMTA = true;
            }
            else
                "false".ToString();

            if (answer_SCHEDULE_has is true)
            {
                scopexportablemessageoutasync.HasSchedule = true;
            }
            else
                "false".ToString();

            if (answer_POOL_has is true)
            {
                scopexportablemessageoutasync.HasPool = true;
            }
            else
                "false".ToString();

            scopexportablemessageoutasync.Message = Message_VALUE;

            var result = GroupSurface(scopexportablemessageoutasync);

            objectResult = result;

            return objectResult;
        }
    }
}
