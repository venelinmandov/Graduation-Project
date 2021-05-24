using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using GraduationProject.Forms;
using GraduationProject.Models;
using GraduationProject.UserControls;

namespace GraduationProject.UserControls.References.Inhabitants
{
    public partial class ReferenceInhabitantsSearchByReg : UserControl
    {
        public ReferenceInhabitantsSearchByReg()
        {
            InitializeComponent();
        }

        [Browsable(true)]
        [Category("Action")]
        [Description("Invoked when show button was clicked.")]
        public event EventHandler ShowButtonClicked;

        private void buttonShow_Click(object sender, EventArgs e)
        {
            UserControls.References.ShowInhabitants.PersonsStruct personsStruct;
            ConnectionHelper connectionHelper = new ConnectionHelper();

            if (radioButtonYes.Checked)
            {
                personsStruct = new ShowInhabitants.PersonsStruct()
                {
                    guests = new List<Person>(),
                    residents = new Resident().Get(connectionHelper, Resident.AddressRegistration.Yes)
                };
            }
            else if (radioButtonTemporary.Checked)
            {
                personsStruct = new ShowInhabitants.PersonsStruct()
                {
                    guests = new List<Person>(),
                    residents = new Resident().Get(connectionHelper, Resident.AddressRegistration.Temporary)
                };
            }
            else if (radioButtonWithout.Checked)
            {
                personsStruct = new ShowInhabitants.PersonsStruct()
                {
                    guests = new Person().Get(connectionHelper),
                    residents = new Resident().Get(connectionHelper, Resident.AddressRegistration.No)
                };
            }
            else
                return;

            ShowButtonClicked(new ReferenceFormMain.EventData("showInhabitants", personsStruct), e);
        }
    }
}
