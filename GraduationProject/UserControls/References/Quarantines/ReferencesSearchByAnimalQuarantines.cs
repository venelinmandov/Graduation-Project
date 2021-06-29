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
            AnimalsQuarantine.AnimalEnum animal;
            if (radioButtonCows.Checked)
            {
                animal = AnimalsQuarantine.AnimalEnum.Cows;
            }
            else if (radioButtonHorses.Checked)
            {
                animal = AnimalsQuarantine.AnimalEnum.Horses;
            }
            else if (radioButtonDonkeys.Checked)
            {
                animal = AnimalsQuarantine.AnimalEnum.Donkeys;
            }
            else if (radioButtonGoats.Checked)
            {
                animal = AnimalsQuarantine.AnimalEnum.Goats;
            }
            else if (radioButtonSheep.Checked)
            {
                animal = AnimalsQuarantine.AnimalEnum.Sheep;
            }
            else if (radioButtonPigs.Checked)
            {
                animal = AnimalsQuarantine.AnimalEnum.Pigs;
            }
            else if (radioButtonFeathered.Checked)
            {
                animal = AnimalsQuarantine.AnimalEnum.Feathered;
            }
            else if (radioButtonDogs.Checked)
            {
                animal = AnimalsQuarantine.AnimalEnum.Dogs;
            }
            else return;

            addresses = new Address().Get(new ConnectionHelper(), animal);
            ListAnimalsQuarantines.QuarantinesData quarantinesData = new ListAnimalsQuarantines.QuarantinesData()
            {
                addresses = addresses,
                animal = animal
            };
            ShowButtonClicked(new MainForm.EventData("listAnimalsQuarantines", quarantinesData), e);
        }
    }
}
