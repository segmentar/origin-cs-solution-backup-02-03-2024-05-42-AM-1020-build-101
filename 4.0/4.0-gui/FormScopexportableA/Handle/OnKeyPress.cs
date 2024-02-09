using Core;

namespace Core
{
    using System;

    using System.Windows;
    using System.Windows.Forms;

    public partial class FormScopexportableA
    {
        protected override void OnKeyPress(KeyPressEventArgs e)
        {
            PropagateKeyPressRedirect(this, e);

            if (FormPrevent.PropagateKeyPressPrevent)
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
