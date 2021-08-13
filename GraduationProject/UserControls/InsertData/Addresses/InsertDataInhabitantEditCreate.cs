using GraduationProject.Models;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace GraduationProject.UserControls.InsertData.Addresses
{
    public partial class InsertDataInhabitantEditCreate : UserControl
    {
        ErrorProvider errorProvider = new ErrorProvider();
        ConnectionHelper connectionHelper = new ConnectionHelper();
        Button activeButton;
        Inhabitant inhabitant;

        public struct InhabitantData
        {
            public Inhabitant Inhabitant;
            public string addressName;
        }

        Dictionary<string, Inhabitant.OwnershipStateEnum> ownershipStateDict = new Dictionary<string, Inhabitant.OwnershipStateEnum>()
        {
            {"гост", Inhabitant.OwnershipStateEnum.Guest },
            {"собственик", Inhabitant.OwnershipStateEnum.Owner },
            {"член на семейството", Inhabitant.OwnershipStateEnum.Resident }
        };

        Dictionary<string, Inhabitant.ResidenceStateEnum> residenceStateDict = new Dictionary<string, Inhabitant.ResidenceStateEnum>()
        {
            {"постоянно", Inhabitant.ResidenceStateEnum.Permanent },
            {"временно", Inhabitant.ResidenceStateEnum.Temporary }
        };

        Dictionary<string, Inhabitant.AddressRegistrationEnum> аddressRegistrationDict = new Dictionary<string, Inhabitant.AddressRegistrationEnum>()
        {
            {"настоящ адрес", Inhabitant.AddressRegistrationEnum.Current },
            {"няма в нас. място", Inhabitant.AddressRegistrationEnum.No },
            {"постоянен адрес", Inhabitant.AddressRegistrationEnum.Permanent }
        };
        public InsertDataInhabitantEditCreate(InhabitantData inhabitantData)
        {
            InitializeComponent();
            inhabitant = inhabitantData.Inhabitant;
            labelAddress.Text = inhabitantData.addressName;
            if (inhabitant.Id != 0)
            {
                labelSubtitle.Text = "Редактиране на обитател";
            }
            else
            {
                labelSubtitle.Text = "Добавяне на обитател";
            }
            activeButton = buttonPersonsData;
            SetActivePanel(panelPersonsData, activeButton);

            comboBoxOwnwershipState.Items.AddRange(ownershipStateDict.Keys.ToArray());
            comboBoxhabitability.Items.AddRange(residenceStateDict.Keys.ToArray());
            comboBoxAddressReg.Items.AddRange(аddressRegistrationDict.Keys.ToArray());
        }

        /// <summary>
        /// Показва се избрания панел. И съответния бутон се визуализира като активен.
        /// </summary>
        /// <param name="panel"></param>
        /// <param name="button"></param>
        void SetActivePanel(Panel panel, Button button)
        {
            panel.BringToFront();
            activeButton.BackColor = Color.FromArgb(170, 255, 255, 255);
            activeButton.ForeColor = SystemColors.ControlText;
            activeButton = button;
            activeButton.BackColor = Color.FromArgb(70, 90, 30);
            activeButton.ForeColor = SystemColors.Control;
            panel.BringToFront();
        }

        private void buttonPersonsData_Click(object sender, EventArgs e)
        {
            SetActivePanel(panelPersonsData, (Button)sender);
        }

        private void buttonOwnershipData_Click(object sender, EventArgs e)
        {
            SetActivePanel(panelOwnershipState, (Button)sender);
        }

        private void buttonHabitabilityData_Click(object sender, EventArgs e)
        {
            SetActivePanel(panelHabitability, (Button)sender);
        }

        private void buttonNotes_Click(object sender, EventArgs e)
        {
            SetActivePanel(panelNotes, (Button)sender);
        }

        private void comboBoxAddressReg_SelectedIndexChanged(object sender, EventArgs e)
        {
            var currentAddresscontrols = from Control ctrl in panelHabitability.Controls where ctrl.Tag != null && ctrl.Tag.Equals("currentAddressControl") select ctrl;
            var permanentAddresscontrols = from Control ctrl in panelHabitability.Controls where ctrl.Tag != null && ctrl.Tag.Equals("permanentAddressControl") select ctrl;
            labelPermanentAddress.Visible = true;
            switch (аddressRegistrationDict[comboBoxAddressReg.Text])
            {
                case Inhabitant.AddressRegistrationEnum.Permanent:
                    checkBoxNotInTheSettlement.Checked = false;
                    foreach (var currentAddresscontrol in currentAddresscontrols)
                    {
                        currentAddresscontrol.Visible = false;
                    }
                    foreach (var permanentAddresscontrol in permanentAddresscontrols)
                    {
                        permanentAddresscontrol.Visible = true;
                    }
                    labelNotInTheSettlement.Visible = false;
                    checkBoxNotInTheSettlement.Visible = false;
                    break;
                case Inhabitant.AddressRegistrationEnum.Current:
                    foreach (var currentAddresscontrol in currentAddresscontrols)
                    {
                        currentAddresscontrol.Visible = true;
                    }
                    foreach (var permanentAddresscontrol in permanentAddresscontrols)
                    {
                        permanentAddresscontrol.Visible = true;
                    }
                    labelNotInTheSettlement.Visible = false;
                    checkBoxNotInTheSettlement.Visible = true;
                    break;
                case Inhabitant.AddressRegistrationEnum.No:
                    checkBoxNotInTheSettlement.Checked = false;
                    foreach (var currentAddresscontrol in currentAddresscontrols)
                    {
                        currentAddresscontrol.Visible = false;
                    }
                    foreach (var permanentAddresscontrol in permanentAddresscontrols)
                    {
                        permanentAddresscontrol.Visible = false;
                    }
                    labelNotInTheSettlement.Visible = true;
                    checkBoxNotInTheSettlement.Visible = false;
                    break;
            }
        }

        private void checkBoxNotInTheSettlement_CheckedChanged(object sender, EventArgs e)
        {
            var permanentAddresscontrols = from Control ctrl in panelHabitability.Controls where ctrl.Tag != null && ctrl.Tag.Equals("permanentAddressControl") select ctrl;

            foreach (var permanentAddresscontrol in permanentAddresscontrols)
            {
                permanentAddresscontrol.Visible = !checkBoxNotInTheSettlement.Checked;
            }
            labelNotInTheSettlement.Visible = checkBoxNotInTheSettlement.Checked;
        }

        private void buttonInsertPersonsData_Click(object sender, EventArgs e)
        {
            errorProvider.Clear();
            bool error = false;
            if (textBoxFirstname.Text.Trim().Equals(""))
            {
                errorProvider.SetError(textBoxFirstname, "Моля въведете име");
                error = true;
            }
            if (textBoxMiddlename.Text.Trim().Equals(""))
            {
                errorProvider.SetError(textBoxMiddlename, "Моля въведете презиме");
                error = true;
            }
            if (textBoxLastname.Text.Trim().Equals(""))
            {
                errorProvider.SetError(textBoxLastname, "Моля въведете фамилия");
                error = true;
            }
            if (!radioButtonMale.Checked && !radioButtonFemale.Checked)
            {
                errorProvider.SetError(radioButtonFemale, "Моля въведете пол");
                error = true;
            }

            if (error) return;
            inhabitant.Firstname = textBoxFirstname.Text;
            inhabitant.Middlename = textBoxMiddlename.Text;
            inhabitant.Lastname = textBoxLastname.Text;
            inhabitant.Gender = radioButtonMale.Checked ? Inhabitant.GenderEnum.Male : Inhabitant.GenderEnum.Female;
            inhabitant.PhoneNumber = textBoxPhone.Text;

            string genderText = inhabitant.Gender == Inhabitant.GenderEnum.Male ? "мъж" : "жена";
            string dispalyData = $"Име: {inhabitant.Firstname}\n" +
                                    $"Презиме: {inhabitant.Middlename}\n" +
                                    $"Фамилия: {inhabitant.Lastname}\n" +
                                    $"Пол: {genderText}";
            if (inhabitant.PhoneNumber.Trim() != "")
            {
                dispalyData += "\nТелефон: " + inhabitant.PhoneNumber;
            }
            insertedDataDisplayPersonsData.DataText = dispalyData;

        }

        private void comboBoxOwnwershipState_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (ownershipStateDict[comboBoxOwnwershipState.Text] == Inhabitant.OwnershipStateEnum.Owner)
            {
                textBoxOwnerRelation.Visible = false;
                labelOwnerRealtion.Visible = false;
            }
            else
            {
                textBoxOwnerRelation.Visible = true;
                labelOwnerRealtion.Visible = true;
            }
        }

        private void buttonInsertOwnershipState_Click(object sender, EventArgs e)
        {
            errorProvider.Clear();
            if (comboBoxOwnwershipState.Text == "")
            {
                errorProvider.SetError(comboBoxOwnwershipState, "Моля изберете опция");
            }
            else if (textBoxOwnerRelation.Visible == true && textBoxOwnerRelation.Text.Trim() == "")
            {
                errorProvider.SetError(textBoxOwnerRelation, "Моля въведете връзка със собственика");
            }
            else
            {
                inhabitant.OwnershipState = ownershipStateDict[comboBoxOwnwershipState.Text];
                inhabitant.RelToOwner = textBoxOwnerRelation.Visible ? textBoxOwnerRelation.Text : "";

                string displayData = "Статус на собственост: " + comboBoxOwnwershipState.Text;
                if (textBoxOwnerRelation.Visible)
                {
                    displayData += "\nВръзка със собтвеника: " + inhabitant.RelToOwner;
                }
                insertedDataDisplayOwnershipState.DataText = displayData;
            }
        }
    }
}
