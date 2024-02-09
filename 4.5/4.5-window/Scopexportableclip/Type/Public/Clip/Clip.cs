using Core;

namespace Core
{
    using System;

    using System.Linq;
        
    using System.Windows;
    using System.Windows.Forms;

    public partial class Scopexportableclip
    {
        public static void Clip(Object reflect_OBJECT)
        {
            var reflect = (FormScopexportableA)(reflect_OBJECT as Object);

            var value = reflect.Controls.OfType<PanelScopexportableA>().First<PanelScopexportableA>().Controls.OfType<RichtextboxScopexportableA>().First<RichtextboxScopexportableA>().Text;

            Clipboard.SetText(value);

            return;
        }
    }
}
