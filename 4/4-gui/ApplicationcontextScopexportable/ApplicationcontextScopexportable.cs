using Core;

namespace Core
{
    using System;

    using System.Windows;
    using System.Windows.Forms;

    public partial class ApplicationcontextScopexportable : ApplicationContext
    {
        public ApplicationcontextScopexportable(Form form) : base(form)
        {
            return;
        }

        ~ApplicationcontextScopexportable()
        {
            return;
        }
    }
}
