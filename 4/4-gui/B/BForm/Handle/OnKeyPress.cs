using Core;

namespace Core
{
    using System;

    using System.Windows;
    using System.Windows.Forms;

    public partial class BForm
    {
        protected override void OnKeyPress(KeyPressEventArgs e)
        {
            PropagateKeyPressRedirect(this, e);

            if (BFormPrevent.PropagateKeyPressPrevent)
            {
                return;
            }
            else
            {
                base.OnKeyPress(e);
            }

            return;
        }
    }
}
