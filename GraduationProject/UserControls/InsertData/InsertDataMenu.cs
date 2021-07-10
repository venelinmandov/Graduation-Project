using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace GraduationProject.UserControls.InsertData
{
    public partial class InsertDataMenu : UserControl
    {
        [Browsable(true)]
        [Category("Action")]
        [Description("Invoked when button is clicked")]
        public event EventHandler ButtonClicked;

        public InsertDataMenu()
        {
            InitializeComponent();
        }

        private void buttonAddresses_Click(object sender, EventArgs e)
        {
            ButtonClicked(new Forms.MainForm.EventData("addressesMenu"), e);

        }

        private void buttonStreets_Click(object sender, EventArgs e)
        {
            ButtonClicked(new Forms.MainForm.EventData("streetsMenu"), e);

        }
    }
}
