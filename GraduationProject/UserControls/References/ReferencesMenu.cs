using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using GraduationProject.Forms;
using System.Windows.Forms;

namespace GraduationProject.UserControls
{
    public partial class ReferencesMenu : UserControl
    {
        [Browsable(true)][Category("Action")]
        [Description("Invoked when button is clicked")]
        public event EventHandler ButtonClicked;
        public ReferencesMenu()
        {
            InitializeComponent();
        }

        private void buttonAddresses_Click(object sender, EventArgs e)
        {
            ButtonClicked(new MainForm.EventData("addresses"), new EventArgs());
        }

        private void buttonCattle_Click(object sender, EventArgs e)
        {
            ButtonClicked(new MainForm.EventData("animals"), new EventArgs());
        }

        private void buttonInhabitants_Click(object sender, EventArgs e)
        {
            ButtonClicked(new MainForm.EventData("inhabitants"), new EventArgs());

        }

        private void buttonPropeties_Click(object sender, EventArgs e)
        {
            ButtonClicked(new MainForm.EventData("properties"), new EventArgs());

        }

        private void buttonTrees_Click(object sender, EventArgs e)
        {
            ButtonClicked(new MainForm.EventData("trees"), new EventArgs());
        }
    }
}
