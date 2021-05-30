using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Linq;
using System.Windows.Forms;
using GraduationProject.Models;
using GraduationProject.Forms;
namespace GraduationProject.UserControls.References
{
    public partial class ShowInhabitants : UserControl
    {
        PersonsStruct personsStruct;
        List<Person> people;
        [Browsable(true)]
        [Category("Action")]
        [Description("Invoked when inhabitant is clicked")]
        public EventHandler InhabitantClicked;

        public struct PersonsStruct
        {
            public List<Person> guests;
            public List<Resident> residents;
        }
        public ShowInhabitants(PersonsStruct persons)
        {
            InitializeComponent();
            this.personsStruct = persons;
            if (persons.guests.Count == 0 && persons.residents.Count == 0)
            {
                labelNoInhabitants.Visible = true;
                listBoxInhabitants.Visible = false;
            }
            people = persons.guests.Concat(persons.residents.Cast<Person>()).ToList();
            people = people.OrderBy(x => x.Firstname).ToList();
            listBoxInhabitants.AddList(people.Cast<object>().ToList());
            listBoxInhabitants.ItemClicked += ShowInhabitantsEvent;

        }

        private void ShowInhabitantsEvent(object sender, EventArgs eventArgs)
        {
            int selectedIndex = (int)sender;
            foreach (Person person in personsStruct.guests)
            {
                if (people[selectedIndex] == person)
                {
                    InhabitantClicked(new MainForm.EventData("showGuest",person), eventArgs);
                    return;
                }
            }
            foreach (Resident resident in personsStruct.residents)
            {
                if (people[selectedIndex] == resident)
                {
                    InhabitantClicked(new MainForm.EventData("showResident", resident), eventArgs);
                    return;
                }
            }
        }
    }
}
