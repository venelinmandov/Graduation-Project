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
        public ShowAddress(Address address)
        {
            InitializeComponent();
            panelBuildings.BringToFront();
            DisplayAddress(address);
            
        }

        private void buttonBuildings_Click(object sender, EventArgs e)
        {
            panelBuildings.BringToFront();
        }

        private void buttonAnimals_Click(object sender, EventArgs e)
        {
            panelAnimals.BringToFront();
        }

        private void buttonDogs_Click(object sender, EventArgs e)
        {
            panelDogs.BringToFront();
        }

        private void buttonTrees_Click(object sender, EventArgs e)
        {
            panelTrees.BringToFront();
        }

        void DisplayAddress(Address address)
        {
            int guardDogs = 0, huntingDogs = 0, domesticDogs = 0;
            labelAddress.Text = address.ToString();
            labelSquaringValue.Text = address.Squaring.ToString();
            switch (address.Habitallity)
            {
                case Address.AddressHabitabillity.Desolate: labelHabitabillityValue.Text = "Пустеещ";break;
                case Address.AddressHabitabillity.Inhabited: labelHabitabillityValue.Text = "Обитаван";break;
                case Address.AddressHabitabillity.TemporaryInhabited: labelHabitabillityValue.Text = "Временно обитаван";break;
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

        private void panelDogs_Paint(object sender, PaintEventArgs e)
        {

        }
    }
}
