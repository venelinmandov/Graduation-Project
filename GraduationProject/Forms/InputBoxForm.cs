using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;


namespace GraduationProject.Forms
{
    public partial class InputBoxForm : Form
    {
        public string text;
        public InputBoxForm(string labelText)
        {
            InitializeComponent();
            label.Text = labelText;
        }

        void Save()
        {
            text = textBox.Text;
            Hide();
        }

        void Cancel()
        {
            text = "";
            Hide();
        }

        private void buttonSave_Click(object sender, EventArgs e)
        {
            Save();
        }
        

        private void buttonCancel_Click(object sender, EventArgs e)
        {
            Cancel();
        }

        private void InputBoxForm_Load(object sender, EventArgs e)
        {

        }

        private void InputBoxForm_KeyUp(object sender, KeyEventArgs e)
        {

            

        }

        private void textBox_KeyUp(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
                Save();
            if (e.KeyCode == Keys.Escape)
                Cancel();
        }

        private void InputBoxForm_FormClosing(object sender, FormClosingEventArgs e)
        {
            
        }
    }
}
