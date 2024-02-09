using Core;

namespace Core
{
    using System;

    using System.Windows;
    using System.Windows.Forms;

    public partial class ScopexportableasyncMonitor
    {
        public static void GroupTarget()
        {
            Form form;

            form = new FormScopexportableA();

            ApplicationContext applicationContext;

            applicationContext = new ApplicationcontextScopexportableA(form);

            Application.Run(applicationContext);

            return;
        }
    }
}
