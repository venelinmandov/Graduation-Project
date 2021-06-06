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

        /// <summary>
        /// Показване на опциите за търсене на жители/гости по имена 
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void buttonByName_Click(object sender, EventArgs e)
        {
            buttonClicked(new MainForm.EventData("inhabitantsByName"),e);
        }

        /// <summary>
        /// Показване на опциите за търсене на жители/гости по адресна регистрация
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void buttonByAddrReg_Click(object sender, EventArgs e)
        {
            buttonClicked(new MainForm.EventData("inhabitantsByReg"), e);
            
        }

        /// <summary>
        /// Показване на опциите за търсене на жители/гости по статус на собственост
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void buttonPropetyStatus_Click(object sender, EventArgs e)
        {
            buttonClicked(new MainForm.EventData("inhabitantsByProp"), e);
            
        }

        /// <summary>
        /// Показване на опциите за търсене на жители/гости по статус на пребиваване
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void buttonResidenceStatus_Click(object sender, EventArgs e)
        {
            buttonClicked(new MainForm.EventData("inhabitantsByResidence"), e);  
        }
    }
}
