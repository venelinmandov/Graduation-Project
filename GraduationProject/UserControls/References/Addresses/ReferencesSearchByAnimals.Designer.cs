
namespace GraduationProject.UserControls.References
{
    partial class ReferencesSearchByAnimals
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
            this.panelCattle = new System.Windows.Forms.Panel();
            this.buttonShowCattle = new System.Windows.Forms.Button();
            this.labelCattle = new System.Windows.Forms.Label();
            this.comboBoxCattle = new System.Windows.Forms.ComboBox();
            this.panelDogs = new System.Windows.Forms.Panel();
            this.buttonShowDogs = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.radioButtonDogAll = new System.Windows.Forms.RadioButton();
            this.radioButtonDomesticDog = new System.Windows.Forms.RadioButton();
            this.radioButtonHuntingDog = new System.Windows.Forms.RadioButton();
            this.radioButtonGuardDog = new System.Windows.Forms.RadioButton();
            this.panelCattle.SuspendLayout();
            this.panelDogs.SuspendLayout();
            this.SuspendLayout();
            // 
            // labelTitle
            // 
            this.labelTitle.AutoSize = true;
            this.labelTitle.BackColor = System.Drawing.Color.Transparent;
            this.labelTitle.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.labelTitle.Font = new System.Drawing.Font("Arial", 21.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.labelTitle.Location = new System.Drawing.Point(354, 37);
            this.labelTitle.Name = "labelTitle";
            this.labelTitle.Size = new System.Drawing.Size(367, 33);
            this.labelTitle.TabIndex = 1;
            this.labelTitle.Text = "Селскостопански животни";
            // 
            // panelCattle
            // 
            this.panelCattle.Controls.Add(this.buttonShowCattle);
            this.panelCattle.Controls.Add(this.labelCattle);
            this.panelCattle.Controls.Add(this.comboBoxCattle);
            this.panelCattle.Location = new System.Drawing.Point(134, 108);
            this.panelCattle.Name = "panelCattle";
            this.panelCattle.Size = new System.Drawing.Size(364, 196);
            this.panelCattle.TabIndex = 2;
            // 
            // buttonShowCattle
            // 
            this.buttonShowCattle.FlatAppearance.BorderSize = 0;
            this.buttonShowCattle.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonShowCattle.Image = global::GraduationProject.Properties.Resources.magnifer_small;
            this.buttonShowCattle.Location = new System.Drawing.Point(46, 153);
            this.buttonShowCattle.Name = "buttonShowCattle";
            this.buttonShowCattle.Size = new System.Drawing.Size(87, 29);
            this.buttonShowCattle.TabIndex = 4;
            this.buttonShowCattle.Text = "Търсeне";
            this.buttonShowCattle.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.buttonShowCattle.UseVisualStyleBackColor = true;
            this.buttonShowCattle.Click += new System.EventHandler(this.buttonShowCattle_Click);
            // 
            // labelCattle
            // 
            this.labelCattle.AutoSize = true;
            this.labelCattle.BackColor = System.Drawing.Color.Transparent;
            this.labelCattle.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.labelCattle.Location = new System.Drawing.Point(62, 19);
            this.labelCattle.Name = "labelCattle";
            this.labelCattle.Size = new System.Drawing.Size(227, 18);
            this.labelCattle.TabIndex = 1;
            this.labelCattle.Text = "Избери тип домашно животно:";
            // 
            // comboBoxCattle
            // 
            this.comboBoxCattle.DrawMode = System.Windows.Forms.DrawMode.OwnerDrawFixed;
            this.comboBoxCattle.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboBoxCattle.FormattingEnabled = true;
            this.comboBoxCattle.Items.AddRange(new object[] {
            "Крави",
            "Овце",
            "Кози",
            "Коне",
            "Магарета",
            "Пернати",
            "Свине"});
            this.comboBoxCattle.Location = new System.Drawing.Point(92, 83);
            this.comboBoxCattle.Name = "comboBoxCattle";
            this.comboBoxCattle.Size = new System.Drawing.Size(180, 22);
            this.comboBoxCattle.TabIndex = 0;
            this.comboBoxCattle.DrawItem += new System.Windows.Forms.DrawItemEventHandler(this.comboBoxCattle_DrawItem);
            // 
            // panelDogs
            // 
            this.panelDogs.Controls.Add(this.buttonShowDogs);
            this.panelDogs.Controls.Add(this.label1);
            this.panelDogs.Controls.Add(this.radioButtonDogAll);
            this.panelDogs.Controls.Add(this.radioButtonDomesticDog);
            this.panelDogs.Controls.Add(this.radioButtonHuntingDog);
            this.panelDogs.Controls.Add(this.radioButtonGuardDog);
            this.panelDogs.Location = new System.Drawing.Point(582, 108);
            this.panelDogs.Name = "panelDogs";
            this.panelDogs.Size = new System.Drawing.Size(364, 196);
            this.panelDogs.TabIndex = 3;
            // 
            // buttonShowDogs
            // 
            this.buttonShowDogs.FlatAppearance.BorderSize = 0;
            this.buttonShowDogs.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonShowDogs.Image = global::GraduationProject.Properties.Resources.magnifer_small;
            this.buttonShowDogs.Location = new System.Drawing.Point(45, 153);
            this.buttonShowDogs.Name = "buttonShowDogs";
            this.buttonShowDogs.Size = new System.Drawing.Size(87, 29);
            this.buttonShowDogs.TabIndex = 5;
            this.buttonShowDogs.Text = "Търсeне";
            this.buttonShowDogs.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.buttonShowDogs.UseVisualStyleBackColor = true;
            this.buttonShowDogs.Click += new System.EventHandler(this.buttonShowDogs_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.Transparent;
            this.label1.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label1.Location = new System.Drawing.Point(88, 19);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(198, 18);
            this.label1.TabIndex = 2;
            this.label1.Text = "Избери тип домашно куче:";
            // 
            // radioButtonDogAll
            // 
            this.radioButtonDogAll.AutoSize = true;
            this.radioButtonDogAll.BackColor = System.Drawing.Color.Transparent;
            this.radioButtonDogAll.Location = new System.Drawing.Point(117, 122);
            this.radioButtonDogAll.Name = "radioButtonDogAll";
            this.radioButtonDogAll.Size = new System.Drawing.Size(65, 19);
            this.radioButtonDogAll.TabIndex = 3;
            this.radioButtonDogAll.TabStop = true;
            this.radioButtonDogAll.Text = "Всички";
            this.radioButtonDogAll.UseVisualStyleBackColor = false;
            // 
            // radioButtonDomesticDog
            // 
            this.radioButtonDomesticDog.AutoSize = true;
            this.radioButtonDomesticDog.BackColor = System.Drawing.Color.Transparent;
            this.radioButtonDomesticDog.Location = new System.Drawing.Point(117, 97);
            this.radioButtonDomesticDog.Name = "radioButtonDomesticDog";
            this.radioButtonDomesticDog.Size = new System.Drawing.Size(135, 19);
            this.radioButtonDomesticDog.TabIndex = 2;
            this.radioButtonDomesticDog.TabStop = true;
            this.radioButtonDomesticDog.Text = "Домашен любимец";
            this.radioButtonDomesticDog.UseVisualStyleBackColor = false;
            // 
            // radioButtonHuntingDog
            // 
            this.radioButtonHuntingDog.AutoSize = true;
            this.radioButtonHuntingDog.BackColor = System.Drawing.Color.Transparent;
            this.radioButtonHuntingDog.Location = new System.Drawing.Point(117, 72);
            this.radioButtonHuntingDog.Name = "radioButtonHuntingDog";
            this.radioButtonHuntingDog.Size = new System.Drawing.Size(122, 19);
            this.radioButtonHuntingDog.TabIndex = 1;
            this.radioButtonHuntingDog.TabStop = true;
            this.radioButtonHuntingDog.Text = "Ловджийско куче";
            this.radioButtonHuntingDog.UseVisualStyleBackColor = false;
            // 
            // radioButtonGuardDog
            // 
            this.radioButtonGuardDog.AutoSize = true;
            this.radioButtonGuardDog.BackColor = System.Drawing.Color.Transparent;
            this.radioButtonGuardDog.Location = new System.Drawing.Point(117, 47);
            this.radioButtonGuardDog.Name = "radioButtonGuardDog";
            this.radioButtonGuardDog.Size = new System.Drawing.Size(86, 19);
            this.radioButtonGuardDog.TabIndex = 0;
            this.radioButtonGuardDog.TabStop = true;
            this.radioButtonGuardDog.Text = "Куче пазач";
            this.radioButtonGuardDog.UseVisualStyleBackColor = false;
            // 
            // ReferencesSearchByAnimals
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(96F, 96F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Dpi;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(170)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.Controls.Add(this.panelDogs);
            this.Controls.Add(this.panelCattle);
            this.Controls.Add(this.labelTitle);
            this.Font = new System.Drawing.Font("Arial", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.Name = "ReferencesSearchByAnimals";
            this.Size = new System.Drawing.Size(1081, 329);
            this.panelCattle.ResumeLayout(false);
            this.panelCattle.PerformLayout();
            this.panelDogs.ResumeLayout(false);
            this.panelDogs.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label labelTitle;
        private System.Windows.Forms.Panel panelCattle;
        private System.Windows.Forms.Panel panelDogs;
        private System.Windows.Forms.Label labelCattle;
        private System.Windows.Forms.ComboBox comboBoxCattle;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.RadioButton radioButtonDogAll;
        private System.Windows.Forms.RadioButton radioButtonDomesticDog;
        private System.Windows.Forms.RadioButton radioButtonHuntingDog;
        private System.Windows.Forms.RadioButton radioButtonGuardDog;
        private System.Windows.Forms.Button buttonShowCattle;
        private System.Windows.Forms.Button buttonShowDogs;
    }
}
