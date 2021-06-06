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
            AnimalsQuarantine.AnimalEnum quarantineType;
            if (radioButtonCows.Checked)
            {
                quarantineType = AnimalsQuarantine.AnimalEnum.Cows;
            }
            else if (radioButtonHorses.Checked)
            {
                quarantineType = AnimalsQuarantine.AnimalEnum.Horses;
            }
            else if (radioButtonDonkeys.Checked)
            {
                quarantineType = AnimalsQuarantine.AnimalEnum.Donkeys;
            }
            else if (radioButtonGoats.Checked)
            {
                quarantineType = AnimalsQuarantine.AnimalEnum.Goats;
            }
            else if (radioButtonSheep.Checked)
            {
                quarantineType = AnimalsQuarantine.AnimalEnum.Sheep;
            }
            else if (radioButtonPigs.Checked)
            {
                quarantineType = AnimalsQuarantine.AnimalEnum.Pigs;
            }
            else if (radioButtonFeathered.Checked)
            {
                quarantineType = AnimalsQuarantine.AnimalEnum.Feathered;
            }
            else if (radioButtonDogs.Checked)
            {
                quarantineType = AnimalsQuarantine.AnimalEnum.Dogs;
            }
            else return;

            addresses = new Address().Get(new ConnectionHelper(), quarantineType);
            ShowButtonClicked(new MainForm.EventData("showAddresses", addresses), e);
        }
    }
}
