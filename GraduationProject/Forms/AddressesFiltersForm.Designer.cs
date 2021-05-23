
namespace GraduationProject.Forms
{
    partial class AddressesFiltersForm
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
            this.buttonSearch = new System.Windows.Forms.Button();
            this.labelTitle = new System.Windows.Forms.Label();
            this.panelSearchByInhabitant = new System.Windows.Forms.Panel();
            this.groupBoxPersons = new System.Windows.Forms.GroupBox();
            this.radioButtonAll = new System.Windows.Forms.RadioButton();
            this.radioButtonGuest = new System.Windows.Forms.RadioButton();
            this.radioButtonResident = new System.Windows.Forms.RadioButton();
            this.textBoxLastname = new System.Windows.Forms.TextBox();
            this.labelLastname = new System.Windows.Forms.Label();
            this.textBoxMiddlename = new System.Windows.Forms.TextBox();
            this.labelMiddlename = new System.Windows.Forms.Label();
            this.textBoxFirstname = new System.Windows.Forms.TextBox();
            this.labelFirstname = new System.Windows.Forms.Label();
            this.panelSearchByAnimal = new System.Windows.Forms.Panel();
            this.comboBoxAnimals = new System.Windows.Forms.ComboBox();
            this.labelSearchByAnimal = new System.Windows.Forms.Label();
            this.buttonSearchByInhabitant = new System.Windows.Forms.Button();
            this.buttonSearchByAnimals = new System.Windows.Forms.Button();
            this.buttonSearchByStreet = new System.Windows.Forms.Button();
            this.panelSearchByStreet = new System.Windows.Forms.Panel();
            this.comboBoxStreets = new System.Windows.Forms.ComboBox();
            this.labelSearchByStreet = new System.Windows.Forms.Label();
            this.panelSearchByInhabitant.SuspendLayout();
            this.groupBoxPersons.SuspendLayout();
            this.panelSearchByAnimal.SuspendLayout();
            this.panelSearchByStreet.SuspendLayout();
            this.SuspendLayout();
            // 
            // buttonSearch
            // 
            this.buttonSearch.BackColor = System.Drawing.SystemColors.ButtonFace;
            this.buttonSearch.FlatAppearance.BorderSize = 0;
            this.buttonSearch.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonSearch.Location = new System.Drawing.Point(8, 190);
            this.buttonSearch.Name = "buttonSearch";
            this.buttonSearch.Size = new System.Drawing.Size(75, 22);
            this.buttonSearch.TabIndex = 0;
            this.buttonSearch.Text = "Търсене";
            this.buttonSearch.UseVisualStyleBackColor = false;
            this.buttonSearch.Click += new System.EventHandler(this.buttonSearch_Click);
            // 
            // labelTitle
            // 
            this.labelTitle.AutoSize = true;
            this.labelTitle.Location = new System.Drawing.Point(1, 4);
            this.labelTitle.Name = "labelTitle";
            this.labelTitle.Size = new System.Drawing.Size(184, 15);
            this.labelTitle.TabIndex = 2;
            this.labelTitle.Text = "Критерии за търсене на адрес:";
            // 
            // panelSearchByInhabitant
            // 
            this.panelSearchByInhabitant.Controls.Add(this.groupBoxPersons);
            this.panelSearchByInhabitant.Controls.Add(this.textBoxLastname);
            this.panelSearchByInhabitant.Controls.Add(this.labelLastname);
            this.panelSearchByInhabitant.Controls.Add(this.textBoxMiddlename);
            this.panelSearchByInhabitant.Controls.Add(this.labelMiddlename);
            this.panelSearchByInhabitant.Controls.Add(this.textBoxFirstname);
            this.panelSearchByInhabitant.Controls.Add(this.labelFirstname);
            this.panelSearchByInhabitant.Location = new System.Drawing.Point(1, 62);
            this.panelSearchByInhabitant.Name = "panelSearchByInhabitant";
            this.panelSearchByInhabitant.Size = new System.Drawing.Size(394, 122);
            this.panelSearchByInhabitant.TabIndex = 3;
            // 
            // groupBoxPersons
            // 
            this.groupBoxPersons.Controls.Add(this.radioButtonAll);
            this.groupBoxPersons.Controls.Add(this.radioButtonGuest);
            this.groupBoxPersons.Controls.Add(this.radioButtonResident);
            this.groupBoxPersons.Location = new System.Drawing.Point(244, 27);
            this.groupBoxPersons.Name = "groupBoxPersons";
            this.groupBoxPersons.Size = new System.Drawing.Size(139, 81);
            this.groupBoxPersons.TabIndex = 6;
            this.groupBoxPersons.TabStop = false;
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
            // textBoxLastname
            // 
            this.textBoxLastname.Location = new System.Drawing.Point(73, 85);
            this.textBoxLastname.Name = "textBoxLastname";
            this.textBoxLastname.Size = new System.Drawing.Size(154, 21);
            this.textBoxLastname.TabIndex = 5;
            // 
            // labelLastname
            // 
            this.labelLastname.AutoSize = true;
            this.labelLastname.Location = new System.Drawing.Point(7, 87);
            this.labelLastname.Name = "labelLastname";
            this.labelLastname.Size = new System.Drawing.Size(60, 15);
            this.labelLastname.TabIndex = 4;
            this.labelLastname.Text = "Фамилия";
            // 
            // textBoxMiddlename
            // 
            this.textBoxMiddlename.Location = new System.Drawing.Point(73, 56);
            this.textBoxMiddlename.Name = "textBoxMiddlename";
            this.textBoxMiddlename.Size = new System.Drawing.Size(154, 21);
            this.textBoxMiddlename.TabIndex = 3;
            // 
            // labelMiddlename
            // 
            this.labelMiddlename.AutoSize = true;
            this.labelMiddlename.Location = new System.Drawing.Point(8, 59);
            this.labelMiddlename.Name = "labelMiddlename";
            this.labelMiddlename.Size = new System.Drawing.Size(59, 15);
            this.labelMiddlename.TabIndex = 2;
            this.labelMiddlename.Text = "Презиме";
            // 
            // textBoxFirstname
            // 
            this.textBoxFirstname.Location = new System.Drawing.Point(73, 27);
            this.textBoxFirstname.Name = "textBoxFirstname";
            this.textBoxFirstname.Size = new System.Drawing.Size(154, 21);
            this.textBoxFirstname.TabIndex = 1;
            // 
            // labelFirstname
            // 
            this.labelFirstname.AutoSize = true;
            this.labelFirstname.Location = new System.Drawing.Point(35, 30);
            this.labelFirstname.Name = "labelFirstname";
            this.labelFirstname.Size = new System.Drawing.Size(32, 15);
            this.labelFirstname.TabIndex = 0;
            this.labelFirstname.Text = "Име";
            // 
            // panelSearchByAnimal
            // 
            this.panelSearchByAnimal.Controls.Add(this.comboBoxAnimals);
            this.panelSearchByAnimal.Controls.Add(this.labelSearchByAnimal);
            this.panelSearchByAnimal.Location = new System.Drawing.Point(1, 62);
            this.panelSearchByAnimal.Name = "panelSearchByAnimal";
            this.panelSearchByAnimal.Size = new System.Drawing.Size(394, 122);
            this.panelSearchByAnimal.TabIndex = 4;
            // 
            // comboBoxAnimals
            // 
            this.comboBoxAnimals.DrawMode = System.Windows.Forms.DrawMode.OwnerDrawFixed;
            this.comboBoxAnimals.FormattingEnabled = true;
            this.comboBoxAnimals.Items.AddRange(new object[] {
            "Крави",
            "Овце",
            "Кози",
            "Коне",
            "Магарета",
            "Пернати",
            "Свине"});
            this.comboBoxAnimals.Location = new System.Drawing.Point(11, 45);
            this.comboBoxAnimals.Name = "comboBoxAnimals";
            this.comboBoxAnimals.Size = new System.Drawing.Size(163, 22);
            this.comboBoxAnimals.TabIndex = 8;
            this.comboBoxAnimals.DrawItem += new System.Windows.Forms.DrawItemEventHandler(this.comboBox_DrawItem);
            // 
            // labelSearchByAnimal
            // 
            this.labelSearchByAnimal.AutoSize = true;
            this.labelSearchByAnimal.Location = new System.Drawing.Point(11, 19);
            this.labelSearchByAnimal.Name = "labelSearchByAnimal";
            this.labelSearchByAnimal.Size = new System.Drawing.Size(112, 15);
            this.labelSearchByAnimal.TabIndex = 7;
            this.labelSearchByAnimal.Text = "Изберете добитък";
            // 
            // buttonSearchByInhabitant
            // 
            this.buttonSearchByInhabitant.BackColor = System.Drawing.SystemColors.ButtonFace;
            this.buttonSearchByInhabitant.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(184)))), ((int)(((byte)(216)))), ((int)(((byte)(186)))));
            this.buttonSearchByInhabitant.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonSearchByInhabitant.Location = new System.Drawing.Point(2, 22);
            this.buttonSearchByInhabitant.Name = "buttonSearchByInhabitant";
            this.buttonSearchByInhabitant.Size = new System.Drawing.Size(107, 41);
            this.buttonSearchByInhabitant.TabIndex = 5;
            this.buttonSearchByInhabitant.Text = "Търсене по обитател";
            this.buttonSearchByInhabitant.UseVisualStyleBackColor = false;
            this.buttonSearchByInhabitant.Click += new System.EventHandler(this.buttonSearchByInhabitant_Click);
            // 
            // buttonSearchByAnimals
            // 
            this.buttonSearchByAnimals.BackColor = System.Drawing.SystemColors.ButtonFace;
            this.buttonSearchByAnimals.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(184)))), ((int)(((byte)(216)))), ((int)(((byte)(186)))));
            this.buttonSearchByAnimals.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonSearchByAnimals.Location = new System.Drawing.Point(110, 22);
            this.buttonSearchByAnimals.Name = "buttonSearchByAnimals";
            this.buttonSearchByAnimals.Size = new System.Drawing.Size(107, 41);
            this.buttonSearchByAnimals.TabIndex = 6;
            this.buttonSearchByAnimals.Text = "Търсене по добитък";
            this.buttonSearchByAnimals.UseVisualStyleBackColor = false;
            this.buttonSearchByAnimals.Click += new System.EventHandler(this.buttonSearchByAnimals_Click);
            // 
            // buttonSearchByStreet
            // 
            this.buttonSearchByStreet.BackColor = System.Drawing.SystemColors.ButtonFace;
            this.buttonSearchByStreet.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(184)))), ((int)(((byte)(216)))), ((int)(((byte)(186)))));
            this.buttonSearchByStreet.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonSearchByStreet.Location = new System.Drawing.Point(218, 22);
            this.buttonSearchByStreet.Name = "buttonSearchByStreet";
            this.buttonSearchByStreet.Size = new System.Drawing.Size(107, 41);
            this.buttonSearchByStreet.TabIndex = 7;
            this.buttonSearchByStreet.Text = "Търсене по улица";
            this.buttonSearchByStreet.UseVisualStyleBackColor = false;
            this.buttonSearchByStreet.Click += new System.EventHandler(this.buttonSearchByStreet_Click);
            // 
            // panelSearchByStreet
            // 
            this.panelSearchByStreet.Controls.Add(this.comboBoxStreets);
            this.panelSearchByStreet.Controls.Add(this.labelSearchByStreet);
            this.panelSearchByStreet.Location = new System.Drawing.Point(1, 62);
            this.panelSearchByStreet.Name = "panelSearchByStreet";
            this.panelSearchByStreet.Size = new System.Drawing.Size(394, 122);
            this.panelSearchByStreet.TabIndex = 8;
            // 
            // comboBoxStreets
            // 
            this.comboBoxStreets.DrawMode = System.Windows.Forms.DrawMode.OwnerDrawFixed;
            this.comboBoxStreets.FormattingEnabled = true;
            this.comboBoxStreets.Location = new System.Drawing.Point(11, 45);
            this.comboBoxStreets.Name = "comboBoxStreets";
            this.comboBoxStreets.Size = new System.Drawing.Size(163, 22);
            this.comboBoxStreets.TabIndex = 10;
            this.comboBoxStreets.DrawItem += new System.Windows.Forms.DrawItemEventHandler(this.comboBox_DrawItem);
            // 
            // labelSearchByStreet
            // 
            this.labelSearchByStreet.AutoSize = true;
            this.labelSearchByStreet.Location = new System.Drawing.Point(11, 19);
            this.labelSearchByStreet.Name = "labelSearchByStreet";
            this.labelSearchByStreet.Size = new System.Drawing.Size(98, 15);
            this.labelSearchByStreet.TabIndex = 9;
            this.labelSearchByStreet.Text = "Изберете улица";
            // 
            // AddressesFiltersForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(184)))), ((int)(((byte)(216)))), ((int)(((byte)(186)))));
            this.ClientSize = new System.Drawing.Size(396, 217);
            this.Controls.Add(this.labelTitle);
            this.Controls.Add(this.buttonSearch);
            this.Controls.Add(this.panelSearchByAnimal);
            this.Controls.Add(this.buttonSearchByInhabitant);
            this.Controls.Add(this.buttonSearchByAnimals);
            this.Controls.Add(this.buttonSearchByStreet);
            this.Controls.Add(this.panelSearchByInhabitant);
            this.Controls.Add(this.panelSearchByStreet);
            this.Font = new System.Drawing.Font("Arial", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.Name = "AddressesFiltersForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Филтри";
            this.panelSearchByInhabitant.ResumeLayout(false);
            this.panelSearchByInhabitant.PerformLayout();
            this.groupBoxPersons.ResumeLayout(false);
            this.groupBoxPersons.PerformLayout();
            this.panelSearchByAnimal.ResumeLayout(false);
            this.panelSearchByAnimal.PerformLayout();
            this.panelSearchByStreet.ResumeLayout(false);
            this.panelSearchByStreet.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button buttonSearch;
        private System.Windows.Forms.Label labelTitle;
        private System.Windows.Forms.Panel panelSearchByInhabitant;
        private System.Windows.Forms.GroupBox groupBoxPersons;
        private System.Windows.Forms.RadioButton radioButtonAll;
        private System.Windows.Forms.RadioButton radioButtonGuest;
        private System.Windows.Forms.RadioButton radioButtonResident;
        private System.Windows.Forms.TextBox textBoxLastname;
        private System.Windows.Forms.Label labelLastname;
        private System.Windows.Forms.TextBox textBoxMiddlename;
        private System.Windows.Forms.Label labelMiddlename;
        private System.Windows.Forms.TextBox textBoxFirstname;
        private System.Windows.Forms.Label labelFirstname;
        private System.Windows.Forms.Panel panelSearchByAnimal;
        private System.Windows.Forms.ComboBox comboBoxAnimals;
        private System.Windows.Forms.Label labelSearchByAnimal;
        private System.Windows.Forms.Button buttonSearchByInhabitant;
        private System.Windows.Forms.Button buttonSearchByAnimals;
        private System.Windows.Forms.Button buttonSearchByStreet;
        private System.Windows.Forms.Panel panelSearchByStreet;
        private System.Windows.Forms.ComboBox comboBoxStreets;
        private System.Windows.Forms.Label labelSearchByStreet;
    }
}