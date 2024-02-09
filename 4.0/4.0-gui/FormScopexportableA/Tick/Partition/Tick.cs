using Core;

namespace Core
{
    using System;

    using System.Linq;

    using System.Windows;
    using System.Windows.Forms;

    using System.Drawing;

    public partial class FormScopexportableA
    {
        public void Tickupdate(Object sender, EventArgs e)
        {
            var value = Controls.OfType<TextboxScopexportableA>().FirstOrDefault<TextboxScopexportableA>();

            Boolean isDefaultCheck, isNotDefaultCheck;

            isDefaultCheck = (value == default) is true;

            isNotDefaultCheck = isDefaultCheck is false;

            if (isNotDefaultCheck is true)
            {
                TextboxScopexportableA.PropagateTextChangedRedirect(value, e);
            }
            else
                "false".ToString();

            return;
        }

        public void Ticktextbox(Object sender, EventArgs e)
        {
            foreach (FormScopexportableA form in Application.OpenForms.OfType<FormScopexportableA>().Cast<FormScopexportableA>())
            {
                var inflect = new Object[1];

                inflect[0] = form.Controls.OfType<TextboxScopexportableA>().First<TextboxScopexportableA>();

                Int32 x, y;

                x = 0;

                y = 0;

                Int32 width, height;

                width = 0;
                
                width = width + form.ClientRectangle.Size.Width;

                height = 0;
                
                height = height + ((TextboxScopexportableA)inflect[0]).ClientRectangle.Size.Height;

                Point point;

                point = new Point(x, y);

                Size size;

                size = new Size(width, height);

                ((TextboxScopexportableA)inflect[0]).Location = point;

                ((TextboxScopexportableA)inflect[0]).Size = size;

                continue;
            }
        }

        public void Tickrichtextbox(Object sender, EventArgs e)
        {
            foreach (FormScopexportableA form in Application.OpenForms.OfType<FormScopexportableA>().Cast<FormScopexportableA>())
            {
                var inflect = new Object[2];

                inflect[0] = form.Controls.OfType<TextboxScopexportableA>().First<TextboxScopexportableA>();

                inflect[1] = form.Controls.OfType<PanelScopexportableA>().First<PanelScopexportableA>().Controls.OfType<RichtextboxScopexportableA>().First<RichtextboxScopexportableA>();

                Int32 x, y;

                x = 0;

                x = x + ButtonScopexportableA.Immutable.Width;

                y = 0;

                y = y + ButtonScopexportableA.Immutable.Height;

                y = y + ((TextboxScopexportableA)inflect[0]).ClientRectangle.Size.Height;

                Int32 width, height;

                width = 0;
                
                width = width + form.ClientRectangle.Size.Width;

                width = width - ButtonScopexportableA.Immutable.Width;

                width = width - ButtonScopexportableA.Immutable.Width;

                height = 0;

                height = height + form.ClientRectangle.Height;

                height = height - ((TextboxScopexportableA)inflect[0]).ClientRectangle.Size.Height;

                height = height - ButtonScopexportableA.Immutable.Height;

                height = height - ButtonScopexportableA.Immutable.Height;

                Point point;

                point = new Point(x, y);

                Size size;

                size = new Size(width, height);

                ((RichTextBox)inflect[1]).Location = point;

                ((RichTextBox)inflect[1]).Size = size;

                continue;
            }

            return;
        }
    }
}

namespace Core
{
    using System;

    using System.Linq;

    using System.Windows;
    using System.Windows.Forms;

    using System.Drawing;

    public partial class FormScopexportableA
    {
        public void Ticktopbutton(Object sender, EventArgs e)
        {
            foreach (FormScopexportableA form in Application.OpenForms.OfType<FormScopexportableA>().Cast<FormScopexportableA>())
            {
                var inflect = new Object[2];

                inflect[0] = form.Controls.OfType<TextboxScopexportableA>().First<TextboxScopexportableA>();

                inflect[1] = form.Controls.OfType<PanelScopexportableA>().First<PanelScopexportableA>();

                if ((((PanelScopexportableA)inflect[1]).PageValue.Top == default).Equals(false))
                {
                    Int32 x, y;

                    x = 0;

                    x = x + ButtonScopexportableA.Immutable.Width;

                    y = 0;

                    y = y + ((TextboxScopexportableA)inflect[0]).Size.Height;

                    Int32 width, height;

                    width = 0;

                    width = width + form.ClientRectangle.Size.Width;

                    width = width - ButtonScopexportableA.Immutable.Width;

                    width = width - ButtonScopexportableA.Immutable.Width;

                    height = ButtonScopexportableA.Immutable.Height;

                    if (ButtonScopexportableA.ButtonPolicy.PaddingHorizontalPolicy is true)
                    {
                        x = x + ButtonScopexportableA.Immutable.PaddingHorizontal;

                        width = width - ButtonScopexportableA.Immutable.PaddingHorizontal;

                        width = width - ButtonScopexportableA.Immutable.PaddingHorizontal;
                    }
                    else
                        "false".ToString();

                    if (ButtonScopexportableA.ButtonPolicy.PaddingVerticalPolicy is true)
                    {
                        y = y + ButtonScopexportableA.Immutable.PaddingVertical;

                        height = height - ButtonScopexportableA.Immutable.PaddingVertical;

                        height = height - ButtonScopexportableA.Immutable.PaddingVertical;
                    }
                    else
                        "false".ToString();

                    Point point;

                    point = new Point(x, y);

                    Size size;

                    size = new Size(width, height);

                    ((PanelScopexportableA)inflect[1]).PageValue.Top.Location = point;

                    ((PanelScopexportableA)inflect[1]).PageValue.Top.Size = size;

                }
                else
                    "false".ToString();

                continue;
            }

            return;
        }
    }
}

namespace Core
{
    using System;

    using System.Linq;

    using System.Windows;
    using System.Windows.Forms;

    using System.Drawing;

    public partial class FormScopexportableA
    {
        public void Tickbottombutton(Object sender, EventArgs e)
        {
            foreach (FormScopexportableA form in Application.OpenForms.OfType<FormScopexportableA>().Cast<FormScopexportableA>())
            {
                var inflect = new Object[2];

                inflect[0] = form.Controls.OfType<TextboxScopexportableA>().First<TextboxScopexportableA>();

                inflect[1] = form.Controls.OfType<PanelScopexportableA>().First<PanelScopexportableA>();

                if ((((PanelScopexportableA)inflect[1]).PageValue.Bottom == default).Equals(false))
                {
                    Int32 x, y;

                    x = 0;

                    x = x + ButtonScopexportableA.Immutable.Width;
                 
                    y = 0;

                    y = y + ((TextboxScopexportableA)inflect[0]).Size.Height;

                    y = y + form.ClientRectangle.Size.Height;

                    Int32 width, height;

                    width = 0;

                    width = width + form.ClientRectangle.Size.Width;

                    width = width - ButtonScopexportableA.Immutable.Width;

                    width = width - ButtonScopexportableA.Immutable.Width;

                    height = 0;

                    height = height + ButtonScopexportableA.Immutable.Height;

                    y = y - height;

                    y = y - ((TextboxScopexportableA)inflect[0]).Size.Height;

                    if (ButtonScopexportableA.ButtonPolicy.PaddingHorizontalPolicy is true)
                    {
                        x = x + ButtonScopexportableA.Immutable.PaddingHorizontal;

                        width = width - ButtonScopexportableA.Immutable.PaddingHorizontal;

                        width = width - ButtonScopexportableA.Immutable.PaddingHorizontal;
                    }
                    else
                        "false".ToString();

                    if (ButtonScopexportableA.ButtonPolicy.PaddingVerticalPolicy is true)
                    {
                        y = y + ButtonScopexportableA.Immutable.PaddingVertical;

                        height = height - ButtonScopexportableA.Immutable.PaddingVertical;

                        height = height - ButtonScopexportableA.Immutable.PaddingVertical;
                    }
                    else
                        "false".ToString();

                    Point point;

                    point = new Point(x, y);

                    Size size;

                    size = new Size(width, height);

                    ((PanelScopexportableA)inflect[1]).PageValue.Bottom.Location = point;

                    ((PanelScopexportableA)inflect[1]).PageValue.Bottom.Size = size;
                }
                else
                    "false".ToString();

                continue;
            }

            return;
        }
    }
}

namespace Core
{
    using System;

    using System.Linq;

    using System.Windows;
    using System.Windows.Forms;

    using System.Drawing;

    public partial class FormScopexportableA
    {
        public void Tickleftbutton(Object sender, EventArgs e)
        {
            foreach (FormScopexportableA form in Application.OpenForms.OfType<FormScopexportableA>().Cast<FormScopexportableA>())
            {
                var inflect = new Object[2];

                inflect[0] = form.Controls.OfType<TextboxScopexportableA>().First<TextboxScopexportableA>();

                inflect[1] = form.Controls.OfType<PanelScopexportableA>().First<PanelScopexportableA>();

                if ((((PanelScopexportableA)inflect[1]).PageValue.Left == default).Equals(false))
                {
                    Int32 x, y;

                    x = 0;

                    y = 0;

                    y = y + ((TextboxScopexportableA)inflect[0]).ClientRectangle.Size.Height;

                    y = y + ButtonScopexportableA.Immutable.Height;

                    Int32 width, height;

                    width = 0;

                    width = width + ButtonScopexportableA.Immutable.Width;

                    height = 0;

                    height = height + form.ClientRectangle.Size.Height;

                    height = height - ButtonScopexportableA.Immutable.Height;

                    height = height - ButtonScopexportableA.Immutable.Height;

                    height = height - ((TextboxScopexportableA)inflect[0]).ClientRectangle.Size.Height;

                    if (ButtonScopexportableA.ButtonPolicy.PaddingHorizontalPolicy is true)
                    {
                        x = x + ButtonScopexportableA.Immutable.PaddingHorizontal;

                        width = width - ButtonScopexportableA.Immutable.PaddingHorizontal;

                        width = width - ButtonScopexportableA.Immutable.PaddingHorizontal;
                    }
                    else
                        "false".ToString();

                    if (ButtonScopexportableA.ButtonPolicy.PaddingVerticalPolicy is true)
                    {
                        y = y + ButtonScopexportableA.Immutable.PaddingVertical;

                        height = height - ButtonScopexportableA.Immutable.PaddingVertical;

                        height = height - ButtonScopexportableA.Immutable.PaddingVertical;
                    }
                    else
                        "false".ToString();

                    Point point;

                    point = new Point(x, y);

                    Size size;

                    size = new Size(width, height);

                    ((PanelScopexportableA)inflect[1]).PageValue.Left.Location = point;

                    ((PanelScopexportableA)inflect[1]).PageValue.Left.Size = size;
                }
                else
                    "false".ToString();

                continue;
            }

            return;
        }
    }
}

namespace Core
{
    using System;

    using System.Linq;

    using System.Windows;
    using System.Windows.Forms;

    using System.Drawing;

    public partial class FormScopexportableA
    {
        public void Tickrightbutton(Object sender, EventArgs e)
        {
            foreach (FormScopexportableA form in Application.OpenForms.OfType<FormScopexportableA>().Cast<FormScopexportableA>())
            {
                var inflect = new Object[2];

                inflect[0] = form.Controls.OfType<TextboxScopexportableA>().First<TextboxScopexportableA>();

                inflect[1] = form.Controls.OfType<PanelScopexportableA>().First<PanelScopexportableA>();

                if ((((PanelScopexportableA)inflect[1]).PageValue.Right == default).Equals(false))
                {
                    Int32 x, y;

                    x = 0;

                    x = x + form.ClientRectangle.Size.Width;

                    x = x - ButtonScopexportableA.Immutable.Width;

                    y = 0;

                    y = y + ((TextboxScopexportableA)inflect[0]).ClientRectangle.Size.Height;

                    y = y + ButtonScopexportableA.Immutable.Height;

                    Int32 width, height;

                    width = 0;

                    width = width + ButtonScopexportableA.Immutable.Width;

                    height = 0;

                    height = height + form.ClientRectangle.Size.Height;

                    height = height - ButtonScopexportableA.Immutable.Height;

                    height = height - ButtonScopexportableA.Immutable.Height;

                    height = height - ((TextboxScopexportableA)inflect[0]).ClientRectangle.Size.Height;

                    if (ButtonScopexportableA.ButtonPolicy.PaddingHorizontalPolicy is true)
                    {
                        x = x + ButtonScopexportableA.Immutable.PaddingHorizontal;

                        width = width - ButtonScopexportableA.Immutable.PaddingHorizontal;

                        width = width - ButtonScopexportableA.Immutable.PaddingHorizontal;
                    }
                    else
                        "false".ToString();

                    if (ButtonScopexportableA.ButtonPolicy.PaddingVerticalPolicy is true)
                    {
                        y = y + ButtonScopexportableA.Immutable.PaddingVertical;

                        height = height - ButtonScopexportableA.Immutable.PaddingVertical;

                        height = height - ButtonScopexportableA.Immutable.PaddingVertical;
                    }
                    else
                        "false".ToString();

                    Point point;

                    point = new Point(x, y);

                    Size size;

                    size = new Size(width, height);

                    ((PanelScopexportableA)inflect[1]).PageValue.Right.Location = point;

                    ((PanelScopexportableA)inflect[1]).PageValue.Right.Size = size;
                }
                else
                    "false".ToString();

                continue;
            }

            return;
        }
    }
}

namespace Core
{
    using System;

    using System.Windows;
    using System.Windows.Forms;

    using System.Drawing;
    using System.Linq;

    public partial class FormScopexportableA
    {
        public void Ticktopalign(Object sender, EventArgs e)
        {
            foreach (FormScopexportableA form in Application.OpenForms.OfType<FormScopexportableA>().Cast<FormScopexportableA>())
            {
                if ((form.Scopexportablemonitorcontext.Owner == default).Equals(false) && form.Scopexportablemonitorcontext.FormDirection is ScopexportableCode.FormDirection.Top)
                {
                    Int32 x, y;

                    x = 0;
                    
                    x = x + form.Scopexportablemonitorcontext.Owner.Location.X;

                    y = 0;
                    
                    y = y + form.Scopexportablemonitorcontext.Owner.Location.Y;

                    Int32 width, height;

                    width = 0;
                     
                    width = width + form.Scopexportablemonitorcontext.Owner.Size.Width;

                    height = 0;
                    
                    height = height + form.Scopexportablemonitorcontext.Owner.Size.Height;

                    y = y - height;

                    Point point;

                    point = new Point(x, y);

                    Size size;

                    size = new Size(width, height);

                    form.Location = point;

                    form.Size = size;
                }
                else
                    "false".ToString();

                continue;
            }

            return;
        }
    }
}

namespace Core
{
    using System;

    using System.Windows;
    using System.Windows.Forms;

    using System.Drawing;
    using System.Linq;

    public partial class FormScopexportableA
    {
        public void Tickbottomalign(Object sender, EventArgs e)
        {
            foreach (FormScopexportableA form in Application.OpenForms.OfType<FormScopexportableA>().Cast<FormScopexportableA>())
            {
                if ((form.Scopexportablemonitorcontext.Owner == default).Equals(false) && form.Scopexportablemonitorcontext.FormDirection is ScopexportableCode.FormDirection.Bottom)
                {
                    Int32 x, y;

                    x = 0;

                    x = x + form.Scopexportablemonitorcontext.Owner.Location.X;

                    y = 0;

                    y = y + form.Scopexportablemonitorcontext.Owner.Location.Y;

                    Int32 width, height;

                    width = 0;

                    width = width + form.Scopexportablemonitorcontext.Owner.Size.Width;

                    height = 0;

                    height = height + form.Scopexportablemonitorcontext.Owner.Size.Height;

                    y = y + height;

                    Point point;

                    point = new Point(x, y);

                    Size size;

                    size = new Size(width, height);

                    form.Location = point;

                    form.Size = size;
                }
                else
                    "false".ToString();

                continue;
            }

            return;
        }
    }
}

namespace Core
{
    using System;

    using System.Windows;
    using System.Windows.Forms;

    using System.Drawing;
    using System.Linq;

    public partial class FormScopexportableA
    {
        public void Tickleftalign(Object sender, EventArgs e)
        {
            foreach (FormScopexportableA form in Application.OpenForms.OfType<FormScopexportableA>().Cast<FormScopexportableA>())
            {
                if ((form.Scopexportablemonitorcontext.Owner == default).Equals(false) && form.Scopexportablemonitorcontext.FormDirection is ScopexportableCode.FormDirection.Left)
                {
                    Int32 x, y;

                    x = 0;

                    x = x + form.Scopexportablemonitorcontext.Owner.Location.X;

                    y = 0;

                    y = y + form.Scopexportablemonitorcontext.Owner.Location.Y;

                    Int32 width, height;

                    width = 0;

                    width = width + form.Scopexportablemonitorcontext.Owner.Size.Width;

                    height = 0;

                    height = height + form.Scopexportablemonitorcontext.Owner.Size.Height;

                    x = x - width;

                    Point point;

                    point = new Point(x, y);

                    Size size;

                    size = new Size(width, height);

                    form.Location = point;

                    form.Size = size;
                }
                else
                    "false".ToString();

                continue;
            }

            return;
        }
    }
}

namespace Core
{
    using System;

    using System.Windows;
    using System.Windows.Forms;

    using System.Drawing;
    using System.Linq;

    public partial class FormScopexportableA
    {
        public void Tickrightalign(Object sender, EventArgs e)
        {
            foreach (FormScopexportableA form in Application.OpenForms.OfType<FormScopexportableA>().Cast<FormScopexportableA>())
            {
                if ((form.Scopexportablemonitorcontext.Owner == default).Equals(false) && form.Scopexportablemonitorcontext.FormDirection is ScopexportableCode.FormDirection.Right)
                {
                    Int32 x, y;

                    x = 0;

                    x = x + form.Scopexportablemonitorcontext.Owner.Location.X;

                    y = 0;

                    y = y + form.Scopexportablemonitorcontext.Owner.Location.Y;

                    Int32 width, height;

                    width = 0;

                    width = width + form.Scopexportablemonitorcontext.Owner.Size.Width;

                    height = 0;

                    height = height + form.Scopexportablemonitorcontext.Owner.Size.Height;

                    x = x + width;

                    Point point;

                    point = new Point(x, y);

                    Size size;

                    size = new Size(width, height);

                    form.Location = point;

                    form.Size = size;
                }
                else
                    "false".ToString();

                continue;
            }

            return;
        }
    }
}