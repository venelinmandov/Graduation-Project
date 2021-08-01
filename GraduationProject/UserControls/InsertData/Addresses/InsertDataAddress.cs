using GraduationProject.Models;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Linq;
using System.Windows.Forms;

namespace GraduationProject.UserControls.InsertData.Addresses
{
    public partial class InsertDataAddress : UserControl
    {
        AddressData addressData;
        List<Address> addresses;
        List<Street> streets;
        ConnectionHelper connectionHelper = new ConnectionHelper();
        int streetIdSavedWith;
        int numberSavedWith;
        bool notSaved = true;
        bool changesAreMade = false;
        string mode; //Режим (редактиране или създаване на адрес)
        public struct AddressData
        {
            public Address address;
            public List<Inhabitant> inhabitants;
            public List<Dog> dogs;

            public void Intialize()
            {
                address = new Address();
                inhabitants = new List<Inhabitant>();
                dogs = new List<Dog>();
            }
        }

        [Browsable(true)]
        [Category("Action")]
        [Description("Invoked when button is clicked")]
        public event EventHandler ButtonClicked;

        //Конструктори
        public InsertDataAddress(AddressData addressData)
        {
            InitializeComponent();
            mode = "create";
            this.addressData = addressData;
            LoadStreets();
            ShowCreateControls();
            labelTitle.Text = "Въвеждане на нов адрес";
            addressData.address.AddressSaved += AddressSaved;
        }

        public InsertDataAddress()
        {
            InitializeComponent();
            mode = "edit";
            LoadStreets();
            ShowEditControls();
            labelTitle.Text = "Редактиране на адрес";
        }

        /// <summary>
        /// Показване на контролите при създаване на адрес
        /// </summary>
        private void ShowCreateControls()
        {
            buttonSave.Visible = true;
            buttonDelete.Visible = false;
            numericUpDownNumber.Visible = true;
            comboBoxNumber.Visible = false;
        }

        /// <summary>
        /// Показване на контролите при редактиране на адрес
        /// </summary>
        private void ShowEditControls()
        {
            buttonSave.Visible = false;
            buttonDelete.Visible = true;
            numericUpDownNumber.Visible = false;
            comboBoxNumber.Visible = true;
        }



        /// <summary>
        /// Извличане на всички улици от базата данни
        /// </summary>
        void LoadStreets()
        {
            streets = new Street().Get(connectionHelper);
            comboBoxStreet.Items.AddRange(streets.ToArray());
            comboBoxStreet.SelectedIndex = 0;
        }

        /// <summary>
        /// Проверка дали избрания адрес съществува
        /// </summary>
        void CheckAddressExist()
        {

            bool isCurrentAddress = !notSaved && (streets[comboBoxStreet.SelectedIndex].Id == streetIdSavedWith && numericUpDownNumber.Value == numberSavedWith);
            var addresssesToCheck = from address in addresses
                                    where address.StreetId == streets[comboBoxStreet.SelectedIndex].Id && address.Number == numericUpDownNumber.Value
                                    select address;
            

            if (addresssesToCheck.Count() != 0 && !isCurrentAddress)
            {
                ShowErrorLabel(labelAddressExists);
                buttonInhabitants.Enabled = false;
                buttonProperty.Enabled = false;
                buttonSave.Enabled = false;
            }
            else
            {
                HideErrorLabel();
                buttonInhabitants.Enabled = true;
                buttonProperty.Enabled = true;
                buttonSave.Enabled = true;
            }
        }

        /// <summary>
        /// Избрана е улица от комбобокса за избор на улица
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void comboBoxStreet_SelectedIndexChanged(object sender, EventArgs e)
        {
            ShowAddresses();
        }

        /// <summary>
        /// Извличане на адресите на избраната улица от базата данни
        /// </summary>
        private void ShowAddresses()
        {
            comboBoxNumber.Items.Clear();
            addresses = new Address().Get(connectionHelper, streets[comboBoxStreet.SelectedIndex]);
            if (addresses.Count > 0)
            {
                foreach (Address address in addresses)
                {
                    comboBoxNumber.Items.Add(address.Number);

                }
                comboBoxNumber.SelectedIndex = 0;
                HideErrorLabel();
                buttonInhabitants.Enabled = true;
                buttonProperty.Enabled = true;
                buttonDelete.Enabled = true;
            }
            else
            {
                comboBoxNumber.Text = "";
                ShowErrorLabel(labelNoAddresses);
                buttonInhabitants.Enabled = false;
                buttonProperty.Enabled = false;
                buttonDelete.Enabled = false;
            }
            if (mode == "create")
            {
                addressData.address.StreetId = streets[comboBoxStreet.SelectedIndex].Id;
                addressData.address.streetName = streets[comboBoxStreet.SelectedIndex].Name;
                SetAddressNumber();
                CheckAddressExist();
            }
        }

        /// <summary>
        /// Въведен е номер на адрес (при създаване на адрес)
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void numericUpDownNumber_ValueChanged(object sender, EventArgs e)
        {
            SetAddressNumber();
        }

        /// <summary>
        /// Задава номера на адреса (при редактиране на адрес)
        /// </summary>
        private void SetAddressNumber()
        {
            if (mode == "create")
            {
                addressData.address.Number = (int)numericUpDownNumber.Value;
                CheckAddressExist();
            }
        }

        /// <summary>
        /// Отваряне на менюто за редактиране на данните на имота
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void buttonProperty_Click(object sender, EventArgs e)
        {
            changesAreMade = true;
            ButtonClicked(new Forms.MainForm.EventData("propertyData", addressData), e);
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
        /// Натиснат е бутона за запис на адреса (при създаване на нов адрес)
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void buttonSave_Click(object sender, EventArgs e)
        {
            streetIdSavedWith = addressData.address.StreetId;
            numberSavedWith = addressData.address.Number;
            if (notSaved)
            {
                SaveAddress();
                MessageBox.Show("Адресът е записан успешно.", "Адресът е записан", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            else
            {
                addressData.address.Update(connectionHelper);
                MessageBox.Show("Промените са записани успешно.", "Промените за записани", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }

        /// <summary>
        /// Запис на адрес (при създаване на нов адрес)
        /// </summary>
        private void SaveAddress()
        {
            if (mode == "create")
            {
                addressData.address.Insert(connectionHelper);
            }
        }

        /// <summary>
        /// Събитие - нов адрес е записан в базата данни.
        /// </summary>
        private void AddressSaved(object obj, EventArgs args)
        {
            foreach (Dog dog in addressData.dogs)
            {
                dog.AddressId = addressData.address.Id;
                dog.Insert(connectionHelper);
            }
            buttonSave.Text = "Промени";
            buttonSave.Size = new Size(buttonSave.Width + 5, buttonSave.Height);
            notSaved = false;
        }

        /// <summary>
        /// Избран е номер да адрес (пре редактиране на адрес)
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void comboBoxNumber_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (mode == "edit")
            {
                addressData.address = addresses[comboBoxNumber.SelectedIndex];
                addressData.dogs = new Dog().Get(connectionHelper, addressData.address);
                addressData.inhabitants = new Inhabitant().Get(connectionHelper, addressData.address);
            }
        }

        /// <summary>
        /// Натиснат е бутона за изтриване на адрес (при редактиране на адрес)
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void buttonDelete_Click(object sender, EventArgs e)
        {
            if (mode == "edit")
            {
                DialogResult dialogResult = MessageBox.Show("Сигурни ли сте, че искате да изтриете адреса?", "Изтриване на адрес", MessageBoxButtons.OKCancel, MessageBoxIcon.Warning);
                if (dialogResult == DialogResult.OK)
                {
                    addressData.address.Delete(connectionHelper);
                    ShowAddresses();
                }
            }
        }

        private void buttonInhabitants_Click(object sender, EventArgs e)
        {
            changesAreMade = true;
        }

        private void InsertDataAddress_VisibleChanged(object sender, EventArgs e)
        {
            if (notSaved && changesAreMade && mode == "create")
            {
                DialogResult dialogResult = MessageBox.Show("Излизате от режим \"Нов адрес\" и въведените от вас данни ще бъдат изгубени. Запазване на въведените данни?", "Запазване на адрес?", MessageBoxButtons.YesNo, MessageBoxIcon.Warning);
                if (dialogResult == DialogResult.Yes)
                {
                    SaveAddress();
                }
            }
        }

        private void ShowErrorLabel(Label label)
        {
            label.Visible = true;
            labelTitle.Visible = false;
        }

        private void HideErrorLabel()
        {
            foreach (var label in from lbl in Controls.OfType<Label>() where lbl.Tag != null && lbl.Tag.Equals("errorLabel") select lbl)
            {
                label.Visible = false;
            }
            labelTitle.Visible = true;
        }

    }
}
