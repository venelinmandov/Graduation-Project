
namespace GraduationProject.UserControls.References
{
    partial class ShowAddresses
    {
        /// <summary> 
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary> 
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Component Designer generated code

        /// <summary> 
        /// Required method for Designer support - do not modify 
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.labelTitle = new System.Windows.Forms.Label();
            this.listBoxAddresses = new GraduationProject.UserControls.ListBoxUserControl();
            this.SuspendLayout();
            // 
            // labelTitle
            // 
            this.labelTitle.AutoSize = true;
            this.labelTitle.BackColor = System.Drawing.Color.Transparent;
            this.labelTitle.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.labelTitle.Font = new System.Drawing.Font("Arial", 21.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.labelTitle.Location = new System.Drawing.Point(467, 60);
            this.labelTitle.Name = "labelTitle";
            this.labelTitle.Size = new System.Drawing.Size(114, 33);
            this.labelTitle.TabIndex = 1;
            this.labelTitle.Text = "Адреси";
            // 
            // listBoxAddresses
            // 
            this.listBoxAddresses.AutoScroll = true;
            this.listBoxAddresses.ItemTextAlignment = System.Drawing.ContentAlignment.MiddleLeft;
            this.listBoxAddresses.DesolateColor = System.Drawing.Color.Empty;
            this.listBoxAddresses.Font = new System.Drawing.Font("Arial", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.listBoxAddresses.InhabitedColor = System.Drawing.Color.Empty;
            this.listBoxAddresses.ItemBorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(170)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.listBoxAddresses.ItemsColor = System.Drawing.Color.FromArgb(((int)(((byte)(170)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.listBoxAddresses.Location = new System.Drawing.Point(264, 109);
            this.listBoxAddresses.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.listBoxAddresses.Name = "listBoxAddresses";
            this.listBoxAddresses.SelectedIndex = -1;
            this.listBoxAddresses.SelectedItemColor = System.Drawing.Color.Empty;
            this.listBoxAddresses.Size = new System.Drawing.Size(534, 196);
            this.listBoxAddresses.TabIndex = 3;
            this.listBoxAddresses.TemporarilyColor = System.Drawing.Color.Empty;
            this.listBoxAddresses.WithDifferentColors = false;
            // 
            // ShowAddresses
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(170)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.Controls.Add(this.listBoxAddresses);
            this.Controls.Add(this.labelTitle);
            this.Font = new System.Drawing.Font("Arial", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.Name = "ShowAddresses";
            this.Size = new System.Drawing.Size(1081, 329);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label labelTitle;
        private ListBoxUserControl listBoxAddresses;
    }
}
