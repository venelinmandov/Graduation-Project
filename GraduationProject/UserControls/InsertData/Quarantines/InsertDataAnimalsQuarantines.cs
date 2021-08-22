using GraduationProject.Models;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using System.Linq;
using GraduationProject.Modules;

namespace GraduationProject.UserControls.InsertData.Quarantines
{
    public partial class InsertDataAnimalsQuarantines : UserControl
    {
        ErrorProvider errorProvider = new ErrorProvider();
        ConnectionHelper connectionHelper = new ConnectionHelper();
        Address address;
        List<AnimalsQuarantine> animalsQuarantines;
        AnimalsQuarantine quarantineToEdit;
        List<Disease> diseases;
        public enum AnimalEnum { Cows, Sheep, Goats, Horses, Donkeys, Feathered, Pigs, Dogs };

        Dictionary<string, int> animalNumbersDict = new Dictionary<string, int>();

        Dictionary<AnimalsQuarantine.AnimalEnum, string> animalsDict = new Dictionary<AnimalsQuarantine.AnimalEnum, string>()
        {
            { AnimalsQuarantine.AnimalEnum.Cows, "крави" },
            { AnimalsQuarantine.AnimalEnum.Sheep, "овце" },
            { AnimalsQuarantine.AnimalEnum.Goats, "кози" },
            { AnimalsQuarantine.AnimalEnum.Horses, "коне" },
            { AnimalsQuarantine.AnimalEnum.Donkeys, "магарета" },
            { AnimalsQuarantine.AnimalEnum.Feathered, "пернати" },
            { AnimalsQuarantine.AnimalEnum.Pigs, "свине" },
            { AnimalsQuarantine.AnimalEnum.Dogs, "кучета" }
        };

        //Конструктор
        public InsertDataAnimalsQuarantines(Address addr)
        {
            InitializeComponent();
            address = addr;
            labelAddress.Text = address.ToString();

            foreach (ComboBox comboBox in panelEditCreateQurantine.Controls.OfType<ComboBox>())
            {
                comboBox.DrawItem += comboBox_DrawItem;
            }

            panelShowQuarantines.BringToFront();
            diseases = new Disease().Get(connectionHelper, Disease.DiseaseType.Animal);

            comboBoxDisease.DataSource = diseases;
            comboBoxDisease.DisplayMember = "Name";

            PopulateAnimalsCombobox();
            ShowQuarantines();
        }

        /// <summary>
        /// Показване на всички карантини
        /// </summary>
        private void ShowQuarantines()
        {
            animalsQuarantines = new AnimalsQuarantine().Get(connectionHelper, address);
            List<string> quarantinesListItems = new List<string>();

            foreach (AnimalsQuarantine animalsQuarantine in animalsQuarantines)
            {
                string dateformat = "d MMMM yyyy";
                string quarantinesListItem;
                string diseaseName = (from Disease d in diseases where d.Id == animalsQuarantine.DiseaseId select d.Name).First();
                DateTime startDate = DateTime.Parse(animalsQuarantine.StartDate);
                DateTime endDate = DateTime.Parse(animalsQuarantine.EndDate);

                quarantinesListItem = $"{animalsQuarantine.Number} {animalsDict[animalsQuarantine.Animal]} с болест {diseaseName}, от {startDate.ToString(dateformat)} до {endDate.ToString(dateformat)}";
                quarantinesListItems.Add(quarantinesListItem);
            }
            listBoxQarantines.AddList(quarantinesListItems.ToList<object>());
        }

        /// <summary>
        /// Запъвване на комбобокса само със видовете секскостопански животни, които се отглеждат в имота
        /// </summary>
        void PopulateAnimalsCombobox()
        {
            List<Dog> dogs = new Dog().Get(connectionHelper,address);
            
            if (address.NumCows > 0)
            {
                comboBoxAnimal.Items.Add("крави");
                animalNumbersDict.Add("крави", address.NumCows);
            }
            if (address.NumSheep > 0)
            {
                comboBoxAnimal.Items.Add("овце");
                animalNumbersDict.Add("овце", address.NumSheep);
            }
            if (address.NumGoats > 0)
            {
                comboBoxAnimal.Items.Add("кози");
                animalNumbersDict.Add("кози", address.NumGoats);
            }
            if (address.NumHorses > 0)
            {
                comboBoxAnimal.Items.Add("коне");
                animalNumbersDict.Add("коне", address.NumHorses);
            }
            if (address.NumDonkeys > 0)
            {
                comboBoxAnimal.Items.Add("магарета");
                animalNumbersDict.Add("магарета", address.NumDonkeys);
            }
            if (address.NumFeathered > 0)
            {
                comboBoxAnimal.Items.Add("пернати");
                animalNumbersDict.Add("пернати", address.NumFeathered);
            }
            if (address.NumPigs > 0)
            {
                comboBoxAnimal.Items.Add("свине");
                animalNumbersDict.Add("свине", address.NumPigs);
            }
            if (dogs.Count > 0)
            {
                comboBoxAnimal.Items.Add("кучета");
                animalNumbersDict.Add("кучета", dogs.Count);
            }


        }

        /// <summary>
        /// Избор на вид селскостопански животни и показване на техния брой в имота
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void comboBoxAnimal_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (comboBoxAnimal.Text == "")
            {
                labelAnimalsInPropertyNumber.Text = "";
            }
            else
            {
                labelAnimalsInPropertyNumber.Text = "от " + animalNumbersDict[comboBoxAnimal.Text];
                numericUpDownNumber.Maximum = animalNumbersDict[comboBoxAnimal.Text];
            }
        }

        /// <summary>
        /// Показване на менюто за добавяне на карантина
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void buttonShowInsertQuarantine_Click(object sender, EventArgs e)
        {
            labelAddEditQuarantineTitleLabel.Text = "Добаване на карантина";
            quarantineToEdit = new AnimalsQuarantine();
            comboBoxAnimal.SelectedIndex = -1;
            comboBoxDisease.SelectedIndex = -1;
            numericUpDownNumber.Value = 0;
            dateTimePickerFrom.Value = DateTime.Now;
            dateTimePickerTo.Value = DateTime.Now;

            panelEditCreateQurantine.BringToFront();
        }

        
        /// <summary>
        /// Показване на менюто за редактиране на карантина
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void buttonShowEditQuarantine_Click(object sender, EventArgs e)
        {
            labelAddEditQuarantineTitleLabel.Text = "Редактиране на карантина";
            if (animalsQuarantines.Count == 0) return;
            quarantineToEdit = animalsQuarantines[listBoxQarantines.SelectedIndex];

            dateTimePickerFrom.Value = DateTime.Parse(quarantineToEdit.StartDate);
            dateTimePickerTo.Value = DateTime.Parse(quarantineToEdit.EndDate);

            string animal = animalsDict[quarantineToEdit.Animal];

            for (int i = 0; i < comboBoxAnimal.Items.Count; i++)
            {
                if (comboBoxAnimal.Items[i].ToString().Equals(animal))
                {
                    comboBoxAnimal.SelectedIndex = i;
                    break;
                }
            }

            if (quarantineToEdit.Number > animalNumbersDict[comboBoxAnimal.Text])
            {
                numericUpDownNumber.Maximum = quarantineToEdit.Number;
            }
            else
            {
                numericUpDownNumber.Maximum = animalNumbersDict[comboBoxAnimal.Text];
            }
            numericUpDownNumber.Value = quarantineToEdit.Number;




            for (int i = 0; i < diseases.Count; i++)
            {
                if (diseases[i].Id == quarantineToEdit.DiseaseId)
                {
                    comboBoxDisease.SelectedIndex = i;
                    break;
                }
            }

            panelEditCreateQurantine.BringToFront();
        }

        /// <summary>
        /// Връщане назад при списъка с карантини
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void buttonCancel_Click(object sender, EventArgs e)
        {
            panelShowQuarantines.BringToFront();
        }

        /// <summary>
        /// Запис на нововъведен или редактирана карантина
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void buttonSave_Click(object sender, EventArgs e)
        {
            bool error = false;
            errorProvider.Clear();
            if (comboBoxAnimal.Text == "")
            {
                errorProvider.SetError(comboBoxAnimal, "Моля изберете опция.");
                error = true;
            }
            if (comboBoxDisease.Text == "")
            {
                errorProvider.SetError(comboBoxDisease, "Моля изберете опция.");
                error = true;
            }
            if (error) return;

            quarantineToEdit.AddressId = address.Id;
            quarantineToEdit.Animal = animalsDict.FirstOrDefault(entry => EqualityComparer<string>.Default.Equals(entry.Value,comboBoxAnimal.Text)).Key;
            quarantineToEdit.Number = (int)numericUpDownNumber.Value;
            quarantineToEdit.DiseaseId = (from d in diseases where d.Name == comboBoxDisease.Text select d.Id).First();
            quarantineToEdit.StartDate = dateTimePickerFrom.Value.ToString("yyyy-MM-dd");
            quarantineToEdit.EndDate = dateTimePickerTo.Value.ToString("yyyy-MM-dd");

            if (quarantineToEdit.Id == 0)
            {
                quarantineToEdit.Insert(connectionHelper);
                CustomMessageBox.Show("Записът за карантината е създаден.", "Записът за карантината е създаден.", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            else
            {
                quarantineToEdit.Update(connectionHelper);
                CustomMessageBox.Show("Записът за карантината е редактиран.", "Записът за карантината е редактиран.", MessageBoxButtons.OK, MessageBoxIcon.Information);

            }
            ShowQuarantines();
            panelShowQuarantines.BringToFront();
        }

        /// <summary>
        /// Изтраване на избрана карантина
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void buttonDeleteQuarantine_Click(object sender, EventArgs e)
        {
            if (animalsQuarantines.Count == 0) return;
            DialogResult result = CustomMessageBox.Show("Сигурни ли сте, че искате да изтриете записа за карантината?", "Изтриване на карантина", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (result == DialogResult.Yes)
            {
                animalsQuarantines[listBoxQarantines.SelectedIndex].Delete(connectionHelper);
                CustomMessageBox.Show("Записът за карантината е изтрит.", "Записът за карантината е изтрит.", MessageBoxButtons.OK, MessageBoxIcon.Information);
                ShowQuarantines();
            }
        }

        /// <summary>
        /// Изчертаване на елемент от комбобокс
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void comboBox_DrawItem(object sender, DrawItemEventArgs e)
        {
            if (e.Index == -1) return;
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

            e.Graphics.DrawString(combo.Items[e.Index].ToString(),
                                          e.Font,
                                          solidBrush,
                                          new Point(e.Bounds.X, e.Bounds.Y));
        }
    }
}
