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
        ConnectionHelper connectionHelper = new ConnectionHelper();
        Address address;
        ErrorProvider errorProvider = new ErrorProvider();
        public PersonsForm(Address addr)
        {
            InitializeComponent();
            address = addr;
            address.id = 5;

        }

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
                sum = sum < 10 ? sum : 0;
                error = !(int.Parse(egn[9].ToString()) == sum % 11);
            }
            
            if (error)
                errorProvider.SetError(textBox, "Невалидно ЕГН!");
            else
                errorProvider.SetError(textBox, "");
            return error;

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
                if (((TextBox)textBoxes[i,0]).Text == "")
                {
                    errorProvider.SetError((TextBox)textBoxes[i, 0], "Моля въведете " + (string)textBoxes[i, 1]+"!");
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

        public int GetGroupBoxValue(params RadioButton[] radioButtons)
        {
            for (int i = 0; i < radioButtons.Length; i++)
            {
                if (radioButtons[i].Checked)
                    return i;
            }
            return -1;
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
            Resident resident = new Resident();
            resident.firstname = textBoxFName.Text;
            resident.middlename = textBoxMName.Text;
            resident.lastname = textBoxLName.Text;
            resident.egn = textBoxEGN.Text;
            resident.relToOwner = textBoxOwner.Text;
            resident.gender = GetGroupBoxValue(radioButtonMale,radioButtonFemale);
            resident.addressId = address.id;



            if (radioButtonGuest.Checked)
            {
                if (validate())
                {
                    Person person = resident;
                    Person.InsertPerson(person, connectionHelper);
                }

            }
            else if (radioButtonHousehold.Checked)
            {
                if (validate())
                {
                    resident.addressReg = GetGroupBoxValue(radioButtonAddrRegNo, radioButtonAddrRegYes, radioButtonAddrRegTemp);
                    resident.covid19 = GetGroupBoxValue(radioButtonCovid19No, radioButtonCovid19Yes, radioButtonCovid19Contact);
                    Resident.InsertResident(resident, connectionHelper);
                }

            }
            else
                errorProvider.SetError(groupBoxOwner, "Моля изберете опция!");



        }
    }
}
