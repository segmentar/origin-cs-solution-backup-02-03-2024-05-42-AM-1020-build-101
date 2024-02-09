using Core;

namespace Core
{
    using System;

    public partial class Materialxportablelog
    {
        public static void Log(Object value_OBJECT)
        {
            System.Windows.Forms.MessageBox.Show(value_OBJECT.ToString());

            Console.Out.WriteLine(value_OBJECT);

            return;
        }
    }
}
