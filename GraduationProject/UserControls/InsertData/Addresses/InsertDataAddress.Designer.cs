
namespace GraduationProject.UserControls.InsertData.Addresses
{
    partial class InsertDataAddress
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
            this.comboBoxStreet = new System.Windows.Forms.ComboBox();
            this.numericUpDownNumber = new System.Windows.Forms.NumericUpDown();
            this.labelStreet = new System.Windows.Forms.Label();
            this.labelNumber = new System.Windows.Forms.Label();
            this.buttonInhabitants = new System.Windows.Forms.Button();
            this.buttonProperty = new System.Windows.Forms.Button();
            this.buttonSave = new System.Windows.Forms.Button();
            this.labelAddressExists = new System.Windows.Forms.Label();
            this.comboBoxNumber = new System.Windows.Forms.ComboBox();
            this.buttonDelete = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDownNumber)).BeginInit();
            this.SuspendLayout();
            // 
            // labelTitle
            // 
            this.labelTitle.BackColor = System.Drawing.Color.Transparent;
            this.labelTitle.Font = new System.Drawing.Font("Arial", 21.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.labelTitle.Location = new System.Drawing.Point(209, 37);
            this.labelTitle.Name = "labelTitle";
            this.labelTitle.Size = new System.Drawing.Size(663, 33);
            this.labelTitle.TabIndex = 15;
            this.labelTitle.Text = "Нов адрес";
            this.labelTitle.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // comboBoxStreet
            // 
            this.comboBoxStreet.DrawMode = System.Windows.Forms.DrawMode.OwnerDrawFixed;
            this.comboBoxStreet.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboBoxStreet.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.comboBoxStreet.FormattingEnabled = true;
            this.comboBoxStreet.Location = new System.Drawing.Point(392, 119);
            this.comboBoxStreet.Name = "comboBoxStreet";
            this.comboBoxStreet.Size = new System.Drawing.Size(213, 27);
            this.comboBoxStreet.TabIndex = 16;
            this.comboBoxStreet.DrawItem += new System.Windows.Forms.DrawItemEventHandler(this.comboBoxStreet_DrawItem);
            this.comboBoxStreet.SelectedIndexChanged += new System.EventHandler(this.comboBoxStreet_SelectedIndexChanged);
            // 
            // numericUpDownNumber
            // 
            this.numericUpDownNumber.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.numericUpDownNumber.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.numericUpDownNumber.Location = new System.Drawing.Point(632, 119);
            this.numericUpDownNumber.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.numericUpDownNumber.Name = "numericUpDownNumber";
            this.numericUpDownNumber.Size = new System.Drawing.Size(56, 26);
            this.numericUpDownNumber.TabIndex = 17;
            this.numericUpDownNumber.Value = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.numericUpDownNumber.ValueChanged += new System.EventHandler(this.numericUpDownNumber_ValueChanged);
            // 
            // labelStreet
            // 
            this.labelStreet.AutoSize = true;
            this.labelStreet.BackColor = System.Drawing.Color.Transparent;
            this.labelStreet.Location = new System.Drawing.Point(392, 98);
            this.labelStreet.Name = "labelStreet";
            this.labelStreet.Size = new System.Drawing.Size(45, 15);
            this.labelStreet.TabIndex = 18;
            this.labelStreet.Text = "Улица:";
            // 
            // labelNumber
            // 
            this.labelNumber.AutoSize = true;
            this.labelNumber.BackColor = System.Drawing.Color.Transparent;
            this.labelNumber.Location = new System.Drawing.Point(632, 98);
            this.labelNumber.Name = "labelNumber";
            this.labelNumber.Size = new System.Drawing.Size(49, 15);
            this.labelNumber.TabIndex = 19;
            this.labelNumber.Text = "Номер:";
            // 
            // buttonInhabitants
            // 
            this.buttonInhabitants.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(50)))), ((int)(((byte)(80)))), ((int)(((byte)(40)))));
            this.buttonInhabitants.FlatAppearance.BorderSize = 0;
            this.buttonInhabitants.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonInhabitants.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.buttonInhabitants.ForeColor = System.Drawing.SystemColors.Control;
            this.buttonInhabitants.Location = new System.Drawing.Point(331, 176);
            this.buttonInhabitants.Name = "buttonInhabitants";
            this.buttonInhabitants.Size = new System.Drawing.Size(179, 60);
            this.buttonInhabitants.TabIndex = 21;
            this.buttonInhabitants.Text = "Обитатели";
            this.buttonInhabitants.UseVisualStyleBackColor = false;
            // 
            // buttonProperty
            // 
            this.buttonProperty.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(50)))), ((int)(((byte)(80)))), ((int)(((byte)(40)))));
            this.buttonProperty.FlatAppearance.BorderSize = 0;
            this.buttonProperty.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonProperty.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.buttonProperty.ForeColor = System.Drawing.SystemColors.Control;
            this.buttonProperty.Location = new System.Drawing.Point(570, 176);
            this.buttonProperty.Name = "buttonProperty";
            this.buttonProperty.Size = new System.Drawing.Size(179, 60);
            this.buttonProperty.TabIndex = 22;
            this.buttonProperty.Text = "Данни за имота";
            this.buttonProperty.UseVisualStyleBackColor = false;
            this.buttonProperty.Click += new System.EventHandler(this.buttonProperty_Click);
            // 
            // buttonSave
            // 
            this.buttonSave.FlatAppearance.BorderSize = 0;
            this.buttonSave.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonSave.Image = global::GraduationProject.Properties.Resources.saveIcon;
            this.buttonSave.Location = new System.Drawing.Point(331, 267);
            this.buttonSave.Name = "buttonSave";
            this.buttonSave.Size = new System.Drawing.Size(87, 29);
            this.buttonSave.TabIndex = 23;
            this.buttonSave.Text = "Запис";
            this.buttonSave.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.buttonSave.UseVisualStyleBackColor = true;
            this.buttonSave.Click += new System.EventHandler(this.buttonSave_Click);
            // 
            // labelAddressExists
            // 
            this.labelAddressExists.AutoSize = true;
            this.labelAddressExists.BackColor = System.Drawing.Color.Transparent;
            this.labelAddressExists.Location = new System.Drawing.Point(392, 152);
            this.labelAddressExists.Name = "labelAddressExists";
            this.labelAddressExists.Size = new System.Drawing.Size(125, 15);
            this.labelAddressExists.TabIndex = 24;
            this.labelAddressExists.Text = "Адресът съществува!";
            this.labelAddressExists.Visible = false;
            // 
            // comboBoxNumber
            // 
            this.comboBoxNumber.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.comboBoxNumber.FormattingEnabled = true;
            this.comboBoxNumber.Location = new System.Drawing.Point(632, 119);
            this.comboBoxNumber.Name = "comboBoxNumber";
            this.comboBoxNumber.Size = new System.Drawing.Size(56, 26);
            this.comboBoxNumber.TabIndex = 25;
            this.comboBoxNumber.SelectedIndexChanged += new System.EventHandler(this.comboBoxNumber_SelectedIndexChanged);
            // 
            // buttonDelete
            // 
            this.buttonDelete.FlatAppearance.BorderSize = 0;
            this.buttonDelete.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonDelete.Image = global::GraduationProject.Properties.Resources.deleteIcon;
            this.buttonDelete.Location = new System.Drawing.Point(331, 267);
            this.buttonDelete.Name = "buttonDelete";
            this.buttonDelete.Size = new System.Drawing.Size(108, 29);
            this.buttonDelete.TabIndex = 26;
            this.buttonDelete.Text = "Изтриване";
            this.buttonDelete.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.buttonDelete.UseVisualStyleBackColor = true;
            this.buttonDelete.Click += new System.EventHandler(this.buttonDelete_Click);
            // 
            // InsertDataAddress
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(96F, 96F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Dpi;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(170)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.Controls.Add(this.buttonDelete);
            this.Controls.Add(this.labelAddressExists);
            this.Controls.Add(this.buttonSave);
            this.Controls.Add(this.buttonProperty);
            this.Controls.Add(this.buttonInhabitants);
            this.Controls.Add(this.labelNumber);
            this.Controls.Add(this.labelStreet);
            this.Controls.Add(this.numericUpDownNumber);
            this.Controls.Add(this.comboBoxStreet);
            this.Controls.Add(this.labelTitle);
            this.Controls.Add(this.comboBoxNumber);
            this.Font = new System.Drawing.Font("Arial", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.Name = "InsertDataAddress";
            this.Size = new System.Drawing.Size(1081, 329);
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDownNumber)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        protected System.Windows.Forms.Label labelTitle;
        private System.Windows.Forms.ComboBox comboBoxStreet;
        private System.Windows.Forms.NumericUpDown numericUpDownNumber;
        private System.Windows.Forms.Label labelStreet;
        private System.Windows.Forms.Label labelNumber;
        protected System.Windows.Forms.Button buttonInhabitants;
        protected System.Windows.Forms.Button buttonProperty;
        private System.Windows.Forms.Button buttonSave;
        private System.Windows.Forms.Label labelAddressExists;
        private System.Windows.Forms.ComboBox comboBoxNumber;
        private System.Windows.Forms.Button buttonDelete;
    }
}
