using Core;

namespace Core
{
    using System;

    public partial class ScopexportableasyncMonitor
    { 
        public static Action GroupAction(ScopexportablecontextMonitor value_SCOPEXPORTABLEMONITORASYNC)
        {
            Action actionResult = default;

            Action action;

            action = new Action(GroupTarget);

            actionResult = action;

            return actionResult;
        }
    }
}
