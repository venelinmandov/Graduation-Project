
namespace GraduationProject.UserControls.References
{
    partial class ShowInhabitants
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
            this.listBoxInhabitants = new GraduationProject.UserControls.ListBoxUserControl();
            this.labelNoInhabitants = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // labelTitle
            // 
            this.labelTitle.AutoSize = true;
            this.labelTitle.BackColor = System.Drawing.Color.Transparent;
            this.labelTitle.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.labelTitle.Font = new System.Drawing.Font("Arial", 21.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.labelTitle.Location = new System.Drawing.Point(476, 37);
            this.labelTitle.Name = "labelTitle";
            this.labelTitle.Size = new System.Drawing.Size(119, 33);
            this.labelTitle.TabIndex = 1;
            this.labelTitle.Text = "Жители";
            // 
            // listBoxInhabitants
            // 
            this.listBoxInhabitants.AutoScroll = true;
            this.listBoxInhabitants.DesolateColor = System.Drawing.Color.Empty;
            this.listBoxInhabitants.Font = new System.Drawing.Font("Arial", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.listBoxInhabitants.InhabitedColor = System.Drawing.Color.Empty;
            this.listBoxInhabitants.ItemBorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(170)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.listBoxInhabitants.ItemsColor = System.Drawing.Color.FromArgb(((int)(((byte)(170)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.listBoxInhabitants.ItemTextAlignment = System.Drawing.ContentAlignment.MiddleLeft;
            this.listBoxInhabitants.Location = new System.Drawing.Point(273, 109);
            this.listBoxInhabitants.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.listBoxInhabitants.Name = "listBoxInhabitants";
            this.listBoxInhabitants.SelectedIndex = -1;
            this.listBoxInhabitants.SelectedItemColor = System.Drawing.Color.Empty;
            this.listBoxInhabitants.Size = new System.Drawing.Size(534, 196);
            this.listBoxInhabitants.TabIndex = 3;
            this.listBoxInhabitants.TemporarilyColor = System.Drawing.Color.Empty;
            // 
            // labelNoInhabitants
            // 
            this.labelNoInhabitants.AutoSize = true;
            this.labelNoInhabitants.BackColor = System.Drawing.Color.Transparent;
            this.labelNoInhabitants.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.labelNoInhabitants.Font = new System.Drawing.Font("Arial", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.labelNoInhabitants.Location = new System.Drawing.Point(272, 155);
            this.labelNoInhabitants.Name = "labelNoInhabitants";
            this.labelNoInhabitants.Size = new System.Drawing.Size(538, 27);
            this.labelNoInhabitants.TabIndex = 4;
            this.labelNoInhabitants.Text = "Няма намерени жители по посочения критерий";
            this.labelNoInhabitants.Visible = false;
            // 
            // ShowInhabitants
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(96F, 96F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Dpi;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(170)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.Controls.Add(this.labelNoInhabitants);
            this.Controls.Add(this.listBoxInhabitants);
            this.Controls.Add(this.labelTitle);
            this.Font = new System.Drawing.Font("Arial", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.Name = "ShowInhabitants";
            this.Size = new System.Drawing.Size(1081, 329);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label labelTitle;
        private ListBoxUserControl listBoxInhabitants;
        private System.Windows.Forms.Label labelNoInhabitants;
    }
}
