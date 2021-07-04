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

        /// <summary>
        /// Показавне на жителите/гостите с дадената адресна речистрациа
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void buttonShow_Click(object sender, EventArgs e)
        {
            List<Inhabitant> inhabitants;
            ConnectionHelper connectionHelper = new ConnectionHelper();

            if (radioButtonPermanent.Checked)
            {
                {
                    inhabitants = new Inhabitant().Get(connectionHelper, Inhabitant.AddressRegistrationEnum.Permanent);
                };
            }
            else if (radioButtonTemporary.Checked)
            {
                {
                    inhabitants = new Inhabitant().Get(connectionHelper, Inhabitant.AddressRegistrationEnum.Current);
                };
            }
            else if (radioButtonWithout.Checked)
            {
                {
                    inhabitants = new Inhabitant().Get(connectionHelper, Inhabitant.AddressRegistrationEnum.No);
                };
            }
            else
                return;

            ShowButtonClicked(new MainForm.EventData("listInhabitants", inhabitants), e);
        }
    }
}
