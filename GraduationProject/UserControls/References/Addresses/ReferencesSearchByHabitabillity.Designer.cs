
namespace GraduationProject.UserControls.References.Addresses
{
    partial class ReferencesSearchByHabitabillity
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
            this.panelDogs = new System.Windows.Forms.Panel();
            this.buttonShow = new System.Windows.Forms.Button();
            this.labelTitle = new System.Windows.Forms.Label();
            this.radioButtonTemporary = new System.Windows.Forms.RadioButton();
            this.radioButtonInhabited = new System.Windows.Forms.RadioButton();
            this.radioButtonOutOfRegulation = new System.Windows.Forms.RadioButton();
            this.radioButtonDesolate = new System.Windows.Forms.RadioButton();
            this.panelDogs.SuspendLayout();
            this.SuspendLayout();
            // 
            // panelDogs
            // 
            this.panelDogs.Controls.Add(this.radioButtonOutOfRegulation);
            this.panelDogs.Controls.Add(this.radioButtonDesolate);
            this.panelDogs.Controls.Add(this.buttonShow);
            this.panelDogs.Controls.Add(this.labelTitle);
            this.panelDogs.Controls.Add(this.radioButtonTemporary);
            this.panelDogs.Controls.Add(this.radioButtonInhabited);
            this.panelDogs.Location = new System.Drawing.Point(338, 51);
            this.panelDogs.Name = "panelDogs";
            this.panelDogs.Size = new System.Drawing.Size(364, 228);
            this.panelDogs.TabIndex = 7;
            // 
            // buttonShow
            // 
            this.buttonShow.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.buttonShow.FlatAppearance.BorderSize = 0;
            this.buttonShow.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonShow.Location = new System.Drawing.Point(64, 185);
            this.buttonShow.Name = "buttonShow";
            this.buttonShow.Size = new System.Drawing.Size(75, 23);
            this.buttonShow.TabIndex = 5;
            this.buttonShow.Text = "Покажи";
            this.buttonShow.UseVisualStyleBackColor = true;
            this.buttonShow.Click += new System.EventHandler(this.buttonShow_Click);
            // 
            // labelTitle
            // 
            this.labelTitle.AutoSize = true;
            this.labelTitle.BackColor = System.Drawing.Color.Transparent;
            this.labelTitle.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.labelTitle.Location = new System.Drawing.Point(88, 19);
            this.labelTitle.Name = "labelTitle";
            this.labelTitle.Size = new System.Drawing.Size(164, 18);
            this.labelTitle.TabIndex = 2;
            this.labelTitle.Text = "Статус на обитаване:";
            // 
            // radioButtonTemporary
            // 
            this.radioButtonTemporary.AutoSize = true;
            this.radioButtonTemporary.BackColor = System.Drawing.Color.Transparent;
            this.radioButtonTemporary.Location = new System.Drawing.Point(133, 90);
            this.radioButtonTemporary.Name = "radioButtonTemporary";
            this.radioButtonTemporary.Size = new System.Drawing.Size(140, 19);
            this.radioButtonTemporary.TabIndex = 1;
            this.radioButtonTemporary.TabStop = true;
            this.radioButtonTemporary.Text = "Временно обитаван";
            this.radioButtonTemporary.UseVisualStyleBackColor = false;
            // 
            // radioButtonInhabted
            // 
            this.radioButtonInhabited.AutoSize = true;
            this.radioButtonInhabited.BackColor = System.Drawing.Color.Transparent;
            this.radioButtonInhabited.Location = new System.Drawing.Point(133, 63);
            this.radioButtonInhabited.Name = "radioButtonInhabted";
            this.radioButtonInhabited.Size = new System.Drawing.Size(80, 19);
            this.radioButtonInhabited.TabIndex = 0;
            this.radioButtonInhabited.TabStop = true;
            this.radioButtonInhabited.Text = "Обитаван";
            this.radioButtonInhabited.UseVisualStyleBackColor = false;
            // 
            // radioButtonOutOfRegulation
            // 
            this.radioButtonOutOfRegulation.AutoSize = true;
            this.radioButtonOutOfRegulation.BackColor = System.Drawing.Color.Transparent;
            this.radioButtonOutOfRegulation.Location = new System.Drawing.Point(133, 142);
            this.radioButtonOutOfRegulation.Name = "radioButtonOutOfRegulation";
            this.radioButtonOutOfRegulation.Size = new System.Drawing.Size(122, 19);
            this.radioButtonOutOfRegulation.TabIndex = 7;
            this.radioButtonOutOfRegulation.TabStop = true;
            this.radioButtonOutOfRegulation.Text = "Извън регулация";
            this.radioButtonOutOfRegulation.UseVisualStyleBackColor = false;
            // 
            // radioButtonDesolate
            // 
            this.radioButtonDesolate.AutoSize = true;
            this.radioButtonDesolate.BackColor = System.Drawing.Color.Transparent;
            this.radioButtonDesolate.Location = new System.Drawing.Point(133, 115);
            this.radioButtonDesolate.Name = "radioButtonDesolate";
            this.radioButtonDesolate.Size = new System.Drawing.Size(73, 19);
            this.radioButtonDesolate.TabIndex = 6;
            this.radioButtonDesolate.TabStop = true;
            this.radioButtonDesolate.Text = "Пустеещ";
            this.radioButtonDesolate.UseVisualStyleBackColor = false;
            // 
            // ReferencesSearchByHabitabillity
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(170)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.Controls.Add(this.panelDogs);
            this.Font = new System.Drawing.Font("Arial", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.Name = "ReferencesSearchByHabitabillity";
            this.Size = new System.Drawing.Size(1081, 329);
            this.panelDogs.ResumeLayout(false);
            this.panelDogs.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panelDogs;
        private System.Windows.Forms.Button buttonShow;
        private System.Windows.Forms.Label labelTitle;
        private System.Windows.Forms.RadioButton radioButtonTemporary;
        private System.Windows.Forms.RadioButton radioButtonInhabited;
        private System.Windows.Forms.RadioButton radioButtonOutOfRegulation;
        private System.Windows.Forms.RadioButton radioButtonDesolate;
    }
}
