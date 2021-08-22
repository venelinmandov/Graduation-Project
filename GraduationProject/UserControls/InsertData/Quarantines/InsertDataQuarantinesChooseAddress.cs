using GraduationProject.Models;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace GraduationProject.UserControls.InsertData.Quarantines
{
    public partial class InsertDataQuarantinesChooseAddress : UserControl
    {
        ConnectionHelper connectionHelper = new ConnectionHelper();
        List<Street> streets;
        List<Address> addresses;
        Color activeButtoncolor = Color.FromArgb(70, 90, 30);
        Color inactiveButtoncolor = Color.FromArgb(50, 70, 90, 30);
        bool buttonsEnabled = false;
        Type quarantineType;

        [Browsable(true)]
        [Category("Action")]
        [Description("Invoked when button is clicked")]
        public event EventHandler ButtonClicked;

        public InsertDataQuarantinesChooseAddress(Type quarType)
        {
            InitializeComponent();
            quarantineType = quarType;
            comboBoxStreet.DrawItem += comboBox_DrawItem;
            comboBoxNumber.DrawItem += comboBox_DrawItem;

            if (quarantineType == typeof(InhabitantsQuarantine))
            {
                labelTitle.Text = "Карантини на обитатели";
                labelNoAnimalsInhabitants.Text = "За имота на този адрес няма въведени обитатели";
                buttonShow.Click += buttonShowInhabitantsQuarantines_Click;
            }
            else if (quarantineType == typeof(AnimalsQuarantine))
            {
                labelTitle.Text = "Карантини на селскостопански животни";
                labelNoAnimalsInhabitants.Text = "За имота на този адрес няма въведени селскостопански животни";

                buttonShow.Click += buttonShowAnimalsQuarantines_Click;
            }

            streets = new Street().Get(connectionHelper);
            comboBoxStreet.Items.AddRange(streets.ToArray());
        }

        private void comboBoxStreet_SelectedIndexChanged(object sender, EventArgs e)
        {
            labelNoAnimalsInhabitants.Visible = false;
            addresses = new Address().Get(connectionHelper, streets[comboBoxStreet.SelectedIndex]);
            labelNoAddresses.Visible = addresses.Count == 0;
            labelTitle.Visible = addresses.Count != 0;
            EnableButtons(addresses.Count != 0);
            comboBoxNumber.DisplayMember = "Number";
            comboBoxNumber.DataSource = addresses;
        }

        private void comboBox_DrawItem(object sender, DrawItemEventArgs e)
        {
            if (e.Index == -1) return;
            string itemText;
            var combo = sender as ComboBox;
            SolidBrush solidBrush;
            if ((e.State & DrawItemState.Selected) == DrawItemState.Selected)
            {
                e.Graphics.FillRectangle(new SolidBrush(Color.FromArgb(70, 90, 30)), e.Bounds);
                solidBrush = new SolidBrush(SystemColors.Control);
            }
            else
            {
                e.Graphics.FillRectangle(new SolidBrush(SystemColors.Window), e.Bounds);
                solidBrush = new SolidBrush(Color.Black);
            }


            if (combo.DisplayMember.Equals(""))
            {
                itemText = combo.Items[e.Index].ToString();
            }
            else
            {
                itemText = ((int)combo.Items[e.Index].GetType().GetProperty(combo.DisplayMember).GetValue(combo.Items[e.Index], null)).ToString();
            }

            e.Graphics.DrawString(itemText, e.Font, solidBrush, new Point(e.Bounds.X, e.Bounds.Y));

        }

        private void EnableButtons(bool enable)
        {
            buttonsEnabled = enable;
            if (enable)
            {
                buttonShow.BackColor = activeButtoncolor;
            }
            else
            {
                buttonShow.BackColor = inactiveButtoncolor;
            }
        }

        private void buttonShowInhabitantsQuarantines_Click(object sender, EventArgs e)
        {
            if (!buttonsEnabled) return;
            ButtonClicked(new Forms.MainForm.EventData("insertDataInhabitantsQuarantines", addresses[comboBoxNumber.SelectedIndex]), e);

        }

        private void buttonShowAnimalsQuarantines_Click(object sender, EventArgs e)
        {
            if (!buttonsEnabled) return;
            ButtonClicked(new Forms.MainForm.EventData("insertDataAnimalsQuarantines", addresses[comboBoxNumber.SelectedIndex]), e);
        }

        private void comboBoxNumber_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (comboBoxNumber.Text == "") return;
            Address selectedAddress = addresses[comboBoxNumber.SelectedIndex];
            bool error = false;
            if (quarantineType == typeof(AnimalsQuarantine))
            {
                List<Dog> dogs = new Dog().Get(connectionHelper, selectedAddress);

                error = (dogs.Count == 0 &&
                    selectedAddress.NumCows == 0 &&
                    selectedAddress.NumSheep == 0 &&
                    selectedAddress.NumGoats == 0 &&
                    selectedAddress.NumHorses == 0 &&
                    selectedAddress.NumDonkeys == 0 &&
                    selectedAddress.NumFeathered == 0 &&
                    selectedAddress.NumPigs == 0);


            }
            else if (quarantineType == typeof(InhabitantsQuarantine))
            {
                error = new Inhabitant().Get(connectionHelper, selectedAddress).Count == 0;
            }

            labelTitle.Visible = !error;
            labelNoAnimalsInhabitants.Visible = error;
            EnableButtons(!error);


        }
    }
}
