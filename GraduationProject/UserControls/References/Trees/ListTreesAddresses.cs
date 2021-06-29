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
    public partial class ListTreesAddresses : UserControl
    {
        TreeAddressesData treeAddressesData;

        public struct TreeAddressesData
        {
            public List<Address> addresses;
            public string tree;
        }
        [Browsable(true)]
        [Category("Action")]
        [Description("Invoked when address is clicked")]
        public EventHandler AddressClicked;
        public ListTreesAddresses(TreeAddressesData treeAddressesData)
        {
            InitializeComponent();
            this.treeAddressesData = treeAddressesData;
            if (treeAddressesData.addresses.Count == 0)
            {
                labelNoAddresses.Visible = true;
                listBoxAddresses.Visible = false;
            }
            listBoxAddresses.ItemClicked += ShowAddress;
            listBoxAddresses.AddList(treeAddressesData.addresses.Cast<object>().ToList());

        }

        private void ShowAddress(object sender, EventArgs eventArgs)
        {
            int selectedIndex = (int)sender;
            ShowAddress.TreeAddressData treeAddressData = new ShowAddress.TreeAddressData()
            {
                address = treeAddressesData.addresses[selectedIndex],
                tree = treeAddressesData.tree
            };
            AddressClicked(new MainForm.EventData("showTrees", treeAddressData), eventArgs);

        }
    }
}
