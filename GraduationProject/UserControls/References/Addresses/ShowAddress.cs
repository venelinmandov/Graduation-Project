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
        Button activeButton;

        Dictionary<AnimalsQuarantine.AnimalEnum, string> animalsDict = new Dictionary<AnimalsQuarantine.AnimalEnum, string>()
        {
            {AnimalsQuarantine.AnimalEnum.Cows, "крави" },
            {AnimalsQuarantine.AnimalEnum.Sheep, "овце" },
            {AnimalsQuarantine.AnimalEnum.Goats, "кози" },
            {AnimalsQuarantine.AnimalEnum.Horses, "коне" },
            {AnimalsQuarantine.AnimalEnum.Donkeys, "магарета" },
            {AnimalsQuarantine.AnimalEnum.Feathered, "пернати" },
            {AnimalsQuarantine.AnimalEnum.Pigs, "свине" },
            {AnimalsQuarantine.AnimalEnum.Dogs, "кучета" },
        };

        public ShowAddress(Address address)
        {
            InitializeComponent();
            activeButton = buttonBuildings;
            SetActivePanel(panelBuildings, buttonBuildings);
            DisplayAddress(address);
        }

        /// <summary>
        /// Показване на панела със постройките
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void buttonBuildings_Click(object sender, EventArgs e)
        {
            SetActivePanel(panelBuildings,(Button)sender);
        }

        /// <summary>
        /// Показване на панела със селскостопанските животни
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void buttonAnimals_Click(object sender, EventArgs e)
        {
            SetActivePanel(panelAnimals, (Button)sender);

        }

        /// <summary>
        /// Показване на панела със кучетата
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void buttonDogs_Click(object sender, EventArgs e)
        {
            SetActivePanel(panelDogs, (Button)sender);

        }

        /// <summary>
        /// Показване на панела със защитените дървестни видове
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void buttonTrees_Click(object sender, EventArgs e)
        {
            SetActivePanel(panelTrees, (Button)sender);

        }

        /// <summary>
        /// Показване на панела със карантините
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void buttonQuarantines_Click(object sender, EventArgs e)
        {
            SetActivePanel(panelQuarantines, (Button)sender);

        }

        /// <summary>
        /// Показва се избрания панел. И съответния бутон се визуализира като активен.
        /// </summary>
        /// <param name="panel"></param>
        /// <param name="button"></param>
        void SetActivePanel(Panel panel, Button button)
        {
            panel.BringToFront();
            activeButton.BackColor = Color.FromArgb(170, 255, 255, 255);
            activeButton.ForeColor = SystemColors.ControlText;
            activeButton = button;
            activeButton.BackColor = Color.FromArgb(50, 80, 40);
            activeButton.ForeColor = SystemColors.Control;
            panel.BringToFront();
        }

        /// <summary>
        /// Показване на даните на адреса
        /// </summary>
        /// <param name="address"></param>
        void DisplayAddress(Address address)
        {
            List<AnimalsQuarantine> animalQuarantines = new AnimalsQuarantine().Get(new ConnectionHelper(),address);
            List<InhabitantsQuarantine> inhabitantsQuarantines = new InhabitantsQuarantine().Get(new ConnectionHelper(),address);
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

            if (animalQuarantines.Count == 0 && inhabitantsQuarantines.Count == 0)
            {
                labelQuarantines.Text += "няма карантини.";
            }
            else
            {
                labelQuarantines.Text += "има карантинирани:\n";
                foreach (InhabitantsQuarantine inhabitantsQuarantine in inhabitantsQuarantines)
                {
                labelQuarantines.Text += $"\t - обитатели от {inhabitantsQuarantine.StartDate} до {inhabitantsQuarantine.EndDate} с диагноза {inhabitantsQuarantine.Disease}\n";
                }
                foreach (AnimalsQuarantine animalsQuarantine  in animalQuarantines)
                {
                    labelQuarantines.Text += $"\t - {animalsDict[animalsQuarantine.Animal]} от {animalsQuarantine.StartDate} до {animalsQuarantine.EndDate} с диагноза {animalsQuarantine.Disease}\n";
                }

            }



        }   
    }
}
