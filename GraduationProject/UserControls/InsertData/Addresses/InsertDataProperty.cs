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
        bool dontTriggerChangeEvent = true;

        InsertDataAddress.AddressData addressData;

        Dictionary<string, Address.Habitability> habitabilityDict = new Dictionary<string, Address.Habitability>()
        {
            {"Обитаван", Address.Habitability.Inhabited },
            {"Временно обитаван", Address.Habitability.TemporaryInhabited },
            {"Необитаван", Address.Habitability.Desolate },
            {"Извън регулация", Address.Habitability.OutOfRegulation },
        };

        Dictionary<string, Dog.DogType> dogDict = new Dictionary<string, Dog.DogType>()
        {
            {"Куче пазач", Dog.DogType.GuardDog },
            {"Ловджийско куче", Dog.DogType.HuntingDog },
            {"Домашно куче", Dog.DogType.DomesticDog }
        };


        //Конструктор
        public InsertDataProperty(InsertDataAddress.AddressData addressData)
        {
            InitializeComponent();
            this.addressData = addressData;
            labelAddress.Text = addressData.address.ToString();
            comboBoxHabitability.Items.AddRange(habitabilityDict.Keys.ToArray());
            activeButton = buttonBuildings;
            SetActivePanel(panelBuildings, buttonBuildings);
            if (addressData.address.Id != 0)
            {
                addressData.dogs = new Dog().Get(connectionHelper, addressData.address);
            }
            else
            {
                addressData.dogs = new List<Dog>();

            }

            ShowDogs();
            numericUpDownSquaring.Value = (decimal)addressData.address.Squaring;
            richTextBoxNotes.Text = addressData.address.Note;

            foreach (Panel panel in Controls.OfType<Panel>())
            {
                foreach (ComboBox comboBox in panel.Controls.OfType<ComboBox>())
                {
                    if (comboBox.Items.Count != 0)
                        comboBox.SelectedIndex = 0;
                    comboBox.DrawItem += comboBox_DrawItem;
                }
            }
            comboBoxHabitability.DrawItem += comboBox_DrawItem;
            comboBoxHabitability.Text = habitabilityDict.FirstOrDefault(entry => EqualityComparer<Address.Habitability>.Default.Equals(entry.Value, addressData.address.Habitallity)).Key;
            numericUpDownFeathererd.Value = addressData.address.NumFeathered;
            dontTriggerChangeEvent = false;
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
            for (int i = 0; i < addressData.dogs.Count; i++)
            {
                dataGridViewDogs.RowCount++;
                if (addressData.dogs[i].SealNumber == null)
                {
                    dataGridViewDogs.Rows[i].Cells[0].Value = "Няма номер";
                }
                else
                {
                    dataGridViewDogs.Rows[i].Cells[0].Value = addressData.dogs[i].SealNumber;
                }
                DataGridViewComboBoxCell dataGridViewComboBox = dataGridViewDogs.Rows[i].Cells[1] as DataGridViewComboBoxCell;
                foreach (var item in comboBoxDogTypeEdit.Items)
                {
                    dataGridViewComboBox.Items.Add(item);
                }
                dataGridViewComboBox.Value = dogDict.FirstOrDefault(entry => EqualityComparer<Dog.DogType>.Default.Equals(entry.Value, addressData.dogs[i].Type)).Key;

            }
        }

        private void comboBoxHabitability_SelectedIndexChanged(object sender, EventArgs e)
        {
            addressData.address.Habitallity = habitabilityDict[comboBoxHabitability.Text];
        }

        private void numericUpDownSquaring_ValueChanged(object sender, EventArgs e)
        {
            addressData.address.Squaring = (double)numericUpDownSquaring.Value;
        }

        private void comboBoxBuildings_SelectedIndexChanged(object sender, EventArgs e)
        {
            int value = comboBoxBuildings.Text == "Жилищни постройки" ? addressData.address.NumResBuildings : addressData.address.NumAgrBuildings;
            numericUpDownBuildings.Value = value;
        }

        private void numericUpDownBuildings_ValueChanged(object sender, EventArgs e)
        {
            if (comboBoxBuildings.Text == "Жилищни постройки")
            {
                addressData.address.NumResBuildings = (int)numericUpDownBuildings.Value;
            }
            else
            {
                addressData.address.NumAgrBuildings = (int)numericUpDownBuildings.Value;

            }
        }

        private void comboBoxDomesticAnimals_SelectedIndexChanged(object sender, EventArgs e)
        {
            switch (comboBoxDomesticAnimals.Text)
            {
                case "Крави":
                    numericUpDownDomesticAnimals.Value = addressData.address.NumCows;
                    break;
                case "Овце":
                    numericUpDownDomesticAnimals.Value = addressData.address.NumSheep;
                    break;
                case "Кози":
                    numericUpDownDomesticAnimals.Value = addressData.address.NumGoats;
                    break;
                case "Коне":
                    numericUpDownDomesticAnimals.Value = addressData.address.NumHorses;
                    break;
                case "Магарета":
                    numericUpDownDomesticAnimals.Value = addressData.address.NumDonkeys;
                    break;
                case "Свине":
                    numericUpDownDomesticAnimals.Value = addressData.address.NumPigs;
                    break;
            }
        }

        private void numericUpDownDomesticAnimals_ValueChanged(object sender, EventArgs e)
        {
            switch (comboBoxDomesticAnimals.Text)
            {
                case "Крави":
                    addressData.address.NumCows = (int)numericUpDownDomesticAnimals.Value;
                    break;
                case "Овце":
                    addressData.address.NumSheep = (int)numericUpDownDomesticAnimals.Value;
                    break;
                case "Кози":
                    addressData.address.NumGoats = (int)numericUpDownDomesticAnimals.Value;
                    break;
                case "Коне":
                    addressData.address.NumHorses = (int)numericUpDownDomesticAnimals.Value;
                    break;
                case "Магарета":
                    addressData.address.NumDonkeys = (int)numericUpDownDomesticAnimals.Value;
                    break;
                case "Свине":
                    addressData.address.NumPigs = (int)numericUpDownDomesticAnimals.Value;
                    break;
            }
        }

        private void comboBoxTrees_SelectedIndexChanged(object sender, EventArgs e)
        {
            switch (comboBoxTrees.Text)
            {
                case "Орехови дървета":
                    numericUpDownTrees.Value = addressData.address.NumWalnutTrees;
                    break;
                case "Черници":
                    numericUpDownTrees.Value = addressData.address.NumMulberryTrees;
                    break;
                case "Дървета над 20 г. възраст":
                    numericUpDownTrees.Value = addressData.address.NumOldTrees;
                    break;
                case "Вековни дървета":
                    numericUpDownTrees.Value = addressData.address.NumCenturyOldTrees;
                    break;
            }
        }

        private void numericUpDownTrees_ValueChanged(object sender, EventArgs e)
        {
            switch (comboBoxTrees.Text)
            {
                case "Орехови дървета":
                    addressData.address.NumWalnutTrees = (int)numericUpDownTrees.Value;
                    break;
                case "Черници":
                    addressData.address.NumMulberryTrees = (int)numericUpDownTrees.Value;
                    break;
                case "Дървета над 20 г. възраст":
                    addressData.address.NumOldTrees = (int)numericUpDownTrees.Value;
                    break;
                case "Вековни дървета":
                    addressData.address.NumCenturyOldTrees = (int)numericUpDownTrees.Value;
                    break;
            }
        }

        private void numericUpDownFeathererd_ValueChanged(object sender, EventArgs e)
        {
            addressData.address.NumFeathered = (int)numericUpDownFeathererd.Value;
        }

        private void comboBoxDogs_SelectedIndexChanged(object sender, EventArgs e)
        {
            switch (comboBoxDogsType.Text)
            {
                case "Кучета пазач":
                    labelDogsNumber.Text = (from dog in addressData.dogs where dog.Type == Dog.DogType.GuardDog select dog).ToArray().Length.ToString();
                    break;
                case "Ловджийски кучета":
                    labelDogsNumber.Text = (from dog in addressData.dogs where dog.Type == Dog.DogType.HuntingDog select dog).ToArray().Length.ToString();
                    break;
                case "Домашни кучета":
                    labelDogsNumber.Text = (from dog in addressData.dogs where dog.Type == Dog.DogType.DomesticDog select dog).ToArray().Length.ToString();
                    break;
            }
        }

        private void buttonEditDogs_Click(object sender, EventArgs e)
        {
            SetActivePanel(panelDogs, buttonAnimals);
        }

        private void buttonAddDog_Click(object sender, EventArgs e)
        {
            dontTriggerChangeEvent = true;
            Dog dog = new Dog();

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
            else
            {
                labelDogsError.Visible = false;
                dog.SealNumber = textBoxDogNumber.Text;

            }
            labelDogsError.Text = "";
            dog.Type = dogDict[comboBoxDogTypeEdit.Text];
            addressData.dogs.Add(dog);
            if (addressData.address.Id != 0)
            {
                dog.AddressId = addressData.address.Id;
                dog.Insert(connectionHelper);
            }
            ShowDogs();
            dontTriggerChangeEvent = false;
        }

        private void dataGridViewDogs_CellPainting(object sender, DataGridViewCellPaintingEventArgs e)
        {
            if (e.RowIndex < 0)
                return;

            if (e.ColumnIndex == 2)
            {
                e.Paint(e.CellBounds, DataGridViewPaintParts.All);

                var w = Properties.Resources.deleteRowIcon.Width;
                var h = Properties.Resources.deleteRowIcon.Height;
                var x = e.CellBounds.Left + (e.CellBounds.Width - w) / 2;
                var y = e.CellBounds.Top + (e.CellBounds.Height - h) / 2;

                e.Graphics.DrawImage(Properties.Resources.deleteRowIcon, new Rectangle(x, y, w, h));
                e.Handled = true;
            }
        }

        private void dataGridViewDogs_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            dontTriggerChangeEvent = true;
            if (e.RowIndex < 0) return;
            if (e.ColumnIndex == 2)
            {
                if (addressData.address.Id != 0)
                {
                    addressData.dogs[e.RowIndex].Delete(connectionHelper);
                }
                addressData.dogs.RemoveAt(e.RowIndex);
                ShowDogs();
            }

            dontTriggerChangeEvent = false;
        }

        private void comboBox_DrawItem(object sender, DrawItemEventArgs e)
        {
            if (e.Index == -1) return;
            var combo = sender as ComboBox;
            SolidBrush solidBrush;
            if ((e.State & DrawItemState.Selected) == DrawItemState.Selected)
            {
                e.Graphics.FillRectangle(new SolidBrush(Color.FromArgb(50, 80, 40)), e.Bounds);
                solidBrush = new SolidBrush(SystemColors.Control);
            }
            else
            {
                e.Graphics.FillRectangle(new SolidBrush(SystemColors.Window), e.Bounds);
                solidBrush = new SolidBrush(Color.Black);
            }

            e.Graphics.DrawString(combo.Items[e.Index].ToString(),
                                          e.Font,
                                          solidBrush,
                                          new Point(e.Bounds.X, e.Bounds.Y));
        }


        private void richTextBoxNotes_TextChanged(object sender, EventArgs e)
        {
            if (dontTriggerChangeEvent) return;
            addressData.address.Note = richTextBoxNotes.Text;
        }

        private void InsertDataProperty_VisibleChanged(object sender, EventArgs e)
        {
            if (addressData.address.Id != 0)
            {
                addressData.address.Update(connectionHelper);
            }
        }

        private void dataGridViewDogs_CellValueChanged(object sender, DataGridViewCellEventArgs e)
        {
            if (dontTriggerChangeEvent) return;
            dontTriggerChangeEvent = true;
            if (e.RowIndex < 0) return;
            DataGridViewCell cell = dataGridViewDogs.Rows[e.RowIndex].Cells[e.ColumnIndex];
            if (e.ColumnIndex == 0)
            {
                if (cell.Value == null || cell.Value.ToString() == "Няма номер" || cell.Value.ToString().Trim() == "")
                {
                    cell.Value = "Няма номер";
                    addressData.dogs[e.RowIndex].SealNumber = null;
                }
                else
                {
                    addressData.dogs[e.RowIndex].SealNumber = cell.Value.ToString();
                }
            }
            else if (e.ColumnIndex == 1)
            {
                addressData.dogs[e.RowIndex].Type = dogDict[cell.Value.ToString()];

            }
            if (addressData.address.Id != 0)
            {
                addressData.dogs[e.RowIndex].Update(connectionHelper);
            }
            ShowDogs();
            dontTriggerChangeEvent = false;
        }


    }
}
