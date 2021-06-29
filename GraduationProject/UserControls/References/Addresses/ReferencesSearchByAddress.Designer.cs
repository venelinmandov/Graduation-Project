
namespace GraduationProject.UserControls.References
{
    partial class ReferencesSearchByAddress
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(ReferencesSearchByAddress));
            this.labelTitle = new System.Windows.Forms.Label();
            this.comboBoxStreet = new System.Windows.Forms.ComboBox();
            this.comboBoxNumber = new System.Windows.Forms.ComboBox();
            this.labelStreet = new System.Windows.Forms.Label();
            this.labelNumber = new System.Windows.Forms.Label();
            this.buttonSearch = new System.Windows.Forms.Button();
            this.panel1 = new System.Windows.Forms.Panel();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // labelTitle
            // 
            this.labelTitle.AutoSize = true;
            this.labelTitle.BackColor = System.Drawing.Color.Transparent;
            this.labelTitle.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.labelTitle.Font = new System.Drawing.Font("Arial", 21.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.labelTitle.Location = new System.Drawing.Point(481, 37);
            this.labelTitle.Name = "labelTitle";
            this.labelTitle.Size = new System.Drawing.Size(114, 33);
            this.labelTitle.TabIndex = 0;
            this.labelTitle.Text = "Адреси";
            // 
            // comboBoxStreet
            // 
            this.comboBoxStreet.DrawMode = System.Windows.Forms.DrawMode.OwnerDrawFixed;
            this.comboBoxStreet.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboBoxStreet.FormattingEnabled = true;
            this.comboBoxStreet.Location = new System.Drawing.Point(46, 50);
            this.comboBoxStreet.Name = "comboBoxStreet";
            this.comboBoxStreet.Size = new System.Drawing.Size(192, 22);
            this.comboBoxStreet.TabIndex = 1;
            this.comboBoxStreet.DrawItem += new System.Windows.Forms.DrawItemEventHandler(this.comboBox_DrawItem);
            this.comboBoxStreet.SelectedIndexChanged += new System.EventHandler(this.comboBoxStreet_SelectedIndexChanged);
            // 
            // comboBoxNumber
            // 
            this.comboBoxNumber.DrawMode = System.Windows.Forms.DrawMode.OwnerDrawFixed;
            this.comboBoxNumber.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboBoxNumber.FormattingEnabled = true;
            this.comboBoxNumber.Location = new System.Drawing.Point(262, 50);
            this.comboBoxNumber.Name = "comboBoxNumber";
            this.comboBoxNumber.Size = new System.Drawing.Size(67, 22);
            this.comboBoxNumber.TabIndex = 2;
            this.comboBoxNumber.DrawItem += new System.Windows.Forms.DrawItemEventHandler(this.comboBox_DrawItem);
            // 
            // labelStreet
            // 
            this.labelStreet.AutoSize = true;
            this.labelStreet.BackColor = System.Drawing.Color.Transparent;
            this.labelStreet.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.labelStreet.Location = new System.Drawing.Point(46, 29);
            this.labelStreet.Name = "labelStreet";
            this.labelStreet.Size = new System.Drawing.Size(45, 15);
            this.labelStreet.TabIndex = 3;
            this.labelStreet.Text = "Улица:";
            // 
            // labelNumber
            // 
            this.labelNumber.AutoSize = true;
            this.labelNumber.BackColor = System.Drawing.Color.Transparent;
            this.labelNumber.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.labelNumber.Location = new System.Drawing.Point(262, 29);
            this.labelNumber.Name = "labelNumber";
            this.labelNumber.Size = new System.Drawing.Size(46, 15);
            this.labelNumber.TabIndex = 4;
            this.labelNumber.Text = "Номер";
            // 
            // buttonSearch
            // 
            this.buttonSearch.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.buttonSearch.FlatAppearance.BorderSize = 0;
            this.buttonSearch.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonSearch.Image = ((System.Drawing.Image)(resources.GetObject("buttonSearch.Image")));
            this.buttonSearch.Location = new System.Drawing.Point(46, 126);
            this.buttonSearch.Name = "buttonSearch";
            this.buttonSearch.Size = new System.Drawing.Size(87, 29);
            this.buttonSearch.TabIndex = 5;
            this.buttonSearch.Text = "Търсeне";
            this.buttonSearch.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.buttonSearch.UseVisualStyleBackColor = true;
            this.buttonSearch.Click += new System.EventHandler(this.buttonSearch_Click);
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.comboBoxStreet);
            this.panel1.Controls.Add(this.buttonSearch);
            this.panel1.Controls.Add(this.comboBoxNumber);
            this.panel1.Controls.Add(this.labelNumber);
            this.panel1.Controls.Add(this.labelStreet);
            this.panel1.Location = new System.Drawing.Point(353, 113);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(375, 172);
            this.panel1.TabIndex = 6;
            // 
            // ReferencesSearchByAddress
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(96F, 96F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Dpi;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(170)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.labelTitle);
            this.Font = new System.Drawing.Font("Arial", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.Name = "ReferencesSearchByAddress";
            this.Size = new System.Drawing.Size(1081, 329);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label labelTitle;
        private System.Windows.Forms.ComboBox comboBoxStreet;
        private System.Windows.Forms.ComboBox comboBoxNumber;
        private System.Windows.Forms.Label labelStreet;
        private System.Windows.Forms.Label labelNumber;
        private System.Windows.Forms.Button buttonSearch;
        private System.Windows.Forms.Panel panel1;
    }
}
