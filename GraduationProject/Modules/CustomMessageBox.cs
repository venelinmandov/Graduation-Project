using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace GraduationProject.Modules
{
    public partial class CustomMessageBox : Form
    {
        static DialogResult result;

        public CustomMessageBox(MessageBoxButtons messageBoxButtons, MessageBoxIcon messageBoxIcon)
        {
            InitializeComponent();
            switch (messageBoxIcon)
            {
                case MessageBoxIcon.Information: pictureBoxIcon.Image = SystemIcons.Information.ToBitmap(); break;
                case MessageBoxIcon.Error: pictureBoxIcon.Image = SystemIcons.Error.ToBitmap(); break;
                case MessageBoxIcon.Warning: pictureBoxIcon.Image = SystemIcons.Warning.ToBitmap(); break;
                case MessageBoxIcon.Question: pictureBoxIcon.Image = SystemIcons.Question.ToBitmap(); break;
            }
            if (messageBoxButtons == MessageBoxButtons.OK)
            {
                buttonNo.Visible = false;
                buttonYes.Visible = false;
                buttonOK.Visible = true;
            }
            else if (messageBoxButtons == MessageBoxButtons.YesNo)
            {
                buttonNo.Visible = true;
                buttonYes.Visible = true;
                buttonOK.Visible = false;
            }

        }

        public static DialogResult Show(string text, string caption, MessageBoxButtons messageBoxButtons, MessageBoxIcon messageBoxIcon)
        {
            CustomMessageBox customMessageBox = new CustomMessageBox(messageBoxButtons, messageBoxIcon);
            customMessageBox.labelText.Text = text;
            customMessageBox.Text = caption;
            customMessageBox.ShowDialog();
            return result;
        }

        private void buttonYes_Click(object sender, EventArgs e)
        {
            result = DialogResult.Yes;
            Hide();
        }

        private void buttonNo_Click(object sender, EventArgs e)
        {
             result = DialogResult.No;
             Hide();

        }

        private void buttonOK_Click(object sender, EventArgs e)
        {
            result = DialogResult.OK;
            Hide();
        }

    }
}
