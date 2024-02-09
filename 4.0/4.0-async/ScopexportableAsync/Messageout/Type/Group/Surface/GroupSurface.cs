using Core;

namespace Core
{
    using System;

    public partial class ScopexportableasyncMessageout
    {
        public static Object GroupSurface(ScopexportablecontextMessageout value_SCOPEXPORTABLEMESSAGEOUTASYNC)
        {
            Object objectResult = default;

            Object objectValue;

            if (value_SCOPEXPORTABLEMESSAGEOUTASYNC.TaskShould)
            {
                objectValue = GroupTask(value_SCOPEXPORTABLEMESSAGEOUTASYNC);
            }
            else if (value_SCOPEXPORTABLEMESSAGEOUTASYNC.ThreadShould)
            {
                objectValue = GroupThread(value_SCOPEXPORTABLEMESSAGEOUTASYNC);
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
