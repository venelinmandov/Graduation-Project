using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using GraduationProject.Forms;
using GraduationProject.Models;

namespace GraduationProject.UserControls.References.Addresses
{
    public partial class ReferencesSearchByTrees : UserControl
    {
        [Browsable(true)]
        [Category("Action")]
        [Description("Invoked when show button was clicked.")]
        public event EventHandler ShowButtonClicked;

        public ReferencesSearchByTrees()
        {
            InitializeComponent();
        }

        private void buttonShow_Click(object sender, EventArgs e)
        {
            string columnName;

            if (radioButtonWalnut.Checked)
            {
                columnName = "numWalnutTrees";
            }
            else if (radioButtonMulberry.Checked)
            {
                columnName = "numMulberryTrees";
            }
            else if (radioButtonOld.Checked)
            {
                columnName = "numOldTrees";
            }
            else if (radioButtonCentury.Checked)
            {
                columnName = "numCenturyOldTrees";
            }
            else
                return;

            List<Address> addresses = new Address().Get(new ConnectionHelper(), columnName);
            ShowButtonClicked(new MainForm.EventData("showAddresses", addresses), e);
        }
    }
}
