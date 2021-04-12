
namespace GraduationProject.Forms
{
    partial class PersonsForm
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

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.textBoxFName = new System.Windows.Forms.TextBox();
            this.labelFname = new System.Windows.Forms.Label();
            this.labelMName = new System.Windows.Forms.Label();
            this.textBoxMName = new System.Windows.Forms.TextBox();
            this.labelLName = new System.Windows.Forms.Label();
            this.textBoxLName = new System.Windows.Forms.TextBox();
            this.labelOwner = new System.Windows.Forms.Label();
            this.textBoxOwner = new System.Windows.Forms.TextBox();
            this.groupBoxGender = new System.Windows.Forms.GroupBox();
            this.radioButtonFemale = new System.Windows.Forms.RadioButton();
            this.radioButtonMale = new System.Windows.Forms.RadioButton();
            this.groupBoxAddressReg = new System.Windows.Forms.GroupBox();
            this.radioButtonAddrRegTemp = new System.Windows.Forms.RadioButton();
            this.radioButtonAddrRegYes = new System.Windows.Forms.RadioButton();
            this.radioButtonAddrRegNo = new System.Windows.Forms.RadioButton();
            this.groupBoxCovid19 = new System.Windows.Forms.GroupBox();
            this.radioButtonCovid19Contact = new System.Windows.Forms.RadioButton();
            this.radioButtonCovid19Yes = new System.Windows.Forms.RadioButton();
            this.radioButtonCovid19No = new System.Windows.Forms.RadioButton();
            this.groupBoxOwner = new System.Windows.Forms.GroupBox();
            this.radioButtonGuest = new System.Windows.Forms.RadioButton();
            this.radioButtonHousehold = new System.Windows.Forms.RadioButton();
            this.checkBoxOwner = new System.Windows.Forms.CheckBox();
            this.buttonSave = new System.Windows.Forms.Button();
            this.textBoxNotes = new System.Windows.Forms.RichTextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.groupBoxGender.SuspendLayout();
            this.groupBoxAddressReg.SuspendLayout();
            this.groupBoxCovid19.SuspendLayout();
            this.groupBoxOwner.SuspendLayout();
            this.SuspendLayout();
            // 
            // textBoxFName
            // 
            this.textBoxFName.Font = new System.Drawing.Font("Roboto", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.textBoxFName.Location = new System.Drawing.Point(77, 30);
            this.textBoxFName.Name = "textBoxFName";
            this.textBoxFName.Size = new System.Drawing.Size(149, 22);
            this.textBoxFName.TabIndex = 0;
            // 
            // labelFname
            // 
            this.labelFname.AutoSize = true;
            this.labelFname.Font = new System.Drawing.Font("Roboto", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.labelFname.Location = new System.Drawing.Point(37, 33);
            this.labelFname.Name = "labelFname";
            this.labelFname.Size = new System.Drawing.Size(33, 14);
            this.labelFname.TabIndex = 1;
            this.labelFname.Text = "Име:";
            // 
            // labelMName
            // 
            this.labelMName.AutoSize = true;
            this.labelMName.Font = new System.Drawing.Font("Roboto", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.labelMName.Location = new System.Drawing.Point(12, 73);
            this.labelMName.Name = "labelMName";
            this.labelMName.Size = new System.Drawing.Size(59, 14);
            this.labelMName.TabIndex = 3;
            this.labelMName.Text = "Презиме:";
            // 
            // textBoxMName
            // 
            this.textBoxMName.Font = new System.Drawing.Font("Roboto", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.textBoxMName.Location = new System.Drawing.Point(77, 70);
            this.textBoxMName.Name = "textBoxMName";
            this.textBoxMName.Size = new System.Drawing.Size(149, 22);
            this.textBoxMName.TabIndex = 2;
            // 
            // labelLName
            // 
            this.labelLName.AutoSize = true;
            this.labelLName.Font = new System.Drawing.Font("Roboto", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.labelLName.Location = new System.Drawing.Point(10, 113);
            this.labelLName.Name = "labelLName";
            this.labelLName.Size = new System.Drawing.Size(62, 14);
            this.labelLName.TabIndex = 5;
            this.labelLName.Text = "Фамилия:";
            // 
            // textBoxLName
            // 
            this.textBoxLName.Font = new System.Drawing.Font("Roboto", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.textBoxLName.Location = new System.Drawing.Point(77, 110);
            this.textBoxLName.Name = "textBoxLName";
            this.textBoxLName.Size = new System.Drawing.Size(149, 22);
            this.textBoxLName.TabIndex = 4;
            // 
            // labelOwner
            // 
            this.labelOwner.AutoSize = true;
            this.labelOwner.Font = new System.Drawing.Font("Roboto", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.labelOwner.Location = new System.Drawing.Point(66, 165);
            this.labelOwner.Name = "labelOwner";
            this.labelOwner.Size = new System.Drawing.Size(150, 14);
            this.labelOwner.TabIndex = 7;
            this.labelOwner.Text = "Връзка със собственика:";
            // 
            // textBoxOwner
            // 
            this.textBoxOwner.Font = new System.Drawing.Font("Roboto", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.textBoxOwner.Location = new System.Drawing.Point(232, 157);
            this.textBoxOwner.Name = "textBoxOwner";
            this.textBoxOwner.Size = new System.Drawing.Size(149, 22);
            this.textBoxOwner.TabIndex = 6;
            // 
            // groupBoxGender
            // 
            this.groupBoxGender.Controls.Add(this.radioButtonFemale);
            this.groupBoxGender.Controls.Add(this.radioButtonMale);
            this.groupBoxGender.Font = new System.Drawing.Font("Roboto", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.groupBoxGender.Location = new System.Drawing.Point(255, 29);
            this.groupBoxGender.Name = "groupBoxGender";
            this.groupBoxGender.Size = new System.Drawing.Size(192, 63);
            this.groupBoxGender.TabIndex = 10;
            this.groupBoxGender.TabStop = false;
            this.groupBoxGender.Text = "Пол";
            // 
            // radioButtonFemale
            // 
            this.radioButtonFemale.AutoSize = true;
            this.radioButtonFemale.Location = new System.Drawing.Point(119, 36);
            this.radioButtonFemale.Name = "radioButtonFemale";
            this.radioButtonFemale.Size = new System.Drawing.Size(55, 18);
            this.radioButtonFemale.TabIndex = 1;
            this.radioButtonFemale.TabStop = true;
            this.radioButtonFemale.Text = "Жена";
            this.radioButtonFemale.UseVisualStyleBackColor = true;
            // 
            // radioButtonMale
            // 
            this.radioButtonMale.AutoSize = true;
            this.radioButtonMale.Location = new System.Drawing.Point(6, 36);
            this.radioButtonMale.Name = "radioButtonMale";
            this.radioButtonMale.Size = new System.Drawing.Size(51, 18);
            this.radioButtonMale.TabIndex = 0;
            this.radioButtonMale.TabStop = true;
            this.radioButtonMale.Text = "Мъж";
            this.radioButtonMale.UseVisualStyleBackColor = true;
            // 
            // groupBoxAddressReg
            // 
            this.groupBoxAddressReg.Controls.Add(this.radioButtonAddrRegTemp);
            this.groupBoxAddressReg.Controls.Add(this.radioButtonAddrRegYes);
            this.groupBoxAddressReg.Controls.Add(this.radioButtonAddrRegNo);
            this.groupBoxAddressReg.Font = new System.Drawing.Font("Roboto", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.groupBoxAddressReg.Location = new System.Drawing.Point(180, 215);
            this.groupBoxAddressReg.Name = "groupBoxAddressReg";
            this.groupBoxAddressReg.Size = new System.Drawing.Size(112, 120);
            this.groupBoxAddressReg.TabIndex = 11;
            this.groupBoxAddressReg.TabStop = false;
            this.groupBoxAddressReg.Text = "Адресна регистрация:";
            // 
            // radioButtonAddrRegTemp
            // 
            this.radioButtonAddrRegTemp.AutoSize = true;
            this.radioButtonAddrRegTemp.Location = new System.Drawing.Point(6, 86);
            this.radioButtonAddrRegTemp.Name = "radioButtonAddrRegTemp";
            this.radioButtonAddrRegTemp.Size = new System.Drawing.Size(82, 18);
            this.radioButtonAddrRegTemp.TabIndex = 3;
            this.radioButtonAddrRegTemp.TabStop = true;
            this.radioButtonAddrRegTemp.Text = "Временна";
            this.radioButtonAddrRegTemp.UseVisualStyleBackColor = true;
            // 
            // radioButtonAddrRegYes
            // 
            this.radioButtonAddrRegYes.AutoSize = true;
            this.radioButtonAddrRegYes.Location = new System.Drawing.Point(6, 61);
            this.radioButtonAddrRegYes.Name = "radioButtonAddrRegYes";
            this.radioButtonAddrRegYes.Size = new System.Drawing.Size(49, 18);
            this.radioButtonAddrRegYes.TabIndex = 1;
            this.radioButtonAddrRegYes.TabStop = true;
            this.radioButtonAddrRegYes.Text = "Има";
            this.radioButtonAddrRegYes.UseVisualStyleBackColor = true;
            // 
            // radioButtonAddrRegNo
            // 
            this.radioButtonAddrRegNo.AutoSize = true;
            this.radioButtonAddrRegNo.Location = new System.Drawing.Point(6, 36);
            this.radioButtonAddrRegNo.Name = "radioButtonAddrRegNo";
            this.radioButtonAddrRegNo.Size = new System.Drawing.Size(56, 18);
            this.radioButtonAddrRegNo.TabIndex = 0;
            this.radioButtonAddrRegNo.TabStop = true;
            this.radioButtonAddrRegNo.Text = "Няма";
            this.radioButtonAddrRegNo.UseVisualStyleBackColor = true;
            // 
            // groupBoxCovid19
            // 
            this.groupBoxCovid19.Controls.Add(this.radioButtonCovid19Contact);
            this.groupBoxCovid19.Controls.Add(this.radioButtonCovid19Yes);
            this.groupBoxCovid19.Controls.Add(this.radioButtonCovid19No);
            this.groupBoxCovid19.Font = new System.Drawing.Font("Roboto", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.groupBoxCovid19.Location = new System.Drawing.Point(319, 215);
            this.groupBoxCovid19.Name = "groupBoxCovid19";
            this.groupBoxCovid19.Size = new System.Drawing.Size(128, 120);
            this.groupBoxCovid19.TabIndex = 12;
            this.groupBoxCovid19.TabStop = false;
            this.groupBoxCovid19.Text = "Covid 19";
            // 
            // radioButtonCovid19Contact
            // 
            this.radioButtonCovid19Contact.AutoSize = true;
            this.radioButtonCovid19Contact.Location = new System.Drawing.Point(6, 86);
            this.radioButtonCovid19Contact.Name = "radioButtonCovid19Contact";
            this.radioButtonCovid19Contact.Size = new System.Drawing.Size(86, 18);
            this.radioButtonCovid19Contact.TabIndex = 3;
            this.radioButtonCovid19Contact.TabStop = true;
            this.radioButtonCovid19Contact.Text = "Контактен";
            this.radioButtonCovid19Contact.UseVisualStyleBackColor = true;
            // 
            // radioButtonCovid19Yes
            // 
            this.radioButtonCovid19Yes.AutoSize = true;
            this.radioButtonCovid19Yes.Location = new System.Drawing.Point(6, 61);
            this.radioButtonCovid19Yes.Name = "radioButtonCovid19Yes";
            this.radioButtonCovid19Yes.Size = new System.Drawing.Size(49, 18);
            this.radioButtonCovid19Yes.TabIndex = 1;
            this.radioButtonCovid19Yes.TabStop = true;
            this.radioButtonCovid19Yes.Text = "Има";
            this.radioButtonCovid19Yes.UseVisualStyleBackColor = true;
            // 
            // radioButtonCovid19No
            // 
            this.radioButtonCovid19No.AutoSize = true;
            this.radioButtonCovid19No.Location = new System.Drawing.Point(6, 36);
            this.radioButtonCovid19No.Name = "radioButtonCovid19No";
            this.radioButtonCovid19No.Size = new System.Drawing.Size(56, 18);
            this.radioButtonCovid19No.TabIndex = 0;
            this.radioButtonCovid19No.TabStop = true;
            this.radioButtonCovid19No.Text = "Няма";
            this.radioButtonCovid19No.UseVisualStyleBackColor = true;
            // 
            // groupBoxOwner
            // 
            this.groupBoxOwner.Controls.Add(this.radioButtonGuest);
            this.groupBoxOwner.Controls.Add(this.radioButtonHousehold);
            this.groupBoxOwner.Font = new System.Drawing.Font("Roboto", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.groupBoxOwner.Location = new System.Drawing.Point(17, 215);
            this.groupBoxOwner.Name = "groupBoxOwner";
            this.groupBoxOwner.Size = new System.Drawing.Size(131, 93);
            this.groupBoxOwner.TabIndex = 13;
            this.groupBoxOwner.TabStop = false;
            // 
            // radioButtonGuest
            // 
            this.radioButtonGuest.AutoSize = true;
            this.radioButtonGuest.Location = new System.Drawing.Point(6, 61);
            this.radioButtonGuest.Name = "radioButtonGuest";
            this.radioButtonGuest.Size = new System.Drawing.Size(51, 18);
            this.radioButtonGuest.TabIndex = 1;
            this.radioButtonGuest.TabStop = true;
            this.radioButtonGuest.Text = "Гост";
            this.radioButtonGuest.UseVisualStyleBackColor = true;
            this.radioButtonGuest.CheckedChanged += new System.EventHandler(this.radioButtonGuest_CheckedChanged);
            // 
            // radioButtonHousehold
            // 
            this.radioButtonHousehold.Location = new System.Drawing.Point(6, 11);
            this.radioButtonHousehold.Name = "radioButtonHousehold";
            this.radioButtonHousehold.Size = new System.Drawing.Size(122, 44);
            this.radioButtonHousehold.TabIndex = 0;
            this.radioButtonHousehold.TabStop = true;
            this.radioButtonHousehold.Text = "Член на домакинството";
            this.radioButtonHousehold.UseVisualStyleBackColor = true;
            this.radioButtonHousehold.CheckedChanged += new System.EventHandler(this.radioButtonHousehold_CheckedChanged);
            // 
            // checkBoxOwner
            // 
            this.checkBoxOwner.AutoSize = true;
            this.checkBoxOwner.Location = new System.Drawing.Point(261, 110);
            this.checkBoxOwner.Name = "checkBoxOwner";
            this.checkBoxOwner.Size = new System.Drawing.Size(91, 19);
            this.checkBoxOwner.TabIndex = 3;
            this.checkBoxOwner.Text = "Собственик";
            this.checkBoxOwner.UseVisualStyleBackColor = true;
            this.checkBoxOwner.CheckedChanged += new System.EventHandler(this.checkBoxOwner_CheckedChanged);
            // 
            // buttonSave
            // 
            this.buttonSave.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.buttonSave.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonSave.Font = new System.Drawing.Font("Roboto", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.buttonSave.Location = new System.Drawing.Point(17, 389);
            this.buttonSave.Name = "buttonSave";
            this.buttonSave.Size = new System.Drawing.Size(125, 34);
            this.buttonSave.TabIndex = 14;
            this.buttonSave.Text = "Запази";
            this.buttonSave.UseVisualStyleBackColor = false;
            this.buttonSave.Click += new System.EventHandler(this.buttonSave_Click);
            // 
            // notesRichTextBox
            // 
            this.textBoxNotes.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.textBoxNotes.Font = new System.Drawing.Font("Roboto", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.textBoxNotes.Location = new System.Drawing.Point(214, 368);
            this.textBoxNotes.Name = "notesRichTextBox";
            this.textBoxNotes.Size = new System.Drawing.Size(233, 57);
            this.textBoxNotes.TabIndex = 15;
            this.textBoxNotes.Text = "";
            this.textBoxNotes.TextChanged += new System.EventHandler(this.richTextBox1_TextChanged);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Roboto", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label1.Location = new System.Drawing.Point(214, 351);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(74, 14);
            this.label1.TabIndex = 16;
            this.label1.Text = "Забележки:";
            // 
            // PersonsForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(184)))), ((int)(((byte)(216)))), ((int)(((byte)(186)))));
            this.ClientSize = new System.Drawing.Size(461, 435);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.textBoxNotes);
            this.Controls.Add(this.checkBoxOwner);
            this.Controls.Add(this.buttonSave);
            this.Controls.Add(this.groupBoxOwner);
            this.Controls.Add(this.groupBoxCovid19);
            this.Controls.Add(this.groupBoxAddressReg);
            this.Controls.Add(this.groupBoxGender);
            this.Controls.Add(this.labelOwner);
            this.Controls.Add(this.textBoxOwner);
            this.Controls.Add(this.labelLName);
            this.Controls.Add(this.textBoxLName);
            this.Controls.Add(this.labelMName);
            this.Controls.Add(this.textBoxMName);
            this.Controls.Add(this.labelFname);
            this.Controls.Add(this.textBoxFName);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.Name = "PersonsForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "PersonsForm";
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.PersonsForm_FormClosed);
            this.groupBoxGender.ResumeLayout(false);
            this.groupBoxGender.PerformLayout();
            this.groupBoxAddressReg.ResumeLayout(false);
            this.groupBoxAddressReg.PerformLayout();
            this.groupBoxCovid19.ResumeLayout(false);
            this.groupBoxCovid19.PerformLayout();
            this.groupBoxOwner.ResumeLayout(false);
            this.groupBoxOwner.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox textBoxFName;
        private System.Windows.Forms.Label labelFname;
        private System.Windows.Forms.Label labelMName;
        private System.Windows.Forms.TextBox textBoxMName;
        private System.Windows.Forms.Label labelLName;
        private System.Windows.Forms.TextBox textBoxLName;
        private System.Windows.Forms.Label labelOwner;
        private System.Windows.Forms.TextBox textBoxOwner;
        private System.Windows.Forms.GroupBox groupBoxGender;
        private System.Windows.Forms.RadioButton radioButtonFemale;
        private System.Windows.Forms.RadioButton radioButtonMale;
        private System.Windows.Forms.GroupBox groupBoxAddressReg;
        private System.Windows.Forms.RadioButton radioButtonAddrRegTemp;
        private System.Windows.Forms.RadioButton radioButtonAddrRegYes;
        private System.Windows.Forms.RadioButton radioButtonAddrRegNo;
        private System.Windows.Forms.GroupBox groupBoxCovid19;
        private System.Windows.Forms.RadioButton radioButtonCovid19Contact;
        private System.Windows.Forms.RadioButton radioButtonCovid19Yes;
        private System.Windows.Forms.RadioButton radioButtonCovid19No;
        private System.Windows.Forms.GroupBox groupBoxOwner;
        private System.Windows.Forms.CheckBox checkBoxOwner;
        private System.Windows.Forms.RadioButton radioButtonGuest;
        private System.Windows.Forms.RadioButton radioButtonHousehold;
        private System.Windows.Forms.Button buttonSave;
        private System.Windows.Forms.RichTextBox textBoxNotes;
        private System.Windows.Forms.Label label1;
    }
}