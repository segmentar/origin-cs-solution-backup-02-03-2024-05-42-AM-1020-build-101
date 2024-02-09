using Core;

namespace Core
{
    using System;

    using System.Linq;

    using System.Windows;
    using System.Windows.Forms;

    public partial class Scopexportablespeed
    {
        public static void Speed(Object reflect_OBJECT)
        {
            var reflect = (FormScopexportableA)(reflect_OBJECT as Object);

            reflect.Hide();

            TextBox textBox;

            textBox = new TextBox();

            textBox.Dock = DockStyle.Fill;

            Form form;

            form = new Form();

            form.Text = "Speed";

            form.Controls.Add(textBox);

            form.Show();

            form.FormClosed += new FormClosedEventHandler((Object sender, FormClosedEventArgs e) => {

                var parse = Int32.Parse(textBox.Text);

                Scopexportablemonitorstate.Interval = parse;

                Scopexportablemonitorframe.LinkedList.AddLast(Scopexportablemonitortransaction.Data());

                Scopexportablemonitorframe.Pointer = Scopexportablemonitorframe.Pointer + 1;

                reflect.Show();
            });

            return;
        }
    }
}
