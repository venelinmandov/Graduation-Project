using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using GraduationProject.Models;
using GraduationProject.Forms;
using System.Linq;

namespace GraduationProject.UserControls.References.Inhabitants
{
    public partial class ReferencesInhabitantsByProperty : UserControl
    {
        [Browsable(true)]
        [Category("Action")]
        [Description("Invoked when show button was clicked.")]
        public event EventHandler ShowButtonClicked;
        public ReferencesInhabitantsByProperty()
        {
            InitializeComponent();
        }

        private void buttonShow_Click(object sender, EventArgs e)
        {
            ConnectionHelper connectionHelper = new ConnectionHelper();
            ShowInhabitants.PersonsStruct personsStruct;
            if (radioButtonGuest.Checked)
            {

                personsStruct = new ShowInhabitants.PersonsStruct()
                {
                    guests = new Person().Get(connectionHelper),
                    residents = new List<Resident>()
                };
            }
            else
            {
                List<Resident> residents = new Resident().Get(connectionHelper);
                if (radioButtonOwner.Checked)
                {
                    personsStruct = new ShowInhabitants.PersonsStruct()
                    {
                        guests = new List<Person>(),
                        residents = residents.Where(resident => resident.RelToOwner == "Собственик").ToList()
                    };
                }
                else if (radioButtonResident.Checked)
                {
                    personsStruct = new ShowInhabitants.PersonsStruct()
                    {
                        guests = new List<Person>(),
                        residents = residents.Where(resident => resident.RelToOwner != "Собственик").ToList()
                    };
                }
                else
                    return;
            }
            ShowButtonClicked(new MainForm.EventData("showInhabitants", personsStruct), e);
        }
    }
}
