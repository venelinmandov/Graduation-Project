using GraduationProject.Models;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Windows.Forms;
using System.Linq;
using GraduationProject.Modules;

namespace GraduationProject.UserControls.InsertData.Addresses
{
    public partial class InsertDataInhabitant : UserControl
    {
        InsertDataAddress.AddressData addressData;
        List<Inhabitant> residents;
        List<Inhabitant> guests;
        Inhabitant owner;
        ListBoxUserControl selectedListBox;
        Inhabitant inhabitantToCreate;
        [Browsable(true)]
        [Category("Action")]
        [Description("Invoked when button is clicked")]
        public event EventHandler ButtonClicked;

        //Конструктор
        public InsertDataInhabitant(InsertDataAddress.AddressData addrData)
        {
            InitializeComponent();
            labelAddress.Text = addrData.address.ToString();
            addressData = addrData;
            ShowInhabitants();
        }

        /// <summary>
        /// Показване на всички обитатели на имота
        /// </summary>
        private void ShowInhabitants()
        {
            owner = null;
            guests = new List<Inhabitant>();
            residents = new List<Inhabitant>();
            foreach (Inhabitant inhabitant in addressData.inhabitants)
            {
                inhabitant.InhabitantUpdated += InhabitantUpdated;

                if      (inhabitant.OwnershipState == Inhabitant.OwnershipStateEnum.Guest) guests.Add(inhabitant);
                else if (inhabitant.OwnershipState == Inhabitant.OwnershipStateEnum.Resident) residents.Add(inhabitant);
                else if (inhabitant.OwnershipState == Inhabitant.OwnershipStateEnum.Owner) owner = inhabitant;
            }

            listBoxResidents.AddList(residents.Cast<object>().ToList());
            listBoxGuests.AddList(guests.Cast<object>().ToList());
            selectedListBox = listBoxResidents;

            if (owner != null)
            {
                labelOwnerFirstnameValue.Text = owner.Firstname;
                labelOwnerMiddlenameValue.Text = owner.Middlename;
                labelOwnerLastnameValue.Text = owner.Lastname;
                labelOwnerMissing.Visible = false;
                labelOwnerFirstnameValue.Visible = true;
                labelOwnerMiddlenameValue.Visible = true;
                labelOwnerLastnameValue.Visible = true;
                labelOwnerFirstname.Visible = true;
                labelOwnerMiddlename.Visible = true;
                labelOwnerLastname.Visible = true;
                buttonEditOwner.Visible = true;
                buttonDeleteOwner.Visible = true;
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
                buttonDeleteOwner.Visible = false;
            }
        }

        /// <summary>
        /// Избран не бутон за показване на обитателите от една от групите: членове на семейството или гости.
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
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

        /// <summary>
        /// Добавяне на обитател
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void buttonAddInhabitant_Click(object sender, EventArgs e)
        {
            inhabitantToCreate = new Inhabitant();
            inhabitantToCreate.InhabitantSaved += InhabitantSaved;
            inhabitantToCreate.InhabitantUpdated += InhabitantUpdated;
            inhabitantToCreate.AddressId = addressData.address.Id;
            InsertDataInhabitantEditCreate.InhabitantData inhabitantData;
            inhabitantData = new InsertDataInhabitantEditCreate.InhabitantData()
            {
                inhabitant = inhabitantToCreate,
                address = addressData.address,
                addressHasOwner = owner != null && inhabitantToCreate != owner
            };
            ButtonClicked(new Forms.MainForm.EventData("inhabitantEditCreate", inhabitantData), e);
        }

        /// <summary>
        /// Нововъведеният обитател е запазен в базата данни
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="eventArgs"></param>
        void InhabitantSaved(object sender, EventArgs eventArgs)
        {
            addressData.inhabitants.Add(inhabitantToCreate);
            ShowInhabitants();
        }

        /// <summary>
        /// Обитател е редактиран
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="eventArgs"></param>
        void InhabitantUpdated(object sender, EventArgs eventArgs)
        {
            ShowInhabitants();
        }

        /// <summary>
        /// Редактиране на обитател
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void buttonEditInhabitant_Click(object sender, EventArgs e)
        {
            InsertDataInhabitantEditCreate.InhabitantData inhabitantData;
            Inhabitant inhabitantToEdit;
            if (selectedListBox == listBoxResidents)
            {
                inhabitantToEdit = residents[selectedListBox.SelectedIndex];
            }
            else
            {
                inhabitantToEdit = guests[selectedListBox.SelectedIndex];
            }

            inhabitantData = new InsertDataInhabitantEditCreate.InhabitantData()
            {
                inhabitant = inhabitantToEdit,
                address = addressData.address,
                addressHasOwner = owner != null && inhabitantToEdit != owner
            };
            ButtonClicked(new Forms.MainForm.EventData("inhabitantEditCreate", inhabitantData), e);
        }

        /// <summary>
        /// Редактиране на собтвеника
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void buttonEditOwner_Click(object sender, EventArgs e)
        {
            InsertDataInhabitantEditCreate.InhabitantData inhabitantData;
            inhabitantData = new InsertDataInhabitantEditCreate.InhabitantData()
            {
                inhabitant = owner,
                address = addressData.address,
                addressHasOwner = false
            };
            ButtonClicked(new Forms.MainForm.EventData("inhabitantEditCreate", inhabitantData), e);

        }

        /// <summary>
        /// Изтриване на обитател
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void buttonDelete_Click(object sender, EventArgs e)
        {
            Inhabitant inhabitantToDelete;
            DialogResult result = CustomMessageBox.Show("Сигурни ли сте, че искате да изтриете информацията за този обитател?", "Изтриване на обитател", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (result == DialogResult.Yes)
            {
                if (selectedListBox == listBoxResidents)
                {
                    inhabitantToDelete = residents[selectedListBox.SelectedIndex];
                }
                else
                {
                    inhabitantToDelete = guests[selectedListBox.SelectedIndex];
                }

                inhabitantToDelete.Delete(new ConnectionHelper());
                addressData.inhabitants.Remove(inhabitantToDelete);
                ShowInhabitants();
            }    

        }

        /// <summary>
        /// Изтриване на собственика
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void buttonDeleteOwner_Click(object sender, EventArgs e)
        {
            DialogResult result = CustomMessageBox.Show("Сигурни ли сте, че искате да изтриете информацията за този обитател?", "Изтриване на обитател", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (result == DialogResult.Yes)
            {
                owner.Delete(new ConnectionHelper());
                addressData.inhabitants.Remove(owner);
                ShowInhabitants();
            }
        }
    }
}
