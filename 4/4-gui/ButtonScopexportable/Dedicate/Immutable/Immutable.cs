using Core;

namespace Core
{
    using System;

    using System.Windows;
    using System.Windows.Forms;

    public partial class ButtonScopexportable
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
                Width = ButtonScopexportableDefault.WidthDefault;

                Height = ButtonScopexportableDefault.HeightDefault;

                PaddingHorizontal = AButtonDefault.PaddingHorizontalDefault;

                PaddingVertical = AButtonDefault.PaddingVerticalDefault;

                FlatStyle = AButtonDefault.FlatStyleDefault;

                return;
            }
        }
    }
}
