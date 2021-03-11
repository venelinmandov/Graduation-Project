using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace GraduationProject.Controls
{
    public partial class ListBoxUserControl : UserControl
    {
        List<Button> buttons;
        public Color SelectedItemColor { get; set; }
        public Color ItemsColor { get; set; }
        public int SelectedIndex { get; set; }

        [Browsable(true)][Category("Action")]
        [Description("Invoked when index is changed")]
        public event EventHandler SelectedIndexChanged;
        public ListBoxUserControl()
        {
            InitializeComponent();
            SelectedIndex = -1;
        }

        public void AddList(List<object> items)
        {
            this.Controls.Clear();
            buttons = new List<Button>();
            foreach (object item in items)
            {
                Button button = new Button();
                button.Text = item.ToString();
                button.FlatAppearance.BorderSize = 0;
                button.FlatStyle = FlatStyle.Flat;
                button.BackColor = ItemsColor;
                button.Dock = DockStyle.Top;
                Controls.Add(button);
                button.BringToFront();
                button.Click += buttonClick;
                button.Paint += buttonOnPaint;



                buttons.Add(button);
            }
            ChangeIndex(0);

        }

        private void ChangeIndex(int index)
        {
            if (SelectedIndex != -1)
            {
                buttons[SelectedIndex].BackColor = ItemsColor;
            }
            SelectedIndex = index;
            buttons[SelectedIndex].BackColor = SelectedItemColor;
            if(SelectedIndexChanged != null)
                SelectedIndexChanged(buttons[SelectedIndex],new EventArgs());
        }

        private void buttonClick(object buttonClicked, EventArgs eventArgs)
        {
            for (int i = 0; i < buttons.Count; i++)
            {
                if (buttonClicked == buttons[i])
                {
                    ChangeIndex(i);
                    break;
                }
            }
        }


        private  void buttonOnPaint(object sender, PaintEventArgs e)
        {
            Button button = (Button)sender;
            Pen pen = new Pen(Color.Black, 1);
            Rectangle rectangle = new Rectangle(0, 0, button.Width - 1, button.Height-1);
            e.Graphics.DrawRectangle(pen, rectangle);
        }

        private void ListBoxUserControl_Load(object sender, EventArgs e)
        {

        }
    }
}
