using Core;

namespace Core
{
    using System;

    public partial class ScopexportableasyncMessagein
    {
        public static Object GroupDepth(Boolean answer_TASK_should, Boolean answer_THREAD_should)
        {
            Object objectResult = default;

            Scopexportablemessageinasync scopexportablemessageinasync;

            scopexportablemessageinasync = new Scopexportablemessageinasync();

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

            var result = GroupSurface(scopexportablemessageinasync);

            objectResult = result;

            return objectResult;
        }
    }
}
