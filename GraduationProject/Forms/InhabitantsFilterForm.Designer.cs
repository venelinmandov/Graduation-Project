
namespace GraduationProject.Forms
{
    partial class InhabitantsFilterForm
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
            this.groupBox = new System.Windows.Forms.GroupBox();
            this.radioButtonAll = new System.Windows.Forms.RadioButton();
            this.radioButtonGuest = new System.Windows.Forms.RadioButton();
            this.radioButtonResident = new System.Windows.Forms.RadioButton();
            this.buttonSearch = new System.Windows.Forms.Button();
            this.buttonSearchByAddress = new System.Windows.Forms.Button();
            this.labelStreet = new System.Windows.Forms.Label();
            this.textBoxLastname = new System.Windows.Forms.TextBox();
            this.labelLastname = new System.Windows.Forms.Label();
            this.textBoxMiddlename = new System.Windows.Forms.TextBox();
            this.comboBoxStreet = new System.Windows.Forms.ComboBox();
            this.panelSearchByAddress = new System.Windows.Forms.Panel();
            this.labelNumber = new System.Windows.Forms.Label();
            this.numericUpDownNumber = new System.Windows.Forms.NumericUpDown();
            this.labelMiddlename = new System.Windows.Forms.Label();
            this.textBoxFirstname = new System.Windows.Forms.TextBox();
            this.labelTitle = new System.Windows.Forms.Label();
            this.panelSearchByNames = new System.Windows.Forms.Panel();
            this.labelFirstname = new System.Windows.Forms.Label();
            this.buttonSearchByNames = new System.Windows.Forms.Button();
            this.groupBox.SuspendLayout();
            this.panelSearchByAddress.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDownNumber)).BeginInit();
            this.panelSearchByNames.SuspendLayout();
            this.SuspendLayout();
            // 
            // groupBox
            // 
            this.groupBox.Controls.Add(this.radioButtonAll);
            this.groupBox.Controls.Add(this.radioButtonGuest);
            this.groupBox.Controls.Add(this.radioButtonResident);
            this.groupBox.Location = new System.Drawing.Point(244, 19);
            this.groupBox.Name = "groupBox";
            this.groupBox.Size = new System.Drawing.Size(136, 81);
            this.groupBox.TabIndex = 6;
            this.groupBox.TabStop = false;
            // 
            // radioButtonAll
            // 
            this.radioButtonAll.AutoSize = true;
            this.radioButtonAll.Location = new System.Drawing.Point(6, 56);
            this.radioButtonAll.Name = "radioButtonAll";
            this.radioButtonAll.Size = new System.Drawing.Size(65, 19);
            this.radioButtonAll.TabIndex = 2;
            this.radioButtonAll.TabStop = true;
            this.radioButtonAll.Text = "Всички";
            this.radioButtonAll.UseVisualStyleBackColor = true;
            // 
            // radioButtonGuest
            // 
            this.radioButtonGuest.AutoSize = true;
            this.radioButtonGuest.Location = new System.Drawing.Point(6, 33);
            this.radioButtonGuest.Name = "radioButtonGuest";
            this.radioButtonGuest.Size = new System.Drawing.Size(121, 19);
            this.radioButtonGuest.TabIndex = 1;
            this.radioButtonGuest.TabStop = true;
            this.radioButtonGuest.Text = "Гост в карантина";
            this.radioButtonGuest.UseVisualStyleBackColor = true;
            // 
            // radioButtonResident
            // 
            this.radioButtonResident.AutoSize = true;
            this.radioButtonResident.Location = new System.Drawing.Point(6, 12);
            this.radioButtonResident.Name = "radioButtonResident";
            this.radioButtonResident.Size = new System.Drawing.Size(62, 19);
            this.radioButtonResident.TabIndex = 0;
            this.radioButtonResident.TabStop = true;
            this.radioButtonResident.Text = "Жител";
            this.radioButtonResident.UseVisualStyleBackColor = true;
            // 
            // buttonSearch
            // 
            this.buttonSearch.BackColor = System.Drawing.SystemColors.ButtonFace;
            this.buttonSearch.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(184)))), ((int)(((byte)(216)))), ((int)(((byte)(186)))));
            this.buttonSearch.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonSearch.Location = new System.Drawing.Point(7, 188);
            this.buttonSearch.Name = "buttonSearch";
            this.buttonSearch.Size = new System.Drawing.Size(81, 27);
            this.buttonSearch.TabIndex = 9;
            this.buttonSearch.Text = "Търсене";
            this.buttonSearch.UseVisualStyleBackColor = false;
            this.buttonSearch.Click += new System.EventHandler(this.buttonSearch_Click);
            // 
            // buttonSearchByAddress
            // 
            this.buttonSearchByAddress.BackColor = System.Drawing.SystemColors.ButtonFace;
            this.buttonSearchByAddress.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(184)))), ((int)(((byte)(216)))), ((int)(((byte)(186)))));
            this.buttonSearchByAddress.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonSearchByAddress.Location = new System.Drawing.Point(0, 21);
            this.buttonSearchByAddress.Name = "buttonSearchByAddress";
            this.buttonSearchByAddress.Size = new System.Drawing.Size(96, 38);
            this.buttonSearchByAddress.TabIndex = 13;
            this.buttonSearchByAddress.Text = "Търсене по адрес";
            this.buttonSearchByAddress.UseVisualStyleBackColor = false;
            this.buttonSearchByAddress.Click += new System.EventHandler(this.buttonSearchByAddress_Click);
            // 
            // labelStreet
            // 
            this.labelStreet.AutoSize = true;
            this.labelStreet.Location = new System.Drawing.Point(11, 18);
            this.labelStreet.Name = "labelStreet";
            this.labelStreet.Size = new System.Drawing.Size(43, 14);
            this.labelStreet.TabIndex = 7;
            this.labelStreet.Text = "Улица";
            // 
            // textBoxLastname
            // 
            this.textBoxLastname.Location = new System.Drawing.Point(73, 72);
            this.textBoxLastname.Name = "textBoxLastname";
            this.textBoxLastname.Size = new System.Drawing.Size(154, 22);
            this.textBoxLastname.TabIndex = 5;
            // 
            // labelLastname
            // 
            this.labelLastname.AutoSize = true;
            this.labelLastname.Location = new System.Drawing.Point(8, 79);
            this.labelLastname.Name = "labelLastname";
            this.labelLastname.Size = new System.Drawing.Size(60, 15);
            this.labelLastname.TabIndex = 4;
            this.labelLastname.Text = "Фамилия";
            // 
            // textBoxMiddlename
            // 
            this.textBoxMiddlename.Location = new System.Drawing.Point(73, 45);
            this.textBoxMiddlename.Name = "textBoxMiddlename";
            this.textBoxMiddlename.Size = new System.Drawing.Size(154, 22);
            this.textBoxMiddlename.TabIndex = 3;
            // 
            // comboBoxStreet
            // 
            this.comboBoxStreet.DrawMode = System.Windows.Forms.DrawMode.OwnerDrawFixed;
            this.comboBoxStreet.FormattingEnabled = true;
            this.comboBoxStreet.Location = new System.Drawing.Point(11, 42);
            this.comboBoxStreet.Name = "comboBoxStreet";
            this.comboBoxStreet.Size = new System.Drawing.Size(163, 23);
            this.comboBoxStreet.TabIndex = 8;
            this.comboBoxStreet.DrawItem += new System.Windows.Forms.DrawItemEventHandler(this.comboBox_DrawItem);
            // 
            // panelSearchByAddress
            // 
            this.panelSearchByAddress.Controls.Add(this.labelNumber);
            this.panelSearchByAddress.Controls.Add(this.numericUpDownNumber);
            this.panelSearchByAddress.Controls.Add(this.comboBoxStreet);
            this.panelSearchByAddress.Controls.Add(this.labelStreet);
            this.panelSearchByAddress.Location = new System.Drawing.Point(0, 56);
            this.panelSearchByAddress.Name = "panelSearchByAddress";
            this.panelSearchByAddress.Size = new System.Drawing.Size(391, 114);
            this.panelSearchByAddress.TabIndex = 12;
            // 
            // labelNumber
            // 
            this.labelNumber.AutoSize = true;
            this.labelNumber.Location = new System.Drawing.Point(181, 18);
            this.labelNumber.Name = "labelNumber";
            this.labelNumber.Size = new System.Drawing.Size(44, 14);
            this.labelNumber.TabIndex = 10;
            this.labelNumber.Text = "Номер";
            // 
            // numericUpDownNumber
            // 
            this.numericUpDownNumber.Location = new System.Drawing.Point(181, 42);
            this.numericUpDownNumber.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.numericUpDownNumber.Name = "numericUpDownNumber";
            this.numericUpDownNumber.Size = new System.Drawing.Size(46, 22);
            this.numericUpDownNumber.TabIndex = 9;
            this.numericUpDownNumber.Value = new decimal(new int[] {
            1,
            0,
            0,
            0});
            // 
            // labelMiddlename
            // 
            this.labelMiddlename.AutoSize = true;
            this.labelMiddlename.Location = new System.Drawing.Point(9, 51);
            this.labelMiddlename.Name = "labelMiddlename";
            this.labelMiddlename.Size = new System.Drawing.Size(59, 15);
            this.labelMiddlename.TabIndex = 2;
            this.labelMiddlename.Text = "Презиме";
            // 
            // textBoxFirstname
            // 
            this.textBoxFirstname.Location = new System.Drawing.Point(73, 18);
            this.textBoxFirstname.Name = "textBoxFirstname";
            this.textBoxFirstname.Size = new System.Drawing.Size(154, 22);
            this.textBoxFirstname.TabIndex = 1;
            // 
            // labelTitle
            // 
            this.labelTitle.AutoSize = true;
            this.labelTitle.Location = new System.Drawing.Point(0, 2);
            this.labelTitle.Name = "labelTitle";
            this.labelTitle.Size = new System.Drawing.Size(202, 14);
            this.labelTitle.TabIndex = 10;
            this.labelTitle.Text = "Критерии за търсене на обитател:";
            // 
            // panelSearchByNames
            // 
            this.panelSearchByNames.Controls.Add(this.groupBox);
            this.panelSearchByNames.Controls.Add(this.textBoxLastname);
            this.panelSearchByNames.Controls.Add(this.labelLastname);
            this.panelSearchByNames.Controls.Add(this.textBoxMiddlename);
            this.panelSearchByNames.Controls.Add(this.labelMiddlename);
            this.panelSearchByNames.Controls.Add(this.textBoxFirstname);
            this.panelSearchByNames.Controls.Add(this.labelFirstname);
            this.panelSearchByNames.Location = new System.Drawing.Point(0, 60);
            this.panelSearchByNames.Name = "panelSearchByNames";
            this.panelSearchByNames.Size = new System.Drawing.Size(391, 122);
            this.panelSearchByNames.TabIndex = 11;
            // 
            // labelFirstname
            // 
            this.labelFirstname.AutoSize = true;
            this.labelFirstname.Location = new System.Drawing.Point(36, 22);
            this.labelFirstname.Name = "labelFirstname";
            this.labelFirstname.Size = new System.Drawing.Size(32, 15);
            this.labelFirstname.TabIndex = 0;
            this.labelFirstname.Text = "Име";
            // 
            // buttonSearchByNames
            // 
            this.buttonSearchByNames.BackColor = System.Drawing.SystemColors.ButtonFace;
            this.buttonSearchByNames.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(184)))), ((int)(((byte)(216)))), ((int)(((byte)(186)))));
            this.buttonSearchByNames.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonSearchByNames.Location = new System.Drawing.Point(97, 21);
            this.buttonSearchByNames.Name = "buttonSearchByNames";
            this.buttonSearchByNames.Size = new System.Drawing.Size(96, 38);
            this.buttonSearchByNames.TabIndex = 14;
            this.buttonSearchByNames.Text = "Търсене по имена";
            this.buttonSearchByNames.UseVisualStyleBackColor = false;
            this.buttonSearchByNames.Click += new System.EventHandler(this.buttonSearchByNames_Click);
            // 
            // InhabitantsFilterForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(184)))), ((int)(((byte)(216)))), ((int)(((byte)(186)))));
            this.ClientSize = new System.Drawing.Size(392, 219);
            this.Controls.Add(this.buttonSearch);
            this.Controls.Add(this.labelTitle);
            this.Controls.Add(this.panelSearchByNames);
            this.Controls.Add(this.panelSearchByAddress);
            this.Controls.Add(this.buttonSearchByAddress);
            this.Controls.Add(this.buttonSearchByNames);
            this.Font = new System.Drawing.Font("Arial", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.Name = "InhabitantsFilterForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Филтри";
            this.Load += new System.EventHandler(this.InhabitantsFilterForm_Load);
            this.groupBox.ResumeLayout(false);
            this.groupBox.PerformLayout();
            this.panelSearchByAddress.ResumeLayout(false);
            this.panelSearchByAddress.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDownNumber)).EndInit();
            this.panelSearchByNames.ResumeLayout(false);
            this.panelSearchByNames.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.GroupBox groupBox;
        private System.Windows.Forms.RadioButton radioButtonAll;
        private System.Windows.Forms.RadioButton radioButtonGuest;
        private System.Windows.Forms.RadioButton radioButtonResident;
        private System.Windows.Forms.Button buttonSearch;
        private System.Windows.Forms.Button buttonSearchByAddress;
        private System.Windows.Forms.Label labelStreet;
        private System.Windows.Forms.TextBox textBoxLastname;
        private System.Windows.Forms.Label labelLastname;
        private System.Windows.Forms.TextBox textBoxMiddlename;
        private System.Windows.Forms.ComboBox comboBoxStreet;
        private System.Windows.Forms.Panel panelSearchByAddress;
        private System.Windows.Forms.Label labelMiddlename;
        private System.Windows.Forms.TextBox textBoxFirstname;
        private System.Windows.Forms.Label labelTitle;
        private System.Windows.Forms.Panel panelSearchByNames;
        private System.Windows.Forms.Label labelFirstname;
        private System.Windows.Forms.Button buttonSearchByNames;
        private System.Windows.Forms.Label labelNumber;
        private System.Windows.Forms.NumericUpDown numericUpDownNumber;
    }
}