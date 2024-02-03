using Core;

namespace Core
{
    using System;

    public partial class ScopexportableasyncMessageout
    {
        public static Action GroupAction(Scopexportablemessageoutasync value_SCOPEXPORTABLEMESSAGEOUTASYNC)
        {
            Action actionResult = default;

            Action action;

            action = new Action(() => { GroupTarget(value_SCOPEXPORTABLEMESSAGEOUTASYNC); });

            actionResult = action;

            return actionResult;
        }
    }
}
