namespace Core
{
    using System.Drawing;
    using System.Windows.Forms;

    public partial class PanelScopexportableA : Panel,
ScopexportableinterfaceExposer.IExposer<PanelScopexportableA>,
ScopexportableinterfaceAccessorder.IAccessorder,
ScopexportableinterfaceStyleorder.IStyleorder<PanelScopexportableA>,
ScopexportableinterfaceControlorder.IControlorder<PanelScopexportableA>
    {
        public Page PageValue = new Page();

        public PanelScopexportableA()
        {
            Accessorder();

            return;
        }

        ~PanelScopexportableA()
        {
            return;
        }

        public PanelScopexportableA ExposePage()
        {
            PageValue.Top = (ButtonScopexportableA)(Controls.Find(Scopexportablestoredirection.EntityTop, false)[0] as Control);

            PageValue.Bottom = (ButtonScopexportableA)(Controls.Find(Scopexportablestoredirection.EntityBottom, false)[0] as Control);

            PageValue.Left = (ButtonScopexportableA)(Controls.Find(Scopexportablestoredirection.EntityLeft, false)[0] as Control);

            PageValue.Right = (ButtonScopexportableA)(Controls.Find(Scopexportablestoredirection.EntityRight, false)[0] as Control);

            return this;
        }

        public PanelScopexportableA CleanPage()
        {
            return this;
        }

        public void Accessorder()
        {
            Styleorder().Controlorder().ExposePage();

            return;
        }

        public PanelScopexportableA Controlorder()
        {
            ButtonScopexportableA[] buttonArray;

            buttonArray = new ButtonScopexportableA[4];

            buttonArray[0] = new ButtonScopexportableA() { Name = Scopexportablestoredirection.EntityTop };

            buttonArray[1] = new ButtonScopexportableA() { Name = Scopexportablestoredirection.EntityBottom };

            buttonArray[2] = new ButtonScopexportableA() { Name = Scopexportablestoredirection.EntityLeft };

            buttonArray[3] = new ButtonScopexportableA() { Name = Scopexportablestoredirection.EntityRight };

            buttonArray[0].BackColor = Color.Red;

            buttonArray[1].BackColor = Color.Blue;

            buttonArray[2].BackColor = Color.Yellow;

            buttonArray[3].BackColor = Color.Green;

            RichtextboxScopexportableA arichtextbox;

            arichtextbox = new RichtextboxScopexportableA();

            this.Controls.Add(buttonArray[0]);

            this.Controls.Add(buttonArray[1]);

            this.Controls.Add(buttonArray[2]);

            this.Controls.Add(buttonArray[3]);

            this.Controls.Add(arichtextbox);

            return this;
        }

        public PanelScopexportableA Styleorder()
        {
            this.BackColor = Immutable.BackColor;

            this.Dock = Immutable.DockStyle;

            return this;
        }
    }
}
