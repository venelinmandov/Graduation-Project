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
        Person person;
        bool canceled = false;

        public bool Canceled => canceled;

        //Конструктори
        public PersonsForm()
        {
            InitializeComponent();
        }

        public PersonsForm(Resident res): this()
        {
            person = res;
            radioButtonHousehold.Enabled = false;
            radioButtonGuest.Enabled = false;
            radioButtonHousehold.Checked = true;
            showData(person);


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

        //Валидация на ЕГН
        bool ValidateEgn(TextBox textBox)
        {
            int[] consts = new int[] { 2, 4, 8, 5, 10, 9, 7, 3, 6 };

            textBox.Text = textBox.Text.Trim();
            string egn = (string)textBox.Text.Clone();
            if (textBox.Text.Length != 10)
            {
                errorProvider.SetError(textBox, "Дължината на ЕГН-то трябва да е от 10 цифри!");
                return true;
            }

            int sum = 0;
            for (int i = 0; i < 9; i++)
            {
                if (!char.IsDigit(egn[i]))
                {
                    errorProvider.SetError(textBox, "ЕГН-то се състои само от цифри!");
                    return true;
                }
                sum += int.Parse(egn[i].ToString()) * consts[i];
            }
            sum %= 11;
            sum = sum < 10 ? sum : 0;
            if (int.Parse(egn[9].ToString()) != sum)
            {
                errorProvider.SetError(textBox, "Невалидно ЕГН!");
                return true;
            }

            errorProvider.SetError(textBox, "");
            return false;


        }

        //Показване на информацията за жителя/госта (при редактиране)
        void showData(Person personToShow)
        {
            textBoxFName.Text = personToShow.Firstname;
            textBoxMName.Text = personToShow.Middlename;
            textBoxLName.Text = personToShow.Lastname;
            textBoxEGN.Text = personToShow.Egn;
            textBoxOwner.Text = personToShow.RelToOwner;
            SetGroupBoxValue(personToShow.Gender,radioButtonMale, radioButtonFemale);
            if (radioButtonHousehold.Checked)
            {
                Resident residentToShow = (Resident)personToShow;
                SetGroupBoxValue(residentToShow.AddressReg,radioButtonAddrRegNo, radioButtonAddrRegYes, radioButtonAddrRegTemp);
                SetGroupBoxValue(residentToShow.Covid19, radioButtonCovid19No, radioButtonCovid19Yes, radioButtonCovid19Contact);
            }

            if (textBoxOwner.Text == "Собственик")
                checkBoxOwner.Checked = true;
        }


        //Валидация
        bool validate()
        {
            bool error = false;

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

            //Валидация на ЕГН
            error |= ValidateEgn(textBoxEGN);

            return !error;
        }

        //Отключват/заключват се опциите, ексклузивни за членовете на домакинството
        void SetOwner(bool enabled, RadioButton radioButton)
        {
            errorProvider.Clear();
            if (radioButton.Checked == true)
            {
                checkBoxOwner.Enabled = enabled;
                groupBoxAddressReg.Enabled = enabled;
                groupBoxCovid19.Enabled = enabled;

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
                textBoxOwner.Enabled = true;
            }
        }

        //Проняна на състоянието на отметката "Собственик"
        private void checkBoxOwner_CheckedChanged(object sender, EventArgs e)
        {
            if (((CheckBox)sender).Checked == true)
            {
                textBoxOwner.Text = "Собственик";
                textBoxOwner.Enabled = false;
            }
            else
            {
                textBoxOwner.Text = "";
                textBoxOwner.Enabled = true;
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
                residentToSave.AddressReg = GetGroupBoxValue(radioButtonAddrRegNo, radioButtonAddrRegYes, radioButtonAddrRegTemp);
                residentToSave.Covid19 = GetGroupBoxValue(radioButtonCovid19No, radioButtonCovid19Yes, radioButtonCovid19Contact);

            }

            person.Firstname = textBoxFName.Text;
            person.Middlename = textBoxMName.Text;
            person.Lastname = textBoxLName.Text;
            person.Egn = textBoxEGN.Text;
            person.RelToOwner = textBoxOwner.Text;
            person.Gender = GetGroupBoxValue(radioButtonMale, radioButtonFemale);

                if (validate())
                    Hide();
        }

        //Избран е бутона за затваряне на формата
        private void PersonsForm_FormClosed(object sender, FormClosedEventArgs e)
        {
            canceled = true;
            Hide();
        }
    }
}
