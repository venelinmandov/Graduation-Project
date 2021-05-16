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
            SetActiveTab(panelSearchByAddress, buttonSearchByAddress);
        }

        //Показване на панела за търсене по адрес
        private void buttonSearchByAddress_Click(object sender, EventArgs e)
        {
            SetActiveTab(panelSearchByAddress,(Button)sender);
        }

        //Показване на панела за търсене по имена
        private void buttonSearchByNames_Click(object sender, EventArgs e)
        {
            SetActiveTab(panelSearchByNames, (Button)sender);
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


        //Показване на избран панел
        void SetActiveTab(Panel panel, Button button)
        {
            panel.BringToFront();
            selectedTab = panel;
            Button[] buttons = new Button[] { buttonSearchByAddress, buttonSearchByNames };
            foreach (Button otherButton in buttons)
            {
                otherButton.FlatAppearance.BorderSize = 0;
                otherButton.BackColor = SystemColors.ButtonFace;
            }
            button.FlatAppearance.BorderSize = 1;
            button.BackColor = SystemColors.ButtonHighlight;
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

        private void InhabitantsFilterForm_Load(object sender, EventArgs e)
        {

        }
    }
}
