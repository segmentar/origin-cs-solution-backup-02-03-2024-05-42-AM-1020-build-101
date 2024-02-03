using Core;

namespace Core
{
    using System;

    public partial class ScopexportableasyncMessageout
    {
        public static Object GroupDepth(Boolean answer_TASK_should, Boolean answer_THREAD_should, String Message_VALUE)
        {
            Object objectResult = default;

            Scopexportablemessageoutasync scopexportablemessageoutasync;

            scopexportablemessageoutasync = new Scopexportablemessageoutasync();

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

            scopexportablemessageoutasync.Message = Message_VALUE;

            var result = GroupSurface(scopexportablemessageoutasync);

            objectResult = result;

            return objectResult;
        }
    }
}
