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

    public partial class ReferencesSearchByAddress : UserControl
    {
        List<Address> addresses;
        List<Street> streets;
        ConnectionHelper connectionHelper = new ConnectionHelper();

        [Browsable(true)]
        [Category("Action")]
        [Description("Invoked when search button is clicked")]
        public EventHandler SearchButtonClicked;
        public ReferencesSearchByAddress()
        {
            InitializeComponent();
            streets = new Street().Get(connectionHelper);
            if (streets.Count == 0) return;
            comboBoxStreet.Items.AddRange(streets.ToArray());
        }

        /// <summary>
        /// Актуализиране на комбобокса със номера на адреси при избор на улица 
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void comboBoxStreet_SelectedIndexChanged(object sender, EventArgs e)
        {
            comboBoxNumber.Items.Clear();
            addresses = new Address().Get(connectionHelper, streets[comboBoxStreet.SelectedIndex]);
            if (addresses.Count > 0)
            {
                foreach (Address address in addresses)
                {
                    comboBoxNumber.Items.Add(address.Number);
                }
                comboBoxNumber.SelectedIndex = 0;  
            }
            else
            {
                comboBoxNumber.Text = "";
            }
        }

        /// <summary>
        /// Визуализиране на информацията за избрания адрес
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void buttonSearch_Click(object sender, EventArgs e)
        {
            if (comboBoxStreet.Text == "" || comboBoxNumber.Text == "") return;
            Address adr = (from Address in addresses where Address.Number == int.Parse(comboBoxNumber.Text) select Address).First();
            SearchButtonClicked(new MainForm.EventData("showAddress", adr), new EventArgs());
        }
    }
}
