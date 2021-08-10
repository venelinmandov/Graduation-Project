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
            DisplayAddress(address);
            SetActivePanel(panelBuildings, buttonBuildings);
        }

        public ShowAddress(AnimalAddressData animalAddress) : this(animalAddress.address)
        {
            Button[] buttons = Controls.OfType<Button>().ToArray();
            foreach (Button button in buttons)
            {
                button.Visible = false;
            }
            SetActivePanel(panelAnimals, buttonAnimals);
            if (animalAddress.animal == "Всички кучета")
            {
                labelDogs.ForeColor = Color.FromArgb(91, 120, 65);
                return;
            }
            if (animalAddress.animal == "Пернати")
            {
                labelFeathered.ForeColor = Color.FromArgb(91, 120, 65);
                return;
            }

            var labels = panelCattle.Controls.OfType<Label>();
            labels = labels.Concat(panelDogs.Controls.OfType<Label>());
            Label label = (from lbl in labels where lbl.Text.Contains(animalAddress.animal) select lbl).First();
            label.ForeColor = Color.FromArgb(91, 120, 65);
        }

        public ShowAddress(TreeAddressData treeAddressData) : this(treeAddressData.address)
        {
            Label label;
            Button[] buttons = Controls.OfType<Button>().ToArray();
            foreach (Button button in buttons)
            {
                button.Visible = false;
            }
            SetActivePanel(panelTrees, buttonTrees);
            switch (treeAddressData.tree)
            {
                case "Орех":
                    label = (from lbl in panelTreesData.Controls.OfType<Label>() where lbl.Text.Contains("Oрехови дървета") select lbl).First();
                    break;
                case "Черница":
                    label = (from lbl in panelTreesData.Controls.OfType<Label>() where lbl.Text.Contains("Черници") select lbl).First();
                    break;
                case "Дърво над 20 г. възраст":
                    label = (from lbl in panelTreesData.Controls.OfType<Label>() where lbl.Text.Contains("Дървета над 20 г. възраст") select lbl).First();
                    break;
                case "Вековно дърво":
                    label = (from lbl in panelTreesData.Controls.OfType<Label>() where lbl.Text.Contains("Вековни дървета") select lbl).First();
                    break;
                default: return;
            }

            label.ForeColor = Color.FromArgb(91, 120, 65);
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
            Font font = new Font("Arial", 12f, FontStyle.Bold);
            if (address.NumResBuildings != 0)
            {
                Label label = new Label();
                label.Font = font;
                label.Text = $"Жилищни пострийки: {address.NumResBuildings}";
                panelBuildingsData.Controls.Add(label);
                label.Dock = DockStyle.Top;
                label.BringToFront();
            }
            if (address.NumAgrBuildings != 0)
            {
                Label label = new Label();
                label.Font = font;
                label.Text = $"Селскостопански пострийки: {address.NumAgrBuildings}";
                panelBuildingsData.Controls.Add(label);
                label.Dock = DockStyle.Top;
                label.BringToFront();
            }
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
            button.BackColor = Color.FromArgb(70, 90, 30);
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
            button.BackColor = Color.FromArgb(70, 90, 30);
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
            Font font = new Font("Arial", 12f, FontStyle.Bold);
            int guardDogs = 0, huntingDogs = 0, domesticDogs = 0;

            List<Dog> dogs = new Dog().Get(new ConnectionHelper(), address);
            foreach (Dog dog in dogs)
            {
                if (dog.Type == Dog.DogType.GuardDog) guardDogs++;
                if (dog.Type == Dog.DogType.HuntingDog) huntingDogs++;
                if (dog.Type == Dog.DogType.DomesticDog) domesticDogs++;
            }

            if (address.NumCows != 0)
            {
                AddLabel("Крави", address.NumCows, panelCattle);
            }
            if (address.NumHorses != 0)
            {
                AddLabel("Коне", address.NumHorses, panelCattle);
            }
            if (address.NumDonkeys != 0)
            {
                AddLabel("Магарета", address.NumDonkeys, panelCattle);
            }
            if (address.NumGoats != 0)
            {
                AddLabel("Кози", address.NumGoats, panelCattle);
            }
            if (address.NumSheep != 0)
            {
                AddLabel("Овце", address.NumSheep, panelCattle);
            }
            if (address.NumPigs != 0)
            {
                AddLabel("Свине", address.NumPigs, panelCattle);
            }
            if (guardDogs != 0)
            {
                AddLabel("Кучета пазач", guardDogs, panelDogs);
            }
            if (huntingDogs != 0)
            {
                AddLabel("Ловджийски кучета", huntingDogs, panelDogs);
            }
            if (domesticDogs != 0)
            {
                AddLabel("Домашни кучета", domesticDogs, panelDogs);
            }
            if (address.NumFeathered != 0)
            {
                labelFeathered.Text = $"Пернати: {address.NumFeathered}";
            }

            void AddLabel(string animal, int number, Panel panel)
            {
                Label label = new Label();
                label.Font = font;
                label.Text = $"- {animal}: {number}";
                panel.Controls.Add(label);
                label.Dock = DockStyle.Top;
                label.BringToFront();
            }
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
            if (address.NumWalnutTrees != 0)
            {
                AddLabel("Oрехови дървета", address.NumWalnutTrees);
            }
            if (address.NumMulberryTrees != 0)
            {
                AddLabel("Черници", address.NumMulberryTrees);
            }
            if (address.NumOldTrees != 0)
            {
                AddLabel("Дървета над 20г. възраст", address.NumOldTrees);
            }
            if (address.NumCenturyOldTrees != 0)
            {
                AddLabel("Вековни дървета", address.NumCenturyOldTrees);
            }

            void AddLabel(string tree, int number)
            {
                Label label = new Label();
                label.Font = new Font("Arial", 12f, FontStyle.Bold);
                label.Text = $"- {tree}: {number}";
                panelTreesData.Controls.Add(label);
                label.Dock = DockStyle.Top;
                label.BringToFront();

            }
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
            activeButton.BackColor = Color.FromArgb(70, 90, 30);
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
            labelSquaringValue.Text = address.Squaring.ToString() + " кв. м.";
            switch (address.Habitallity)
            {
                case Address.Habitability.NotSet: labelHabitabillityValue.Text = ""; break;
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

        private void label1_Click(object sender, EventArgs e)
        {

        }
    }
}
