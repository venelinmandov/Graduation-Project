using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using GraduationProject.Models;


namespace GraduationProject.Forms
{
    public partial class StreetsForm : Form
    {

        List<Street> streets;
        ConnectionHelper connectionHelper = new ConnectionHelper();
        public StreetsForm()
        {
            InitializeComponent();

        }

        void ShowStreets()
        {
            streets = Street.GetStreets(connectionHelper);
            listBoxStreets.DataSource = streets;
        }

        private void AddressForm_Load(object sender, EventArgs e)
        {
            ShowStreets();
        }

        private void labelTitle21_Click(object sender, EventArgs e)
        {

        }

        private void titleLabelcs1_Load(object sender, EventArgs e)
        {

        }

       
        private void buttonAddSt_Click(object sender, EventArgs e)
        {
            string name = InputBox.OpenInputBox();
            if (name != "")
            {
                Street street = new Street();
                street.name = name;
                street.InsertStreet(connectionHelper);
                ShowStreets();
            }
            
            
        }

        private void buttonRemoveSt_Click(object sender, EventArgs e)
        {
            streets[listBoxStreets.SelectedIndex].DeleteStreet(connectionHelper);
            ShowStreets();
        }
    }
}
