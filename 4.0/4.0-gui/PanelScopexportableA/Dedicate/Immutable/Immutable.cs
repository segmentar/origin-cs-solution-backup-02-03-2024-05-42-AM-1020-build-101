using Core;

namespace Core
{
    using System;

    using System.Windows;
    using System.Windows.Forms;

    using System.Drawing;

    public partial class PanelScopexportableA
    {
        public partial class Immutable
        {
            public static Color BackColor;

            public static DockStyle DockStyle;

            static Immutable()
            {
                BackColor = PanelDefault.BackColorDefault;

                DockStyle = PanelDefault.DockStyleDefault;

                return;
            }
        }
    }
}
