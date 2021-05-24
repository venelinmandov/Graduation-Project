
namespace GraduationProject.UserControls.References.Inhabitants
{
    partial class ReferencesInhabitantsSearchByName
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
            this.textBoxFirstname = new System.Windows.Forms.TextBox();
            this.labelName = new System.Windows.Forms.Label();
            this.labelMiddlename = new System.Windows.Forms.Label();
            this.textBoxMiddlename = new System.Windows.Forms.TextBox();
            this.labelLastname = new System.Windows.Forms.Label();
            this.textBoxLastname = new System.Windows.Forms.TextBox();
            this.panel1 = new System.Windows.Forms.Panel();
            this.buttonShow = new System.Windows.Forms.Button();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // textBoxFirstname
            // 
            this.textBoxFirstname.Location = new System.Drawing.Point(68, 42);
            this.textBoxFirstname.Name = "textBoxFirstname";
            this.textBoxFirstname.Size = new System.Drawing.Size(251, 21);
            this.textBoxFirstname.TabIndex = 0;
            // 
            // labelName
            // 
            this.labelName.AutoSize = true;
            this.labelName.BackColor = System.Drawing.Color.Transparent;
            this.labelName.Location = new System.Drawing.Point(68, 24);
            this.labelName.Name = "labelName";
            this.labelName.Size = new System.Drawing.Size(35, 15);
            this.labelName.TabIndex = 1;
            this.labelName.Text = "Име:";
            // 
            // labelMiddlename
            // 
            this.labelMiddlename.AutoSize = true;
            this.labelMiddlename.BackColor = System.Drawing.Color.Transparent;
            this.labelMiddlename.Location = new System.Drawing.Point(68, 76);
            this.labelMiddlename.Name = "labelMiddlename";
            this.labelMiddlename.Size = new System.Drawing.Size(62, 15);
            this.labelMiddlename.TabIndex = 3;
            this.labelMiddlename.Text = "Презиме:";
            // 
            // textBoxMiddlename
            // 
            this.textBoxMiddlename.Location = new System.Drawing.Point(68, 94);
            this.textBoxMiddlename.Name = "textBoxMiddlename";
            this.textBoxMiddlename.Size = new System.Drawing.Size(251, 21);
            this.textBoxMiddlename.TabIndex = 2;
            // 
            // labelLastname
            // 
            this.labelLastname.AutoSize = true;
            this.labelLastname.BackColor = System.Drawing.Color.Transparent;
            this.labelLastname.Location = new System.Drawing.Point(68, 133);
            this.labelLastname.Name = "labelLastname";
            this.labelLastname.Size = new System.Drawing.Size(63, 15);
            this.labelLastname.TabIndex = 5;
            this.labelLastname.Text = "Фамилия:";
            // 
            // textBoxLastname
            // 
            this.textBoxLastname.Location = new System.Drawing.Point(68, 151);
            this.textBoxLastname.Name = "textBoxLastname";
            this.textBoxLastname.Size = new System.Drawing.Size(251, 21);
            this.textBoxLastname.TabIndex = 4;
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.buttonShow);
            this.panel1.Controls.Add(this.textBoxFirstname);
            this.panel1.Controls.Add(this.labelLastname);
            this.panel1.Controls.Add(this.labelName);
            this.panel1.Controls.Add(this.textBoxLastname);
            this.panel1.Controls.Add(this.textBoxMiddlename);
            this.panel1.Controls.Add(this.labelMiddlename);
            this.panel1.Location = new System.Drawing.Point(324, 46);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(389, 242);
            this.panel1.TabIndex = 6;
            // 
            // buttonShow
            // 
            this.buttonShow.FlatAppearance.BorderSize = 0;
            this.buttonShow.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonShow.Location = new System.Drawing.Point(68, 195);
            this.buttonShow.Name = "buttonShow";
            this.buttonShow.Size = new System.Drawing.Size(75, 23);
            this.buttonShow.TabIndex = 6;
            this.buttonShow.Text = "Покажи";
            this.buttonShow.UseVisualStyleBackColor = true;
            this.buttonShow.Click += new System.EventHandler(this.buttonShow_Click);
            // 
            // ReferencesInhabitantsSearchByName
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(96F, 96F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Dpi;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(170)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.Controls.Add(this.panel1);
            this.Font = new System.Drawing.Font("Arial", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.Name = "ReferencesInhabitantsSearchByName";
            this.Size = new System.Drawing.Size(1081, 329);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TextBox textBoxFirstname;
        private System.Windows.Forms.Label labelName;
        private System.Windows.Forms.Label labelMiddlename;
        private System.Windows.Forms.TextBox textBoxMiddlename;
        private System.Windows.Forms.Label labelLastname;
        private System.Windows.Forms.TextBox textBoxLastname;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Button buttonShow;
    }
}
