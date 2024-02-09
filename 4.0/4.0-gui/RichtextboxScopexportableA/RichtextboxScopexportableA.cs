using Core;

namespace Core
{
    using System;

    using System.Windows;
    using System.Windows.Forms;

    public partial class RichtextboxScopexportableA : RichTextBox,
ScopexportableinterfaceAccessorder.IAccessorder,
ScopexportableinterfaceStyleorder.IStyleorder<RichtextboxScopexportableA>
    {
        public RichtextboxScopexportableA()
        {
            Accessorder();

            return;
        }

        ~RichtextboxScopexportableA()
        {
            return;
        }

        public void Accessorder()
        {
            Styleorder();

            return;
        }

        public RichtextboxScopexportableA Styleorder()
        {
            this.ForeColor = Immutable.ForeColor;

            this.BackColor = Immutable.BackColor;

            this.ReadOnly = Immutable.ReadOnly;

            this.Font = Immutable.Font;

            return this;
        }
    }
}
