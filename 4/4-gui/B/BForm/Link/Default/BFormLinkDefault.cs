using Core;

namespace Core
{
    using System;

    using System.Windows;
    using System.Windows.Forms;

    public partial class BFormDefault
    {
        public static String TextDefault;

        public static Boolean ShowIconDefault;

        public static FormStartPosition FormStartPositionDefault;

        public static Boolean KeyPreviewDefault;

        static BFormDefault()
        {
            TextDefault = "Monitor";

            ShowIconDefault = false;

            FormStartPositionDefault = FormStartPosition.Manual;

            KeyPreviewDefault = true;

            return;
        }
    }
}
