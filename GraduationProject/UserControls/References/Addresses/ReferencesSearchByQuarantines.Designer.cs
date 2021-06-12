
namespace GraduationProject.UserControls.References.Addresses
{
    partial class ReferencesSearchByQuarantines
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
            this.radioButtonAnimals = new System.Windows.Forms.RadioButton();
            this.radioButtonInhabitants = new System.Windows.Forms.RadioButton();
            this.panelDogs.SuspendLayout();
            this.SuspendLayout();
            // 
            // panelDogs
            // 
            this.panelDogs.Controls.Add(this.buttonShow);
            this.panelDogs.Controls.Add(this.labelTitle);
            this.panelDogs.Controls.Add(this.radioButtonAnimals);
            this.panelDogs.Controls.Add(this.radioButtonInhabitants);
            this.panelDogs.Location = new System.Drawing.Point(358, 67);
            this.panelDogs.Name = "panelDogs";
            this.panelDogs.Size = new System.Drawing.Size(364, 196);
            this.panelDogs.TabIndex = 5;
            // 
            // buttonShow
            // 
            this.buttonShow.FlatAppearance.BorderSize = 0;
            this.buttonShow.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonShow.Font = new System.Drawing.Font("Arial", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.buttonShow.Image = global::GraduationProject.Properties.Resources.magnifer_small;
            this.buttonShow.Location = new System.Drawing.Point(46, 151);
            this.buttonShow.Name = "buttonShow";
            this.buttonShow.Size = new System.Drawing.Size(87, 29);
            this.buttonShow.TabIndex = 5;
            this.buttonShow.Text = "Покажи";
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
            this.labelTitle.Size = new System.Drawing.Size(171, 18);
            this.labelTitle.TabIndex = 2;
            this.labelTitle.Text = "Справки за карантини:";
            // 
            // radioButtonAnimals
            // 
            this.radioButtonAnimals.AutoSize = true;
            this.radioButtonAnimals.BackColor = System.Drawing.Color.Transparent;
            this.radioButtonAnimals.Location = new System.Drawing.Point(93, 93);
            this.radioButtonAnimals.Name = "radioButtonAnimals";
            this.radioButtonAnimals.Size = new System.Drawing.Size(190, 19);
            this.radioButtonAnimals.TabIndex = 1;
            this.radioButtonAnimals.TabStop = true;
            this.radioButtonAnimals.Text = "на селскостопански животни";
            this.radioButtonAnimals.UseVisualStyleBackColor = false;
            // 
            // radioButtonInhabitants
            // 
            this.radioButtonInhabitants.AutoSize = true;
            this.radioButtonInhabitants.BackColor = System.Drawing.Color.Transparent;
            this.radioButtonInhabitants.Location = new System.Drawing.Point(93, 69);
            this.radioButtonInhabitants.Name = "radioButtonInhabitants";
            this.radioButtonInhabitants.Size = new System.Drawing.Size(70, 19);
            this.radioButtonInhabitants.TabIndex = 0;
            this.radioButtonInhabitants.TabStop = true;
            this.radioButtonInhabitants.Text = "На хора";
            this.radioButtonInhabitants.UseVisualStyleBackColor = false;
            // 
            // ReferencesSearchByQuarantines
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(96F, 96F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Dpi;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(170)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.Controls.Add(this.panelDogs);
            this.Font = new System.Drawing.Font("Arial", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.Name = "ReferencesSearchByQuarantines";
            this.Size = new System.Drawing.Size(1081, 329);
            this.panelDogs.ResumeLayout(false);
            this.panelDogs.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panelDogs;
        private System.Windows.Forms.Button buttonShow;
        private System.Windows.Forms.Label labelTitle;
        private System.Windows.Forms.RadioButton radioButtonAnimals;
        private System.Windows.Forms.RadioButton radioButtonInhabitants;
    }
}
