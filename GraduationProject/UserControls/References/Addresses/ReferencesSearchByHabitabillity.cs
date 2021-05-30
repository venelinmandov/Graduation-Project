using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using GraduationProject.Models;
using GraduationProject.Forms;

namespace GraduationProject.UserControls.References.Addresses
{
    public partial class ReferencesSearchByHabitabillity : UserControl
    {
        [Browsable(true)]
        [Category("Action")]
        [Description("Invoked when show button was clicked.")]
        public event EventHandler ShowButtonClicked;
        public ReferencesSearchByHabitabillity()
        {
            InitializeComponent();
        }

        private void buttonShow_Click(object sender, EventArgs e)
        {
            Address.AddressHabitability addressHabitabillity;
            if (radioButtonInhabited.Checked)
            {
                addressHabitabillity = Address.AddressHabitability.Inhabited;
            }
            else if (radioButtonTemporary.Checked)
            {
                addressHabitabillity = Address.AddressHabitability.TemporaryInhabited;
            }
            else if (radioButtonDesolate.Checked)
            {
                addressHabitabillity = Address.AddressHabitability.Desolate;
            }
            else if (radioButtonOutOfRegulation.Checked)
            {
                addressHabitabillity = Address.AddressHabitability.OutOfRegulation;
            }
            else
                return;

            List<Address> addresses = new Address().Get(new ConnectionHelper(), addressHabitabillity);
            ShowButtonClicked(new MainForm.EventData("showAddresses", addresses),e);
        }
    }
}
