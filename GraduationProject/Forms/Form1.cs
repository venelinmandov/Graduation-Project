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
        public Form1()
        {
            InitializeComponent();
            comboBoxCriteria.DataSource = new string[] {"Улица", "Жител" };

            listBoxAddresses.DataSource = Address.GetAddresses(connectionHelper);
            showStreets();
        }

        void showStreets()
        {
            if (textBoxSearchStr.Text != "")
                listBoxStreets.DataSource = Street.GetStreets(textBoxSearchStr.Text, connectionHelper);
            else
                listBoxStreets.DataSource = Street.GetStreets(connectionHelper);
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

        private void tabControl1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {
            showStreets();
        }

        private void buttonAddResident_Click(object sender, EventArgs e)
        {
            Forms.PersonsForm personsForm = new Forms.PersonsForm(new Address());
            personsForm.ShowDialog();

        }

        private void buttonSearch_Click(object sender, EventArgs e)
        {

        }
    }
}
