using GraduationProject.Models;
using System;
using System.Collections.Generic;
using System.Drawing;
using System.Windows.Forms;

namespace GraduationProject.Forms
{
    public partial class ReferenceForm : Form
    {
        //Полета
        ConnectionHelper connectionHelper = new ConnectionHelper();
        AddressesFiltersForm addressesFilterForm = new AddressesFiltersForm();
        InhabitantsFilterForm inhabitantsFilterForm = new InhabitantsFilterForm();
        Panel selectedTab;

        Dictionary<Address.AddressHabitability, string> habitabillity = new Dictionary<Address.AddressHabitability, string>(){
            { Address.AddressHabitability.Desolate, "Пустеещ" } ,
            { Address.AddressHabitability.Inhabited, "Обитаван" },
            { Address.AddressHabitability.TemporaryInhabited, "Временно обитаван" }};

        Dictionary<int, string> gender = new Dictionary<int, string>(){
            { 0, "Мъж" } ,
            { 1, "Жена" }};

        Dictionary<Person.QuarantineEnum, string> quarantine = new Dictionary<Person.QuarantineEnum, string>(){
            { Person.QuarantineEnum.No, "Няма" } ,
            { Person.QuarantineEnum.Yes, "Има" },
            { Person.QuarantineEnum.Contact, "Контактен" }};

        Dictionary<Inhabitant.AddressRegistrationEnum, string> addressRegistration = new Dictionary<Inhabitant.AddressRegistrationEnum, string>(){
            { Inhabitant.AddressRegistrationEnum.No, "Няма" } ,
            { Inhabitant.AddressRegistrationEnum.Current, "Настоящ адрес" },
            { Inhabitant.AddressRegistrationEnum.Permanent, "Постоянен адрес" }};


        //Конструктор
        public ReferenceForm()
        {
            InitializeComponent();
            SetActiveTab(tabAddresses,buttonAddresses);

            foreach (Control control in Controls)
            {
                control.Enter += (object sender, EventArgs e) => this.ActiveControl = null;
            }
        }

        #region Адреси

        //Показване на панела за търсене на адреси
        private void buttonAddresses_Click(object sender, EventArgs e)
        {
            SetActiveTab(tabAddresses, (Button)sender);
        }

        //Отваряне на формата за избор на филтър при тъсене на адреси
        private void buttonFiltersAddresses_Click(object sender, EventArgs e)
        {
            addressesFilterForm.ShowDialog();
            ShowAddresses(addressesFilterForm.Addresses);
            labelCriteriaAddresses.Text = addressesFilterForm.Filter;
        }

        //Показване на адресите в таблицата
        void ShowAddresses(List<Models.Address> addresses)
        {
            dataGridViewAddresses.RowCount = 0;
            for (int i = 0; i < addresses.Count; i++)
            {
                dataGridViewAddresses.RowCount++;
                dataGridViewAddresses.Rows[dataGridViewAddresses.RowCount - 1].Cells[0].Value = "Обитатели";
                ((DataGridViewButtonCell)dataGridViewAddresses.Rows[dataGridViewAddresses.RowCount - 1].Cells[0]).FlatStyle = FlatStyle.Flat;
                ((DataGridViewButtonCell)dataGridViewAddresses.Rows[dataGridViewAddresses.RowCount - 1].Cells[0]).Style.BackColor = SystemColors.ButtonFace;

                dataGridViewAddresses.Rows[dataGridViewAddresses.RowCount - 1].Cells[1].Value = addresses[i].streetName;
                dataGridViewAddresses.Rows[dataGridViewAddresses.RowCount - 1].Cells[2].Value = addresses[i].Number;
                dataGridViewAddresses.Rows[dataGridViewAddresses.RowCount - 1].Cells[3].Value = addresses[i].Squaring;
                dataGridViewAddresses.Rows[dataGridViewAddresses.RowCount - 1].Cells[4].Value = habitabillity[addresses[i].Habitallity];
                dataGridViewAddresses.Rows[dataGridViewAddresses.RowCount - 1].Cells[5].Value = addresses[i].NumResBuildings;
                dataGridViewAddresses.Rows[dataGridViewAddresses.RowCount - 1].Cells[6].Value = addresses[i].NumAgrBuildings;
                dataGridViewAddresses.Rows[dataGridViewAddresses.RowCount - 1].Cells[7].Value = addresses[i].NumCows;
                dataGridViewAddresses.Rows[dataGridViewAddresses.RowCount - 1].Cells[8].Value = addresses[i].NumSheep;
                dataGridViewAddresses.Rows[dataGridViewAddresses.RowCount - 1].Cells[9].Value = addresses[i].NumGoats;
                dataGridViewAddresses.Rows[dataGridViewAddresses.RowCount - 1].Cells[10].Value = addresses[i].NumHorses;
                dataGridViewAddresses.Rows[dataGridViewAddresses.RowCount - 1].Cells[11].Value = addresses[i].NumDonkeys;
                dataGridViewAddresses.Rows[dataGridViewAddresses.RowCount - 1].Cells[12].Value = addresses[i].NumFeathered;
                dataGridViewAddresses.Rows[dataGridViewAddresses.RowCount - 1].Cells[13].Value = addresses[i].NumPigs;
                dataGridViewAddresses.Rows[dataGridViewAddresses.RowCount - 1].Cells[14].Value = addresses[i].NumWalnutTrees;
               
            }
        }
        #endregion
        #region Обитатели
        //Показване на панела за търсене на обитатели
        private void buttonInhabitants_Click(object sender, EventArgs e)
        {
            SetActiveTab(tabInhabitants, (Button)sender);
        }

        //Отваряне на формата за избор на филтър при тъсене на обитатели
        private void buttonFiltersInhabitants_Click(object sender, EventArgs e)
        {
            inhabitantsFilterForm.ShowDialog();
            ShowInhabitants(inhabitantsFilterForm.residents, inhabitantsFilterForm.guests);
            labelCriteriaInhabitants.Text = inhabitantsFilterForm.Filter;
        }

        //Показване на обитателите в таблицата
        void ShowInhabitants(List<Models.Inhabitant> residents, List<Models.Person> guests)
        {
            dataGridViewInhabitants.RowCount = 0;

            //Жители
            for (int i = 0; i < residents.Count; i++)
            {
                dataGridViewInhabitants.RowCount++;
                dataGridViewInhabitants.Rows[dataGridViewInhabitants.RowCount - 1].Cells[0].Value = residents[i].Firstname;
                dataGridViewInhabitants.Rows[dataGridViewInhabitants.RowCount - 1].Cells[1].Value = residents[i].Middlename;
                dataGridViewInhabitants.Rows[dataGridViewInhabitants.RowCount - 1].Cells[2].Value = residents[i].Lastname;
                dataGridViewInhabitants.Rows[dataGridViewInhabitants.RowCount - 1].Cells[3].Value = gender[residents[i].Gender];
                dataGridViewInhabitants.Rows[dataGridViewInhabitants.RowCount - 1].Cells[4].Value = new Models.Address().Get(connectionHelper, residents[i].AddressId);
                int currentAddress = residents[i].CurrentAddressId;
                if (currentAddress == -1)
                    dataGridViewInhabitants.Rows[dataGridViewInhabitants.RowCount - 1].Cells[5].Value = "";
                else
                    dataGridViewInhabitants.Rows[dataGridViewInhabitants.RowCount - 1].Cells[5].Value = new Models.Address().Get(connectionHelper, residents[i].CurrentAddressId);
                dataGridViewInhabitants.Rows[dataGridViewInhabitants.RowCount - 1].Cells[6].Value = residents[i].RelToOwner;
                dataGridViewInhabitants.Rows[dataGridViewInhabitants.RowCount - 1].Cells[7].Value = "Жител";
                dataGridViewInhabitants.Rows[dataGridViewInhabitants.RowCount - 1].Cells[8].Value = addressRegistration[residents[i].AddressReg];
                //dataGridViewInhabitants.Rows[dataGridViewInhabitants.RowCount - 1].Cells[9].Value = quarantine[residents[i].Quarantine];
                dataGridViewInhabitants.Rows[dataGridViewInhabitants.RowCount - 1].Cells[10].Value = residents[i].Note;

            }

            //Гости в карантина
            for (int i = 0; i < guests.Count; i++)
            {
                dataGridViewInhabitants.RowCount++;
                dataGridViewInhabitants.Rows[dataGridViewInhabitants.RowCount - 1].Cells[0].Value = guests[i].Firstname;
                dataGridViewInhabitants.Rows[dataGridViewInhabitants.RowCount - 1].Cells[1].Value = guests[i].Middlename;
                dataGridViewInhabitants.Rows[dataGridViewInhabitants.RowCount - 1].Cells[2].Value = guests[i].Lastname;
                dataGridViewInhabitants.Rows[dataGridViewInhabitants.RowCount - 1].Cells[3].Value = gender[guests[i].Gender];
                dataGridViewInhabitants.Rows[dataGridViewInhabitants.RowCount - 1].Cells[4].Value = new Models.Address().Get(connectionHelper, guests[i].AddressId);
                int currentAddress = guests[i].CurrentAddressId;
                if (currentAddress == -1)
                    dataGridViewInhabitants.Rows[dataGridViewInhabitants.RowCount - 1].Cells[5].Value = "";
                else
                    dataGridViewInhabitants.Rows[dataGridViewInhabitants.RowCount - 1].Cells[5].Value = new Models.Address().Get(connectionHelper, guests[i].CurrentAddressId);
                dataGridViewInhabitants.Rows[dataGridViewInhabitants.RowCount - 1].Cells[6].Value = guests[i].RelToOwner;
                dataGridViewInhabitants.Rows[dataGridViewInhabitants.RowCount - 1].Cells[7].Value = "Гост в карантина";
                dataGridViewInhabitants.Rows[dataGridViewInhabitants.RowCount - 1].Cells[8].Value = guests[i].Note;

            }
        }
#endregion

        //Показване на обитателите на избран адрес
        private void dataGridViewAddresses_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            var senderGrid = (DataGridView)sender;

            if (senderGrid.Columns[e.ColumnIndex] is DataGridViewButtonColumn &&
                e.RowIndex >= 0)
            {
                List<Models.Inhabitant> residents = new Models.Inhabitant().Get(connectionHelper, addressesFilterForm.Addresses[e.RowIndex]);
                List<Models.Person> persons = new Models.Person().Get(connectionHelper, addressesFilterForm.Addresses[e.RowIndex]);
                labelCriteriaInhabitants.Text = $"По адрес: {addressesFilterForm.Addresses[e.RowIndex].streetName} {addressesFilterForm.Addresses[e.RowIndex].Number}";
                ShowInhabitants(residents,persons);
                selectedTab = tabInhabitants;
                tabInhabitants.BringToFront();
            }
        }

        //Показване на избрания таб
        void SetActiveTab(Panel panel, Button button)
        {
            panel.BringToFront();
            selectedTab = panel;
            buttonAddresses.FlatAppearance.BorderSize = 0;
            buttonAddresses.BackColor = SystemColors.ButtonFace;
            buttonInhabitants.FlatAppearance.BorderSize = 0;
            buttonInhabitants.BackColor = SystemColors.ButtonFace;
            button.FlatAppearance.BorderSize = 1;
            button.BackColor = SystemColors.ButtonHighlight;

        }
        
    }
}
