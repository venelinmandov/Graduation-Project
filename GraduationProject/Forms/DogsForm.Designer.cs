
namespace GraduationProject.Forms
{
    partial class DogsForm
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle3 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle4 = new System.Windows.Forms.DataGridViewCellStyle();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(DogsForm));
            this.dataGridViewDogs = new System.Windows.Forms.DataGridView();
            this.ColumnNumber = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ColumnSealNumber = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewImageColumn1 = new System.Windows.Forms.DataGridViewImageColumn();
            this.textBoxDogName = new System.Windows.Forms.TextBox();
            this.checkBoxNoNumber = new System.Windows.Forms.CheckBox();
            this.buttonAdd = new System.Windows.Forms.Button();
            this.radioButtonGuard = new System.Windows.Forms.RadioButton();
            this.radioButtonHunting = new System.Windows.Forms.RadioButton();
            this.radioButtonDomestic = new System.Windows.Forms.RadioButton();
            this.groupBoxDogType = new System.Windows.Forms.GroupBox();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewDogs)).BeginInit();
            this.groupBoxDogType.SuspendLayout();
            this.SuspendLayout();
            // 
            // dataGridViewDogs
            // 
            this.dataGridViewDogs.AllowUserToAddRows = false;
            this.dataGridViewDogs.AllowUserToDeleteRows = false;
            this.dataGridViewDogs.AllowUserToResizeColumns = false;
            this.dataGridViewDogs.AllowUserToResizeRows = false;
            dataGridViewCellStyle1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.dataGridViewDogs.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle1;
            this.dataGridViewDogs.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.dataGridViewDogs.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(184)))), ((int)(((byte)(216)))), ((int)(((byte)(186)))));
            this.dataGridViewDogs.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.Single;
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Arial", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            dataGridViewCellStyle2.ForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dataGridViewDogs.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle2;
            this.dataGridViewDogs.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridViewDogs.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.ColumnNumber,
            this.ColumnSealNumber,
            this.dataGridViewImageColumn1});
            dataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle3.BackColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle3.Font = new System.Drawing.Font("Arial", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            dataGridViewCellStyle3.ForeColor = System.Drawing.Color.Black;
            dataGridViewCellStyle3.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(79)))), ((int)(((byte)(33)))));
            dataGridViewCellStyle3.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dataGridViewDogs.DefaultCellStyle = dataGridViewCellStyle3;
            this.dataGridViewDogs.EnableHeadersVisualStyles = false;
            this.dataGridViewDogs.GridColor = System.Drawing.Color.Silver;
            this.dataGridViewDogs.Location = new System.Drawing.Point(12, 12);
            this.dataGridViewDogs.MultiSelect = false;
            this.dataGridViewDogs.Name = "dataGridViewDogs";
            this.dataGridViewDogs.RowHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            dataGridViewCellStyle4.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle4.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle4.Font = new System.Drawing.Font("Arial", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            dataGridViewCellStyle4.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle4.SelectionBackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle4.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle4.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dataGridViewDogs.RowHeadersDefaultCellStyle = dataGridViewCellStyle4;
            this.dataGridViewDogs.RowHeadersVisible = false;
            this.dataGridViewDogs.RowTemplate.Height = 25;
            this.dataGridViewDogs.ShowCellToolTips = false;
            this.dataGridViewDogs.Size = new System.Drawing.Size(279, 216);
            this.dataGridViewDogs.TabIndex = 0;
            this.dataGridViewDogs.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridViewDogs_CellClick);
            this.dataGridViewDogs.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridViewDogs_CellContentClick);
            this.dataGridViewDogs.CellValueChanged += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridViewDogs_CellValueChanged);
            // 
            // ColumnNumber
            // 
            this.ColumnNumber.FillWeight = 152.2843F;
            this.ColumnNumber.HeaderText = "№";
            this.ColumnNumber.Name = "ColumnNumber";
            this.ColumnNumber.ReadOnly = true;
            this.ColumnNumber.Width = 30;
            // 
            // ColumnSealNumber
            // 
            this.ColumnSealNumber.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.ColumnSealNumber.FillWeight = 47.71574F;
            this.ColumnSealNumber.HeaderText = "Номер";
            this.ColumnSealNumber.Name = "ColumnSealNumber";
            this.ColumnSealNumber.ReadOnly = true;
            // 
            // dataGridViewImageColumn1
            // 
            this.dataGridViewImageColumn1.HeaderText = "";
            this.dataGridViewImageColumn1.Image = ((System.Drawing.Image)(resources.GetObject("dataGridViewImageColumn1.Image")));
            this.dataGridViewImageColumn1.Name = "dataGridViewImageColumn1";
            this.dataGridViewImageColumn1.ReadOnly = true;
            this.dataGridViewImageColumn1.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            this.dataGridViewImageColumn1.Width = 32;
            // 
            // textBoxDogName
            // 
            this.textBoxDogName.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.textBoxDogName.Font = new System.Drawing.Font("Arial", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.textBoxDogName.Location = new System.Drawing.Point(304, 14);
            this.textBoxDogName.Name = "textBoxDogName";
            this.textBoxDogName.Size = new System.Drawing.Size(185, 21);
            this.textBoxDogName.TabIndex = 1;
            // 
            // checkBoxNoNumber
            // 
            this.checkBoxNoNumber.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.checkBoxNoNumber.AutoSize = true;
            this.checkBoxNoNumber.Font = new System.Drawing.Font("Arial", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.checkBoxNoNumber.Location = new System.Drawing.Point(304, 52);
            this.checkBoxNoNumber.Name = "checkBoxNoNumber";
            this.checkBoxNoNumber.Size = new System.Drawing.Size(98, 19);
            this.checkBoxNoNumber.TabIndex = 2;
            this.checkBoxNoNumber.Text = "Няма номер";
            this.checkBoxNoNumber.UseVisualStyleBackColor = true;
            this.checkBoxNoNumber.CheckedChanged += new System.EventHandler(this.checkBoxNoNumber_CheckedChanged);
            // 
            // buttonAdd
            // 
            this.buttonAdd.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.buttonAdd.BackColor = System.Drawing.SystemColors.ButtonFace;
            this.buttonAdd.FlatAppearance.BorderSize = 0;
            this.buttonAdd.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonAdd.Font = new System.Drawing.Font("Arial", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.buttonAdd.Location = new System.Drawing.Point(308, 205);
            this.buttonAdd.Name = "buttonAdd";
            this.buttonAdd.Size = new System.Drawing.Size(94, 23);
            this.buttonAdd.TabIndex = 3;
            this.buttonAdd.Text = "Добавяне";
            this.buttonAdd.UseVisualStyleBackColor = false;
            this.buttonAdd.Click += new System.EventHandler(this.buttonAdd_Click);
            // 
            // radioButtonGuard
            // 
            this.radioButtonGuard.AutoSize = true;
            this.radioButtonGuard.Location = new System.Drawing.Point(17, 20);
            this.radioButtonGuard.Name = "radioButtonGuard";
            this.radioButtonGuard.Size = new System.Drawing.Size(86, 19);
            this.radioButtonGuard.TabIndex = 4;
            this.radioButtonGuard.TabStop = true;
            this.radioButtonGuard.Text = "Куче пазач";
            this.radioButtonGuard.UseVisualStyleBackColor = true;
            // 
            // radioButtonHuntingDog
            // 
            this.radioButtonHunting.AutoSize = true;
            this.radioButtonHunting.Location = new System.Drawing.Point(17, 45);
            this.radioButtonHunting.Name = "radioButtonHuntingDog";
            this.radioButtonHunting.Size = new System.Drawing.Size(122, 19);
            this.radioButtonHunting.TabIndex = 5;
            this.radioButtonHunting.TabStop = true;
            this.radioButtonHunting.Text = "Ловджийско куче";
            this.radioButtonHunting.UseVisualStyleBackColor = true;
            // 
            // radioButtonDomestic
            // 
            this.radioButtonDomestic.AutoSize = true;
            this.radioButtonDomestic.Location = new System.Drawing.Point(17, 70);
            this.radioButtonDomestic.Name = "radioButtonDomestic";
            this.radioButtonDomestic.Size = new System.Drawing.Size(135, 19);
            this.radioButtonDomestic.TabIndex = 6;
            this.radioButtonDomestic.TabStop = true;
            this.radioButtonDomestic.Text = "Домашен любимец";
            this.radioButtonDomestic.UseVisualStyleBackColor = true;
            // 
            // groupBoxDogType
            // 
            this.groupBoxDogType.Controls.Add(this.radioButtonGuard);
            this.groupBoxDogType.Controls.Add(this.radioButtonDomestic);
            this.groupBoxDogType.Controls.Add(this.radioButtonHunting);
            this.groupBoxDogType.Location = new System.Drawing.Point(297, 77);
            this.groupBoxDogType.Name = "groupBoxDogType";
            this.groupBoxDogType.Size = new System.Drawing.Size(200, 100);
            this.groupBoxDogType.TabIndex = 7;
            this.groupBoxDogType.TabStop = false;
            // 
            // DogsForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(184)))), ((int)(((byte)(216)))), ((int)(((byte)(186)))));
            this.ClientSize = new System.Drawing.Size(505, 240);
            this.Controls.Add(this.groupBoxDogType);
            this.Controls.Add(this.buttonAdd);
            this.Controls.Add(this.checkBoxNoNumber);
            this.Controls.Add(this.textBoxDogName);
            this.Controls.Add(this.dataGridViewDogs);
            this.Font = new System.Drawing.Font("Arial", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.Name = "DogsForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Кучета";
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewDogs)).EndInit();
            this.groupBoxDogType.ResumeLayout(false);
            this.groupBoxDogType.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dataGridViewDogs;
        private System.Windows.Forms.TextBox textBoxDogName;
        private System.Windows.Forms.CheckBox checkBoxNoNumber;
        private System.Windows.Forms.Button buttonAdd;
        private System.Windows.Forms.DataGridViewTextBoxColumn ColumnNumber;
        private System.Windows.Forms.DataGridViewTextBoxColumn ColumnSealNumber;
        private System.Windows.Forms.DataGridViewImageColumn dataGridViewImageColumn1;
        private System.Windows.Forms.RadioButton radioButtonGuard;
        private System.Windows.Forms.RadioButton radioButtonHunting;
        private System.Windows.Forms.RadioButton radioButtonDomestic;
        private System.Windows.Forms.GroupBox groupBoxDogType;
    }
}