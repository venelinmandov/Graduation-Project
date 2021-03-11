
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
            this.textBoxDogName = new System.Windows.Forms.TextBox();
            this.checkBoxNoNumber = new System.Windows.Forms.CheckBox();
            this.button1 = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewDogs)).BeginInit();
            this.SuspendLayout();
            // 
            // dataGridViewDogs
            // 
            this.dataGridViewDogs.AllowUserToAddRows = false;
            this.dataGridViewDogs.AllowUserToDeleteRows = false;
            this.dataGridViewDogs.AllowUserToResizeColumns = false;
            this.dataGridViewDogs.AllowUserToResizeRows = false;
            this.dataGridViewDogs.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridViewDogs.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.ColumnNumber,
            this.ColumnSealNumber});
            this.dataGridViewDogs.Location = new System.Drawing.Point(13, 12);
            this.dataGridViewDogs.MultiSelect = false;
            this.dataGridViewDogs.Name = "dataGridViewDogs";
            this.dataGridViewDogs.RowHeadersVisible = false;
            this.dataGridViewDogs.RowTemplate.Height = 25;
            this.dataGridViewDogs.Size = new System.Drawing.Size(186, 256);
            this.dataGridViewDogs.TabIndex = 0;
            // 
            // ColumnNumber
            // 
            this.ColumnNumber.FillWeight = 152.2843F;
            this.ColumnNumber.HeaderText = "№";
            this.ColumnNumber.Name = "ColumnNumber";
            this.ColumnNumber.Width = 30;
            // 
            // ColumnSealNumber
            // 
            this.ColumnSealNumber.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.ColumnSealNumber.FillWeight = 47.71574F;
            this.ColumnSealNumber.HeaderText = "Номер";
            this.ColumnSealNumber.Name = "ColumnSealNumber";
            // 
            // textBoxDogName
            // 
            this.textBoxDogName.Location = new System.Drawing.Point(13, 274);
            this.textBoxDogName.Name = "textBoxDogName";
            this.textBoxDogName.Size = new System.Drawing.Size(185, 23);
            this.textBoxDogName.TabIndex = 1;
            // 
            // checkBoxNoNumber
            // 
            this.checkBoxNoNumber.AutoSize = true;
            this.checkBoxNoNumber.Location = new System.Drawing.Point(12, 303);
            this.checkBoxNoNumber.Name = "checkBoxNoNumber";
            this.checkBoxNoNumber.Size = new System.Drawing.Size(95, 19);
            this.checkBoxNoNumber.TabIndex = 2;
            this.checkBoxNoNumber.Text = "Няма номер";
            this.checkBoxNoNumber.UseVisualStyleBackColor = true;
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(12, 339);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(94, 23);
            this.button1.TabIndex = 3;
            this.button1.Text = "button1";
            this.button1.UseVisualStyleBackColor = true;
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(113, 339);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(86, 23);
            this.button2.TabIndex = 4;
            this.button2.Text = "button2";
            this.button2.UseVisualStyleBackColor = true;
            // 
            // DogsForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(211, 368);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.button1);
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
        private System.Windows.Forms.DataGridViewTextBoxColumn ColumnNumber;
        private System.Windows.Forms.DataGridViewTextBoxColumn ColumnSealNumber;
        private System.Windows.Forms.TextBox textBoxDogName;
        private System.Windows.Forms.CheckBox checkBoxNoNumber;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button button2;
    }
}