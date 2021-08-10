using System;
using System.ComponentModel;
using System.Windows.Forms;

namespace GraduationProject.UserControls.InsertData.Addresses
{
    public partial class AddressesMenu : UserControl
    {
        [Browsable(true)]
        [Category("Action")]
        [Description("Invoked when button is clicked")]
        public event EventHandler ButtonClicked;
        public AddressesMenu()
        {
            InitializeComponent();
        }

        private void buttonNewAddresse_Click(object sender, EventArgs e)
        {
            ButtonClicked(new Forms.MainForm.EventData("createAddress"), e);

        }

        private void buttonEditAddress_Click(object sender, EventArgs e)
        {
            ButtonClicked(new Forms.MainForm.EventData("editAddress"), e);

        }
    }
}
