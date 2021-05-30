using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using GraduationProject.Models;
using GraduationProject.Forms;

namespace GraduationProject.UserControls.References.Inhabitants
{
    public partial class ReferencesInhabitantsSearchByName : UserControl
    {
        [Browsable(true)] [Category("Action")]
        [Description("Invoked when show button was clicked.")]
        public event EventHandler ShowButtonClicked;
        public ReferencesInhabitantsSearchByName()
        {
            InitializeComponent();
        }

        private void buttonShow_Click(object sender, EventArgs e)
        {
            if (textBoxFirstname.Text.Trim() == "" && textBoxMiddlename.Text.Trim() == "" && textBoxLastname.Text.Trim() == "")
                return;
            ConnectionHelper connectionHelper = new ConnectionHelper();
            List<Person> persons = new Person().Get(connectionHelper, textBoxFirstname.Text, textBoxMiddlename.Text, textBoxLastname.Text);
            List<Resident> residents = new Resident().Get(connectionHelper, textBoxFirstname.Text, textBoxMiddlename.Text, textBoxLastname.Text);
            ShowInhabitants.PersonsStruct personsStruct = new ShowInhabitants.PersonsStruct()
            {
                guests = persons,
                residents = residents
            };

            ShowButtonClicked(new MainForm.EventData("showInhabitants",personsStruct),e);
        }
    }
}
