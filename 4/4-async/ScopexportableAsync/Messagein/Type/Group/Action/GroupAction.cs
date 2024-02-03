using Core;

namespace Core
{
    using System;

    public partial class ScopexportableasyncMessagein
    {
        public static Action GroupAction()
        {
            Action actionResult = default;

            Action action;

            action = new Action(GroupTarget);

            actionResult = action;

            return actionResult;
        }
    }
}
