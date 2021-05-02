
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
            this.button1 = new System.Windows.Forms.Button();
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
            this.buttonSearch.Location = new System.Drawing.Point(12, 200);
            this.buttonSearch.Name = "buttonSearch";
            this.buttonSearch.Size = new System.Drawing.Size(75, 23);
            this.buttonSearch.TabIndex = 0;
            this.buttonSearch.Text = "Търсене";
            this.buttonSearch.UseVisualStyleBackColor = true;
            this.buttonSearch.Click += new System.EventHandler(this.buttonSearch_Click);
            // 
            // labelTitle
            // 
            this.labelTitle.AutoSize = true;
            this.labelTitle.Location = new System.Drawing.Point(1, 4);
            this.labelTitle.Name = "labelTitle";
            this.labelTitle.Size = new System.Drawing.Size(174, 15);
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
            this.groupBoxPersons.Location = new System.Drawing.Point(244, 19);
            this.groupBoxPersons.Name = "groupBoxPersons";
            this.groupBoxPersons.Size = new System.Drawing.Size(125, 81);
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
            this.radioButtonGuest.Size = new System.Drawing.Size(118, 19);
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
            this.radioButtonResident.Size = new System.Drawing.Size(61, 19);
            this.radioButtonResident.TabIndex = 0;
            this.radioButtonResident.TabStop = true;
            this.radioButtonResident.Text = "Жител";
            this.radioButtonResident.UseVisualStyleBackColor = true;
            // 
            // textBoxLastname
            // 
            this.textBoxLastname.Location = new System.Drawing.Point(73, 85);
            this.textBoxLastname.Name = "textBoxLastname";
            this.textBoxLastname.Size = new System.Drawing.Size(154, 23);
            this.textBoxLastname.TabIndex = 5;
            // 
            // labelLastname
            // 
            this.labelLastname.AutoSize = true;
            this.labelLastname.Location = new System.Drawing.Point(11, 93);
            this.labelLastname.Name = "labelLastname";
            this.labelLastname.Size = new System.Drawing.Size(58, 15);
            this.labelLastname.TabIndex = 4;
            this.labelLastname.Text = "Фамилия";
            // 
            // textBoxMiddlename
            // 
            this.textBoxMiddlename.Location = new System.Drawing.Point(73, 56);
            this.textBoxMiddlename.Name = "textBoxMiddlename";
            this.textBoxMiddlename.Size = new System.Drawing.Size(154, 23);
            this.textBoxMiddlename.TabIndex = 3;
            // 
            // labelMiddlename
            // 
            this.labelMiddlename.AutoSize = true;
            this.labelMiddlename.Location = new System.Drawing.Point(11, 64);
            this.labelMiddlename.Name = "labelMiddlename";
            this.labelMiddlename.Size = new System.Drawing.Size(56, 15);
            this.labelMiddlename.TabIndex = 2;
            this.labelMiddlename.Text = "Презиме";
            // 
            // textBoxFirstname
            // 
            this.textBoxFirstname.Location = new System.Drawing.Point(73, 27);
            this.textBoxFirstname.Name = "textBoxFirstname";
            this.textBoxFirstname.Size = new System.Drawing.Size(154, 23);
            this.textBoxFirstname.TabIndex = 1;
            // 
            // labelFirstname
            // 
            this.labelFirstname.AutoSize = true;
            this.labelFirstname.Location = new System.Drawing.Point(36, 35);
            this.labelFirstname.Name = "labelFirstname";
            this.labelFirstname.Size = new System.Drawing.Size(31, 15);
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
            this.comboBoxAnimals.FormattingEnabled = true;
            this.comboBoxAnimals.Items.AddRange(new object[] {
            "Крави",
            "Овце",
            "Кози",
            "Коне",
            "Магарета",
            "Пернати"});
            this.comboBoxAnimals.Location = new System.Drawing.Point(11, 45);
            this.comboBoxAnimals.Name = "comboBoxAnimals";
            this.comboBoxAnimals.Size = new System.Drawing.Size(163, 23);
            this.comboBoxAnimals.TabIndex = 8;
            // 
            // labelSearchByAnimal
            // 
            this.labelSearchByAnimal.AutoSize = true;
            this.labelSearchByAnimal.Location = new System.Drawing.Point(11, 19);
            this.labelSearchByAnimal.Name = "labelSearchByAnimal";
            this.labelSearchByAnimal.Size = new System.Drawing.Size(106, 15);
            this.labelSearchByAnimal.TabIndex = 7;
            this.labelSearchByAnimal.Text = "Изберете добитък";
            // 
            // buttonSearchByInhabitant
            // 
            this.buttonSearchByInhabitant.Location = new System.Drawing.Point(1, 24);
            this.buttonSearchByInhabitant.Name = "buttonSearchByInhabitant";
            this.buttonSearchByInhabitant.Size = new System.Drawing.Size(96, 40);
            this.buttonSearchByInhabitant.TabIndex = 5;
            this.buttonSearchByInhabitant.Text = "Търсене по обитател";
            this.buttonSearchByInhabitant.UseVisualStyleBackColor = true;
            this.buttonSearchByInhabitant.Click += new System.EventHandler(this.buttonSearchByInhabitant_Click);
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(95, 24);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(96, 40);
            this.button1.TabIndex = 6;
            this.button1.Text = "Търсене по добитък";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // buttonSearchByStreet
            // 
            this.buttonSearchByStreet.Location = new System.Drawing.Point(189, 24);
            this.buttonSearchByStreet.Name = "buttonSearchByStreet";
            this.buttonSearchByStreet.Size = new System.Drawing.Size(96, 40);
            this.buttonSearchByStreet.TabIndex = 7;
            this.buttonSearchByStreet.Text = "Търсене по улица";
            this.buttonSearchByStreet.UseVisualStyleBackColor = true;
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
            this.comboBoxStreets.FormattingEnabled = true;
            this.comboBoxStreets.Location = new System.Drawing.Point(11, 45);
            this.comboBoxStreets.Name = "comboBoxStreets";
            this.comboBoxStreets.Size = new System.Drawing.Size(163, 23);
            this.comboBoxStreets.TabIndex = 10;
            // 
            // labelSearchByStreet
            // 
            this.labelSearchByStreet.AutoSize = true;
            this.labelSearchByStreet.Location = new System.Drawing.Point(11, 19);
            this.labelSearchByStreet.Name = "labelSearchByStreet";
            this.labelSearchByStreet.Size = new System.Drawing.Size(94, 15);
            this.labelSearchByStreet.TabIndex = 9;
            this.labelSearchByStreet.Text = "Изберете улица";
            // 
            // AddressesFiltersForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(396, 234);
            this.Controls.Add(this.labelTitle);
            this.Controls.Add(this.buttonSearch);
            this.Controls.Add(this.buttonSearchByInhabitant);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.buttonSearchByStreet);
            this.Controls.Add(this.panelSearchByInhabitant);
            this.Controls.Add(this.panelSearchByStreet);
            this.Controls.Add(this.panelSearchByAnimal);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.Name = "AddressesFiltersForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "AddressesFiltersForm";
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
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button buttonSearchByStreet;
        private System.Windows.Forms.Panel panelSearchByStreet;
        private System.Windows.Forms.ComboBox comboBoxStreets;
        private System.Windows.Forms.Label labelSearchByStreet;
    }
}