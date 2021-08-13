using GraduationProject.Models;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using System.Linq;

namespace GraduationProject.UserControls.InsertData.Addresses
{
    public partial class InsertDataInhabitant : UserControl
    {
        InsertDataAddress.AddressData addressData;
        ListBoxUserControl selectedListBox;
        Inhabitant inhabitantToSave;
        [Browsable(true)]
        [Category("Action")]
        [Description("Invoked when button is clicked")]
        public event EventHandler ButtonClicked;

        public InsertDataInhabitant(InsertDataAddress.AddressData addrData)
        {
            InitializeComponent();
            labelAddress.Text = addrData.address.ToString();
            addressData = addrData;
            ShowInhabitants();


        }
        private void ShowInhabitants()
        {
            List<Inhabitant> residents = (from inhab in addressData.inhabitants where inhab.OwnershipState == Inhabitant.OwnershipStateEnum.Resident select inhab).ToList();
            List<Inhabitant> guests = (from inhab in addressData.inhabitants where inhab.OwnershipState == Inhabitant.OwnershipStateEnum.Guest select inhab).ToList();
            var ownerRes = (from inhab in addressData.inhabitants where inhab.OwnershipState == Inhabitant.OwnershipStateEnum.Guest select inhab);

            listBoxResidents.AddList(residents.Cast<object>().ToList());
            listBoxGuests.AddList(guests.Cast<object>().ToList());
            if (ownerRes.Count() != 0)
            {
                Inhabitant owner = ownerRes.First();
                labelOwnerFirstnameValue.Text = owner.Firstname;
                labelOwnerMiddlenameValue.Text = owner.Middlename;
                labelOwnerLastname.Text = owner.Lastname;
                labelOwnerMissing.Visible = false;
                labelOwnerFirstnameValue.Visible = true;
                labelOwnerMiddlenameValue.Visible = true;
                labelOwnerLastnameValue.Visible = true;
                labelOwnerFirstname.Visible = true;
                labelOwnerMiddlename.Visible = true;
                labelOwnerLastname.Visible = true;
                buttonEditOwner.Visible = true;
            }
            else
            {
                labelOwnerMissing.Visible = true;
                labelOwnerFirstnameValue.Visible = false;
                labelOwnerMiddlenameValue.Visible = false;
                labelOwnerLastnameValue.Visible = false;
                labelOwnerFirstname.Visible = false;
                labelOwnerMiddlename.Visible = false;
                labelOwnerLastname.Visible = false;
                buttonEditOwner.Visible = false;
            }
        }

        private void buttonSelectInhabitantsType_Click(object sender, EventArgs e)
        {
            Button button = (Button)sender;
            Button selectedButton, notSelectedButton;
            if (button == buttonResidents)
            {
                selectedButton = buttonResidents;
                notSelectedButton = buttonGuests;
                selectedListBox = listBoxResidents;
            }
            else
            {
                selectedButton = buttonGuests;
                notSelectedButton = buttonResidents;
                selectedListBox = listBoxGuests;
            }
            selectedListBox.BringToFront();

            notSelectedButton.BackColor = Color.FromArgb(170, 255, 255, 255);
            notSelectedButton.ForeColor = SystemColors.ControlText;

            selectedButton.BackColor = Color.FromArgb(70, 90, 30);
            selectedButton.ForeColor = SystemColors.Control;
        }

        private void buttonAddInhabitant_Click(object sender, EventArgs e)
        {
            inhabitantToSave = new Inhabitant();
            inhabitantToSave.InhabitantSaved += SaveInahbitant;
            inhabitantToSave.AddressId = addressData.address.Id;
            UserControls.InsertData.Addresses.InsertDataInhabitantEditCreate.InhabitantData inhabitantData;
            inhabitantData = new InsertDataInhabitantEditCreate.InhabitantData()
            {
                Inhabitant = inhabitantToSave,
                addressName = addressData.address.ToString()
            };
            ButtonClicked(new Forms.MainForm.EventData("inhabitantEditCreate", inhabitantData), e);
        }

        void SaveInahbitant(object sender, EventArgs eventArgs)
        {
            addressData.inhabitants.Add(inhabitantToSave);
            ShowInhabitants();
        }
    }
}
