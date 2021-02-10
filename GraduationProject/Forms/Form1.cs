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
            addresses = Address.GetAddresses(connectionHelper);
            listBoxAddresses.DataSource = addresses;
            showStreets();
            comboBoxCriteria.SelectedIndex = 0;
        }

       //Показване на улици в listbox-а
        void showStreets()
        {
            streets = Street.GetStreets(connectionHelper, textBoxSearchStr.Text);
            listBoxStreets.DataSource = streets;

        }

        //Опресняване на таблциата с жители и гости
        void RefreshDataGrid()
        {
            //Запълване с жители
            dataGridView.RowCount = 0;
            for (int i = 0; i < residents.Count; i++)
            {
                dataGridView.RowCount++;
                dataGridView.Rows[dataGridView.RowCount - 1].Cells[0].Value = residents[i].firstname;
                dataGridView.Rows[dataGridView.RowCount - 1].Cells[1].Value = residents[i].lastname;
                dataGridView.Rows[dataGridView.RowCount - 1].Cells[2].Value = residents[i].relToOwner;
                dataGridView.Rows[dataGridView.RowCount - 1].Cells[3].Value = false;
            }

            //Запълване с гости
            for (int i = 0; i < guests.Count; i++)
            {
                dataGridView.RowCount++;
                dataGridView.Rows[dataGridView.RowCount - 1].Cells[0].Value = guests[i].firstname;
                dataGridView.Rows[dataGridView.RowCount - 1].Cells[1].Value = guests[i].lastname;
                dataGridView.Rows[dataGridView.RowCount - 1].Cells[2].Value = guests[i].relToOwner;
                dataGridView.Rows[dataGridView.RowCount - 1].Cells[3].Value = true;
            }
        }

        //Опресняване на списъка с кучета
        void RefreshDogsList()
        {
            listBoxDogs.DataSource = null;
            listBoxDogs.DataSource = dogs;
        }

        //Показване на информацията за текущо избрания адрес
        void ShowAddress()
        {
            numericUpDownNumber.Value = address.number;
            numericUpDownSquaring.Value = (decimal)address.squaring;
            numericUpDownResBuildings.Value = address.numResBuildings;
            numericUpDownAgrBuildings.Value = address.numAgrBuildings;
            numericUpDownCows.Value = address.numCows;
            numericUpDownSheep.Value = address.numSheep;
            numericUpDownGoats.Value = address.numGoats;
            numericUpDownHorses.Value = address.numHorses;
            numericUpDownDonkeys.Value = address.numDonkeys;
            numericUpDownFeathered.Value = address.numFeathered;
            numericUpDownWalnut.Value = address.numWalnutTrees;
            SetGroupBoxValue(address.habitallity, radioButtonDesolate, radioButtonInhabited, radioButtonTemporariry);

            residents = Resident.GetResidents(connectionHelper,address);
            guests = Person.GetPersons(connectionHelper, address);
            RefreshDataGrid();

            dogs = Dog.GetDogs(connectionHelper, address);
            RefreshDogsList();

        }


        //Метода връща стойност, в зависимост дали даден адрес съществува
        bool AddressExist(Street street, int number)
        {
            List <Address> addresses = Address.GetAddresses(connectionHelper, street, "street");
            for (int i = 0; i < addresses.Count; i++)
            {
                if (addresses[i].number == number)
                    return true;
            }
            return false;
        }

        //Запазване на текущия адрес в базата данни
        void SaveAddress()
        {   
            //Запазване на адреса и записване на id-то му в променливата addressId
            int addressId = Address.InsertAddress(connectionHelper, address);

            //Добаване на id-то на адреса към гостите, жителите и кучетата
            foreach (Person guest in guests)
            {
                guest.addressId = addressId;
                guest.InsertPerson(connectionHelper);
            }

            foreach (Resident resident in residents)
            {
                resident.addressId = addressId;
                resident.InsertResident(connectionHelper);
            }

            foreach (Dog dog in dogs)
            {
                dog.addressId = addressId;
                dog.InsertDog(connectionHelper);
            }

        }

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

        public void SetGroupBoxValue(int habitabillity,params RadioButton[] radioButtons)
        {
            for (int i = 0; i < radioButtons.Length; i++)
            {
                if (habitabillity == i)
                    radioButtons[i].Checked = true;
            }
        }


        private void Form1_Load(object sender, EventArgs e)
        {
            
        }

        private void menuStrip1_ItemClicked(object sender, ToolStripItemClickedEventArgs e)
        {

        }





        private void menuStrip_ItemClicked(object sender, ToolStripItemClickedEventArgs e)
        {

        }

        //Нулиране на списъците с гости, жители и кучета
        private void tabControl_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (tabPageAdd == tabControl.SelectedTab)
            {
                residents = new List<Resident>();
                guests = new List<Person>();
                dogs = new List<Dog>();
                dataGridView.RowCount = 0;
                RefreshDogsList();
            }
        }

        //Опресняване на списъка с улици при промяна на стойността на полето за търсене
        private void textBoxSearchStr_TextChanged(object sender, EventArgs e)
        {
            showStreets();
        }

        //Добавяне на нов жител/гост
        private void buttonAddResident_Click(object sender, EventArgs e)
        {
            Forms.PersonsForm personsForm = new Forms.PersonsForm();
            personsForm.ShowDialog();
            //В режим "нов адрес"
            if (tabControl.SelectedTab == tabPageAdd)
            {
                if (personsForm.isResident)
                {
                    residents.Add(personsForm.getResident);
                }
                else
                    guests.Add(personsForm.getGuest);
                RefreshDataGrid();
            }

        }

        private void buttonSearch_Click(object sender, EventArgs e)
        {

        }

        //Добаване на улица в базата данни
        private void buttonAddStr_Click(object sender, EventArgs e)
        {
            Street street = new Street();
            if((street.name = InputBox.OpenInputBox("Моля въведете име на улица:")) == "") return;

            if (Street.GetStreets(connectionHelper, street.name).Count == 0)
            {
                street.InsertStreet(connectionHelper);
                showStreets();
            }
            else
            {
                MessageBox.Show("Тази улица съществува!", "Съществуваща улица", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
           
        }

        //Изтриване на улица от базата данни
        private void buttonRemoveStr_Click(object sender, EventArgs e)
        {
            streets[listBoxStreets.SelectedIndex].DeleteStreet(connectionHelper);
            showStreets();
        }

        //Запазване на текущия адрес
        private void buttonSave_Click(object sender, EventArgs e)
        {
            //В режим "нов адрес"
            if (tabPageAdd == tabControl.SelectedTab)
            {
                if (!AddressExist(streets[listBoxStreets.SelectedIndex],(int)numericUpDownNumber.Value))
                {
                    int habitabillityValue;
                    if ((habitabillityValue = GetGroupBoxValue(radioButtonDesolate, radioButtonInhabited, radioButtonTemporariry)) != -1)
                    {
                        errorProvider.SetError(groupBoxHabitabillity, "");
                        address = new Address()
                        {
                            streetId = streets[listBoxStreets.SelectedIndex].id,
                            number = (int)numericUpDownNumber.Value,
                            squaring = (double)numericUpDownSquaring.Value,
                            habitallity = habitabillityValue,
                            numResBuildings = (int)numericUpDownResBuildings.Value,
                            numAgrBuildings = (int)numericUpDownAgrBuildings.Value,
                            numCows = (int)numericUpDownCows.Value,
                            numSheep = (int)numericUpDownSheep.Value,
                            numGoats = (int)numericUpDownGoats.Value,
                            numHorses = (int)numericUpDownHorses.Value,
                            numDonkeys = (int)numericUpDownDonkeys.Value,
                            numFeathered = (int)numericUpDownFeathered.Value,
                            numWalnutTrees = (int)numericUpDownWalnut.Value
                        };
                        SaveAddress();
                    }
                    else
                        errorProvider.SetError(groupBoxHabitabillity, "Моля изберете опция!");
                }
                else
                    MessageBox.Show("Този адрес съществува!", "СЪществуващ адрес", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }

        }

        //Изтриване на жител/гост
        private void buttonRemoveResident_Click(object sender, EventArgs e)
        {
            //в режим "нов адрес"
            if (tabControl.SelectedTab == tabPageAdd)
            {
                if (dataGridView.CurrentCell.RowIndex < residents.Count)
                {
                    residents.RemoveAt(dataGridView.CurrentCell.RowIndex);
                }
                else 
                {
                    guests.RemoveAt(dataGridView.CurrentCell.RowIndex - residents.Count);
                }         
            }

            RefreshDataGrid();
        }

        //Добаване на куче
        private void buttonAddDog_Click(object sender, EventArgs e)
        {
            Regex regex = new Regex(@"\d+");
            string sealNum = InputBox.OpenInputBox("Моля въведете номер на скобата:");
            if (sealNum == "") { return; };
            if (!regex.IsMatch(sealNum))
            {
                MessageBox.Show("Невалидна стойност!", "Невалидна стойност", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
            //В режим "нов адрес"
            if (tabControl.SelectedTab == tabPageAdd)
            {  
                dogs.Add(new Dog() { sealNumber = int.Parse(sealNum) });
                RefreshDogsList();
                
            }
           
        }
        //Премахване на куче
        private void buttonRemoveDog_Click(object sender, EventArgs e)
        {
            //В режим "нов адрес"
            if (tabControl.SelectedTab == tabPageAdd)
            {
                if (dogs.Count > 0)
                {
                    dogs.RemoveAt(listBoxDogs.SelectedIndex);
                    RefreshDogsList();
                }
            }

        }

        private void textBoxSearchAddr_TextChanged(object sender, EventArgs e)
        {
            
        }

        //Опресняване на списъка с адреси
        private void buttonSearchAddress_Click(object sender, EventArgs e)
        {
            if (textBoxSearchAddr.Text == "")
            {
                addresses = Address.GetAddresses(connectionHelper);
                listBoxAddresses.DataSource = addresses;
                return;
            }
            addresses = new List<Address>();
            if (comboBoxCriteria.SelectedIndex == 0)
            {
                List<Street> foundStreets = Street.GetStreets(connectionHelper, textBoxSearchAddr.Text);
                foreach (Street street in foundStreets)
                {
                    addresses = addresses.Concat(Address.GetAddresses(connectionHelper, street, "street")).ToList();
                }
            }
            else if (comboBoxCriteria.SelectedIndex == 1)
            {
                addresses = Address.GetAddresses(connectionHelper, textBoxSearchAddr.Text, "person");
            }
            listBoxAddresses.DataSource = addresses;
        }

        //Показване на данните за избрания адрес от списъка с адреси
        private void listBoxAddresses_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (addresses.Count == 0) return;
                address = addresses[listBoxAddresses.SelectedIndex];
                ShowAddress();

        }
    }
}
