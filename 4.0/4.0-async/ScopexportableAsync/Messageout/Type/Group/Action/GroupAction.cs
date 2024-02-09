using Core;

namespace Core
{
    using System;

    public partial class ScopexportableasyncMessageout
    {
        public static Action GroupAction(ScopexportablecontextMessageout value_SCOPEXPORTABLEMESSAGEOUTASYNC)
        {
            Action actionResult = default;

            Action<ScopexportablecontextMessageout> item;

            item = new Action<ScopexportablecontextMessageout>(GroupTarget);

            Action entry;

            entry = new Action(() => { item(value_SCOPEXPORTABLEMESSAGEOUTASYNC); });

            var result = entry;

            actionResult = result;

            return actionResult;
        }
    }
}
