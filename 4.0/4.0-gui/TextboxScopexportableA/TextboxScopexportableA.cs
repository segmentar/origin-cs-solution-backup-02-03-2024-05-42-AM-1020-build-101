using Core;

namespace Core
{
    using System;

    using System.Windows;
    using System.Windows.Forms;

    public partial class TextboxScopexportableA : TextBox,
ScopexportableinterfaceAccessorder.IAccessorder,
ScopexportableinterfaceStyleorder.IStyleorder<TextboxScopexportableA>,
ScopexportableinterfaceEventorder.IEventorder<TextboxScopexportableA>
    {
        public TextboxScopexportableA()
        {
            Accessorder();

            return;
        }

        ~TextboxScopexportableA()
        {
            return;
        }

        public void Accessorder()
        {
            Styleorder().Eventorder();

            return;
        }

        public TextboxScopexportableA Eventorder()
        {
            this.TextChanged += PropagateTextChangedRedirect;

            this.KeyPress += PropagateKeyPressRedirect;

            return this;
        }

        public TextboxScopexportableA Styleorder()
        {
            this.ForeColor = Immutable.ForeColor;

            this.BackColor = Immutable.BackColor;

            this.BorderStyle = Immutable.borderStyle;

            this.Font = Immutable.Font;

            return this;
        }
    }
}
