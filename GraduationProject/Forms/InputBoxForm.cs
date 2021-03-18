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

        //Запазване на въведения текст
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

        //Изход от формата без запазване на текста
        void Cancel()
        {
            canceled = true;
            Hide();
        }

        //Избор на бутона "Запис"
        private void buttonSave_Click(object sender, EventArgs e)
        {
            Save();
        }

        //Избор на бутона "Отказ"
        private void buttonCancel_Click(object sender, EventArgs e)
        {
            Cancel();
        }

        private void textBox_KeyUp(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
                Save();
            if (e.KeyCode == Keys.Escape)
                Cancel();
        }

        //Избор на бутона за затваряне на формата
        private void InputBoxForm_FormClosed(object sender, FormClosedEventArgs e)
        {
            Cancel();
        }
    }
}
