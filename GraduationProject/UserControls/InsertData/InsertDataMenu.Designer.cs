
namespace GraduationProject.UserControls.InsertData
{
    partial class InsertDataMenu
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
            this.buttonAddresses = new System.Windows.Forms.Button();
            this.buttonStreets = new System.Windows.Forms.Button();
            this.labelSearchBy = new System.Windows.Forms.Label();
            this.buttonQuarantines = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // labelTitle
            // 
            this.labelTitle.AutoSize = true;
            this.labelTitle.BackColor = System.Drawing.Color.Transparent;
            this.labelTitle.Font = new System.Drawing.Font("Arial", 21.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.labelTitle.Location = new System.Drawing.Point(395, 37);
            this.labelTitle.Name = "labelTitle";
            this.labelTitle.Size = new System.Drawing.Size(297, 33);
            this.labelTitle.TabIndex = 13;
            this.labelTitle.Text = "Въвеждане на данни";
            // 
            // buttonAddresses
            // 
            this.buttonAddresses.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(70)))), ((int)(((byte)(90)))), ((int)(((byte)(30)))));
            this.buttonAddresses.FlatAppearance.BorderSize = 0;
            this.buttonAddresses.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonAddresses.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.buttonAddresses.ForeColor = System.Drawing.SystemColors.Control;
            this.buttonAddresses.Location = new System.Drawing.Point(233, 139);
            this.buttonAddresses.Name = "buttonAddresses";
            this.buttonAddresses.Size = new System.Drawing.Size(179, 60);
            this.buttonAddresses.TabIndex = 14;
            this.buttonAddresses.Text = "Имоти";
            this.buttonAddresses.UseVisualStyleBackColor = false;
            this.buttonAddresses.Click += new System.EventHandler(this.buttonAddresses_Click);
            // 
            // buttonStreets
            // 
            this.buttonStreets.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(70)))), ((int)(((byte)(90)))), ((int)(((byte)(30)))));
            this.buttonStreets.FlatAppearance.BorderSize = 0;
            this.buttonStreets.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonStreets.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.buttonStreets.ForeColor = System.Drawing.SystemColors.Control;
            this.buttonStreets.Location = new System.Drawing.Point(450, 139);
            this.buttonStreets.Name = "buttonStreets";
            this.buttonStreets.Size = new System.Drawing.Size(179, 60);
            this.buttonStreets.TabIndex = 15;
            this.buttonStreets.Text = "Улици";
            this.buttonStreets.UseVisualStyleBackColor = false;
            this.buttonStreets.Click += new System.EventHandler(this.buttonStreets_Click);
            // 
            // labelSearchBy
            // 
            this.labelSearchBy.AutoSize = true;
            this.labelSearchBy.BackColor = System.Drawing.Color.Transparent;
            this.labelSearchBy.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.labelSearchBy.Location = new System.Drawing.Point(459, 78);
            this.labelSearchBy.Name = "labelSearchBy";
            this.labelSearchBy.Size = new System.Drawing.Size(159, 18);
            this.labelSearchBy.TabIndex = 16;
            this.labelSearchBy.Text = "Изберете категория:";
            // 
            // buttonQuarantines
            // 
            this.buttonQuarantines.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(70)))), ((int)(((byte)(90)))), ((int)(((byte)(30)))));
            this.buttonQuarantines.FlatAppearance.BorderSize = 0;
            this.buttonQuarantines.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonQuarantines.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.buttonQuarantines.ForeColor = System.Drawing.SystemColors.Control;
            this.buttonQuarantines.Location = new System.Drawing.Point(666, 139);
            this.buttonQuarantines.Name = "buttonQuarantines";
            this.buttonQuarantines.Size = new System.Drawing.Size(179, 60);
            this.buttonQuarantines.TabIndex = 17;
            this.buttonQuarantines.Text = "Карантини";
            this.buttonQuarantines.UseVisualStyleBackColor = false;
            this.buttonQuarantines.Click += new System.EventHandler(this.buttonQuarantines_Click);
            // 
            // InsertDataMenu
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(96F, 96F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Dpi;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(170)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.Controls.Add(this.buttonQuarantines);
            this.Controls.Add(this.labelSearchBy);
            this.Controls.Add(this.buttonStreets);
            this.Controls.Add(this.buttonAddresses);
            this.Controls.Add(this.labelTitle);
            this.Font = new System.Drawing.Font("Arial", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.Name = "InsertDataMenu";
            this.Size = new System.Drawing.Size(1081, 329);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        protected System.Windows.Forms.Label labelTitle;
        protected System.Windows.Forms.Button buttonAddresses;
        protected System.Windows.Forms.Button buttonStreets;
        protected System.Windows.Forms.Label labelSearchBy;
        protected System.Windows.Forms.Button buttonQuarantines;
    }
}
