using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using GraduationProject.Models;
using System.Linq;

namespace GraduationProject.UserControls.References
{
    public partial class ShowAddress : UserControl
    {
        ConnectionHelper connectionHelper = new ConnectionHelper();
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
        /// Показване на панела със обитателите
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void buttonInhabitants_Click(object sender, EventArgs e)
        {
            SetActivePanel(panelInhabitants, (Button)sender);
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

            
            labelAddress.Text = address.ToString();
            labelSquaringValue.Text = address.Squaring.ToString();
            switch (address.Habitallity)
            {
                case Address.AddressHabitability.Desolate: labelHabitabillityValue.Text = "Пустеещ";break;
                case Address.AddressHabitability.Inhabited: labelHabitabillityValue.Text = "Обитаван";break;
                case Address.AddressHabitability.TemporaryInhabited: labelHabitabillityValue.Text = "Временно обитаван";break;
                case Address.AddressHabitability.OutOfRegulation: labelHabitabillityValue.Text = "Извън регулация";break;
            }

            ShowBuildings(address);
            ShowAnimals(address);
            ShowTrees(address);
            ShowQuarantines(address);
            ShowInhabitants(address);
            
        }

        /// <summary>
        /// Показване на сградите
        /// </summary>
        /// <param name="address"></param>
        void ShowBuildings(Address address)
        {
            labelResidentalValue.Text = address.NumResBuildings.ToString();
            labelAgriculturalValue.Text = address.NumAgrBuildings.ToString();
        }

        /// <summary>
        /// Показване на селскостопанските животни
        /// </summary>
        /// <param name="address"></param>
        void ShowAnimals(Address address)
        {
            int guardDogs = 0, huntingDogs = 0, domesticDogs = 0;

            labelCowsValue.Text = address.NumCows.ToString();
            labelHorsesValue.Text = address.NumHorses.ToString();
            labelDonkeysValue.Text = address.NumDonkeys.ToString();
            labelGoatsValue.Text = address.NumGoats.ToString();
            labelSheepValue.Text = address.NumSheep.ToString();
            labelPigsValue.Text = address.NumPigs.ToString();
            labelFeatheredValue.Text = address.NumFeathered.ToString();
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
        }

        /// <summary>
        /// Показване на дърветата със специален статут
        /// </summary>
        /// <param name="address"></param>
        void ShowTrees(Address address)
        {
            labelWalnutTreesValue.Text = address.NumWalnutTrees.ToString();
            labelMulBerryTreesValue.Text = address.NumMulberryTrees.ToString();
            labelOldTreesValue.Text = address.NumOldTrees.ToString();
            labelCenturyOldTreesValue.Text = address.NumCenturyOldTrees.ToString();
        }

        /// <summary>
        /// Показване на карантините
        /// </summary>
        /// <param name="address"></param>
        void ShowQuarantines(Address address)
        {
            List<AnimalsQuarantine> animalQuarantines = new AnimalsQuarantine().Get(connectionHelper, address);
            List<InhabitantsQuarantine> inhabitantsQuarantines = new InhabitantsQuarantine().Get(connectionHelper, address);
            List<Disease> inhabitantDiseases = new Disease().Get(connectionHelper, Disease.DiseaseType.Inhabitant);
            List<Disease> animalDiseases = new Disease().Get(connectionHelper, Disease.DiseaseType.Animal);

            if (animalQuarantines.Count == 0 && inhabitantsQuarantines.Count == 0)
            {
                labelQuarantines.Visible = true;
                dataGridViewQuarantines.Visible = false;
            }
            else
            {
                labelQuarantines.Visible = false;
                dataGridViewQuarantines.Visible = true;
                DateTime startDate, endDate;
                string diagnose;
                string dateformat = "d MMMM yyyy";
                int row = 0;
                labelQuarantines.Text += "има карантинирани:\n";
                foreach (InhabitantsQuarantine inhabitantsQuarantine in inhabitantsQuarantines)
                {
                    dataGridViewQuarantines.RowCount++;
                    startDate = DateTime.Parse(inhabitantsQuarantine.StartDate);
                    endDate = DateTime.Parse(inhabitantsQuarantine.EndDate);
                    diagnose = (from d in inhabitantDiseases where d.Id == inhabitantsQuarantine.DiseaseId select d).First().Name;
                    dataGridViewQuarantines.Rows[row].Cells[0].Value = "обитатели";
                    dataGridViewQuarantines.Rows[row].Cells[1].Value = diagnose;
                    dataGridViewQuarantines.Rows[row].Cells[2].Value = startDate.ToString(dateformat);
                    dataGridViewQuarantines.Rows[row].Cells[3].Value = endDate.ToString(dateformat);
                    row++;
                }
                foreach (AnimalsQuarantine animalsQuarantine in animalQuarantines)
                {
                    dataGridViewQuarantines.RowCount++;
                    startDate = DateTime.Parse(animalsQuarantine.StartDate);
                    endDate = DateTime.Parse(animalsQuarantine.EndDate);
                    diagnose = (from d in animalDiseases where d.Id == animalsQuarantine.Disease select d).First().Name;
                    dataGridViewQuarantines.Rows[row].Cells[0].Value = animalsDict[animalsQuarantine.Animal];
                    dataGridViewQuarantines.Rows[row].Cells[1].Value = diagnose;
                    dataGridViewQuarantines.Rows[row].Cells[2].Value = startDate.ToString(dateformat);
                    dataGridViewQuarantines.Rows[row].Cells[3].Value = endDate.ToString(dateformat);
                    row++;
                }

            }
        }

        void ShowInhabitants(Address address)
        {
            List<Person> guests = new Person().Get(connectionHelper, address);
            List<Resident> residents = new Resident().Get(connectionHelper, address);
            List<Resident> owners;
            if ((owners = (from resident in residents where resident.RelToOwner == "Собственик" select resident).ToList()).Count != 0)
            {
                labelOwnerValue.Text = $"{owners[0].Firstname} \n {owners[0].Middlename} \n {owners[0].Lastname}";
            }
            else 
            {
                labelOwnerValue.Text = "Няма";
            }

        }

        
    }
}
