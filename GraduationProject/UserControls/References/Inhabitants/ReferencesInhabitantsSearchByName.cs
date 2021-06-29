using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using GraduationProject.Models;
using GraduationProject.Forms;

namespace GraduationProject.UserControls.References.Inhabitants
{
    public partial class ReferencesInhabitantsSearchByName : UserControl
    {
        [Browsable(true)] [Category("Action")]
        [Description("Invoked when show button was clicked.")]
        public event EventHandler ShowButtonClicked;
        public ReferencesInhabitantsSearchByName()
        {
            InitializeComponent();
        }

        /// <summary>
        /// Показване на жителите/гостите със въведеното име/имена
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void buttonShow_Click(object sender, EventArgs e)
        {
            if (textBoxFirstname.Text.Trim() == "" && textBoxMiddlename.Text.Trim() == "" && textBoxLastname.Text.Trim() == "")
                return;
            ConnectionHelper connectionHelper = new ConnectionHelper();
            List<Inhabitant> inhabitants = new Inhabitant().Get(connectionHelper, textBoxFirstname.Text, textBoxMiddlename.Text, textBoxLastname.Text);


            ShowButtonClicked(new MainForm.EventData("listInhabitants", inhabitants),e);
        }
    }
}
