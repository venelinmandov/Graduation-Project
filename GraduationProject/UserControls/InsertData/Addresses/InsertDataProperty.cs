using GraduationProject.Forms;
using GraduationProject.Models;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text.RegularExpressions;
using System.Windows.Forms;

namespace GraduationProject.UserControls.InsertData.Addresses
{
    public partial class InsertDataProperty : UserControl
    {
        ConnectionHelper connectionHelper = new ConnectionHelper();
        Button activeButton;

        Address address;
        List<Dog> dogs;

        [Browsable(true)]
        [Category("Action")]
        [Description("Invoked when inhabitant is clicked")]
        public EventHandler InhabitantClicked;

        Dictionary<string, Address.AddressHabitability> habitabilityDict = new Dictionary<string, Address.AddressHabitability>()
        {
            {"Обитаван", Address.AddressHabitability.Inhabited },
            {"Временно обитаван", Address.AddressHabitability.TemporaryInhabited },
            {"Необитаван", Address.AddressHabitability.Desolate },
            {"Извън регулация", Address.AddressHabitability.OutOfRegulation },
        };

        Dictionary<string, Dog.DogType> dogsDict = new Dictionary<string, Dog.DogType>()
        {
            {"Кучета пазач", Dog.DogType.GuardDog },
            {"Ловджийски кучета", Dog.DogType.HuntingDog },
            {"Домашни кучета", Dog.DogType.DomesticDog }
        };


        //Конструктури
        public InsertDataProperty(Address address)
        {
            InitializeComponent();
            this.address = address;
            labelAddress.Text = address.ToString();
            comboBoxHabitability.Items.AddRange(habitabilityDict.Keys.ToArray());
            activeButton = buttonBuildings;
            SetActivePanel(panelBuildings, buttonBuildings);
            if (address.Id != 0)
            {
                dogs = new Dog().Get(connectionHelper, address);
            }
            else
            {
                dogs = new List<Dog>();
                
            }

            ShowDogs();
        }

        

        

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
        /// Показване на панелса със забележките
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void buttonNotes_Click(object sender, EventArgs e)
        {
            SetActivePanel(panelNotes, (Button)sender);

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

        void ShowDogs()
        {
            dataGridViewDogs.RowCount = 0;
            for (int i = 0; i < dogs.Count; i++)
            {
                dataGridViewDogs.RowCount++;
                if (dogs[i].SealNumber == null)
                {
                    dataGridViewDogs.Rows[i].Cells[0].Value = "Няма номер";
                }
                else
                {
                    dataGridViewDogs.Rows[i].Cells[0].Value = dogs[i].SealNumber;
                }
                DataGridViewComboBoxCell dataGridViewComboBox = dataGridViewDogs.Rows[i].Cells[1] as DataGridViewComboBoxCell;
                foreach (var item in comboBoxDogTypeEdit.Items)
                {
                    dataGridViewComboBox.Items.Add(item);
                }
                    dataGridViewComboBox.Value = dogsDict.FirstOrDefault(entry => EqualityComparer<Dog.DogType>.Default.Equals(entry.Value, dogs[i].Type)).Key;
            }
        }

        private void comboBoxHabitability_SelectedIndexChanged(object sender, EventArgs e)
        {
            address.Habitallity = habitabilityDict[comboBoxHabitability.Text];
        }

        private void numericUpDownSquaring_ValueChanged(object sender, EventArgs e)
        {
            address.Squaring = (double)numericUpDownSquaring.Value;
        }

        private void comboBoxBuildings_SelectedIndexChanged(object sender, EventArgs e)
        {
            int value = comboBoxBuildings.Text == "Жилищни постройки" ? address.NumResBuildings : address.NumAgrBuildings;
            numericUpDownBuildings.Value = value;
        }

        private void numericUpDownBuildings_ValueChanged(object sender, EventArgs e)
        {
            if (comboBoxBuildings.Text == "Жилищни постройки")
            {
                address.NumResBuildings = (int)numericUpDownBuildings.Value;
            }
            else
            {
                address.NumAgrBuildings = (int)numericUpDownBuildings.Value;

            }
        }

        private void comboBoxDomesticAnimals_SelectedIndexChanged(object sender, EventArgs e)
        {
            switch (comboBoxDomesticAnimals.Text)
            {
                case "Крави":
                     numericUpDownDomesticAnimals.Value = address.NumCows;
                    break;
                case "Овце":
                    numericUpDownDomesticAnimals.Value = address.NumSheep;
                    break;
                case "Кози":
                    numericUpDownDomesticAnimals.Value = address.NumGoats;
                    break;
                case "Коне":
                    numericUpDownDomesticAnimals.Value = address.NumHorses;
                    break;
                case "Магарета":
                    numericUpDownDomesticAnimals.Value = address.NumDonkeys;
                    break;
                case "Свине":
                    numericUpDownDomesticAnimals.Value = address.NumPigs;
                    break;
            }
        }

        private void numericUpDownDomesticAnimals_ValueChanged(object sender, EventArgs e)
        {
            switch (comboBoxDomesticAnimals.Text)
            {
                case "Крави":
                    address.NumCows = (int)numericUpDownDomesticAnimals.Value;
                    break;
                case "Овце":
                    address.NumSheep = (int)numericUpDownDomesticAnimals.Value;
                    break;
                case "Кози":
                    address.NumGoats = (int)numericUpDownDomesticAnimals.Value;
                    break;
                case "Коне":
                    address.NumHorses = (int)numericUpDownDomesticAnimals.Value;
                    break;
                case "Магарета":
                    address.NumDonkeys = (int)numericUpDownDomesticAnimals.Value;
                    break;
                case "Свине":
                    address.NumPigs = (int)numericUpDownDomesticAnimals.Value;
                    break;
            }
        }

        private void numericUpDownFeathererd_ValueChanged(object sender, EventArgs e)
        {
            address.NumFeathered = (int)numericUpDownFeathererd.Value;
        }

        private void comboBoxDogs_SelectedIndexChanged(object sender, EventArgs e)
        {
            switch (comboBoxDogsType.Text)
            {
                case "Кучета пазач":
                    labelDogsNumber.Text = (from dog in dogs where dog.Type == Dog.DogType.GuardDog select dog).ToArray().Length.ToString();
                    break;
                case "Ловджийски кучета":
                    labelDogsNumber.Text = (from dog in dogs where dog.Type == Dog.DogType.HuntingDog select dog).ToArray().Length.ToString();
                    break;
                case "Домашни кучета":
                    labelDogsNumber.Text = (from dog in dogs where dog.Type == Dog.DogType.DomesticDog select dog).ToArray().Length.ToString();
                    break;
            }
        }

        private void buttonEditDogs_Click(object sender, EventArgs e)
        {
            SetActivePanel(panelDogs, buttonAnimals);
        }

        private void buttonAddDog_Click(object sender, EventArgs e)
        {
            Dog dog = new Dog();
            Regex rx = new Regex(@"^d{15}$");

            if (checkBoxDogNoNumber.Checked)
            {
                dog.SealNumber = null;
            }
            else if (textBoxDogNumber.Text.Trim() == "")
            {
                labelDogsError.Text = "Моля въведете номер или изберете опцията \"няма номер\"!";
                labelDogsError.Visible = true;
                return;
            }
            else if (!rx.IsMatch(labelDogsError.Text))
            {
                labelDogsError.Text = "Невалиден номер!";
                labelDogsError.Visible = true;
                return;
            }
            else
            {
                labelDogsError.Visible = false;
                dog.SealNumber = textBoxDogNumber.Text;

            }
            dog.Type = dogsDict[comboBoxDogTypeEdit.Text];
            dogs.Add(dog);
            if (address.Id != 0)
            {
                dog.Insert(connectionHelper);
            }
            ShowDogs();
        }
    }
}
