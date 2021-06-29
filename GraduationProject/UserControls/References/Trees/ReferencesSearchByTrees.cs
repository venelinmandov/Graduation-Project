using GraduationProject.Forms;
using GraduationProject.Models;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Windows.Forms;

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

        /// <summary>
        /// Показване на адресите, на които се отглежда дадения дървесен вид със специален статут
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void buttonShow_Click(object sender, EventArgs e)
        {
            string columnName;
            string tree;

            if (radioButtonWalnut.Checked)
            {
                columnName = "numWalnutTrees";
                tree = radioButtonWalnut.Text;
            }
            else if (radioButtonMulberry.Checked)
            {
                columnName = "numMulberryTrees";
                tree = radioButtonMulberry.Text;

            }
            else if (radioButtonOld.Checked)
            {
                columnName = "numOldTrees";
                tree = radioButtonOld.Text;

            }
            else if (radioButtonCentury.Checked)
            {
                columnName = "numCenturyOldTrees";
                tree = radioButtonCentury.Text;

            }
            else
                return;

            ListTreesAddresses.TreeAddressesData addressesTreeData = new ListTreesAddresses.TreeAddressesData()
            {
                addresses = new Address().Get(new ConnectionHelper(), columnName),
                tree = tree
            };
            ShowButtonClicked(new MainForm.EventData("listTreesAddresses", addressesTreeData), e);
        }
    }
}
