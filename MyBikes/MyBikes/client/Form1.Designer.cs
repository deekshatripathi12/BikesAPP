namespace MyBikes.client
{
    partial class Form1
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
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.radioButtonRoad = new System.Windows.Forms.RadioButton();
            this.radioButtonMountain = new System.Windows.Forms.RadioButton();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.textBoxSerialNumber = new System.Windows.Forms.TextBox();
            this.textBoxBrand = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.textBoxModel = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.textBoxSpeed = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.comboBoxColor = new System.Windows.Forms.ComboBox();
            this.label6 = new System.Windows.Forms.Label();
            this.comboBoxSuspension = new System.Windows.Forms.ComboBox();
            this.label7 = new System.Windows.Forms.Label();
            this.textBoxHFG = new System.Windows.Forms.TextBox();
            this.label8 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.textBoxYear = new System.Windows.Forms.TextBox();
            this.textBoxMonth = new System.Windows.Forms.TextBox();
            this.textBoxDay = new System.Windows.Forms.TextBox();
            this.label10 = new System.Windows.Forms.Label();
            this.label11 = new System.Windows.Forms.Label();
            this.buttonAdd = new System.Windows.Forms.Button();
            this.buttonUpdate = new System.Windows.Forms.Button();
            this.buttonDelete = new System.Windows.Forms.Button();
            this.buttonDisplay = new System.Windows.Forms.Button();
            this.textBoxSearch = new System.Windows.Forms.TextBox();
            this.label12 = new System.Windows.Forms.Label();
            this.buttonSearch = new System.Windows.Forms.Button();
            this.listBoxDisplay = new System.Windows.Forms.ListBox();
            this.label13 = new System.Windows.Forms.Label();
            this.label14 = new System.Windows.Forms.Label();
            this.label15 = new System.Windows.Forms.Label();
            this.label16 = new System.Windows.Forms.Label();
            this.label17 = new System.Windows.Forms.Label();
            this.label18 = new System.Windows.Forms.Label();
            this.HFG = new System.Windows.Forms.Label();
            this.seatHeight = new System.Windows.Forms.Label();
            this.label21 = new System.Windows.Forms.Label();
            this.textBoxSeatHeight = new System.Windows.Forms.TextBox();
            this.buttonDisplayMountain = new System.Windows.Forms.Button();
            this.buttonDisplayRoad = new System.Windows.Forms.Button();
            this.buttonReset = new System.Windows.Forms.Button();
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.fileToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.saveTxt = new System.Windows.Forms.ToolStripMenuItem();
            this.saveXml = new System.Windows.Forms.ToolStripMenuItem();
            this.saveBin = new System.Windows.Forms.ToolStripMenuItem();
            this.readToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.readtxtToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.readxmlToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.readbinToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.errorProvider1 = new System.Windows.Forms.ErrorProvider(this.components);
            this.errorProvider2 = new System.Windows.Forms.ErrorProvider(this.components);
            this.errorProvider3 = new System.Windows.Forms.ErrorProvider(this.components);
            this.errorProvider4 = new System.Windows.Forms.ErrorProvider(this.components);
            this.errorProvider5 = new System.Windows.Forms.ErrorProvider(this.components);
            this.errorProvider7 = new System.Windows.Forms.ErrorProvider(this.components);
            this.errorProvider8 = new System.Windows.Forms.ErrorProvider(this.components);
            this.errorProvider9 = new System.Windows.Forms.ErrorProvider(this.components);
            this.errorProvider6 = new System.Windows.Forms.ErrorProvider(this.components);
            this.groupBox1.SuspendLayout();
            this.menuStrip1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider3)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider4)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider5)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider7)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider8)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider9)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider6)).BeginInit();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.radioButtonRoad);
            this.groupBox1.Controls.Add(this.radioButtonMountain);
            this.groupBox1.Location = new System.Drawing.Point(382, 12);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(200, 72);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Choose Bike ";
            // 
            // radioButtonRoad
            // 
            this.radioButtonRoad.AutoSize = true;
            this.radioButtonRoad.Location = new System.Drawing.Point(112, 30);
            this.radioButtonRoad.Name = "radioButtonRoad";
            this.radioButtonRoad.Size = new System.Drawing.Size(51, 17);
            this.radioButtonRoad.TabIndex = 1;
            this.radioButtonRoad.Text = "Road";
            this.radioButtonRoad.UseVisualStyleBackColor = true;
            this.radioButtonRoad.CheckedChanged += new System.EventHandler(this.radioButtonRoad_CheckedChanged);
            // 
            // radioButtonMountain
            // 
            this.radioButtonMountain.AutoSize = true;
            this.radioButtonMountain.Checked = true;
            this.radioButtonMountain.Location = new System.Drawing.Point(20, 30);
            this.radioButtonMountain.Name = "radioButtonMountain";
            this.radioButtonMountain.Size = new System.Drawing.Size(69, 17);
            this.radioButtonMountain.TabIndex = 0;
            this.radioButtonMountain.TabStop = true;
            this.radioButtonMountain.Text = "Mountain";
            this.radioButtonMountain.UseVisualStyleBackColor = true;
            this.radioButtonMountain.CheckedChanged += new System.EventHandler(this.radioButtonMountain_CheckedChanged);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(13, 104);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(73, 13);
            this.label1.TabIndex = 1;
            this.label1.Text = "Serial Number";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(13, 131);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(35, 13);
            this.label2.TabIndex = 2;
            this.label2.Text = "Brand";
            // 
            // textBoxSerialNumber
            // 
            this.textBoxSerialNumber.Location = new System.Drawing.Point(122, 104);
            this.textBoxSerialNumber.Name = "textBoxSerialNumber";
            this.textBoxSerialNumber.Size = new System.Drawing.Size(100, 20);
            this.textBoxSerialNumber.TabIndex = 3;
            this.textBoxSerialNumber.TextChanged += new System.EventHandler(this.textBoxSerialNumber_TextChanged);
            // 
            // textBoxBrand
            // 
            this.textBoxBrand.Location = new System.Drawing.Point(122, 131);
            this.textBoxBrand.Name = "textBoxBrand";
            this.textBoxBrand.Size = new System.Drawing.Size(100, 20);
            this.textBoxBrand.TabIndex = 4;
            this.textBoxBrand.TextChanged += new System.EventHandler(this.textBoxBrand_TextChanged);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(13, 161);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(36, 13);
            this.label3.TabIndex = 5;
            this.label3.Text = "Model";
            // 
            // textBoxModel
            // 
            this.textBoxModel.Location = new System.Drawing.Point(122, 161);
            this.textBoxModel.Name = "textBoxModel";
            this.textBoxModel.Size = new System.Drawing.Size(100, 20);
            this.textBoxModel.TabIndex = 6;
            this.textBoxModel.TextChanged += new System.EventHandler(this.textBoxModel_TextChanged);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(13, 195);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(38, 13);
            this.label4.TabIndex = 7;
            this.label4.Text = "Speed";
            // 
            // textBoxSpeed
            // 
            this.textBoxSpeed.Location = new System.Drawing.Point(122, 195);
            this.textBoxSpeed.Name = "textBoxSpeed";
            this.textBoxSpeed.Size = new System.Drawing.Size(100, 20);
            this.textBoxSpeed.TabIndex = 8;
            this.textBoxSpeed.TextChanged += new System.EventHandler(this.textBoxSpeed_TextChanged);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(326, 103);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(31, 13);
            this.label5.TabIndex = 9;
            this.label5.Text = "Color";
            // 
            // comboBoxColor
            // 
            this.comboBoxColor.FormattingEnabled = true;
            this.comboBoxColor.Location = new System.Drawing.Point(402, 95);
            this.comboBoxColor.Name = "comboBoxColor";
            this.comboBoxColor.Size = new System.Drawing.Size(121, 21);
            this.comboBoxColor.TabIndex = 10;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(326, 130);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(62, 13);
            this.label6.TabIndex = 11;
            this.label6.Text = "Suspension";
            // 
            // comboBoxSuspension
            // 
            this.comboBoxSuspension.FormattingEnabled = true;
            this.comboBoxSuspension.Location = new System.Drawing.Point(402, 130);
            this.comboBoxSuspension.Name = "comboBoxSuspension";
            this.comboBoxSuspension.Size = new System.Drawing.Size(121, 21);
            this.comboBoxSuspension.TabIndex = 12;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(287, 160);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(102, 13);
            this.label7.TabIndex = 13;
            this.label7.Text = "Height From Ground";
            // 
            // textBoxHFG
            // 
            this.textBoxHFG.Location = new System.Drawing.Point(402, 158);
            this.textBoxHFG.Name = "textBoxHFG";
            this.textBoxHFG.Size = new System.Drawing.Size(121, 20);
            this.textBoxHFG.TabIndex = 14;
            this.textBoxHFG.TextChanged += new System.EventHandler(this.textBoxHFG_TextChanged);
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(290, 194);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(63, 13);
            this.label8.TabIndex = 15;
            this.label8.Text = "Seat Height";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(547, 98);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(60, 13);
            this.label9.TabIndex = 17;
            this.label9.Text = "Made Date";
            // 
            // textBoxYear
            // 
            this.textBoxYear.Location = new System.Drawing.Point(639, 91);
            this.textBoxYear.Name = "textBoxYear";
            this.textBoxYear.Size = new System.Drawing.Size(64, 20);
            this.textBoxYear.TabIndex = 18;
            this.textBoxYear.TextChanged += new System.EventHandler(this.textBoxYear_TextChanged);
            // 
            // textBoxMonth
            // 
            this.textBoxMonth.Location = new System.Drawing.Point(727, 91);
            this.textBoxMonth.Name = "textBoxMonth";
            this.textBoxMonth.Size = new System.Drawing.Size(42, 20);
            this.textBoxMonth.TabIndex = 19;
            this.textBoxMonth.TextChanged += new System.EventHandler(this.textBoxMonth_TextChanged);
            // 
            // textBoxDay
            // 
            this.textBoxDay.Location = new System.Drawing.Point(793, 92);
            this.textBoxDay.Name = "textBoxDay";
            this.textBoxDay.Size = new System.Drawing.Size(40, 20);
            this.textBoxDay.TabIndex = 20;
            this.textBoxDay.TextChanged += new System.EventHandler(this.textBoxDay_TextChanged);
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(709, 94);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(12, 13);
            this.label10.TabIndex = 21;
            this.label10.Text = "/";
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Location = new System.Drawing.Point(775, 95);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(12, 13);
            this.label11.TabIndex = 22;
            this.label11.Text = "/";
            // 
            // buttonAdd
            // 
            this.buttonAdd.Location = new System.Drawing.Point(573, 131);
            this.buttonAdd.Name = "buttonAdd";
            this.buttonAdd.Size = new System.Drawing.Size(75, 23);
            this.buttonAdd.TabIndex = 23;
            this.buttonAdd.Text = "Add";
            this.buttonAdd.UseVisualStyleBackColor = true;
            this.buttonAdd.Click += new System.EventHandler(this.buttonAdd_Click);
            // 
            // buttonUpdate
            // 
            this.buttonUpdate.Location = new System.Drawing.Point(816, 131);
            this.buttonUpdate.Name = "buttonUpdate";
            this.buttonUpdate.Size = new System.Drawing.Size(75, 23);
            this.buttonUpdate.TabIndex = 24;
            this.buttonUpdate.Text = "Update";
            this.buttonUpdate.UseVisualStyleBackColor = true;
            this.buttonUpdate.Click += new System.EventHandler(this.buttonUpdate_Click);
            // 
            // buttonDelete
            // 
            this.buttonDelete.Location = new System.Drawing.Point(735, 131);
            this.buttonDelete.Name = "buttonDelete";
            this.buttonDelete.Size = new System.Drawing.Size(75, 23);
            this.buttonDelete.TabIndex = 25;
            this.buttonDelete.Text = "Delete";
            this.buttonDelete.UseVisualStyleBackColor = true;
            this.buttonDelete.Click += new System.EventHandler(this.buttonDelete_Click);
            // 
            // buttonDisplay
            // 
            this.buttonDisplay.Location = new System.Drawing.Point(654, 131);
            this.buttonDisplay.Name = "buttonDisplay";
            this.buttonDisplay.Size = new System.Drawing.Size(75, 23);
            this.buttonDisplay.TabIndex = 26;
            this.buttonDisplay.Text = "Display";
            this.buttonDisplay.UseVisualStyleBackColor = true;
            this.buttonDisplay.Click += new System.EventHandler(this.buttonDisplay_Click);
            // 
            // textBoxSearch
            // 
            this.textBoxSearch.Location = new System.Drawing.Point(678, 187);
            this.textBoxSearch.Name = "textBoxSearch";
            this.textBoxSearch.Size = new System.Drawing.Size(100, 20);
            this.textBoxSearch.TabIndex = 27;
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Location = new System.Drawing.Point(547, 191);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(125, 13);
            this.label12.TabIndex = 28;
            this.label12.Text = "Search By Serial Number";
            // 
            // buttonSearch
            // 
            this.buttonSearch.Location = new System.Drawing.Point(793, 184);
            this.buttonSearch.Name = "buttonSearch";
            this.buttonSearch.Size = new System.Drawing.Size(75, 23);
            this.buttonSearch.TabIndex = 29;
            this.buttonSearch.Text = "Search";
            this.buttonSearch.UseVisualStyleBackColor = true;
            this.buttonSearch.Click += new System.EventHandler(this.buttonSearch_Click);
            // 
            // listBoxDisplay
            // 
            this.listBoxDisplay.FormattingEnabled = true;
            this.listBoxDisplay.Location = new System.Drawing.Point(43, 284);
            this.listBoxDisplay.Name = "listBoxDisplay";
            this.listBoxDisplay.Size = new System.Drawing.Size(869, 121);
            this.listBoxDisplay.TabIndex = 30;
            this.listBoxDisplay.SelectedIndexChanged += new System.EventHandler(this.listBoxDisplay_SelectedIndexChanged);
            // 
            // label13
            // 
            this.label13.AutoSize = true;
            this.label13.Location = new System.Drawing.Point(53, 265);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(73, 13);
            this.label13.TabIndex = 31;
            this.label13.Text = "Serial Number";
            // 
            // label14
            // 
            this.label14.AutoSize = true;
            this.label14.Location = new System.Drawing.Point(147, 265);
            this.label14.Name = "label14";
            this.label14.Size = new System.Drawing.Size(35, 13);
            this.label14.TabIndex = 32;
            this.label14.Text = "Brand";
            // 
            // label15
            // 
            this.label15.AutoSize = true;
            this.label15.Location = new System.Drawing.Point(203, 265);
            this.label15.Name = "label15";
            this.label15.Size = new System.Drawing.Size(36, 13);
            this.label15.TabIndex = 33;
            this.label15.Text = "Model";
            // 
            // label16
            // 
            this.label16.AutoSize = true;
            this.label16.Location = new System.Drawing.Point(262, 265);
            this.label16.Name = "label16";
            this.label16.Size = new System.Drawing.Size(38, 13);
            this.label16.TabIndex = 34;
            this.label16.Text = "Speed";
            // 
            // label17
            // 
            this.label17.AutoSize = true;
            this.label17.Location = new System.Drawing.Point(329, 265);
            this.label17.Name = "label17";
            this.label17.Size = new System.Drawing.Size(31, 13);
            this.label17.TabIndex = 35;
            this.label17.Text = "Color";
            // 
            // label18
            // 
            this.label18.AutoSize = true;
            this.label18.Location = new System.Drawing.Point(379, 265);
            this.label18.Name = "label18";
            this.label18.Size = new System.Drawing.Size(62, 13);
            this.label18.TabIndex = 36;
            this.label18.Text = "Suspension";
            // 
            // HFG
            // 
            this.HFG.AutoSize = true;
            this.HFG.Location = new System.Drawing.Point(468, 264);
            this.HFG.Name = "HFG";
            this.HFG.Size = new System.Drawing.Size(102, 13);
            this.HFG.TabIndex = 37;
            this.HFG.Text = "Height From Ground";
            // 
            // seatHeight
            // 
            this.seatHeight.AutoSize = true;
            this.seatHeight.Location = new System.Drawing.Point(379, 265);
            this.seatHeight.Name = "seatHeight";
            this.seatHeight.Size = new System.Drawing.Size(63, 13);
            this.seatHeight.TabIndex = 38;
            this.seatHeight.Text = "Seat Height";
            // 
            // label21
            // 
            this.label21.AutoSize = true;
            this.label21.Location = new System.Drawing.Point(662, 265);
            this.label21.Name = "label21";
            this.label21.Size = new System.Drawing.Size(60, 13);
            this.label21.TabIndex = 39;
            this.label21.Text = "Made Date";
            // 
            // textBoxSeatHeight
            // 
            this.textBoxSeatHeight.Location = new System.Drawing.Point(402, 187);
            this.textBoxSeatHeight.Name = "textBoxSeatHeight";
            this.textBoxSeatHeight.Size = new System.Drawing.Size(121, 20);
            this.textBoxSeatHeight.TabIndex = 40;
            this.textBoxSeatHeight.TextChanged += new System.EventHandler(this.textBoxSeatHeight_TextChanged);
            // 
            // buttonDisplayMountain
            // 
            this.buttonDisplayMountain.Location = new System.Drawing.Point(413, 221);
            this.buttonDisplayMountain.Name = "buttonDisplayMountain";
            this.buttonDisplayMountain.Size = new System.Drawing.Size(102, 23);
            this.buttonDisplayMountain.TabIndex = 42;
            this.buttonDisplayMountain.Text = "Display Mountain";
            this.buttonDisplayMountain.UseVisualStyleBackColor = true;
            this.buttonDisplayMountain.Click += new System.EventHandler(this.buttonDisplayMountain_Click);
            // 
            // buttonDisplayRoad
            // 
            this.buttonDisplayRoad.Location = new System.Drawing.Point(550, 221);
            this.buttonDisplayRoad.Name = "buttonDisplayRoad";
            this.buttonDisplayRoad.Size = new System.Drawing.Size(89, 23);
            this.buttonDisplayRoad.TabIndex = 43;
            this.buttonDisplayRoad.Text = "Display Road";
            this.buttonDisplayRoad.UseVisualStyleBackColor = true;
            this.buttonDisplayRoad.Click += new System.EventHandler(this.buttonDisplayRoad_Click);
            // 
            // buttonReset
            // 
            this.buttonReset.Location = new System.Drawing.Point(896, 131);
            this.buttonReset.Name = "buttonReset";
            this.buttonReset.Size = new System.Drawing.Size(75, 23);
            this.buttonReset.TabIndex = 44;
            this.buttonReset.Text = "Reset";
            this.buttonReset.UseVisualStyleBackColor = true;
            this.buttonReset.Click += new System.EventHandler(this.buttonReset_Click);
            // 
            // menuStrip1
            // 
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.fileToolStripMenuItem,
            this.readToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(983, 24);
            this.menuStrip1.TabIndex = 45;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // fileToolStripMenuItem
            // 
            this.fileToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.saveTxt,
            this.saveXml,
            this.saveBin});
            this.fileToolStripMenuItem.Name = "fileToolStripMenuItem";
            this.fileToolStripMenuItem.Size = new System.Drawing.Size(43, 20);
            this.fileToolStripMenuItem.Text = "Save";
            // 
            // saveTxt
            // 
            this.saveTxt.Enabled = false;
            this.saveTxt.Name = "saveTxt";
            this.saveTxt.Size = new System.Drawing.Size(131, 22);
            this.saveTxt.Text = "Save (.txt)";
            this.saveTxt.Click += new System.EventHandler(this.saveTxt_Click);
            // 
            // saveXml
            // 
            this.saveXml.Name = "saveXml";
            this.saveXml.Size = new System.Drawing.Size(131, 22);
            this.saveXml.Text = "Save (.xml)";
            this.saveXml.Click += new System.EventHandler(this.saveXml_Click);
            // 
            // saveBin
            // 
            this.saveBin.Enabled = false;
            this.saveBin.Name = "saveBin";
            this.saveBin.Size = new System.Drawing.Size(131, 22);
            this.saveBin.Text = "Save (.bin)";
            this.saveBin.Click += new System.EventHandler(this.saveBin_Click);
            // 
            // readToolStripMenuItem
            // 
            this.readToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.readtxtToolStripMenuItem,
            this.readxmlToolStripMenuItem,
            this.readbinToolStripMenuItem});
            this.readToolStripMenuItem.Name = "readToolStripMenuItem";
            this.readToolStripMenuItem.Size = new System.Drawing.Size(45, 20);
            this.readToolStripMenuItem.Text = "Read";
            // 
            // readtxtToolStripMenuItem
            // 
            this.readtxtToolStripMenuItem.Enabled = false;
            this.readtxtToolStripMenuItem.Name = "readtxtToolStripMenuItem";
            this.readtxtToolStripMenuItem.Size = new System.Drawing.Size(133, 22);
            this.readtxtToolStripMenuItem.Text = "Read (.txt)";
            this.readtxtToolStripMenuItem.Click += new System.EventHandler(this.readtxtToolStripMenuItem_Click);
            // 
            // readxmlToolStripMenuItem
            // 
            this.readxmlToolStripMenuItem.Name = "readxmlToolStripMenuItem";
            this.readxmlToolStripMenuItem.Size = new System.Drawing.Size(133, 22);
            this.readxmlToolStripMenuItem.Text = "Read (.xml)";
            this.readxmlToolStripMenuItem.Click += new System.EventHandler(this.readxmlToolStripMenuItem_Click);
            // 
            // readbinToolStripMenuItem
            // 
            this.readbinToolStripMenuItem.Enabled = false;
            this.readbinToolStripMenuItem.Name = "readbinToolStripMenuItem";
            this.readbinToolStripMenuItem.Size = new System.Drawing.Size(133, 22);
            this.readbinToolStripMenuItem.Text = "Read (.bin)";
            this.readbinToolStripMenuItem.Click += new System.EventHandler(this.readbinToolStripMenuItem_Click);
            // 
            // errorProvider1
            // 
            this.errorProvider1.BlinkStyle = System.Windows.Forms.ErrorBlinkStyle.NeverBlink;
            this.errorProvider1.ContainerControl = this;
            this.errorProvider1.Icon = ((System.Drawing.Icon)(resources.GetObject("errorProvider1.Icon")));
            // 
            // errorProvider2
            // 
            this.errorProvider2.BlinkStyle = System.Windows.Forms.ErrorBlinkStyle.NeverBlink;
            this.errorProvider2.ContainerControl = this;
            // 
            // errorProvider3
            // 
            this.errorProvider3.BlinkStyle = System.Windows.Forms.ErrorBlinkStyle.NeverBlink;
            this.errorProvider3.ContainerControl = this;
            // 
            // errorProvider4
            // 
            this.errorProvider4.BlinkStyle = System.Windows.Forms.ErrorBlinkStyle.NeverBlink;
            this.errorProvider4.ContainerControl = this;
            // 
            // errorProvider5
            // 
            this.errorProvider5.BlinkStyle = System.Windows.Forms.ErrorBlinkStyle.NeverBlink;
            this.errorProvider5.ContainerControl = this;
            // 
            // errorProvider7
            // 
            this.errorProvider7.BlinkStyle = System.Windows.Forms.ErrorBlinkStyle.NeverBlink;
            this.errorProvider7.ContainerControl = this;
            // 
            // errorProvider8
            // 
            this.errorProvider8.BlinkStyle = System.Windows.Forms.ErrorBlinkStyle.NeverBlink;
            this.errorProvider8.ContainerControl = this;
            // 
            // errorProvider9
            // 
            this.errorProvider9.BlinkStyle = System.Windows.Forms.ErrorBlinkStyle.NeverBlink;
            this.errorProvider9.ContainerControl = this;
            // 
            // errorProvider6
            // 
            this.errorProvider6.BlinkStyle = System.Windows.Forms.ErrorBlinkStyle.NeverBlink;
            this.errorProvider6.ContainerControl = this;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(983, 450);
            this.Controls.Add(this.buttonReset);
            this.Controls.Add(this.buttonDisplayRoad);
            this.Controls.Add(this.buttonDisplayMountain);
            this.Controls.Add(this.textBoxSeatHeight);
            this.Controls.Add(this.label21);
            this.Controls.Add(this.seatHeight);
            this.Controls.Add(this.HFG);
            this.Controls.Add(this.label18);
            this.Controls.Add(this.label17);
            this.Controls.Add(this.label16);
            this.Controls.Add(this.label15);
            this.Controls.Add(this.label14);
            this.Controls.Add(this.label13);
            this.Controls.Add(this.listBoxDisplay);
            this.Controls.Add(this.buttonSearch);
            this.Controls.Add(this.label12);
            this.Controls.Add(this.textBoxSearch);
            this.Controls.Add(this.buttonDisplay);
            this.Controls.Add(this.buttonDelete);
            this.Controls.Add(this.buttonUpdate);
            this.Controls.Add(this.buttonAdd);
            this.Controls.Add(this.label11);
            this.Controls.Add(this.label10);
            this.Controls.Add(this.textBoxDay);
            this.Controls.Add(this.textBoxMonth);
            this.Controls.Add(this.textBoxYear);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.textBoxHFG);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.comboBoxSuspension);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.comboBoxColor);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.textBoxSpeed);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.textBoxModel);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.textBoxBrand);
            this.Controls.Add(this.textBoxSerialNumber);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.menuStrip1);
            this.Name = "Form1";
            this.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.Text = "MyBikes";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider3)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider4)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider5)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider7)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider8)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider9)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider6)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.RadioButton radioButtonRoad;
        private System.Windows.Forms.RadioButton radioButtonMountain;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox textBoxSerialNumber;
        private System.Windows.Forms.TextBox textBoxBrand;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox textBoxModel;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox textBoxSpeed;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.ComboBox comboBoxColor;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.ComboBox comboBoxSuspension;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.TextBox textBoxHFG;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.TextBox textBoxYear;
        private System.Windows.Forms.TextBox textBoxMonth;
        private System.Windows.Forms.TextBox textBoxDay;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.Button buttonAdd;
        private System.Windows.Forms.Button buttonUpdate;
        private System.Windows.Forms.Button buttonDelete;
        private System.Windows.Forms.Button buttonDisplay;
        private System.Windows.Forms.TextBox textBoxSearch;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.Button buttonSearch;
        private System.Windows.Forms.ListBox listBoxDisplay;
        private System.Windows.Forms.Label label13;
        private System.Windows.Forms.Label label14;
        private System.Windows.Forms.Label label15;
        private System.Windows.Forms.Label label16;
        private System.Windows.Forms.Label label17;
        private System.Windows.Forms.Label label18;
        private System.Windows.Forms.Label HFG;
        private System.Windows.Forms.Label seatHeight;
        private System.Windows.Forms.Label label21;
        private System.Windows.Forms.TextBox textBoxSeatHeight;
        private System.Windows.Forms.Button buttonDisplayMountain;
        private System.Windows.Forms.Button buttonDisplayRoad;
        private System.Windows.Forms.Button buttonReset;
        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem fileToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem saveXml;
        private System.Windows.Forms.ToolStripMenuItem saveTxt;
        private System.Windows.Forms.ToolStripMenuItem saveBin;
        private System.Windows.Forms.ToolStripMenuItem readToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem readtxtToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem readxmlToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem readbinToolStripMenuItem;
        private System.Windows.Forms.ErrorProvider errorProvider1;
        private System.Windows.Forms.ErrorProvider errorProvider2;
        private System.Windows.Forms.ErrorProvider errorProvider3;
        private System.Windows.Forms.ErrorProvider errorProvider4;
        private System.Windows.Forms.ErrorProvider errorProvider5;
        private System.Windows.Forms.ErrorProvider errorProvider7;
        private System.Windows.Forms.ErrorProvider errorProvider8;
        private System.Windows.Forms.ErrorProvider errorProvider9;
        private System.Windows.Forms.ErrorProvider errorProvider6;
    }
}

