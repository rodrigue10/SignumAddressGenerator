
namespace SignumAddressGenerator
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
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.tmr = new System.Windows.Forms.Timer(this.components);
            this.Label9 = new System.Windows.Forms.Label();
            this.GroupBox2 = new System.Windows.Forms.GroupBox();
            this.label14 = new System.Windows.Forms.Label();
            this.txtAcct = new System.Windows.Forms.TextBox();
            this.txtPass = new System.Windows.Forms.RichTextBox();
            this.txtAddress = new System.Windows.Forms.TextBox();
            this.Label8 = new System.Windows.Forms.Label();
            this.Label7 = new System.Windows.Forms.Label();
            this.btnSave = new System.Windows.Forms.Button();
            this.GroupBox1 = new System.Windows.Forms.GroupBox();
            this.label19 = new System.Windows.Forms.Label();
            this.lblGenStatus = new System.Windows.Forms.Label();
            this.GroupAddress = new System.Windows.Forms.GroupBox();
            this.Label1 = new System.Windows.Forms.Label();
            this.txtFind1 = new System.Windows.Forms.TextBox();
            this.Label10 = new System.Windows.Forms.Label();
            this.txtFind4 = new System.Windows.Forms.TextBox();
            this.Label12 = new System.Windows.Forms.Label();
            this.txtFind2 = new System.Windows.Forms.TextBox();
            this.Label11 = new System.Windows.Forms.Label();
            this.txtFind3 = new System.Windows.Forms.TextBox();
            this.GroupOptions = new System.Windows.Forms.GroupBox();
            this.label17 = new System.Windows.Forms.Label();
            this.Label2 = new System.Windows.Forms.Label();
            this.label13 = new System.Windows.Forms.Label();
            this.nrThreads = new System.Windows.Forms.NumericUpDown();
            this.Label3 = new System.Windows.Forms.Label();
            this.nrPassMin = new System.Windows.Forms.NumericUpDown();
            this.Label4 = new System.Windows.Forms.Label();
            this.nrPass = new System.Windows.Forms.NumericUpDown();
            this.UseWords = new System.Windows.Forms.CheckBox();
            this.lblTested = new System.Windows.Forms.Label();
            this.lblTesting = new System.Windows.Forms.Label();
            this.Label6 = new System.Windows.Forms.Label();
            this.btnStart = new System.Windows.Forms.Button();
            this.Label5 = new System.Windows.Forms.Label();
            this.comboBox1 = new System.Windows.Forms.ComboBox();
            this.GroupAll = new System.Windows.Forms.GroupBox();
            this.groupBox4 = new System.Windows.Forms.GroupBox();
            this.label18 = new System.Windows.Forms.Label();
            this.label16 = new System.Windows.Forms.Label();
            this.lblNodeStatus = new System.Windows.Forms.Label();
            this.label15 = new System.Windows.Forms.Label();
            this.label20 = new System.Windows.Forms.Label();
            this.label21 = new System.Windows.Forms.Label();
            this.GroupBox2.SuspendLayout();
            this.GroupBox1.SuspendLayout();
            this.GroupAddress.SuspendLayout();
            this.GroupOptions.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.nrThreads)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.nrPassMin)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.nrPass)).BeginInit();
            this.GroupAll.SuspendLayout();
            this.groupBox4.SuspendLayout();
            this.SuspendLayout();
            // 
            // tmr
            // 
            this.tmr.Tick += new System.EventHandler(this.Tmr_Tick);
            // 
            // Label9
            // 
            this.Label9.AutoSize = true;
            this.Label9.BackColor = System.Drawing.Color.Transparent;
            this.Label9.Location = new System.Drawing.Point(6, 19);
            this.Label9.Name = "Label9";
            this.Label9.Size = new System.Drawing.Size(519, 45);
            this.Label9.TabIndex = 12;
            this.Label9.Text = "Replace  @  in the address boxes at the positions you would like to have your per" +
    "sonal characters.\r\nYou are not allowed to use I, O, 0 or 1.  Position 13 will on" +
    "ly accept chars 2-9 or A-H.\r\n\r\n";
            // 
            // GroupBox2
            // 
            this.GroupBox2.Controls.Add(this.label14);
            this.GroupBox2.Controls.Add(this.txtAcct);
            this.GroupBox2.Controls.Add(this.txtPass);
            this.GroupBox2.Controls.Add(this.txtAddress);
            this.GroupBox2.Controls.Add(this.Label8);
            this.GroupBox2.Controls.Add(this.Label7);
            this.GroupBox2.Controls.Add(this.btnSave);
            this.GroupBox2.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.GroupBox2.Location = new System.Drawing.Point(6, 342);
            this.GroupBox2.Name = "GroupBox2";
            this.GroupBox2.Size = new System.Drawing.Size(570, 170);
            this.GroupBox2.TabIndex = 11;
            this.GroupBox2.TabStop = false;
            this.GroupBox2.Text = "Results";
            // 
            // label14
            // 
            this.label14.AutoSize = true;
            this.label14.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label14.Location = new System.Drawing.Point(12, 68);
            this.label14.Name = "label14";
            this.label14.Size = new System.Drawing.Size(69, 15);
            this.label14.TabIndex = 13;
            this.label14.Text = "Account ID:";
            // 
            // txtAcct
            // 
            this.txtAcct.Location = new System.Drawing.Point(109, 60);
            this.txtAcct.Name = "txtAcct";
            this.txtAcct.ReadOnly = true;
            this.txtAcct.Size = new System.Drawing.Size(455, 23);
            this.txtAcct.TabIndex = 12;
            // 
            // txtPass
            // 
            this.txtPass.Location = new System.Drawing.Point(109, 100);
            this.txtPass.Name = "txtPass";
            this.txtPass.ReadOnly = true;
            this.txtPass.Size = new System.Drawing.Size(455, 64);
            this.txtPass.TabIndex = 11;
            this.txtPass.Text = "";
            // 
            // txtAddress
            // 
            this.txtAddress.Location = new System.Drawing.Point(109, 27);
            this.txtAddress.Name = "txtAddress";
            this.txtAddress.ReadOnly = true;
            this.txtAddress.Size = new System.Drawing.Size(455, 23);
            this.txtAddress.TabIndex = 10;
            // 
            // Label8
            // 
            this.Label8.AutoSize = true;
            this.Label8.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.Label8.Location = new System.Drawing.Point(12, 103);
            this.Label8.Name = "Label8";
            this.Label8.Size = new System.Drawing.Size(68, 15);
            this.Label8.TabIndex = 9;
            this.Label8.Text = "Passphrase:";
            // 
            // Label7
            // 
            this.Label7.AutoSize = true;
            this.Label7.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.Label7.Location = new System.Drawing.Point(12, 35);
            this.Label7.Name = "Label7";
            this.Label7.Size = new System.Drawing.Size(52, 15);
            this.Label7.TabIndex = 8;
            this.Label7.Text = "Address:";
            // 
            // btnSave
            // 
            this.btnSave.Location = new System.Drawing.Point(6, 138);
            this.btnSave.Name = "btnSave";
            this.btnSave.Size = new System.Drawing.Size(94, 26);
            this.btnSave.TabIndex = 1;
            this.btnSave.Text = "Save";
            this.btnSave.UseVisualStyleBackColor = true;
            this.btnSave.Click += new System.EventHandler(this.BtnSave_Click);
            // 
            // GroupBox1
            // 
            this.GroupBox1.Controls.Add(this.label19);
            this.GroupBox1.Controls.Add(this.lblGenStatus);
            this.GroupBox1.Controls.Add(this.GroupAddress);
            this.GroupBox1.Controls.Add(this.GroupOptions);
            this.GroupBox1.Controls.Add(this.lblTested);
            this.GroupBox1.Controls.Add(this.lblTesting);
            this.GroupBox1.Controls.Add(this.Label6);
            this.GroupBox1.Controls.Add(this.btnStart);
            this.GroupBox1.Controls.Add(this.Label5);
            this.GroupBox1.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.GroupBox1.Location = new System.Drawing.Point(0, 56);
            this.GroupBox1.Name = "GroupBox1";
            this.GroupBox1.Size = new System.Drawing.Size(591, 280);
            this.GroupBox1.TabIndex = 10;
            this.GroupBox1.TabStop = false;
            this.GroupBox1.Text = "Address Generation";
            // 
            // label19
            // 
            this.label19.AutoSize = true;
            this.label19.Location = new System.Drawing.Point(77, 258);
            this.label19.Name = "label19";
            this.label19.Size = new System.Drawing.Size(114, 15);
            this.label19.TabIndex = 29;
            this.label19.Text = "Generation Status: ";
            // 
            // lblGenStatus
            // 
            this.lblGenStatus.AutoSize = true;
            this.lblGenStatus.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.lblGenStatus.Location = new System.Drawing.Point(197, 258);
            this.lblGenStatus.Name = "lblGenStatus";
            this.lblGenStatus.Size = new System.Drawing.Size(73, 15);
            this.lblGenStatus.TabIndex = 28;
            this.lblGenStatus.Text = "lblGenStatus";
            // 
            // GroupAddress
            // 
            this.GroupAddress.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.GroupAddress.Controls.Add(this.Label1);
            this.GroupAddress.Controls.Add(this.txtFind1);
            this.GroupAddress.Controls.Add(this.Label10);
            this.GroupAddress.Controls.Add(this.txtFind4);
            this.GroupAddress.Controls.Add(this.Label12);
            this.GroupAddress.Controls.Add(this.txtFind2);
            this.GroupAddress.Controls.Add(this.Label11);
            this.GroupAddress.Controls.Add(this.txtFind3);
            this.GroupAddress.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.GroupAddress.Location = new System.Drawing.Point(123, 11);
            this.GroupAddress.Name = "GroupAddress";
            this.GroupAddress.Size = new System.Drawing.Size(333, 48);
            this.GroupAddress.TabIndex = 22;
            this.GroupAddress.TabStop = false;
            // 
            // Label1
            // 
            this.Label1.AutoSize = true;
            this.Label1.Location = new System.Drawing.Point(6, 19);
            this.Label1.Name = "Label1";
            this.Label1.Size = new System.Drawing.Size(19, 15);
            this.Label1.TabIndex = 2;
            this.Label1.Text = "S-";
            // 
            // txtFind1
            // 
            this.txtFind1.Location = new System.Drawing.Point(30, 16);
            this.txtFind1.Name = "txtFind1";
            this.txtFind1.Size = new System.Drawing.Size(51, 23);
            this.txtFind1.TabIndex = 12;
            this.txtFind1.Text = "@@@@";
            this.txtFind1.TextChanged += new System.EventHandler(this.TxtFind1_TextChanged);
            // 
            // Label10
            // 
            this.Label10.AutoSize = true;
            this.Label10.Location = new System.Drawing.Point(87, 19);
            this.Label10.Name = "Label10";
            this.Label10.Size = new System.Drawing.Size(12, 15);
            this.Label10.TabIndex = 16;
            this.Label10.Text = "-";
            // 
            // txtFind4
            // 
            this.txtFind4.Location = new System.Drawing.Point(261, 16);
            this.txtFind4.Name = "txtFind4";
            this.txtFind4.Size = new System.Drawing.Size(64, 23);
            this.txtFind4.TabIndex = 15;
            this.txtFind4.Text = "@@@@@";
            this.txtFind4.TextChanged += new System.EventHandler(this.TxtFind4_TextChanged);
            this.txtFind4.KeyDown += new System.Windows.Forms.KeyEventHandler(this.TxtFind4_KeyDown);
            // 
            // Label12
            // 
            this.Label12.AutoSize = true;
            this.Label12.Location = new System.Drawing.Point(246, 19);
            this.Label12.Name = "Label12";
            this.Label12.Size = new System.Drawing.Size(12, 15);
            this.Label12.TabIndex = 18;
            this.Label12.Text = "-";
            // 
            // txtFind2
            // 
            this.txtFind2.Location = new System.Drawing.Point(105, 16);
            this.txtFind2.Name = "txtFind2";
            this.txtFind2.Size = new System.Drawing.Size(54, 23);
            this.txtFind2.TabIndex = 13;
            this.txtFind2.Text = "@@@@";
            this.txtFind2.TextChanged += new System.EventHandler(this.TxtFind2_TextChanged);
            this.txtFind2.KeyDown += new System.Windows.Forms.KeyEventHandler(this.TxtFind2_KeyDown);
            // 
            // Label11
            // 
            this.Label11.AutoSize = true;
            this.Label11.Location = new System.Drawing.Point(165, 19);
            this.Label11.Name = "Label11";
            this.Label11.Size = new System.Drawing.Size(12, 15);
            this.Label11.TabIndex = 17;
            this.Label11.Text = "-";
            // 
            // txtFind3
            // 
            this.txtFind3.Location = new System.Drawing.Point(183, 16);
            this.txtFind3.Name = "txtFind3";
            this.txtFind3.Size = new System.Drawing.Size(57, 23);
            this.txtFind3.TabIndex = 14;
            this.txtFind3.Text = "@@@@";
            this.txtFind3.TextChanged += new System.EventHandler(this.TxtFind3_TextChanged);
            this.txtFind3.KeyDown += new System.Windows.Forms.KeyEventHandler(this.TxtFind3_KeyDown);
            // 
            // GroupOptions
            // 
            this.GroupOptions.Controls.Add(this.label17);
            this.GroupOptions.Controls.Add(this.Label2);
            this.GroupOptions.Controls.Add(this.label13);
            this.GroupOptions.Controls.Add(this.nrThreads);
            this.GroupOptions.Controls.Add(this.Label3);
            this.GroupOptions.Controls.Add(this.nrPassMin);
            this.GroupOptions.Controls.Add(this.Label4);
            this.GroupOptions.Controls.Add(this.nrPass);
            this.GroupOptions.Controls.Add(this.UseWords);
            this.GroupOptions.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.GroupOptions.Location = new System.Drawing.Point(6, 56);
            this.GroupOptions.Name = "GroupOptions";
            this.GroupOptions.Size = new System.Drawing.Size(585, 132);
            this.GroupOptions.TabIndex = 21;
            this.GroupOptions.TabStop = false;
            this.GroupOptions.Text = "Options";
            // 
            // label17
            // 
            this.label17.AutoSize = true;
            this.label17.BackColor = System.Drawing.Color.Transparent;
            this.label17.Location = new System.Drawing.Point(331, 13);
            this.label17.Name = "label17";
            this.label17.Size = new System.Drawing.Size(192, 30);
            this.label17.TabIndex = 14;
            this.label17.Text = "Process is CPU efficient at available\r\nCORE count vs. THREAD count.\r\n";
            // 
            // Label2
            // 
            this.Label2.AutoSize = true;
            this.Label2.Location = new System.Drawing.Point(26, 19);
            this.Label2.Name = "Label2";
            this.Label2.Size = new System.Drawing.Size(51, 15);
            this.Label2.TabIndex = 3;
            this.Label2.Text = "Threads:";
            // 
            // label13
            // 
            this.label13.AutoSize = true;
            this.label13.BackColor = System.Drawing.Color.Transparent;
            this.label13.Location = new System.Drawing.Point(331, 62);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(227, 30);
            this.label13.TabIndex = 13;
            this.label13.Text = "The more words/characters you select the\r\nlonger it will take to create the addre" +
    "ss.\r\n";
            // 
            // nrThreads
            // 
            this.nrThreads.Location = new System.Drawing.Point(216, 11);
            this.nrThreads.Name = "nrThreads";
            this.nrThreads.Size = new System.Drawing.Size(100, 23);
            this.nrThreads.TabIndex = 11;
            // 
            // Label3
            // 
            this.Label3.AutoSize = true;
            this.Label3.Location = new System.Drawing.Point(26, 48);
            this.Label3.Name = "Label3";
            this.Label3.Size = new System.Drawing.Size(103, 15);
            this.Label3.TabIndex = 4;
            this.Label3.Text = "Min Words/Chars:";
            // 
            // nrPassMin
            // 
            this.nrPassMin.Location = new System.Drawing.Point(216, 40);
            this.nrPassMin.Maximum = new decimal(new int[] {
            999,
            0,
            0,
            0});
            this.nrPassMin.Minimum = new decimal(new int[] {
            12,
            0,
            0,
            0});
            this.nrPassMin.Name = "nrPassMin";
            this.nrPassMin.Size = new System.Drawing.Size(100, 23);
            this.nrPassMin.TabIndex = 10;
            this.nrPassMin.Value = new decimal(new int[] {
            12,
            0,
            0,
            0});
            this.nrPassMin.ValueChanged += new System.EventHandler(this.NrPassMin_ValueChanged);
            // 
            // Label4
            // 
            this.Label4.AutoSize = true;
            this.Label4.Location = new System.Drawing.Point(24, 77);
            this.Label4.Name = "Label4";
            this.Label4.Size = new System.Drawing.Size(105, 15);
            this.Label4.TabIndex = 5;
            this.Label4.Text = "Max Words/Chars:";
            // 
            // nrPass
            // 
            this.nrPass.Location = new System.Drawing.Point(214, 69);
            this.nrPass.Maximum = new decimal(new int[] {
            1000,
            0,
            0,
            0});
            this.nrPass.Minimum = new decimal(new int[] {
            12,
            0,
            0,
            0});
            this.nrPass.Name = "nrPass";
            this.nrPass.Size = new System.Drawing.Size(102, 23);
            this.nrPass.TabIndex = 9;
            this.nrPass.Value = new decimal(new int[] {
            12,
            0,
            0,
            0});
            this.nrPass.ValueChanged += new System.EventHandler(this.NrPass_ValueChanged);
            // 
            // UseWords
            // 
            this.UseWords.AutoSize = true;
            this.UseWords.CheckAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.UseWords.Checked = true;
            this.UseWords.CheckState = System.Windows.Forms.CheckState.Checked;
            this.UseWords.Location = new System.Drawing.Point(26, 109);
            this.UseWords.Name = "UseWords";
            this.UseWords.Size = new System.Drawing.Size(196, 19);
            this.UseWords.TabIndex = 8;
            this.UseWords.Text = "Use Words Instead of Characters";
            this.UseWords.UseVisualStyleBackColor = true;
            this.UseWords.CheckedChanged += new System.EventHandler(this.UseWords_CheckedChanged);
            // 
            // lblTested
            // 
            this.lblTested.AutoSize = true;
            this.lblTested.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.lblTested.Location = new System.Drawing.Point(312, 190);
            this.lblTested.Name = "lblTested";
            this.lblTested.Size = new System.Drawing.Size(13, 15);
            this.lblTested.TabIndex = 20;
            this.lblTested.Text = "0";
            // 
            // lblTesting
            // 
            this.lblTesting.AutoSize = true;
            this.lblTesting.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.lblTesting.Location = new System.Drawing.Point(312, 222);
            this.lblTesting.Name = "lblTesting";
            this.lblTesting.Size = new System.Drawing.Size(61, 15);
            this.lblTesting.TabIndex = 19;
            this.lblTesting.Text = "0 keys/sec";
            // 
            // Label6
            // 
            this.Label6.AutoSize = true;
            this.Label6.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.Label6.Location = new System.Drawing.Point(235, 222);
            this.Label6.Name = "Label6";
            this.Label6.Size = new System.Drawing.Size(47, 15);
            this.Label6.TabIndex = 7;
            this.Label6.Text = "Testing:";
            // 
            // btnStart
            // 
            this.btnStart.Location = new System.Drawing.Point(6, 190);
            this.btnStart.Name = "btnStart";
            this.btnStart.Size = new System.Drawing.Size(216, 47);
            this.btnStart.TabIndex = 0;
            this.btnStart.Text = "Start";
            this.btnStart.UseVisualStyleBackColor = true;
            this.btnStart.Click += new System.EventHandler(this.BtnStart_Click);
            // 
            // Label5
            // 
            this.Label5.AutoSize = true;
            this.Label5.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.Label5.Location = new System.Drawing.Point(235, 190);
            this.Label5.Name = "Label5";
            this.Label5.Size = new System.Drawing.Size(71, 15);
            this.Label5.TabIndex = 6;
            this.Label5.Text = "Total Tested:";
            // 
            // comboBox1
            // 
            this.comboBox1.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboBox1.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.comboBox1.FormattingEnabled = true;
            this.comboBox1.Items.AddRange(new object[] {
            "http://localhost:8125/",
            "https://europe.signum.network/",
            "https://europe1.signum.network/",
            "https://europe2.signum.network/",
            "https://europe3.signum.network/",
            "https://brazil.signum.network/",
            "https://canada.signum.network/",
            "https://australia.signum.network/",
            "https://uk.signum.network/"});
            this.comboBox1.Location = new System.Drawing.Point(258, 19);
            this.comboBox1.Name = "comboBox1";
            this.comboBox1.Size = new System.Drawing.Size(324, 29);
            this.comboBox1.TabIndex = 24;
            this.comboBox1.SelectedValueChanged += new System.EventHandler(this.ComboBox1_SelectedValueChanged);
            // 
            // GroupAll
            // 
            this.GroupAll.BackColor = System.Drawing.Color.Transparent;
            this.GroupAll.Controls.Add(this.GroupBox2);
            this.GroupAll.Controls.Add(this.GroupBox1);
            this.GroupAll.Controls.Add(this.Label9);
            this.GroupAll.Location = new System.Drawing.Point(12, 140);
            this.GroupAll.Name = "GroupAll";
            this.GroupAll.Size = new System.Drawing.Size(591, 525);
            this.GroupAll.TabIndex = 25;
            this.GroupAll.TabStop = false;
            // 
            // groupBox4
            // 
            this.groupBox4.BackColor = System.Drawing.Color.Transparent;
            this.groupBox4.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.groupBox4.Controls.Add(this.label18);
            this.groupBox4.Controls.Add(this.label16);
            this.groupBox4.Controls.Add(this.lblNodeStatus);
            this.groupBox4.Controls.Add(this.comboBox1);
            this.groupBox4.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.groupBox4.Location = new System.Drawing.Point(12, 44);
            this.groupBox4.Name = "groupBox4";
            this.groupBox4.Size = new System.Drawing.Size(589, 100);
            this.groupBox4.TabIndex = 26;
            this.groupBox4.TabStop = false;
            this.groupBox4.Text = "Signum Node Selection";
            // 
            // label18
            // 
            this.label18.AutoSize = true;
            this.label18.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label18.Location = new System.Drawing.Point(6, 64);
            this.label18.Name = "label18";
            this.label18.Size = new System.Drawing.Size(101, 21);
            this.label18.TabIndex = 29;
            this.label18.Text = "Node Status: ";
            // 
            // label16
            // 
            this.label16.AutoSize = true;
            this.label16.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label16.Location = new System.Drawing.Point(6, 19);
            this.label16.Name = "label16";
            this.label16.Size = new System.Drawing.Size(246, 45);
            this.label16.TabIndex = 28;
            this.label16.Text = "A valid and up-to-date SRS Node is needed.\r\nPlease choose from the list of Signum" +
    " Nodes.\r\n\r\n";
            // 
            // lblNodeStatus
            // 
            this.lblNodeStatus.AutoSize = true;
            this.lblNodeStatus.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.lblNodeStatus.Location = new System.Drawing.Point(107, 64);
            this.lblNodeStatus.Name = "lblNodeStatus";
            this.lblNodeStatus.Size = new System.Drawing.Size(119, 21);
            this.lblNodeStatus.TabIndex = 27;
            this.lblNodeStatus.Text = "lblNodeStatus";
            // 
            // label15
            // 
            this.label15.AutoSize = true;
            this.label15.BackColor = System.Drawing.Color.Transparent;
            this.label15.Font = new System.Drawing.Font("Segoe UI", 12F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Underline))), System.Drawing.GraphicsUnit.Point);
            this.label15.ForeColor = System.Drawing.SystemColors.ControlText;
            this.label15.Location = new System.Drawing.Point(62, 671);
            this.label15.Name = "label15";
            this.label15.Size = new System.Drawing.Size(154, 21);
            this.label15.TabIndex = 30;
            this.label15.Text = "Donation Address: ";
            // 
            // label20
            // 
            this.label20.AutoSize = true;
            this.label20.BackColor = System.Drawing.Color.Transparent;
            this.label20.Font = new System.Drawing.Font("Segoe UI", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label20.Location = new System.Drawing.Point(124, 9);
            this.label20.Name = "label20";
            this.label20.Size = new System.Drawing.Size(344, 30);
            this.label20.TabIndex = 31;
            this.label20.Text = "Signum Vanity Address Generator";
            // 
            // label21
            // 
            this.label21.AutoSize = true;
            this.label21.BackColor = System.Drawing.Color.Transparent;
            this.label21.Font = new System.Drawing.Font("Segoe UI", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label21.Location = new System.Drawing.Point(240, 668);
            this.label21.Name = "label21";
            this.label21.Size = new System.Drawing.Size(262, 25);
            this.label21.TabIndex = 13;
            this.label21.Text = "S-TGS2-BU2Q-DBFR-DNATE";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(623, 717);
            this.Controls.Add(this.label21);
            this.Controls.Add(this.label20);
            this.Controls.Add(this.label15);
            this.Controls.Add(this.groupBox4);
            this.Controls.Add(this.GroupAll);
            this.DoubleBuffered = true;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "Form1";
            this.Text = "Signum Vanity Address Generator";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.Form1_FormClosing);
            this.Load += new System.EventHandler(this.Form1_Load);
            this.GroupBox2.ResumeLayout(false);
            this.GroupBox2.PerformLayout();
            this.GroupBox1.ResumeLayout(false);
            this.GroupBox1.PerformLayout();
            this.GroupAddress.ResumeLayout(false);
            this.GroupAddress.PerformLayout();
            this.GroupOptions.ResumeLayout(false);
            this.GroupOptions.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.nrThreads)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.nrPassMin)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.nrPass)).EndInit();
            this.GroupAll.ResumeLayout(false);
            this.GroupAll.PerformLayout();
            this.groupBox4.ResumeLayout(false);
            this.groupBox4.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Timer tmr;
        internal System.Windows.Forms.Label Label9;
        internal System.Windows.Forms.GroupBox GroupBox2;
        internal System.Windows.Forms.RichTextBox txtPass;
        internal System.Windows.Forms.TextBox txtAddress;
        internal System.Windows.Forms.Label Label8;
        internal System.Windows.Forms.Label Label7;
        internal System.Windows.Forms.Button btnSave;
        internal System.Windows.Forms.GroupBox GroupBox1;
        internal System.Windows.Forms.GroupBox GroupAddress;
        internal System.Windows.Forms.GroupBox GroupOptions;
        internal System.Windows.Forms.Label lblTested;
        internal System.Windows.Forms.Label lblTesting;
        internal System.Windows.Forms.Label Label6;
        internal System.Windows.Forms.Button btnStart;
        internal System.Windows.Forms.Label Label5;
        internal System.Windows.Forms.Label Label1;
        internal System.Windows.Forms.TextBox txtFind1;
        internal System.Windows.Forms.Label Label10;
        internal System.Windows.Forms.TextBox txtFind4;
        internal System.Windows.Forms.Label Label12;
        internal System.Windows.Forms.TextBox txtFind2;
        internal System.Windows.Forms.Label Label11;
        internal System.Windows.Forms.TextBox txtFind3;
        internal System.Windows.Forms.Label Label2;
        internal System.Windows.Forms.NumericUpDown nrThreads;
        internal System.Windows.Forms.Label Label3;
        internal System.Windows.Forms.NumericUpDown nrPassMin;
        internal System.Windows.Forms.Label Label4;
        internal System.Windows.Forms.NumericUpDown nrPass;
        internal System.Windows.Forms.CheckBox UseWords;
        internal System.Windows.Forms.TextBox txtAcct;
        internal System.Windows.Forms.Label label14;
        private System.Windows.Forms.ComboBox comboBox1;
        private System.Windows.Forms.GroupBox GroupAll;
        private System.Windows.Forms.GroupBox groupBox4;
        private System.Windows.Forms.Label lblNodeStatus;
        internal System.Windows.Forms.Label label16;
        private System.Windows.Forms.Label label19;
        private System.Windows.Forms.Label lblGenStatus;
        private System.Windows.Forms.Label label18;
        private System.Windows.Forms.Label label15;
        internal System.Windows.Forms.Label label17;
        internal System.Windows.Forms.Label label13;
        private System.Windows.Forms.Label label20;
        private System.Windows.Forms.Label label21;
    }
}

