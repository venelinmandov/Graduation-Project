
namespace GraduationProject.UserControls.References.Inhabitants
{
    partial class ReferenceInhabitantsSearchByReg
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
            this.radioButtonWithout = new System.Windows.Forms.RadioButton();
            this.radioButtonTemporary = new System.Windows.Forms.RadioButton();
            this.radioButtonYes = new System.Windows.Forms.RadioButton();
            this.panelDogs.SuspendLayout();
            this.SuspendLayout();
            // 
            // panelDogs
            // 
            this.panelDogs.Controls.Add(this.buttonShow);
            this.panelDogs.Controls.Add(this.labelTitle);
            this.panelDogs.Controls.Add(this.radioButtonWithout);
            this.panelDogs.Controls.Add(this.radioButtonTemporary);
            this.panelDogs.Controls.Add(this.radioButtonYes);
            this.panelDogs.Location = new System.Drawing.Point(338, 70);
            this.panelDogs.Name = "panelDogs";
            this.panelDogs.Size = new System.Drawing.Size(364, 196);
            this.panelDogs.TabIndex = 4;
            // 
            // buttonShow
            // 
            this.buttonShow.FlatAppearance.BorderSize = 0;
            this.buttonShow.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonShow.Font = new System.Drawing.Font("Arial", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.buttonShow.Location = new System.Drawing.Point(64, 153);
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
            this.labelTitle.Size = new System.Drawing.Size(170, 18);
            this.labelTitle.TabIndex = 2;
            this.labelTitle.Text = "Адресна регистрация:";
            // 
            // radioButtonWithout
            // 
            this.radioButtonWithout.AutoSize = true;
            this.radioButtonWithout.BackColor = System.Drawing.Color.Transparent;
            this.radioButtonWithout.Location = new System.Drawing.Point(133, 103);
            this.radioButtonWithout.Name = "radioButtonWithout";
            this.radioButtonWithout.Size = new System.Drawing.Size(120, 19);
            this.radioButtonWithout.TabIndex = 2;
            this.radioButtonWithout.TabStop = true;
            this.radioButtonWithout.Text = "Без регистрация";
            this.radioButtonWithout.UseVisualStyleBackColor = false;
            // 
            // radioButtonTemporary
            // 
            this.radioButtonTemporary.AutoSize = true;
            this.radioButtonTemporary.BackColor = System.Drawing.Color.Transparent;
            this.radioButtonTemporary.Location = new System.Drawing.Point(133, 78);
            this.radioButtonTemporary.Name = "radioButtonTemporary";
            this.radioButtonTemporary.Size = new System.Drawing.Size(112, 19);
            this.radioButtonTemporary.TabIndex = 1;
            this.radioButtonTemporary.TabStop = true;
            this.radioButtonTemporary.Text = "Настоящ адрес";
            this.radioButtonTemporary.UseVisualStyleBackColor = false;
            // 
            // radioButtonYes
            // 
            this.radioButtonYes.AutoSize = true;
            this.radioButtonYes.BackColor = System.Drawing.Color.Transparent;
            this.radioButtonYes.Location = new System.Drawing.Point(133, 51);
            this.radioButtonYes.Name = "radioButtonYes";
            this.radioButtonYes.Size = new System.Drawing.Size(124, 19);
            this.radioButtonYes.TabIndex = 0;
            this.radioButtonYes.TabStop = true;
            this.radioButtonYes.Text = "Постоянен адрес";
            this.radioButtonYes.UseVisualStyleBackColor = false;
            // 
            // ReferenceInhabitantsSearchByReg
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(96F, 96F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Dpi;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(170)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.Controls.Add(this.panelDogs);
            this.Font = new System.Drawing.Font("Arial", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.Name = "ReferenceInhabitantsSearchByReg";
            this.Size = new System.Drawing.Size(1081, 329);
            this.panelDogs.ResumeLayout(false);
            this.panelDogs.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panelDogs;
        private System.Windows.Forms.Button buttonShow;
        private System.Windows.Forms.Label labelTitle;
        private System.Windows.Forms.RadioButton radioButtonWithout;
        private System.Windows.Forms.RadioButton radioButtonTemporary;
        private System.Windows.Forms.RadioButton radioButtonYes;
    }
}
