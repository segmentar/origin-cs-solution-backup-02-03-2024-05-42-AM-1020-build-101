using Core;

namespace Core
{
    using System;

    using System.Windows;
    using System.Windows.Forms;

    using System.Drawing;

    public partial class PanelScopexportableA
    {
        public partial class PanelDefault
        {
            public static Color BackColorDefault;

            public static DockStyle DockStyleDefault;

            static PanelDefault()
            {
                BackColorDefault = Color.Orange;

                DockStyleDefault = DockStyle.Fill;

                return;
            }
        }
    }
}
