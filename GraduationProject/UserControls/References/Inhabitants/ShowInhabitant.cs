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


        Dictionary<Inhabitant.AddressRegistrationEnum, string> addressRegDict = new Dictionary<Inhabitant.AddressRegistrationEnum, string>()
        {
            {Inhabitant.AddressRegistrationEnum.No, "Няма в населеното място" },
            {Inhabitant.AddressRegistrationEnum.Permanent, "Постоянен адрес" },
            {Inhabitant.AddressRegistrationEnum.Current, "Настоящ адрес" }
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
            labelPhoneValue.Text = inhabitant.PhoneNumber;
            labelAddressValue.Text = new Address().Get(new ConnectionHelper(), inhabitant.AddressId).ToString();
            richTextBoxNotes.Text = inhabitant.Note;
            labelAddressValue.Text = new Address().Get(connectionHelper, inhabitant.AddressId).ToString();
            labelPropertyStateValue.Text = ownershipDict[inhabitant.OwnershipState];
            labelResidenceStateValue.Text = inhabitant.ResidenceState == Inhabitant.ResidenceStateEnum.Permanent ? "Постоянно" : "Временно";
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
                    foreach (Control control in Controls)
                    {
                        control.Location = new Point(control.Location.X, control.Location.Y + 14);
                    }
                    labelPermanentAddressValue.Text = new Address().Get(connectionHelper, inhabitant.PermanentAddressId).ToString();

                    break;
                case Inhabitant.AddressRegistrationEnum.Current:
                    labelPermanentAddressValue.Text = inhabitant.PermanentAddressId == -1 ? "Не е в нас. място" : new Address().Get(connectionHelper, inhabitant.PermanentAddressId).ToString();
                    labelCurrentAddressValue.Text = new Address().Get(connectionHelper, inhabitant.CurrentAddressId).ToString();
                    break;
                case Inhabitant.AddressRegistrationEnum.No:
                    labelCurrentAddress.Visible = false;
                    labelCurrentAddressValue.Visible = false;
                    foreach (Control control in Controls)
                    {
                        control.Location = new Point(control.Location.X, control.Location.Y + 14);
                    }
                    labelPermanentAddressValue.Text = "Не е в нас. място";
                    break;

            }
          
        }
    }
}
