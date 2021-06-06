using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using GraduationProject.Models;

namespace GraduationProject.UserControls.References.Inhabitants
{
    public partial class ShowInhabitant : UserControl
    {
        public ShowInhabitant(Person person)
        {
            InitializeComponent();
            ShowPerson(person);
        }

        public ShowInhabitant(Resident resident) : this ((Person)resident)
        {
            ShowResident(resident);

        }

        Dictionary<Person.Covid19Enum, string> covidDict = new Dictionary<Person.Covid19Enum, string>()
        {
            { Person.Covid19Enum.Yes,"Има"},
            { Person.Covid19Enum.No,"Няма"},
            { Person.Covid19Enum.Contact,"Контактен"}
        };

        Dictionary<Resident.AddressRegistration, string> addressRegDict = new Dictionary<Resident.AddressRegistration, string>()
        {
            {Resident.AddressRegistration.No, "Без регистрация" },
            {Resident.AddressRegistration.Yes, "Постоянен адрес" },
            {Resident.AddressRegistration.Temporary, "Настоящ асдрес" }
        };

        /// <summary>
        /// Показване на информацията за госта
        /// </summary>
        /// <param name="person"></param>
        void ShowPerson(Person person)
        {
            labelFirstnameValue.Text = person.Firstname;
            labelMiddlenameValue.Text = person.Middlename;
            labelLastnameValue.Text = person.Lastname;
            labelGenderValue.Text = person.Gender == 0 ? "Мъж" : "Жена";
            labelAddressValue.Text = new Address().Get(new ConnectionHelper(), person.AddressId).ToString();
            labelCurrentAddressValue.Text = person.CurrentAddressId == -1 ? "Няма":
                new Address().Get(new ConnectionHelper(), person.CurrentAddressId).ToString();
            labelPropertyStateValue.Text = "Гост: " + person.RelToOwner;
            labelResidenceStateValue.Text = person.CurrentAddressId == -1 ? "Постоянно" : "Временно";
            labelAddressRegValue.Text = "Гост";
            labelCovid19Value.Text = covidDict[person.Covid19];
            richTextBoxNotes.Text = person.Note;
          
        }

        /// <summary>
        /// Показване на информацията за жителя
        /// </summary>
        /// <param name="resident"></param>
        void ShowResident(Resident resident)
        {
            if (resident.RelToOwner == "Собственик")
                labelPropertyStateValue.Text = "Собственик";
            else
                labelPropertyStateValue.Text = "Член на домакинството: " + resident.RelToOwner;
            labelAddressRegValue.Text = addressRegDict[resident.AddressReg];
        }
        

    }
}
