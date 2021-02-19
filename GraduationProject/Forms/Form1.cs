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
            showStreets();
            comboBoxCriteria.SelectedIndex = 0;
        }

       //Показване на улици в listbox-а
        void showStreets()
        {
            streets = new Street().Get(connectionHelper, textBoxSearchStr.Text);
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

            residents = new Resident().Get(connectionHelper,address);
            guests = new Person().Get(connectionHelper, address);
            RefreshDataGrid();

            dogs = new Dog().Get(connectionHelper, address);
            RefreshDogsList();

        }


        //Метода връща стойност, в зависимост дали даден адрес съществува
        bool AddressExist(Street street, int number)
        {
            List <Address> addresses = new Address().Get(connectionHelper, street, "street");
            for (int i = 0; i < addresses.Count; i++)
            {
                if (addresses[i].number == number)
                    return true;
            }
            return false;
        }

        //Запазване на избрания адрес в базата данни
        void InsertAddress()
        {   
            //Запазване на адреса и записване на id-то му в променливата addressId
            int addressId = address.Insert(connectionHelper);

            //Добаване на id-то на адреса към гостите, жителите и кучетата
            foreach (Person guest in guests)
            {
                guest.addressId = addressId;
                guest.Insert(connectionHelper);
            }

            foreach (Resident resident in residents)
            {
                resident.addressId = addressId;
                resident.Insert(connectionHelper);
            }

            foreach (Dog dog in dogs)
            {
                dog.addressId = addressId;
                dog.Insert(connectionHelper);
            }

        }

        //Промяна на информацията за избрания адрес в базата данни
        private void UpdateAddress()
        {
            address.Update(connectionHelper);
            
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
                numericUpDownNumber.Enabled = true;
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
            else 
            {
                numericUpDownNumber.Enabled = false;
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
            if (personsForm.canceled) return;
            //В режим "нов адрес"
            if (tabControl.SelectedTab == tabPageAdd)
            {
                if (personsForm.isResident)
                {
                    residents.Add(personsForm.getNewResident);
                }
                else
                    guests.Add(personsForm.getNewGuest);
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

            if (street.Get(connectionHelper, street.name).Count == 0)
            {
                street.Insert(connectionHelper);
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
            Street selectedStreet = streets[listBoxStreets.SelectedIndex];
            if (new Address().Get(connectionHelper, selectedStreet, "street").Count == 0)
            {
                streets[listBoxStreets.SelectedIndex].Delete(connectionHelper);
                showStreets();
            }
            else
                MessageBox.Show("Има записи на адреси за тази улица. Моля първо изтрийте адресите.", "Действието не може да се извърши!", MessageBoxButtons.OK, MessageBoxIcon.Information);

        }

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


                        address.streetId = streets[listBoxStreets.SelectedIndex].id;
                        address.number = (int)numericUpDownNumber.Value;
                        address.squaring = (double)numericUpDownSquaring.Value;
                        address.habitallity = habitabillityValue;
                        address.numResBuildings = (int)numericUpDownResBuildings.Value;
                        address.numAgrBuildings = (int)numericUpDownAgrBuildings.Value;
                        address.numCows = (int)numericUpDownCows.Value;
                        address.numSheep = (int)numericUpDownSheep.Value;
                        address.numGoats = (int)numericUpDownGoats.Value;
                        address.numHorses = (int)numericUpDownHorses.Value;
                        address.numDonkeys = (int)numericUpDownDonkeys.Value;
                        address.numFeathered = (int)numericUpDownFeathered.Value;
                        address.numWalnutTrees = (int)numericUpDownWalnut.Value;

                    if (tabPageAdd == tabControl.SelectedTab)
                    {
                        InsertAddress();
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
                    residents = new Resident().Get(connectionHelper);
                }
                else
                {
                    guests[currentIndex - residents.Count].Delete(connectionHelper);
                    guests = new Person().Get(connectionHelper);
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

        private void textBoxSearchAddr_TextChanged(object sender, EventArgs e)
        {
            
        }

        //Опресняване на списъка с адреси
        private void buttonSearchAddress_Click(object sender, EventArgs e)
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
                    addresses = addresses.Concat(new Address().Get(connectionHelper, street, "street")).ToList();
                }
            }
            else if (comboBoxCriteria.SelectedIndex == 1)
            {
                addresses = new Address().Get(connectionHelper, textBoxSearchAddr.Text, "person");
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

        
        private void dataGridView_CellClick(object sender, DataGridViewCellEventArgs e)
        {
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
                if (!personsForm.canceled && tabControl.SelectedTab == tabPageSearch)
                    residents[currentRowIndex].Update(connectionHelper);
            }
            else
            {
                personsForm = new Forms.PersonsForm(guests[currentRowIndex - residents.Count]);
                personsForm.ShowDialog();
                if (!personsForm.canceled && tabControl.SelectedTab == tabPageSearch)
                    guests[currentRowIndex - residents.Count].Update(connectionHelper);
            }
            RefreshDataGrid();
        }
    }
}
