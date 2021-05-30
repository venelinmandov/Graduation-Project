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
    public partial class ShowAddresses : UserControl
    {
        List<Address> addresses;
        [Browsable(true)]
        [Category("Action")]
        [Description("Invoked when address is clicked")]
        public EventHandler AddressClicked;
        public ShowAddresses(List<Address> addresses)
        {
            InitializeComponent();
            this.addresses = addresses;
            if (addresses.Count == 0)
            {
                labelNoAddresses.Visible = true;
                listBoxAddresses.Visible = false;
            }
            listBoxAddresses.ItemClicked += ShowAddress;
            listBoxAddresses.AddList(addresses.Cast<object>().ToList());

        }

        private void ShowAddress(object sender, EventArgs eventArgs)
        {
            int selectedIndex = (int)sender;
            AddressClicked(new MainForm.EventData("showAddress", addresses[selectedIndex]), eventArgs);

        }
    }
}
