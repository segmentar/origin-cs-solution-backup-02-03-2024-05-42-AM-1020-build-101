using Core;

namespace Core
{
    using System;

    using System.Linq;

    using System.Windows;
    using System.Windows.Forms;

    using System.Drawing;

    public partial class Scopexportablefontdown
    {
        public static void Fontdown()
        {
            foreach (FormScopexportableA form in Application.OpenForms)
            {
                var inflect = new Object[2];

                inflect[0] = form.Controls.OfType<TextboxScopexportableA>().First<TextboxScopexportableA>();

                inflect[1] = form.Controls.OfType<PanelScopexportableA>().First<PanelScopexportableA>().Controls.OfType<RichtextboxScopexportableA>().First<RichtextboxScopexportableA>();

                var value = 0.00F;

                value = value + ((TextboxScopexportableA)inflect[0]).Font.Size;

                value = value - 1.00F;

                ((TextboxScopexportableA)inflect[0]).Font = new Font(((TextboxScopexportableA)inflect[0]).Font.FontFamily, value, ((TextboxScopexportableA)inflect[0]).Font.Style);

                ((RichtextboxScopexportableA)inflect[1]).Font = new Font(((RichtextboxScopexportableA)inflect[1]).Font.FontFamily, value, ((RichtextboxScopexportableA)inflect[1]).Font.Style);

                continue;
            }

            return;
        }
    }
}
