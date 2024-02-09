using Core;

namespace Core
{
    using System;

    public partial class ScopexportableasyncMonitor
    {
        public static Object GroupSurface(ScopexportablecontextMonitor value_SCOPEXPORTABLEMONITORASYNC)
        {
            Object objectResult = default;

            Object objectValue;

            if (value_SCOPEXPORTABLEMONITORASYNC.TaskShould)
            {
                objectValue = GroupTask(value_SCOPEXPORTABLEMONITORASYNC);
            }
            else if (value_SCOPEXPORTABLEMONITORASYNC.ThreadShould)
            {
                objectValue = GroupThread(value_SCOPEXPORTABLEMONITORASYNC);
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
