
namespace GraduationProject.UserControls
{
    partial class InsertedDataDisplay
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
            this.labelData = new System.Windows.Forms.Label();
            this.panelData = new System.Windows.Forms.Panel();
            this.panelData.SuspendLayout();
            this.SuspendLayout();
            // 
            // labelTitle
            // 
            this.labelTitle.AutoSize = true;
            this.labelTitle.BackColor = System.Drawing.Color.Transparent;
            this.labelTitle.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.labelTitle.Location = new System.Drawing.Point(12, 14);
            this.labelTitle.Name = "labelTitle";
            this.labelTitle.Size = new System.Drawing.Size(150, 19);
            this.labelTitle.TabIndex = 0;
            this.labelTitle.Text = "Въведени данни:";
            // 
            // labelData
            // 
            this.labelData.AutoSize = true;
            this.labelData.BackColor = System.Drawing.Color.Transparent;
            this.labelData.Dock = System.Windows.Forms.DockStyle.Top;
            this.labelData.Font = new System.Drawing.Font("Arial Narrow", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.labelData.Location = new System.Drawing.Point(0, 0);
            this.labelData.Name = "labelData";
            this.labelData.Size = new System.Drawing.Size(0, 20);
            this.labelData.TabIndex = 1;
            // 
            // panelData
            // 
            this.panelData.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.panelData.AutoScroll = true;
            this.panelData.BackColor = System.Drawing.Color.Transparent;
            this.panelData.Controls.Add(this.labelData);
            this.panelData.Location = new System.Drawing.Point(12, 45);
            this.panelData.Name = "panelData";
            this.panelData.Size = new System.Drawing.Size(291, 158);
            this.panelData.TabIndex = 2;
            // 
            // InsertedDataDisplay
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(96F, 96F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Dpi;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(170)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.Controls.Add(this.panelData);
            this.Controls.Add(this.labelTitle);
            this.Font = new System.Drawing.Font("Arial Narrow", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.Name = "InsertedDataDisplay";
            this.Size = new System.Drawing.Size(303, 203);
            this.panelData.ResumeLayout(false);
            this.panelData.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label labelTitle;
        private System.Windows.Forms.Label labelData;
        private System.Windows.Forms.Panel panelData;
    }
}
