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
            public EventData(string name, object d) : this(name)
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
                    menuUserControl.Location = new System.Drawing.Point(0, 58);
                    break;
                #region Справки
                case "references":
                    ReferencesMenu referencesMenu = new ReferencesMenu();
                    AddControl(referencesMenu);
                    panelContents.Controls.Add(referencesMenu);
                    referencesMenu.BringToFront();
                    referencesMenu.ButtonClicked += MenuButtonClicked;
                    break;
                #region  Адреси
                case "addresses":
                    UserControls.References.ReferencesSearchByAddress byAddressControl = new UserControls.References.ReferencesSearchByAddress();
                    AddControl(byAddressControl);
                    byAddressControl.SearchButtonClicked += MenuButtonClicked;
                    panelContents.Controls.Add(byAddressControl);
                    byAddressControl.BringToFront();
                    break;
                case "showAddress":
                    UserControls.References.ShowAddress showAddress = new UserControls.References.ShowAddress((Address)eventData.data);
                    panelContents.Controls.Add(showAddress);
                    AddControl(showAddress);
                    showAddress.InhabitantClicked += MenuButtonClicked;
                    showAddress.BringToFront();
                    break;
                case "listAddresses":
                    UserControls.References.ListAddresses listAddresses = new UserControls.References.ListAddresses((List<Address>)eventData.data);
                    AddControl(listAddresses);
                    listAddresses.AddressClicked += MenuButtonClicked;
                    panelContents.Controls.Add(listAddresses);
                    listAddresses.BringToFront();
                    break;
                case "properties":
                    UserControls.References.Addresses.ReferencesSearchByHabitabillity referencesSearchByHabitabillity = new UserControls.References.Addresses.ReferencesSearchByHabitabillity();
                    AddControl(referencesSearchByHabitabillity);
                    referencesSearchByHabitabillity.ShowButtonClicked += MenuButtonClicked;
                    panelContents.Controls.Add(referencesSearchByHabitabillity);
                    referencesSearchByHabitabillity.BringToFront();
                    break;
                #endregion
                #region Селскостопански животни
                case "animals":
                    UserControls.References.ReferencesSearchByAnimals searchByAnimals = new UserControls.References.ReferencesSearchByAnimals();
                    AddControl(searchByAnimals);
                    searchByAnimals.SearchButtonClicked += MenuButtonClicked;
                    panelContents.Controls.Add(searchByAnimals);
                    searchByAnimals.BringToFront();
                    break;
                case "listAnimalsAddresses":
                    UserControls.References.ListAnimalAddresses listAnimalsAddresses = new UserControls.References.ListAnimalAddresses((UserControls.References.ListAnimalAddresses.AnimalsAddressesData)eventData.data);
                    AddControl(listAnimalsAddresses);
                    listAnimalsAddresses.AddressClicked += MenuButtonClicked;
                    panelContents.Controls.Add(listAnimalsAddresses);
                    listAnimalsAddresses.BringToFront();
                    break;
                case "showAnimals":
                    UserControls.References.ShowAddress showAddressAnimals = new UserControls.References.ShowAddress((UserControls.References.ShowAddress.AnimalAddressData)eventData.data);
                    panelContents.Controls.Add(showAddressAnimals);
                    AddControl(showAddressAnimals);
                    showAddressAnimals.InhabitantClicked += MenuButtonClicked;
                    showAddressAnimals.BringToFront();
                    break;
                #endregion
                #region Защитени дървесни видове
                case "trees":
                    UserControls.References.Addresses.ReferencesSearchByTrees referencesSearchByTrees = new UserControls.References.Addresses.ReferencesSearchByTrees();
                    AddControl(referencesSearchByTrees);
                    referencesSearchByTrees.ShowButtonClicked += MenuButtonClicked;
                    panelContents.Controls.Add(referencesSearchByTrees);
                    referencesSearchByTrees.BringToFront();
                    break;
                case "listTreesAddresses":
                    UserControls.References.ListTreesAddresses listTreesAddresses = new UserControls.References.ListTreesAddresses((UserControls.References.ListTreesAddresses.TreeAddressesData)eventData.data);
                    AddControl(listTreesAddresses);
                    listTreesAddresses.AddressClicked += MenuButtonClicked;
                    panelContents.Controls.Add(listTreesAddresses);
                    listTreesAddresses.BringToFront();
                    break;
                case "showTrees":
                    UserControls.References.ShowAddress showAddressTrees = new UserControls.References.ShowAddress((UserControls.References.ShowAddress.TreeAddressData)eventData.data);
                    panelContents.Controls.Add(showAddressTrees);
                    AddControl(showAddressTrees);
                    showAddressTrees.InhabitantClicked += MenuButtonClicked;
                    showAddressTrees.BringToFront();
                    break;
                #endregion
                #region Карантини
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
                case "listInhabitantsQuarantines":
                    UserControls.References.ListInhabitantQuarantines listInhabitantsQuarantines = new UserControls.References.ListInhabitantQuarantines((List<Address>)eventData.data);
                    AddControl(listInhabitantsQuarantines);
                    listInhabitantsQuarantines.AddressClicked += MenuButtonClicked;
                    panelContents.Controls.Add(listInhabitantsQuarantines);
                    listInhabitantsQuarantines.BringToFront();
                    break;
                case "listAnimalsQuarantines":
                    UserControls.References.ListAnimalsQuarantines listAnimalsQuarantines = new UserControls.References.ListAnimalsQuarantines((UserControls.References.ListAnimalsQuarantines.QuarantinesData)eventData.data);
                    AddControl(listAnimalsQuarantines);
                    listAnimalsQuarantines.AddressClicked += MenuButtonClicked;
                    panelContents.Controls.Add(listAnimalsQuarantines);
                    listAnimalsQuarantines.BringToFront();
                    break;
                case "showInhabitantsQuarantines":
                    UserControls.References.Quarantines.ShowInhabitantsQuarantines showInhabitantsQuarantines = new UserControls.References.Quarantines.ShowInhabitantsQuarantines((Address)eventData.data);
                    AddControl(showInhabitantsQuarantines);
                    panelContents.Controls.Add(showInhabitantsQuarantines);
                    showInhabitantsQuarantines.BringToFront();
                    break;
                case "showAnimalsQuarantines":
                    UserControls.References.Quarantines.ShowAnimalsQuarantines showAnimalsQuarantines = new UserControls.References.Quarantines.ShowAnimalsQuarantines((UserControls.References.Quarantines.ShowAnimalsQuarantines.QuarantineData)eventData.data);
                    AddControl(showAnimalsQuarantines);
                    panelContents.Controls.Add(showAnimalsQuarantines);
                    showAnimalsQuarantines.BringToFront();
                    break;

                #endregion
                #region Жители
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
                case "listInhabitants":
                    UserControls.References.ListInhabitants listInhabitants = new UserControls.References.ListInhabitants((List<Inhabitant>)eventData.data);
                    AddControl(listInhabitants);
                    listInhabitants.InhabitantClicked += MenuButtonClicked;
                    panelContents.Controls.Add(listInhabitants);
                    listInhabitants.BringToFront();
                    break;
                case "showInhabitant":
                    UserControls.References.Inhabitants.ShowInhabitant showResident = new UserControls.References.Inhabitants.ShowInhabitant((Inhabitant)eventData.data);
                    AddControl(showResident);
                    panelContents.Controls.Add(showResident);
                    showResident.BringToFront();
                    break;
                #endregion




                #endregion
                #region Въвеждане на данни
                case "insertData":
                    UserControls.InsertData.InsertDataMenu insertDataMenu = new UserControls.InsertData.InsertDataMenu();
                    AddControl(insertDataMenu);
                    panelContents.Controls.Add(insertDataMenu);
                    insertDataMenu.BringToFront();
                    insertDataMenu.ButtonClicked += MenuButtonClicked;
                    break;
                case "addressesMenu":
                    UserControls.InsertData.Addresses.AddressesMenu addressesMenu = new UserControls.InsertData.Addresses.AddressesMenu();
                    AddControl(addressesMenu);
                    panelContents.Controls.Add(addressesMenu);
                    addressesMenu.BringToFront();
                    addressesMenu.ButtonClicked += MenuButtonClicked;
                    break;
               
                case "createAddress":
                    UserControls.InsertData.Addresses.InsertDataAddress.AddressData addressData = new UserControls.InsertData.Addresses.InsertDataAddress.AddressData();
                    addressData.Intialize();
                    UserControls.InsertData.Addresses.InsertDataAddress createAddress = new UserControls.InsertData.Addresses.InsertDataAddress(addressData);
                    AddControl(createAddress);
                    panelContents.Controls.Add(createAddress);
                    createAddress.BringToFront();
                    createAddress.ButtonClicked += MenuButtonClicked;
                    break;
                case "editAddress":
                    UserControls.InsertData.Addresses.InsertDataAddress editAddress = new UserControls.InsertData.Addresses.InsertDataAddress();
                    AddControl(editAddress);
                    panelContents.Controls.Add(editAddress);
                    editAddress.BringToFront();
                    editAddress.ButtonClicked += MenuButtonClicked;
                    break;
                case "propertyData":
                    UserControls.InsertData.Addresses.InsertDataProperty insertDataProperty = new UserControls.InsertData.Addresses.InsertDataProperty((UserControls.InsertData.Addresses.InsertDataAddress.AddressData)eventData.data);
                    AddControl(insertDataProperty);
                    panelContents.Controls.Add(insertDataProperty);
                    insertDataProperty.BringToFront();
                    break;
                case "inhabitantsData":
                    UserControls.InsertData.Addresses.InsertDataInhabitant insertDataInhabitant = new UserControls.InsertData.Addresses.InsertDataInhabitant((UserControls.InsertData.Addresses.InsertDataAddress.AddressData)eventData.data);
                    AddControl(insertDataInhabitant);
                    panelContents.Controls.Add(insertDataInhabitant);
                    insertDataInhabitant.BringToFront();
                    break;
                case "streetsMenu":
                    UserControls.InsertData.Streets.InsertDataStreets insertDataStreets = new UserControls.InsertData.Streets.InsertDataStreets();
                    AddControl(insertDataStreets);
                    panelContents.Controls.Add(insertDataStreets);
                    insertDataStreets.BringToFront();
                    break;
                case "insertDataStreets":

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
                UserControl userControl = userControls.Pop();
                userControl.Visible = false;
                panelContents.Controls.Remove(userControl);
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
