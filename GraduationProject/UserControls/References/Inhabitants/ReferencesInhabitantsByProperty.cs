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

namespace GraduationProject.UserControls.References.Inhabitants
{
    public partial class ReferencesInhabitantsByProperty : UserControl
    {
        [Browsable(true)]
        [Category("Action")]
        [Description("Invoked when show button was clicked.")]
        public event EventHandler ShowButtonClicked;
        public ReferencesInhabitantsByProperty()
        {
            InitializeComponent();
        }

        /// <summary>
        /// Показване на жителите/гостите със избрания статус на собственост
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void buttonShow_Click(object sender, EventArgs e)
        {
            ConnectionHelper connectionHelper = new ConnectionHelper();
            List<Inhabitant> inhabitants;
            if (radioButtonGuest.Checked)
            {
                inhabitants = new Inhabitant().Get(connectionHelper, Inhabitant.OwnershipStateEnum.Guest);
            }
            else if (radioButtonOwner.Checked)
            {
                inhabitants = new Inhabitant().Get(connectionHelper, Inhabitant.OwnershipStateEnum.Owner);
            }
            else if (radioButtonResident.Checked)
            {
                inhabitants = new Inhabitant().Get(connectionHelper, Inhabitant.OwnershipStateEnum.Resident);
            }
            else return;
               
            ShowButtonClicked(new MainForm.EventData("showInhabitants", inhabitants), e);
        }
    }
}
