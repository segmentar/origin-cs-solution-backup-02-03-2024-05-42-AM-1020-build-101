﻿using Core;

namespace Core
{
    using System;

    using System.Windows;
    using System.Windows.Forms;

    public partial class AButton : Button,
ScopexportableinterfaceAccessorder.IAccessorder,
ScopexportableinterfaceStyleorder.IStyleorder<AButton>,
ScopexportableinterfaceEventorder.IEventorder<AButton>
    {
        public AButton()
        {
            Accessorder();

            return;
        }

        ~AButton()
        {
            return;
        }

        public void Accessorder()
        {
            Styleorder().Eventorder();

            return;
        }

        public AButton Eventorder()
        {
            this.Click += PropagateClickRedirect;

            return this;
        }

        public AButton Styleorder()
        {
            this.FlatStyle = Immutable.FlatStyle;

            return this;
        }
    }
}
