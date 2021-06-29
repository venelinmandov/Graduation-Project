using GraduationProject.Models;
using System;
using System.Collections.Generic;
using System.Windows.Forms;
using System.Linq;

namespace GraduationProject.UserControls.InsertData.Addresses
{
    public partial class InsertDataAddress : UserControl
    {
        Address address;
        List<Address> addresses;
        List<Street> streets;
        ConnectionHelper connectionHelper = new ConnectionHelper();

        public InsertDataAddress(Address address)
        {
            InitializeComponent();
            this.address = address;
            LoadStreets();
            buttonSave.Visible = true;
            numericUpDownNumber.Visible = true;
            comboBoxNumber.Visible = false;
            labelTitle.Text = "Нов адрес";
        }
        public InsertDataAddress()
        {
            InitializeComponent();
            LoadStreets();
            buttonSave.Visible = false;
            numericUpDownNumber.Visible = false;
            comboBoxNumber.Visible = true;
            labelTitle.Text = "Редактиране на адрес";
        }

        void LoadStreets()
        {
            streets = new Street().Get(connectionHelper);
            comboBoxStreet.Items.AddRange(streets.ToArray());
            comboBoxStreet.SelectedIndex = 0;
        }

        void CheckAddressExist()
        {
            var addresssesToCheck = from address in addresses
                                    where address.StreetId == streets[comboBoxStreet.SelectedIndex].Id && address.Number == numericUpDownNumber.Value
                                    select address;
            if (addresssesToCheck.Count() != 0)
            {
                labelAddressExists.Visible = true;
                buttonInhabitants.Enabled = false;
                buttonProperty.Enabled = false;
                buttonSave.Enabled = false;
            }
            else
            {
                labelAddressExists.Visible = false;
                buttonInhabitants.Enabled = true;
                buttonProperty.Enabled = true;
                buttonSave.Enabled = true;
            }
        }


        private void comboBoxStreet_SelectedIndexChanged(object sender, EventArgs e)
        {
            comboBoxNumber.Items.Clear();
            addresses = new Address().Get(connectionHelper, streets[comboBoxStreet.SelectedIndex]);
            if (addresses.Count > 0)
            {
                foreach (Address address in addresses)
                {
                    comboBoxNumber.Items.Add(address.Number);

                }
                comboBoxNumber.SelectedIndex = 0;
            }
            else
            {
                comboBoxNumber.Text = "";
            }
            CheckAddressExist();
        }

        private void numericUpDownNumber_ValueChanged(object sender, EventArgs e)
        {
            CheckAddressExist();
        }
    }
}
