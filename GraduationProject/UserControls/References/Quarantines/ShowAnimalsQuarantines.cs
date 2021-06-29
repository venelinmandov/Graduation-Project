using GraduationProject.Models;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using System.Linq;

namespace GraduationProject.UserControls.References.Quarantines
{
    public partial class ShowAnimalsQuarantines : UserControl
    {
        Address address;
        List<AnimalsQuarantine> animalsQuarantines;
        ConnectionHelper connectionHelper = new ConnectionHelper();
        List<Disease> diseases;

        public struct QuarantineData
        {
            public Address address;
            public AnimalsQuarantine.AnimalEnum animal;
        }

        Dictionary<AnimalsQuarantine.AnimalEnum, string> animalsDict = new Dictionary<AnimalsQuarantine.AnimalEnum, string>()
        {
            {AnimalsQuarantine.AnimalEnum.Cows, "крави" },
            {AnimalsQuarantine.AnimalEnum.Sheep, "овце" },
            {AnimalsQuarantine.AnimalEnum.Goats, "кози" },
            {AnimalsQuarantine.AnimalEnum.Horses, "коне" },
            {AnimalsQuarantine.AnimalEnum.Donkeys, "магарета" },
            {AnimalsQuarantine.AnimalEnum.Feathered, "пернати" },
            {AnimalsQuarantine.AnimalEnum.Pigs, "свине" },
            {AnimalsQuarantine.AnimalEnum.Dogs, "кучета" },
        };
        public ShowAnimalsQuarantines(QuarantineData quarantineData)
        {
            InitializeComponent();
            address = quarantineData.address;
            animalsQuarantines = new AnimalsQuarantine().Get(connectionHelper, address, quarantineData.animal);
            diseases = new Disease().Get(connectionHelper, Disease.DiseaseType.Animal);
            ShowQuarantines();
        }

        void ShowQuarantines()
        {
            labelAddress.Text = address.ToString();
            string dateformat = "d MMMM yyyy";
            foreach (AnimalsQuarantine animalsQuarantine in animalsQuarantines)
            {
                Label label = new Label();
                DateTime startDate, endDate;
                string diseaseName = diseases.Where(d => d.Id == animalsQuarantine.DiseaseId).First().Name;
                startDate = DateTime.Parse(animalsQuarantine.StartDate);
                endDate = DateTime.Parse(animalsQuarantine.EndDate);
                label.Font = new Font("Arial", 14.25F, FontStyle.Regular, GraphicsUnit.Point);
                label.Text = $"{animalsQuarantine.Number} {animalsDict[animalsQuarantine.Animal ]} с болест {diseaseName}, от {startDate.ToString(dateformat)} до {endDate.ToString(dateformat)}.";
                label.Size = new Size(panel.Width, label.Height);
                label.Dock = DockStyle.Top;
                panel.Controls.Add(label);
                label.BringToFront();

            }
        }

        private void labelQuarantinedNumber_Click(object sender, EventArgs e)
        {

        }
    }
}
