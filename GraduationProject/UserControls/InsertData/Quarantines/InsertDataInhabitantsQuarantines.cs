using GraduationProject.Models;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using System.Linq;
using GraduationProject.Modules;

namespace GraduationProject.UserControls.InsertData.Quarantines
{
    public partial class InsertDataInhabitantsQuarantines : UserControl
    {
        Address address;
        InhabitantsQuarantine inhabitantsQuarantineToEdit = null;
        List<InhabitantsQuarantine> inhabitantsQuarantines;
        List<Disease> diseases;
        List<Inhabitant> inhabitants;
        List<Inhabitant> selectedInhabitants;
        ConnectionHelper connectionHelper = new ConnectionHelper();
        ErrorProvider errorProvider = new ErrorProvider();

        //Конструктор
        public InsertDataInhabitantsQuarantines(Address addr)
        {
            InitializeComponent();
            address = addr;
            labelAddress.Text = address.ToString();
            panelShowQuarantines.BringToFront();

            foreach (GroupBox groupBox in panelAddEditQuarantine.Controls.OfType<GroupBox>())
            {
                foreach (ComboBox comboBox in groupBox.Controls.OfType<ComboBox>())
                {
                    comboBox.DrawItem += comboBox_DrawItem;
                }
            }

            diseases = new Disease().Get(connectionHelper, Disease.DiseaseType.Inhabitant);
            inhabitants = new Inhabitant().Get(connectionHelper,address);

            comboBoxDisease.DataSource = diseases;
            ShowQuarantines();
        }

        /// <summary>
        /// Показаване на карантините в списъка с карантини
        /// </summary>
        void ShowQuarantines()
        {
            inhabitantsQuarantines = new InhabitantsQuarantine().Get(connectionHelper, address);
            string dateformat = "d MMMM yyyy";
            List<string> qurantineListItems = new List<string>();
            foreach (InhabitantsQuarantine inhabitantsQuarantine in inhabitantsQuarantines)
            {
                Inhabitant inhabitant = new Inhabitant().Get(connectionHelper, inhabitantsQuarantine.InhabitantId);
                string inhabitantOwnershipState;
                switch (inhabitant.OwnershipState)
                {
                    case Inhabitant.OwnershipStateEnum.Guest:
                        inhabitantOwnershipState = "гост";
                        break;
                    case Inhabitant.OwnershipStateEnum.Owner:
                        inhabitantOwnershipState = "собственик";
                        break;
                    case Inhabitant.OwnershipStateEnum.Resident:
                        inhabitantOwnershipState = "член на семейството";
                        break;
                    default:
                        inhabitantOwnershipState = "indefined";
                        break;
                }

                string quarantineType = inhabitantsQuarantine.QuarantineType == InhabitantsQuarantine.QuarantineEnum.Contact ? "контактен" : "боледува";
                string diseaseName = (from Disease d in diseases where d.Id == inhabitantsQuarantine.DiseaseId select d.Name).First();
                DateTime startDate = DateTime.Parse(inhabitantsQuarantine.StartDate);
                DateTime endDate = DateTime.Parse(inhabitantsQuarantine.EndDate);
                string qurantineListItem = $"{inhabitant} - {inhabitantOwnershipState}: {quarantineType}, {diseaseName}, от {startDate.ToString(dateformat)} до {endDate.ToString(dateformat)}";
                qurantineListItems.Add(qurantineListItem);
            }
            listBoxQarantines.AddList(qurantineListItems.ToList<object>());
        }

        /// <summary>
        /// Избран с статус на собственост и обитателите с този статус се показват в падащото меню на обитателите
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void radioButton_CheckedChanged(object sender, EventArgs e)
        {
            if (radioButtonResident.Checked)
            {
                selectedInhabitants = (from inh in inhabitants where inh.OwnershipState == Inhabitant.OwnershipStateEnum.Resident select inh).ToList();
                selectedInhabitants.Concat((from inh in inhabitants where inh.OwnershipState == Inhabitant.OwnershipStateEnum.Owner select inh).ToList());
            }
            else if (radioButtonGuest.Checked)
            {
                selectedInhabitants = (from inh in inhabitants where inh.OwnershipState == Inhabitant.OwnershipStateEnum.Guest select inh).ToList();
            }
            comboBoxInhabitant.DataSource = selectedInhabitants;
        }

        /// <summary>
        /// Показване на менюто за редактиране на карантина
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void buttonShowEditQuarantine_Click(object sender, EventArgs e)
        {
            if (inhabitantsQuarantines.Count == 0) return;
            labelAddEditQuarantineTitlelabel.Text = "Редактиране на карантина";
            inhabitantsQuarantineToEdit = inhabitantsQuarantines[listBoxQarantines.SelectedIndex];
            Inhabitant inhabitant = new Inhabitant().Get(connectionHelper, inhabitantsQuarantineToEdit.InhabitantId);
            if (inhabitant.OwnershipState == Inhabitant.OwnershipStateEnum.Guest)
            {
                radioButtonGuest.Checked = true;
            }
            else
            {
                radioButtonResident.Checked = true;
            }

            if (inhabitantsQuarantineToEdit.QuarantineType == InhabitantsQuarantine.QuarantineEnum.Ill)
            {
                radioButtonIll.Checked = true;
            }
            else
            {
                radioButtonContact.Checked = true;
            }

            for (int i = 0; i < selectedInhabitants.Count; i++)
            {
                if (selectedInhabitants[i].Id == inhabitantsQuarantineToEdit.InhabitantId)
                {
                    comboBoxInhabitant.SelectedIndex = i;
                    break;
                }
            }

            for (int i = 0; i < diseases.Count; i++)
            {
                if (diseases[i].Id == inhabitantsQuarantineToEdit.DiseaseId)
                {
                    comboBoxDisease.SelectedIndex = i;
                    break;
                }
            }

            dateTimePickerFrom.Value = DateTime.Parse(inhabitantsQuarantineToEdit.StartDate);
            dateTimePickerTo.Value = DateTime.Parse(inhabitantsQuarantineToEdit.EndDate);

            panelAddEditQuarantine.BringToFront();

        }

        /// <summary>
        /// Показване на менюто за добавяне на карантина 
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void buttonShowInsertQuarantine_Click(object sender, EventArgs e)
        {
            labelAddEditQuarantineTitlelabel.Text = "Добавяне на карантина";
            inhabitantsQuarantineToEdit = new InhabitantsQuarantine();

            foreach (GroupBox groupBox in panelAddEditQuarantine.Controls.OfType<GroupBox>())
            {
                foreach (RadioButton radioButton in groupBox.Controls.OfType<RadioButton>())
                {
                    if (radioButton.Checked)
                    {
                        radioButton.Checked = false;
                    }
                }
            }
            

            dateTimePickerFrom.Value = DateTime.Now;
            dateTimePickerTo.Value = DateTime.Now;

            selectedInhabitants = new List<Inhabitant>();
            comboBoxInhabitant.DataSource = selectedInhabitants;

            comboBoxDisease.SelectedIndex = -1;

            panelAddEditQuarantine.BringToFront();

        }

        /// <summary>
        /// Изчертаване на елемент от комбобокс
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void comboBox_DrawItem(object sender, DrawItemEventArgs e)
        {
            if (e.Index == -1) return;
            var combo = sender as ComboBox;
            SolidBrush solidBrush;
            if ((e.State & DrawItemState.Selected) == DrawItemState.Selected)
            {
                e.Graphics.FillRectangle(new SolidBrush(Color.FromArgb(70, 90, 30)), e.Bounds);
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

        /// <summary>
        /// Запис на нововъведена или редактирана карантина
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void buttonSave_Click(object sender, EventArgs e)
        {
            errorProvider.Clear();
            bool error = false;
            if (!radioButtonResident.Checked && !radioButtonGuest.Checked)
            {
                errorProvider.SetError(groupBoxInhabitant, "Моля изберете опция");
                error = true;
            }
            if ((!radioButtonContact.Checked && !radioButtonIll.Checked) || comboBoxDisease.Text == "") ;
            {
                errorProvider.SetError(groupBoxDisease, "Моля изберете опция");
                error = true;
            }
            if (error) return;

            inhabitantsQuarantineToEdit.InhabitantId = selectedInhabitants[comboBoxInhabitant.SelectedIndex].Id;
            inhabitantsQuarantineToEdit.QuarantineType = radioButtonIll.Checked ? InhabitantsQuarantine.QuarantineEnum.Ill : InhabitantsQuarantine.QuarantineEnum.Contact;
            inhabitantsQuarantineToEdit.DiseaseId = diseases[comboBoxDisease.SelectedIndex].Id;
            inhabitantsQuarantineToEdit.StartDate = dateTimePickerFrom.Value.ToString("yyyy-MM-dd");
            inhabitantsQuarantineToEdit.EndDate = dateTimePickerTo.Value.ToString("yyyy-MM-dd");

            if (inhabitantsQuarantineToEdit.Id == 0)
            {
                inhabitantsQuarantineToEdit.Insert(connectionHelper);
                CustomMessageBox.Show("Записът за карантината е създаден.", "Записът за карантината е създаден.", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            else
            {
                inhabitantsQuarantineToEdit.Update(connectionHelper);
                CustomMessageBox.Show("Записът за карантината е редактиран.", "Записът за карантината е редактиран.", MessageBoxButtons.OK, MessageBoxIcon.Information);

            }
            ShowQuarantines();
            panelShowQuarantines.BringToFront();
        }

        /// <summary>
        /// Връщане назад към списъка с карантини
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void buttonCancel_Click(object sender, EventArgs e)
        {
            panelShowQuarantines.BringToFront();
        }

        /// <summary>
        /// Изтриване на избрана карантина
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void buttonDeleteQuarantine_Click(object sender, EventArgs e)
        {
            if (inhabitantsQuarantines.Count == 0) return;
            DialogResult result = CustomMessageBox.Show("Сигурни ли сте, че искате да изтриете записа за карантината?", "Изтриване на карантина", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (result == DialogResult.Yes)
            {
                inhabitantsQuarantines[listBoxQarantines.SelectedIndex].Delete(connectionHelper);
                CustomMessageBox.Show("Записът за карантината е изтрит.", "Записът за карантината е изтрит.", MessageBoxButtons.OK, MessageBoxIcon.Information);
                ShowQuarantines();
            }
        }
    }
}
