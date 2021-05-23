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
        string previousState; 
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
                    panelContents.Controls.Clear();
                    ReferencesMenu referencesMenu = new ReferencesMenu();
                    panelContents.Controls.Add(referencesMenu);
                    referencesMenu.ButtonClicked += MenuButtonClicked;
                    previousState = "";
                    break;
                case "addresses":
                    panelContents.Controls.Clear();
                    UserControls.References.ReferencesSearchByAddress byAddressControl = new UserControls.References.ReferencesSearchByAddress();
                    byAddressControl.SearchButtonClicked += MenuButtonClicked;
                    panelContents.Controls.Add(byAddressControl);
                    previousState = "menu";
                    break;
                case "animals":
                    panelContents.Controls.Clear();
                    UserControls.References.ReferencesSearchByAnimals searchByAnimals = new UserControls.References.ReferencesSearchByAnimals();
                    searchByAnimals.SearchButtonClicked += MenuButtonClicked;
                    panelContents.Controls.Add(searchByAnimals);
                    previousState = "menu";
                    break;
                case "showAddress":
                    panelContents.Controls.Clear();
                    panelContents.Controls.Add(new UserControls.References.ShowAddress((Address)eventData.data));
                    previousState = "menu";
                    break;
                case "showAddresses":
                    panelContents.Controls.Clear();
                    UserControls.References.ShowAddresses showAddresses = new UserControls.References.ShowAddresses((List<Address>)eventData.data);
                    showAddresses.AddressClicked += MenuButtonClicked;
                    panelContents.Controls.Add(showAddresses);
                    previousState = "menu";
                    break;
                case "inhabitants":
                    panelContents.Controls.Clear();
                    UserControls.References.ReferencesInhabitantsMenu referencesInhabitantsMenu = new UserControls.References.ReferencesInhabitantsMenu();
                    referencesInhabitantsMenu.buttonClicked += MenuButtonClicked;
                    panelContents.Controls.Add(referencesInhabitantsMenu);
                    previousState = "menu";
                    break;
                case "inhabitantsByName":
                    panelContents.Controls.Clear();
                    UserControls.References.Inhabitants.ReferencesInhabitantsSearchByName inhabitantsSearchByName = new UserControls.References.Inhabitants.ReferencesInhabitantsSearchByName();
                    panelContents.Controls.Add(inhabitantsSearchByName);
                    previousState = "menu";
                    break;

                default: break;
                    
            }

        }

        private void buttonBack_Click(object sender, EventArgs e)
        {
            MenuButtonClicked(new EventData(previousState), new EventArgs());
        }

        private void ShowAddress(object sender, EventArgs e)
        {
            MenuButtonClicked(new EventData(previousState), new EventArgs());
        }
    }
}
