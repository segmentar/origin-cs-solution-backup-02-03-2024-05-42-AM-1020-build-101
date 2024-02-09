using Core;

namespace Core
{
    using System;

    using System.Windows;
    using System.Windows.Forms;

    public partial class FormScopexportableA
    {
        public partial class Immutable
        {
            public static readonly String Text;

            public static readonly Boolean ShowIcon;

            public static readonly FormStartPosition FormStartPosition;

            public static readonly Boolean KeyPreview;

            static Immutable()
            {
                Text = FormDefault.TextDefault;

                ShowIcon = FormDefault.ShowIconDefault;

                FormStartPosition = FormDefault.FormStartPositionDefault;

                KeyPreview = FormDefault.KeyPreviewDefault;

                return;
            }
        }
    }
}
