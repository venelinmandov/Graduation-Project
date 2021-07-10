using GraduationProject.Forms;
using GraduationProject.Models;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Windows.Forms;

namespace GraduationProject.UserControls.References
{
    public partial class ShowAddress : UserControl
    {
        ConnectionHelper connectionHelper = new ConnectionHelper();
        Button activeButton;
        List<Inhabitant> guests;
        List<Inhabitant> residents;
        List<Inhabitant> inhabitants;
        Inhabitant owner;

        public struct AnimalAddressData
        {
            public Address address;
            public string animal;
        }

        public struct TreeAddressData
        {
            public Address address;
            public string tree;
        }

        [Browsable(true)]
        [Category("Action")]
        [Description("Invoked when inhabitant is clicked")]
        public EventHandler InhabitantClicked;

        #region  Коструктури
        public ShowAddress(Address address)
        {
            InitializeComponent();
            activeButton = buttonBuildings;
            SetActivePanel(panelBuildings, buttonBuildings);
            DisplayAddress(address);
        }

        public ShowAddress(AnimalAddressData animalAddress) : this(animalAddress.address)
        {
            Label[] label = new Label[2];
            Button[] buttons = Controls.OfType<Button>().ToArray();
            foreach (Button button in buttons)
            {
                button.Visible = false;
            }
            SetActivePanel(panelAnimals, buttonAnimals);
            switch (animalAddress.animal)
            {
                case "Крави":
                    label[0] = labelCows;
                    label[1] = labelCowsValue;
                    break;
                case "Овце":
                    label[0] = labelSheep;
                    label[1] = labelSheepValue;
                    break;
                case "Кози":
                    label[0] = labelGoats;
                    label[1] = labelGoatsValue;
                    break;
                case "Коне":
                    label[0] = labelHorses;
                    label[1] = labelHorsesValue;
                    break;
                case "Магарета":
                    label[0] = labelDonkeys;
                    label[1] = labelDonkeysValue;
                    break;
                case "Пернати":
                    label[0] = labelFeathered;
                    label[1] = labelFeatheredValue;
                    break;
                case "Свине":
                    label[0] = labelPigs;
                    label[1] = labelPigsValue;
                    break;
                case "Куче пазач":
                    label[0] = labelGuardDogs;
                    label[1] = labelGuardDogsValue;
                    break;
                case "Ловджийско куче":
                    label[0] = labelHuntingDogs;
                    label[1] = labelHuntingDogsValue;
                    break;
                case "Домашен любимец":
                    label[0] = labelDomesticDogs;
                    label[1] = labelDomesticDogsValue;
                    break;
                case "Всички кучета":
                    label[0] = labelDogs;
                    label[1] = labelDogs;
                    break;
                default: return;
            }

            label[0].ForeColor = Color.FromArgb(91, 120, 65);
            label[1].ForeColor = Color.FromArgb(91, 120, 65);
        }

        public ShowAddress(TreeAddressData treeAddressData) : this(treeAddressData.address)
        {
            Label[] label = new Label[2];
            Button[] buttons = Controls.OfType<Button>().ToArray();
            foreach (Button button in buttons)
            {
                button.Visible = false;
            }
            SetActivePanel(panelTrees, buttonTrees);
            switch (treeAddressData.tree)
            {
                case "Орех":
                    label[0] = labelWalnutTrees;
                    label[1] = labelWalnutTreesValue;
                    break;
                case "Черница":
                    label[0] = labelMulBerryTrees;
                    label[1] = labelMulBerryTreesValue;
                    break;
                case "Дърво над 20 г. възраст":
                    label[0] = labelOldTrees;
                    label[1] = labelOldTreesValue;
                    break;
                case "Вековно дърво":
                    label[0] = labelCenturyOldTrees;
                    label[1] = labelCenturyOldTreesValue;
                    break;
                default: return;
            }

            label[0].ForeColor = Color.FromArgb(91, 120, 65);
            label[1].ForeColor = Color.FromArgb(91, 120, 65);
        }
        #endregion

        //Методи
        #region Постройки
        /// <summary>
        /// Показване на панела със постройките
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void buttonBuildings_Click(object sender, EventArgs e)
        {
            SetActivePanel(panelBuildings, (Button)sender);
        }

        /// <summary>
        /// Показване на постройките
        /// </summary>
        /// <param name="address"></param>
        void ShowBuildings(Address address)
        {
            labelResidentalValue.Text = address.NumResBuildings.ToString();
            labelAgriculturalValue.Text = address.NumAgrBuildings.ToString();
        }
        #endregion
        #region Обитатели
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
        /// Покаване на списък с жителите
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void buttonResidents_Click(object sender, EventArgs e)
        {
            Button button = (Button)sender;
            listBoxResidents.BringToFront();
            buttonGuests.BackColor = Color.FromArgb(170, 255, 255, 255);
            buttonGuests.ForeColor = SystemColors.ControlText;
            button.BackColor = Color.FromArgb(50, 80, 40);
            button.ForeColor = SystemColors.Control;
        }

        /// <summary>
        /// Покаване на списък с гостите
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void buttonGuests_Click(object sender, EventArgs e)
        {
            Button button = (Button)sender;
            listBoxGuests.BringToFront();
            buttonResidents.BackColor = Color.FromArgb(170, 255, 255, 255);
            buttonResidents.ForeColor = SystemColors.ControlText;
            button.BackColor = Color.FromArgb(50, 80, 40);
            button.ForeColor = SystemColors.Control;
        }

        /// <summary>
        /// Извличане на обитателите от базата данни 
        /// </summary>
        /// <param name="address"></param>
        void ShowInhabitants(Address address)
        {
            inhabitants = new Inhabitant().Get(connectionHelper, address);
            residents = (from inhabitant in inhabitants where inhabitant.OwnershipState == Inhabitant.OwnershipStateEnum.Resident select inhabitant).ToList();
            guests = (from inhabitant in inhabitants where inhabitant.OwnershipState == Inhabitant.OwnershipStateEnum.Guest select inhabitant).ToList();

            List<Inhabitant> owners;
            if ((owners = (from resident in inhabitants where resident.OwnershipState == Inhabitant.OwnershipStateEnum.Owner select resident).ToList()).Count != 0)
            {
                owner = owners[0];
                labelOwnerFirstnameValue.Text = owner.Firstname;
                labelOwnerMiddlenameValue.Text = owner.Middlename;
                labelOwnerLastnameValue.Text = owner.Lastname;
            }
            else
            {
                labelOwnerFirstname.Text = "Няма";
                labelOwnerFirstnameValue.Visible = false;
                labelOwnerMiddlename.Visible = false;
                labelOwnerMiddlenameValue.Visible = false;
                labelOwnerLastname.Visible = false;
                labelOwnerLastnameValue.Visible = false;
                buttonShowOwner.Visible = false;
            }

            listBoxResidents.AddList(residents.Cast<object>().ToList());
            listBoxGuests.AddList(guests.Cast<object>().ToList());

        }

        /// <summary>
        /// Избран е жител от списъка в жители
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void listBoxResidents_ItemClicked(object sender, EventArgs e)
        {
            int selectedIndex = (int)sender;
            InhabitantClicked(new MainForm.EventData("showInhabitant", residents[selectedIndex]), e);
        }

        /// <summary>
        /// Избран е гост от списъка с гости
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void listBoxGuests_ItemClicked(object sender, EventArgs e)
        {
            int selectedIndex = (int)sender;
            InhabitantClicked(new MainForm.EventData("showInhabitant", guests[selectedIndex]), e);
        }

        /// <summary>
        /// Избран е собственика
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void buttonShowOwner_Click(object sender, EventArgs e)
        {
            InhabitantClicked(new MainForm.EventData("showInhabitant", owner), e);

        }
        #endregion
        #region Селскостопански животни
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
        #endregion
        #region Защитени дървестни видове
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
        #endregion
        #region Забележки
        /// <summary>
        /// Показване на панела със забележките
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void buttonNotes_Click(object sender, EventArgs e)
        {
            SetActivePanel(panelNotes, (Button)sender);

        }
        #endregion
        #region Други методи
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
                case Address.Habitability.Desolate: labelHabitabillityValue.Text = "Пустеещ"; break;
                case Address.Habitability.Inhabited: labelHabitabillityValue.Text = "Обитаван"; break;
                case Address.Habitability.TemporaryInhabited: labelHabitabillityValue.Text = "Временно обитаван"; break;
                case Address.Habitability.OutOfRegulation: labelHabitabillityValue.Text = "Извън регулация"; break;
            }

            ShowBuildings(address);
            ShowAnimals(address);
            ShowTrees(address);
            ShowInhabitants(address);
            richTextBoxNotes.Text = address.Note;
        }
        #endregion
    }
}
