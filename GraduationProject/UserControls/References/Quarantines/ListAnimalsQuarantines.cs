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
    public partial class ListAnimalsQuarantines : UserControl
    {
        List<Address> addresses;
        AnimalsQuarantine.AnimalEnum animal;
        [Browsable(true)]
        [Category("Action")]
        [Description("Invoked when address is clicked")]
        public EventHandler AddressClicked;

        public struct QuarantinesData
        {
            public List<Address> addresses;
            public AnimalsQuarantine.AnimalEnum animal;
        }
        public ListAnimalsQuarantines(QuarantinesData quarantinesData)
        {
            InitializeComponent();
            addresses = quarantinesData.addresses;
            animal = quarantinesData.animal;
            if (addresses.Count == 0)
            {
                labelNoAddresses.Visible = true;
                listBoxAddresses.Visible = false;
            }
            listBoxAddresses.ItemClicked += ShowQuarantine;
            listBoxAddresses.AddList(addresses.Cast<object>().ToList());

        }

        private void ShowQuarantine(object sender, EventArgs eventArgs)
        {
            Quarantines.ShowAnimalsQuarantines.QuarantineData quarantineData = new Quarantines.ShowAnimalsQuarantines.QuarantineData()
            {
                address = addresses[listBoxAddresses.SelectedIndex],
                animal = animal
            };
                AddressClicked(new MainForm.EventData("showAnimalsQuarantines", quarantineData), eventArgs);
        }
    }
}
