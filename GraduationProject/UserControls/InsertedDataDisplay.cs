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
        public bool WrapText 
        {
            get
            {
                return labelData.MaximumSize.Width != 0;
            }
            set
            {
                if (value == true)
                    labelData.MaximumSize =  new Size(Width - panelData.Location.X, Height);
                else
                    labelData.MaximumSize = new Size( 0, Height);

            }
        }
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
