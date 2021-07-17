using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace GraduationProject.UserControls
{
    public partial class InsertedDataDisplay : UserControl
    {
        public InsertedDataDisplay()
        {
            InitializeComponent();
        }

        public string DataText
        {
            set 
            {
                labelData.Text = value;
            }
        }
    }
}
