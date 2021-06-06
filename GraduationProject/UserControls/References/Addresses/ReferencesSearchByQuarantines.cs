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
    public partial class ReferencesSearchByQuarantines : UserControl
    {
        [Browsable(true)]
        [Category("Action")]
        [Description("Invoked when show button was clicked.")]
        public event EventHandler ShowButtonClicked;

        public ReferencesSearchByQuarantines()
        {
            InitializeComponent();
        }

        /// <summary>
        /// Показване на адрсите със избрания тип карантина
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void buttonShow_Click(object sender, EventArgs e)
        {
            if (radioButtonInhabitants.Checked)
            {
                List<Address> addresses = new Address().Get(new ConnectionHelper(), AnimalsQuarantine.AnimalEnum.Cows);
                ShowButtonClicked(new MainForm.EventData("showAddresses", addresses), e);

            }
            else if (radioButtonAnimals.Checked)
            {
                ShowButtonClicked(new MainForm.EventData("animalQuarantine"), e);
            }
            else return;
        }
    }
}
