using Core;

namespace Core
{
    using System;

    using System.Windows;
    using System.Windows.Forms;

    public partial class FormScopexportableA
    {
        public partial class FormDefault
        {
            public static String TextDefault;

            public static Boolean ShowIconDefault;

            public static FormStartPosition FormStartPositionDefault;

            public static Boolean KeyPreviewDefault;

            static FormDefault()
            {
                TextDefault = "Monitor";

                ShowIconDefault = false;

                FormStartPositionDefault = FormStartPosition.Manual;

                KeyPreviewDefault = true;

                return;
            }
        }
    }
}
