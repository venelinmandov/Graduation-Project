using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace GraduationProject.Forms
{
    public partial class AddressesFiltersForm : Form
    {
        //Полета
        Panel selectedTab;
        List<Models.Address> addresses = new List<Models.Address>();
        ConnectionHelper connectionHelper = new ConnectionHelper();
        ErrorProvider ErrorProvider = new ErrorProvider();
        List<Models.Street> streets;
        string filter;

        Dictionary<string, string> animals = new Dictionary<string, string>(){
            { "Крави", "numCows"},
            { "Овце", "numSheep"},
            { "Кози", "numGoats"},
            { "Коне", "numHorses"},
            { "Магарета", "numDonkeys"},
            { "Пернати", "numFeathered"},
            { "Свине", "numPigs" }
        };

        //Свойства    
        public List <Models.Address> Addresses { get => addresses; }
        public string Filter { get => filter; }

        //Конструктор
        public AddressesFiltersForm()
        {
            InitializeComponent();
            selectedTab = panelSearchByInhabitant;
            streets = new Models.Street().Get(connectionHelper);
            comboBoxStreets.Items.AddRange(streets.ToArray());
        }

        //Показване на панела за търсене по обитатели
        private void buttonSearchByInhabitant_Click(object sender, EventArgs e)
        {
            ShowPanel(panelSearchByInhabitant, (Button)sender);
        }

        //Показване на панела за търсене по добитък
        private void buttonSearchByAnimals_Click(object sender, EventArgs e)
        {
            ShowPanel(panelSearchByAnimal, (Button)sender);
        }

        //Показване на панела за търсене по улица
        private void buttonSearchByStreet_Click(object sender, EventArgs e)
        {
            ShowPanel(panelSearchByStreet, (Button)sender);
        }

        //Натискане на бутона "Търсене"
        private void buttonSearch_Click(object sender, EventArgs e)
        {
            
            if (selectedTab == panelSearchByInhabitant)
            {
                //Тъесене по обитател
                int option = getSelectedOption(radioButtonResident, radioButtonGuest, radioButtonAll);
                if (option == -1)
                {
                    ErrorProvider.SetError(groupBoxPersons, "Моля изберете опция!");
                    return;
                }
                if (textBoxFirstname.Text.Trim() == "" && textBoxMiddlename.Text.Trim() == "" && textBoxLastname.Text.Trim() == "")
                {
                    ErrorProvider.SetError(textBoxFirstname, "Моля въведете поне едно от трите имена!");
                    ErrorProvider.SetError(textBoxMiddlename, "Моля въведете поне едно от трите имена!");
                    ErrorProvider.SetError(textBoxLastname, "Моля въведете поне едно от трите имена!");
                    return;
                }
                filter = "По обитател: ";
                if (textBoxFirstname.Text.Trim() != "")
                    filter += "Име: " + textBoxFirstname.Text;
                if (textBoxMiddlename.Text.Trim() != "")
                    filter += " Презиме: " + textBoxMiddlename.Text;
                if (textBoxLastname.Text.Trim() != "")
                    filter += " Фамилия: " + textBoxLastname.Text;
                addresses = new Models.Address().Get(connectionHelper, option, textBoxFirstname.Text, textBoxMiddlename.Text, textBoxLastname.Text);
            }
            else if (selectedTab == panelSearchByAnimal)
            {
                //Търсене по добитък
                if (comboBoxAnimals.SelectedItem == null)
                {
                    ErrorProvider.SetError(comboBoxAnimals, "Моля изберете добитък!");
                    return;
                }
                filter = "По добитък: " + comboBoxAnimals.SelectedItem.ToString();
                addresses = new Models.Address().Get(connectionHelper, animals[comboBoxAnimals.Text]);
            }
            else if (selectedTab == panelSearchByStreet)
            {
                //Търсене по улица 
                if (comboBoxStreets.SelectedItem == null)
                {
                    ErrorProvider.SetError(comboBoxStreets, "Моля изберете улица!");
                    return;
                }
                filter = "По улица: " + comboBoxStreets.SelectedItem.ToString();
                addresses = new Models.Address().Get(connectionHelper, streets[comboBoxStreets.SelectedIndex]);
            }
            ErrorProvider.Clear();
            this.Hide();
        }

        //Връща номера на избрания радиобутон 
        int getSelectedOption(params RadioButton[] radioButtons)
        {
            for (int i = 0; i < radioButtons.Length; i++)
            {
                if (radioButtons[i].Checked)
                    return i;
            }
            return -1;
        }

        //Показване на избран панел
        void ShowPanel(Panel panel, Button button)
        {
            panel.BringToFront();
            selectedTab = panel;
            buttonSearchByInhabitant.BackColor = SystemColors.ButtonFace;
            buttonSearchByAnimals.BackColor = SystemColors.ButtonFace;
            buttonSearchByStreet.BackColor = SystemColors.ButtonFace;
            button.BackColor = Color.White;
        }

        //Изчертаване на елемент на коммбобокс
        private void comboBox_DrawItem(object sender, DrawItemEventArgs e)
        {
            var combo = sender as ComboBox;
            SolidBrush solidBrush;
            if ((e.State & DrawItemState.Selected) == DrawItemState.Selected)
            {
                e.Graphics.FillRectangle(new SolidBrush(Color.FromArgb(0, 79, 33)), e.Bounds);
                solidBrush = new SolidBrush(Color.White);
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
    }
}
