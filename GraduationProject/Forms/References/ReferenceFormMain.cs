using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using GraduationProject.UserControls;
using GraduationProject.Models;

namespace GraduationProject.Forms
{
    public partial class ReferenceFormMain : Form
    {
        Stack<UserControl> userControls = new Stack<UserControl>();
        public ReferenceFormMain()
        {
            InitializeComponent();
            MenuButtonClicked(new EventData("menu"), new EventArgs());


        }
        public struct EventData
        {
            public EventData(string name)
            {
                panelName = name;
                data = null;
            }
            public EventData(string name,object d): this(name)
            {
                data = d;
            }
            public string panelName;
            public object data;
        }

        void MenuButtonClicked(object sender, EventArgs eventArgs)
        {
            EventData eventData = (EventData)sender;
            switch (eventData.panelName)
            {
                case "menu":
                    ReferencesMenu referencesMenu = new ReferencesMenu();
                    panelContents.Controls.Add(referencesMenu);
                    referencesMenu.BringToFront();
                    referencesMenu.ButtonClicked += MenuButtonClicked;
                    break;
                case "addresses":
                    UserControls.References.ReferencesSearchByAddress byAddressControl = new UserControls.References.ReferencesSearchByAddress();
                    userControls.Push(byAddressControl);
                    byAddressControl.SearchButtonClicked += MenuButtonClicked;
                    panelContents.Controls.Add(byAddressControl);
                    byAddressControl.BringToFront();
                    break;
                case "animals":
                    UserControls.References.ReferencesSearchByAnimals searchByAnimals = new UserControls.References.ReferencesSearchByAnimals();
                    userControls.Push(searchByAnimals);
                    searchByAnimals.SearchButtonClicked += MenuButtonClicked;
                    panelContents.Controls.Add(searchByAnimals);
                    searchByAnimals.BringToFront();
                    break;
                case "showAddress":
                    UserControls.References.ShowAddress showAddress = new UserControls.References.ShowAddress((Address)eventData.data);
                    panelContents.Controls.Add(showAddress);
                    showAddress.BringToFront();
                    userControls.Push(showAddress);
                    break;
                case "showAddresses":
                    UserControls.References.ShowAddresses showAddresses = new UserControls.References.ShowAddresses((List<Address>)eventData.data);
                    userControls.Push(showAddresses);
                    showAddresses.AddressClicked += MenuButtonClicked;
                    panelContents.Controls.Add(showAddresses);
                    showAddresses.BringToFront();
                    break;
                case "inhabitants":
                    UserControls.References.ReferencesInhabitantsMenu referencesInhabitantsMenu = new UserControls.References.ReferencesInhabitantsMenu();
                    userControls.Push(referencesInhabitantsMenu);
                    referencesInhabitantsMenu.buttonClicked += MenuButtonClicked;
                    panelContents.Controls.Add(referencesInhabitantsMenu);
                    referencesInhabitantsMenu.BringToFront();
                    break;
                case "inhabitantsByName":
                    UserControls.References.Inhabitants.ReferencesInhabitantsSearchByName inhabitantsSearchByName = new UserControls.References.Inhabitants.ReferencesInhabitantsSearchByName();
                    userControls.Push(inhabitantsSearchByName);
                    inhabitantsSearchByName.ShowButtonClicked += MenuButtonClicked;
                    panelContents.Controls.Add(inhabitantsSearchByName);
                    inhabitantsSearchByName.BringToFront();
                    break;
                case "inhabitantsByReg":
                    UserControls.References.Inhabitants.ReferenceInhabitantsSearchByReg inhabitantsSearchByReg = new UserControls.References.Inhabitants.ReferenceInhabitantsSearchByReg();
                    userControls.Push(inhabitantsSearchByReg);
                    inhabitantsSearchByReg.ShowButtonClicked += MenuButtonClicked;
                    panelContents.Controls.Add(inhabitantsSearchByReg);
                    inhabitantsSearchByReg.BringToFront();
                    break;
                case "inhabitantsByProp":
                    UserControls.References.Inhabitants.ReferencesInhabitantsByProperty inhabitantsSearchByProp = new UserControls.References.Inhabitants.ReferencesInhabitantsByProperty();
                    userControls.Push(inhabitantsSearchByProp);
                    inhabitantsSearchByProp.ShowButtonClicked += MenuButtonClicked;
                    panelContents.Controls.Add(inhabitantsSearchByProp);
                    inhabitantsSearchByProp.BringToFront();
                    break;
                case "inhabitantsByResidence":
                    UserControls.References.Inhabitants.ReferencesInhabitantsByResidence inhabitantsSearchByResidence = new UserControls.References.Inhabitants.ReferencesInhabitantsByResidence();
                    userControls.Push(inhabitantsSearchByResidence);
                    inhabitantsSearchByResidence.ShowButtonClicked += MenuButtonClicked;
                    panelContents.Controls.Add(inhabitantsSearchByResidence);
                    inhabitantsSearchByResidence.BringToFront();
                    break;
                case "showInhabitants":
                    UserControls.References.ShowInhabitants showInhabitants = new UserControls.References.ShowInhabitants((UserControls.References.ShowInhabitants.PersonsStruct)eventData.data);
                    userControls.Push(showInhabitants);
                    showInhabitants.InhabitantClicked += MenuButtonClicked;
                    panelContents.Controls.Add(showInhabitants);
                    showInhabitants.BringToFront();
                    break;
                case "showGuest":
                    UserControls.References.Inhabitants.ShowInhabitant showGuest = new UserControls.References.Inhabitants.ShowInhabitant((Person)eventData.data);
                    userControls.Push(showGuest);
                    panelContents.Controls.Add(showGuest);
                    showGuest.BringToFront();
                    break;
                case "showResident":
                    UserControls.References.Inhabitants.ShowInhabitant showResident = new UserControls.References.Inhabitants.ShowInhabitant((Resident)eventData.data);
                    userControls.Push(showResident);
                    panelContents.Controls.Add(showResident);
                    showResident.BringToFront();
                    break;

                default: break;
                    
            }

        }

        private void buttonBack_Click(object sender, EventArgs e)
        {
            if (userControls.Count != 0)
                panelContents.Controls.Remove(userControls.Pop());
        }
    }
}
