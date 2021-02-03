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
        List<Person> guests;
        List<Resident> residents;
        List<Street> streets;
        List<Dog> dogs;
        public Form1()
        {
            InitializeComponent();
            comboBoxCriteria.DataSource = new string[] {"Улица", "Жител" };

            listBoxAddresses.DataSource = Address.GetAddresses(connectionHelper);
            showStreets();
        }

       
        void showStreets()
        {
            streets = Street.GetStreets(connectionHelper, textBoxSearchStr.Text);
            listBoxStreets.DataSource = streets;

        }

        void RefreshDataGrid()
        {
            dataGridView.RowCount = 0;
            for (int i = 0; i < residents.Count; i++)
            {
                dataGridView.RowCount++;
                dataGridView.Rows[dataGridView.RowCount - 1].Cells[0].Value = residents[i].firstname;
                dataGridView.Rows[dataGridView.RowCount - 1].Cells[1].Value = residents[i].lastname;
                dataGridView.Rows[dataGridView.RowCount - 1].Cells[2].Value = residents[i].relToOwner;
                dataGridView.Rows[dataGridView.RowCount - 1].Cells[3].Value = false;
            }

            for (int i = 0; i < guests.Count; i++)
            {
                dataGridView.RowCount++;
                dataGridView.Rows[dataGridView.RowCount - 1].Cells[0].Value = guests[i].firstname;
                dataGridView.Rows[dataGridView.RowCount - 1].Cells[1].Value = guests[i].lastname;
                dataGridView.Rows[dataGridView.RowCount - 1].Cells[2].Value = guests[i].relToOwner;
                dataGridView.Rows[dataGridView.RowCount - 1].Cells[3].Value = true;
            }
        }

        void RefreshDogsList()
        {
            listBoxDogs.DataSource = null;
            listBoxDogs.DataSource = dogs;
        }

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

        void SaveAddress()
        {   
            int addressId = Address.InsertAddress(connectionHelper, address);

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

        }

        public int GetGroupBoxValue(params RadioButton[] radioButtons)
        {
            for (int i = 0; i < radioButtons.Length; i++)
            {
                if (radioButtons[i].Checked)
                    return i;
            }
            return -1;
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

        private void tabControl_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (tabPageAdd == tabControl.SelectedTab)
            {
                residents = new List<Resident>();
                guests = new List<Person>();
                dogs = new List<Dog>();
                dataGridView.RowCount = 0;
            }
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {
            showStreets();
        }

        private void buttonAddResident_Click(object sender, EventArgs e)
        {
            Forms.PersonsForm personsForm = new Forms.PersonsForm();
            personsForm.ShowDialog();
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

        private void buttonAddStr_Click(object sender, EventArgs e)
        {
            Street street = new Street();
            if((street.name = InputBox.OpenInputBox("Моля въведете име на улица:")) == "") return;

            if (Street.GetStreets(connectionHelper, street.name).Count == 0)
            {
                street.Insert(connectionHelper);
                showStreets();
            }
            else
            {
                MessageBox.Show("Тази улица съществува!", "Съществуваща улица", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
           
        }

        private void buttonRemoveStr_Click(object sender, EventArgs e)
        {
            streets[listBoxStreets.SelectedIndex].DeleteStreet(connectionHelper);
            showStreets();
        }

        private void buttonSave_Click(object sender, EventArgs e)
        {
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
                            numResBuildings = (int)numericUpDownResBouldings.Value,
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

        private void buttonRemoveResident_Click(object sender, EventArgs e)
        {
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
            if (tabControl.SelectedTab == tabPageAdd)
            {  
                dogs.Add(new Dog() { sealNumber = int.Parse(sealNum) });
                RefreshDogsList();
                
            }
           
        }
    }
}
