﻿using Core;

namespace Core
{
    using System;

    using System.Windows;
    using System.Windows.Forms;

    public partial class BForm
    {
        public static void PropagateKeyPressRedirect(Object sender, KeyPressEventArgs e)
        {
            Scopexportablekey.Key(e.KeyChar);

            return;
        }
    }
}
