using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using GraduationProject.Models;
using GraduationProject.Forms;

namespace GraduationProject.UserControls.References.Addresses
{
    public partial class ReferencesSearchByAnimalQuarantines : UserControl
    {
        [Browsable(true)]
        [Category("Action")]
        [Description("Invoked when show button was clicked.")]
        public event EventHandler ShowButtonClicked;
        public ReferencesSearchByAnimalQuarantines()
        {
            InitializeComponent();
        }

        /// <summary>
        /// Показване на адресите, на които има карантина на съответното селскостопанско животно
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void buttonShow_Click(object sender, EventArgs e)
        {
            List<Address> addresses;
            Quarantine.QuarantineType quarantineType;
            if (radioButtonCows.Checked)
            {
                quarantineType = Quarantine.QuarantineType.Cows;
            }
            else if (radioButtonHorses.Checked)
            {
                quarantineType = Quarantine.QuarantineType.Horses;
            }
            else if (radioButtonDonkeys.Checked)
            {
                quarantineType = Quarantine.QuarantineType.Donkeys;
            }
            else if (radioButtonGoats.Checked)
            {
                quarantineType = Quarantine.QuarantineType.Goats;
            }
            else if (radioButtonSheep.Checked)
            {
                quarantineType = Quarantine.QuarantineType.Sheep;
            }
            else if (radioButtonPigs.Checked)
            {
                quarantineType = Quarantine.QuarantineType.Pigs;
            }
            else if (radioButtonFeathered.Checked)
            {
                quarantineType = Quarantine.QuarantineType.Feathered;
            }
            else if (radioButtonDogs.Checked)
            {
                quarantineType = Quarantine.QuarantineType.Dogs;
            }
            else return;

            addresses = new Address().Get(new ConnectionHelper(), quarantineType);
            ShowButtonClicked(new MainForm.EventData("showAddresses", addresses), e);
        }
    }
}
