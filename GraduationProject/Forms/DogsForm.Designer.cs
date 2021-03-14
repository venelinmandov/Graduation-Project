
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
            this.dataGridViewDogs = new System.Windows.Forms.DataGridView();
            this.ColumnNumber = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ColumnSealNumber = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewButtonColumn1 = new System.Windows.Forms.DataGridViewButtonColumn();
            this.textBoxDogName = new System.Windows.Forms.TextBox();
            this.checkBoxNoNumber = new System.Windows.Forms.CheckBox();
            this.buttonAdd = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewDogs)).BeginInit();
            this.SuspendLayout();
            // 
            // dataGridViewDogs
            // 
            this.dataGridViewDogs.AllowUserToAddRows = false;
            this.dataGridViewDogs.AllowUserToDeleteRows = false;
            this.dataGridViewDogs.AllowUserToResizeColumns = false;
            this.dataGridViewDogs.AllowUserToResizeRows = false;
            this.dataGridViewDogs.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.dataGridViewDogs.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridViewDogs.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.ColumnNumber,
            this.ColumnSealNumber,
            this.dataGridViewButtonColumn1});
            this.dataGridViewDogs.Location = new System.Drawing.Point(12, 12);
            this.dataGridViewDogs.MultiSelect = false;
            this.dataGridViewDogs.Name = "dataGridViewDogs";
            this.dataGridViewDogs.RowHeadersVisible = false;
            this.dataGridViewDogs.RowTemplate.Height = 25;
            this.dataGridViewDogs.Size = new System.Drawing.Size(279, 177);
            this.dataGridViewDogs.TabIndex = 0;
            this.dataGridViewDogs.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridViewDogs_CellClick);
            this.dataGridViewDogs.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridViewDogs_CellContentClick);
            this.dataGridViewDogs.CellValueChanged += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridViewDogs_CellValueChanged);
            this.dataGridViewDogs.CurrentCellChanged += new System.EventHandler(this.dataGridViewDogs_CurrentCellChanged);
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
            // dataGridViewButtonColumn1
            // 
            this.dataGridViewButtonColumn1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.dataGridViewButtonColumn1.HeaderText = "";
            this.dataGridViewButtonColumn1.Name = "dataGridViewButtonColumn1";
            this.dataGridViewButtonColumn1.ReadOnly = true;
            this.dataGridViewButtonColumn1.Width = 70;
            // 
            // textBoxDogName
            // 
            this.textBoxDogName.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.textBoxDogName.Location = new System.Drawing.Point(308, 13);
            this.textBoxDogName.Name = "textBoxDogName";
            this.textBoxDogName.Size = new System.Drawing.Size(185, 23);
            this.textBoxDogName.TabIndex = 1;
            this.textBoxDogName.TextChanged += new System.EventHandler(this.textBoxDogName_TextChanged);
            // 
            // checkBoxNoNumber
            // 
            this.checkBoxNoNumber.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.checkBoxNoNumber.AutoSize = true;
            this.checkBoxNoNumber.Location = new System.Drawing.Point(308, 52);
            this.checkBoxNoNumber.Name = "checkBoxNoNumber";
            this.checkBoxNoNumber.Size = new System.Drawing.Size(95, 19);
            this.checkBoxNoNumber.TabIndex = 2;
            this.checkBoxNoNumber.Text = "Няма номер";
            this.checkBoxNoNumber.UseVisualStyleBackColor = true;
            this.checkBoxNoNumber.CheckedChanged += new System.EventHandler(this.checkBoxNoNumber_CheckedChanged);
            // 
            // buttonAdd
            // 
            this.buttonAdd.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.buttonAdd.Location = new System.Drawing.Point(308, 80);
            this.buttonAdd.Name = "buttonAdd";
            this.buttonAdd.Size = new System.Drawing.Size(94, 23);
            this.buttonAdd.TabIndex = 3;
            this.buttonAdd.Text = "Добаване";
            this.buttonAdd.UseVisualStyleBackColor = true;
            this.buttonAdd.Click += new System.EventHandler(this.buttonAdd_Click);
            // 
            // DogsForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(505, 201);
            this.Controls.Add(this.buttonAdd);
            this.Controls.Add(this.checkBoxNoNumber);
            this.Controls.Add(this.textBoxDogName);
            this.Controls.Add(this.dataGridViewDogs);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.Name = "DogsForm";
            this.Text = "DogsForm";
            this.Load += new System.EventHandler(this.DogsForm_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewDogs)).EndInit();
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
        private System.Windows.Forms.DataGridViewButtonColumn dataGridViewButtonColumn1;
    }
}