using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using GraduationProject.Models;
using GraduationProject.Forms;

namespace GraduationProject.UserControls.References
{
    public partial class ReferencesSearchByAnimals : UserControl
    {
        [Browsable(true)][Category("Action")]
        [Description("Invoked when search button is clicked")]
        public EventHandler SearchButtonClicked;
        ConnectionHelper connectionHelper = new ConnectionHelper(); 

        Dictionary<string, string> animals = new Dictionary<string, string>(){
            { "Крави", "numCows"},
            { "Овце", "numSheep"},
            { "Кози", "numGoats"},
            { "Коне", "numHorses"},
            { "Магарета", "numDonkeys"},
            { "Пернати", "numFeathered"},
            { "Свине", "numPigs" }
        };
        public ReferencesSearchByAnimals()
        {
            InitializeComponent();
        }

        /// <summary>
        /// Показване на адресите, на които се отглежда избраното селскостопанско животно
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void buttonShowCattle_Click(object sender, EventArgs e)
        {
            if (comboBoxCattle.Text == "") return;
            List<Address> addresses = new Address().Get(connectionHelper,animals[comboBoxCattle.Text]);
            SearchButtonClicked(new MainForm.EventData("showAddresses", addresses), new EventArgs());
        }

        /// <summary>
        /// Показване на адресите, на които се отглежда избрания вид куче
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void buttonShowDogs_Click(object sender, EventArgs e)
        {
            List<Address> addresses;
            if (radioButtonGuardDog.Checked)
            {
                addresses = new Address().Get(connectionHelper, Dog.DogType.GuardDog);
            }
            else if (radioButtonHuntingDog.Checked)
            {
                addresses = new Address().Get(connectionHelper, Dog.DogType.HuntingDog);
            }
            else if (radioButtonDomesticDog.Checked)
            {
                addresses = new Address().Get(connectionHelper, Dog.DogType.DomesticDog);
            }
            else if (radioButtonDogAll.Checked)
            {
                addresses = new Address().Get(connectionHelper, Dog.DogType.All);
            }
            else
                return;

            SearchButtonClicked(new MainForm.EventData("showAddresses", addresses), new EventArgs());

        }

        private void comboBoxCattle_DrawItem(object sender, DrawItemEventArgs e)
        {
            if (e.Index == -1) return;
            var combo = sender as ComboBox;
            SolidBrush solidBrush;
            if ((e.State & DrawItemState.Selected) == DrawItemState.Selected)
            {
                e.Graphics.FillRectangle(new SolidBrush(Color.FromArgb(50, 80, 40)), e.Bounds);
                solidBrush = new SolidBrush(SystemColors.Control);
            }
            else
            {
                e.Graphics.FillRectangle(new SolidBrush(SystemColors.Window), e.Bounds);
                solidBrush = new SolidBrush(Color.Black);
            }

            e.Graphics.DrawString(combo.Items[e.Index].ToString(),
                                          e.Font,
                                          solidBrush,
                                          new Point(e.Bounds.X, e.Bounds.Y));
        }
    }
}
