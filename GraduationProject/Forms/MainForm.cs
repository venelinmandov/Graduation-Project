using GraduationProject.Models;
using GraduationProject.UserControls;
using System;
using System.Collections.Generic;
using System.Windows.Forms;

namespace GraduationProject.Forms
{
    public partial class MainForm : Form
    {
        Stack<UserControl> userControls = new Stack<UserControl>();
        public MainForm()
        {
            InitializeComponent();
            MenuButtonClicked(new EventData("menu"), new EventArgs());
            pictureBoxBack.Visible = false;


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
                    MenuUserControl menuUserControl = new MenuUserControl();
                    panelContents.Controls.Add(menuUserControl);
                    menuUserControl.BringToFront();
                    menuUserControl.ButtonClicked += MenuButtonClicked;
                    menuUserControl.Location = new System.Drawing.Point(0,58);
                    break;
                #region Справки
                case "references":
                    ReferencesMenu referencesMenu = new ReferencesMenu();
                    AddControl(referencesMenu);
                    panelContents.Controls.Add(referencesMenu);
                    referencesMenu.BringToFront();
                    referencesMenu.ButtonClicked += MenuButtonClicked;
                    break;
                case "addresses":
                    UserControls.References.ReferencesSearchByAddress byAddressControl = new UserControls.References.ReferencesSearchByAddress();
                    AddControl(byAddressControl);
                    byAddressControl.SearchButtonClicked += MenuButtonClicked;
                    panelContents.Controls.Add(byAddressControl);
                    byAddressControl.BringToFront();
                    break;
                case "animals":
                    UserControls.References.ReferencesSearchByAnimals searchByAnimals = new UserControls.References.ReferencesSearchByAnimals();
                    AddControl(searchByAnimals);
                    searchByAnimals.SearchButtonClicked += MenuButtonClicked;
                    panelContents.Controls.Add(searchByAnimals);
                    searchByAnimals.BringToFront();
                    break;
                case "properties":
                    UserControls.References.Addresses.ReferencesSearchByHabitabillity referencesSearchByHabitabillity = new UserControls.References.Addresses.ReferencesSearchByHabitabillity();
                    AddControl(referencesSearchByHabitabillity);
                    referencesSearchByHabitabillity.ShowButtonClicked += MenuButtonClicked;
                    panelContents.Controls.Add(referencesSearchByHabitabillity);
                    referencesSearchByHabitabillity.BringToFront();
                    break;
                case "trees":
                    UserControls.References.Addresses.ReferencesSearchByTrees referencesSearchByTrees = new UserControls.References.Addresses.ReferencesSearchByTrees();
                    AddControl(referencesSearchByTrees);
                    referencesSearchByTrees.ShowButtonClicked += MenuButtonClicked;
                    panelContents.Controls.Add(referencesSearchByTrees);
                    referencesSearchByTrees.BringToFront();
                    break;
                case "quarantines":
                    UserControls.References.Addresses.ReferencesSearchByQuarantines referencesSearchByQuarantines = new UserControls.References.Addresses.ReferencesSearchByQuarantines();
                    AddControl(referencesSearchByQuarantines);
                    referencesSearchByQuarantines.ShowButtonClicked += MenuButtonClicked;
                    panelContents.Controls.Add(referencesSearchByQuarantines);
                    referencesSearchByQuarantines.BringToFront();
                    break;
                case "animalQuarantine":
                    UserControls.References.Addresses.ReferencesSearchByAnimalQuarantines referencesSearchByAnimalQuarantines = new UserControls.References.Addresses.ReferencesSearchByAnimalQuarantines();
                    AddControl(referencesSearchByAnimalQuarantines);
                    referencesSearchByAnimalQuarantines.ShowButtonClicked += MenuButtonClicked;
                    panelContents.Controls.Add(referencesSearchByAnimalQuarantines);
                    referencesSearchByAnimalQuarantines.BringToFront();
                    break;
                case "showAddress":
                    UserControls.References.ShowAddress showAddress = new UserControls.References.ShowAddress((Address)eventData.data);
                    panelContents.Controls.Add(showAddress);
                    AddControl(showAddress);
                    showAddress.InhabitantClicked += MenuButtonClicked;
                    showAddress.BringToFront();
                    break;
                case "showAddresses":
                    UserControls.References.ShowAddresses showAddresses = new UserControls.References.ShowAddresses((List<Address>)eventData.data);
                    AddControl(showAddresses);
                    showAddresses.AddressClicked += MenuButtonClicked;
                    panelContents.Controls.Add(showAddresses);
                    showAddresses.BringToFront();
                    break;
                case "inhabitants":
                    UserControls.References.ReferencesInhabitantsMenu referencesInhabitantsMenu = new UserControls.References.ReferencesInhabitantsMenu();
                    AddControl(referencesInhabitantsMenu);
                    referencesInhabitantsMenu.buttonClicked += MenuButtonClicked;
                    panelContents.Controls.Add(referencesInhabitantsMenu);
                    referencesInhabitantsMenu.BringToFront();
                    break;
                case "inhabitantsByName":
                    UserControls.References.Inhabitants.ReferencesInhabitantsSearchByName inhabitantsSearchByName = new UserControls.References.Inhabitants.ReferencesInhabitantsSearchByName();
                    AddControl(inhabitantsSearchByName);
                    inhabitantsSearchByName.ShowButtonClicked += MenuButtonClicked;
                    panelContents.Controls.Add(inhabitantsSearchByName);
                    inhabitantsSearchByName.BringToFront();
                    break;
                case "inhabitantsByReg":
                    UserControls.References.Inhabitants.ReferenceInhabitantsSearchByReg inhabitantsSearchByReg = new UserControls.References.Inhabitants.ReferenceInhabitantsSearchByReg();
                    AddControl(inhabitantsSearchByReg);
                    inhabitantsSearchByReg.ShowButtonClicked += MenuButtonClicked;
                    panelContents.Controls.Add(inhabitantsSearchByReg);
                    inhabitantsSearchByReg.BringToFront();
                    break;
                case "inhabitantsByProp":
                    UserControls.References.Inhabitants.ReferencesInhabitantsByProperty inhabitantsSearchByProp = new UserControls.References.Inhabitants.ReferencesInhabitantsByProperty();
                    AddControl(inhabitantsSearchByProp);
                    inhabitantsSearchByProp.ShowButtonClicked += MenuButtonClicked;
                    panelContents.Controls.Add(inhabitantsSearchByProp);
                    inhabitantsSearchByProp.BringToFront();
                    break;
                case "inhabitantsByResidence":
                    UserControls.References.Inhabitants.ReferencesInhabitantsByResidence inhabitantsSearchByResidence = new UserControls.References.Inhabitants.ReferencesInhabitantsByResidence();
                    AddControl(inhabitantsSearchByResidence);
                    inhabitantsSearchByResidence.ShowButtonClicked += MenuButtonClicked;
                    panelContents.Controls.Add(inhabitantsSearchByResidence);
                    inhabitantsSearchByResidence.BringToFront();
                    break;
                case "showInhabitants":
                    UserControls.References.ShowInhabitants showInhabitants = new UserControls.References.ShowInhabitants((List<Inhabitant>)eventData.data);
                    AddControl(showInhabitants);
                    showInhabitants.InhabitantClicked += MenuButtonClicked;
                    panelContents.Controls.Add(showInhabitants);
                    showInhabitants.BringToFront();
                    break;
                case "showInhabitant":
                    UserControls.References.Inhabitants.ShowInhabitant showResident = new UserControls.References.Inhabitants.ShowInhabitant((Inhabitant)eventData.data);
                    AddControl(showResident);
                    panelContents.Controls.Add(showResident);
                    showResident.BringToFront();
                    break;
                #endregion
                #region Въвеждане на данни
                case "insertData":
                    Hide();
                    //new InsertDataForm().ShowDialog();
                    Show();
                    break;
                #endregion
                default: break;
                    
            }

        }

        void AddControl(UserControl userControl)
        {
            userControls.Push(userControl);
            pictureBoxBack.Visible = true;

        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {
            if (userControls.Count != 0)
            {
                panelContents.Controls.Remove(userControls.Pop());
                if (userControls.Count == 0)
                    pictureBoxBack.Visible = false;
            }
        }

        private void pictureBoxBack_MouseEnter(object sender, EventArgs e)
        {
            pictureBoxBack.Size = new System.Drawing.Size(pictureBoxBack.Size.Width + 4, pictureBoxBack.Size.Height + 4);
            pictureBoxBack.Location = new System.Drawing.Point(pictureBoxBack.Location.X - 2, pictureBoxBack.Location.Y - 2);
        }

        private void pictureBoxBack_MouseLeave(object sender, EventArgs e)
        {
            pictureBoxBack.Size = new System.Drawing.Size(pictureBoxBack.Size.Width - 4, pictureBoxBack.Size.Height - 4);
            pictureBoxBack.Location = new System.Drawing.Point(pictureBoxBack.Location.X + 2, pictureBoxBack.Location.Y + 2);
        }
    }
}
