
namespace GraduationProject
{
    partial class Form1
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.menuStrip = new System.Windows.Forms.MenuStrip();
            this.Settings = new System.Windows.Forms.ToolStripMenuItem();
            this.Streets = new System.Windows.Forms.ToolStripMenuItem();
            this.Residents = new System.Windows.Forms.ToolStripMenuItem();
            this.listBoxAddresses = new System.Windows.Forms.ListBox();
            this.textBoxSearchAddr = new System.Windows.Forms.TextBox();
            this.buttonSearch = new System.Windows.Forms.Button();
            this.comboBoxCriteria = new System.Windows.Forms.ComboBox();
            this.tabControl1 = new System.Windows.Forms.TabControl();
            this.tabPageSearch = new System.Windows.Forms.TabPage();
            this.labelCriteria = new System.Windows.Forms.Label();
            this.tabPageAdd = new System.Windows.Forms.TabPage();
            this.buttonRemoveStr = new System.Windows.Forms.Button();
            this.buttonAddStr = new System.Windows.Forms.Button();
            this.label3 = new System.Windows.Forms.Label();
            this.listBoxStreets = new System.Windows.Forms.ListBox();
            this.textBoxSearchStr = new System.Windows.Forms.TextBox();
            this.panel1 = new System.Windows.Forms.Panel();
            this.buttonAddResident = new System.Windows.Forms.Button();
            this.buttonRemoveDog = new System.Windows.Forms.Button();
            this.buttonAddDog = new System.Windows.Forms.Button();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.firstName = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.lastName = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.owner = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Guest = new System.Windows.Forms.DataGridViewCheckBoxColumn();
            this.listBox1 = new System.Windows.Forms.ListBox();
            this.numericUpDown1 = new System.Windows.Forms.NumericUpDown();
            this.labelNumber = new System.Windows.Forms.Label();
            this.labelDogs = new System.Windows.Forms.Label();
            this.labelInhabitants = new System.Windows.Forms.Label();
            this.labelWalnut = new System.Windows.Forms.Label();
            this.numericUpDownWalnut = new System.Windows.Forms.NumericUpDown();
            this.labelFeathered = new System.Windows.Forms.Label();
            this.numericUpDownFeathered = new System.Windows.Forms.NumericUpDown();
            this.labelDonkeys = new System.Windows.Forms.Label();
            this.numericUpDownDonkeys = new System.Windows.Forms.NumericUpDown();
            this.labelSheep = new System.Windows.Forms.Label();
            this.numericUpDownSheep = new System.Windows.Forms.NumericUpDown();
            this.labelHorses = new System.Windows.Forms.Label();
            this.numericUpDownHorses = new System.Windows.Forms.NumericUpDown();
            this.labelGoats = new System.Windows.Forms.Label();
            this.numericUpDownGoats = new System.Windows.Forms.NumericUpDown();
            this.labelCows = new System.Windows.Forms.Label();
            this.numericUpDownCows = new System.Windows.Forms.NumericUpDown();
            this.label2 = new System.Windows.Forms.Label();
            this.numericUpDownAgrBuildings = new System.Windows.Forms.NumericUpDown();
            this.labelResBuildings = new System.Windows.Forms.Label();
            this.numericUpDownResBouldings = new System.Windows.Forms.NumericUpDown();
            this.groupBoxHabitabillity = new System.Windows.Forms.GroupBox();
            this.radioButtonTemporariry = new System.Windows.Forms.RadioButton();
            this.radioButtonInhabited = new System.Windows.Forms.RadioButton();
            this.radioButtonDesolate = new System.Windows.Forms.RadioButton();
            this.label1 = new System.Windows.Forms.Label();
            this.numericUpDownSquaring = new System.Windows.Forms.NumericUpDown();
            this.menuStrip.SuspendLayout();
            this.tabControl1.SuspendLayout();
            this.tabPageSearch.SuspendLayout();
            this.tabPageAdd.SuspendLayout();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDown1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDownWalnut)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDownFeathered)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDownDonkeys)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDownSheep)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDownHorses)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDownGoats)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDownCows)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDownAgrBuildings)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDownResBouldings)).BeginInit();
            this.groupBoxHabitabillity.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDownSquaring)).BeginInit();
            this.SuspendLayout();
            // 
            // menuStrip
            // 
            this.menuStrip.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.Settings});
            this.menuStrip.Location = new System.Drawing.Point(0, 0);
            this.menuStrip.Name = "menuStrip";
            this.menuStrip.Size = new System.Drawing.Size(982, 24);
            this.menuStrip.TabIndex = 0;
            this.menuStrip.Text = "menuStrip1";
            this.menuStrip.ItemClicked += new System.Windows.Forms.ToolStripItemClickedEventHandler(this.menuStrip_ItemClicked);
            // 
            // Settings
            // 
            this.Settings.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.Streets,
            this.Residents});
            this.Settings.Name = "Settings";
            this.Settings.Size = new System.Drawing.Size(79, 20);
            this.Settings.Text = "Настройки";
            // 
            // Streets
            // 
            this.Streets.Name = "Streets";
            this.Streets.Size = new System.Drawing.Size(117, 22);
            this.Streets.Text = "Улици";
            this.Streets.Click += new System.EventHandler(this.Streets_ItemClicked);
            // 
            // Residents
            // 
            this.Residents.Name = "Residents";
            this.Residents.Size = new System.Drawing.Size(117, 22);
            this.Residents.Text = "Жители";
            // 
            // listBoxAddresses
            // 
            this.listBoxAddresses.FormattingEnabled = true;
            this.listBoxAddresses.ItemHeight = 15;
            this.listBoxAddresses.Location = new System.Drawing.Point(3, 75);
            this.listBoxAddresses.Name = "listBoxAddresses";
            this.listBoxAddresses.Size = new System.Drawing.Size(209, 349);
            this.listBoxAddresses.TabIndex = 3;
            // 
            // textBoxSearchAddr
            // 
            this.textBoxSearchAddr.Location = new System.Drawing.Point(3, 34);
            this.textBoxSearchAddr.Name = "textBoxSearchAddr";
            this.textBoxSearchAddr.Size = new System.Drawing.Size(147, 23);
            this.textBoxSearchAddr.TabIndex = 1;
            // 
            // buttonSearch
            // 
            this.buttonSearch.Location = new System.Drawing.Point(157, 34);
            this.buttonSearch.Name = "buttonSearch";
            this.buttonSearch.Size = new System.Drawing.Size(55, 23);
            this.buttonSearch.TabIndex = 5;
            this.buttonSearch.Text = "Търси";
            this.buttonSearch.UseVisualStyleBackColor = true;
            this.buttonSearch.Click += new System.EventHandler(this.buttonSearch_Click);
            // 
            // comboBoxCriteria
            // 
            this.comboBoxCriteria.FormattingEnabled = true;
            this.comboBoxCriteria.Location = new System.Drawing.Point(74, 5);
            this.comboBoxCriteria.Name = "comboBoxCriteria";
            this.comboBoxCriteria.Size = new System.Drawing.Size(138, 23);
            this.comboBoxCriteria.TabIndex = 2;
            // 
            // tabControl1
            // 
            this.tabControl1.Controls.Add(this.tabPageSearch);
            this.tabControl1.Controls.Add(this.tabPageAdd);
            this.tabControl1.Location = new System.Drawing.Point(12, 28);
            this.tabControl1.Name = "tabControl1";
            this.tabControl1.SelectedIndex = 0;
            this.tabControl1.Size = new System.Drawing.Size(223, 457);
            this.tabControl1.TabIndex = 7;
            this.tabControl1.SelectedIndexChanged += new System.EventHandler(this.tabControl1_SelectedIndexChanged);
            // 
            // tabPageSearch
            // 
            this.tabPageSearch.BackColor = System.Drawing.SystemColors.Control;
            this.tabPageSearch.Controls.Add(this.labelCriteria);
            this.tabPageSearch.Controls.Add(this.listBoxAddresses);
            this.tabPageSearch.Controls.Add(this.textBoxSearchAddr);
            this.tabPageSearch.Controls.Add(this.buttonSearch);
            this.tabPageSearch.Controls.Add(this.comboBoxCriteria);
            this.tabPageSearch.Location = new System.Drawing.Point(4, 24);
            this.tabPageSearch.Name = "tabPageSearch";
            this.tabPageSearch.Padding = new System.Windows.Forms.Padding(3);
            this.tabPageSearch.Size = new System.Drawing.Size(215, 429);
            this.tabPageSearch.TabIndex = 0;
            this.tabPageSearch.Text = "Търси Адрес";
            // 
            // labelCriteria
            // 
            this.labelCriteria.AutoSize = true;
            this.labelCriteria.Location = new System.Drawing.Point(4, 8);
            this.labelCriteria.Name = "labelCriteria";
            this.labelCriteria.Size = new System.Drawing.Size(63, 15);
            this.labelCriteria.TabIndex = 7;
            this.labelCriteria.Text = "Критерий:";
            // 
            // tabPageAdd
            // 
            this.tabPageAdd.BackColor = System.Drawing.SystemColors.Control;
            this.tabPageAdd.Controls.Add(this.buttonRemoveStr);
            this.tabPageAdd.Controls.Add(this.buttonAddStr);
            this.tabPageAdd.Controls.Add(this.label3);
            this.tabPageAdd.Controls.Add(this.listBoxStreets);
            this.tabPageAdd.Controls.Add(this.textBoxSearchStr);
            this.tabPageAdd.Location = new System.Drawing.Point(4, 24);
            this.tabPageAdd.Name = "tabPageAdd";
            this.tabPageAdd.Padding = new System.Windows.Forms.Padding(3);
            this.tabPageAdd.Size = new System.Drawing.Size(215, 429);
            this.tabPageAdd.TabIndex = 1;
            this.tabPageAdd.Text = "Нов Адрес";
            // 
            // buttonRemoveStr
            // 
            this.buttonRemoveStr.Location = new System.Drawing.Point(85, 400);
            this.buttonRemoveStr.Name = "buttonRemoveStr";
            this.buttonRemoveStr.Size = new System.Drawing.Size(75, 23);
            this.buttonRemoveStr.TabIndex = 4;
            this.buttonRemoveStr.Text = "Премахни";
            this.buttonRemoveStr.UseVisualStyleBackColor = true;
            this.buttonRemoveStr.Click += new System.EventHandler(this.buttonRemoveStr_Click);
            // 
            // buttonAddStr
            // 
            this.buttonAddStr.Location = new System.Drawing.Point(4, 400);
            this.buttonAddStr.Name = "buttonAddStr";
            this.buttonAddStr.Size = new System.Drawing.Size(75, 23);
            this.buttonAddStr.TabIndex = 3;
            this.buttonAddStr.Text = "Добави";
            this.buttonAddStr.UseVisualStyleBackColor = true;
            this.buttonAddStr.Click += new System.EventHandler(this.buttonAddStr_Click);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(13, 25);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(44, 15);
            this.label3.TabIndex = 2;
            this.label3.Text = "Улица:";
            // 
            // listBoxStreets
            // 
            this.listBoxStreets.FormattingEnabled = true;
            this.listBoxStreets.ItemHeight = 15;
            this.listBoxStreets.Location = new System.Drawing.Point(4, 60);
            this.listBoxStreets.Name = "listBoxStreets";
            this.listBoxStreets.Size = new System.Drawing.Size(208, 334);
            this.listBoxStreets.TabIndex = 1;
            // 
            // textBoxSearchStr
            // 
            this.textBoxSearchStr.Location = new System.Drawing.Point(63, 19);
            this.textBoxSearchStr.Name = "textBoxSearchStr";
            this.textBoxSearchStr.Size = new System.Drawing.Size(138, 23);
            this.textBoxSearchStr.TabIndex = 0;
            this.textBoxSearchStr.TextChanged += new System.EventHandler(this.textBox1_TextChanged);
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.buttonAddResident);
            this.panel1.Controls.Add(this.buttonRemoveDog);
            this.panel1.Controls.Add(this.buttonAddDog);
            this.panel1.Controls.Add(this.dataGridView1);
            this.panel1.Controls.Add(this.listBox1);
            this.panel1.Controls.Add(this.numericUpDown1);
            this.panel1.Controls.Add(this.labelNumber);
            this.panel1.Controls.Add(this.labelDogs);
            this.panel1.Controls.Add(this.labelInhabitants);
            this.panel1.Controls.Add(this.labelWalnut);
            this.panel1.Controls.Add(this.numericUpDownWalnut);
            this.panel1.Controls.Add(this.labelFeathered);
            this.panel1.Controls.Add(this.numericUpDownFeathered);
            this.panel1.Controls.Add(this.labelDonkeys);
            this.panel1.Controls.Add(this.numericUpDownDonkeys);
            this.panel1.Controls.Add(this.labelSheep);
            this.panel1.Controls.Add(this.numericUpDownSheep);
            this.panel1.Controls.Add(this.labelHorses);
            this.panel1.Controls.Add(this.numericUpDownHorses);
            this.panel1.Controls.Add(this.labelGoats);
            this.panel1.Controls.Add(this.numericUpDownGoats);
            this.panel1.Controls.Add(this.labelCows);
            this.panel1.Controls.Add(this.numericUpDownCows);
            this.panel1.Controls.Add(this.label2);
            this.panel1.Controls.Add(this.numericUpDownAgrBuildings);
            this.panel1.Controls.Add(this.labelResBuildings);
            this.panel1.Controls.Add(this.numericUpDownResBouldings);
            this.panel1.Controls.Add(this.groupBoxHabitabillity);
            this.panel1.Controls.Add(this.label1);
            this.panel1.Controls.Add(this.numericUpDownSquaring);
            this.panel1.Location = new System.Drawing.Point(242, 28);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(725, 453);
            this.panel1.TabIndex = 8;
            // 
            // buttonAddResident
            // 
            this.buttonAddResident.Location = new System.Drawing.Point(269, 222);
            this.buttonAddResident.Name = "buttonAddResident";
            this.buttonAddResident.Size = new System.Drawing.Size(66, 22);
            this.buttonAddResident.TabIndex = 31;
            this.buttonAddResident.Text = "Добави";
            this.buttonAddResident.UseVisualStyleBackColor = true;
            this.buttonAddResident.Click += new System.EventHandler(this.buttonAddResident_Click);
            // 
            // buttonRemoveDog
            // 
            this.buttonRemoveDog.Location = new System.Drawing.Point(341, 416);
            this.buttonRemoveDog.Name = "buttonRemoveDog";
            this.buttonRemoveDog.Size = new System.Drawing.Size(78, 22);
            this.buttonRemoveDog.TabIndex = 30;
            this.buttonRemoveDog.Text = "Премахни";
            this.buttonRemoveDog.UseVisualStyleBackColor = true;
            // 
            // buttonAddDog
            // 
            this.buttonAddDog.Location = new System.Drawing.Point(269, 416);
            this.buttonAddDog.Name = "buttonAddDog";
            this.buttonAddDog.Size = new System.Drawing.Size(66, 22);
            this.buttonAddDog.TabIndex = 29;
            this.buttonAddDog.Text = "Добави";
            this.buttonAddDog.UseVisualStyleBackColor = true;
            // 
            // dataGridView1
            // 
            this.dataGridView1.AllowUserToAddRows = false;
            this.dataGridView1.AllowUserToDeleteRows = false;
            this.dataGridView1.AllowUserToResizeColumns = false;
            this.dataGridView1.AllowUserToResizeRows = false;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.firstName,
            this.lastName,
            this.owner,
            this.Guest});
            this.dataGridView1.Location = new System.Drawing.Point(269, 32);
            this.dataGridView1.MultiSelect = false;
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.RowTemplate.Height = 25;
            this.dataGridView1.Size = new System.Drawing.Size(443, 183);
            this.dataGridView1.TabIndex = 28;
            // 
            // firstName
            // 
            this.firstName.HeaderText = "Име";
            this.firstName.Name = "firstName";
            // 
            // lastName
            // 
            this.lastName.HeaderText = "Фамилия";
            this.lastName.Name = "lastName";
            // 
            // owner
            // 
            this.owner.HeaderText = "Собственик";
            this.owner.Name = "owner";
            // 
            // Guest
            // 
            this.Guest.HeaderText = "Гост в карантина";
            this.Guest.Name = "Guest";
            // 
            // listBox1
            // 
            this.listBox1.FormattingEnabled = true;
            this.listBox1.ItemHeight = 15;
            this.listBox1.Location = new System.Drawing.Point(269, 271);
            this.listBox1.Name = "listBox1";
            this.listBox1.Size = new System.Drawing.Size(443, 139);
            this.listBox1.TabIndex = 27;
            // 
            // numericUpDown1
            // 
            this.numericUpDown1.Font = new System.Drawing.Font("Segoe UI", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.numericUpDown1.Location = new System.Drawing.Point(17, 49);
            this.numericUpDown1.Name = "numericUpDown1";
            this.numericUpDown1.Size = new System.Drawing.Size(45, 43);
            this.numericUpDown1.TabIndex = 26;
            this.numericUpDown1.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // labelNumber
            // 
            this.labelNumber.AutoSize = true;
            this.labelNumber.Location = new System.Drawing.Point(17, 24);
            this.labelNumber.Name = "labelNumber";
            this.labelNumber.Size = new System.Drawing.Size(48, 15);
            this.labelNumber.TabIndex = 25;
            this.labelNumber.Text = "Номер:";
            // 
            // labelDogs
            // 
            this.labelDogs.AutoSize = true;
            this.labelDogs.Location = new System.Drawing.Point(269, 253);
            this.labelDogs.Name = "labelDogs";
            this.labelDogs.Size = new System.Drawing.Size(44, 15);
            this.labelDogs.TabIndex = 24;
            this.labelDogs.Text = "Кучета";
            // 
            // labelInhabitants
            // 
            this.labelInhabitants.AutoSize = true;
            this.labelInhabitants.Location = new System.Drawing.Point(269, 14);
            this.labelInhabitants.Name = "labelInhabitants";
            this.labelInhabitants.Size = new System.Drawing.Size(66, 15);
            this.labelInhabitants.TabIndex = 22;
            this.labelInhabitants.Text = "Обитатели";
            // 
            // labelWalnut
            // 
            this.labelWalnut.AutoSize = true;
            this.labelWalnut.Location = new System.Drawing.Point(96, 365);
            this.labelWalnut.Name = "labelWalnut";
            this.labelWalnut.Size = new System.Drawing.Size(104, 15);
            this.labelWalnut.TabIndex = 20;
            this.labelWalnut.Text = "Орехови дървета:";
            // 
            // numericUpDownWalnut
            // 
            this.numericUpDownWalnut.Location = new System.Drawing.Point(210, 363);
            this.numericUpDownWalnut.Name = "numericUpDownWalnut";
            this.numericUpDownWalnut.Size = new System.Drawing.Size(38, 23);
            this.numericUpDownWalnut.TabIndex = 19;
            // 
            // labelFeathered
            // 
            this.labelFeathered.AutoSize = true;
            this.labelFeathered.Location = new System.Drawing.Point(143, 255);
            this.labelFeathered.Name = "labelFeathered";
            this.labelFeathered.Size = new System.Drawing.Size(57, 15);
            this.labelFeathered.TabIndex = 18;
            this.labelFeathered.Text = "Пернати:";
            // 
            // numericUpDownFeathered
            // 
            this.numericUpDownFeathered.Location = new System.Drawing.Point(210, 253);
            this.numericUpDownFeathered.Name = "numericUpDownFeathered";
            this.numericUpDownFeathered.Size = new System.Drawing.Size(38, 23);
            this.numericUpDownFeathered.TabIndex = 17;
            // 
            // labelDonkeys
            // 
            this.labelDonkeys.AutoSize = true;
            this.labelDonkeys.Location = new System.Drawing.Point(143, 329);
            this.labelDonkeys.Name = "labelDonkeys";
            this.labelDonkeys.Size = new System.Drawing.Size(62, 15);
            this.labelDonkeys.TabIndex = 16;
            this.labelDonkeys.Text = "Магарета:";
            // 
            // numericUpDownDonkeys
            // 
            this.numericUpDownDonkeys.Location = new System.Drawing.Point(210, 325);
            this.numericUpDownDonkeys.Name = "numericUpDownDonkeys";
            this.numericUpDownDonkeys.Size = new System.Drawing.Size(38, 23);
            this.numericUpDownDonkeys.TabIndex = 15;
            // 
            // labelSheep
            // 
            this.labelSheep.AutoSize = true;
            this.labelSheep.Location = new System.Drawing.Point(143, 289);
            this.labelSheep.Name = "labelSheep";
            this.labelSheep.Size = new System.Drawing.Size(38, 15);
            this.labelSheep.TabIndex = 14;
            this.labelSheep.Text = "Овце:";
            // 
            // numericUpDownSheep
            // 
            this.numericUpDownSheep.Location = new System.Drawing.Point(210, 289);
            this.numericUpDownSheep.Name = "numericUpDownSheep";
            this.numericUpDownSheep.Size = new System.Drawing.Size(38, 23);
            this.numericUpDownSheep.TabIndex = 13;
            // 
            // labelHorses
            // 
            this.labelHorses.AutoSize = true;
            this.labelHorses.Location = new System.Drawing.Point(17, 325);
            this.labelHorses.Name = "labelHorses";
            this.labelHorses.Size = new System.Drawing.Size(37, 15);
            this.labelHorses.TabIndex = 12;
            this.labelHorses.Text = "Коне:";
            // 
            // numericUpDownHorses
            // 
            this.numericUpDownHorses.Location = new System.Drawing.Point(63, 327);
            this.numericUpDownHorses.Name = "numericUpDownHorses";
            this.numericUpDownHorses.Size = new System.Drawing.Size(38, 23);
            this.numericUpDownHorses.TabIndex = 11;
            // 
            // labelGoats
            // 
            this.labelGoats.AutoSize = true;
            this.labelGoats.Location = new System.Drawing.Point(17, 291);
            this.labelGoats.Name = "labelGoats";
            this.labelGoats.Size = new System.Drawing.Size(36, 15);
            this.labelGoats.TabIndex = 10;
            this.labelGoats.Text = "Кози:";
            // 
            // numericUpDownGoats
            // 
            this.numericUpDownGoats.Location = new System.Drawing.Point(63, 289);
            this.numericUpDownGoats.Name = "numericUpDownGoats";
            this.numericUpDownGoats.Size = new System.Drawing.Size(38, 23);
            this.numericUpDownGoats.TabIndex = 9;
            // 
            // labelCows
            // 
            this.labelCows.AutoSize = true;
            this.labelCows.Location = new System.Drawing.Point(17, 255);
            this.labelCows.Name = "labelCows";
            this.labelCows.Size = new System.Drawing.Size(43, 15);
            this.labelCows.TabIndex = 8;
            this.labelCows.Text = "Крави:";
            // 
            // numericUpDownCows
            // 
            this.numericUpDownCows.Location = new System.Drawing.Point(63, 253);
            this.numericUpDownCows.Name = "numericUpDownCows";
            this.numericUpDownCows.Size = new System.Drawing.Size(38, 23);
            this.numericUpDownCows.TabIndex = 7;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(17, 223);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(169, 15);
            this.label2.TabIndex = 6;
            this.label2.Text = "Селскостопански постройки:";
            // 
            // numericUpDownAgrBuildings
            // 
            this.numericUpDownAgrBuildings.Location = new System.Drawing.Point(210, 221);
            this.numericUpDownAgrBuildings.Name = "numericUpDownAgrBuildings";
            this.numericUpDownAgrBuildings.Size = new System.Drawing.Size(38, 23);
            this.numericUpDownAgrBuildings.TabIndex = 5;
            // 
            // labelResBuildings
            // 
            this.labelResBuildings.AutoSize = true;
            this.labelResBuildings.Location = new System.Drawing.Point(17, 191);
            this.labelResBuildings.Name = "labelResBuildings";
            this.labelResBuildings.Size = new System.Drawing.Size(129, 15);
            this.labelResBuildings.TabIndex = 4;
            this.labelResBuildings.Text = "Жилищни постройки:";
            // 
            // numericUpDownResBouldings
            // 
            this.numericUpDownResBouldings.Location = new System.Drawing.Point(210, 192);
            this.numericUpDownResBouldings.Name = "numericUpDownResBouldings";
            this.numericUpDownResBouldings.Size = new System.Drawing.Size(38, 23);
            this.numericUpDownResBouldings.TabIndex = 3;
            // 
            // groupBoxHabitabillity
            // 
            this.groupBoxHabitabillity.Controls.Add(this.radioButtonTemporariry);
            this.groupBoxHabitabillity.Controls.Add(this.radioButtonInhabited);
            this.groupBoxHabitabillity.Controls.Add(this.radioButtonDesolate);
            this.groupBoxHabitabillity.Location = new System.Drawing.Point(82, 14);
            this.groupBoxHabitabillity.Name = "groupBoxHabitabillity";
            this.groupBoxHabitabillity.Size = new System.Drawing.Size(166, 110);
            this.groupBoxHabitabillity.TabIndex = 2;
            this.groupBoxHabitabillity.TabStop = false;
            this.groupBoxHabitabillity.Text = "Обитаемост";
            // 
            // radioButtonTemporariry
            // 
            this.radioButtonTemporariry.AutoSize = true;
            this.radioButtonTemporariry.Location = new System.Drawing.Point(18, 84);
            this.radioButtonTemporariry.Name = "radioButtonTemporariry";
            this.radioButtonTemporariry.Size = new System.Drawing.Size(135, 19);
            this.radioButtonTemporariry.TabIndex = 2;
            this.radioButtonTemporariry.TabStop = true;
            this.radioButtonTemporariry.Text = "Временно обитаван";
            this.radioButtonTemporariry.UseVisualStyleBackColor = true;
            // 
            // radioButtonInhabited
            // 
            this.radioButtonInhabited.AutoSize = true;
            this.radioButtonInhabited.Location = new System.Drawing.Point(18, 58);
            this.radioButtonInhabited.Name = "radioButtonInhabited";
            this.radioButtonInhabited.Size = new System.Drawing.Size(78, 19);
            this.radioButtonInhabited.TabIndex = 1;
            this.radioButtonInhabited.TabStop = true;
            this.radioButtonInhabited.Text = "Обитаван";
            this.radioButtonInhabited.UseVisualStyleBackColor = true;
            // 
            // radioButtonDesolate
            // 
            this.radioButtonDesolate.AutoSize = true;
            this.radioButtonDesolate.Location = new System.Drawing.Point(18, 35);
            this.radioButtonDesolate.Name = "radioButtonDesolate";
            this.radioButtonDesolate.Size = new System.Drawing.Size(74, 19);
            this.radioButtonDesolate.TabIndex = 0;
            this.radioButtonDesolate.TabStop = true;
            this.radioButtonDesolate.Text = "Пустеещ";
            this.radioButtonDesolate.UseVisualStyleBackColor = true;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(17, 145);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(72, 15);
            this.label1.TabIndex = 1;
            this.label1.Text = "Квадратура:";
            // 
            // numericUpDownSquaring
            // 
            this.numericUpDownSquaring.DecimalPlaces = 3;
            this.numericUpDownSquaring.Location = new System.Drawing.Point(126, 143);
            this.numericUpDownSquaring.Maximum = new decimal(new int[] {
            30000,
            0,
            0,
            0});
            this.numericUpDownSquaring.Name = "numericUpDownSquaring";
            this.numericUpDownSquaring.Size = new System.Drawing.Size(122, 23);
            this.numericUpDownSquaring.TabIndex = 0;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(982, 497);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.tabControl1);
            this.Controls.Add(this.menuStrip);
            this.MainMenuStrip = this.menuStrip;
            this.Name = "Form1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.menuStrip.ResumeLayout(false);
            this.menuStrip.PerformLayout();
            this.tabControl1.ResumeLayout(false);
            this.tabPageSearch.ResumeLayout(false);
            this.tabPageSearch.PerformLayout();
            this.tabPageAdd.ResumeLayout(false);
            this.tabPageAdd.PerformLayout();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDown1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDownWalnut)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDownFeathered)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDownDonkeys)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDownSheep)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDownHorses)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDownGoats)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDownCows)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDownAgrBuildings)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDownResBouldings)).EndInit();
            this.groupBoxHabitabillity.ResumeLayout(false);
            this.groupBoxHabitabillity.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDownSquaring)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.ToolStripMenuItem Settings;
        private System.Windows.Forms.MenuStrip menuStrip;
        private System.Windows.Forms.ToolStripMenuItem Streets;
        private System.Windows.Forms.ListBox listBoxAddresses;
        private System.Windows.Forms.TextBox textBoxSearchAddr;
        private System.Windows.Forms.Button buttonSearch;
        private System.Windows.Forms.ComboBox comboBoxCriteria;
        private System.Windows.Forms.Label labelCriteria;
        private System.Windows.Forms.TabControl tabControl1;
        private System.Windows.Forms.TabPage tabPageSearch;
        private System.Windows.Forms.TabPage tabPageAdd;
        private System.Windows.Forms.ListBox listBoxStreets;
        private System.Windows.Forms.TextBox textBoxSearchStr;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.NumericUpDown numericUpDownSquaring;
        private System.Windows.Forms.Label labelCows;
        private System.Windows.Forms.NumericUpDown numericUpDownCows;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.NumericUpDown numericUpDownAgrBuildings;
        private System.Windows.Forms.Label labelResBuildings;
        private System.Windows.Forms.NumericUpDown numericUpDownResBouldings;
        private System.Windows.Forms.GroupBox groupBoxHabitabillity;
        private System.Windows.Forms.RadioButton radioButtonTemporariry;
        private System.Windows.Forms.RadioButton radioButtonInhabited;
        private System.Windows.Forms.RadioButton radioButtonDesolate;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label labelInhabitants;
        private System.Windows.Forms.Label labelWalnut;
        private System.Windows.Forms.NumericUpDown numericUpDownWalnut;
        private System.Windows.Forms.Label labelFeathered;
        private System.Windows.Forms.NumericUpDown numericUpDownFeathered;
        private System.Windows.Forms.Label labelDonkeys;
        private System.Windows.Forms.NumericUpDown numericUpDownDonkeys;
        private System.Windows.Forms.Label labelSheep;
        private System.Windows.Forms.NumericUpDown numericUpDownSheep;
        private System.Windows.Forms.Label labelHorses;
        private System.Windows.Forms.NumericUpDown numericUpDownHorses;
        private System.Windows.Forms.Label labelGoats;
        private System.Windows.Forms.NumericUpDown numericUpDownGoats;
        private System.Windows.Forms.NumericUpDown numericUpDown1;
        private System.Windows.Forms.Label labelNumber;
        private System.Windows.Forms.Label labelDogs;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.ListBox listBox1;
        private System.Windows.Forms.ToolStripMenuItem Residents;
        private System.Windows.Forms.Button buttonRemoveDog;
        private System.Windows.Forms.Button buttonAddDog;
        private System.Windows.Forms.DataGridViewTextBoxColumn firstName;
        private System.Windows.Forms.DataGridViewTextBoxColumn lastName;
        private System.Windows.Forms.DataGridViewTextBoxColumn owner;
        private System.Windows.Forms.DataGridViewCheckBoxColumn Guest;
        private System.Windows.Forms.Button buttonAddResident;
        private System.Windows.Forms.Label labelCriteri;
        private System.Windows.Forms.Button buttonRemoveStr;
        private System.Windows.Forms.Button buttonAddStr;
    }
}

