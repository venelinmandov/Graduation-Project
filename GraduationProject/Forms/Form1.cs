using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using GraduationProject.Models;
using System.Text.RegularExpressions;

namespace GraduationProject
{
    public partial class Form1 : Form
    {
        ErrorProvider errorProvider = new ErrorProvider();
        ConnectionHelper connectionHelper = new ConnectionHelper();
        Address address;
        List<Address> addresses;
        List<Person> guests;
        List<Resident> residents;
        List<Street> streets;
        List<Dog> dogs;
        public Form1()
        {
            InitializeComponent();
            addresses = new Address().Get(connectionHelper);
            listBoxAddresses.DataSource = addresses;
            ShowStreets();
            comboBoxCriteria.SelectedIndex = 0;
        }

        //АДРЕСИ:

        //Запазване на текущия адрес
        private void buttonSave_Click(object sender, EventArgs e)
        {
            if (!AddressExist(streets[listBoxStreets.SelectedIndex], (int)numericUpDownNumber.Value) || tabControl.SelectedTab == tabPageSearch)
            {
                int habitabillityValue;
                if ((habitabillityValue = GetGroupBoxValue(radioButtonDesolate, radioButtonInhabited, radioButtonTemporariry)) != -1)
                {
                    errorProvider.SetError(groupBoxHabitabillity, "");
                    if (tabPageAdd == tabControl.SelectedTab)
                    {
                        address = new Address();
                    }


                    address.StreetId = streets[listBoxStreets.SelectedIndex].Id;
                    address.Number = (int)numericUpDownNumber.Value;
                    address.Squaring = (double)numericUpDownSquaring.Value;
                    address.Habitallity = habitabillityValue;
                    address.NumResBuildings = (int)numericUpDownResBuildings.Value;
                    address.NumAgrBuildings = (int)numericUpDownAgrBuildings.Value;
                    address.NumCows = (int)numericUpDownCows.Value;
                    address.NumSheep = (int)numericUpDownSheep.Value;
                    address.NumGoats = (int)numericUpDownGoats.Value;
                    address.NumHorses = (int)numericUpDownHorses.Value;
                    address.NumDonkeys = (int)numericUpDownDonkeys.Value;
                    address.NumFeathered = (int)numericUpDownFeathered.Value;
                    address.NumWalnutTrees = (int)numericUpDownWalnut.Value;

                    if (tabPageAdd == tabControl.SelectedTab)
                    {
                        InsertAddress();
                        ClearInfo();
                    }
                    else
                        UpdateAddress();

                }
                else
                    errorProvider.SetError(groupBoxHabitabillity, "Моля изберете опция!");
            }
            else
                MessageBox.Show("Този адрес съществува!", "СЪществуващ адрес", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

        //Запазване на адреса в базата данни
        void InsertAddress()
        {
            //Запазване на адреса и записване на id-то му в променливата addressId
            int addressId = address.Insert(connectionHelper);

            //Добаване на id-то на адреса към гостите, жителите и кучетата
            foreach (Person guest in guests)
            {
                guest.AddressId = addressId;
                guest.Insert(connectionHelper);
            }

            foreach (Resident resident in residents)
            {
                resident.AddressId = addressId;
                resident.Insert(connectionHelper);
            }

            foreach (Dog dog in dogs)
            {
                dog.AddressId = addressId;
                dog.Insert(connectionHelper);
            }

        }

        //Промяна на информацията за избрания адрес в базата данни
        private void UpdateAddress()
        {
            address.Update(connectionHelper);

        }

        //Изтриване на адрес
        private void buttonDeleteAddr_Click(object sender, EventArgs e)
        {
            DialogResult = MessageBox.Show("Сигурни ли сте, че искате да изтриете адреса?", "Изтриване на адрес", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (DialogResult == DialogResult.No) return;

            address.Delete(connectionHelper);
            ShowAddresses();
        }

        //Опресняване на списъка с адреси
        private void ShowAddresses()
        {
            if (textBoxSearchAddr.Text == "")
            {
                addresses = new Address().Get(connectionHelper);
                listBoxAddresses.DataSource = addresses;
                return;
            }
            addresses = new List<Address>();
            if (comboBoxCriteria.SelectedIndex == 0)
            {
                List<Street> foundStreets = new Street().Get(connectionHelper, textBoxSearchAddr.Text);
                foreach (Street street in foundStreets)
                {
                    addresses = addresses.Concat(new Address().Get(connectionHelper, street)).ToList();
                }
            }
            else if (comboBoxCriteria.SelectedIndex == 1)
            {
                addresses = new Address().Get(connectionHelper, textBoxSearchAddr.Text);
            }
            listBoxAddresses.DataSource = addresses;
        }

        //Показване на информацията за текущо избрания адрес
        void ShowSelectedAddress()
        {
            numericUpDownNumber.Value = address.Number;
            numericUpDownSquaring.Value = (decimal)address.Squaring;
            numericUpDownResBuildings.Value = address.NumResBuildings;
            numericUpDownAgrBuildings.Value = address.NumAgrBuildings;
            numericUpDownCows.Value = address.NumCows;
            numericUpDownSheep.Value = address.NumSheep;
            numericUpDownGoats.Value = address.NumGoats;
            numericUpDownHorses.Value = address.NumHorses;
            numericUpDownDonkeys.Value = address.NumDonkeys;
            numericUpDownFeathered.Value = address.NumFeathered;
            numericUpDownWalnut.Value = address.NumWalnutTrees;
            SetGroupBoxValue(address.Habitallity, radioButtonDesolate, radioButtonInhabited, radioButtonTemporariry);

            residents = new Resident().Get(connectionHelper, address);
            guests = new Person().Get(connectionHelper, address);
            RefreshDataGrid();

            dogs = new Dog().Get(connectionHelper, address);
            RefreshDogsList();
        }

        //Показване на данните за избрания адрес от списъка с адреси
        private void listBoxAddresses_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (addresses.Count == 0) return;
            address = addresses[listBoxAddresses.SelectedIndex];
            ShowSelectedAddress();
        }

        //Метода връща стойност, в зависимост дали даден адрес съществува
        bool AddressExist(Street street, int number)
        {
            List<Address> addresses = new Address().Get(connectionHelper, street);
            for (int i = 0; i < addresses.Count; i++)
            {
                if (addresses[i].Number == number)
                    return true;
            }
            return false;
        }

        //Избран е бутона за търсене на адреси
        private void buttonSearchAddress_Click(object sender, EventArgs e)
        {
            ShowAddresses();
        }

        //УЛИЦИ:

        //Добаване на улица в базата данни
        private void buttonAddStr_Click(object sender, EventArgs e)
        {
            Street street = new Street();
            InputBox.InputboxResponce responce = InputBox.OpenInputBox("Моля въведете име на улица:");
            if (responce.canceled) return;

            street.Name = responce.text;
            if (!StreetExist(street.Name))
            {
                street.Insert(connectionHelper);
                ShowStreets();
            }
            else
            {
                MessageBox.Show("Тази улица съществува!", "Съществуваща улица", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }

        //Преименуване на улица
        private void toolStripMenuItemRenameStr_click(object sender, EventArgs e)
        {
            InputBox.InputboxResponce responce = InputBox.OpenInputBox("Ново име на улицата: ");
            if (responce.canceled) return;
            if (!StreetExist(responce.text))
            {
                Street selectedStreet = streets[listBoxStreets.SelectedIndex];

                selectedStreet.Name = responce.text;
                selectedStreet.Update(connectionHelper);
                ShowStreets();
            }
            else
            {
                MessageBox.Show("Тази улица съществува!", "Съществуваща улица", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }

        }

        //Изтриване на улица от базата данни
        private void toolStripMenuItemRemoveStr_click(object sender, EventArgs e)
        {
            Street selectedStreet = streets[listBoxStreets.SelectedIndex];
            if (new Address().Get(connectionHelper, selectedStreet).Count == 0)
            {
                streets[listBoxStreets.SelectedIndex].Delete(connectionHelper);
                ShowStreets();
            }
            else
                MessageBox.Show("Има записи на адреси за тази улица. Моля първо изтрийте адресите.", "Действието не може да се извърши!", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

        //Опресняване на списъка с улици при промяна на стойността на полето за търсене
        private void textBoxSearchStr_TextChanged(object sender, EventArgs e)
        {
            ShowStreets();
        }

        //Показване на улици в listbox-а
        void ShowStreets()
        {
            streets = new Street().Get(connectionHelper, textBoxSearchStr.Text);
            listBoxStreets.DataSource = streets;
        }

        //Показване на контекстно меню на улица
        private void listBoxStreets_MouseDown(object sender, MouseEventArgs e)
        {
            if (e.Button == MouseButtons.Right)
            {

                if (listBoxStreets.IndexFromPoint(e.Location) != ListBox.NoMatches)
                {
                    listBoxStreets.SelectedIndex = listBoxStreets.IndexFromPoint(e.Location);
                    contextMenuStripStreets.Show(listBoxStreets, e.Location);
                }
            }
        }

        //Връща стойност дали дадена улица съществува
        bool StreetExist(string streetName)
        {
            List<Street> foundStreets = new Street().Get(connectionHelper, streetName);
            if (foundStreets.Count != 0)
            {
                foreach (Street street in foundStreets)
                {
                    if (street.Name == streetName)
                    {
                        return true;
                    }
                }
            }
            return false;
        }

        //ЖИТЕЛИ/ГОСТИ:

        //Добавяне на нов жител/гост
        private void buttonAddResident_Click(object sender, EventArgs e)
        {
            Forms.PersonsForm personsForm = new Forms.PersonsForm();
            personsForm.ShowDialog();
            if (personsForm.Canceled) return;
            //В режим "нов адрес"
            if (tabControl.SelectedTab == tabPageAdd)
            {
                if (personsForm.isResident)
                {
                    residents.Add(personsForm.getNewResident);
                }
                else
                    guests.Add(personsForm.getNewGuest);

            }
            //В режим "редактиране на адрес" 
            else
            {
                if (personsForm.isResident)
                {
                    Resident newRes = personsForm.getNewResident;
                    newRes.AddressId = address.Id;
                    newRes.Insert(connectionHelper);
                    residents = new Resident().Get(connectionHelper, address);
                }
                else
                {
                    Person newGuest = personsForm.getNewGuest;
                    newGuest.AddressId = address.Id;
                    newGuest.Insert(connectionHelper);
                    guests = new Person().Get(connectionHelper, address);
                }


            }
            RefreshDataGrid();
        }

        //Изтриване на жител/гост
        private void buttonRemoveResident_Click(object sender, EventArgs e)
        {
            if (dataGridView.RowCount == 0) return;
            int currentIndex = dataGridView.CurrentCell.RowIndex;
            //в режим "нов адрес"
            if (tabControl.SelectedTab == tabPageAdd)
            {
                if (currentIndex < residents.Count)
                {
                    residents.RemoveAt(currentIndex);
                }
                else
                {
                    guests.RemoveAt(currentIndex - residents.Count);
                }
            }
            //В режим "редактиране на адрес" 
            else
            {
                if (currentIndex < residents.Count)
                {
                    residents[currentIndex].Delete(connectionHelper);
                    residents = new Resident().Get(connectionHelper, address);
                }
                else
                {
                    guests[currentIndex - residents.Count].Delete(connectionHelper);
                    guests = new Person().Get(connectionHelper);
                }
            }
            RefreshDataGrid();
        }

        //Опресняване на таблциата с жители и гости
        void RefreshDataGrid()
        {
            //Запълване с жители
            dataGridView.RowCount = 0;
            for (int i = 0; i < residents.Count; i++)
            {
                dataGridView.RowCount++;
                dataGridView.Rows[dataGridView.RowCount - 1].Cells[0].Value = residents[i].Firstname;
                dataGridView.Rows[dataGridView.RowCount - 1].Cells[1].Value = residents[i].Lastname;
                dataGridView.Rows[dataGridView.RowCount - 1].Cells[2].Value = residents[i].RelToOwner;
                dataGridView.Rows[dataGridView.RowCount - 1].Cells[3].Value = false;
            }

            //Запълване с гости
            for (int i = 0; i < guests.Count; i++)
            {
                dataGridView.RowCount++;
                dataGridView.Rows[dataGridView.RowCount - 1].Cells[0].Value = guests[i].Firstname;
                dataGridView.Rows[dataGridView.RowCount - 1].Cells[1].Value = guests[i].Lastname;
                dataGridView.Rows[dataGridView.RowCount - 1].Cells[2].Value = guests[i].RelToOwner;
                dataGridView.Rows[dataGridView.RowCount - 1].Cells[3].Value = true;
            }
        }

        //Отваряне на формата за редактиране на жител/гост 
        private void buttonEditPerson_Click(object sender, EventArgs e)
        {
            if (dataGridView.RowCount == 0) return;
            Forms.PersonsForm personsForm;
            int currentRowIndex = dataGridView.CurrentCell.RowIndex;
            if (currentRowIndex < residents.Count)
            {
                personsForm = new Forms.PersonsForm(residents[currentRowIndex]);
                personsForm.ShowDialog();
                if (!personsForm.Canceled && tabControl.SelectedTab == tabPageSearch)
                    residents[currentRowIndex].Update(connectionHelper);
            }
            else
            {
                personsForm = new Forms.PersonsForm(guests[currentRowIndex - residents.Count]);
                personsForm.ShowDialog();
                if (!personsForm.Canceled && tabControl.SelectedTab == tabPageSearch)
                    guests[currentRowIndex - residents.Count].Update(connectionHelper);
            }
            RefreshDataGrid();
        }

        //КУЧЕТА:

        //Добаване на куче
        private void buttonAddDog_Click(object sender, EventArgs e)
        {

            Regex regex = new Regex(@"\d{15}");
            InputBox.InputboxResponce responce = InputBox.OpenInputBox("Моля въведете номер на скобата:");
            if (responce.canceled) return;

            string sealNum = responce.text;
            if (!regex.IsMatch(sealNum))
            {
                MessageBox.Show("Невалидна стойност!", "Невалидна стойност", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
            Dog newDog = new Dog() { SealNumber = sealNum };
            //В режим "нов адрес"
            if (tabControl.SelectedTab == tabPageAdd)
            {
                dogs.Add(newDog);
            }
            //В режим "редактиране на адрес"
            else
            {
                newDog.AddressId = address.Id;
                newDog.Insert(connectionHelper);
                dogs = new Dog().Get(connectionHelper, address);
            }
            RefreshDogsList();
        }

        //Премахване на куче
        private void buttonRemoveDog_Click(object sender, EventArgs e)
        {
            int selectedIndex = listBoxDogs.SelectedIndex;
            //В режим "нов адрес"
            if (tabControl.SelectedTab == tabPageAdd)
            {
                if (dogs.Count > 0)
                {
                    dogs.RemoveAt(selectedIndex);
                }
            }
            //В режим "редактиране на адрес"
            else
            {
                dogs[selectedIndex].Delete(connectionHelper);
                dogs = new Dog().Get(connectionHelper, address);
            }
            RefreshDogsList();
        }

        //Опресняване на списъка с кучета
        void RefreshDogsList()
        {
            listBoxDogs.DataSource = null;
            listBoxDogs.DataSource = dogs;
        }

        //ДРУГИ:

        //Връща поредния номер на избран радиобутон от няколко подадени кото аргументи.
        public int GetGroupBoxValue(params RadioButton[] radioButtons)
        {
            for (int i = 0; i < radioButtons.Length; i++)
            {
                if (radioButtons[i].Checked)
                    return i;
            }
            return -1;
        }

        //Задава стойност на избран радиобутон по индекс от група зададени
        public void SetGroupBoxValue(int index, params RadioButton[] radioButtons)
        {
            for (int i = 0; i < radioButtons.Length; i++)
            {
                if (index == i)
                    radioButtons[i].Checked = true;
            }
        }

        //Променен е избрания таб
        private void tabControl_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (tabPageAdd == tabControl.SelectedTab)
            {
                //Таб "Нов адрес"
                ClearInfo();
            }
            else
            {
                //Таб "Търси адрес"
                ShowAddresses();
                numericUpDownNumber.Enabled = false;
                buttonDeleteAddr.Enabled = true;
            }
        }

        //Изчистване на визуализираната информация за адрес
        private void ClearInfo()
        {
            numericUpDownNumber.Enabled = true;
            buttonDeleteAddr.Enabled = false;
            residents = new List<Resident>();
            guests = new List<Person>();
            dogs = new List<Dog>();
            dataGridView.RowCount = 0;
            RefreshDogsList();

            numericUpDownAgrBuildings.Value = 0;
            numericUpDownCows.Value = 0;
            numericUpDownDonkeys.Value = 0;
            numericUpDownFeathered.Value = 0;
            numericUpDownGoats.Value = 0;
            numericUpDownHorses.Value = 0;
            numericUpDownNumber.Value = 0;
            numericUpDownResBuildings.Value = 0;
            numericUpDownSheep.Value = 0;
            numericUpDownSquaring.Value = 0;
            numericUpDownWalnut.Value = 0;

            RadioButton[] radioButtons = new RadioButton[] { radioButtonDesolate, radioButtonInhabited, radioButtonTemporariry };
            foreach (RadioButton radioButton in radioButtons)
            {
                if (radioButton.Checked)
                {
                    radioButton.Checked = false;
                    break;
                }
            }
        }
    }
}
