
namespace GraduationProject.UserControls.InsertData.Quarantines
{
    partial class InsertDataQuarantinesChooseAddress
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
            this.labelSearchBy = new System.Windows.Forms.Label();
            this.comboBoxStreet = new System.Windows.Forms.ComboBox();
            this.comboBoxNumber = new System.Windows.Forms.ComboBox();
            this.labelNumber = new System.Windows.Forms.Label();
            this.labelStreet = new System.Windows.Forms.Label();
            this.buttonShow = new System.Windows.Forms.Button();
            this.labelNoAddresses = new System.Windows.Forms.Label();
            this.labelNoAnimalsInhabitants = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // labelTitle
            // 
            this.labelTitle.BackColor = System.Drawing.Color.Transparent;
            this.labelTitle.Font = new System.Drawing.Font("Arial", 21.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.labelTitle.Location = new System.Drawing.Point(186, 37);
            this.labelTitle.Name = "labelTitle";
            this.labelTitle.Size = new System.Drawing.Size(709, 33);
            this.labelTitle.TabIndex = 16;
            this.labelTitle.Text = "Карантини на ...";
            this.labelTitle.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // labelSearchBy
            // 
            this.labelSearchBy.AutoSize = true;
            this.labelSearchBy.BackColor = System.Drawing.Color.Transparent;
            this.labelSearchBy.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.labelSearchBy.Location = new System.Drawing.Point(475, 78);
            this.labelSearchBy.Name = "labelSearchBy";
            this.labelSearchBy.Size = new System.Drawing.Size(130, 18);
            this.labelSearchBy.TabIndex = 19;
            this.labelSearchBy.Text = "Изберете адрес:";
            // 
            // comboBoxStreet
            // 
            this.comboBoxStreet.DrawMode = System.Windows.Forms.DrawMode.OwnerDrawFixed;
            this.comboBoxStreet.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboBoxStreet.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.comboBoxStreet.FormattingEnabled = true;
            this.comboBoxStreet.Location = new System.Drawing.Point(393, 153);
            this.comboBoxStreet.Name = "comboBoxStreet";
            this.comboBoxStreet.Size = new System.Drawing.Size(213, 27);
            this.comboBoxStreet.TabIndex = 26;
            this.comboBoxStreet.SelectedIndexChanged += new System.EventHandler(this.comboBoxStreet_SelectedIndexChanged);
            // 
            // comboBoxNumber
            // 
            this.comboBoxNumber.DrawMode = System.Windows.Forms.DrawMode.OwnerDrawFixed;
            this.comboBoxNumber.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboBoxNumber.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.comboBoxNumber.FormattingEnabled = true;
            this.comboBoxNumber.Location = new System.Drawing.Point(633, 153);
            this.comboBoxNumber.Name = "comboBoxNumber";
            this.comboBoxNumber.Size = new System.Drawing.Size(56, 27);
            this.comboBoxNumber.TabIndex = 29;
            this.comboBoxNumber.SelectedIndexChanged += new System.EventHandler(this.comboBoxNumber_SelectedIndexChanged);
            // 
            // labelNumber
            // 
            this.labelNumber.AutoSize = true;
            this.labelNumber.BackColor = System.Drawing.Color.Transparent;
            this.labelNumber.Location = new System.Drawing.Point(633, 135);
            this.labelNumber.Name = "labelNumber";
            this.labelNumber.Size = new System.Drawing.Size(49, 15);
            this.labelNumber.TabIndex = 28;
            this.labelNumber.Text = "Номер:";
            // 
            // labelStreet
            // 
            this.labelStreet.AutoSize = true;
            this.labelStreet.BackColor = System.Drawing.Color.Transparent;
            this.labelStreet.Location = new System.Drawing.Point(393, 135);
            this.labelStreet.Name = "labelStreet";
            this.labelStreet.Size = new System.Drawing.Size(45, 15);
            this.labelStreet.TabIndex = 27;
            this.labelStreet.Text = "Улица:";
            // 
            // buttonShow
            // 
            this.buttonShow.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(50)))), ((int)(((byte)(70)))), ((int)(((byte)(90)))), ((int)(((byte)(30)))));
            this.buttonShow.FlatAppearance.BorderSize = 0;
            this.buttonShow.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonShow.ForeColor = System.Drawing.SystemColors.Control;
            this.buttonShow.Location = new System.Drawing.Point(393, 235);
            this.buttonShow.Name = "buttonShow";
            this.buttonShow.Size = new System.Drawing.Size(87, 29);
            this.buttonShow.TabIndex = 30;
            this.buttonShow.Text = "Покажи";
            this.buttonShow.UseVisualStyleBackColor = false;
            // 
            // labelNoAddresses
            // 
            this.labelNoAddresses.BackColor = System.Drawing.Color.Transparent;
            this.labelNoAddresses.Font = new System.Drawing.Font("Arial", 21.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.labelNoAddresses.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(150)))), ((int)(((byte)(40)))), ((int)(((byte)(10)))));
            this.labelNoAddresses.Location = new System.Drawing.Point(208, 37);
            this.labelNoAddresses.Name = "labelNoAddresses";
            this.labelNoAddresses.Size = new System.Drawing.Size(663, 33);
            this.labelNoAddresses.TabIndex = 31;
            this.labelNoAddresses.Tag = "errorLabel";
            this.labelNoAddresses.Text = "На тази улица няма записи за адреси";
            this.labelNoAddresses.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.labelNoAddresses.Visible = false;
            // 
            // labelNoAnimalsInhabitants
            // 
            this.labelNoAnimalsInhabitants.BackColor = System.Drawing.Color.Transparent;
            this.labelNoAnimalsInhabitants.Font = new System.Drawing.Font("Arial", 21.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.labelNoAnimalsInhabitants.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(150)))), ((int)(((byte)(40)))), ((int)(((byte)(10)))));
            this.labelNoAnimalsInhabitants.Location = new System.Drawing.Point(30, 37);
            this.labelNoAnimalsInhabitants.Name = "labelNoAnimalsInhabitants";
            this.labelNoAnimalsInhabitants.Size = new System.Drawing.Size(1024, 40);
            this.labelNoAnimalsInhabitants.TabIndex = 32;
            this.labelNoAnimalsInhabitants.Tag = "errorLabel";
            this.labelNoAnimalsInhabitants.Text = "За имота на този адрес няма въведени ...";
            this.labelNoAnimalsInhabitants.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.labelNoAnimalsInhabitants.Visible = false;
            // 
            // InsertDataQuarantinesChooseAddress
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(96F, 96F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Dpi;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(170)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.Controls.Add(this.labelNoAnimalsInhabitants);
            this.Controls.Add(this.buttonShow);
            this.Controls.Add(this.comboBoxStreet);
            this.Controls.Add(this.comboBoxNumber);
            this.Controls.Add(this.labelNumber);
            this.Controls.Add(this.labelStreet);
            this.Controls.Add(this.labelSearchBy);
            this.Controls.Add(this.labelTitle);
            this.Controls.Add(this.labelNoAddresses);
            this.Font = new System.Drawing.Font("Arial", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.Name = "InsertDataQuarantinesChooseAddress";
            this.Size = new System.Drawing.Size(1081, 329);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        protected System.Windows.Forms.Label labelTitle;
        protected System.Windows.Forms.Label labelSearchBy;
        private System.Windows.Forms.ComboBox comboBoxStreet;
        private System.Windows.Forms.ComboBox comboBoxNumber;
        private System.Windows.Forms.Label labelNumber;
        private System.Windows.Forms.Label labelStreet;
        private System.Windows.Forms.Button buttonShow;
        protected System.Windows.Forms.Label labelNoAddresses;
        protected System.Windows.Forms.Label labelNoAnimalsInhabitants;
    }
}
