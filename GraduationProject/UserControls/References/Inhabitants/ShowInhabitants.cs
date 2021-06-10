using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Linq;
using System.Windows.Forms;
using GraduationProject.Models;
using GraduationProject.Forms;
namespace GraduationProject.UserControls.References
{
    public partial class ShowInhabitants : UserControl
    {
        List<Inhabitant> inhabitants;
        [Browsable(true)]
        [Category("Action")]
        [Description("Invoked when inhabitant is clicked")]
        public EventHandler InhabitantClicked;

        public ShowInhabitants(List<Inhabitant> inhabitantsArg)
        {
            InitializeComponent();
            inhabitants = inhabitantsArg;
            if (inhabitants.Count == 0)
            {
                labelNoInhabitants.Visible = true;
                listBoxInhabitants.Visible = false;
            }
            listBoxInhabitants.AddList(inhabitants.Cast<object>().ToList());
            listBoxInhabitants.ItemClicked += ShowInhabitantsEvent;

        }

        private void ShowInhabitantsEvent(object sender, EventArgs eventArgs)
        {
            int selectedIndex = (int)sender;
            InhabitantClicked(new MainForm.EventData("showInhabitant", inhabitants[selectedIndex]), eventArgs);
        }
    }
}
