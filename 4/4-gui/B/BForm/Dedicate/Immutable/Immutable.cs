using Core;

namespace Core
{
    using System;

    using System.Windows;
    using System.Windows.Forms;

    public partial class BForm
    {
        public partial class Immutable
        {
            public static readonly String Text;

            public static readonly Boolean ShowIcon;

            public static readonly FormStartPosition FormStartPosition;

            public static readonly Boolean KeyPreview;

            static Immutable()
            {
                Text = BFormDefault.TextDefault;

                ShowIcon = BormDefault.ShowIconDefault;

                FormStartPosition = BFormDefault.FormStartPositionDefault;

                KeyPreview = BFormDefault.KeyPreviewDefault;

                return;
            }
        }
    }
}
