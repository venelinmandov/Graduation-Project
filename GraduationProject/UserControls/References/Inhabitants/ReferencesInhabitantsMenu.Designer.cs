
namespace GraduationProject.UserControls.References
{
    partial class ReferencesInhabitantsMenu
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
            this.buttonResidenceStatus = new System.Windows.Forms.Button();
            this.buttonPropetyStatus = new System.Windows.Forms.Button();
            this.buttonByAddrReg = new System.Windows.Forms.Button();
            this.buttonByName = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // labelTitle
            // 
            this.labelTitle.AutoSize = true;
            this.labelTitle.BackColor = System.Drawing.Color.Transparent;
            this.labelTitle.Font = new System.Drawing.Font("Arial", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.labelTitle.Location = new System.Drawing.Point(479, 33);
            this.labelTitle.Name = "labelTitle";
            this.labelTitle.Size = new System.Drawing.Size(97, 27);
            this.labelTitle.TabIndex = 13;
            this.labelTitle.Text = "Жители";
            // 
            // labelSearchBy
            // 
            this.labelSearchBy.AutoSize = true;
            this.labelSearchBy.BackColor = System.Drawing.Color.Transparent;
            this.labelSearchBy.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.labelSearchBy.Location = new System.Drawing.Point(490, 85);
            this.labelSearchBy.Name = "labelSearchBy";
            this.labelSearchBy.Size = new System.Drawing.Size(77, 18);
            this.labelSearchBy.TabIndex = 14;
            this.labelSearchBy.Text = "Търси по:";
            // 
            // buttonResidenceStatus
            // 
            this.buttonResidenceStatus.Location = new System.Drawing.Point(550, 233);
            this.buttonResidenceStatus.Name = "buttonResidenceStatus";
            this.buttonResidenceStatus.Size = new System.Drawing.Size(179, 60);
            this.buttonResidenceStatus.TabIndex = 18;
            this.buttonResidenceStatus.Text = "Статус на пребиваване";
            this.buttonResidenceStatus.UseVisualStyleBackColor = true;
            // 
            // buttonPropetyStatus
            // 
            this.buttonPropetyStatus.Location = new System.Drawing.Point(335, 233);
            this.buttonPropetyStatus.Name = "buttonPropetyStatus";
            this.buttonPropetyStatus.Size = new System.Drawing.Size(179, 60);
            this.buttonPropetyStatus.TabIndex = 17;
            this.buttonPropetyStatus.Text = "Статус на собственост";
            this.buttonPropetyStatus.UseVisualStyleBackColor = true;
            // 
            // buttonByAddrReg
            // 
            this.buttonByAddrReg.Location = new System.Drawing.Point(550, 128);
            this.buttonByAddrReg.Name = "buttonByAddrReg";
            this.buttonByAddrReg.Size = new System.Drawing.Size(179, 60);
            this.buttonByAddrReg.TabIndex = 16;
            this.buttonByAddrReg.Text = "Адресна регистрация";
            this.buttonByAddrReg.UseVisualStyleBackColor = true;
            // 
            // buttonByName
            // 
            this.buttonByName.Location = new System.Drawing.Point(335, 128);
            this.buttonByName.Name = "buttonByName";
            this.buttonByName.Size = new System.Drawing.Size(179, 60);
            this.buttonByName.TabIndex = 15;
            this.buttonByName.Text = "Име";
            this.buttonByName.UseVisualStyleBackColor = true;
            this.buttonByName.Click += new System.EventHandler(this.buttonByName_Click);
            // 
            // ReferencesInhabitantsMenu
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(170)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.Controls.Add(this.buttonResidenceStatus);
            this.Controls.Add(this.buttonPropetyStatus);
            this.Controls.Add(this.buttonByAddrReg);
            this.Controls.Add(this.buttonByName);
            this.Controls.Add(this.labelSearchBy);
            this.Controls.Add(this.labelTitle);
            this.Font = new System.Drawing.Font("Arial", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.Name = "ReferencesInhabitantsMenu";
            this.Size = new System.Drawing.Size(1081, 329);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        protected System.Windows.Forms.Label labelTitle;
        protected System.Windows.Forms.Label labelSearchBy;
        protected System.Windows.Forms.Button buttonResidenceStatus;
        protected System.Windows.Forms.Button buttonPropetyStatus;
        protected System.Windows.Forms.Button buttonByAddrReg;
        protected System.Windows.Forms.Button buttonByName;
    }
}
