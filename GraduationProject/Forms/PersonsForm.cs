using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using GraduationProject.Models;

namespace GraduationProject.Forms
{
    public partial class PersonsForm : Form
    {
        ErrorProvider errorProvider = new ErrorProvider();
        ConnectionHelper connectionHelper = new ConnectionHelper(); 
        Person person;
        List<Street> streets;

        bool canceled = false;

        public bool Canceled => canceled;

        //Конструктори
        public PersonsForm()
        {
            InitializeComponent();
            streets = new Street().Get(connectionHelper);
            comboBoxStreets.Items.AddRange(streets.ToArray());
            comboBoxStreets.Visible = false;
            numericUpDownAddressNumber.Visible = false;
            Text = "Добавяне на жител / гост в карантина";
        }

        public PersonsForm(Resident res): this()
        {
            person = res;
            radioButtonHousehold.Enabled = false;
            radioButtonGuest.Enabled = false;
            radioButtonHousehold.Checked = true;
            showData(person);
            Text = "Редактиране на жител";

        }

        public PersonsForm(Person pers):this()
        {
            person = pers;
            radioButtonHousehold.Enabled = false;
            radioButtonGuest.Enabled = false;
            radioButtonGuest.Checked = true;
            groupBoxAddressReg.Enabled = false;
            groupBoxCovid19.Enabled = false;
            showData(person);
            Text = "Редактиране на гост в карантина";
        }


        //Свойства
        public bool isResident => radioButtonHousehold.Checked;
        public Person getNewGuest => person;
        public Resident getNewResident => (Resident)person;




        //Валидация на groupbox-овете
        bool ValidateGroupBox(GroupBox groupBox, params RadioButton[] radioButtons)
        {
            if (GetGroupBoxValue(radioButtons) == -1)
            {
                errorProvider.SetError(groupBox, "Моля изберете опция!");
                return true;
            }
            else
            {
                errorProvider.SetError(groupBox, "");
                return false;
            }
        }

      

        //Показване на информацията за жителя/госта (при редактиране)
        void showData(Person personToShow)
        {
            textBoxFName.Text = personToShow.Firstname;
            textBoxMName.Text = personToShow.Middlename;
            textBoxLName.Text = personToShow.Lastname;
            textBoxOwner.Text = personToShow.RelToOwner;
            textBoxNotes.Text = personToShow.Note;
            SetGroupBoxValue(personToShow.Gender,radioButtonMale, radioButtonFemale);
            if (radioButtonHousehold.Checked)
            {
                Resident residentToShow = (Resident)personToShow;
                SetGroupBoxValue((int)residentToShow.AddressReg,radioButtonAddrRegNo, radioButtonAddrRegYes, radioButtonAddrRegTemp);
                SetGroupBoxValue((int)residentToShow.Covid19, radioButtonCovid19No, radioButtonCovid19Yes, radioButtonCovid19Contact);
            }

            if (personToShow.CurrentAddressId != -1)
            {
                checkBoxCurrentAddress.Checked = true;
                Address currentAddress = new Address().Get(connectionHelper,personToShow.CurrentAddressId);

                int i;
                for (i = 0; i < streets.Count; i++)
                {
                    if (currentAddress.StreetId == streets[i].Id)
                        break;
                }
                comboBoxStreets.SelectedIndex = i;
                numericUpDownAddressNumber.Value = currentAddress.Number;
            }


            if (textBoxOwner.Text == "Собственик")
                checkBoxOwner.Checked = true;
        }


        //Валидация
        bool validate()
        {
            bool error = false;
            errorProvider.Clear();

            //Валидация на текстовите полета
            object[,] textBoxes = new object[,]
            {
                {textBoxFName,"име" },
                {textBoxMName,"презиме" },
                {textBoxLName,"фамилия" },
                {textBoxOwner,"връзка със собственика" },

            };
            for (int i = 0; i < textBoxes.GetLength(0); i++)
            {
                if (((TextBox)textBoxes[i, 0]).Text == "")
                {
                    errorProvider.SetError((TextBox)textBoxes[i, 0], "Моля въведете " + (string)textBoxes[i, 1] + "!");
                    error = true;
                }
                else
                    errorProvider.SetError((TextBox)textBoxes[i, 0], "");
            }

            //Валидация на groupbox-овете
            error |= ValidateGroupBox(groupBoxGender, radioButtonMale, radioButtonFemale);
            if (radioButtonHousehold.Checked)
            {
                error |= ValidateGroupBox(groupBoxAddressReg, radioButtonAddrRegNo, radioButtonAddrRegYes, radioButtonAddrRegTemp);
                error |= ValidateGroupBox(groupBoxCovid19, radioButtonCovid19No, radioButtonCovid19Yes, radioButtonCovid19Contact);
            }

            //Валидация на полетата за текущ адрес
            if (checkBoxCurrentAddress.Checked)
            {
                if (comboBoxStreets.SelectedItem == null)
                {
                    errorProvider.SetError(numericUpDownAddressNumber, "Моля изберете улица!");
                    error |= true;
                }
                    
                else if (person.CurrentAddressId == -1)
                {
                    errorProvider.SetError(numericUpDownAddressNumber, "Няма такъв адрес!");
                    error |= true;
                }
            }

            return !error;
        }

        //Отключват/заключват се опциите, ексклузивни за членовете на домакинството
        void SetOwner(bool enabled, RadioButton radioButton)
        {
            errorProvider.Clear();
            if (radioButton.Checked == true)
            {
                checkBoxOwner.Visible = enabled;
                groupBoxAddressReg.Visible = enabled;
                groupBoxCovid19.Visible = enabled;

            }
        }

        //Връща индекса на избрания радиобутон 
        public int GetGroupBoxValue(params RadioButton[] radioButtons)
        {
            for (int i = 0; i < radioButtons.Length; i++)
            {
                if (radioButtons[i].Checked)
                    return i;
            }
            return -1;
        }

        //Избира се радиобутон по индекс
        public void SetGroupBoxValue(int index, params RadioButton[] radioButtons)
        {
            radioButtons[index].Checked = true;
        }

        //Избран е радиобутона "Член на домакинство"
        private void radioButtonHousehold_CheckedChanged(object sender, EventArgs e)
        {
            SetOwner(true, (RadioButton)sender);

        }

        //Избран е бутона "Гост"
        private void radioButtonGuest_CheckedChanged(object sender, EventArgs e)
        {
            SetOwner(false, (RadioButton)sender);
            if (textBoxOwner.Enabled == false)
            {
                textBoxOwner.Text = "";
                textBoxOwner.Visible = true;
                labelOwner.Visible = true;
            }
        }

        //Проняна на състоянието на отметката "Собственик"
        private void checkBoxOwner_CheckedChanged(object sender, EventArgs e)
        {
            if (((CheckBox)sender).Checked == true)
            {
                textBoxOwner.Text = "Собственик";
                textBoxOwner.Visible = false;
                labelOwner.Visible = false;
            }
            else
            {
                textBoxOwner.Text = "";
                textBoxOwner.Visible = true;
                labelOwner.Visible = true;
            }
        }


        //Запазване и затваряне на формата
        private void buttonSave_Click(object sender, EventArgs e)
        {
            if (person == null)
            {
                if (radioButtonHousehold.Checked)
                {
                    person = new Resident();
                }
                else if (radioButtonGuest.Checked)
                {
                    person = new Person();
                }
                else
                {
                    errorProvider.SetError(groupBoxOwner, "Моля изберете опция!");
                    return;
                }

            }
            if (radioButtonHousehold.Checked)
            {
                Resident residentToSave = (Resident)person;
                residentToSave.AddressReg = (Resident.AddressRegistration)GetGroupBoxValue(radioButtonAddrRegNo, radioButtonAddrRegYes, radioButtonAddrRegTemp);
                residentToSave.Covid19 = (Person.Covid19Enum)GetGroupBoxValue(radioButtonCovid19No, radioButtonCovid19Yes, radioButtonCovid19Contact);

            }

            person.Firstname = textBoxFName.Text;
            person.Middlename = textBoxMName.Text;
            person.Lastname = textBoxLName.Text;
            person.RelToOwner = textBoxOwner.Text;
            person.Gender = GetGroupBoxValue(radioButtonMale, radioButtonFemale);
            person.Note = textBoxNotes.Text;
            if (checkBoxCurrentAddress.Checked && comboBoxStreets.SelectedItem != null)
            {
                Address currentAddres = new Address().Get(connectionHelper, streets[comboBoxStreets.SelectedIndex].Id, (int)numericUpDownAddressNumber.Value);
                person.CurrentAddressId = currentAddres == null ? -1 : currentAddres.Id;
            }
            else
                person.CurrentAddressId = -1;
            


            if (validate())
                    Hide();
        }

        //Избран е бутона за затваряне на формата
        private void PersonsForm_FormClosed(object sender, FormClosedEventArgs e)
        {
            canceled = true;
            Hide();
        }

        //Променено е състоянието на отметката "текущ адрес"
        private void checkBoxCurrentAddress_CheckedChanged(object sender, EventArgs e)
        {
            if (checkBoxCurrentAddress.Checked)
            {
                comboBoxStreets.Visible = true;
                numericUpDownAddressNumber.Visible = true;
                numericUpDownAddressNumber.Visible = true;
                labelStreet.Visible = true;
                labelAddressNumber.Visible = true;
            }
            else
            {
                comboBoxStreets.Visible = false;
                numericUpDownAddressNumber.Visible = false;
                numericUpDownAddressNumber.Visible = false;
                labelStreet.Visible = false;
                labelAddressNumber.Visible = false;
            }
        }

        private void PersonsForm_Load(object sender, EventArgs e)
        {

        }
    }
}
