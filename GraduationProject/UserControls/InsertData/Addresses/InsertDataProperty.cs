using GraduationProject.Models;
using System;
using System.Collections.Generic;
using System.Data;
using System.Drawing;
using System.Linq;
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
            activeButton = buttonStateAndSquaring;
            SetActivePanel(panelStateAndSquaring, activeButton);
            if (addressData.address.Id != 0)
            {
                addressData.dogs = new Dog().Get(connectionHelper, addressData.address);
            }
            else
            {
                addressData.dogs = new List<Dog>();

            }

            ShowDogs();

            foreach (Panel panel in Controls.OfType<Panel>())
            {
                foreach (ComboBox comboBox in panel.Controls.OfType<ComboBox>())
                {
                    comboBox.DrawItem += comboBox_DrawItem;
                }
            }
            comboBoxHabitability.DrawItem += comboBox_DrawItem;

            UpdateInsertedDataStatesAndProperty();
            UpdateInsertedDataBuildings();
            UpdateInsertedDataTrees();
            UpdateInsertedDataAnimals();
            UpdateInsertedDataNotes();

            dontTriggerChangeEvent = false;
        }

        //Методи

        #region Статус и площ
        /// <summary>
        /// Показване на панела със статуса на обитаване и площта
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void buttonStateAndSquaring_Click(object sender, EventArgs e)
        {
            SetActivePanel(panelStateAndSquaring, (Button)sender);

        }
        /// <summary>
        /// Показване на въведените данни (статус и площ)
        /// </summary>
        void UpdateInsertedDataStatesAndProperty()
        {
            string dataText = "";
            if (addressData.address.Habitallity != 0)
            {
                string habitability = habitabilityDict.FirstOrDefault(entry => EqualityComparer<Address.Habitability>.Default.Equals(entry.Value, addressData.address.Habitallity)).Key;
                dataText += $"Статус: {habitability}\n";
            }
            if (addressData.address.Squaring != 0.0)
            {
                dataText += $"Площ: {addressData.address.Squaring}\n";
            }
            insertedDataDisplayStateAndSquaring.DataText = dataText;

        }
        /// <summary>
        /// Въвеждане на статус на обитаемост
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void buttonInsertState_Click(object sender, EventArgs e)
        {
            if (comboBoxHabitability.Text == "") return;
            addressData.address.Habitallity = habitabilityDict[comboBoxHabitability.Text];
            SaveAddress();
            UpdateInsertedDataStatesAndProperty();
        }
        /// <summary>
        /// Въвеждане на площ
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void buttonInsertSquaring_Click(object sender, EventArgs e)
        {
            addressData.address.Squaring = (double)numericUpDownSquaring.Value;
            SaveAddress();
            UpdateInsertedDataStatesAndProperty();
        }
        #endregion
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
        /// Показване на въведените данни (постройки)
        /// </summary>
        void UpdateInsertedDataBuildings()
        {
            string dataText = "";
            if (addressData.address.NumResBuildings != 0)
            {
                dataText += $"Жилищни постройки: {addressData.address.NumResBuildings}\n";
            }
            if (addressData.address.NumAgrBuildings != 0)
            {
                dataText += $"Селскостопански постройки: {addressData.address.NumAgrBuildings}\n";
            }

            insertedDataDisplayBuildings.DataText = dataText;
        }

        /// <summary>
        /// Въвеждане на постройки
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void buttonInsertBuildings_Click(object sender, EventArgs e)
        {
            if (comboBoxBuildings.Text == "") return;
            if (comboBoxBuildings.Text == "Жилищни постройки")
            {
                addressData.address.NumResBuildings = (int)numericUpDownBuildings.Value;
            }
            else
            {
                addressData.address.NumAgrBuildings = (int)numericUpDownBuildings.Value;

            }
            SaveAddress();
            UpdateInsertedDataBuildings();
        }

        #endregion
        #region Селскостопански животни
        #region Кучета
        /// <summary>
        /// Показване на панела за редактиране на кучетата
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void buttonEditDogs_Click(object sender, EventArgs e)
        {
            SetActivePanel(panelDogs, buttonAnimals);
        }

        /// <summary>
        /// Уголямяване на бутона за назад 
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void pictureBoxBack_MouseEnter(object sender, EventArgs e)
        {
            pictureBoxBack.Size = new Size(pictureBoxBack.Size.Width + 4, pictureBoxBack.Size.Height + 4);
            pictureBoxBack.Location = new Point(pictureBoxBack.Location.X - 2, pictureBoxBack.Location.Y - 2);
        }

        /// <summary>
        /// намаляване на размера на бутона за назад
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void pictureBoxBack_MouseLeave(object sender, EventArgs e)
        {
            pictureBoxBack.Size = new Size(pictureBoxBack.Size.Width - 4, pictureBoxBack.Size.Height - 4);
            pictureBoxBack.Location = new Point(pictureBoxBack.Location.X + 2, pictureBoxBack.Location.Y + 2);
        }

        /// <summary>
        /// Натискане на бутона за назад
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void pictureBoxBack_Click(object sender, EventArgs e)
        {
            SetActivePanel(panelAnimals, buttonAnimals);
            UpdateInsertedDataAnimals();
        }
        /// <summary>
        /// Показване на кучетата от списъка с кучета в таблицата
        /// </summary>
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

        /// <summary>
        /// Добаване на ново куче
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
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
                dog.SealNumber = textBoxDogNumber.Text;
            }
            if (comboBoxDogTypeEdit.Text == "")
            {
                labelDogsError.Text = "Моля изберете тип куче!";
                labelDogsError.Visible = true;
                return;
            }

            labelDogsError.Visible = false;
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

        /// <summary>
        /// Изчертаване на иконите за изтриване на куче в таблицата с кучета
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
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

        /// <summary>
        /// Натискане на бутон от таблицата с кучета за изтриване на куче 
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
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

        /// <summary>
        /// Промяна на стойност на клетка от таблицата с кучетата
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
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
        #endregion
        /// <summary>
        /// Показване на панела със селскостопанските животни
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void buttonAnimals_Click(object sender, EventArgs e)
        {
            UpdateInsertedDataAnimals();
            SetActivePanel(panelAnimals, (Button)sender);

        }
        /// <summary>
        /// Показване на въведените данни (селкскостопански животни)
        /// </summary>
        void UpdateInsertedDataAnimals()
        {
            string dataText = "";
            int guardDogs = (from dog in addressData.dogs where dog.Type == Dog.DogType.GuardDog select dog).ToArray().Length;
            int huntingDogs = (from dog in addressData.dogs where dog.Type == Dog.DogType.HuntingDog select dog).ToArray().Length;
            int domesticDogs = (from dog in addressData.dogs where dog.Type == Dog.DogType.DomesticDog select dog).ToArray().Length;

            if (addressData.address.NumCows != 0)
            {
                dataText += $"Крави: {addressData.address.NumCows}\n";

            }
            if (addressData.address.NumSheep != 0)
            {
                dataText += $"Овце: {addressData.address.NumSheep}\n";

            }
            if (addressData.address.NumGoats != 0)
            {
                dataText += $"Кози: {addressData.address.NumGoats}\n";

            }
            if (addressData.address.NumHorses != 0)
            {
                dataText += $"Коне: {addressData.address.NumHorses}\n";

            }
            if (addressData.address.NumDonkeys != 0)
            {
                dataText += $"Магарета: {addressData.address.NumDonkeys}\n";

            }
            if (addressData.address.NumPigs != 0)
            {
                dataText += $"Свине: {addressData.address.NumPigs}\n";

            }
            if (addressData.address.NumFeathered != 0)
            {
                dataText += $"Пернати: {addressData.address.NumFeathered}\n";

            }
            if (guardDogs != 0)
            {
                dataText += $"Кучета пазачи: {guardDogs}\n";
            }
            if (huntingDogs != 0)
            {
                dataText += $"Ловджийски кучета: {huntingDogs}\n";
            }
            if (domesticDogs != 0)
            {
                dataText += $"Домашни кучета: {domesticDogs}\n";
            }

            insertedDataDisplayAnimals.DataText = dataText;

        }

        /// <summary>
        /// Въвеждане на домашни животни
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void buttonInsertCattle_Click(object sender, EventArgs e)
        {
            switch (comboBoxDomesticAnimals.Text)
            {
                case "": return;
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
            SaveAddress();
            UpdateInsertedDataAnimals();
        }

        /// <summary>
        /// Въвеждане на пернати
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void buttonInsertFeathered_Click(object sender, EventArgs e)
        {
            addressData.address.NumFeathered = (int)numericUpDownFeathererd.Value;
            SaveAddress();
            UpdateInsertedDataAnimals();
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
        /// Показване на въведените данни (защитени дървесни видове)
        /// </summary>
        void UpdateInsertedDataTrees()
        {
            string dataText = "";
            if (addressData.address.NumWalnutTrees != 0)
            {
                dataText += $"Орехови дървета: {addressData.address.NumWalnutTrees}\n";
            }
            if (addressData.address.NumMulberryTrees != 0)
            {
                dataText += $"Черници: {addressData.address.NumMulberryTrees}\n";
            }
            if (addressData.address.NumOldTrees != 0)
            {
                dataText += $"Дървета над 20 г. възраст: {addressData.address.NumOldTrees}\n";
            }
            if (addressData.address.NumCenturyOldTrees != 0)
            {
                dataText += $"Вековни дървета: {addressData.address.NumCenturyOldTrees}\n";
            }
            insertedDataDisplayTrees.DataText = dataText;
        }

        /// <summary>
        /// Въвеждане на защитени дървесни видове
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void buttonInsertTrees_Click(object sender, EventArgs e)
        {
            switch (comboBoxTrees.Text)
            {
                case "":
                    return;
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
            SaveAddress();
            UpdateInsertedDataTrees();
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

        /// <summary>
        /// Показване на въведените данни (забележки)
        /// </summary>
        void UpdateInsertedDataNotes()
        {
            insertedDataDisplayNotes.DataText = addressData.address.Note;
        }
        /// <summary>
        /// Въвеждане на забележки
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void buttonInsertNote_Click(object sender, EventArgs e)
        {
            addressData.address.Note = richTextBoxNotes.Text;
            SaveAddress();
            UpdateInsertedDataNotes();
        }

        /// <summary>
        /// Редактиране на забележки
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void buttonEditNote_Click(object sender, EventArgs e)
        {
            richTextBoxNotes.Text = addressData.address.Note;
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
        /// Изчертаване на елемент от комбобокс
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
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

        /// <summary>
        /// Запазване на промените в базата данни (при редактиране на адрес)
        /// </summary>
        private void SaveAddress()
        {
            if (addressData.address.Id != 0)
            {
                addressData.address.Update(connectionHelper);
            }
        }
        #endregion












    }
}
