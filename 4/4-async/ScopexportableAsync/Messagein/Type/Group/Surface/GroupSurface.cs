using Core;

namespace Core
{
    using System;

    public partial class ScopexportableasyncMessagein
    {
        public static Object GroupSurface(Scopexportablemessageinasync value_SCOPEXPORTABLEMESSAGEINASYNC)
        {
            Object objectResult = default;

            Object objectValue;

            if (value_SCOPEXPORTABLEMESSAGEINASYNC.TaskShould)
            {
                objectValue = GroupTask();
            }
            else if (value_SCOPEXPORTABLEMESSAGEINASYNC.ThreadShould)
            {
                objectValue = GroupThread();
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
