using Core;

namespace Core
{
    using System;

    using System.Windows;
    using System.Windows.Forms;

    public partial class ButtonScopexportableA
    {
        public partial class Immutable
        {
            public static readonly Int32 Width;

            public static readonly Int32 Height;

            public static readonly Int32 PaddingHorizontal;

            public static readonly Int32 PaddingVertical;

            public static readonly FlatStyle FlatStyle;

            static Immutable()
            {
                Width = ButtonDefault.WidthDefault;

                Height = ButtonDefault.HeightDefault;

                PaddingHorizontal = ButtonDefault.PaddingHorizontalDefault;

                PaddingVertical = ButtonDefault.PaddingVerticalDefault;

                FlatStyle = ButtonDefault.FlatStyleDefault;

                return;
            }
        }
    }
}
