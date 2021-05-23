
namespace GraduationProject.UserControls
{
    partial class ReferencesMenu
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
            this.buttonQuarantines = new System.Windows.Forms.Button();
            this.buttonTrees = new System.Windows.Forms.Button();
            this.buttonPropeties = new System.Windows.Forms.Button();
            this.buttonCattle = new System.Windows.Forms.Button();
            this.buttonInhabitants = new System.Windows.Forms.Button();
            this.buttonAddresses = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // labelTitle
            // 
            this.labelTitle.AutoSize = true;
            this.labelTitle.BackColor = System.Drawing.Color.Transparent;
            this.labelTitle.Font = new System.Drawing.Font("Arial", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.labelTitle.Location = new System.Drawing.Point(371, 33);
            this.labelTitle.Name = "labelTitle";
            this.labelTitle.Size = new System.Drawing.Size(369, 27);
            this.labelTitle.TabIndex = 12;
            this.labelTitle.Text = "Изберете категория за търсене:";
            // 
            // buttonQuarantines
            // 
            this.buttonQuarantines.Location = new System.Drawing.Point(440, 208);
            this.buttonQuarantines.Name = "buttonQuarantines";
            this.buttonQuarantines.Size = new System.Drawing.Size(179, 60);
            this.buttonQuarantines.TabIndex = 10;
            this.buttonQuarantines.Text = "Карантини";
            this.buttonQuarantines.UseVisualStyleBackColor = true;
            // 
            // buttonTrees
            // 
            this.buttonTrees.Location = new System.Drawing.Point(658, 208);
            this.buttonTrees.Name = "buttonTrees";
            this.buttonTrees.Size = new System.Drawing.Size(179, 60);
            this.buttonTrees.TabIndex = 11;
            this.buttonTrees.Text = "Защитени дървесни видове";
            this.buttonTrees.UseVisualStyleBackColor = true;
            // 
            // buttonPropeties
            // 
            this.buttonPropeties.Location = new System.Drawing.Point(225, 208);
            this.buttonPropeties.Name = "buttonPropeties";
            this.buttonPropeties.Size = new System.Drawing.Size(179, 60);
            this.buttonPropeties.TabIndex = 9;
            this.buttonPropeties.Text = "Данни за имоти";
            this.buttonPropeties.UseVisualStyleBackColor = true;
            // 
            // buttonCattle
            // 
            this.buttonCattle.Location = new System.Drawing.Point(658, 103);
            this.buttonCattle.Name = "buttonCattle";
            this.buttonCattle.Size = new System.Drawing.Size(179, 60);
            this.buttonCattle.TabIndex = 8;
            this.buttonCattle.Text = "Селскостопански животни";
            this.buttonCattle.UseVisualStyleBackColor = true;
            this.buttonCattle.Click += new System.EventHandler(this.buttonCattle_Click);
            // 
            // buttonInhabitants
            // 
            this.buttonInhabitants.Location = new System.Drawing.Point(440, 103);
            this.buttonInhabitants.Name = "buttonInhabitants";
            this.buttonInhabitants.Size = new System.Drawing.Size(179, 60);
            this.buttonInhabitants.TabIndex = 7;
            this.buttonInhabitants.Text = "Жители";
            this.buttonInhabitants.UseVisualStyleBackColor = true;
            this.buttonInhabitants.Click += new System.EventHandler(this.buttonInhabitants_Click);
            // 
            // buttonAddresses
            // 
            this.buttonAddresses.Location = new System.Drawing.Point(225, 103);
            this.buttonAddresses.Name = "buttonAddresses";
            this.buttonAddresses.Size = new System.Drawing.Size(179, 60);
            this.buttonAddresses.TabIndex = 6;
            this.buttonAddresses.Text = "Адреси";
            this.buttonAddresses.UseVisualStyleBackColor = true;
            this.buttonAddresses.Click += new System.EventHandler(this.buttonAddresses_Click);
            // 
            // ReferencesMenu
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(170)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.Controls.Add(this.labelTitle);
            this.Controls.Add(this.buttonQuarantines);
            this.Controls.Add(this.buttonTrees);
            this.Controls.Add(this.buttonPropeties);
            this.Controls.Add(this.buttonCattle);
            this.Controls.Add(this.buttonInhabitants);
            this.Controls.Add(this.buttonAddresses);
            this.Font = new System.Drawing.Font("Arial", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.Name = "ReferencesMenu";
            this.Size = new System.Drawing.Size(1081, 329);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        protected System.Windows.Forms.Label labelTitle;
        protected System.Windows.Forms.Button buttonQuarantines;
        protected System.Windows.Forms.Button buttonTrees;
        protected System.Windows.Forms.Button buttonPropeties;
        protected System.Windows.Forms.Button buttonCattle;
        protected System.Windows.Forms.Button buttonInhabitants;
        protected System.Windows.Forms.Button buttonAddresses;
    }
}
