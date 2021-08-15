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
                    ShowUserControl(referencesMenu);
                    referencesMenu.ButtonClicked += MenuButtonClicked;
                    break;
                #region  Адреси
                case "addresses":
                    UserControls.References.ReferencesSearchByAddress byAddressControl = new UserControls.References.ReferencesSearchByAddress();
                    ShowUserControl(byAddressControl);
                    byAddressControl.SearchButtonClicked += MenuButtonClicked;
                    break;
                case "showAddress":
                    UserControls.References.ShowAddress showAddress = new UserControls.References.ShowAddress((Address)eventData.data);
                    ShowUserControl(showAddress);
                    showAddress.InhabitantClicked += MenuButtonClicked;
                    break;
                case "listAddresses":
                    UserControls.References.ListAddresses listAddresses = new UserControls.References.ListAddresses((List<Address>)eventData.data);
                    ShowUserControl(listAddresses);
                    listAddresses.AddressClicked += MenuButtonClicked;

                    break;
                case "properties":
                    UserControls.References.Addresses.ReferencesSearchByHabitabillity referencesSearchByHabitabillity = new UserControls.References.Addresses.ReferencesSearchByHabitabillity();
                    ShowUserControl(referencesSearchByHabitabillity);
                    referencesSearchByHabitabillity.ShowButtonClicked += MenuButtonClicked;
                    break;
                #endregion
                #region Селскостопански животни
                case "animals":
                    UserControls.References.ReferencesSearchByAnimals searchByAnimals = new UserControls.References.ReferencesSearchByAnimals();
                    ShowUserControl(searchByAnimals);
                    searchByAnimals.SearchButtonClicked += MenuButtonClicked;
                    break;
                case "listAnimalsAddresses":
                    UserControls.References.ListAnimalAddresses listAnimalsAddresses = new UserControls.References.ListAnimalAddresses((UserControls.References.ListAnimalAddresses.AnimalsAddressesData)eventData.data);
                    ShowUserControl(listAnimalsAddresses);
                    listAnimalsAddresses.AddressClicked += MenuButtonClicked;
                    break;
                case "showAnimals":
                    UserControls.References.ShowAddress showAddressAnimals = new UserControls.References.ShowAddress((UserControls.References.ShowAddress.AnimalAddressData)eventData.data);
                    ShowUserControl(showAddressAnimals);
                    showAddressAnimals.InhabitantClicked += MenuButtonClicked;
                    break;
                #endregion
                #region Защитени дървесни видове
                case "trees":
                    UserControls.References.Addresses.ReferencesSearchByTrees referencesSearchByTrees = new UserControls.References.Addresses.ReferencesSearchByTrees();
                    ShowUserControl(referencesSearchByTrees);
                    referencesSearchByTrees.ShowButtonClicked += MenuButtonClicked;
                    break;
                case "listTreesAddresses":
                    UserControls.References.ListTreesAddresses listTreesAddresses = new UserControls.References.ListTreesAddresses((UserControls.References.ListTreesAddresses.TreeAddressesData)eventData.data);
                    ShowUserControl(listTreesAddresses);
                    listTreesAddresses.AddressClicked += MenuButtonClicked;
                    break;
                case "showTrees":
                    UserControls.References.ShowAddress showAddressTrees = new UserControls.References.ShowAddress((UserControls.References.ShowAddress.TreeAddressData)eventData.data);
                    ShowUserControl(showAddressTrees);
                    showAddressTrees.InhabitantClicked += MenuButtonClicked;
                    break;
                #endregion
                #region Карантини
                case "quarantines":
                    UserControls.References.Addresses.ReferencesSearchByQuarantines referencesSearchByQuarantines = new UserControls.References.Addresses.ReferencesSearchByQuarantines();
                    ShowUserControl(referencesSearchByQuarantines);
                    referencesSearchByQuarantines.ShowButtonClicked += MenuButtonClicked;
                    break;
                case "animalQuarantine":
                    UserControls.References.Addresses.ReferencesSearchByAnimalQuarantines referencesSearchByAnimalQuarantines = new UserControls.References.Addresses.ReferencesSearchByAnimalQuarantines();
                    ShowUserControl(referencesSearchByAnimalQuarantines);
                    referencesSearchByAnimalQuarantines.ShowButtonClicked += MenuButtonClicked;
                    break;
                case "listInhabitantsQuarantines":
                    UserControls.References.ListInhabitantQuarantines listInhabitantsQuarantines = new UserControls.References.ListInhabitantQuarantines((List<Address>)eventData.data);
                    ShowUserControl(listInhabitantsQuarantines);
                    listInhabitantsQuarantines.AddressClicked += MenuButtonClicked;
                    break;
                case "listAnimalsQuarantines":
                    UserControls.References.ListAnimalsQuarantines listAnimalsQuarantines = new UserControls.References.ListAnimalsQuarantines((UserControls.References.ListAnimalsQuarantines.QuarantinesData)eventData.data);
                    ShowUserControl(listAnimalsQuarantines);
                    listAnimalsQuarantines.AddressClicked += MenuButtonClicked;
                    break;
                case "showInhabitantsQuarantines":
                    UserControls.References.Quarantines.ShowInhabitantsQuarantines showInhabitantsQuarantines = new UserControls.References.Quarantines.ShowInhabitantsQuarantines((Address)eventData.data);
                    ShowUserControl(showInhabitantsQuarantines);
                    break;
                case "showAnimalsQuarantines":
                    UserControls.References.Quarantines.ShowAnimalsQuarantines showAnimalsQuarantines = new UserControls.References.Quarantines.ShowAnimalsQuarantines((UserControls.References.Quarantines.ShowAnimalsQuarantines.QuarantineData)eventData.data);
                    ShowUserControl(showAnimalsQuarantines);
                    break;

                #endregion
                #region Жители
                case "inhabitants":
                    UserControls.References.ReferencesInhabitantsMenu referencesInhabitantsMenu = new UserControls.References.ReferencesInhabitantsMenu();
                    ShowUserControl(referencesInhabitantsMenu);
                    referencesInhabitantsMenu.buttonClicked += MenuButtonClicked;
                    break;
                case "inhabitantsByName":
                    UserControls.References.Inhabitants.ReferencesInhabitantsSearchByName inhabitantsSearchByName = new UserControls.References.Inhabitants.ReferencesInhabitantsSearchByName();
                    ShowUserControl(inhabitantsSearchByName);
                    inhabitantsSearchByName.ShowButtonClicked += MenuButtonClicked;
                    break;
                case "inhabitantsByReg":
                    UserControls.References.Inhabitants.ReferenceInhabitantsSearchByReg inhabitantsSearchByReg = new UserControls.References.Inhabitants.ReferenceInhabitantsSearchByReg();
                    ShowUserControl(inhabitantsSearchByReg);
                    inhabitantsSearchByReg.ShowButtonClicked += MenuButtonClicked;

                    break;
                case "inhabitantsByProp":
                    UserControls.References.Inhabitants.ReferencesInhabitantsByProperty inhabitantsSearchByProp = new UserControls.References.Inhabitants.ReferencesInhabitantsByProperty();
                    ShowUserControl(inhabitantsSearchByProp);
                    inhabitantsSearchByProp.ShowButtonClicked += MenuButtonClicked;
                    break;
                case "inhabitantsByResidence":
                    UserControls.References.Inhabitants.ReferencesInhabitantsByResidence inhabitantsSearchByResidence = new UserControls.References.Inhabitants.ReferencesInhabitantsByResidence();
                    ShowUserControl(inhabitantsSearchByResidence);
                    inhabitantsSearchByResidence.ShowButtonClicked += MenuButtonClicked;

                    break;
                case "listInhabitants":
                    UserControls.References.ListInhabitants listInhabitants = new UserControls.References.ListInhabitants((List<Inhabitant>)eventData.data);
                    ShowUserControl(listInhabitants);
                    listInhabitants.InhabitantClicked += MenuButtonClicked;
                    break;
                case "showInhabitant":
                    UserControls.References.Inhabitants.ShowInhabitant showResident = new UserControls.References.Inhabitants.ShowInhabitant((Inhabitant)eventData.data);
                    ShowUserControl(showResident);
                    break;
                #endregion
                #endregion
                #region Въвеждане на данни
                case "insertData":
                    UserControls.InsertData.InsertDataMenu insertDataMenu = new UserControls.InsertData.InsertDataMenu();
                    ShowUserControl(insertDataMenu);
                    insertDataMenu.ButtonClicked += MenuButtonClicked;
                    break;
                case "insertdataAddress":
                    UserControls.InsertData.Addresses.AddressesMenu addressesMenu = new UserControls.InsertData.Addresses.AddressesMenu();
                    ShowUserControl(addressesMenu);
                    addressesMenu.ButtonClicked += MenuButtonClicked;
                    break;

                case "createAddress":
                    UserControls.InsertData.Addresses.InsertDataAddress.AddressData addressData = new UserControls.InsertData.Addresses.InsertDataAddress.AddressData();
                    addressData.Intialize();
                    UserControls.InsertData.Addresses.InsertDataAddress createAddress = new UserControls.InsertData.Addresses.InsertDataAddress(addressData);
                    ShowUserControl(createAddress);
                    createAddress.ButtonClicked += MenuButtonClicked;
                    break;
                case "editAddress":
                    UserControls.InsertData.Addresses.InsertDataAddress editAddress = new UserControls.InsertData.Addresses.InsertDataAddress();
                    ShowUserControl(editAddress);
                    editAddress.ButtonClicked += MenuButtonClicked;
                    break;
                case "propertyData":
                    UserControls.InsertData.Addresses.InsertDataProperty insertDataProperty = new UserControls.InsertData.Addresses.InsertDataProperty((UserControls.InsertData.Addresses.InsertDataAddress.AddressData)eventData.data);
                    ShowUserControl(insertDataProperty);
                    break;
                case "inhabitantsData":
                    UserControls.InsertData.Addresses.InsertDataInhabitant insertDataInhabitant = new UserControls.InsertData.Addresses.InsertDataInhabitant((UserControls.InsertData.Addresses.InsertDataAddress.AddressData)eventData.data);
                    ShowUserControl(insertDataInhabitant);
                    insertDataInhabitant.ButtonClicked += MenuButtonClicked;

                    break;
                case "inhabitantEditCreate":
                    UserControls.InsertData.Addresses.InsertDataInhabitantEditCreate insertDataInhabitantEditCreate = new UserControls.InsertData.Addresses.InsertDataInhabitantEditCreate((UserControls.InsertData.Addresses.InsertDataInhabitantEditCreate.InhabitantData)eventData.data);
                    ShowUserControl(insertDataInhabitantEditCreate);
                    break;
                case "insertDataStreets":
                    UserControls.InsertData.Streets.InsertDataStreets insertDataStreets = new UserControls.InsertData.Streets.InsertDataStreets();
                    ShowUserControl(insertDataStreets);
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

        void ShowUserControl(UserControl userControl)
        {
            AddControl(userControl);
            panelContents.Controls.Add(userControl);
            userControl.BringToFront();
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {
            if (userControls.Count != 0)
            {
                UserControl userControl = userControls.Peek();
                userControl.Visible = false;
                if (!userControl.Visible)
                {
                    userControls.Pop();
                    panelContents.Controls.Remove(userControl);
                    if (userControls.Count == 0)
                        pictureBoxBack.Visible = false;
                }
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
