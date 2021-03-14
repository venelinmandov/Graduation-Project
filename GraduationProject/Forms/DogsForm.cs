using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Text.RegularExpressions;
using System.Windows.Forms;
using GraduationProject.Models;

namespace GraduationProject.Forms
{
    public partial class DogsForm : Form
    {
        List<Dog> dogs;
        Address address;
        ConnectionHelper connectionHelper = new ConnectionHelper();
        bool editing = false;
        string currentCellText;
        
        public DogsForm(List<Dog> dogsArg)
        {
            InitializeComponent();
            dogs = dogsArg;
            ShowDogs();
        }

        public DogsForm(List<Dog> dogsArg, Address addressArg)
        {
            InitializeComponent();
            dogs = dogsArg;
            ShowDogs();
            address = addressArg;
        }

        void ShowDogs()
        {
            for (int i = 0; i < dogs.Count; i++)
            {
                
                dataGridViewDogs.RowCount++;
                dataGridViewDogs.Rows[dataGridViewDogs.RowCount - 1].Cells[0].Value = i + 1;
                dataGridViewDogs.Rows[dataGridViewDogs.RowCount - 1].Cells[1].Value = dogs[i];
                
                
                dataGridViewDogs.Rows[dataGridViewDogs.RowCount - 1].Cells[2].Value = "Изтриване";
                
            }
        }

        private void DogsForm_Load(object sender, EventArgs e)
        {

        }

        private void dataGridViewDogs_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            var senderGrid = (DataGridView)sender;

            if (senderGrid.Columns[e.ColumnIndex] is DataGridViewButtonColumn &&
                e.RowIndex >= 0)
            {
                if (address != null)
                {
                    dogs[e.RowIndex].Delete(connectionHelper);
                }
                dataGridViewDogs.Rows.Remove(dataGridViewDogs.Rows[e.RowIndex]);
                dogs.RemoveAt(e.RowIndex);
            }
        }

        private void buttonEdit_Click(object sender, EventArgs e)
        {

        }

        private void textBoxDogName_TextChanged(object sender, EventArgs e)
        {

        }

        private void dataGridViewDogs_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (dataGridViewDogs.CurrentCell.ColumnIndex == 1)
            {
                dataGridViewDogs.Columns[1].ReadOnly = false;
                currentCellText = dataGridViewDogs.CurrentCell.Value.ToString();
                editing = true;
            }
        }

        private void checkBoxNoNumber_CheckedChanged(object sender, EventArgs e)
        {
            if (checkBoxNoNumber.Checked)
                textBoxDogName.Enabled = false;
            else
                textBoxDogName.Enabled = true;
        }

        private void buttonAdd_Click(object sender, EventArgs e)
        {
            Regex regex = new Regex(@"^\d{15}$");
            string sealNum;

            if (!checkBoxNoNumber.Checked)
            {
                sealNum = textBoxDogName.Text;
                if (!regex.IsMatch(sealNum))
                {

                    MessageBox.Show("Невалидна стойност!", "Невалидна стойност", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return;
                }
            }
            else
            {
                sealNum = null;
            }

           
            Dog newDog = new Dog() { SealNumber = sealNum };

            if (address != null)
            {
                newDog.AddressId = address.Id;
                newDog.Insert(connectionHelper);
            }
            else
            {
                dogs.Add(newDog);
            }

            dataGridViewDogs.RowCount++;
            dataGridViewDogs.Rows[dataGridViewDogs.RowCount - 1].Cells[0].Value = dataGridViewDogs.RowCount;
            dataGridViewDogs.Rows[dataGridViewDogs.RowCount - 1].Cells[1].Value = newDog;
            dataGridViewDogs.Rows[dataGridViewDogs.RowCount - 1].Cells[2].Value = "Изтриване";
        }

        private void dataGridViewDogs_CurrentCellChanged(object sender, EventArgs e)
        {
            
        }

        private void dataGridViewDogs_CellValueChanged(object sender, DataGridViewCellEventArgs e)
        {
            if (!editing) return;
            editing = false;
            dataGridViewDogs.Columns[1].ReadOnly = true;
            DialogResult dialogResult;
            dialogResult = MessageBox.Show("Сигурни ли сте, че искате да промените номера?", "Промяна на номера",MessageBoxButtons.YesNo,MessageBoxIcon.Question);
            if (dialogResult == DialogResult.Yes)
            {
                //INSERT
            }
            else
                dataGridViewDogs.CurrentCell.Value = currentCellText;

            

        }
    }
}
