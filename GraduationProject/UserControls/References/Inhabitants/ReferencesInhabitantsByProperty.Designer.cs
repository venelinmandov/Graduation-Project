
namespace GraduationProject.UserControls.References.Inhabitants
{
    partial class ReferencesInhabitantsByProperty
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
            this.radioButtonGuest = new System.Windows.Forms.RadioButton();
            this.radioButtonResident = new System.Windows.Forms.RadioButton();
            this.radioButtonOwner = new System.Windows.Forms.RadioButton();
            this.panelDogs.SuspendLayout();
            this.SuspendLayout();
            // 
            // panelDogs
            // 
            this.panelDogs.Controls.Add(this.buttonShow);
            this.panelDogs.Controls.Add(this.labelTitle);
            this.panelDogs.Controls.Add(this.radioButtonGuest);
            this.panelDogs.Controls.Add(this.radioButtonResident);
            this.panelDogs.Controls.Add(this.radioButtonOwner);
            this.panelDogs.Location = new System.Drawing.Point(358, 69);
            this.panelDogs.Name = "panelDogs";
            this.panelDogs.Size = new System.Drawing.Size(364, 196);
            this.panelDogs.TabIndex = 5;
            // 
            // buttonShow
            // 
            this.buttonShow.FlatAppearance.BorderSize = 0;
            this.buttonShow.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonShow.Image = global::GraduationProject.Properties.Resources.magnifer_small;
            this.buttonShow.Location = new System.Drawing.Point(46, 153);
            this.buttonShow.Name = "buttonShow";
            this.buttonShow.Size = new System.Drawing.Size(87, 29);
            this.buttonShow.TabIndex = 5;
            this.buttonShow.Text = "Търсeне";
            this.buttonShow.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
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
            this.labelTitle.Size = new System.Drawing.Size(178, 18);
            this.labelTitle.TabIndex = 2;
            this.labelTitle.Text = "Статус на собственост:";
            // 
            // radioButtonGuest
            // 
            this.radioButtonGuest.AutoSize = true;
            this.radioButtonGuest.BackColor = System.Drawing.Color.Transparent;
            this.radioButtonGuest.Location = new System.Drawing.Point(133, 108);
            this.radioButtonGuest.Name = "radioButtonGuest";
            this.radioButtonGuest.Size = new System.Drawing.Size(49, 19);
            this.radioButtonGuest.TabIndex = 2;
            this.radioButtonGuest.TabStop = true;
            this.radioButtonGuest.Text = "Гост";
            this.radioButtonGuest.UseVisualStyleBackColor = false;
            // 
            // radioButtonResident
            // 
            this.radioButtonResident.AutoSize = true;
            this.radioButtonResident.BackColor = System.Drawing.Color.Transparent;
            this.radioButtonResident.Location = new System.Drawing.Point(133, 84);
            this.radioButtonResident.Name = "radioButtonResident";
            this.radioButtonResident.Size = new System.Drawing.Size(160, 19);
            this.radioButtonResident.TabIndex = 1;
            this.radioButtonResident.TabStop = true;
            this.radioButtonResident.Text = "Член на домакинството";
            this.radioButtonResident.UseVisualStyleBackColor = false;
            // 
            // radioButtonOwner
            // 
            this.radioButtonOwner.AutoSize = true;
            this.radioButtonOwner.BackColor = System.Drawing.Color.Transparent;
            this.radioButtonOwner.Location = new System.Drawing.Point(133, 60);
            this.radioButtonOwner.Name = "radioButtonOwner";
            this.radioButtonOwner.Size = new System.Drawing.Size(92, 19);
            this.radioButtonOwner.TabIndex = 0;
            this.radioButtonOwner.TabStop = true;
            this.radioButtonOwner.Text = "Собственик";
            this.radioButtonOwner.UseVisualStyleBackColor = false;
            // 
            // ReferencesInhabitantsByProperty
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(96F, 96F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Dpi;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(170)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.Controls.Add(this.panelDogs);
            this.Font = new System.Drawing.Font("Arial", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.Name = "ReferencesInhabitantsByProperty";
            this.Size = new System.Drawing.Size(1081, 329);
            this.panelDogs.ResumeLayout(false);
            this.panelDogs.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panelDogs;
        private System.Windows.Forms.Button buttonShow;
        private System.Windows.Forms.Label labelTitle;
        private System.Windows.Forms.RadioButton radioButtonGuest;
        private System.Windows.Forms.RadioButton radioButtonResident;
        private System.Windows.Forms.RadioButton radioButtonOwner;
    }
}
