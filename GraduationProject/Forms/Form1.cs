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

namespace GraduationProject
{
    public partial class Form1 : Form
    {
        ConnectionHelper connectionHelper = new ConnectionHelper();
        List<Person> guests;
        List<Resident> residents;
        List<Street> streets;
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
                dataGridView.Rows[dataGridView.RowCount-1].Cells[0].Value = residents[i].firstname;
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

        private void Form1_Load(object sender, EventArgs e)
        {
            
        }

        private void menuStrip1_ItemClicked(object sender, ToolStripItemClickedEventArgs e)
        {

        }



        private void Streets_ItemClicked(object sender, EventArgs e)
        {
            Forms.StreetsForm addressForm = new Forms.StreetsForm();
            addressForm.ShowDialog();
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
                    residents.Add(personsForm.GetResident);
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
            street.name = InputBox.OpenInputBox();
            if (Street.GetStreets(connectionHelper, street.name).Count == 0)
            {
                street.InsertStreet(connectionHelper);
                showStreets();
            }
            else
            {
                //ERROR: Тази улица съществува.
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
                
            }
        }
    }
}
