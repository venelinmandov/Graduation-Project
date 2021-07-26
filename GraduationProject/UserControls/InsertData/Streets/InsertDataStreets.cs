using GraduationProject.Models;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Windows.Forms;

namespace GraduationProject.UserControls.InsertData.Streets
{
    public partial class InsertDataStreets : UserControl
    {
        List<Street> streets;
        ConnectionHelper connectionHelper = new ConnectionHelper();
        public InsertDataStreets()
        {
            InitializeComponent();
            panelShowStreets.BringToFront();
            labelErrorInsert.Visible = false;
            labelErrorRename.Visible = false;
            RefreshStreets();
        }

        private void buttonInsertNote_Click(object sender, System.EventArgs e)
        {
            panelInsertStreet.BringToFront();
        }

        private void buttonRenameStreet_Click(object sender, System.EventArgs e)
        {
            panelRenameStreet.BringToFront();
            labelTitleRenameStreet.Text = "Преименуване на улица " + streets[listBoxStreets.SelectedIndex].Name;
        }

        private void buttonInsertStreet_Click(object sender, System.EventArgs e)
        {
            if (textBoxStreetInsert.Text.Trim() == "")
            {
                labelErrorInsert.Visible = true;
                labelErrorInsert.Text = "Моля въведете име на улица.";
            }
            else if ((from str in streets where str.Name == textBoxStreetInsert.Text select str).Count() != 0)
            {
                labelErrorInsert.Visible = true;
                labelErrorInsert.Text = "Въведената улица съществува.";
            }
            else
            {
                labelErrorInsert.Visible = false;
                Street street = new Street()
                {
                    Name = textBoxStreetInsert.Text
                };
                street.Insert(connectionHelper);
                RefreshStreets();
                panelShowStreets.BringToFront();
            }

        }

        private void RefreshStreets()
        {
            streets = new Street().Get(connectionHelper);
            listBoxStreets.AddList(streets.Cast<object>().ToList());
        }

        private void InsertDataStreets_Load(object sender, System.EventArgs e)
        {

        }

        private void buttonUpdateStreet_Click(object sender, System.EventArgs e)
        {
            if (textBoxStreetRename.Text.Trim() == "")
            {
                labelErrorRename.Visible = true;
                labelErrorRename.Text = "Моля въведете име на улица.";
            }
            else if ((from str in streets where str.Name == textBoxStreetRename.Text select str).Count() != 0)
            {
                labelErrorRename.Visible = true;
                labelErrorRename.Text = "Въведената улица съществува.";

            }
            else
            {
                labelErrorRename.Visible = false;
                Street street = streets[listBoxStreets.SelectedIndex];
                street.Name = textBoxStreetRename.Text;
                street.Update(connectionHelper);
                RefreshStreets();
                panelShowStreets.BringToFront();
            }
        }
    }
}
