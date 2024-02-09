using Core;

namespace Core
{
    using System;

    using System.Windows;
    using System.Windows.Forms;

    public partial class ButtonScopexportableA
    {
        public partial class ButtonDefault
        {
            public static Int32 WidthDefault;

            public static Int32 HeightDefault;

            public static Int32 PaddingHorizontalDefault;

            public static Int32 PaddingVerticalDefault;

            public static FlatStyle FlatStyleDefault;

            static ButtonDefault()
            {
                WidthDefault = 30;

                HeightDefault = 30;

                PaddingHorizontalDefault = 10;

                PaddingVerticalDefault = 5;

                FlatStyleDefault = FlatStyle.Flat;

                return;
            }
        }
    }
}
