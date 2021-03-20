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

        public DogsForm(List<Dog> dogsArg, Address addressArg): this(dogsArg)
        {
            address = addressArg;
        }

        //Показване на кучетата в списъка
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

        //Натискане на бутон "Изтрване"
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

        //Натискане на клетка с номер на куче, при кето тя става редактируема
        private void dataGridViewDogs_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (dataGridViewDogs.CurrentCell.ColumnIndex == 1)
            {
                dataGridViewDogs.Columns[1].ReadOnly = false;
                currentCellText = dataGridViewDogs.CurrentCell.Value.ToString();
                editing = true;
            }
        }

        //Избрана е отметката, оказваща че кучето няма номер
        private void checkBoxNoNumber_CheckedChanged(object sender, EventArgs e)
        {
            if (checkBoxNoNumber.Checked)
                textBoxDogName.Enabled = false;
            else
                textBoxDogName.Enabled = true;
        }

        //Валидация и добавяне на ново куче
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
            textBoxDogName.Text = "";

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

        //Премяна на номера на кучето
        private void dataGridViewDogs_CellValueChanged(object sender, DataGridViewCellEventArgs e)
        {
            Regex regex = new Regex(@"^\d{15}$");
            string newSealnumber;

            if (!editing) return;
            editing = false;
            dataGridViewDogs.Columns[1].ReadOnly = true;


            if (dataGridViewDogs.CurrentCell.Value == null )
            {
                newSealnumber = null;
                dataGridViewDogs.CurrentCell.Value = "няма";
            }
            else if (regex.IsMatch(dataGridViewDogs.CurrentCell.Value.ToString()))
            {
                newSealnumber = dataGridViewDogs.CurrentCell.Value.ToString();
            }
            else
            {
                MessageBox.Show("Невалидна стойност!", "Невалидна стойност", MessageBoxButtons.OK, MessageBoxIcon.Error);
                dataGridViewDogs.CurrentCell.Value = currentCellText;
                return;
            }

            DialogResult dialogResult;
            dialogResult = MessageBox.Show("Сигурни ли сте, че искате да промените номера?", "Промяна на номера", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (dialogResult == DialogResult.Yes)
            {
                dogs[dataGridViewDogs.CurrentCell.RowIndex].SealNumber = newSealnumber;
                if (address != null)
                {
                    dogs[dataGridViewDogs.CurrentCell.RowIndex].Update(connectionHelper);
                }
            }
            else
                dataGridViewDogs.CurrentCell.Value = currentCellText;

        }
    }
}
