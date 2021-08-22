
namespace GraduationProject.UserControls.InsertData.Quarantines
{
    partial class InsertDataQuarantines
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
            this.labelSearchBy = new System.Windows.Forms.Label();
            this.buttonAnimalsQuarantines = new System.Windows.Forms.Button();
            this.buttonInhabitantsQuarantines = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // labelTitle
            // 
            this.labelTitle.AutoSize = true;
            this.labelTitle.BackColor = System.Drawing.Color.Transparent;
            this.labelTitle.Font = new System.Drawing.Font("Arial", 21.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.labelTitle.Location = new System.Drawing.Point(461, 37);
            this.labelTitle.Name = "labelTitle";
            this.labelTitle.Size = new System.Drawing.Size(157, 33);
            this.labelTitle.TabIndex = 15;
            this.labelTitle.Text = "Карантини";
            // 
            // labelSearchBy
            // 
            this.labelSearchBy.AutoSize = true;
            this.labelSearchBy.BackColor = System.Drawing.Color.Transparent;
            this.labelSearchBy.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.labelSearchBy.Location = new System.Drawing.Point(474, 78);
            this.labelSearchBy.Name = "labelSearchBy";
            this.labelSearchBy.Size = new System.Drawing.Size(129, 18);
            this.labelSearchBy.TabIndex = 18;
            this.labelSearchBy.Text = "Изберете опция:";
            // 
            // buttonAnimalsQuarantines
            // 
            this.buttonAnimalsQuarantines.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(70)))), ((int)(((byte)(90)))), ((int)(((byte)(30)))));
            this.buttonAnimalsQuarantines.FlatAppearance.BorderSize = 0;
            this.buttonAnimalsQuarantines.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonAnimalsQuarantines.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.buttonAnimalsQuarantines.ForeColor = System.Drawing.SystemColors.Control;
            this.buttonAnimalsQuarantines.Location = new System.Drawing.Point(570, 139);
            this.buttonAnimalsQuarantines.Name = "buttonAnimalsQuarantines";
            this.buttonAnimalsQuarantines.Size = new System.Drawing.Size(202, 60);
            this.buttonAnimalsQuarantines.TabIndex = 20;
            this.buttonAnimalsQuarantines.Text = "Карантини на селскостопански животни";
            this.buttonAnimalsQuarantines.UseVisualStyleBackColor = false;
            this.buttonAnimalsQuarantines.Click += new System.EventHandler(this.buttonAnimalsQuarantines_Click);
            // 
            // buttonInhabitantsQuarantines
            // 
            this.buttonInhabitantsQuarantines.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(70)))), ((int)(((byte)(90)))), ((int)(((byte)(30)))));
            this.buttonInhabitantsQuarantines.FlatAppearance.BorderSize = 0;
            this.buttonInhabitantsQuarantines.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonInhabitantsQuarantines.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.buttonInhabitantsQuarantines.ForeColor = System.Drawing.SystemColors.Control;
            this.buttonInhabitantsQuarantines.Location = new System.Drawing.Point(308, 139);
            this.buttonInhabitantsQuarantines.Name = "buttonInhabitantsQuarantines";
            this.buttonInhabitantsQuarantines.Size = new System.Drawing.Size(202, 60);
            this.buttonInhabitantsQuarantines.TabIndex = 19;
            this.buttonInhabitantsQuarantines.Text = "Карантини на обитатели";
            this.buttonInhabitantsQuarantines.UseVisualStyleBackColor = false;
            this.buttonInhabitantsQuarantines.Click += new System.EventHandler(this.buttonInhabitantsQuarantines_Click);
            // 
            // InsertDataQuarantines
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(96F, 96F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Dpi;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(170)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.Controls.Add(this.buttonAnimalsQuarantines);
            this.Controls.Add(this.buttonInhabitantsQuarantines);
            this.Controls.Add(this.labelSearchBy);
            this.Controls.Add(this.labelTitle);
            this.Font = new System.Drawing.Font("Arial", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.Name = "InsertDataQuarantines";
            this.Size = new System.Drawing.Size(1081, 329);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        protected System.Windows.Forms.Label labelTitle;
        protected System.Windows.Forms.Label labelSearchBy;
        protected System.Windows.Forms.Button buttonAnimalsQuarantines;
        protected System.Windows.Forms.Button buttonInhabitantsQuarantines;
    }
}
