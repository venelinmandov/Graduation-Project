using GraduationProject.Models;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Linq;
using System.Windows.Forms;

namespace GraduationProject.UserControls.InsertData.Addresses
{
    public partial class InsertDataAddress : UserControl
    {
        AddressData addressData;
        List<Address> addresses;
        List<Street> streets;
        ConnectionHelper connectionHelper = new ConnectionHelper();
        string mode;

        [Browsable(true)]
        [Category("Action")]
        [Description("Invoked when button is clicked")]
        public event EventHandler ButtonClicked;


        public InsertDataAddress(AddressData addressData)
        {
            InitializeComponent();
            mode = "create";
            this.addressData = addressData;
            LoadStreets();
            buttonSave.Visible = true;
            numericUpDownNumber.Visible = true;
            comboBoxNumber.Visible = false;
            labelTitle.Text = "Нов адрес";
        }
        public InsertDataAddress()
        {
            InitializeComponent();
            mode = "edit";
            LoadStreets();
            buttonSave.Visible = false;
            numericUpDownNumber.Visible = false;
            comboBoxNumber.Visible = true;
            labelTitle.Text = "Редактиране на адрес";
        }

        public struct AddressData
        {
            public Address address;
            public List<Inhabitant> inhabitants;
            public List<Dog> dogs;

            public void Intialize()
            {
                address = new Address();
                inhabitants = new List<Inhabitant>();
                dogs = new List<Dog>();
            }
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
            ShowAddresses();
        }

        private void ShowAddresses()
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
            if (mode == "create")
            {
                addressData.address.StreetId = streets[comboBoxStreet.SelectedIndex].Id;
                addressData.address.streetName = streets[comboBoxStreet.SelectedIndex].Name;
                CheckAddressExist();
            }
        }

        private void numericUpDownNumber_ValueChanged(object sender, EventArgs e)
        {
            if (mode == "create")
            {
                addressData.address.Number = (int)numericUpDownNumber.Value;
                CheckAddressExist();
            }
        }

        private void buttonProperty_Click(object sender, EventArgs e)
        {
            ButtonClicked(new Forms.MainForm.EventData("propertyData", addressData), e);
        }

        private void comboBoxStreet_DrawItem(object sender, DrawItemEventArgs e)
        {
            if (e.Index == -1) return;
            var combo = sender as ComboBox;
            SolidBrush solidBrush;
            if ((e.State & DrawItemState.Selected) == DrawItemState.Selected)
            {
                e.Graphics.FillRectangle(new SolidBrush(Color.FromArgb(50, 80, 40)), e.Bounds);
                solidBrush = new SolidBrush(SystemColors.Control);
            }
            else
            {
                e.Graphics.FillRectangle(new SolidBrush(SystemColors.Window), e.Bounds);
                solidBrush = new SolidBrush(Color.Black);
            }

            e.Graphics.DrawString(combo.Items[e.Index].ToString(),
                                          e.Font,
                                          solidBrush,
                                          new Point(e.Bounds.X, e.Bounds.Y));
        }

        private void buttonSave_Click(object sender, EventArgs e)
        {
            addressData.address.Insert(connectionHelper);
            foreach (Dog dog in addressData.dogs)
            {
                dog.AddressId = addressData.address.Id;
                dog.Insert(connectionHelper);
            }
            ShowAddresses();
        }
    }
}
