using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace GraduationProject
{
    public partial class MenuForm : Form
    {
        public MenuForm()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Hide();
            new InsertDataForm().ShowDialog();
            Show();
            
        }

        private void buttonAddPerson_Click(object sender, EventArgs e)
        {
            Hide();
            new Forms.ReferenceFormMain().ShowDialog();
            Show();
        }
    }
}
