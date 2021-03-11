using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace GraduationProject.Forms
{
    public partial class DogsForm : Form
    {
        List<Models.Dog> dogs;
        public DogsForm(List<Models.Dog> dogsArg)
        {
            InitializeComponent();
            dogs = dogsArg;
            ShowDogs();
        }

        void ShowDogs()
        {
            for (int i = 0; i < dogs.Count; i++)
            {
                dataGridViewDogs.RowCount++;
                dataGridViewDogs.Rows[dataGridViewDogs.RowCount - 1].Cells[0].Value = i + 1;
                dataGridViewDogs.Rows[dataGridViewDogs.RowCount - 1].Cells[1].Value = dogs[i].SealNumber != null ? dogs[i].SealNumber : "Няма";
            }
        }

        private void DogsForm_Load(object sender, EventArgs e)
        {

        }
    }
}
