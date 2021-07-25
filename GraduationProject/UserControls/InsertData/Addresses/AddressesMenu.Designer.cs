
namespace GraduationProject.UserControls.InsertData.Addresses
{
    partial class AddressesMenu
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
            this.buttonNewAddresse = new System.Windows.Forms.Button();
            this.buttonEditAddress = new System.Windows.Forms.Button();
            this.labelSearchBy = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // labelTitle
            // 
            this.labelTitle.AutoSize = true;
            this.labelTitle.BackColor = System.Drawing.Color.Transparent;
            this.labelTitle.Font = new System.Drawing.Font("Arial", 21.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.labelTitle.Location = new System.Drawing.Point(479, 37);
            this.labelTitle.Name = "labelTitle";
            this.labelTitle.Size = new System.Drawing.Size(114, 33);
            this.labelTitle.TabIndex = 14;
            this.labelTitle.Text = "Адреси";
            // 
            // buttonNewAddresse
            // 
            this.buttonNewAddresse.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(50)))), ((int)(((byte)(80)))), ((int)(((byte)(40)))));
            this.buttonNewAddresse.FlatAppearance.BorderSize = 0;
            this.buttonNewAddresse.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonNewAddresse.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.buttonNewAddresse.ForeColor = System.Drawing.SystemColors.Control;
            this.buttonNewAddresse.Location = new System.Drawing.Point(331, 139);
            this.buttonNewAddresse.Name = "buttonNewAddresse";
            this.buttonNewAddresse.Size = new System.Drawing.Size(179, 60);
            this.buttonNewAddresse.TabIndex = 15;
            this.buttonNewAddresse.Text = "Нов запис";
            this.buttonNewAddresse.UseVisualStyleBackColor = false;
            this.buttonNewAddresse.Click += new System.EventHandler(this.buttonNewAddresse_Click);
            // 
            // buttonEditAddress
            // 
            this.buttonEditAddress.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(50)))), ((int)(((byte)(80)))), ((int)(((byte)(40)))));
            this.buttonEditAddress.FlatAppearance.BorderSize = 0;
            this.buttonEditAddress.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonEditAddress.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.buttonEditAddress.ForeColor = System.Drawing.SystemColors.Control;
            this.buttonEditAddress.Location = new System.Drawing.Point(570, 139);
            this.buttonEditAddress.Name = "buttonEditAddress";
            this.buttonEditAddress.Size = new System.Drawing.Size(179, 60);
            this.buttonEditAddress.TabIndex = 16;
            this.buttonEditAddress.Text = "Редактиране на запис";
            this.buttonEditAddress.UseVisualStyleBackColor = false;
            this.buttonEditAddress.Click += new System.EventHandler(this.buttonEditAddress_Click);
            // 
            // labelSearchBy
            // 
            this.labelSearchBy.AutoSize = true;
            this.labelSearchBy.BackColor = System.Drawing.Color.Transparent;
            this.labelSearchBy.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.labelSearchBy.Location = new System.Drawing.Point(472, 78);
            this.labelSearchBy.Name = "labelSearchBy";
            this.labelSearchBy.Size = new System.Drawing.Size(129, 18);
            this.labelSearchBy.TabIndex = 17;
            this.labelSearchBy.Text = "Изберете опция:";
            // 
            // AddressesMenu
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(96F, 96F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Dpi;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(170)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.Controls.Add(this.labelSearchBy);
            this.Controls.Add(this.buttonEditAddress);
            this.Controls.Add(this.buttonNewAddresse);
            this.Controls.Add(this.labelTitle);
            this.Font = new System.Drawing.Font("Arial", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.Name = "AddressesMenu";
            this.Size = new System.Drawing.Size(1081, 329);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        protected System.Windows.Forms.Label labelTitle;
        protected System.Windows.Forms.Button buttonNewAddresse;
        protected System.Windows.Forms.Button buttonEditAddress;
        protected System.Windows.Forms.Label labelSearchBy;
    }
}
