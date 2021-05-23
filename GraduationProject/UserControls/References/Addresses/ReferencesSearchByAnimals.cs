using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using GraduationProject.Models;
using GraduationProject.Forms;

namespace GraduationProject.UserControls.References
{
    public partial class ReferencesSearchByAnimals : UserControl
    {
        [Browsable(true)][Category("Action")]
        [Description("Invoked when search button is clicked")]
        public EventHandler SearchButtonClicked;
        ConnectionHelper connectionHelper = new ConnectionHelper(); 

        Dictionary<string, string> animals = new Dictionary<string, string>(){
            { "Крави", "numCows"},
            { "Овце", "numSheep"},
            { "Кози", "numGoats"},
            { "Коне", "numHorses"},
            { "Магарета", "numDonkeys"},
            { "Пернати", "numFeathered"},
            { "Свине", "numPigs" }
        };
        public ReferencesSearchByAnimals()
        {
            InitializeComponent();
        }

        private void buttonShowCattle_Click(object sender, EventArgs e)
        {
            if (comboBoxCattle.Text == "") return;
            List<Address> addresses = new Address().Get(connectionHelper,animals[comboBoxCattle.Text]);
            SearchButtonClicked(new ReferenceFormMain.EventData("showAddresses", addresses), new EventArgs());
        }

        private void buttonShowDogs_Click(object sender, EventArgs e)
        {
            List<Address> addresses;
            if (radioButtonGuardDog.Checked)
            {
                addresses = new Address().Get(connectionHelper, Dog.DogType.GuardDog);
            }
            else if (radioButtonHuntingDog.Checked)
            {
                addresses = new Address().Get(connectionHelper, Dog.DogType.HuntingDog);
            }
            else if (radioButtonDomesticDog.Checked)
            {
                addresses = new Address().Get(connectionHelper, Dog.DogType.DomesticDog);
            }
            else if (radioButtonDogAll.Checked)
            {
                addresses = new Address().Get(connectionHelper, Dog.DogType.All);
            }
            else
                return;

            SearchButtonClicked(new ReferenceFormMain.EventData("showAddresses", addresses), new EventArgs());

        }
    }
}
