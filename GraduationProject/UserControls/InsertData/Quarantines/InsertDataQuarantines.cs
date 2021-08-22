using GraduationProject.Models;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace GraduationProject.UserControls.InsertData.Quarantines
{
    public partial class InsertDataQuarantines : UserControl
    {

        [Browsable(true)]
        [Category("Action")]
        [Description("Invoked when button is clicked")]
        public event EventHandler ButtonClicked;

        public InsertDataQuarantines()
        {
            InitializeComponent();
        }

        private void buttonInhabitantsQuarantines_Click(object sender, EventArgs e)
        {
            ButtonClicked(new Forms.MainForm.EventData("inserDataQuarantinesChooseAddress", typeof(InhabitantsQuarantine)), e);
        }

        private void buttonAnimalsQuarantines_Click(object sender, EventArgs e)
        {
            ButtonClicked(new Forms.MainForm.EventData("inserDataQuarantinesChooseAddress", typeof(AnimalsQuarantine)), e);
        }
    }
}
