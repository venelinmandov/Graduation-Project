using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace GraduationProject.UserControls
{
    public partial class MenuUserControl : UserControl
    {
        [Browsable(true)]
        [Category("Action")]
        [Description("Invoked when button is clicked")]
        public event EventHandler ButtonClicked;
        public MenuUserControl()
        {
            InitializeComponent();
        }

        private void buttonReferences_Click(object sender, EventArgs e)
        {
            ButtonClicked(new Forms.MainForm.EventData("references"), e);
        }

        private void buttonInsertData_Click(object sender, EventArgs e)
        {
            ButtonClicked(new Forms.MainForm.EventData("insertData"), e);
        }
    }
}
