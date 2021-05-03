using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace GraduationProject.Forms
{
    public partial class InhabitantsFilterForm : Form
    {
        //Полета
        List<Models.Street> streets;
        ConnectionHelper connectionHelper = new ConnectionHelper();
        public List<Models.Person> guests = new List<Models.Person>();
        public List<Models.Resident> residents = new List<Models.Resident>();
        ErrorProvider errorProvider = new ErrorProvider();
        Panel selectedTab;
        string filter;

        //Свойства
        public string Filter { get => filter; }
        
        //Конструктор
        public InhabitantsFilterForm()
        {
            InitializeComponent();
            streets = new Models.Street().Get(connectionHelper);
            comboBoxStreet.Items.AddRange(streets.ToArray());
            selectedTab = panelSearchByAddress;
        }

        //Показване на панела за търсене по адрес
        private void buttonSearchByAddress_Click(object sender, EventArgs e)
        {
            panelSearchByAddress.BringToFront();
            selectedTab = panelSearchByAddress;
        }

        //Показване на панела за търсене по имена
        private void buttonSearchByNames_Click(object sender, EventArgs e)
        {
            panelSearchByNames.BringToFront();
            selectedTab = panelSearchByNames;
        }

        //Натискане на бутона "търсене" 
        private void buttonSearch_Click(object sender, EventArgs e)
        {
            if (selectedTab == panelSearchByAddress)
            {
                //Търсене по адрес
                if (comboBoxStreet.SelectedItem == null)
                {
                    errorProvider.SetError(comboBoxStreet, "Моля изберете улица!");
                }
                Models.Address address = new Models.Address().Get(connectionHelper, streets[comboBoxStreet.SelectedIndex].Id, (int)numericUpDownNumber.Value);
                if (address == null)
                {
                    MessageBox.Show("Няма такъв адрес!", "Няма такъв адрес!", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    return;
                }
                guests = new Models.Person().Get(connectionHelper, address);
                residents = new Models.Resident().Get(connectionHelper, address);
                filter = $"По адрес: {comboBoxStreet.Text} {numericUpDownNumber.Value}";
            }
            if (selectedTab == panelSearchByNames)
            {
                //Търсене по имена
                if (textBoxFirstname.Text.Trim() == "" && textBoxMiddlename.Text.Trim() == "" && textBoxLastname.Text.Trim() == "")
                {
                    errorProvider.SetError(textBoxFirstname, "Моля въведете поне едно от трите имена");
                    errorProvider.SetError(textBoxMiddlename, "Моля въведете поне едно от трите имена");
                    errorProvider.SetError(textBoxLastname, "Моля въведете поне едно от трите имена");
                    return;
                }
                filter = "По име/имена: ";
                if (textBoxFirstname.Text.Trim() != "")
                    filter += "Име: " + textBoxFirstname.Text;
                if (textBoxMiddlename.Text.Trim() != "")
                    filter += " Презиме: " + textBoxMiddlename.Text;
                if (textBoxLastname.Text.Trim() != "")
                    filter += " Фамилия: " + textBoxLastname.Text;
                if (radioButtonGuest.Checked)
                {
                    residents = new List<Models.Resident>();
                    guests = new Models.Person().Get(connectionHelper, textBoxFirstname.Text.Trim(), textBoxMiddlename.Text.Trim(), textBoxLastname.Text.Trim());
                    filter += " - гости в карантина";
                }

                else if (radioButtonResident.Checked)
                {
                    residents = new Models.Resident().Get(connectionHelper, textBoxFirstname.Text.Trim(), textBoxMiddlename.Text.Trim(), textBoxLastname.Text.Trim());
                    guests = new List<Models.Person>();
                    filter += " - жители";


                }
                else if (radioButtonAll.Checked)
                {
                    residents = new Models.Resident().Get(connectionHelper, textBoxFirstname.Text.Trim(), textBoxMiddlename.Text.Trim(), textBoxLastname.Text.Trim());
                    guests = new Models.Person().Get(connectionHelper, textBoxFirstname.Text.Trim(), textBoxMiddlename.Text.Trim(), textBoxLastname.Text.Trim());
                    filter += " - жители, гости в карантина";

                }
                else
                {
                    errorProvider.SetError(groupBox, "Моля изберете опция!");
                    return;
                }
            }
            errorProvider.Clear();
            Hide();
        }
    }
}
