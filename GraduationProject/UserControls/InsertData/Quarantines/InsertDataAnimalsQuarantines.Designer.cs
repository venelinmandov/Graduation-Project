
namespace GraduationProject.UserControls.InsertData.Quarantines
{
    partial class InsertDataAnimalsQuarantines
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
            this.panelShowQuarantines = new System.Windows.Forms.Panel();
            this.listBoxQarantines = new GraduationProject.UserControls.ListBoxUserControl();
            this.buttonDeleteQuarantine = new System.Windows.Forms.Button();
            this.buttonShowEditQuarantine = new System.Windows.Forms.Button();
            this.buttonShowInsertQuarantine = new System.Windows.Forms.Button();
            this.panelEditCreateQurantine = new System.Windows.Forms.Panel();
            this.labelAddEditQuarantineTitleLabel = new System.Windows.Forms.Label();
            this.buttonCancel = new System.Windows.Forms.Button();
            this.buttonSave = new System.Windows.Forms.Button();
            this.dateTimePickerTo = new System.Windows.Forms.DateTimePicker();
            this.dateTimePickerFrom = new System.Windows.Forms.DateTimePicker();
            this.labelTo = new System.Windows.Forms.Label();
            this.labelFrom = new System.Windows.Forms.Label();
            this.comboBoxDisease = new System.Windows.Forms.ComboBox();
            this.labelDiesase = new System.Windows.Forms.Label();
            this.labelAnimalsInPropertyNumber = new System.Windows.Forms.Label();
            this.numericUpDownNumber = new System.Windows.Forms.NumericUpDown();
            this.labelNumber = new System.Windows.Forms.Label();
            this.comboBoxAnimal = new System.Windows.Forms.ComboBox();
            this.labelAnimal = new System.Windows.Forms.Label();
            this.labelAddress = new System.Windows.Forms.Label();
            this.panelShowQuarantines.SuspendLayout();
            this.panelEditCreateQurantine.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDownNumber)).BeginInit();
            this.SuspendLayout();
            // 
            // labelTitle
            // 
            this.labelTitle.BackColor = System.Drawing.Color.Transparent;
            this.labelTitle.Font = new System.Drawing.Font("Arial", 21.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.labelTitle.Location = new System.Drawing.Point(209, 14);
            this.labelTitle.Name = "labelTitle";
            this.labelTitle.Size = new System.Drawing.Size(663, 33);
            this.labelTitle.TabIndex = 28;
            this.labelTitle.Text = "Карантини на селскостопански животни";
            this.labelTitle.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // panelShowQuarantines
            // 
            this.panelShowQuarantines.Controls.Add(this.listBoxQarantines);
            this.panelShowQuarantines.Controls.Add(this.buttonDeleteQuarantine);
            this.panelShowQuarantines.Controls.Add(this.buttonShowEditQuarantine);
            this.panelShowQuarantines.Controls.Add(this.buttonShowInsertQuarantine);
            this.panelShowQuarantines.Location = new System.Drawing.Point(163, 90);
            this.panelShowQuarantines.Name = "panelShowQuarantines";
            this.panelShowQuarantines.Size = new System.Drawing.Size(759, 222);
            this.panelShowQuarantines.TabIndex = 29;
            // 
            // listBoxQarantines
            // 
            this.listBoxQarantines.AutoScroll = true;
            this.listBoxQarantines.Font = new System.Drawing.Font("Arial", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.listBoxQarantines.ItemBorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(170)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.listBoxQarantines.ItemsColor = System.Drawing.Color.FromArgb(((int)(((byte)(170)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.listBoxQarantines.ItemTextAlignment = System.Drawing.ContentAlignment.MiddleLeft;
            this.listBoxQarantines.Location = new System.Drawing.Point(36, 31);
            this.listBoxQarantines.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.listBoxQarantines.Name = "listBoxQarantines";
            this.listBoxQarantines.SelectedIndex = -1;
            this.listBoxQarantines.SelectedItemColor = System.Drawing.Color.FromArgb(((int)(((byte)(70)))), ((int)(((byte)(90)))), ((int)(((byte)(30)))));
            this.listBoxQarantines.SelectedItemForeColor = System.Drawing.SystemColors.Control;
            this.listBoxQarantines.Size = new System.Drawing.Size(690, 145);
            this.listBoxQarantines.TabIndex = 17;
            // 
            // buttonDeleteQuarantine
            // 
            this.buttonDeleteQuarantine.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(130)))), ((int)(((byte)(80)))), ((int)(((byte)(10)))));
            this.buttonDeleteQuarantine.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonDeleteQuarantine.ForeColor = System.Drawing.SystemColors.Control;
            this.buttonDeleteQuarantine.Location = new System.Drawing.Point(470, 187);
            this.buttonDeleteQuarantine.Name = "buttonDeleteQuarantine";
            this.buttonDeleteQuarantine.Size = new System.Drawing.Size(170, 25);
            this.buttonDeleteQuarantine.TabIndex = 24;
            this.buttonDeleteQuarantine.Text = "Изтрий карантината";
            this.buttonDeleteQuarantine.UseVisualStyleBackColor = false;
            this.buttonDeleteQuarantine.Click += new System.EventHandler(this.buttonDeleteQuarantine_Click);
            // 
            // buttonShowEditQuarantine
            // 
            this.buttonShowEditQuarantine.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(130)))), ((int)(((byte)(80)))), ((int)(((byte)(10)))));
            this.buttonShowEditQuarantine.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonShowEditQuarantine.ForeColor = System.Drawing.SystemColors.Control;
            this.buttonShowEditQuarantine.Location = new System.Drawing.Point(294, 187);
            this.buttonShowEditQuarantine.Name = "buttonShowEditQuarantine";
            this.buttonShowEditQuarantine.Size = new System.Drawing.Size(170, 25);
            this.buttonShowEditQuarantine.TabIndex = 23;
            this.buttonShowEditQuarantine.Text = "Редактирай карантината";
            this.buttonShowEditQuarantine.UseVisualStyleBackColor = false;
            this.buttonShowEditQuarantine.Click += new System.EventHandler(this.buttonShowEditQuarantine_Click);
            // 
            // buttonShowInsertQuarantine
            // 
            this.buttonShowInsertQuarantine.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(130)))), ((int)(((byte)(80)))), ((int)(((byte)(10)))));
            this.buttonShowInsertQuarantine.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonShowInsertQuarantine.ForeColor = System.Drawing.SystemColors.Control;
            this.buttonShowInsertQuarantine.Location = new System.Drawing.Point(118, 187);
            this.buttonShowInsertQuarantine.Name = "buttonShowInsertQuarantine";
            this.buttonShowInsertQuarantine.Size = new System.Drawing.Size(170, 25);
            this.buttonShowInsertQuarantine.TabIndex = 22;
            this.buttonShowInsertQuarantine.Text = "Добави карантина";
            this.buttonShowInsertQuarantine.UseVisualStyleBackColor = false;
            this.buttonShowInsertQuarantine.Click += new System.EventHandler(this.buttonShowInsertQuarantine_Click);
            // 
            // panelEditCreateQurantine
            // 
            this.panelEditCreateQurantine.Controls.Add(this.labelAddEditQuarantineTitleLabel);
            this.panelEditCreateQurantine.Controls.Add(this.buttonCancel);
            this.panelEditCreateQurantine.Controls.Add(this.buttonSave);
            this.panelEditCreateQurantine.Controls.Add(this.dateTimePickerTo);
            this.panelEditCreateQurantine.Controls.Add(this.dateTimePickerFrom);
            this.panelEditCreateQurantine.Controls.Add(this.labelTo);
            this.panelEditCreateQurantine.Controls.Add(this.labelFrom);
            this.panelEditCreateQurantine.Controls.Add(this.comboBoxDisease);
            this.panelEditCreateQurantine.Controls.Add(this.labelDiesase);
            this.panelEditCreateQurantine.Controls.Add(this.labelAnimalsInPropertyNumber);
            this.panelEditCreateQurantine.Controls.Add(this.numericUpDownNumber);
            this.panelEditCreateQurantine.Controls.Add(this.labelNumber);
            this.panelEditCreateQurantine.Controls.Add(this.comboBoxAnimal);
            this.panelEditCreateQurantine.Controls.Add(this.labelAnimal);
            this.panelEditCreateQurantine.Location = new System.Drawing.Point(163, 90);
            this.panelEditCreateQurantine.Name = "panelEditCreateQurantine";
            this.panelEditCreateQurantine.Size = new System.Drawing.Size(759, 222);
            this.panelEditCreateQurantine.TabIndex = 30;
            // 
            // labelAddEditQuarantineTitleLabel
            // 
            this.labelAddEditQuarantineTitleLabel.BackColor = System.Drawing.Color.Transparent;
            this.labelAddEditQuarantineTitleLabel.Font = new System.Drawing.Font("Arial", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.labelAddEditQuarantineTitleLabel.Location = new System.Drawing.Point(36, 10);
            this.labelAddEditQuarantineTitleLabel.Name = "labelAddEditQuarantineTitleLabel";
            this.labelAddEditQuarantineTitleLabel.Size = new System.Drawing.Size(663, 33);
            this.labelAddEditQuarantineTitleLabel.TabIndex = 47;
            this.labelAddEditQuarantineTitleLabel.Text = "... на карантина";
            this.labelAddEditQuarantineTitleLabel.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // buttonCancel
            // 
            this.buttonCancel.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(130)))), ((int)(((byte)(80)))), ((int)(((byte)(10)))));
            this.buttonCancel.FlatAppearance.BorderSize = 0;
            this.buttonCancel.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonCancel.ForeColor = System.Drawing.SystemColors.Control;
            this.buttonCancel.Location = new System.Drawing.Point(201, 182);
            this.buttonCancel.Name = "buttonCancel";
            this.buttonCancel.Size = new System.Drawing.Size(87, 29);
            this.buttonCancel.TabIndex = 46;
            this.buttonCancel.Text = "Отказ";
            this.buttonCancel.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.buttonCancel.UseVisualStyleBackColor = false;
            this.buttonCancel.Click += new System.EventHandler(this.buttonCancel_Click);
            // 
            // buttonSave
            // 
            this.buttonSave.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(130)))), ((int)(((byte)(80)))), ((int)(((byte)(10)))));
            this.buttonSave.FlatAppearance.BorderSize = 0;
            this.buttonSave.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonSave.ForeColor = System.Drawing.SystemColors.Control;
            this.buttonSave.Image = global::GraduationProject.Properties.Resources.saveIcon_white;
            this.buttonSave.Location = new System.Drawing.Point(85, 182);
            this.buttonSave.Name = "buttonSave";
            this.buttonSave.Size = new System.Drawing.Size(87, 29);
            this.buttonSave.TabIndex = 45;
            this.buttonSave.Text = "Запис";
            this.buttonSave.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.buttonSave.UseVisualStyleBackColor = false;
            this.buttonSave.Click += new System.EventHandler(this.buttonSave_Click);
            // 
            // dateTimePickerTo
            // 
            this.dateTimePickerTo.Location = new System.Drawing.Point(512, 98);
            this.dateTimePickerTo.Name = "dateTimePickerTo";
            this.dateTimePickerTo.Size = new System.Drawing.Size(200, 21);
            this.dateTimePickerTo.TabIndex = 10;
            // 
            // dateTimePickerFrom
            // 
            this.dateTimePickerFrom.Location = new System.Drawing.Point(512, 71);
            this.dateTimePickerFrom.Name = "dateTimePickerFrom";
            this.dateTimePickerFrom.Size = new System.Drawing.Size(200, 21);
            this.dateTimePickerFrom.TabIndex = 9;
            // 
            // labelTo
            // 
            this.labelTo.AutoSize = true;
            this.labelTo.BackColor = System.Drawing.Color.Transparent;
            this.labelTo.Location = new System.Drawing.Point(481, 103);
            this.labelTo.Name = "labelTo";
            this.labelTo.Size = new System.Drawing.Size(24, 15);
            this.labelTo.TabIndex = 8;
            this.labelTo.Text = "до:";
            // 
            // labelFrom
            // 
            this.labelFrom.AutoSize = true;
            this.labelFrom.BackColor = System.Drawing.Color.Transparent;
            this.labelFrom.Location = new System.Drawing.Point(481, 76);
            this.labelFrom.Name = "labelFrom";
            this.labelFrom.Size = new System.Drawing.Size(22, 15);
            this.labelFrom.TabIndex = 7;
            this.labelFrom.Text = "от:";
            // 
            // comboBoxDisease
            // 
            this.comboBoxDisease.DrawMode = System.Windows.Forms.DrawMode.OwnerDrawFixed;
            this.comboBoxDisease.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboBoxDisease.FormattingEnabled = true;
            this.comboBoxDisease.Location = new System.Drawing.Point(231, 98);
            this.comboBoxDisease.Name = "comboBoxDisease";
            this.comboBoxDisease.Size = new System.Drawing.Size(217, 22);
            this.comboBoxDisease.TabIndex = 6;
            // 
            // labelDiesase
            // 
            this.labelDiesase.AutoSize = true;
            this.labelDiesase.BackColor = System.Drawing.Color.Transparent;
            this.labelDiesase.Location = new System.Drawing.Point(175, 101);
            this.labelDiesase.Name = "labelDiesase";
            this.labelDiesase.Size = new System.Drawing.Size(50, 15);
            this.labelDiesase.TabIndex = 5;
            this.labelDiesase.Text = "Болест:";
            // 
            // labelAnimalsInPropertyNumber
            // 
            this.labelAnimalsInPropertyNumber.AutoSize = true;
            this.labelAnimalsInPropertyNumber.BackColor = System.Drawing.Color.Transparent;
            this.labelAnimalsInPropertyNumber.Location = new System.Drawing.Point(301, 131);
            this.labelAnimalsInPropertyNumber.Name = "labelAnimalsInPropertyNumber";
            this.labelAnimalsInPropertyNumber.Size = new System.Drawing.Size(31, 15);
            this.labelAnimalsInPropertyNumber.TabIndex = 4;
            this.labelAnimalsInPropertyNumber.Text = "от ...";
            // 
            // numericUpDownNumber
            // 
            this.numericUpDownNumber.Location = new System.Drawing.Point(231, 129);
            this.numericUpDownNumber.Name = "numericUpDownNumber";
            this.numericUpDownNumber.Size = new System.Drawing.Size(64, 21);
            this.numericUpDownNumber.TabIndex = 3;
            // 
            // labelNumber
            // 
            this.labelNumber.AutoSize = true;
            this.labelNumber.BackColor = System.Drawing.Color.Transparent;
            this.labelNumber.Location = new System.Drawing.Point(129, 129);
            this.labelNumber.Name = "labelNumber";
            this.labelNumber.Size = new System.Drawing.Size(96, 15);
            this.labelNumber.TabIndex = 2;
            this.labelNumber.Text = "Брой заразени:";
            // 
            // comboBoxAnimal
            // 
            this.comboBoxAnimal.DrawMode = System.Windows.Forms.DrawMode.OwnerDrawFixed;
            this.comboBoxAnimal.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboBoxAnimal.FormattingEnabled = true;
            this.comboBoxAnimal.Location = new System.Drawing.Point(231, 69);
            this.comboBoxAnimal.Name = "comboBoxAnimal";
            this.comboBoxAnimal.Size = new System.Drawing.Size(217, 22);
            this.comboBoxAnimal.TabIndex = 1;
            this.comboBoxAnimal.SelectedIndexChanged += new System.EventHandler(this.comboBoxAnimal_SelectedIndexChanged);
            // 
            // labelAnimal
            // 
            this.labelAnimal.AutoSize = true;
            this.labelAnimal.BackColor = System.Drawing.Color.Transparent;
            this.labelAnimal.Location = new System.Drawing.Point(44, 71);
            this.labelAnimal.Name = "labelAnimal";
            this.labelAnimal.Size = new System.Drawing.Size(181, 15);
            this.labelAnimal.TabIndex = 0;
            this.labelAnimal.Text = "Тип селскостопанско животно:";
            // 
            // labelAddress
            // 
            this.labelAddress.BackColor = System.Drawing.Color.Transparent;
            this.labelAddress.Font = new System.Drawing.Font("Arial", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.labelAddress.Location = new System.Drawing.Point(209, 47);
            this.labelAddress.Name = "labelAddress";
            this.labelAddress.Size = new System.Drawing.Size(663, 33);
            this.labelAddress.TabIndex = 46;
            this.labelAddress.Text = "адрес";
            this.labelAddress.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // InsertDataAnimalsQuarantines
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(96F, 96F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Dpi;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(170)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.Controls.Add(this.panelShowQuarantines);
            this.Controls.Add(this.panelEditCreateQurantine);
            this.Controls.Add(this.labelAddress);
            this.Controls.Add(this.labelTitle);
            this.Font = new System.Drawing.Font("Arial", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.Name = "InsertDataAnimalsQuarantines";
            this.Size = new System.Drawing.Size(1081, 329);
            this.panelShowQuarantines.ResumeLayout(false);
            this.panelEditCreateQurantine.ResumeLayout(false);
            this.panelEditCreateQurantine.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDownNumber)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        protected System.Windows.Forms.Label labelTitle;
        private System.Windows.Forms.Panel panelShowQuarantines;
        private ListBoxUserControl listBoxQarantines;
        private System.Windows.Forms.Button buttonDeleteQuarantine;
        private System.Windows.Forms.Button buttonShowEditQuarantine;
        private System.Windows.Forms.Button buttonShowInsertQuarantine;
        private System.Windows.Forms.Panel panelEditCreateQurantine;
        private System.Windows.Forms.Label labelTo;
        private System.Windows.Forms.Label labelFrom;
        private System.Windows.Forms.ComboBox comboBoxDisease;
        private System.Windows.Forms.Label labelDiesase;
        private System.Windows.Forms.Label labelAnimalsInPropertyNumber;
        private System.Windows.Forms.NumericUpDown numericUpDownNumber;
        private System.Windows.Forms.Label labelNumber;
        private System.Windows.Forms.ComboBox comboBoxAnimal;
        private System.Windows.Forms.Label labelAnimal;
        private System.Windows.Forms.DateTimePicker dateTimePickerTo;
        private System.Windows.Forms.DateTimePicker dateTimePickerFrom;
        private System.Windows.Forms.Button buttonCancel;
        private System.Windows.Forms.Button buttonSave;
        protected System.Windows.Forms.Label labelAddEditQuarantineTitleLabel;
        protected System.Windows.Forms.Label labelAddress;
    }
}
