
namespace GraduationProject.Forms
{
    partial class ReferenceForm
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
            this.tabControl = new System.Windows.Forms.TabControl();
            this.tabAddresses = new System.Windows.Forms.TabPage();
            this.labelCriteriaAddresses = new System.Windows.Forms.Label();
            this.buttonSaveAddesses = new System.Windows.Forms.Button();
            this.buttonFiltersAddresses = new System.Windows.Forms.Button();
            this.dataGridViewAddresses = new System.Windows.Forms.DataGridView();
            this.InhabitantsButton = new System.Windows.Forms.DataGridViewButtonColumn();
            this.streetNameCol = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.streetNomberCol = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.squaringCol = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.habitabilityCol = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.resBuildingsCol = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.agrBuildingsCol = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.cowsCol = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.sheepCol = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.goatsCol = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.horsesCol = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.donkeysCol = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.fetheredCol = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.walnutTreesCol = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.tabInhabitants = new System.Windows.Forms.TabPage();
            this.labelCriteriaInhabitants = new System.Windows.Forms.Label();
            this.buttonSaveInhabitants = new System.Windows.Forms.Button();
            this.buttonFiltersInhabitants = new System.Windows.Forms.Button();
            this.dataGridViewInhabitants = new System.Windows.Forms.DataGridView();
            this.firstNameCol = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.middlenameCol = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.lastnameCol = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.genderCol = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.addressCol = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.currentAddressCol = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.relationToOwnerCol = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.GuestResidentCol = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.addRefCol = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.covidCol = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.notoCol = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.tabControl.SuspendLayout();
            this.tabAddresses.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewAddresses)).BeginInit();
            this.tabInhabitants.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewInhabitants)).BeginInit();
            this.SuspendLayout();
            // 
            // tabControl
            // 
            this.tabControl.Controls.Add(this.tabAddresses);
            this.tabControl.Controls.Add(this.tabInhabitants);
            this.tabControl.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tabControl.Location = new System.Drawing.Point(0, 0);
            this.tabControl.Name = "tabControl";
            this.tabControl.SelectedIndex = 0;
            this.tabControl.Size = new System.Drawing.Size(1308, 459);
            this.tabControl.TabIndex = 0;
            this.tabControl.SelectedIndexChanged += new System.EventHandler(this.AddressesTab_SelectedIndexChanged);
            // 
            // tabAddresses
            // 
            this.tabAddresses.Controls.Add(this.labelCriteriaAddresses);
            this.tabAddresses.Controls.Add(this.buttonSaveAddesses);
            this.tabAddresses.Controls.Add(this.buttonFiltersAddresses);
            this.tabAddresses.Controls.Add(this.dataGridViewAddresses);
            this.tabAddresses.Location = new System.Drawing.Point(4, 24);
            this.tabAddresses.Name = "tabAddresses";
            this.tabAddresses.Padding = new System.Windows.Forms.Padding(3);
            this.tabAddresses.Size = new System.Drawing.Size(1300, 431);
            this.tabAddresses.TabIndex = 0;
            this.tabAddresses.Text = "Адреси";
            this.tabAddresses.UseVisualStyleBackColor = true;
            // 
            // labelCriteriaAddresses
            // 
            this.labelCriteriaAddresses.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.labelCriteriaAddresses.AutoSize = true;
            this.labelCriteriaAddresses.Location = new System.Drawing.Point(3, 411);
            this.labelCriteriaAddresses.Name = "labelCriteriaAddresses";
            this.labelCriteriaAddresses.Size = new System.Drawing.Size(0, 15);
            this.labelCriteriaAddresses.TabIndex = 4;
            // 
            // buttonSaveAddesses
            // 
            this.buttonSaveAddesses.Location = new System.Drawing.Point(84, 7);
            this.buttonSaveAddesses.Name = "buttonSaveAddesses";
            this.buttonSaveAddesses.Size = new System.Drawing.Size(75, 23);
            this.buttonSaveAddesses.TabIndex = 2;
            this.buttonSaveAddesses.Text = "Експорт";
            this.buttonSaveAddesses.UseVisualStyleBackColor = true;
            // 
            // buttonFiltersAddresses
            // 
            this.buttonFiltersAddresses.Location = new System.Drawing.Point(3, 7);
            this.buttonFiltersAddresses.Name = "buttonFiltersAddresses";
            this.buttonFiltersAddresses.Size = new System.Drawing.Size(75, 23);
            this.buttonFiltersAddresses.TabIndex = 1;
            this.buttonFiltersAddresses.Text = "Филтри";
            this.buttonFiltersAddresses.UseVisualStyleBackColor = true;
            this.buttonFiltersAddresses.Click += new System.EventHandler(this.buttonFiltersAddresses_Click);
            // 
            // dataGridViewAddresses
            // 
            this.dataGridViewAddresses.AllowUserToAddRows = false;
            this.dataGridViewAddresses.AllowUserToDeleteRows = false;
            this.dataGridViewAddresses.AllowUserToResizeColumns = false;
            this.dataGridViewAddresses.AllowUserToResizeRows = false;
            this.dataGridViewAddresses.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.dataGridViewAddresses.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridViewAddresses.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.InhabitantsButton,
            this.streetNameCol,
            this.streetNomberCol,
            this.squaringCol,
            this.habitabilityCol,
            this.resBuildingsCol,
            this.agrBuildingsCol,
            this.cowsCol,
            this.sheepCol,
            this.goatsCol,
            this.horsesCol,
            this.donkeysCol,
            this.fetheredCol,
            this.walnutTreesCol});
            this.dataGridViewAddresses.Location = new System.Drawing.Point(3, 36);
            this.dataGridViewAddresses.Name = "dataGridViewAddresses";
            this.dataGridViewAddresses.RowHeadersVisible = false;
            this.dataGridViewAddresses.RowTemplate.Height = 25;
            this.dataGridViewAddresses.Size = new System.Drawing.Size(1294, 364);
            this.dataGridViewAddresses.TabIndex = 0;
            this.dataGridViewAddresses.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridViewAddresses_CellClick);
            // 
            // InhabitantsButton
            // 
            this.InhabitantsButton.HeaderText = "";
            this.InhabitantsButton.Name = "InhabitantsButton";
            // 
            // streetNameCol
            // 
            this.streetNameCol.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.streetNameCol.HeaderText = "Улица";
            this.streetNameCol.MinimumWidth = 100;
            this.streetNameCol.Name = "streetNameCol";
            // 
            // streetNomberCol
            // 
            this.streetNomberCol.HeaderText = "Номер";
            this.streetNomberCol.MinimumWidth = 50;
            this.streetNomberCol.Name = "streetNomberCol";
            this.streetNomberCol.Width = 50;
            // 
            // squaringCol
            // 
            this.squaringCol.HeaderText = "Квадратура";
            this.squaringCol.Name = "squaringCol";
            // 
            // habitabilityCol
            // 
            this.habitabilityCol.HeaderText = "Обитаемост";
            this.habitabilityCol.MinimumWidth = 120;
            this.habitabilityCol.Name = "habitabilityCol";
            this.habitabilityCol.Width = 120;
            // 
            // resBuildingsCol
            // 
            this.resBuildingsCol.HeaderText = "Жилищни постройки";
            this.resBuildingsCol.MinimumWidth = 100;
            this.resBuildingsCol.Name = "resBuildingsCol";
            // 
            // agrBuildingsCol
            // 
            this.agrBuildingsCol.HeaderText = "Селскостопански постройки";
            this.agrBuildingsCol.MinimumWidth = 110;
            this.agrBuildingsCol.Name = "agrBuildingsCol";
            this.agrBuildingsCol.Width = 110;
            // 
            // cowsCol
            // 
            this.cowsCol.HeaderText = "Крави";
            this.cowsCol.MinimumWidth = 70;
            this.cowsCol.Name = "cowsCol";
            this.cowsCol.Width = 70;
            // 
            // sheepCol
            // 
            this.sheepCol.HeaderText = "Овце";
            this.sheepCol.MinimumWidth = 70;
            this.sheepCol.Name = "sheepCol";
            this.sheepCol.Width = 70;
            // 
            // goatsCol
            // 
            this.goatsCol.HeaderText = "Кози";
            this.goatsCol.MinimumWidth = 70;
            this.goatsCol.Name = "goatsCol";
            this.goatsCol.Width = 70;
            // 
            // horsesCol
            // 
            this.horsesCol.HeaderText = "Коне";
            this.horsesCol.MinimumWidth = 70;
            this.horsesCol.Name = "horsesCol";
            this.horsesCol.Width = 70;
            // 
            // donkeysCol
            // 
            this.donkeysCol.HeaderText = "Магарета";
            this.donkeysCol.MinimumWidth = 70;
            this.donkeysCol.Name = "donkeysCol";
            this.donkeysCol.Width = 70;
            // 
            // fetheredCol
            // 
            this.fetheredCol.HeaderText = "Пернати";
            this.fetheredCol.MinimumWidth = 70;
            this.fetheredCol.Name = "fetheredCol";
            this.fetheredCol.Width = 70;
            // 
            // walnutTreesCol
            // 
            this.walnutTreesCol.HeaderText = "Орехови дървета";
            this.walnutTreesCol.MinimumWidth = 70;
            this.walnutTreesCol.Name = "walnutTreesCol";
            this.walnutTreesCol.Width = 70;
            // 
            // tabInhabitants
            // 
            this.tabInhabitants.Controls.Add(this.labelCriteriaInhabitants);
            this.tabInhabitants.Controls.Add(this.buttonSaveInhabitants);
            this.tabInhabitants.Controls.Add(this.buttonFiltersInhabitants);
            this.tabInhabitants.Controls.Add(this.dataGridViewInhabitants);
            this.tabInhabitants.Location = new System.Drawing.Point(4, 24);
            this.tabInhabitants.Name = "tabInhabitants";
            this.tabInhabitants.Padding = new System.Windows.Forms.Padding(3);
            this.tabInhabitants.Size = new System.Drawing.Size(1300, 431);
            this.tabInhabitants.TabIndex = 1;
            this.tabInhabitants.Text = "Обитатели";
            this.tabInhabitants.UseVisualStyleBackColor = true;
            // 
            // labelCriteriaInhabitants
            // 
            this.labelCriteriaInhabitants.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.labelCriteriaInhabitants.AutoSize = true;
            this.labelCriteriaInhabitants.Location = new System.Drawing.Point(3, 411);
            this.labelCriteriaInhabitants.Name = "labelCriteriaInhabitants";
            this.labelCriteriaInhabitants.Size = new System.Drawing.Size(0, 15);
            this.labelCriteriaInhabitants.TabIndex = 6;
            // 
            // buttonSaveInhabitants
            // 
            this.buttonSaveInhabitants.Location = new System.Drawing.Point(84, 7);
            this.buttonSaveInhabitants.Name = "buttonSaveInhabitants";
            this.buttonSaveInhabitants.Size = new System.Drawing.Size(75, 23);
            this.buttonSaveInhabitants.TabIndex = 4;
            this.buttonSaveInhabitants.Text = "Експорт";
            this.buttonSaveInhabitants.UseVisualStyleBackColor = true;
            // 
            // buttonFiltersInhabitants
            // 
            this.buttonFiltersInhabitants.Location = new System.Drawing.Point(3, 7);
            this.buttonFiltersInhabitants.Name = "buttonFiltersInhabitants";
            this.buttonFiltersInhabitants.Size = new System.Drawing.Size(75, 23);
            this.buttonFiltersInhabitants.TabIndex = 3;
            this.buttonFiltersInhabitants.Text = "Филтри";
            this.buttonFiltersInhabitants.UseVisualStyleBackColor = true;
            this.buttonFiltersInhabitants.Click += new System.EventHandler(this.buttonFiltersInhabitants_Click);
            // 
            // dataGridViewInhabitants
            // 
            this.dataGridViewInhabitants.AllowUserToAddRows = false;
            this.dataGridViewInhabitants.AllowUserToDeleteRows = false;
            this.dataGridViewInhabitants.AllowUserToResizeColumns = false;
            this.dataGridViewInhabitants.AllowUserToResizeRows = false;
            this.dataGridViewInhabitants.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.dataGridViewInhabitants.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridViewInhabitants.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.firstNameCol,
            this.middlenameCol,
            this.lastnameCol,
            this.genderCol,
            this.addressCol,
            this.currentAddressCol,
            this.relationToOwnerCol,
            this.GuestResidentCol,
            this.addRefCol,
            this.covidCol,
            this.notoCol});
            this.dataGridViewInhabitants.Location = new System.Drawing.Point(3, 36);
            this.dataGridViewInhabitants.Name = "dataGridViewInhabitants";
            this.dataGridViewInhabitants.RowHeadersVisible = false;
            this.dataGridViewInhabitants.RowTemplate.Height = 25;
            this.dataGridViewInhabitants.Size = new System.Drawing.Size(1294, 364);
            this.dataGridViewInhabitants.TabIndex = 0;
            // 
            // firstNameCol
            // 
            this.firstNameCol.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.firstNameCol.HeaderText = "Име";
            this.firstNameCol.Name = "firstNameCol";
            // 
            // middlenameCol
            // 
            this.middlenameCol.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.middlenameCol.HeaderText = "Презиме";
            this.middlenameCol.Name = "middlenameCol";
            // 
            // lastnameCol
            // 
            this.lastnameCol.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.lastnameCol.HeaderText = "Фамилия";
            this.lastnameCol.Name = "lastnameCol";
            // 
            // genderCol
            // 
            this.genderCol.HeaderText = "Пол";
            this.genderCol.Name = "genderCol";
            // 
            // addressCol
            // 
            this.addressCol.HeaderText = "Адрес";
            this.addressCol.Name = "addressCol";
            // 
            // currentAddressCol
            // 
            this.currentAddressCol.HeaderText = "Текущ адрес";
            this.currentAddressCol.Name = "currentAddressCol";
            // 
            // relationToOwnerCol
            // 
            this.relationToOwnerCol.HeaderText = "Връзка със собственика";
            this.relationToOwnerCol.Name = "relationToOwnerCol";
            // 
            // GuestResidentCol
            // 
            this.GuestResidentCol.HeaderText = "Гост в карантина / Жител";
            this.GuestResidentCol.Name = "GuestResidentCol";
            this.GuestResidentCol.Width = 135;
            // 
            // addRefCol
            // 
            this.addRefCol.HeaderText = "Адр. регистрация";
            this.addRefCol.Name = "addRefCol";
            // 
            // covidCol
            // 
            this.covidCol.HeaderText = "Covid 19";
            this.covidCol.Name = "covidCol";
            // 
            // notoCol
            // 
            this.notoCol.HeaderText = "Забележка";
            this.notoCol.Name = "notoCol";
            // 
            // ReferenceForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1308, 459);
            this.Controls.Add(this.tabControl);
            this.Name = "ReferenceForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "ReferenceForm";
            this.tabControl.ResumeLayout(false);
            this.tabAddresses.ResumeLayout(false);
            this.tabAddresses.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewAddresses)).EndInit();
            this.tabInhabitants.ResumeLayout(false);
            this.tabInhabitants.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewInhabitants)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TabControl tabControl;
        private System.Windows.Forms.TabPage tabAddresses;
        private System.Windows.Forms.TabPage tabInhabitants;
        private System.Windows.Forms.DataGridView dataGridViewAddresses;
        private System.Windows.Forms.Button buttonSaveAddesses;
        private System.Windows.Forms.Button buttonFiltersAddresses;
        private System.Windows.Forms.Label labelCriteriaAddresses;
        private System.Windows.Forms.DataGridView dataGridViewInhabitants;
        private System.Windows.Forms.Button buttonExportInhabitants;
        private System.Windows.Forms.Button buttonFiltersInhabitants;
        private System.Windows.Forms.Label labelCriteriaInhabitants;
        private System.Windows.Forms.Button buttonSaveInhabitants;
        private System.Windows.Forms.DataGridViewButtonColumn InhabitantsButton;
        private System.Windows.Forms.DataGridViewTextBoxColumn streetNameCol;
        private System.Windows.Forms.DataGridViewTextBoxColumn streetNomberCol;
        private System.Windows.Forms.DataGridViewTextBoxColumn squaringCol;
        private System.Windows.Forms.DataGridViewTextBoxColumn habitabilityCol;
        private System.Windows.Forms.DataGridViewTextBoxColumn resBuildingsCol;
        private System.Windows.Forms.DataGridViewTextBoxColumn agrBuildingsCol;
        private System.Windows.Forms.DataGridViewTextBoxColumn cowsCol;
        private System.Windows.Forms.DataGridViewTextBoxColumn sheepCol;
        private System.Windows.Forms.DataGridViewTextBoxColumn goatsCol;
        private System.Windows.Forms.DataGridViewTextBoxColumn horsesCol;
        private System.Windows.Forms.DataGridViewTextBoxColumn donkeysCol;
        private System.Windows.Forms.DataGridViewTextBoxColumn fetheredCol;
        private System.Windows.Forms.DataGridViewTextBoxColumn walnutTreesCol;
        private System.Windows.Forms.DataGridViewTextBoxColumn firstNameCol;
        private System.Windows.Forms.DataGridViewTextBoxColumn middlenameCol;
        private System.Windows.Forms.DataGridViewTextBoxColumn lastnameCol;
        private System.Windows.Forms.DataGridViewTextBoxColumn genderCol;
        private System.Windows.Forms.DataGridViewTextBoxColumn addressCol;
        private System.Windows.Forms.DataGridViewTextBoxColumn currentAddressCol;
        private System.Windows.Forms.DataGridViewTextBoxColumn relationToOwnerCol;
        private System.Windows.Forms.DataGridViewTextBoxColumn GuestResidentCol;
        private System.Windows.Forms.DataGridViewTextBoxColumn addRefCol;
        private System.Windows.Forms.DataGridViewTextBoxColumn covidCol;
        private System.Windows.Forms.DataGridViewTextBoxColumn notoCol;
    }
}