using Core;

namespace Core
{
    using System;

    using System.Windows;
    using System.Windows.Forms;

    public partial class ButtonScopexportableA : Button,
ScopexportableinterfaceAccessorder.IAccessorder,
ScopexportableinterfaceStyleorder.IStyleorder<ButtonScopexportableA>,
ScopexportableinterfaceEventorder.IEventorder<ButtonScopexportableA>
    {
        public ButtonScopexportableA()
        {
            Accessorder();

            return;
        }

        ~ButtonScopexportableA()
        {
            return;
        }

        public void Accessorder()
        {
            Styleorder().Eventorder();

            return;
        }

        public ButtonScopexportableA Eventorder()
        {
            this.Click += PropagateClickRedirect;

            return this;
        }

        public ButtonScopexportableA Styleorder()
        {
            this.FlatStyle = Immutable.FlatStyle;

            return this;
        }
    }
}
