
namespace GraduationProject.Forms
{
    partial class StreetsForm
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
            this.listBoxStreets = new System.Windows.Forms.ListBox();
            this.titleLabelStr = new GraduationProject.Controls.TitleLabel();
            this.buttonAddSt = new System.Windows.Forms.Button();
            this.buttonRemoveSt = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // listBoxStreets
            // 
            this.listBoxStreets.FormattingEnabled = true;
            this.listBoxStreets.ItemHeight = 15;
            this.listBoxStreets.Location = new System.Drawing.Point(12, 58);
            this.listBoxStreets.Name = "listBoxStreets";
            this.listBoxStreets.Size = new System.Drawing.Size(193, 259);
            this.listBoxStreets.TabIndex = 0;
            // 
            // titleLabelStr
            // 
            this.titleLabelStr.LabelText = "Улици";
            this.titleLabelStr.Location = new System.Drawing.Point(12, 11);
            this.titleLabelStr.Name = "titleLabelStr";
            this.titleLabelStr.Size = new System.Drawing.Size(104, 39);
            this.titleLabelStr.TabIndex = 1;
            // 
            // buttonAddSt
            // 
            this.buttonAddSt.Location = new System.Drawing.Point(12, 332);
            this.buttonAddSt.Name = "buttonAddSt";
            this.buttonAddSt.Size = new System.Drawing.Size(88, 25);
            this.buttonAddSt.TabIndex = 3;
            this.buttonAddSt.Text = "Добави";
            this.buttonAddSt.UseVisualStyleBackColor = true;
            this.buttonAddSt.Click += new System.EventHandler(this.buttonAddSt_Click);
            // 
            // buttonRemoveSt
            // 
            this.buttonRemoveSt.Location = new System.Drawing.Point(117, 332);
            this.buttonRemoveSt.Name = "buttonRemoveSt";
            this.buttonRemoveSt.Size = new System.Drawing.Size(88, 25);
            this.buttonRemoveSt.TabIndex = 4;
            this.buttonRemoveSt.Text = "Премахни";
            this.buttonRemoveSt.UseVisualStyleBackColor = true;
            this.buttonRemoveSt.Click += new System.EventHandler(this.buttonRemoveSt_Click);
            // 
            // StreetsForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(222, 373);
            this.Controls.Add(this.buttonRemoveSt);
            this.Controls.Add(this.buttonAddSt);
            this.Controls.Add(this.titleLabelStr);
            this.Controls.Add(this.listBoxStreets);
            this.Name = "StreetsForm";
            this.Text = "StreetsForm";
            this.Load += new System.EventHandler(this.AddressForm_Load);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.ListBox listBoxStreets;
        private Controls.TitleLabel titleLabelcs1;
        private Controls.TitleLabel titleLabelcs2;
        private Controls.TitleLabel titleLabelcs3;
        private Controls.TitleLabel titleLabelStr;
        private System.Windows.Forms.Button buttonAddSt;
        private System.Windows.Forms.Button buttonRemoveSt;
    }
}