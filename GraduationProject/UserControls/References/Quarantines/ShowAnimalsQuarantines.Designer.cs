
namespace GraduationProject.UserControls.References.Quarantines
{
    partial class ShowAnimalsQuarantines
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
            this.labelAddress = new System.Windows.Forms.Label();
            this.labelQuarantinedNumber = new System.Windows.Forms.Label();
            this.panel = new System.Windows.Forms.Panel();
            this.SuspendLayout();
            // 
            // labelAddress
            // 
            this.labelAddress.BackColor = System.Drawing.Color.Transparent;
            this.labelAddress.Font = new System.Drawing.Font("Arial", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.labelAddress.Location = new System.Drawing.Point(21, 20);
            this.labelAddress.Name = "labelAddress";
            this.labelAddress.Size = new System.Drawing.Size(1038, 32);
            this.labelAddress.TabIndex = 6;
            this.labelAddress.Text = "Адрес";
            this.labelAddress.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // labelQuarantinedNumber
            // 
            this.labelQuarantinedNumber.BackColor = System.Drawing.Color.Transparent;
            this.labelQuarantinedNumber.Font = new System.Drawing.Font("Arial", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.labelQuarantinedNumber.Location = new System.Drawing.Point(21, 69);
            this.labelQuarantinedNumber.Name = "labelQuarantinedNumber";
            this.labelQuarantinedNumber.Size = new System.Drawing.Size(1038, 32);
            this.labelQuarantinedNumber.TabIndex = 7;
            this.labelQuarantinedNumber.Text = "На адреса има карантини на:";
            this.labelQuarantinedNumber.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.labelQuarantinedNumber.Click += new System.EventHandler(this.labelQuarantinedNumber_Click);
            // 
            // panel
            // 
            this.panel.AutoScroll = true;
            this.panel.BackColor = System.Drawing.Color.Transparent;
            this.panel.Location = new System.Drawing.Point(65, 118);
            this.panel.Name = "panel";
            this.panel.Size = new System.Drawing.Size(950, 189);
            this.panel.TabIndex = 8;
            // 
            // ShowAnimalsQuarantines
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(96F, 96F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Dpi;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(220)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.Controls.Add(this.panel);
            this.Controls.Add(this.labelQuarantinedNumber);
            this.Controls.Add(this.labelAddress);
            this.Font = new System.Drawing.Font("Arial", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.Name = "ShowAnimalsQuarantines";
            this.Size = new System.Drawing.Size(1081, 329);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Label labelAddress;
        private System.Windows.Forms.Label labelQuarantinedNumber;
        private System.Windows.Forms.Panel panel;
    }
}
