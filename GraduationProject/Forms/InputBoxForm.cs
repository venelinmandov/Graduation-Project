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
        ErrorProvider errorProvider = new ErrorProvider();
        public string text;
        public bool canceled = false;
        public InputBoxForm(string labelText)
        {
            InitializeComponent();
            label.Text = labelText;
        }

        void Save()
        {
            text = textBox.Text.Trim();
            if (text == "")
            {
                errorProvider.SetError(textBox, "Моля въведете текст.");
                return;
            }
            Hide();
        }

        void Cancel()
        {
            canceled = true;
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

        private void InputBoxForm_FormClosed(object sender, FormClosedEventArgs e)
        {
            Cancel();
        }
    }
}
