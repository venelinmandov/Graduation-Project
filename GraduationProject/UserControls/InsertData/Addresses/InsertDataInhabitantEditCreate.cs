using GraduationProject.Models;
using GraduationProject.Modules;
using System;
using System.Collections.Generic;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Windows.Forms;

namespace GraduationProject.UserControls.InsertData.Addresses
{
    public partial class InsertDataInhabitantEditCreate : UserControl
    {
        ErrorProvider errorProvider = new ErrorProvider();
        ConnectionHelper connectionHelper = new ConnectionHelper();
        List<Street> streets;
        List<Address> currAddresses;
        List<Address> permAddresses;
        Button activeButton;
        InhabitantData inhabitantData;

        bool noCurrAddressLabelVisible = false,
             noPermAddressLabelVisible = false;

        bool personsDataFilled = false,
             ownershipDataFilled = false,
             habitalityDataFilled = false;

        public struct InhabitantData
        {
            public Inhabitant inhabitant;
            public Address address;
            public bool addressHasOwner;
        }

        Dictionary<string, Inhabitant.OwnershipStateEnum> ownershipStateDict = new Dictionary<string, Inhabitant.OwnershipStateEnum>()
        {
            {"собственик", Inhabitant.OwnershipStateEnum.Owner },
            {"член на семейството", Inhabitant.OwnershipStateEnum.Resident },
            {"гост", Inhabitant.OwnershipStateEnum.Guest }

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

        //Конструктор
        public InsertDataInhabitantEditCreate(InhabitantData inhabData)
        {
            InitializeComponent();
            inhabitantData = inhabData;
            labelAddress.Text = inhabitantData.address.ToString();
            if (inhabitantData.inhabitant.Id != 0)
            {
                labelSubtitle.Text = "Редактиране на обитател";
                ShowInhabitantData();
            }
            else
            {
                labelSubtitle.Text = "Добавяне на обитател";
            }

            string editButtonText;
            if (inhabitantData.inhabitant.Id == 0)
            {
                editButtonText = "Въведи";
            }
            else
            {
                editButtonText = "Промени";
            }
            foreach (Panel panel in Controls.OfType<Panel>())
            {
                foreach (ComboBox comboBox in panel.Controls.OfType<ComboBox>())
                {
                    comboBox.DrawItem += comboBox_DrawItem;
                }

                foreach (Button button in panel.Controls.OfType<Button>())
                {
                    if (button.Tag != null)
                    {
                        if (button.Tag.Equals("saveAddress"))
                        {
                            if (inhabData.inhabitant.Id != 0)
                            {
                                button.Visible = false;
                            }
                            else
                            {
                                button.Click += SaveInhabitantButton_Click;
                            }
                        }
                        else if (button.Tag.Equals("editInhabitant"))
                        {
                            button.Text = editButtonText;
                        }
                    }

                }


            }

            activeButton = buttonPersonsData;
            SetActivePanel(panelPersonsData, activeButton);

            comboBoxOwnwershipState.Items.AddRange(ownershipStateDict.Keys.ToArray());
            comboBoxhabitability.Items.AddRange(residenceStateDict.Keys.ToArray());
            comboBoxAddressReg.Items.AddRange(аddressRegistrationDict.Keys.ToArray());

            streets = new Street().Get(connectionHelper);
            comboBoxStreetCurr.Items.AddRange(streets.ToArray());
            comboBoxStreetPerm.Items.AddRange(streets.ToArray());

            labelNoAddressesCurr.Visible = false;
            labelNoAddressesPerm.Visible = false;


        }
        //Методи

        #region Данни за лицето
        /// <summary>
        /// Показване на панел с данните за лицето
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void buttonPersonsData_Click(object sender, EventArgs e)
        {
            SetActivePanel(panelPersonsData, (Button)sender);
        }
        /// <summary>
        /// Запазване на въведените данни за лицето в обекта на обитателя. Запазване на промените в БД при редактиране.
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
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
            inhabitantData.inhabitant.Firstname = textBoxFirstname.Text;
            inhabitantData.inhabitant.Middlename = textBoxMiddlename.Text;
            inhabitantData.inhabitant.Lastname = textBoxLastname.Text;
            inhabitantData.inhabitant.Gender = radioButtonMale.Checked ? Inhabitant.GenderEnum.Male : Inhabitant.GenderEnum.Female;
            inhabitantData.inhabitant.PhoneNumber = textBoxPhone.Text;

            DisplayInsertedPersonsData();

            personsDataFilled = true;

            if (inhabitantData.inhabitant.Id != 0)
            {
                inhabitantData.inhabitant.Update(connectionHelper);
            }
        }
        /// <summary>
        /// Показване на въведените данни за лицето.
        /// </summary>
        private void DisplayInsertedPersonsData()
        {
            string genderText = inhabitantData.inhabitant.Gender == Inhabitant.GenderEnum.Male ? "мъж" : "жена";
            string dispalyData = $"Име: {inhabitantData.inhabitant.Firstname}\n" +
                                    $"Презиме: {inhabitantData.inhabitant.Middlename}\n" +
                                    $"Фамилия: {inhabitantData.inhabitant.Lastname}\n" +
                                    $"Пол: {genderText}";
            if (inhabitantData.inhabitant.PhoneNumber.Trim() != "")
            {
                dispalyData += "\nТелефон: " + inhabitantData.inhabitant.PhoneNumber;
            }
            insertedDataDisplayPersonsData.DataText = dispalyData;
        }

        #endregion
        #region Статус на собственост
        /// <summary>
        /// Показване на панела със статуса на собственост
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void buttonOwnershipData_Click(object sender, EventArgs e)
        {
            SetActivePanel(panelOwnershipState, (Button)sender);
        }
        /// <summary>
        /// Избран е статус на собственост
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void comboBoxOwnwershipState_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (ownershipStateDict[comboBoxOwnwershipState.Text] == Inhabitant.OwnershipStateEnum.Owner)
            {
                textBoxOwnerRelation.Visible = false;
                labelOwnerRealtion.Visible = false;
                if (inhabitantData.addressHasOwner)
                {
                    labelOwnerExistsError.Visible = true;
                }
            }
            else
            {
                textBoxOwnerRelation.Visible = true;
                labelOwnerRealtion.Visible = true;
                labelOwnerExistsError.Visible = false;

            }
        }

        /// <summary>
        ///  Запазване на въведените данни за статус на собственост в обекта на обитателя. Запазване на промените в БД при редактиране.
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
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
            else if (labelOwnerExistsError.Visible)
            {
                errorProvider.SetError(comboBoxOwnwershipState, labelOwnerExistsError.Text);
            }
            else
            {
                inhabitantData.inhabitant.OwnershipState = ownershipStateDict[comboBoxOwnwershipState.Text];
                inhabitantData.inhabitant.RelToOwner = textBoxOwnerRelation.Visible ? textBoxOwnerRelation.Text : "";
                DisplayInsertedOwnershipState();
            }

            ownershipDataFilled = true;

            if (inhabitantData.inhabitant.Id != 0)
            {
                inhabitantData.inhabitant.Update(connectionHelper);
            }
        }
        /// <summary>
        /// Показване на въведените данни за статус на собственост
        /// </summary>
        private void DisplayInsertedOwnershipState()
        {
            string displayData = "Статус на собственост: " + ownershipStateDict.FirstOrDefault(entry => EqualityComparer<Inhabitant.OwnershipStateEnum>.Default.Equals(entry.Value, inhabitantData.inhabitant.OwnershipState)).Key;
            if (inhabitantData.inhabitant.OwnershipState != Inhabitant.OwnershipStateEnum.Owner)
            {
                displayData += "\nВръзка със собтвеника: " + inhabitantData.inhabitant.RelToOwner;
            }
            insertedDataDisplayOwnershipState.DataText = displayData;
        }

        #endregion
        #region Статус на пребиваване
        /// <summary>
        /// Показване на панела със статуса на пребиваване
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void buttonHabitabilityData_Click(object sender, EventArgs e)
        {
            SetActivePanel(panelHabitability, (Button)sender);
        }
        /// <summary>
        /// Избрана е адресна регистрация от панащото меню
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
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
                    labelNoAddressesCurr.Visible = false;

                    foreach (var permanentAddresscontrol in permanentAddresscontrols)
                    {
                        permanentAddresscontrol.Visible = true;
                    }
                    labelNoAddressesPerm.Visible = noCurrAddressLabelVisible;
                    labelNumberPerm.Visible = comboBoxNumberPerm.Visible = !noCurrAddressLabelVisible;

                    labelNotInTheSettlement.Visible = false;
                    checkBoxNotInTheSettlement.Visible = false;
                    break;
                case Inhabitant.AddressRegistrationEnum.Current:
                    foreach (var currentAddresscontrol in currentAddresscontrols)
                    {
                        currentAddresscontrol.Visible = true;
                    }
                    labelNoAddressesCurr.Visible = noCurrAddressLabelVisible;
                    labelNumberCurr.Visible = comboBoxNumberCurr.Visible = !noCurrAddressLabelVisible;

                    foreach (var permanentAddresscontrol in permanentAddresscontrols)
                    {
                        permanentAddresscontrol.Visible = true;
                    }
                    labelNoAddressesPerm.Visible = noPermAddressLabelVisible;
                    labelNumberPerm.Visible = comboBoxNumberPerm.Visible = !noPermAddressLabelVisible;

                    labelNotInTheSettlement.Visible = false;
                    checkBoxNotInTheSettlement.Visible = true;
                    break;
                case Inhabitant.AddressRegistrationEnum.No:
                    checkBoxNotInTheSettlement.Checked = false;
                    foreach (var currentAddresscontrol in currentAddresscontrols)
                    {
                        currentAddresscontrol.Visible = false;
                    }
                    labelNoAddressesCurr.Visible = false;

                    foreach (var permanentAddresscontrol in permanentAddresscontrols)
                    {
                        permanentAddresscontrol.Visible = false;
                    }
                    labelNoAddressesPerm.Visible = false;

                    labelNotInTheSettlement.Visible = true;
                    checkBoxNotInTheSettlement.Visible = false;
                    break;
            }
        }

        /// <summary>
        /// Избран е чекбокса "Не е в нас. място"
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void checkBoxNotInTheSettlement_CheckedChanged(object sender, EventArgs e)
        {
            var permanentAddresscontrols = from Control ctrl in panelHabitability.Controls where ctrl.Tag != null && ctrl.Tag.Equals("permanentAddressControl") select ctrl;

            foreach (var permanentAddresscontrol in permanentAddresscontrols)
            {
                permanentAddresscontrol.Visible = !checkBoxNotInTheSettlement.Checked;
            }
            labelNotInTheSettlement.Visible = checkBoxNotInTheSettlement.Checked;
            labelNoAddressesPerm.Visible = !checkBoxNotInTheSettlement.Checked && noPermAddressLabelVisible;
            labelNumberPerm.Visible = !labelNoAddressesPerm.Visible && !checkBoxNotInTheSettlement.Checked;
            comboBoxNumberPerm.Visible = !labelNoAddressesPerm.Visible && !checkBoxNotInTheSettlement.Checked;
        }

        /// <summary>
        /// Избрана е улицата на постоянния адрес.
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void comboBoxStreetPerm_SelectedIndexChanged(object sender, EventArgs e)
        {
            comboBoxNumberPerm.Items.Clear();
            permAddresses = new Address().Get(connectionHelper, streets[comboBoxStreetPerm.SelectedIndex]);
            if (permAddresses.Count == 0)
            {
                labelNumberPerm.Visible = false;
                comboBoxNumberPerm.Visible = false;
                labelNoAddressesPerm.Visible = noPermAddressLabelVisible = true;

            }
            else
            {
                labelNumberPerm.Visible = true;
                comboBoxNumberPerm.Visible = true;
                labelNoAddressesPerm.Visible = noPermAddressLabelVisible = false;
                foreach (Address address in permAddresses)
                {
                    comboBoxNumberPerm.Items.Add(address.Number);
                };
            }

        }
        /// <summary>
        /// Избрана е улицата на настоящия адрес.
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void comboBoxStreetCurr_SelectedIndexChanged(object sender, EventArgs e)
        {
            comboBoxNumberCurr.Items.Clear();
            currAddresses = new Address().Get(connectionHelper, streets[comboBoxStreetCurr.SelectedIndex]);
            if (currAddresses.Count == 0)
            {
                labelNumberCurr.Visible = false;
                comboBoxNumberCurr.Visible = false;
                labelNoAddressesCurr.Visible = noCurrAddressLabelVisible = true;
            }
            else
            {
                labelNumberCurr.Visible = true;
                comboBoxNumberCurr.Visible = true;
                labelNoAddressesCurr.Visible = noCurrAddressLabelVisible = false;
                foreach (Address address in currAddresses)
                {
                    comboBoxNumberCurr.Items.Add(address.Number);
                };
            }
        }
        /// <summary>
        ///  Запазване на въведените данни за статус на пребиваване в обекта на обитателя. Запазване на промените в БД при редактиране.
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void buttonInsertHabitality_Click(object sender, EventArgs e)
        {
            errorProvider.Clear();
            bool error = false;
            if (comboBoxhabitability.Text.Trim() == "")
            {
                errorProvider.SetError(comboBoxhabitability, "Моля изберете опция");
                error = true;
            }
            if (comboBoxAddressReg.Text.Trim() == "")
            {
                errorProvider.SetError(comboBoxAddressReg, "Моля изберете опция");
                error = true;
            }
            else
            {
                if ((labelStreetPerm.Visible && comboBoxStreetPerm.Text.Trim() == "" && comboBoxNumberPerm.Text.Trim() == "") || labelNoAddressesPerm.Visible)
                {
                    errorProvider.SetError(labelPermanentAddress, "Моля въведете постянен адрес");
                    error = true;
                }
                if ((labelStreetCurr.Visible && comboBoxStreetCurr.Text.Trim() == "" && comboBoxNumberCurr.Text.Trim() == "") || labelNoAddressesCurr.Visible)
                {
                    errorProvider.SetError(labelCurrentAddress, "Моля въведете настощ адрес");
                    error = true;
                }
            }
            if (error) return;

            inhabitantData.inhabitant.ResidenceState = residenceStateDict[comboBoxhabitability.Text];
            inhabitantData.inhabitant.AddressReg = аddressRegistrationDict[comboBoxAddressReg.Text];
            if (labelStreetPerm.Visible)
            {
                inhabitantData.inhabitant.PermanentAddressId = permAddresses[comboBoxNumberPerm.SelectedIndex].Id;
            }
            else
            {
                inhabitantData.inhabitant.PermanentAddressId = -1;
            }

            if (labelStreetCurr.Visible)
            {
                inhabitantData.inhabitant.CurrentAddressId = currAddresses[comboBoxNumberCurr.SelectedIndex].Id;
            }
            else
            {
                inhabitantData.inhabitant.CurrentAddressId = -1;
            }

            DispaleyInsertedHabitalityData();

            habitalityDataFilled = true;

            if (inhabitantData.inhabitant.Id != 0)
            {
                inhabitantData.inhabitant.Update(connectionHelper);
            }
        }
        /// <summary>
        /// Показване на въведените данни за статус на пребиваване
        /// </summary>
        private void DispaleyInsertedHabitalityData()
        {
            string displayData = $"Статус на пребиваване: {residenceStateDict.FirstOrDefault(entry => EqualityComparer<Inhabitant.ResidenceStateEnum>.Default.Equals(entry.Value, inhabitantData.inhabitant.ResidenceState)).Key}\n" +
                                              $"Адресна регистрация: {аddressRegistrationDict.FirstOrDefault(entry => EqualityComparer<Inhabitant.AddressRegistrationEnum>.Default.Equals(entry.Value, inhabitantData.inhabitant.AddressReg)).Key}\n";

            string permanentAddressText;
            if (inhabitantData.inhabitant.PermanentAddressId != -1)
            {
                permanentAddressText = new Address().Get(connectionHelper, inhabitantData.inhabitant.PermanentAddressId).ToString();
            }
            else
            {
                permanentAddressText = "не е в нас. място";
            }
            displayData += $"Постоянен адрес: {permanentAddressText}";

            if (inhabitantData.inhabitant.CurrentAddressId != -1)
            {
                displayData += $"\nНастоящ адрес: {new Address().Get(connectionHelper, inhabitantData.inhabitant.CurrentAddressId)}";
            }

            insertedDataDisplayHabitability.DataText = displayData;
        }

        #endregion
        #region Забележки
        /// <summary>
        /// Показване на панела със забележките
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void buttonNotes_Click(object sender, EventArgs e)
        {
            SetActivePanel(panelNotes, (Button)sender);
        }
        /// <summary>
        ///  Запазване на въведените забележки за обитателя в обекта на обитателя. Запазване на промените в БД при редактиране.
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void buttonInsertNote_Click(object sender, EventArgs e)
        {
            inhabitantData.inhabitant.Note = richTextBoxNotes.Text;
            DisplayInsertedNotes();

            if (inhabitantData.inhabitant.Id != 0)
            {
                inhabitantData.inhabitant.Update(connectionHelper);
            }
        }

        /// <summary>
        /// Показване на бележките за обитателя в текстовото поле
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void buttonEditNote_Click(object sender, EventArgs e)
        {
            richTextBoxNotes.Text = inhabitantData.inhabitant.Note;
        }
        /// <summary>
        /// Показване на въведените забележки
        /// </summary>
        private void DisplayInsertedNotes()
        {
            insertedDataDisplayNotes.DataText = inhabitantData.inhabitant.Note;
        }

        private void InsertDataInhabitantEditCreate_Load(object sender, EventArgs e)
        {

        }

        #endregion
        #region Други методи
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
        /// Избран е бутона "Запис"
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="eventArgs"></param>
        private void SaveInhabitantButton_Click(object sender, EventArgs eventArgs)
        {
            if (!SaveInhabitant()) return;

            foreach (Panel panel in Controls.OfType<Panel>())
            {
                foreach (Button button in panel.Controls.OfType<Button>())
                {
                    if (button.Tag != null)
                    {
                        if (button.Tag.Equals("saveAddress"))
                        {
                            button.Visible = false;
                        }
                        else if (button.Tag.Equals("editInhabitant"))
                        {
                            button.Text = "Промени";
                        }
                    }
                }
            }

            CustomMessageBox.Show("Данните са записани успешно.", "Данните са записани записани", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

        /// <summary>
        /// Показване на всички въведени данни
        /// </summary>
        private void ShowInhabitantData()
        {
            DisplayInsertedPersonsData();
            DisplayInsertedOwnershipState();
            DispaleyInsertedHabitalityData();
            DisplayInsertedNotes();
        }

        /// <summary>
        /// Излизане от режим добавяне/редактиране на обитател
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void InsertDataInhabitantEditCreate_VisibleChanged(object sender, EventArgs e)
        {
            if (Visible == false && inhabitantData.inhabitant.Id == 0)
            {
                DialogResult result = CustomMessageBox.Show("Излизате от режим \"Добавяне на обитател\" и въведените от вас данни ще бъдат изгубени. Запазване на въведените данни?", "Запазване на обитател?", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
                if (result == DialogResult.Yes)
                {
                    if (!SaveInhabitant())
                        Visible = true;
                }
            }

        }

        /// <summary>
        /// Запазване на обитателя в БД, както и имота ако не е.
        /// </summary>
        /// <returns></returns>
        private bool SaveInhabitant()
        {
            errorProvider.Clear();
            bool error = false;
            if (!personsDataFilled)
            {
                errorProvider.SetError(buttonPersonsData, "Моля въведете данните за лицето");
                error = true;
            }
            if (!ownershipDataFilled)
            {
                errorProvider.SetError(buttonOwnershipData, "Моля въведете статуса на собственост");
                error = true;
            }
            if (!habitalityDataFilled)
            {
                errorProvider.SetError(buttonHabitabilityData, "Моля въведете статуса на пребиваване");
                error = true;
            }

            if (error) return false;

            if (inhabitantData.address.Id == 0)
            {
                inhabitantData.address.Insert(connectionHelper);
            }
            inhabitantData.inhabitant.AddressId = inhabitantData.address.Id;
            inhabitantData.inhabitant.Insert(connectionHelper);

            return true;
        }
        #endregion

    }
}
