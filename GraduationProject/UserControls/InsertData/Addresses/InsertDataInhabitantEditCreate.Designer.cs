
namespace GraduationProject.UserControls.InsertData.Addresses
{
    partial class InsertDataInhabitantEditCreate
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
            this.panelBuildings = new System.Windows.Forms.Panel();
            this.buttonSaveBuildings = new System.Windows.Forms.Button();
            this.labelFirstname = new System.Windows.Forms.Label();
            this.labelTitlePersonsData = new System.Windows.Forms.Label();
            this.insertedDataDisplayPersonsData = new GraduationProject.UserControls.InsertedDataDisplay();
            this.panelNotes = new System.Windows.Forms.Panel();
            this.buttonSaveNotes = new System.Windows.Forms.Button();
            this.buttonEditNote = new System.Windows.Forms.Button();
            this.insertedDataDisplayNotes = new GraduationProject.UserControls.InsertedDataDisplay();
            this.buttonInsertNote = new System.Windows.Forms.Button();
            this.richTextBoxNotes = new System.Windows.Forms.RichTextBox();
            this.labelTitleNotes = new System.Windows.Forms.Label();
            this.buttonPersonsData = new System.Windows.Forms.Button();
            this.buttonNotes = new System.Windows.Forms.Button();
            this.buttonHabitabilityData = new System.Windows.Forms.Button();
            this.buttonOwnershipData = new System.Windows.Forms.Button();
            this.labelAddress = new System.Windows.Forms.Label();
            this.textBoxFirstname = new System.Windows.Forms.TextBox();
            this.textBoxMiddlename = new System.Windows.Forms.TextBox();
            this.labelMiddlename = new System.Windows.Forms.Label();
            this.textBoxLastname = new System.Windows.Forms.TextBox();
            this.labelLastname = new System.Windows.Forms.Label();
            this.textBoxPhone = new System.Windows.Forms.TextBox();
            this.labelPhone = new System.Windows.Forms.Label();
            this.buttonInsertPersonsData = new System.Windows.Forms.Button();
            this.labelGender = new System.Windows.Forms.Label();
            this.radioButtonMale = new System.Windows.Forms.RadioButton();
            this.radioButtonFemale = new System.Windows.Forms.RadioButton();
            this.panelBuildings.SuspendLayout();
            this.panelNotes.SuspendLayout();
            this.SuspendLayout();
            // 
            // panelBuildings
            // 
            this.panelBuildings.Controls.Add(this.radioButtonFemale);
            this.panelBuildings.Controls.Add(this.radioButtonMale);
            this.panelBuildings.Controls.Add(this.labelGender);
            this.panelBuildings.Controls.Add(this.textBoxPhone);
            this.panelBuildings.Controls.Add(this.labelPhone);
            this.panelBuildings.Controls.Add(this.buttonInsertPersonsData);
            this.panelBuildings.Controls.Add(this.textBoxLastname);
            this.panelBuildings.Controls.Add(this.labelLastname);
            this.panelBuildings.Controls.Add(this.textBoxMiddlename);
            this.panelBuildings.Controls.Add(this.labelMiddlename);
            this.panelBuildings.Controls.Add(this.textBoxFirstname);
            this.panelBuildings.Controls.Add(this.buttonSaveBuildings);
            this.panelBuildings.Controls.Add(this.labelFirstname);
            this.panelBuildings.Controls.Add(this.labelTitlePersonsData);
            this.panelBuildings.Controls.Add(this.insertedDataDisplayPersonsData);
            this.panelBuildings.Location = new System.Drawing.Point(336, 14);
            this.panelBuildings.Name = "panelBuildings";
            this.panelBuildings.Size = new System.Drawing.Size(712, 300);
            this.panelBuildings.TabIndex = 66;
            // 
            // buttonSaveBuildings
            // 
            this.buttonSaveBuildings.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(130)))), ((int)(((byte)(80)))), ((int)(((byte)(10)))));
            this.buttonSaveBuildings.FlatAppearance.BorderSize = 0;
            this.buttonSaveBuildings.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonSaveBuildings.ForeColor = System.Drawing.SystemColors.Control;
            this.buttonSaveBuildings.Image = global::GraduationProject.Properties.Resources.saveIcon_white;
            this.buttonSaveBuildings.Location = new System.Drawing.Point(607, 249);
            this.buttonSaveBuildings.Name = "buttonSaveBuildings";
            this.buttonSaveBuildings.Size = new System.Drawing.Size(87, 29);
            this.buttonSaveBuildings.TabIndex = 65;
            this.buttonSaveBuildings.Tag = "saveAddress";
            this.buttonSaveBuildings.Text = "Запис";
            this.buttonSaveBuildings.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.buttonSaveBuildings.UseVisualStyleBackColor = false;
            // 
            // labelFirstname
            // 
            this.labelFirstname.AutoSize = true;
            this.labelFirstname.BackColor = System.Drawing.Color.Transparent;
            this.labelFirstname.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.labelFirstname.Location = new System.Drawing.Point(431, 94);
            this.labelFirstname.Name = "labelFirstname";
            this.labelFirstname.Size = new System.Drawing.Size(47, 19);
            this.labelFirstname.TabIndex = 18;
            this.labelFirstname.Text = "Име:";
            // 
            // labelTitlePersonsData
            // 
            this.labelTitlePersonsData.AutoSize = true;
            this.labelTitlePersonsData.BackColor = System.Drawing.Color.Transparent;
            this.labelTitlePersonsData.Font = new System.Drawing.Font("Arial", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.labelTitlePersonsData.Location = new System.Drawing.Point(33, 25);
            this.labelTitlePersonsData.Name = "labelTitlePersonsData";
            this.labelTitlePersonsData.Size = new System.Drawing.Size(211, 29);
            this.labelTitlePersonsData.TabIndex = 13;
            this.labelTitlePersonsData.Text = "Данни за лицето";
            // 
            // insertedDataDisplayPersonsData
            // 
            this.insertedDataDisplayPersonsData.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(170)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.insertedDataDisplayPersonsData.Font = new System.Drawing.Font("Arial Narrow", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.insertedDataDisplayPersonsData.Location = new System.Drawing.Point(25, 76);
            this.insertedDataDisplayPersonsData.Name = "insertedDataDisplayPersonsData";
            this.insertedDataDisplayPersonsData.Size = new System.Drawing.Size(307, 203);
            this.insertedDataDisplayPersonsData.TabIndex = 17;
            // 
            // panelNotes
            // 
            this.panelNotes.Controls.Add(this.buttonSaveNotes);
            this.panelNotes.Controls.Add(this.buttonEditNote);
            this.panelNotes.Controls.Add(this.insertedDataDisplayNotes);
            this.panelNotes.Controls.Add(this.buttonInsertNote);
            this.panelNotes.Controls.Add(this.richTextBoxNotes);
            this.panelNotes.Controls.Add(this.labelTitleNotes);
            this.panelNotes.Location = new System.Drawing.Point(336, 14);
            this.panelNotes.Name = "panelNotes";
            this.panelNotes.Size = new System.Drawing.Size(712, 300);
            this.panelNotes.TabIndex = 72;
            // 
            // buttonSaveNotes
            // 
            this.buttonSaveNotes.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(130)))), ((int)(((byte)(80)))), ((int)(((byte)(10)))));
            this.buttonSaveNotes.FlatAppearance.BorderSize = 0;
            this.buttonSaveNotes.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonSaveNotes.ForeColor = System.Drawing.SystemColors.Control;
            this.buttonSaveNotes.Image = global::GraduationProject.Properties.Resources.saveIcon_white;
            this.buttonSaveNotes.Location = new System.Drawing.Point(601, 25);
            this.buttonSaveNotes.Name = "buttonSaveNotes";
            this.buttonSaveNotes.Size = new System.Drawing.Size(87, 29);
            this.buttonSaveNotes.TabIndex = 72;
            this.buttonSaveNotes.Tag = "saveAddress";
            this.buttonSaveNotes.Text = "Запис";
            this.buttonSaveNotes.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.buttonSaveNotes.UseVisualStyleBackColor = false;
            // 
            // buttonEditNote
            // 
            this.buttonEditNote.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(130)))), ((int)(((byte)(80)))), ((int)(((byte)(10)))));
            this.buttonEditNote.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonEditNote.ForeColor = System.Drawing.SystemColors.Control;
            this.buttonEditNote.Location = new System.Drawing.Point(525, 255);
            this.buttonEditNote.Name = "buttonEditNote";
            this.buttonEditNote.Size = new System.Drawing.Size(121, 23);
            this.buttonEditNote.TabIndex = 23;
            this.buttonEditNote.Text = "Редактиране";
            this.buttonEditNote.UseVisualStyleBackColor = false;
            // 
            // insertedDataDisplayNotes
            // 
            this.insertedDataDisplayNotes.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(170)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.insertedDataDisplayNotes.Font = new System.Drawing.Font("Arial Narrow", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.insertedDataDisplayNotes.Location = new System.Drawing.Point(25, 76);
            this.insertedDataDisplayNotes.Name = "insertedDataDisplayNotes";
            this.insertedDataDisplayNotes.Size = new System.Drawing.Size(307, 203);
            this.insertedDataDisplayNotes.TabIndex = 22;
            // 
            // buttonInsertNote
            // 
            this.buttonInsertNote.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(130)))), ((int)(((byte)(80)))), ((int)(((byte)(10)))));
            this.buttonInsertNote.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonInsertNote.ForeColor = System.Drawing.SystemColors.Control;
            this.buttonInsertNote.Location = new System.Drawing.Point(398, 255);
            this.buttonInsertNote.Name = "buttonInsertNote";
            this.buttonInsertNote.Size = new System.Drawing.Size(121, 23);
            this.buttonInsertNote.TabIndex = 21;
            this.buttonInsertNote.Text = "Въведи";
            this.buttonInsertNote.UseVisualStyleBackColor = false;
            // 
            // richTextBoxNotes
            // 
            this.richTextBoxNotes.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.richTextBoxNotes.Cursor = System.Windows.Forms.Cursors.Arrow;
            this.richTextBoxNotes.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.richTextBoxNotes.Location = new System.Drawing.Point(355, 75);
            this.richTextBoxNotes.Name = "richTextBoxNotes";
            this.richTextBoxNotes.Size = new System.Drawing.Size(334, 175);
            this.richTextBoxNotes.TabIndex = 14;
            this.richTextBoxNotes.Text = "";
            // 
            // labelTitleNotes
            // 
            this.labelTitleNotes.AutoSize = true;
            this.labelTitleNotes.BackColor = System.Drawing.Color.Transparent;
            this.labelTitleNotes.Font = new System.Drawing.Font("Arial", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.labelTitleNotes.Location = new System.Drawing.Point(33, 25);
            this.labelTitleNotes.Name = "labelTitleNotes";
            this.labelTitleNotes.Size = new System.Drawing.Size(141, 29);
            this.labelTitleNotes.TabIndex = 13;
            this.labelTitleNotes.Text = "Забележки";
            // 
            // buttonPersonsData
            // 
            this.buttonPersonsData.FlatAppearance.BorderSize = 0;
            this.buttonPersonsData.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonPersonsData.Location = new System.Drawing.Point(32, 205);
            this.buttonPersonsData.Name = "buttonPersonsData";
            this.buttonPersonsData.Size = new System.Drawing.Size(271, 23);
            this.buttonPersonsData.TabIndex = 73;
            this.buttonPersonsData.Text = "Данни за лицето";
            this.buttonPersonsData.UseVisualStyleBackColor = true;
            // 
            // buttonNotes
            // 
            this.buttonNotes.FlatAppearance.BorderSize = 0;
            this.buttonNotes.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonNotes.Location = new System.Drawing.Point(32, 291);
            this.buttonNotes.Name = "buttonNotes";
            this.buttonNotes.Size = new System.Drawing.Size(271, 23);
            this.buttonNotes.TabIndex = 65;
            this.buttonNotes.Text = "Забележки";
            this.buttonNotes.UseVisualStyleBackColor = true;
            // 
            // buttonHabitabilityData
            // 
            this.buttonHabitabilityData.FlatAppearance.BorderSize = 0;
            this.buttonHabitabilityData.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonHabitabilityData.Location = new System.Drawing.Point(32, 262);
            this.buttonHabitabilityData.Name = "buttonHabitabilityData";
            this.buttonHabitabilityData.Size = new System.Drawing.Size(271, 23);
            this.buttonHabitabilityData.TabIndex = 64;
            this.buttonHabitabilityData.Text = "Статус на пребиваване";
            this.buttonHabitabilityData.UseVisualStyleBackColor = true;
            // 
            // buttonOwnershipData
            // 
            this.buttonOwnershipData.FlatAppearance.BorderSize = 0;
            this.buttonOwnershipData.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonOwnershipData.Location = new System.Drawing.Point(32, 233);
            this.buttonOwnershipData.Name = "buttonOwnershipData";
            this.buttonOwnershipData.Size = new System.Drawing.Size(271, 23);
            this.buttonOwnershipData.TabIndex = 63;
            this.buttonOwnershipData.Text = "Статус на собственост";
            this.buttonOwnershipData.UseVisualStyleBackColor = true;
            // 
            // labelAddress
            // 
            this.labelAddress.AutoSize = true;
            this.labelAddress.BackColor = System.Drawing.Color.Transparent;
            this.labelAddress.Font = new System.Drawing.Font("Arial", 21.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.labelAddress.Location = new System.Drawing.Point(32, 23);
            this.labelAddress.Name = "labelAddress";
            this.labelAddress.Size = new System.Drawing.Size(197, 34);
            this.labelAddress.TabIndex = 62;
            this.labelAddress.Text = "Адрес Адрес";
            // 
            // textBoxFirstname
            // 
            this.textBoxFirstname.Location = new System.Drawing.Point(483, 96);
            this.textBoxFirstname.Name = "textBoxFirstname";
            this.textBoxFirstname.Size = new System.Drawing.Size(168, 21);
            this.textBoxFirstname.TabIndex = 66;
            // 
            // textBoxMiddlename
            // 
            this.textBoxMiddlename.Location = new System.Drawing.Point(483, 123);
            this.textBoxMiddlename.Name = "textBoxMiddlename";
            this.textBoxMiddlename.Size = new System.Drawing.Size(168, 21);
            this.textBoxMiddlename.TabIndex = 69;
            // 
            // labelMiddlename
            // 
            this.labelMiddlename.AutoSize = true;
            this.labelMiddlename.BackColor = System.Drawing.Color.Transparent;
            this.labelMiddlename.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.labelMiddlename.Location = new System.Drawing.Point(394, 121);
            this.labelMiddlename.Name = "labelMiddlename";
            this.labelMiddlename.Size = new System.Drawing.Size(84, 19);
            this.labelMiddlename.TabIndex = 67;
            this.labelMiddlename.Text = "Презиме:";
            // 
            // textBoxLastname
            // 
            this.textBoxLastname.Location = new System.Drawing.Point(483, 150);
            this.textBoxLastname.Name = "textBoxLastname";
            this.textBoxLastname.Size = new System.Drawing.Size(168, 21);
            this.textBoxLastname.TabIndex = 72;
            // 
            // labelLastname
            // 
            this.labelLastname.AutoSize = true;
            this.labelLastname.BackColor = System.Drawing.Color.Transparent;
            this.labelLastname.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.labelLastname.Location = new System.Drawing.Point(390, 148);
            this.labelLastname.Name = "labelLastname";
            this.labelLastname.Size = new System.Drawing.Size(88, 19);
            this.labelLastname.TabIndex = 70;
            this.labelLastname.Text = "Фамилия:";
            // 
            // textBoxPhone
            // 
            this.textBoxPhone.Location = new System.Drawing.Point(484, 201);
            this.textBoxPhone.Name = "textBoxPhone";
            this.textBoxPhone.Size = new System.Drawing.Size(168, 21);
            this.textBoxPhone.TabIndex = 75;
            // 
            // labelPhone
            // 
            this.labelPhone.AutoSize = true;
            this.labelPhone.BackColor = System.Drawing.Color.Transparent;
            this.labelPhone.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.labelPhone.Location = new System.Drawing.Point(392, 200);
            this.labelPhone.Name = "labelPhone";
            this.labelPhone.Size = new System.Drawing.Size(86, 19);
            this.labelPhone.TabIndex = 73;
            this.labelPhone.Text = "Телефон:";
            this.labelPhone.Click += new System.EventHandler(this.labelPhone_Click);
            // 
            // buttonInsertPersonsData
            // 
            this.buttonInsertPersonsData.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(130)))), ((int)(((byte)(80)))), ((int)(((byte)(10)))));
            this.buttonInsertPersonsData.FlatAppearance.BorderSize = 0;
            this.buttonInsertPersonsData.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonInsertPersonsData.ForeColor = System.Drawing.SystemColors.Control;
            this.buttonInsertPersonsData.Location = new System.Drawing.Point(394, 249);
            this.buttonInsertPersonsData.Name = "buttonInsertPersonsData";
            this.buttonInsertPersonsData.Size = new System.Drawing.Size(117, 29);
            this.buttonInsertPersonsData.TabIndex = 74;
            this.buttonInsertPersonsData.Tag = "editAddress";
            this.buttonInsertPersonsData.Text = "Въведи";
            this.buttonInsertPersonsData.UseVisualStyleBackColor = false;
            // 
            // labelGender
            // 
            this.labelGender.AutoSize = true;
            this.labelGender.BackColor = System.Drawing.Color.Transparent;
            this.labelGender.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.labelGender.Location = new System.Drawing.Point(431, 175);
            this.labelGender.Name = "labelGender";
            this.labelGender.Size = new System.Drawing.Size(47, 19);
            this.labelGender.TabIndex = 76;
            this.labelGender.Text = "Пол:";
            // 
            // radioButtonMale
            // 
            this.radioButtonMale.AutoSize = true;
            this.radioButtonMale.Location = new System.Drawing.Point(483, 175);
            this.radioButtonMale.Name = "radioButtonMale";
            this.radioButtonMale.Size = new System.Drawing.Size(51, 19);
            this.radioButtonMale.TabIndex = 77;
            this.radioButtonMale.TabStop = true;
            this.radioButtonMale.Text = "мъж";
            this.radioButtonMale.UseVisualStyleBackColor = true;
            // 
            // radioButtonFemale
            // 
            this.radioButtonFemale.AutoSize = true;
            this.radioButtonFemale.Location = new System.Drawing.Point(540, 175);
            this.radioButtonFemale.Name = "radioButtonFemale";
            this.radioButtonFemale.Size = new System.Drawing.Size(55, 19);
            this.radioButtonFemale.TabIndex = 78;
            this.radioButtonFemale.TabStop = true;
            this.radioButtonFemale.Text = "жена";
            this.radioButtonFemale.UseVisualStyleBackColor = true;
            // 
            // InsertDataInhabitantEditCreate
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(96F, 96F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Dpi;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(220)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.Controls.Add(this.panelBuildings);
            this.Controls.Add(this.panelNotes);
            this.Controls.Add(this.buttonPersonsData);
            this.Controls.Add(this.buttonNotes);
            this.Controls.Add(this.buttonHabitabilityData);
            this.Controls.Add(this.buttonOwnershipData);
            this.Controls.Add(this.labelAddress);
            this.Font = new System.Drawing.Font("Arial", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.Name = "InsertDataInhabitantEditCreate";
            this.Size = new System.Drawing.Size(1081, 329);
            this.panelBuildings.ResumeLayout(false);
            this.panelBuildings.PerformLayout();
            this.panelNotes.ResumeLayout(false);
            this.panelNotes.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Panel panelBuildings;
        private System.Windows.Forms.Button buttonSaveBuildings;
        private System.Windows.Forms.Label labelFirstname;
        private System.Windows.Forms.Label labelTitlePersonsData;
        private InsertedDataDisplay insertedDataDisplayPersonsData;
        private System.Windows.Forms.Panel panelNotes;
        private System.Windows.Forms.Button buttonSaveNotes;
        private System.Windows.Forms.Button buttonEditNote;
        private InsertedDataDisplay insertedDataDisplayNotes;
        private System.Windows.Forms.Button buttonInsertNote;
        private System.Windows.Forms.RichTextBox richTextBoxNotes;
        private System.Windows.Forms.Label labelTitleNotes;
        private System.Windows.Forms.Button buttonPersonsData;
        private System.Windows.Forms.Button buttonNotes;
        private System.Windows.Forms.Button buttonHabitabilityData;
        private System.Windows.Forms.Button buttonOwnershipData;
        private System.Windows.Forms.Label labelAddress;
        private System.Windows.Forms.TextBox textBoxPhone;
        private System.Windows.Forms.Label labelPhone;
        private System.Windows.Forms.Button buttonInsertPersonsData;
        private System.Windows.Forms.TextBox textBoxLastname;
        private System.Windows.Forms.Label labelLastname;
        private System.Windows.Forms.TextBox textBoxMiddlename;
        private System.Windows.Forms.Label labelMiddlename;
        private System.Windows.Forms.TextBox textBoxFirstname;
        private System.Windows.Forms.RadioButton radioButtonFemale;
        private System.Windows.Forms.RadioButton radioButtonMale;
        private System.Windows.Forms.Label labelGender;
    }
}
