
namespace GraduationProject.UserControls.InsertData.Streets
{
    partial class InsertDataStreets
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
            this.listBoxStreets = new GraduationProject.UserControls.ListBoxUserControl();
            this.buttonShowInsertStreet = new System.Windows.Forms.Button();
            this.buttonShowRenameStreet = new System.Windows.Forms.Button();
            this.buttonDeleteStreet = new System.Windows.Forms.Button();
            this.panelShowStreets = new System.Windows.Forms.Panel();
            this.panelInsertStreet = new System.Windows.Forms.Panel();
            this.buttonInsertCancel = new System.Windows.Forms.Button();
            this.labelErrorInsert = new System.Windows.Forms.Label();
            this.labelStreetName = new System.Windows.Forms.Label();
            this.labelTitleAddstreet = new System.Windows.Forms.Label();
            this.textBoxStreetInsert = new System.Windows.Forms.TextBox();
            this.buttonInsertStreet = new System.Windows.Forms.Button();
            this.panelRenameStreet = new System.Windows.Forms.Panel();
            this.buttonRenameCancel = new System.Windows.Forms.Button();
            this.labelErrorRename = new System.Windows.Forms.Label();
            this.labelRenameStreet = new System.Windows.Forms.Label();
            this.labelTitleRenameStreet = new System.Windows.Forms.Label();
            this.textBoxStreetRename = new System.Windows.Forms.TextBox();
            this.buttonUpdateStreet = new System.Windows.Forms.Button();
            this.panelShowStreets.SuspendLayout();
            this.panelInsertStreet.SuspendLayout();
            this.panelRenameStreet.SuspendLayout();
            this.SuspendLayout();
            // 
            // labelTitle
            // 
            this.labelTitle.BackColor = System.Drawing.Color.Transparent;
            this.labelTitle.Font = new System.Drawing.Font("Arial", 21.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.labelTitle.Location = new System.Drawing.Point(209, 14);
            this.labelTitle.Name = "labelTitle";
            this.labelTitle.Size = new System.Drawing.Size(663, 33);
            this.labelTitle.TabIndex = 16;
            this.labelTitle.Text = "Улици";
            this.labelTitle.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // listBoxStreets
            // 
            this.listBoxStreets.AutoScroll = true;
            this.listBoxStreets.Font = new System.Drawing.Font("Arial", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.listBoxStreets.ItemBorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(170)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.listBoxStreets.ItemsColor = System.Drawing.Color.FromArgb(((int)(((byte)(170)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.listBoxStreets.ItemTextAlignment = System.Drawing.ContentAlignment.MiddleLeft;
            this.listBoxStreets.Location = new System.Drawing.Point(36, 31);
            this.listBoxStreets.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.listBoxStreets.Name = "listBoxStreets";
            this.listBoxStreets.SelectedIndex = -1;
            this.listBoxStreets.SelectedItemColor = System.Drawing.Color.FromArgb(((int)(((byte)(53)))), ((int)(((byte)(70)))), ((int)(((byte)(38)))));
            this.listBoxStreets.SelectedItemForeColor = System.Drawing.SystemColors.Control;
            this.listBoxStreets.Size = new System.Drawing.Size(534, 167);
            this.listBoxStreets.TabIndex = 17;
            // 
            // buttonShowInsertStreet
            // 
            this.buttonShowInsertStreet.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(53)))), ((int)(((byte)(70)))), ((int)(((byte)(38)))));
            this.buttonShowInsertStreet.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonShowInsertStreet.ForeColor = System.Drawing.SystemColors.Control;
            this.buttonShowInsertStreet.Location = new System.Drawing.Point(53, 220);
            this.buttonShowInsertStreet.Name = "buttonShowInsertStreet";
            this.buttonShowInsertStreet.Size = new System.Drawing.Size(155, 23);
            this.buttonShowInsertStreet.TabIndex = 22;
            this.buttonShowInsertStreet.Text = "Добави улица";
            this.buttonShowInsertStreet.UseVisualStyleBackColor = false;
            this.buttonShowInsertStreet.Click += new System.EventHandler(this.buttonShowInsertStreet_Click);
            // 
            // buttonShowRenameStreet
            // 
            this.buttonShowRenameStreet.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(53)))), ((int)(((byte)(70)))), ((int)(((byte)(38)))));
            this.buttonShowRenameStreet.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonShowRenameStreet.ForeColor = System.Drawing.SystemColors.Control;
            this.buttonShowRenameStreet.Location = new System.Drawing.Point(224, 220);
            this.buttonShowRenameStreet.Name = "buttonShowRenameStreet";
            this.buttonShowRenameStreet.Size = new System.Drawing.Size(155, 23);
            this.buttonShowRenameStreet.TabIndex = 23;
            this.buttonShowRenameStreet.Text = "Преименувай улицата";
            this.buttonShowRenameStreet.UseVisualStyleBackColor = false;
            this.buttonShowRenameStreet.Click += new System.EventHandler(this.buttonRenameStreet_Click);
            // 
            // buttonDeleteStreet
            // 
            this.buttonDeleteStreet.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(53)))), ((int)(((byte)(70)))), ((int)(((byte)(38)))));
            this.buttonDeleteStreet.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonDeleteStreet.ForeColor = System.Drawing.SystemColors.Control;
            this.buttonDeleteStreet.Location = new System.Drawing.Point(400, 220);
            this.buttonDeleteStreet.Name = "buttonDeleteStreet";
            this.buttonDeleteStreet.Size = new System.Drawing.Size(155, 23);
            this.buttonDeleteStreet.TabIndex = 24;
            this.buttonDeleteStreet.Text = "Изтрий улицата";
            this.buttonDeleteStreet.UseVisualStyleBackColor = false;
            this.buttonDeleteStreet.Click += new System.EventHandler(this.buttonDeleteStreet_Click);
            // 
            // panelShowStreets
            // 
            this.panelShowStreets.Controls.Add(this.listBoxStreets);
            this.panelShowStreets.Controls.Add(this.buttonDeleteStreet);
            this.panelShowStreets.Controls.Add(this.buttonShowRenameStreet);
            this.panelShowStreets.Controls.Add(this.buttonShowInsertStreet);
            this.panelShowStreets.Location = new System.Drawing.Point(249, 62);
            this.panelShowStreets.Name = "panelShowStreets";
            this.panelShowStreets.Size = new System.Drawing.Size(606, 253);
            this.panelShowStreets.TabIndex = 25;
            // 
            // panelInsertStreet
            // 
            this.panelInsertStreet.Controls.Add(this.buttonInsertCancel);
            this.panelInsertStreet.Controls.Add(this.labelErrorInsert);
            this.panelInsertStreet.Controls.Add(this.labelStreetName);
            this.panelInsertStreet.Controls.Add(this.labelTitleAddstreet);
            this.panelInsertStreet.Controls.Add(this.textBoxStreetInsert);
            this.panelInsertStreet.Controls.Add(this.buttonInsertStreet);
            this.panelInsertStreet.Location = new System.Drawing.Point(249, 62);
            this.panelInsertStreet.Name = "panelInsertStreet";
            this.panelInsertStreet.Size = new System.Drawing.Size(606, 253);
            this.panelInsertStreet.TabIndex = 26;
            // 
            // buttonInsertCancel
            // 
            this.buttonInsertCancel.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(53)))), ((int)(((byte)(70)))), ((int)(((byte)(38)))));
            this.buttonInsertCancel.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonInsertCancel.ForeColor = System.Drawing.SystemColors.Control;
            this.buttonInsertCancel.Location = new System.Drawing.Point(326, 202);
            this.buttonInsertCancel.Name = "buttonInsertCancel";
            this.buttonInsertCancel.Size = new System.Drawing.Size(155, 23);
            this.buttonInsertCancel.TabIndex = 29;
            this.buttonInsertCancel.Text = "Отказ";
            this.buttonInsertCancel.UseVisualStyleBackColor = false;
            this.buttonInsertCancel.Click += new System.EventHandler(this.buttonInsertCancel_Click);
            // 
            // labelErrorInsert
            // 
            this.labelErrorInsert.BackColor = System.Drawing.Color.Transparent;
            this.labelErrorInsert.Font = new System.Drawing.Font("Arial", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.labelErrorInsert.Location = new System.Drawing.Point(201, 170);
            this.labelErrorInsert.Name = "labelErrorInsert";
            this.labelErrorInsert.Size = new System.Drawing.Size(206, 15);
            this.labelErrorInsert.TabIndex = 28;
            this.labelErrorInsert.Text = "Грешка";
            this.labelErrorInsert.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // labelStreetName
            // 
            this.labelStreetName.AutoSize = true;
            this.labelStreetName.BackColor = System.Drawing.Color.Transparent;
            this.labelStreetName.Font = new System.Drawing.Font("Arial", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.labelStreetName.Location = new System.Drawing.Point(226, 119);
            this.labelStreetName.Name = "labelStreetName";
            this.labelStreetName.Size = new System.Drawing.Size(153, 15);
            this.labelStreetName.TabIndex = 27;
            this.labelStreetName.Text = "Въведете име на улицата";
            // 
            // labelTitleAddstreet
            // 
            this.labelTitleAddstreet.AutoSize = true;
            this.labelTitleAddstreet.BackColor = System.Drawing.Color.Transparent;
            this.labelTitleAddstreet.Font = new System.Drawing.Font("Arial", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.labelTitleAddstreet.Location = new System.Drawing.Point(204, 47);
            this.labelTitleAddstreet.Name = "labelTitleAddstreet";
            this.labelTitleAddstreet.Size = new System.Drawing.Size(197, 24);
            this.labelTitleAddstreet.TabIndex = 26;
            this.labelTitleAddstreet.Text = "Добавяне на улица";
            // 
            // textBoxStreetInsert
            // 
            this.textBoxStreetInsert.Location = new System.Drawing.Point(200, 137);
            this.textBoxStreetInsert.Name = "textBoxStreetInsert";
            this.textBoxStreetInsert.Size = new System.Drawing.Size(206, 21);
            this.textBoxStreetInsert.TabIndex = 25;
            // 
            // buttonInsertStreet
            // 
            this.buttonInsertStreet.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(53)))), ((int)(((byte)(70)))), ((int)(((byte)(38)))));
            this.buttonInsertStreet.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonInsertStreet.ForeColor = System.Drawing.SystemColors.Control;
            this.buttonInsertStreet.Location = new System.Drawing.Point(124, 202);
            this.buttonInsertStreet.Name = "buttonInsertStreet";
            this.buttonInsertStreet.Size = new System.Drawing.Size(155, 23);
            this.buttonInsertStreet.TabIndex = 23;
            this.buttonInsertStreet.Text = "Въведи";
            this.buttonInsertStreet.UseVisualStyleBackColor = false;
            this.buttonInsertStreet.Click += new System.EventHandler(this.buttonInsertStreet_Click);
            // 
            // panelRenameStreet
            // 
            this.panelRenameStreet.Controls.Add(this.buttonRenameCancel);
            this.panelRenameStreet.Controls.Add(this.labelErrorRename);
            this.panelRenameStreet.Controls.Add(this.labelRenameStreet);
            this.panelRenameStreet.Controls.Add(this.labelTitleRenameStreet);
            this.panelRenameStreet.Controls.Add(this.textBoxStreetRename);
            this.panelRenameStreet.Controls.Add(this.buttonUpdateStreet);
            this.panelRenameStreet.Location = new System.Drawing.Point(249, 62);
            this.panelRenameStreet.Name = "panelRenameStreet";
            this.panelRenameStreet.Size = new System.Drawing.Size(606, 253);
            this.panelRenameStreet.TabIndex = 28;
            // 
            // buttonRenameCancel
            // 
            this.buttonRenameCancel.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(53)))), ((int)(((byte)(70)))), ((int)(((byte)(38)))));
            this.buttonRenameCancel.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonRenameCancel.ForeColor = System.Drawing.SystemColors.Control;
            this.buttonRenameCancel.Location = new System.Drawing.Point(326, 202);
            this.buttonRenameCancel.Name = "buttonRenameCancel";
            this.buttonRenameCancel.Size = new System.Drawing.Size(155, 23);
            this.buttonRenameCancel.TabIndex = 30;
            this.buttonRenameCancel.Text = "Отказ";
            this.buttonRenameCancel.UseVisualStyleBackColor = false;
            this.buttonRenameCancel.Click += new System.EventHandler(this.buttonRenameCancel_Click);
            // 
            // labelErrorRename
            // 
            this.labelErrorRename.BackColor = System.Drawing.Color.Transparent;
            this.labelErrorRename.Font = new System.Drawing.Font("Arial", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.labelErrorRename.Location = new System.Drawing.Point(201, 170);
            this.labelErrorRename.Name = "labelErrorRename";
            this.labelErrorRename.Size = new System.Drawing.Size(206, 15);
            this.labelErrorRename.TabIndex = 29;
            this.labelErrorRename.Text = "Грешка";
            this.labelErrorRename.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // labelRenameStreet
            // 
            this.labelRenameStreet.AutoSize = true;
            this.labelRenameStreet.BackColor = System.Drawing.Color.Transparent;
            this.labelRenameStreet.Font = new System.Drawing.Font("Arial", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.labelRenameStreet.Location = new System.Drawing.Point(226, 119);
            this.labelRenameStreet.Name = "labelRenameStreet";
            this.labelRenameStreet.Size = new System.Drawing.Size(153, 15);
            this.labelRenameStreet.TabIndex = 27;
            this.labelRenameStreet.Text = "Въведете име на улицата";
            // 
            // labelTitleRenameStreet
            // 
            this.labelTitleRenameStreet.BackColor = System.Drawing.Color.Transparent;
            this.labelTitleRenameStreet.Font = new System.Drawing.Font("Arial", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.labelTitleRenameStreet.Location = new System.Drawing.Point(22, 47);
            this.labelTitleRenameStreet.Name = "labelTitleRenameStreet";
            this.labelTitleRenameStreet.Size = new System.Drawing.Size(562, 24);
            this.labelTitleRenameStreet.TabIndex = 26;
            this.labelTitleRenameStreet.Text = "Преименуване на на улица";
            this.labelTitleRenameStreet.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // textBoxStreetRename
            // 
            this.textBoxStreetRename.Location = new System.Drawing.Point(200, 137);
            this.textBoxStreetRename.Name = "textBoxStreetRename";
            this.textBoxStreetRename.Size = new System.Drawing.Size(206, 21);
            this.textBoxStreetRename.TabIndex = 25;
            // 
            // buttonUpdateStreet
            // 
            this.buttonUpdateStreet.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(53)))), ((int)(((byte)(70)))), ((int)(((byte)(38)))));
            this.buttonUpdateStreet.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonUpdateStreet.ForeColor = System.Drawing.SystemColors.Control;
            this.buttonUpdateStreet.Location = new System.Drawing.Point(124, 202);
            this.buttonUpdateStreet.Name = "buttonUpdateStreet";
            this.buttonUpdateStreet.Size = new System.Drawing.Size(155, 23);
            this.buttonUpdateStreet.TabIndex = 23;
            this.buttonUpdateStreet.Text = "Преименувай";
            this.buttonUpdateStreet.UseVisualStyleBackColor = false;
            this.buttonUpdateStreet.Click += new System.EventHandler(this.buttonUpdateStreet_Click);
            // 
            // InsertDataStreets
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(170)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.Controls.Add(this.panelShowStreets);
            this.Controls.Add(this.panelRenameStreet);
            this.Controls.Add(this.panelInsertStreet);
            this.Controls.Add(this.labelTitle);
            this.Font = new System.Drawing.Font("Arial", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.Name = "InsertDataStreets";
            this.Size = new System.Drawing.Size(1081, 329);
            this.panelShowStreets.ResumeLayout(false);
            this.panelInsertStreet.ResumeLayout(false);
            this.panelInsertStreet.PerformLayout();
            this.panelRenameStreet.ResumeLayout(false);
            this.panelRenameStreet.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        protected System.Windows.Forms.Label labelTitle;
        private ListBoxUserControl listBoxStreets;
        private System.Windows.Forms.Button buttonShowInsertStreet;
        private System.Windows.Forms.Button buttonShowRenameStreet;
        private System.Windows.Forms.Button buttonDeleteStreet;
        private System.Windows.Forms.Panel panelShowStreets;
        private System.Windows.Forms.Panel panelInsertStreet;
        private System.Windows.Forms.Label labelStreetName;
        private System.Windows.Forms.Label labelTitleAddstreet;
        private System.Windows.Forms.TextBox textBoxStreetInsert;
        private System.Windows.Forms.Button buttonInsertStreet;
        private System.Windows.Forms.Panel panelRenameStreet;
        private System.Windows.Forms.Label labelRenameStreet;
        private System.Windows.Forms.Label labelTitleRenameStreet;
        private System.Windows.Forms.TextBox textBoxStreetRename;
        private System.Windows.Forms.Button buttonUpdateStreet;
        private System.Windows.Forms.Label labelErrorInsert;
        private System.Windows.Forms.Label labelErrorRename;
        private System.Windows.Forms.Button buttonRenameCancel;
        private System.Windows.Forms.Button buttonInsertCancel;
    }
}
