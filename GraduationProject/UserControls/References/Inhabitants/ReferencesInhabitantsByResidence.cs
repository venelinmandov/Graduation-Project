using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using GraduationProject.Models;
using System.Linq;
using GraduationProject.Forms;

namespace GraduationProject.UserControls.References.Inhabitants
{
    public partial class ReferencesInhabitantsByResidence : UserControl
    {
        [Browsable(true)]
        [Category("Action")]
        [Description("Invoked when show button was clicked.")]

        public event EventHandler ShowButtonClicked;
        public ReferencesInhabitantsByResidence()
        {
            InitializeComponent();
        }

        /// <summary>
        /// Показавне на жителите/гостите със избрания статус на пребиваване
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void buttonShow_Click(object sender, EventArgs e)
        {
            ConnectionHelper connectionHelper = new ConnectionHelper();
            List<Inhabitant> inhabitants;
            if (radioButtonTemporary.Checked)
            {
                inhabitants = new Inhabitant().Get(connectionHelper, Inhabitant.ResidenceStateEnum.Temporary);
            }
            else if (radioButtonPermanent.Checked)
            {
                inhabitants = new Inhabitant().Get(connectionHelper, Inhabitant.ResidenceStateEnum.Permanent);

            }
            else return;
            ShowButtonClicked(new MainForm.EventData("showInhabitants", inhabitants), e);
        }
    }
}
