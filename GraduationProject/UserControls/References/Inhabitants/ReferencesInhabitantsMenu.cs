using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using GraduationProject.Forms;

namespace GraduationProject.UserControls.References
{
    public partial class ReferencesInhabitantsMenu : UserControl
    {
        [Browsable(true)] [Category("Action")]
        [Description("Invoked when button was clicked")]
        public event EventHandler buttonClicked;
        public ReferencesInhabitantsMenu()
        {
            InitializeComponent();
        }

        private void buttonByName_Click(object sender, EventArgs e)
        {
            buttonClicked(new ReferenceFormMain.EventData("inhabitantsByName"),e);
        }

        private void buttonByAddrReg_Click(object sender, EventArgs e)
        {
            buttonClicked(new ReferenceFormMain.EventData("inhabitantsByReg"), e);
            
        }

        private void buttonPropetyStatus_Click(object sender, EventArgs e)
        {
            buttonClicked(new ReferenceFormMain.EventData("inhabitantsByProp"), e);
            
        }

        private void buttonResidenceStatus_Click(object sender, EventArgs e)
        {
            buttonClicked(new ReferenceFormMain.EventData("inhabitantsByResidence"), e);  
        }
    }
}
