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
    public partial class ShowInhabitantsQuarantines : UserControl
    {
        Address address;
        List<InhabitantsQuarantine> inhabitantsQuarantines;
        ConnectionHelper connectionHelper = new ConnectionHelper();
        List<Disease> diseases;
        public ShowInhabitantsQuarantines(Address addr)
        {
            InitializeComponent();
            address = addr;
            inhabitantsQuarantines = new InhabitantsQuarantine().Get(connectionHelper, address);
            diseases = new Disease().Get(connectionHelper, Disease.DiseaseType.Inhabitant);
            ShowQuarantines();
        }

        void ShowQuarantines()
        {
            labelAddress.Text = address.ToString();
            string dateformat = "d MMMM yyyy";
            if (inhabitantsQuarantines.Count == 1)
            {
                labelQuarantinedNumber.Text += "1 карантиниран:";
            }
            else
            {
                labelQuarantinedNumber.Text += inhabitantsQuarantines.Count + " карантинирани:"; 
            }
            foreach (InhabitantsQuarantine inhabitantsQuarantine in inhabitantsQuarantines)
            {
                Label label = new Label();
                DateTime startDate, endDate;
                string diseaseName = diseases.Where(d => d.Id == inhabitantsQuarantine.DiseaseId).First().Name;
                startDate = DateTime.Parse(inhabitantsQuarantine.StartDate);
                endDate = DateTime.Parse(inhabitantsQuarantine.EndDate);
                Inhabitant inhabitant = new Inhabitant().Get(connectionHelper, inhabitantsQuarantine.InhabitantId);
                string quarantineType = inhabitantsQuarantine.QuarantineType == InhabitantsQuarantine.QuarantineEnum.Contact ? "контактен" : "боледува";
                label.Font = new System.Drawing.Font("Arial", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
                label.Text = $"{inhabitant.ToString()}: {quarantineType}, {diseaseName}, от {startDate.ToString(dateformat)} до {endDate.ToString(dateformat)}.";
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
