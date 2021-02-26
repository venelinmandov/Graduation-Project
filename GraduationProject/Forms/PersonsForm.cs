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
        Resident resident;
        Person person;
        bool canceled = false;

        public bool Canceled => canceled;

        //Конструктори
        public PersonsForm()
        {
            InitializeComponent();
        }

        public PersonsForm(Resident res)
        {
            InitializeComponent();
            resident = res;
            radioButtonHousehold.Enabled = false;
            radioButtonGuest.Enabled = false;
            radioButtonHousehold.Checked = true;
            showData(resident);


        }

        public PersonsForm(Person pers)
        {
            InitializeComponent();
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
        public Person getNewGuest => resident;
        public Resident getNewResident => resident;




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

        bool ValidateEgn(TextBox textBox)
        {
            bool error = false;
            int[] consts = new int[] { 2, 4, 8, 5, 10, 9, 7, 3, 6 };
            textBox.Text = textBox.Text.Trim();
            string egn = (string)textBox.Text.Clone();
            if (textBox.Text.Length != 10)
            {
                error = true;
            }
            else
            {
                int sum = 0;
                for (int i = 0; i < 9; i++)
                {
                    if (!char.IsDigit(egn[i]))
                    {
                        error = true;
                        break;
                    }
                    sum += int.Parse(egn[i].ToString()) * consts[i];
                }
                textBoxFName.Text = sum.ToString();
                sum %= 11;
                sum = sum < 10 ? sum : 0;
                error = !(int.Parse(egn[9].ToString()) == sum);
            }

            if (error)
                errorProvider.SetError(textBox, "Невалидно ЕГН!");
            else
                errorProvider.SetError(textBox, "");
            return error;

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
            if (resident != null)
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

        public void SetGroupBoxValue(int index, params RadioButton[] radioButtons)
        {
            radioButtons[index].Checked = true;
        }


        private void PersonsForm_Load(object sender, EventArgs e)
        {

        }

        private void radioButtonHousehold_CheckedChanged(object sender, EventArgs e)
        {
            SetOwner(true, (RadioButton)sender);

        }

        private void groupBox4_Enter(object sender, EventArgs e)
        {

        }

        private void radioButtonGuest_CheckedChanged(object sender, EventArgs e)
        {
            SetOwner(false, (RadioButton)sender);
            if (textBoxOwner.Enabled == false)
            {
                textBoxOwner.Text = "";
                textBoxOwner.Enabled = true;
            }
        }

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



        private void buttonSave_Click(object sender, EventArgs e)
        {
            Person personToSave;
            if(resident == null && person == null)
                resident = new Resident();
            if (resident != null)
            {
                personToSave = resident;
                Resident residentToSave = (Resident)personToSave;
                residentToSave.AddressReg = GetGroupBoxValue(radioButtonAddrRegNo, radioButtonAddrRegYes, radioButtonAddrRegTemp);
                residentToSave.Covid19 = GetGroupBoxValue(radioButtonCovid19No, radioButtonCovid19Yes, radioButtonCovid19Contact);

            }
            else
            {
                personToSave = person;
            }

            personToSave.Firstname = textBoxFName.Text;
            personToSave.Middlename = textBoxMName.Text;
            personToSave.Lastname = textBoxLName.Text;
            personToSave.Egn = textBoxEGN.Text;
            personToSave.RelToOwner = textBoxOwner.Text;
            personToSave.Gender = GetGroupBoxValue(radioButtonMale, radioButtonFemale);
           


            if (radioButtonHousehold.Checked || radioButtonGuest.Checked)
            {
                if (validate())
                {
                    Hide();
                }
            }   
            else
                errorProvider.SetError(groupBoxOwner, "Моля изберете опция!");



        }

        private void PersonsForm_FormClosed(object sender, FormClosedEventArgs e)
        {
            canceled = true;
            Hide();
        }
    }
}
