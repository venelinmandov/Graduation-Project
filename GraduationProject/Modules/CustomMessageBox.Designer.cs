
namespace GraduationProject.Modules
{
    partial class CustomMessageBox
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

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.buttonYes = new System.Windows.Forms.Button();
            this.buttonNo = new System.Windows.Forms.Button();
            this.labelText = new System.Windows.Forms.Label();
            this.buttonOK = new System.Windows.Forms.Button();
            this.pictureBoxIcon = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxIcon)).BeginInit();
            this.SuspendLayout();
            // 
            // buttonYes
            // 
            this.buttonYes.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.buttonYes.Location = new System.Drawing.Point(9, 76);
            this.buttonYes.Name = "buttonYes";
            this.buttonYes.Size = new System.Drawing.Size(75, 23);
            this.buttonYes.TabIndex = 0;
            this.buttonYes.Text = "Да";
            this.buttonYes.UseVisualStyleBackColor = true;
            this.buttonYes.Click += new System.EventHandler(this.buttonYes_Click);
            // 
            // buttonNo
            // 
            this.buttonNo.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.buttonNo.Location = new System.Drawing.Point(99, 76);
            this.buttonNo.Name = "buttonNo";
            this.buttonNo.Size = new System.Drawing.Size(75, 23);
            this.buttonNo.TabIndex = 1;
            this.buttonNo.Text = "Не";
            this.buttonNo.UseVisualStyleBackColor = true;
            this.buttonNo.Click += new System.EventHandler(this.buttonNo_Click);
            // 
            // labelText
            // 
            this.labelText.AutoSize = true;
            this.labelText.Location = new System.Drawing.Point(65, 37);
            this.labelText.MaximumSize = new System.Drawing.Size(357, 44);
            this.labelText.Name = "labelText";
            this.labelText.Size = new System.Drawing.Size(53, 15);
            this.labelText.TabIndex = 2;
            this.labelText.Text = "labelText";
            // 
            // buttonOK
            // 
            this.buttonOK.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.buttonOK.Location = new System.Drawing.Point(99, 76);
            this.buttonOK.Name = "buttonOK";
            this.buttonOK.Size = new System.Drawing.Size(75, 23);
            this.buttonOK.TabIndex = 3;
            this.buttonOK.Text = "Добре";
            this.buttonOK.UseVisualStyleBackColor = true;
            this.buttonOK.Click += new System.EventHandler(this.buttonOK_Click);
            // 
            // pictureBoxIcon
            // 
            this.pictureBoxIcon.Location = new System.Drawing.Point(16, 23);
            this.pictureBoxIcon.Name = "pictureBoxIcon";
            this.pictureBoxIcon.Size = new System.Drawing.Size(38, 37);
            this.pictureBoxIcon.TabIndex = 4;
            this.pictureBoxIcon.TabStop = false;
            // 
            // CustomMessageBox
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(96F, 96F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Dpi;
            this.AutoSize = true;
            this.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.ClientSize = new System.Drawing.Size(191, 116);
            this.ControlBox = false;
            this.Controls.Add(this.pictureBoxIcon);
            this.Controls.Add(this.buttonOK);
            this.Controls.Add(this.labelText);
            this.Controls.Add(this.buttonNo);
            this.Controls.Add(this.buttonYes);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.MaximizeBox = false;
            this.Name = "CustomMessageBox";
            this.Padding = new System.Windows.Forms.Padding(5);
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "CustomMessageBox";
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxIcon)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button buttonYes;
        private System.Windows.Forms.Button buttonNo;
        private System.Windows.Forms.Label labelText;
        private System.Windows.Forms.Button buttonOK;
        private System.Windows.Forms.PictureBox pictureBoxIcon;
    }
}