using Core;

namespace Core
{
    using System;

    using System.Windows;
    using System.Windows.Forms;

    public partial class FormScopexportableA
    {
        public static void PropagateKeyPressRedirect(Object sender, KeyPressEventArgs e)
        {
            Scopexportablemonitorkey.Key(sender, e.KeyChar);

            return;
        }
    }
}
