using Core;

namespace Core
{
    using System;

    public partial class ButtonScopexportableA
    {
        protected override void OnClick(EventArgs e)
        {
            PropagateClickRedirect(this, e);

            if (ButtonPrevent.PropagateClickPrevent)
            {
                return;
            }
            else
            {
                base.OnClick(e);
            }

            return;
        }
    }
}
