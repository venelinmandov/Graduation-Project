
namespace GraduationProject.UserControls.InsertData.Quarantines
{
    partial class InsertDataInhabitantsQuarantines
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
            this.panelShowQuarantines = new System.Windows.Forms.Panel();
            this.listBoxQarantines = new GraduationProject.UserControls.ListBoxUserControl();
            this.buttonDeleteQuarantine = new System.Windows.Forms.Button();
            this.buttonShowEditQuarantine = new System.Windows.Forms.Button();
            this.buttonShowInsertQuarantine = new System.Windows.Forms.Button();
            this.labelTitle = new System.Windows.Forms.Label();
            this.panelAddEditQuarantine = new System.Windows.Forms.Panel();
            this.buttonCancel = new System.Windows.Forms.Button();
            this.groupBoxDisease = new System.Windows.Forms.GroupBox();
            this.comboBoxDisease = new System.Windows.Forms.ComboBox();
            this.radioButtonContact = new System.Windows.Forms.RadioButton();
            this.radioButtonIll = new System.Windows.Forms.RadioButton();
            this.groupBoxInhabitant = new System.Windows.Forms.GroupBox();
            this.comboBoxInhabitant = new System.Windows.Forms.ComboBox();
            this.radioButtonResident = new System.Windows.Forms.RadioButton();
            this.radioButtonGuest = new System.Windows.Forms.RadioButton();
            this.labelAddEditQuarantineTitlelabel = new System.Windows.Forms.Label();
            this.buttonSave = new System.Windows.Forms.Button();
            this.labelTo = new System.Windows.Forms.Label();
            this.labelFrom = new System.Windows.Forms.Label();
            this.dateTimePickerTo = new System.Windows.Forms.DateTimePicker();
            this.dateTimePickerFrom = new System.Windows.Forms.DateTimePicker();
            this.labelAddress = new System.Windows.Forms.Label();
            this.panelShowQuarantines.SuspendLayout();
            this.panelAddEditQuarantine.SuspendLayout();
            this.groupBoxDisease.SuspendLayout();
            this.groupBoxInhabitant.SuspendLayout();
            this.SuspendLayout();
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
            this.panelShowQuarantines.TabIndex = 26;
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
            // labelTitle
            // 
            this.labelTitle.BackColor = System.Drawing.Color.Transparent;
            this.labelTitle.Font = new System.Drawing.Font("Arial", 21.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.labelTitle.Location = new System.Drawing.Point(209, 14);
            this.labelTitle.Name = "labelTitle";
            this.labelTitle.Size = new System.Drawing.Size(663, 33);
            this.labelTitle.TabIndex = 27;
            this.labelTitle.Text = "Карантини на обитатели";
            this.labelTitle.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // panelAddEditQuarantine
            // 
            this.panelAddEditQuarantine.Controls.Add(this.buttonCancel);
            this.panelAddEditQuarantine.Controls.Add(this.groupBoxDisease);
            this.panelAddEditQuarantine.Controls.Add(this.groupBoxInhabitant);
            this.panelAddEditQuarantine.Controls.Add(this.labelAddEditQuarantineTitlelabel);
            this.panelAddEditQuarantine.Controls.Add(this.buttonSave);
            this.panelAddEditQuarantine.Controls.Add(this.labelTo);
            this.panelAddEditQuarantine.Controls.Add(this.labelFrom);
            this.panelAddEditQuarantine.Controls.Add(this.dateTimePickerTo);
            this.panelAddEditQuarantine.Controls.Add(this.dateTimePickerFrom);
            this.panelAddEditQuarantine.Location = new System.Drawing.Point(163, 90);
            this.panelAddEditQuarantine.Name = "panelAddEditQuarantine";
            this.panelAddEditQuarantine.Size = new System.Drawing.Size(759, 222);
            this.panelAddEditQuarantine.TabIndex = 27;
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
            this.buttonCancel.TabIndex = 44;
            this.buttonCancel.Text = "Отказ";
            this.buttonCancel.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.buttonCancel.UseVisualStyleBackColor = false;
            this.buttonCancel.Click += new System.EventHandler(this.buttonCancel_Click);
            // 
            // groupBoxDisease
            // 
            this.groupBoxDisease.BackColor = System.Drawing.Color.Transparent;
            this.groupBoxDisease.Controls.Add(this.comboBoxDisease);
            this.groupBoxDisease.Controls.Add(this.radioButtonContact);
            this.groupBoxDisease.Controls.Add(this.radioButtonIll);
            this.groupBoxDisease.Location = new System.Drawing.Point(405, 55);
            this.groupBoxDisease.Name = "groupBoxDisease";
            this.groupBoxDisease.Size = new System.Drawing.Size(266, 75);
            this.groupBoxDisease.TabIndex = 43;
            this.groupBoxDisease.TabStop = false;
            this.groupBoxDisease.Text = "Заболяване:";
            // 
            // comboBoxDisease
            // 
            this.comboBoxDisease.DrawMode = System.Windows.Forms.DrawMode.OwnerDrawFixed;
            this.comboBoxDisease.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboBoxDisease.FormattingEnabled = true;
            this.comboBoxDisease.Location = new System.Drawing.Point(6, 20);
            this.comboBoxDisease.Name = "comboBoxDisease";
            this.comboBoxDisease.Size = new System.Drawing.Size(255, 22);
            this.comboBoxDisease.TabIndex = 33;
            // 
            // radioButtonContact
            // 
            this.radioButtonContact.AutoSize = true;
            this.radioButtonContact.BackColor = System.Drawing.Color.Transparent;
            this.radioButtonContact.Location = new System.Drawing.Point(96, 48);
            this.radioButtonContact.Name = "radioButtonContact";
            this.radioButtonContact.Size = new System.Drawing.Size(82, 19);
            this.radioButtonContact.TabIndex = 41;
            this.radioButtonContact.TabStop = true;
            this.radioButtonContact.Text = "контактен";
            this.radioButtonContact.UseVisualStyleBackColor = false;
            // 
            // radioButtonIll
            // 
            this.radioButtonIll.AutoSize = true;
            this.radioButtonIll.BackColor = System.Drawing.Color.Transparent;
            this.radioButtonIll.Location = new System.Drawing.Point(6, 48);
            this.radioButtonIll.Name = "radioButtonIll";
            this.radioButtonIll.Size = new System.Drawing.Size(78, 19);
            this.radioButtonIll.TabIndex = 40;
            this.radioButtonIll.TabStop = true;
            this.radioButtonIll.Text = "боледува";
            this.radioButtonIll.UseVisualStyleBackColor = false;
            // 
            // groupBoxInhabitant
            // 
            this.groupBoxInhabitant.BackColor = System.Drawing.Color.Transparent;
            this.groupBoxInhabitant.Controls.Add(this.comboBoxInhabitant);
            this.groupBoxInhabitant.Controls.Add(this.radioButtonResident);
            this.groupBoxInhabitant.Controls.Add(this.radioButtonGuest);
            this.groupBoxInhabitant.Location = new System.Drawing.Point(85, 50);
            this.groupBoxInhabitant.Name = "groupBoxInhabitant";
            this.groupBoxInhabitant.Size = new System.Drawing.Size(266, 75);
            this.groupBoxInhabitant.TabIndex = 42;
            this.groupBoxInhabitant.TabStop = false;
            this.groupBoxInhabitant.Text = "Обитател:";
            // 
            // comboBoxInhabitant
            // 
            this.comboBoxInhabitant.DrawMode = System.Windows.Forms.DrawMode.OwnerDrawFixed;
            this.comboBoxInhabitant.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboBoxInhabitant.FormattingEnabled = true;
            this.comboBoxInhabitant.Location = new System.Drawing.Point(6, 20);
            this.comboBoxInhabitant.Name = "comboBoxInhabitant";
            this.comboBoxInhabitant.Size = new System.Drawing.Size(255, 22);
            this.comboBoxInhabitant.TabIndex = 31;
            // 
            // radioButtonResident
            // 
            this.radioButtonResident.AutoSize = true;
            this.radioButtonResident.BackColor = System.Drawing.Color.Transparent;
            this.radioButtonResident.Location = new System.Drawing.Point(6, 48);
            this.radioButtonResident.Name = "radioButtonResident";
            this.radioButtonResident.Size = new System.Drawing.Size(144, 19);
            this.radioButtonResident.TabIndex = 29;
            this.radioButtonResident.TabStop = true;
            this.radioButtonResident.Text = "член на семейството";
            this.radioButtonResident.UseVisualStyleBackColor = false;
            this.radioButtonResident.CheckedChanged += new System.EventHandler(this.radioButton_CheckedChanged);
            // 
            // radioButtonGuest
            // 
            this.radioButtonGuest.AutoSize = true;
            this.radioButtonGuest.BackColor = System.Drawing.Color.Transparent;
            this.radioButtonGuest.Location = new System.Drawing.Point(162, 48);
            this.radioButtonGuest.Name = "radioButtonGuest";
            this.radioButtonGuest.Size = new System.Drawing.Size(47, 19);
            this.radioButtonGuest.TabIndex = 30;
            this.radioButtonGuest.TabStop = true;
            this.radioButtonGuest.Text = "гост";
            this.radioButtonGuest.UseVisualStyleBackColor = false;
            this.radioButtonGuest.CheckedChanged += new System.EventHandler(this.radioButton_CheckedChanged);
            // 
            // labelAddEditQuarantineTitlelabel
            // 
            this.labelAddEditQuarantineTitlelabel.BackColor = System.Drawing.Color.Transparent;
            this.labelAddEditQuarantineTitlelabel.Font = new System.Drawing.Font("Arial", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.labelAddEditQuarantineTitlelabel.Location = new System.Drawing.Point(36, 10);
            this.labelAddEditQuarantineTitlelabel.Name = "labelAddEditQuarantineTitlelabel";
            this.labelAddEditQuarantineTitlelabel.Size = new System.Drawing.Size(663, 33);
            this.labelAddEditQuarantineTitlelabel.TabIndex = 28;
            this.labelAddEditQuarantineTitlelabel.Text = "... на карантина";
            this.labelAddEditQuarantineTitlelabel.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
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
            this.buttonSave.TabIndex = 39;
            this.buttonSave.Text = "Запис";
            this.buttonSave.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.buttonSave.UseVisualStyleBackColor = false;
            this.buttonSave.Click += new System.EventHandler(this.buttonSave_Click);
            // 
            // labelTo
            // 
            this.labelTo.AutoSize = true;
            this.labelTo.BackColor = System.Drawing.Color.Transparent;
            this.labelTo.Location = new System.Drawing.Point(425, 141);
            this.labelTo.Name = "labelTo";
            this.labelTo.Size = new System.Drawing.Size(24, 15);
            this.labelTo.TabIndex = 38;
            this.labelTo.Text = "до:";
            // 
            // labelFrom
            // 
            this.labelFrom.AutoSize = true;
            this.labelFrom.BackColor = System.Drawing.Color.Transparent;
            this.labelFrom.Location = new System.Drawing.Point(106, 142);
            this.labelFrom.Name = "labelFrom";
            this.labelFrom.Size = new System.Drawing.Size(22, 15);
            this.labelFrom.TabIndex = 37;
            this.labelFrom.Text = "от:";
            // 
            // dateTimePickerTo
            // 
            this.dateTimePickerTo.CalendarTitleBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(70)))), ((int)(((byte)(90)))), ((int)(((byte)(30)))));
            this.dateTimePickerTo.Location = new System.Drawing.Point(455, 136);
            this.dateTimePickerTo.Name = "dateTimePickerTo";
            this.dateTimePickerTo.Size = new System.Drawing.Size(200, 21);
            this.dateTimePickerTo.TabIndex = 36;
            // 
            // dateTimePickerFrom
            // 
            this.dateTimePickerFrom.CalendarTitleBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(70)))), ((int)(((byte)(90)))), ((int)(((byte)(30)))));
            this.dateTimePickerFrom.Checked = false;
            this.dateTimePickerFrom.Location = new System.Drawing.Point(134, 137);
            this.dateTimePickerFrom.Name = "dateTimePickerFrom";
            this.dateTimePickerFrom.Size = new System.Drawing.Size(200, 21);
            this.dateTimePickerFrom.TabIndex = 35;
            // 
            // labelAddress
            // 
            this.labelAddress.BackColor = System.Drawing.Color.Transparent;
            this.labelAddress.Font = new System.Drawing.Font("Arial", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.labelAddress.Location = new System.Drawing.Point(209, 47);
            this.labelAddress.Name = "labelAddress";
            this.labelAddress.Size = new System.Drawing.Size(663, 33);
            this.labelAddress.TabIndex = 45;
            this.labelAddress.Text = "адрес";
            this.labelAddress.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // InsertDataInhabitantsQuarantines
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(96F, 96F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Dpi;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(170)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.Controls.Add(this.panelAddEditQuarantine);
            this.Controls.Add(this.panelShowQuarantines);
            this.Controls.Add(this.labelAddress);
            this.Controls.Add(this.labelTitle);
            this.Font = new System.Drawing.Font("Arial", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.Name = "InsertDataInhabitantsQuarantines";
            this.Size = new System.Drawing.Size(1081, 329);
            this.panelShowQuarantines.ResumeLayout(false);
            this.panelAddEditQuarantine.ResumeLayout(false);
            this.panelAddEditQuarantine.PerformLayout();
            this.groupBoxDisease.ResumeLayout(false);
            this.groupBoxDisease.PerformLayout();
            this.groupBoxInhabitant.ResumeLayout(false);
            this.groupBoxInhabitant.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panelShowQuarantines;
        private ListBoxUserControl listBoxQarantines;
        private System.Windows.Forms.Button buttonDeleteQuarantine;
        private System.Windows.Forms.Button buttonShowEditQuarantine;
        private System.Windows.Forms.Button buttonShowInsertQuarantine;
        protected System.Windows.Forms.Label labelTitle;
        private System.Windows.Forms.Panel panelAddEditQuarantine;
        private System.Windows.Forms.ComboBox comboBoxInhabitant;
        private System.Windows.Forms.RadioButton radioButtonGuest;
        private System.Windows.Forms.RadioButton radioButtonResident;
        protected System.Windows.Forms.Label labelAddEditQuarantineTitlelabel;
        private System.Windows.Forms.Label labelTo;
        private System.Windows.Forms.Label labelFrom;
        private System.Windows.Forms.DateTimePicker dateTimePickerTo;
        private System.Windows.Forms.DateTimePicker dateTimePickerFrom;
        private System.Windows.Forms.ComboBox comboBoxDisease;
        private System.Windows.Forms.Button buttonSave;
        private System.Windows.Forms.RadioButton radioButtonContact;
        private System.Windows.Forms.RadioButton radioButtonIll;
        private System.Windows.Forms.GroupBox groupBoxDisease;
        private System.Windows.Forms.GroupBox groupBoxInhabitant;
        private System.Windows.Forms.Button buttonCancel;
        protected System.Windows.Forms.Label labelAddress;
    }
}
