using GraduationProject.Models;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Windows.Forms;
using GraduationProject.Modules;

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

        /// <summary>
        /// Показване на панела за преименуване на улица
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void buttonShowInsertStreet_Click(object sender, System.EventArgs e)
        {
            textBoxStreetInsert.Text = "";
            panelInsertStreet.BringToFront();
        }

        /// <summary>
        /// Преименуване на улица
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void buttonRenameStreet_Click(object sender, System.EventArgs e)
        {
            textBoxStreetRename.Text = "";
            panelRenameStreet.BringToFront();
            labelTitleRenameStreet.Text = "Преименуване на улица " + streets[listBoxStreets.SelectedIndex].Name;
        }

        /// <summary>
        /// Добавяне на улица
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
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

        /// <summary>
        /// Обновяване на списъка с улици
        /// </summary>
        private void RefreshStreets()
        {
            streets = new Street().Get(connectionHelper);
            listBoxStreets.AddList(streets.Cast<object>().ToList());
        }


        /// <summary>
        /// Преименуване на улица
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
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


        /// <summary>
        /// Изтриване на улица
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void buttonDeleteStreet_Click(object sender, System.EventArgs e)
        {
            
            DialogResult result = CustomMessageBox.Show("Сигурни ли сте че искате да изтриете улицата?", "Изтриване на улица", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (result == DialogResult.Yes)
            {
                Street street = streets[listBoxStreets.SelectedIndex];
                if (new Address().Get(connectionHelper, street).Count != 0)
                {
                    CustomMessageBox.Show("За тази улица има записи на адреси и не може да бъде изтрита. Моля първо изтрийте записите на адресите.",
                                    "Действието не може да бъде извършено",
                                    MessageBoxButtons.OK,
                                    MessageBoxIcon.Error);
                }
                else
                {
                    street.Delete(connectionHelper);
                    RefreshStreets();
                }
            }
        }


        /// <summary>
        /// Връщане назад към панела със списъка с улици
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void buttonRenameCancel_Click(object sender, System.EventArgs e)
        {
            panelShowStreets.BringToFront();
        }

        /// <summary>
        /// Връщане назад към панела със списъка с улици
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void buttonInsertCancel_Click(object sender, System.EventArgs e)
        {
            panelShowStreets.BringToFront();
        }
    }
}
