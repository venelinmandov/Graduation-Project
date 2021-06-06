using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using GraduationProject.Models;

namespace GraduationProject.UserControls.References
{
    public partial class ShowAddress : UserControl
    {
        Dictionary<Quarantine.QuarantineType, string> quarntineDict = new Dictionary<Quarantine.QuarantineType, string>()
        {
            {Quarantine.QuarantineType.Inhabitants, "хора" },
            {Quarantine.QuarantineType.Cows, "крави" },
            {Quarantine.QuarantineType.Sheep, "овце" },
            {Quarantine.QuarantineType.Goats, "кози" },
            {Quarantine.QuarantineType.Horses, "коне" },
            {Quarantine.QuarantineType.Donkeys, "магарета" },
            {Quarantine.QuarantineType.Feathered, "пернати" },
            {Quarantine.QuarantineType.Pigs, "свине" },
            {Quarantine.QuarantineType.Dogs, "кучета" },
        };

        public ShowAddress(Address address)
        {
            InitializeComponent();
            panelBuildings.BringToFront();
            DisplayAddress(address);
            
        }

        /// <summary>
        /// Показване на панела със постройките
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void buttonBuildings_Click(object sender, EventArgs e)
        {
            panelBuildings.BringToFront();
        }

        /// <summary>
        /// Показване на панела със селскостопанските животни
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void buttonAnimals_Click(object sender, EventArgs e)
        {
            panelAnimals.BringToFront();
        }

        /// <summary>
        /// Показване на панела със кучетата
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void buttonDogs_Click(object sender, EventArgs e)
        {
            panelDogs.BringToFront();
        }

        /// <summary>
        /// Показване на панела със защитените дървестни видове
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void buttonTrees_Click(object sender, EventArgs e)
        {
            panelTrees.BringToFront();
        }

        /// <summary>
        /// Показване на панела със карантините
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void buttonQuarantines_Click(object sender, EventArgs e)
        {
            panelQuarantines.BringToFront();
        }

        /// <summary>
        /// Показване на даните на адреса
        /// </summary>
        /// <param name="address"></param>
        void DisplayAddress(Address address)
        {
            List<Quarantine> quarantines = new Quarantine().Get(new ConnectionHelper(),address);
            int guardDogs = 0, huntingDogs = 0, domesticDogs = 0;
            labelAddress.Text = address.ToString();
            labelSquaringValue.Text = address.Squaring.ToString();
            switch (address.Habitallity)
            {
                case Address.AddressHabitability.Desolate: labelHabitabillityValue.Text = "Пустеещ";break;
                case Address.AddressHabitability.Inhabited: labelHabitabillityValue.Text = "Обитаван";break;
                case Address.AddressHabitability.TemporaryInhabited: labelHabitabillityValue.Text = "Временно обитаван";break;
                case Address.AddressHabitability.OutOfRegulation: labelHabitabillityValue.Text = "Извън регулация";break;
            }

            labelResidentalValue.Text = address.NumResBuildings.ToString();
            labelAgriculturalValue.Text = address.NumAgrBuildings.ToString();

            labelCowsValue.Text = address.NumCows.ToString();
            labelHorsesValue.Text = address.NumHorses.ToString();
            labelDonkeysValue.Text = address.NumDonkeys.ToString();
            labelGoatsValue.Text = address.NumGoats.ToString();
            labelSheepValue.Text = address.NumSheep.ToString();
            labelPigsValue.Text = address.NumPigs.ToString();
            labelFeatheredValue.Text = address.NumFeathered.ToString();
            labelWalnutTreesValue.Text = address.NumWalnutTrees.ToString();
            labelMulBerryTreesValue.Text = address.NumMulberryTrees.ToString();
            labelOldTreesValue.Text = address.NumOldTrees.ToString();
            labelCenturyOldTreesValue.Text = address.NumCenturyOldTrees.ToString();
            List<Dog> dogs = new Dog().Get(new ConnectionHelper(), address);
            foreach (Dog dog in dogs)
            {
                if (dog.Type == Dog.DogType.GuardDog) guardDogs++;
                if (dog.Type == Dog.DogType.HuntingDog) huntingDogs++;
                if (dog.Type == Dog.DogType.DomesticDog) domesticDogs++;
            }
            labelGuardDogsValue.Text = guardDogs.ToString();
            labelHuntingDogsValue.Text = huntingDogs.ToString();
            labelDomesticDogsValue.Text = domesticDogs.ToString();

            if (quarantines.Count == 0)
            {
                labelQuarantines.Text += "няма карантини.";
            }
            else if (quarantines.Count == 1)
            {
                labelQuarantines.Text += "има карантина на "+ quarntineDict[quarantines[0].Type] + ".";

            }
            else
            {
                List<string> animalNames = new List<string>();
                labelQuarantines.Text += "има карантини на ";
                for (int i = 0; i < quarantines.Count; i++)
                {
                    if (quarantines[i].Type == Quarantine.QuarantineType.Inhabitants)
                        labelQuarantines.Text += "хора";
                    else
                    {
                        animalNames.Add(quarntineDict[quarantines[i].Type]);
                    }
                }
                if (animalNames.Count != 0)
                {
                    labelQuarantines.Text += $" и \nселскостопански животни: {string.Join(", ",animalNames)}";
                }
                labelQuarantines.Text += ".";
            }
            


        }   
    }
}
