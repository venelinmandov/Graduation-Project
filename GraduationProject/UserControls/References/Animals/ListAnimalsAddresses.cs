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
namespace GraduationProject.UserControls.References
{
    public partial class ListAnimalAddresses : UserControl
    {
        AnimalsAddressesData animalsAddressesData;

        public struct AnimalsAddressesData
        {
            public List<Address> addresses;
            public string animal;
        }


        [Browsable(true)]
        [Category("Action")]
        [Description("Invoked when address is clicked")]
        public EventHandler AddressClicked;
        public ListAnimalAddresses(AnimalsAddressesData animalsAddressesData)
        {
            InitializeComponent();
            this.animalsAddressesData = animalsAddressesData;
            if (this.animalsAddressesData.addresses.Count == 0)
            {
                labelNoAddresses.Visible = true;
                listBoxAddresses.Visible = false;
            }
            listBoxAddresses.ItemClicked += ShowAddress;
            listBoxAddresses.AddList(animalsAddressesData.addresses.Cast<object>().ToList());

        }

        private void ShowAddress(object sender, EventArgs eventArgs)
        {
            int selectedIndex = (int)sender;
            ShowAddress.AnimalAddressData animalAddressData = new ShowAddress.AnimalAddressData()
            {
                address = animalsAddressesData.addresses[selectedIndex],
                animal = animalsAddressesData.animal
            };
            AddressClicked(new MainForm.EventData("showAnimals", animalAddressData), eventArgs);

        }
    }
}
