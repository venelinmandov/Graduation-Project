using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using GraduationProject.Models;

namespace GraduationProject.UserControls.References.Inhabitants
{
    public partial class ShowInhabitant : UserControl
    {
        public ShowInhabitant(Inhabitant inhabitant)
        {
            InitializeComponent();
            DisplayInhabitant(inhabitant);
        }



        Dictionary<Inhabitant.QuarantineEnum, string> covidDict = new Dictionary<Inhabitant.QuarantineEnum, string>()
        {
            { Inhabitant.QuarantineEnum.Yes,"Има"},
            { Inhabitant.QuarantineEnum.No,"Няма"},
            { Inhabitant.QuarantineEnum.Contact,"Контактен"}
        };

        Dictionary<Inhabitant.AddressRegistrationEnum, string> addressRegDict = new Dictionary<Inhabitant.AddressRegistrationEnum, string>()
        {
            {Inhabitant.AddressRegistrationEnum.No, "Няма в населеното място" },
            {Inhabitant.AddressRegistrationEnum.Permanent, "Постоянен адрес" },
            {Inhabitant.AddressRegistrationEnum.Current, "Настоящ асдрес" }
        };

        Dictionary<Inhabitant.OwnershipStateEnum, string> ownershipDict = new Dictionary<Inhabitant.OwnershipStateEnum, string>()
        {
            {Inhabitant.OwnershipStateEnum.Guest,"Гост" },
            {Inhabitant.OwnershipStateEnum.Owner,"Собственик" },
            {Inhabitant.OwnershipStateEnum.Resident,"Член на семейството" }
        };

        /// <summary>
        /// Показване на информацията за обитателя
        /// </summary>
        /// <param name="inhabitant"></param>
        void DisplayInhabitant(Inhabitant inhabitant)
        {
            ConnectionHelper connectionHelper = new ConnectionHelper();
            labelFirstnameValue.Text = inhabitant.Firstname;
            labelMiddlenameValue.Text = inhabitant.Middlename;
            labelLastnameValue.Text = inhabitant.Lastname;
            labelGenderValue.Text = inhabitant.Gender == 0 ? "Мъж" : "Жена";
            labelAddressValue.Text = new Address().Get(new ConnectionHelper(), inhabitant.AddressId).ToString();
            labelQuarantineValue.Text = covidDict[inhabitant.Quarantine];
            richTextBoxNotes.Text = inhabitant.Note;
            labelAddressValue.Text = new Address().Get(connectionHelper, inhabitant.AddressId).ToString();
            labelPropertyStateValue.Text = ownershipDict[inhabitant.OwnershipState];
            labelResidenceStateValue.Text = inhabitant.ResidenceState == Inhabitant.ResidenceStateEnum.Permanent ? "Временно" : "Постоянно";
            labelAddressRegValue.Text = addressRegDict[inhabitant.AddressReg];
            if (inhabitant.OwnershipState == Inhabitant.OwnershipStateEnum.Owner)
            {
                labelOwnerRel.Visible = false;
                labelOwnerRelValue.Visible = false;
            }
            else
            {
                labelOwnerRelValue.Text = inhabitant.RelToOwner;
            }
            switch (inhabitant.AddressReg)
            {
                case Inhabitant.AddressRegistrationEnum.Permanent:
                    labelCurrentAddress.Visible = false;
                    labelCurrentAddressValue.Visible = false;
                    labelPermanentAddressValue.Text = new Address().Get(connectionHelper, inhabitant.PermanentAddressId).ToString();
                    labelQuarantine.Location = new Point(labelQuarantine.Location.X, labelCurrentAddress.Location.Y);
                    labelQuarantineValue.Location = new Point(labelQuarantineValue.Location.X, labelQuarantine.Location.Y);
                    labelCurrentAddressValue.Text = new Address().Get(connectionHelper, inhabitant.CurrentAddressId).ToString();
                    break;
                case Inhabitant.AddressRegistrationEnum.Current:
                    labelPermanentAddressValue.Text = inhabitant.PermanentAddressId == -1 ? "Не е в населеното място" : new Address().Get(connectionHelper, inhabitant.PermanentAddressId).ToString();
                    labelCurrentAddressValue.Text = new Address().Get(connectionHelper, inhabitant.CurrentAddressId).ToString();
                    break;
                case Inhabitant.AddressRegistrationEnum.No:
                    labelPermanentAddressValue.Text = "Не е в населеното място";
                    break;

            }
          
        }

        private void labelCurrentAddressValue_Click(object sender, EventArgs e)
        {

        }
    }
}
