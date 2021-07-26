using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Windows.Forms;

namespace GraduationProject.UserControls
{
    public partial class ListBoxUserControl : UserControl
    {
        List<Button> buttons;
        public Color SelectedItemColor { get; set; }
        public Color SelectedItemForeColor { get; set; }
        public Color ItemsColor { get; set; }
        public Color ItemBorderColor { get; set; }
        public ContentAlignment ItemTextAlignment { get; set; }

        public int SelectedIndex { get; set; }


        [Browsable(true)]
        [Category("Action")]
        [Description("Invoked when index is changed")]
        public event EventHandler SelectedIndexChanged;

        [Browsable(true)]
        [Category("Action")]
        [Description("Item clicked")]
        public event EventHandler ItemClicked;
        public ListBoxUserControl()
        {
            InitializeComponent();
            SelectedIndex = -1;
        }

        //Добаване на списък с елементи
        public void AddList(List<object> items)
        {
            Controls.Clear();
            buttons = new List<Button>();
            foreach (object item in items)
            {
                Button button = new Button();
                button.Text = item.ToString();
                button.FlatAppearance.BorderSize = 0;
                button.FlatStyle = FlatStyle.Flat;
                button.BackColor = ItemsColor;
                button.Dock = DockStyle.Top;
                button.TextAlign = ItemTextAlignment;
                button.Click += ButtonClick;
                Controls.Add(button);
                button.BringToFront();
                button.Paint += ButtonOnPaint;


                buttons.Add(button);
            }
            ChangeIndex(0);

        }

        //Промяна на индекса на избрания елемент
        public void ChangeIndex(int index)
        {
            if (buttons.Count <= index) return;
            if (SelectedIndex != -1)
            {
                buttons[SelectedIndex].BackColor = buttons[index].BackColor;
                buttons[SelectedIndex].ForeColor = buttons[index].ForeColor;
            }
            SelectedIndex = index;

            buttons[SelectedIndex].BackColor = SelectedItemColor;
            buttons[SelectedIndex].ForeColor = SelectedItemForeColor;


            if (SelectedIndexChanged != null)
                SelectedIndexChanged(this, new EventArgs());
        }


        //Обработчик на събитие натискане на ляв бутон на мишката върху елемент 
        private void ButtonClick(object buttonClicked, EventArgs eventArgs)
        {
            for (int i = 0; i < buttons.Count; i++)
            {
                if (buttonClicked == buttons[i])
                {
                    ChangeIndex(i);
                    break;
                }
            }
            if (ItemClicked != null)
                ItemClicked(SelectedIndex, new EventArgs());
        }

        //Изчертаване на рамка на елемент
        private void ButtonOnPaint(object sender, PaintEventArgs e)
        {
            Button button = (Button)sender;
            Pen pen = new Pen(ItemBorderColor);
            Rectangle rectangle = new Rectangle(0, 0, button.Width - 1, button.Height - 1);
            e.Graphics.DrawRectangle(pen, rectangle);
        }


    }
}
