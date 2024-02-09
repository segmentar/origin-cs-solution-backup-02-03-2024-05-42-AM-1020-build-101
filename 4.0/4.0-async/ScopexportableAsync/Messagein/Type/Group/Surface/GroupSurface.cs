using Core;

namespace Core
{
    using System;

    public partial class ScopexportableasyncMessagein
    {
        public static Object GroupSurface(ScopexportablecontextMessagein value_SCOPEXPORTABLEMESSAGEINASYNC)
        {
            Object objectResult = default;

            Object objectValue;

            if (value_SCOPEXPORTABLEMESSAGEINASYNC.TaskShould)
            {
                objectValue = GroupTask(value_SCOPEXPORTABLEMESSAGEINASYNC);
            }
            else if (value_SCOPEXPORTABLEMESSAGEINASYNC.ThreadShould)
            {
                objectValue = GroupThread(value_SCOPEXPORTABLEMESSAGEINASYNC);
            }
            else
            {
                objectValue = default;
            }

            objectResult = objectValue;

            return objectResult;
        }
    }
}
