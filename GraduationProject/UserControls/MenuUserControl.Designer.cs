
namespace GraduationProject.UserControls
{
    partial class MenuUserControl
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
            this.buttonReferences = new System.Windows.Forms.Button();
            this.buttonInsertData = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // buttonReferences
            // 
            this.buttonReferences.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(50)))), ((int)(((byte)(80)))), ((int)(((byte)(40)))));
            this.buttonReferences.FlatAppearance.BorderSize = 0;
            this.buttonReferences.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonReferences.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.buttonReferences.ForeColor = System.Drawing.SystemColors.Control;
            this.buttonReferences.Location = new System.Drawing.Point(200, 68);
            this.buttonReferences.Name = "buttonReferences";
            this.buttonReferences.Size = new System.Drawing.Size(259, 82);
            this.buttonReferences.TabIndex = 16;
            this.buttonReferences.Text = "Справки";
            this.buttonReferences.UseVisualStyleBackColor = false;
            this.buttonReferences.Click += new System.EventHandler(this.buttonReferences_Click);
            // 
            // buttonInsertData
            // 
            this.buttonInsertData.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(50)))), ((int)(((byte)(80)))), ((int)(((byte)(40)))));
            this.buttonInsertData.FlatAppearance.BorderSize = 0;
            this.buttonInsertData.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonInsertData.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.buttonInsertData.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.buttonInsertData.Location = new System.Drawing.Point(622, 68);
            this.buttonInsertData.Name = "buttonInsertData";
            this.buttonInsertData.Size = new System.Drawing.Size(259, 82);
            this.buttonInsertData.TabIndex = 17;
            this.buttonInsertData.Text = "Въвеждане на данни";
            this.buttonInsertData.UseVisualStyleBackColor = false;
            this.buttonInsertData.Click += new System.EventHandler(this.buttonInsertData_Click);
            // 
            // MenuUserControl
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(96F, 96F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Dpi;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(170)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.Controls.Add(this.buttonInsertData);
            this.Controls.Add(this.buttonReferences);
            this.Font = new System.Drawing.Font("Arial", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.Name = "MenuUserControl";
            this.Size = new System.Drawing.Size(1081, 218);
            this.ResumeLayout(false);

        }

        #endregion

        protected System.Windows.Forms.Button buttonReferences;
        protected System.Windows.Forms.Button buttonInsertData;
    }
}
