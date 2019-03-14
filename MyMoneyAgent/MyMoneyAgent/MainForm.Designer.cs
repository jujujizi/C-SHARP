namespace MyMoneyAgent
{
    partial class MainForm
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
            this.musMoney = new System.Windows.Forms.MenuStrip();
            this.管理ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.tsmiLogin = new System.Windows.Forms.ToolStripMenuItem();
            this.tsmiChangeUser = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripSeparator1 = new System.Windows.Forms.ToolStripSeparator();
            this.tsmiExit = new System.Windows.Forms.ToolStripMenuItem();
            this.帮助ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.tsmiHelp = new System.Windows.Forms.ToolStripMenuItem();
            this.tsmiAbout = new System.Windows.Forms.ToolStripMenuItem();
            this.tlsMoney = new System.Windows.Forms.ToolStrip();
            this.tsbtnLogIn = new System.Windows.Forms.ToolStripButton();
            this.tsbtnChangeUser = new System.Windows.Forms.ToolStripButton();
            this.toolStripSeparator2 = new System.Windows.Forms.ToolStripSeparator();
            this.tsbtnExit = new System.Windows.Forms.ToolStripButton();
            this.toolStripSeparator3 = new System.Windows.Forms.ToolStripSeparator();
            this.stsMoney = new System.Windows.Forms.StatusStrip();
            this.tslbCurUser = new System.Windows.Forms.ToolStripStatusLabel();
            this.tpOther = new System.Windows.Forms.TabPage();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.btnAddUse = new System.Windows.Forms.Button();
            this.tbUsageDes = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.tbUsage = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.btnDelUse = new System.Windows.Forms.Button();
            this.btnLoadUse = new System.Windows.Forms.Button();
            this.lstUsage = new System.Windows.Forms.ListBox();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.tbUseTypeDes = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.tbUseType = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.btnAddType = new System.Windows.Forms.Button();
            this.btnDelType = new System.Windows.Forms.Button();
            this.btnLoadType = new System.Windows.Forms.Button();
            this.lstUseType = new System.Windows.Forms.ListBox();
            this.tabPage4 = new System.Windows.Forms.TabPage();
            this.label3 = new System.Windows.Forms.Label();
            this.dgvCardOps = new System.Windows.Forms.DataGridView();
            this.colBankNo = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colBankName = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colBankBanlance = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.panel5 = new System.Windows.Forms.Panel();
            this.btnAddCard = new System.Windows.Forms.Button();
            this.btnDelCard = new System.Windows.Forms.Button();
            this.btnMdyBanlance = new System.Windows.Forms.Button();
            this.btnFreshCard = new System.Windows.Forms.Button();
            this.treeBankCard = new System.Windows.Forms.TreeView();
            this.tabPage3 = new System.Windows.Forms.TabPage();
            this.panel4 = new System.Windows.Forms.Panel();
            this.richTextBox1 = new System.Windows.Forms.RichTextBox();
            this.date2 = new System.Windows.Forms.DateTimePicker();
            this.lbl2 = new System.Windows.Forms.Label();
            this.date1 = new System.Windows.Forms.DateTimePicker();
            this.btnAddNewOutRec = new System.Windows.Forms.Button();
            this.btnDelOutRec = new System.Windows.Forms.Button();
            this.btnModifyOutRec = new System.Windows.Forms.Button();
            this.btnLdOutRec = new System.Windows.Forms.Button();
            this.dgvOutRec = new System.Windows.Forms.DataGridView();
            this.colOutId = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colOutTime = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colOutAmount = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colOutType = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colOutUsage = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colOutRecTime = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colOutBank = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colOutDes = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.tabPage2 = new System.Windows.Forms.TabPage();
            this.panel3 = new System.Windows.Forms.Panel();
            this.richTextBox2 = new System.Windows.Forms.RichTextBox();
            this.dtpdate2 = new System.Windows.Forms.DateTimePicker();
            this.label1 = new System.Windows.Forms.Label();
            this.dtpdate1 = new System.Windows.Forms.DateTimePicker();
            this.btnAddNewIncomRec = new System.Windows.Forms.Button();
            this.btnDelIncomRec = new System.Windows.Forms.Button();
            this.btnModifyIncomRec = new System.Windows.Forms.Button();
            this.btnLdIncomRec = new System.Windows.Forms.Button();
            this.dgvInRec = new System.Windows.Forms.DataGridView();
            this.colInID = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colInInTime = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colInAmount = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colInType = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colInUsage = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colInRecTime = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colInBank = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colInDes = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.tpUserMng = new System.Windows.Forms.TabPage();
            this.panel2 = new System.Windows.Forms.Panel();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.cmbRight = new System.Windows.Forms.ComboBox();
            this.tbPwd = new System.Windows.Forms.TextBox();
            this.tbName = new System.Windows.Forms.TextBox();
            this.lblPower = new System.Windows.Forms.Label();
            this.lblPassword = new System.Windows.Forms.Label();
            this.lblName = new System.Windows.Forms.Label();
            this.panel1 = new System.Windows.Forms.Panel();
            this.btnDelUser = new System.Windows.Forms.Button();
            this.btnAddUser = new System.Windows.Forms.Button();
            this.btnModifyUser = new System.Windows.Forms.Button();
            this.btnFreshUser = new System.Windows.Forms.Button();
            this.treeUser = new System.Windows.Forms.TreeView();
            this.tabctrOps = new System.Windows.Forms.TabControl();
            this.musMoney.SuspendLayout();
            this.tlsMoney.SuspendLayout();
            this.stsMoney.SuspendLayout();
            this.tpOther.SuspendLayout();
            this.groupBox3.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.tabPage4.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvCardOps)).BeginInit();
            this.panel5.SuspendLayout();
            this.tabPage3.SuspendLayout();
            this.panel4.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvOutRec)).BeginInit();
            this.tabPage2.SuspendLayout();
            this.panel3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvInRec)).BeginInit();
            this.tpUserMng.SuspendLayout();
            this.panel2.SuspendLayout();
            this.groupBox1.SuspendLayout();
            this.panel1.SuspendLayout();
            this.tabctrOps.SuspendLayout();
            this.SuspendLayout();
            // 
            // musMoney
            // 
            this.musMoney.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.管理ToolStripMenuItem,
            this.帮助ToolStripMenuItem});
            this.musMoney.Location = new System.Drawing.Point(0, 0);
            this.musMoney.Name = "musMoney";
            this.musMoney.Size = new System.Drawing.Size(788, 25);
            this.musMoney.TabIndex = 0;
            this.musMoney.Text = "menuStrip1";
            // 
            // 管理ToolStripMenuItem
            // 
            this.管理ToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.tsmiLogin,
            this.tsmiChangeUser,
            this.toolStripSeparator1,
            this.tsmiExit});
            this.管理ToolStripMenuItem.Name = "管理ToolStripMenuItem";
            this.管理ToolStripMenuItem.Size = new System.Drawing.Size(64, 21);
            this.管理ToolStripMenuItem.Text = "管理(&M)";
            // 
            // tsmiLogin
            // 
            this.tsmiLogin.Name = "tsmiLogin";
            this.tsmiLogin.Size = new System.Drawing.Size(140, 22);
            this.tsmiLogin.Text = "登陆(&L)";
            this.tsmiLogin.Click += new System.EventHandler(this.tsmiLogin_Click);
            // 
            // tsmiChangeUser
            // 
            this.tsmiChangeUser.Name = "tsmiChangeUser";
            this.tsmiChangeUser.Size = new System.Drawing.Size(140, 22);
            this.tsmiChangeUser.Text = "切换用户(&C)";
            this.tsmiChangeUser.Click += new System.EventHandler(this.tsmiChangeUser_Click);
            // 
            // toolStripSeparator1
            // 
            this.toolStripSeparator1.Name = "toolStripSeparator1";
            this.toolStripSeparator1.Size = new System.Drawing.Size(137, 6);
            // 
            // tsmiExit
            // 
            this.tsmiExit.Name = "tsmiExit";
            this.tsmiExit.Size = new System.Drawing.Size(140, 22);
            this.tsmiExit.Text = "退出(&E)";
            this.tsmiExit.Click += new System.EventHandler(this.tsmiExit_Click);
            // 
            // 帮助ToolStripMenuItem
            // 
            this.帮助ToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.tsmiHelp,
            this.tsmiAbout});
            this.帮助ToolStripMenuItem.Name = "帮助ToolStripMenuItem";
            this.帮助ToolStripMenuItem.Size = new System.Drawing.Size(61, 21);
            this.帮助ToolStripMenuItem.Text = "帮助(&H)";
            // 
            // tsmiHelp
            // 
            this.tsmiHelp.Name = "tsmiHelp";
            this.tsmiHelp.Size = new System.Drawing.Size(136, 22);
            this.tsmiHelp.Text = "使用说明(&I)";
            this.tsmiHelp.Click += new System.EventHandler(this.tsmiHelp_Click);
            // 
            // tsmiAbout
            // 
            this.tsmiAbout.Name = "tsmiAbout";
            this.tsmiAbout.Size = new System.Drawing.Size(136, 22);
            this.tsmiAbout.Text = "关于(&A)";
            this.tsmiAbout.Click += new System.EventHandler(this.tsmiAbout_Click);
            // 
            // tlsMoney
            // 
            this.tlsMoney.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.tsbtnLogIn,
            this.tsbtnChangeUser,
            this.toolStripSeparator2,
            this.tsbtnExit,
            this.toolStripSeparator3});
            this.tlsMoney.Location = new System.Drawing.Point(0, 25);
            this.tlsMoney.Name = "tlsMoney";
            this.tlsMoney.Size = new System.Drawing.Size(788, 25);
            this.tlsMoney.TabIndex = 1;
            this.tlsMoney.Text = "toolStrip1";
            // 
            // tsbtnLogIn
            // 
            this.tsbtnLogIn.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.tsbtnLogIn.Name = "tsbtnLogIn";
            this.tsbtnLogIn.Size = new System.Drawing.Size(36, 22);
            this.tsbtnLogIn.Text = "登陆";
            this.tsbtnLogIn.Click += new System.EventHandler(this.tsbtnLogIn_Click);
            // 
            // tsbtnChangeUser
            // 
            this.tsbtnChangeUser.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.tsbtnChangeUser.Name = "tsbtnChangeUser";
            this.tsbtnChangeUser.Size = new System.Drawing.Size(60, 22);
            this.tsbtnChangeUser.Text = "切换用户";
            this.tsbtnChangeUser.Click += new System.EventHandler(this.tsbtnChangeUser_Click);
            // 
            // toolStripSeparator2
            // 
            this.toolStripSeparator2.Name = "toolStripSeparator2";
            this.toolStripSeparator2.Size = new System.Drawing.Size(6, 25);
            // 
            // tsbtnExit
            // 
            this.tsbtnExit.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.tsbtnExit.Name = "tsbtnExit";
            this.tsbtnExit.Size = new System.Drawing.Size(36, 22);
            this.tsbtnExit.Text = "退出";
            this.tsbtnExit.Click += new System.EventHandler(this.tsbtnExit_Click);
            // 
            // toolStripSeparator3
            // 
            this.toolStripSeparator3.Name = "toolStripSeparator3";
            this.toolStripSeparator3.Size = new System.Drawing.Size(6, 25);
            // 
            // stsMoney
            // 
            this.stsMoney.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.tslbCurUser});
            this.stsMoney.Location = new System.Drawing.Point(0, 531);
            this.stsMoney.Name = "stsMoney";
            this.stsMoney.Size = new System.Drawing.Size(788, 22);
            this.stsMoney.TabIndex = 3;
            // 
            // tslbCurUser
            // 
            this.tslbCurUser.Name = "tslbCurUser";
            this.tslbCurUser.Size = new System.Drawing.Size(56, 17);
            this.tslbCurUser.Text = "当前用户";
            // 
            // tpOther
            // 
            this.tpOther.BackgroundImage = global::MyMoneyAgent.Properties.Resources.主窗体;
            this.tpOther.Controls.Add(this.groupBox3);
            this.tpOther.Controls.Add(this.groupBox2);
            this.tpOther.Location = new System.Drawing.Point(4, 22);
            this.tpOther.Name = "tpOther";
            this.tpOther.Padding = new System.Windows.Forms.Padding(3);
            this.tpOther.Size = new System.Drawing.Size(768, 437);
            this.tpOther.TabIndex = 5;
            this.tpOther.Text = "其他功能";
            this.tpOther.UseVisualStyleBackColor = true;
            // 
            // groupBox3
            // 
            this.groupBox3.Controls.Add(this.btnAddUse);
            this.groupBox3.Controls.Add(this.tbUsageDes);
            this.groupBox3.Controls.Add(this.label6);
            this.groupBox3.Controls.Add(this.tbUsage);
            this.groupBox3.Controls.Add(this.label5);
            this.groupBox3.Controls.Add(this.btnDelUse);
            this.groupBox3.Controls.Add(this.btnLoadUse);
            this.groupBox3.Controls.Add(this.lstUsage);
            this.groupBox3.Location = new System.Drawing.Point(402, 27);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(321, 349);
            this.groupBox3.TabIndex = 1;
            this.groupBox3.TabStop = false;
            this.groupBox3.Text = "用途分类管理";
            // 
            // btnAddUse
            // 
            this.btnAddUse.Location = new System.Drawing.Point(203, 294);
            this.btnAddUse.Name = "btnAddUse";
            this.btnAddUse.Size = new System.Drawing.Size(89, 35);
            this.btnAddUse.TabIndex = 7;
            this.btnAddUse.Text = "添加新用途";
            this.btnAddUse.UseVisualStyleBackColor = true;
            this.btnAddUse.Click += new System.EventHandler(this.btnAddUse_Click);
            // 
            // tbUsageDes
            // 
            this.tbUsageDes.Location = new System.Drawing.Point(203, 222);
            this.tbUsageDes.Multiline = true;
            this.tbUsageDes.Name = "tbUsageDes";
            this.tbUsageDes.Size = new System.Drawing.Size(100, 66);
            this.tbUsageDes.TabIndex = 6;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(201, 191);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(53, 12);
            this.label6.TabIndex = 5;
            this.label6.Text = "用途说明";
            // 
            // tbUsage
            // 
            this.tbUsage.Location = new System.Drawing.Point(203, 158);
            this.tbUsage.Name = "tbUsage";
            this.tbUsage.Size = new System.Drawing.Size(100, 21);
            this.tbUsage.TabIndex = 4;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(201, 133);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(29, 12);
            this.label5.TabIndex = 3;
            this.label5.Text = "用途";
            // 
            // btnDelUse
            // 
            this.btnDelUse.Location = new System.Drawing.Point(203, 90);
            this.btnDelUse.Name = "btnDelUse";
            this.btnDelUse.Size = new System.Drawing.Size(100, 39);
            this.btnDelUse.TabIndex = 2;
            this.btnDelUse.Text = "删除选中用途";
            this.btnDelUse.UseVisualStyleBackColor = true;
            this.btnDelUse.Click += new System.EventHandler(this.btnDelUse_Click);
            // 
            // btnLoadUse
            // 
            this.btnLoadUse.Location = new System.Drawing.Point(203, 41);
            this.btnLoadUse.Name = "btnLoadUse";
            this.btnLoadUse.Size = new System.Drawing.Size(100, 42);
            this.btnLoadUse.TabIndex = 1;
            this.btnLoadUse.Text = "加载现有用途";
            this.btnLoadUse.UseVisualStyleBackColor = true;
            this.btnLoadUse.Click += new System.EventHandler(this.btnLoadUse_Click);
            // 
            // lstUsage
            // 
            this.lstUsage.FormattingEnabled = true;
            this.lstUsage.ItemHeight = 12;
            this.lstUsage.Location = new System.Drawing.Point(21, 37);
            this.lstUsage.Name = "lstUsage";
            this.lstUsage.Size = new System.Drawing.Size(162, 292);
            this.lstUsage.TabIndex = 0;
            this.lstUsage.SelectedIndexChanged += new System.EventHandler(this.lstUsage_SelectedIndexChanged);
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.tbUseTypeDes);
            this.groupBox2.Controls.Add(this.label4);
            this.groupBox2.Controls.Add(this.tbUseType);
            this.groupBox2.Controls.Add(this.label2);
            this.groupBox2.Controls.Add(this.btnAddType);
            this.groupBox2.Controls.Add(this.btnDelType);
            this.groupBox2.Controls.Add(this.btnLoadType);
            this.groupBox2.Controls.Add(this.lstUseType);
            this.groupBox2.Location = new System.Drawing.Point(27, 27);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(310, 349);
            this.groupBox2.TabIndex = 0;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "消费方式管理";
            // 
            // tbUseTypeDes
            // 
            this.tbUseTypeDes.Location = new System.Drawing.Point(197, 222);
            this.tbUseTypeDes.Multiline = true;
            this.tbUseTypeDes.Name = "tbUseTypeDes";
            this.tbUseTypeDes.Size = new System.Drawing.Size(103, 66);
            this.tbUseTypeDes.TabIndex = 7;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(199, 191);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(53, 12);
            this.label4.TabIndex = 6;
            this.label4.Text = "方式说明";
            // 
            // tbUseType
            // 
            this.tbUseType.Location = new System.Drawing.Point(201, 158);
            this.tbUseType.Name = "tbUseType";
            this.tbUseType.Size = new System.Drawing.Size(100, 21);
            this.tbUseType.TabIndex = 5;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(199, 133);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(29, 12);
            this.label2.TabIndex = 4;
            this.label2.Text = "方式";
            // 
            // btnAddType
            // 
            this.btnAddType.Location = new System.Drawing.Point(197, 294);
            this.btnAddType.Name = "btnAddType";
            this.btnAddType.Size = new System.Drawing.Size(95, 35);
            this.btnAddType.TabIndex = 3;
            this.btnAddType.Text = "添加新方式";
            this.btnAddType.UseVisualStyleBackColor = true;
            this.btnAddType.Click += new System.EventHandler(this.btnAddType_Click);
            // 
            // btnDelType
            // 
            this.btnDelType.Location = new System.Drawing.Point(197, 89);
            this.btnDelType.Name = "btnDelType";
            this.btnDelType.Size = new System.Drawing.Size(99, 40);
            this.btnDelType.TabIndex = 2;
            this.btnDelType.Text = "删除选中方式";
            this.btnDelType.UseVisualStyleBackColor = true;
            this.btnDelType.Click += new System.EventHandler(this.btnDelType_Click);
            // 
            // btnLoadType
            // 
            this.btnLoadType.Location = new System.Drawing.Point(197, 41);
            this.btnLoadType.Name = "btnLoadType";
            this.btnLoadType.Size = new System.Drawing.Size(99, 42);
            this.btnLoadType.TabIndex = 1;
            this.btnLoadType.Text = "加载现有方式";
            this.btnLoadType.UseVisualStyleBackColor = true;
            this.btnLoadType.Click += new System.EventHandler(this.btnLoadType_Click);
            // 
            // lstUseType
            // 
            this.lstUseType.FormattingEnabled = true;
            this.lstUseType.ItemHeight = 12;
            this.lstUseType.Location = new System.Drawing.Point(19, 37);
            this.lstUseType.Name = "lstUseType";
            this.lstUseType.Size = new System.Drawing.Size(160, 292);
            this.lstUseType.TabIndex = 0;
            this.lstUseType.SelectedIndexChanged += new System.EventHandler(this.lstUseType_SelectedIndexChanged);
            // 
            // tabPage4
            // 
            this.tabPage4.BackgroundImage = global::MyMoneyAgent.Properties.Resources.主窗体;
            this.tabPage4.Controls.Add(this.label3);
            this.tabPage4.Controls.Add(this.dgvCardOps);
            this.tabPage4.Controls.Add(this.panel5);
            this.tabPage4.Controls.Add(this.treeBankCard);
            this.tabPage4.Location = new System.Drawing.Point(4, 22);
            this.tabPage4.Name = "tabPage4";
            this.tabPage4.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage4.Size = new System.Drawing.Size(768, 437);
            this.tabPage4.TabIndex = 3;
            this.tabPage4.Text = "银行卡管理";
            this.tabPage4.UseVisualStyleBackColor = true;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.ForeColor = System.Drawing.SystemColors.Highlight;
            this.label3.Location = new System.Drawing.Point(330, 395);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(395, 12);
            this.label3.TabIndex = 3;
            this.label3.Text = "提示：选中行再按<Del>可删除该行数据。双击末尾空行，可添加新记录。";
            // 
            // dgvCardOps
            // 
            this.dgvCardOps.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvCardOps.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.colBankNo,
            this.colBankName,
            this.colBankBanlance});
            this.dgvCardOps.Location = new System.Drawing.Point(275, 6);
            this.dgvCardOps.Name = "dgvCardOps";
            this.dgvCardOps.RowTemplate.Height = 23;
            this.dgvCardOps.Size = new System.Drawing.Size(487, 359);
            this.dgvCardOps.TabIndex = 2;
            // 
            // colBankNo
            // 
            this.colBankNo.HeaderText = "卡号";
            this.colBankNo.Name = "colBankNo";
            this.colBankNo.Width = 170;
            // 
            // colBankName
            // 
            this.colBankName.HeaderText = "开户银行";
            this.colBankName.Name = "colBankName";
            this.colBankName.Width = 130;
            // 
            // colBankBanlance
            // 
            this.colBankBanlance.HeaderText = "余额";
            this.colBankBanlance.Name = "colBankBanlance";
            this.colBankBanlance.Width = 145;
            // 
            // panel5
            // 
            this.panel5.Controls.Add(this.btnAddCard);
            this.panel5.Controls.Add(this.btnDelCard);
            this.panel5.Controls.Add(this.btnMdyBanlance);
            this.panel5.Controls.Add(this.btnFreshCard);
            this.panel5.Location = new System.Drawing.Point(17, 332);
            this.panel5.Name = "panel5";
            this.panel5.Size = new System.Drawing.Size(251, 99);
            this.panel5.TabIndex = 1;
            // 
            // btnAddCard
            // 
            this.btnAddCard.Location = new System.Drawing.Point(16, 52);
            this.btnAddCard.Name = "btnAddCard";
            this.btnAddCard.Size = new System.Drawing.Size(75, 35);
            this.btnAddCard.TabIndex = 3;
            this.btnAddCard.Text = "添加银行卡";
            this.btnAddCard.UseVisualStyleBackColor = true;
            this.btnAddCard.Click += new System.EventHandler(this.btnAddCard_Click);
            // 
            // btnDelCard
            // 
            this.btnDelCard.Location = new System.Drawing.Point(97, 52);
            this.btnDelCard.Name = "btnDelCard";
            this.btnDelCard.Size = new System.Drawing.Size(75, 35);
            this.btnDelCard.TabIndex = 2;
            this.btnDelCard.Text = "删除银行卡";
            this.btnDelCard.UseVisualStyleBackColor = true;
            this.btnDelCard.Click += new System.EventHandler(this.btnDelCard_Click);
            // 
            // btnMdyBanlance
            // 
            this.btnMdyBanlance.Location = new System.Drawing.Point(97, 9);
            this.btnMdyBanlance.Name = "btnMdyBanlance";
            this.btnMdyBanlance.Size = new System.Drawing.Size(75, 37);
            this.btnMdyBanlance.TabIndex = 1;
            this.btnMdyBanlance.Text = "修改余额";
            this.btnMdyBanlance.UseVisualStyleBackColor = true;
            this.btnMdyBanlance.Click += new System.EventHandler(this.btnMdyBanlance_Click);
            // 
            // btnFreshCard
            // 
            this.btnFreshCard.Location = new System.Drawing.Point(16, 7);
            this.btnFreshCard.Name = "btnFreshCard";
            this.btnFreshCard.Size = new System.Drawing.Size(75, 37);
            this.btnFreshCard.TabIndex = 0;
            this.btnFreshCard.Text = "刷新银行卡";
            this.btnFreshCard.UseVisualStyleBackColor = true;
            this.btnFreshCard.Click += new System.EventHandler(this.btnFreshCard_Click);
            // 
            // treeBankCard
            // 
            this.treeBankCard.Location = new System.Drawing.Point(13, 12);
            this.treeBankCard.Name = "treeBankCard";
            this.treeBankCard.Size = new System.Drawing.Size(256, 314);
            this.treeBankCard.TabIndex = 0;
            this.treeBankCard.AfterSelect += new System.Windows.Forms.TreeViewEventHandler(this.treeBankCard_AfterSelect);
            // 
            // tabPage3
            // 
            this.tabPage3.Controls.Add(this.panel4);
            this.tabPage3.Controls.Add(this.dgvOutRec);
            this.tabPage3.Location = new System.Drawing.Point(4, 22);
            this.tabPage3.Name = "tabPage3";
            this.tabPage3.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage3.Size = new System.Drawing.Size(768, 437);
            this.tabPage3.TabIndex = 2;
            this.tabPage3.Text = "支出管理";
            this.tabPage3.UseVisualStyleBackColor = true;
            // 
            // panel4
            // 
            this.panel4.BackgroundImage = global::MyMoneyAgent.Properties.Resources.收入编辑对话框;
            this.panel4.Controls.Add(this.richTextBox1);
            this.panel4.Controls.Add(this.date2);
            this.panel4.Controls.Add(this.lbl2);
            this.panel4.Controls.Add(this.date1);
            this.panel4.Controls.Add(this.btnAddNewOutRec);
            this.panel4.Controls.Add(this.btnDelOutRec);
            this.panel4.Controls.Add(this.btnModifyOutRec);
            this.panel4.Controls.Add(this.btnLdOutRec);
            this.panel4.Location = new System.Drawing.Point(533, 3);
            this.panel4.Name = "panel4";
            this.panel4.Size = new System.Drawing.Size(232, 428);
            this.panel4.TabIndex = 1;
            // 
            // richTextBox1
            // 
            this.richTextBox1.ForeColor = System.Drawing.SystemColors.MenuHighlight;
            this.richTextBox1.Location = new System.Drawing.Point(3, 335);
            this.richTextBox1.Name = "richTextBox1";
            this.richTextBox1.Size = new System.Drawing.Size(226, 90);
            this.richTextBox1.TabIndex = 6;
            this.richTextBox1.Text = "点击查看选中记录详细信息，通过对应按钮执行对应的操作。提示:选中再按<Del>可删除该行数据。双击末尾空行可添加记录。";
            // 
            // date2
            // 
            this.date2.Location = new System.Drawing.Point(18, 298);
            this.date2.Name = "date2";
            this.date2.Size = new System.Drawing.Size(123, 21);
            this.date2.TabIndex = 4;
            // 
            // lbl2
            // 
            this.lbl2.AutoSize = true;
            this.lbl2.Location = new System.Drawing.Point(16, 283);
            this.lbl2.Name = "lbl2";
            this.lbl2.Size = new System.Drawing.Size(17, 12);
            this.lbl2.TabIndex = 3;
            this.lbl2.Text = "到";
            // 
            // date1
            // 
            this.date1.Location = new System.Drawing.Point(18, 259);
            this.date1.Name = "date1";
            this.date1.Size = new System.Drawing.Size(123, 21);
            this.date1.TabIndex = 2;
            // 
            // btnAddNewOutRec
            // 
            this.btnAddNewOutRec.Location = new System.Drawing.Point(18, 196);
            this.btnAddNewOutRec.Name = "btnAddNewOutRec";
            this.btnAddNewOutRec.Size = new System.Drawing.Size(140, 38);
            this.btnAddNewOutRec.TabIndex = 1;
            this.btnAddNewOutRec.Text = "添加新的支出记录";
            this.btnAddNewOutRec.UseVisualStyleBackColor = true;
            this.btnAddNewOutRec.Click += new System.EventHandler(this.btnAddNewOutRec_Click);
            // 
            // btnDelOutRec
            // 
            this.btnDelOutRec.Location = new System.Drawing.Point(18, 139);
            this.btnDelOutRec.Name = "btnDelOutRec";
            this.btnDelOutRec.Size = new System.Drawing.Size(140, 39);
            this.btnDelOutRec.TabIndex = 0;
            this.btnDelOutRec.Text = "删除选中支出记录";
            this.btnDelOutRec.UseVisualStyleBackColor = true;
            this.btnDelOutRec.Click += new System.EventHandler(this.btnDelOutRec_Click);
            // 
            // btnModifyOutRec
            // 
            this.btnModifyOutRec.Location = new System.Drawing.Point(18, 80);
            this.btnModifyOutRec.Name = "btnModifyOutRec";
            this.btnModifyOutRec.Size = new System.Drawing.Size(140, 39);
            this.btnModifyOutRec.TabIndex = 0;
            this.btnModifyOutRec.Text = "修改选中支出记录";
            this.btnModifyOutRec.UseVisualStyleBackColor = true;
            this.btnModifyOutRec.Click += new System.EventHandler(this.btnModifyOutRec_Click);
            // 
            // btnLdOutRec
            // 
            this.btnLdOutRec.Location = new System.Drawing.Point(18, 24);
            this.btnLdOutRec.Name = "btnLdOutRec";
            this.btnLdOutRec.Size = new System.Drawing.Size(140, 39);
            this.btnLdOutRec.TabIndex = 0;
            this.btnLdOutRec.Text = "加载支出记录";
            this.btnLdOutRec.UseVisualStyleBackColor = true;
            this.btnLdOutRec.Click += new System.EventHandler(this.btnLdOutRec_Click);
            // 
            // dgvOutRec
            // 
            this.dgvOutRec.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvOutRec.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.colOutId,
            this.colOutTime,
            this.colOutAmount,
            this.colOutType,
            this.colOutUsage,
            this.colOutRecTime,
            this.colOutBank,
            this.colOutDes});
            this.dgvOutRec.Location = new System.Drawing.Point(3, 0);
            this.dgvOutRec.Name = "dgvOutRec";
            this.dgvOutRec.RowTemplate.Height = 23;
            this.dgvOutRec.Size = new System.Drawing.Size(524, 431);
            this.dgvOutRec.TabIndex = 0;
            this.dgvOutRec.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvOutRec_CellContentClick);
            // 
            // colOutId
            // 
            this.colOutId.HeaderText = "支出编号";
            this.colOutId.Name = "colOutId";
            // 
            // colOutTime
            // 
            this.colOutTime.HeaderText = "支出时间";
            this.colOutTime.Name = "colOutTime";
            // 
            // colOutAmount
            // 
            this.colOutAmount.HeaderText = "支出金额";
            this.colOutAmount.Name = "colOutAmount";
            // 
            // colOutType
            // 
            this.colOutType.HeaderText = "支出类型";
            this.colOutType.Name = "colOutType";
            // 
            // colOutUsage
            // 
            this.colOutUsage.HeaderText = "支出目的";
            this.colOutUsage.Name = "colOutUsage";
            // 
            // colOutRecTime
            // 
            this.colOutRecTime.HeaderText = "最新修改";
            this.colOutRecTime.Name = "colOutRecTime";
            // 
            // colOutBank
            // 
            this.colOutBank.HeaderText = "银行卡";
            this.colOutBank.Name = "colOutBank";
            // 
            // colOutDes
            // 
            this.colOutDes.HeaderText = "支出说明";
            this.colOutDes.Name = "colOutDes";
            // 
            // tabPage2
            // 
            this.tabPage2.Controls.Add(this.panel3);
            this.tabPage2.Controls.Add(this.dgvInRec);
            this.tabPage2.Location = new System.Drawing.Point(4, 22);
            this.tabPage2.Name = "tabPage2";
            this.tabPage2.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage2.Size = new System.Drawing.Size(768, 437);
            this.tabPage2.TabIndex = 1;
            this.tabPage2.Text = "收入管理";
            this.tabPage2.UseVisualStyleBackColor = true;
            // 
            // panel3
            // 
            this.panel3.BackgroundImage = global::MyMoneyAgent.Properties.Resources.收入编辑对话框;
            this.panel3.Controls.Add(this.richTextBox2);
            this.panel3.Controls.Add(this.dtpdate2);
            this.panel3.Controls.Add(this.label1);
            this.panel3.Controls.Add(this.dtpdate1);
            this.panel3.Controls.Add(this.btnAddNewIncomRec);
            this.panel3.Controls.Add(this.btnDelIncomRec);
            this.panel3.Controls.Add(this.btnModifyIncomRec);
            this.panel3.Controls.Add(this.btnLdIncomRec);
            this.panel3.Location = new System.Drawing.Point(544, 3);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(223, 428);
            this.panel3.TabIndex = 1;
            // 
            // richTextBox2
            // 
            this.richTextBox2.ForeColor = System.Drawing.SystemColors.MenuHighlight;
            this.richTextBox2.Location = new System.Drawing.Point(3, 343);
            this.richTextBox2.Name = "richTextBox2";
            this.richTextBox2.Size = new System.Drawing.Size(215, 82);
            this.richTextBox2.TabIndex = 7;
            this.richTextBox2.Text = "点击查看选中记录详细信息，通过对应按钮执行对应的操作。提示:选中再按<Del>可删除该行数据。双击末尾空行可添加记录。";
            // 
            // dtpdate2
            // 
            this.dtpdate2.Location = new System.Drawing.Point(20, 305);
            this.dtpdate2.Name = "dtpdate2";
            this.dtpdate2.Size = new System.Drawing.Size(126, 21);
            this.dtpdate2.TabIndex = 4;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(18, 290);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(17, 12);
            this.label1.TabIndex = 3;
            this.label1.Text = "到";
            // 
            // dtpdate1
            // 
            this.dtpdate1.Location = new System.Drawing.Point(20, 266);
            this.dtpdate1.Name = "dtpdate1";
            this.dtpdate1.Size = new System.Drawing.Size(135, 21);
            this.dtpdate1.TabIndex = 2;
            // 
            // btnAddNewIncomRec
            // 
            this.btnAddNewIncomRec.Location = new System.Drawing.Point(20, 201);
            this.btnAddNewIncomRec.Name = "btnAddNewIncomRec";
            this.btnAddNewIncomRec.Size = new System.Drawing.Size(135, 39);
            this.btnAddNewIncomRec.TabIndex = 1;
            this.btnAddNewIncomRec.Text = "添加新的收入记录";
            this.btnAddNewIncomRec.UseVisualStyleBackColor = true;
            this.btnAddNewIncomRec.Click += new System.EventHandler(this.btnAddNewIncomRec_Click);
            // 
            // btnDelIncomRec
            // 
            this.btnDelIncomRec.Location = new System.Drawing.Point(20, 145);
            this.btnDelIncomRec.Name = "btnDelIncomRec";
            this.btnDelIncomRec.Size = new System.Drawing.Size(135, 40);
            this.btnDelIncomRec.TabIndex = 0;
            this.btnDelIncomRec.Text = "删除选中收入记录";
            this.btnDelIncomRec.UseVisualStyleBackColor = true;
            this.btnDelIncomRec.Click += new System.EventHandler(this.btnDelIncomRec_Click);
            // 
            // btnModifyIncomRec
            // 
            this.btnModifyIncomRec.Location = new System.Drawing.Point(20, 90);
            this.btnModifyIncomRec.Name = "btnModifyIncomRec";
            this.btnModifyIncomRec.Size = new System.Drawing.Size(135, 39);
            this.btnModifyIncomRec.TabIndex = 1;
            this.btnModifyIncomRec.Text = "修改选中收入记录";
            this.btnModifyIncomRec.UseVisualStyleBackColor = true;
            this.btnModifyIncomRec.Click += new System.EventHandler(this.btnModifyIncomRec_Click);
            // 
            // btnLdIncomRec
            // 
            this.btnLdIncomRec.Location = new System.Drawing.Point(20, 31);
            this.btnLdIncomRec.Name = "btnLdIncomRec";
            this.btnLdIncomRec.Size = new System.Drawing.Size(135, 40);
            this.btnLdIncomRec.TabIndex = 0;
            this.btnLdIncomRec.Text = "加载收入记录";
            this.btnLdIncomRec.UseVisualStyleBackColor = true;
            this.btnLdIncomRec.Click += new System.EventHandler(this.btnLdIncomRec_Click);
            // 
            // dgvInRec
            // 
            this.dgvInRec.BackgroundColor = System.Drawing.SystemColors.ActiveBorder;
            this.dgvInRec.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvInRec.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.colInID,
            this.colInInTime,
            this.colInAmount,
            this.colInType,
            this.colInUsage,
            this.colInRecTime,
            this.colInBank,
            this.colInDes});
            this.dgvInRec.Location = new System.Drawing.Point(3, 0);
            this.dgvInRec.Name = "dgvInRec";
            this.dgvInRec.RowTemplate.Height = 23;
            this.dgvInRec.Size = new System.Drawing.Size(535, 431);
            this.dgvInRec.TabIndex = 0;
            this.dgvInRec.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvInRec_CellContentClick);
            // 
            // colInID
            // 
            this.colInID.HeaderText = "收入编号";
            this.colInID.Name = "colInID";
            // 
            // colInInTime
            // 
            this.colInInTime.HeaderText = "收入时间";
            this.colInInTime.Name = "colInInTime";
            // 
            // colInAmount
            // 
            this.colInAmount.HeaderText = "收入金额";
            this.colInAmount.Name = "colInAmount";
            // 
            // colInType
            // 
            this.colInType.HeaderText = "收入方式";
            this.colInType.Name = "colInType";
            // 
            // colInUsage
            // 
            this.colInUsage.HeaderText = "收入来源";
            this.colInUsage.Name = "colInUsage";
            // 
            // colInRecTime
            // 
            this.colInRecTime.HeaderText = "最新修改";
            this.colInRecTime.Name = "colInRecTime";
            // 
            // colInBank
            // 
            this.colInBank.HeaderText = "银行卡";
            this.colInBank.Name = "colInBank";
            // 
            // colInDes
            // 
            this.colInDes.HeaderText = "收入说明";
            this.colInDes.Name = "colInDes";
            // 
            // tpUserMng
            // 
            this.tpUserMng.BackgroundImage = global::MyMoneyAgent.Properties.Resources.主窗体;
            this.tpUserMng.Controls.Add(this.panel2);
            this.tpUserMng.Controls.Add(this.panel1);
            this.tpUserMng.Controls.Add(this.treeUser);
            this.tpUserMng.Location = new System.Drawing.Point(4, 22);
            this.tpUserMng.Name = "tpUserMng";
            this.tpUserMng.Padding = new System.Windows.Forms.Padding(3);
            this.tpUserMng.Size = new System.Drawing.Size(768, 437);
            this.tpUserMng.TabIndex = 0;
            this.tpUserMng.Text = "用户管理";
            this.tpUserMng.UseVisualStyleBackColor = true;
            // 
            // panel2
            // 
            this.panel2.Controls.Add(this.groupBox1);
            this.panel2.Location = new System.Drawing.Point(313, 18);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(447, 411);
            this.panel2.TabIndex = 2;
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.cmbRight);
            this.groupBox1.Controls.Add(this.tbPwd);
            this.groupBox1.Controls.Add(this.tbName);
            this.groupBox1.Controls.Add(this.lblPower);
            this.groupBox1.Controls.Add(this.lblPassword);
            this.groupBox1.Controls.Add(this.lblName);
            this.groupBox1.Location = new System.Drawing.Point(28, 19);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(262, 169);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "选中用户";
            // 
            // cmbRight
            // 
            this.cmbRight.FormattingEnabled = true;
            this.cmbRight.Location = new System.Drawing.Point(83, 105);
            this.cmbRight.Name = "cmbRight";
            this.cmbRight.Size = new System.Drawing.Size(124, 20);
            this.cmbRight.TabIndex = 5;
            // 
            // tbPwd
            // 
            this.tbPwd.Location = new System.Drawing.Point(83, 69);
            this.tbPwd.Name = "tbPwd";
            this.tbPwd.ReadOnly = true;
            this.tbPwd.Size = new System.Drawing.Size(124, 21);
            this.tbPwd.TabIndex = 4;
            // 
            // tbName
            // 
            this.tbName.Location = new System.Drawing.Point(83, 33);
            this.tbName.Name = "tbName";
            this.tbName.ReadOnly = true;
            this.tbName.Size = new System.Drawing.Size(124, 21);
            this.tbName.TabIndex = 3;
            // 
            // lblPower
            // 
            this.lblPower.AutoSize = true;
            this.lblPower.Location = new System.Drawing.Point(24, 105);
            this.lblPower.Name = "lblPower";
            this.lblPower.Size = new System.Drawing.Size(29, 12);
            this.lblPower.TabIndex = 2;
            this.lblPower.Text = "权限";
            // 
            // lblPassword
            // 
            this.lblPassword.AutoSize = true;
            this.lblPassword.Location = new System.Drawing.Point(24, 69);
            this.lblPassword.Name = "lblPassword";
            this.lblPassword.Size = new System.Drawing.Size(29, 12);
            this.lblPassword.TabIndex = 1;
            this.lblPassword.Text = "密码";
            // 
            // lblName
            // 
            this.lblName.AutoSize = true;
            this.lblName.Location = new System.Drawing.Point(24, 36);
            this.lblName.Name = "lblName";
            this.lblName.Size = new System.Drawing.Size(29, 12);
            this.lblName.TabIndex = 0;
            this.lblName.Text = "姓名";
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.btnDelUser);
            this.panel1.Controls.Add(this.btnAddUser);
            this.panel1.Controls.Add(this.btnModifyUser);
            this.panel1.Controls.Add(this.btnFreshUser);
            this.panel1.Location = new System.Drawing.Point(16, 329);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(278, 100);
            this.panel1.TabIndex = 1;
            // 
            // btnDelUser
            // 
            this.btnDelUser.Location = new System.Drawing.Point(162, 52);
            this.btnDelUser.Name = "btnDelUser";
            this.btnDelUser.Size = new System.Drawing.Size(75, 33);
            this.btnDelUser.TabIndex = 3;
            this.btnDelUser.Text = "删除用户";
            this.btnDelUser.UseVisualStyleBackColor = true;
            this.btnDelUser.Click += new System.EventHandler(this.btnDelUser_Click);
            // 
            // btnAddUser
            // 
            this.btnAddUser.Location = new System.Drawing.Point(45, 52);
            this.btnAddUser.Name = "btnAddUser";
            this.btnAddUser.Size = new System.Drawing.Size(75, 33);
            this.btnAddUser.TabIndex = 2;
            this.btnAddUser.Text = "添加用户";
            this.btnAddUser.UseVisualStyleBackColor = true;
            this.btnAddUser.Click += new System.EventHandler(this.btnAddUser_Click);
            // 
            // btnModifyUser
            // 
            this.btnModifyUser.Location = new System.Drawing.Point(162, 12);
            this.btnModifyUser.Name = "btnModifyUser";
            this.btnModifyUser.Size = new System.Drawing.Size(75, 34);
            this.btnModifyUser.TabIndex = 1;
            this.btnModifyUser.Text = "修改密码";
            this.btnModifyUser.UseVisualStyleBackColor = true;
            this.btnModifyUser.Click += new System.EventHandler(this.btnModifyUser_Click);
            // 
            // btnFreshUser
            // 
            this.btnFreshUser.Location = new System.Drawing.Point(45, 12);
            this.btnFreshUser.Name = "btnFreshUser";
            this.btnFreshUser.Size = new System.Drawing.Size(75, 34);
            this.btnFreshUser.TabIndex = 0;
            this.btnFreshUser.Text = "刷新用户";
            this.btnFreshUser.UseVisualStyleBackColor = true;
            this.btnFreshUser.Click += new System.EventHandler(this.btnFreshUser_Click);
            // 
            // treeUser
            // 
            this.treeUser.Location = new System.Drawing.Point(16, 16);
            this.treeUser.Name = "treeUser";
            this.treeUser.Size = new System.Drawing.Size(278, 307);
            this.treeUser.TabIndex = 0;
            this.treeUser.AfterSelect += new System.Windows.Forms.TreeViewEventHandler(this.treeUser_AfterSelect);
            // 
            // tabctrOps
            // 
            this.tabctrOps.Controls.Add(this.tpUserMng);
            this.tabctrOps.Controls.Add(this.tabPage2);
            this.tabctrOps.Controls.Add(this.tabPage3);
            this.tabctrOps.Controls.Add(this.tabPage4);
            this.tabctrOps.Controls.Add(this.tpOther);
            this.tabctrOps.Location = new System.Drawing.Point(12, 53);
            this.tabctrOps.Name = "tabctrOps";
            this.tabctrOps.SelectedIndex = 0;
            this.tabctrOps.Size = new System.Drawing.Size(776, 463);
            this.tabctrOps.TabIndex = 2;
            this.tabctrOps.SelectedIndexChanged += new System.EventHandler(this.tabctrOps_SelectedIndexChanged);
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::MyMoneyAgent.Properties.Resources.主窗体;
            this.ClientSize = new System.Drawing.Size(788, 553);
            this.Controls.Add(this.stsMoney);
            this.Controls.Add(this.tabctrOps);
            this.Controls.Add(this.tlsMoney);
            this.Controls.Add(this.musMoney);
            this.MainMenuStrip = this.musMoney;
            this.Name = "MainForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "个人财务管理系统";
            this.Load += new System.EventHandler(this.MainForm_Load);
            this.musMoney.ResumeLayout(false);
            this.musMoney.PerformLayout();
            this.tlsMoney.ResumeLayout(false);
            this.tlsMoney.PerformLayout();
            this.stsMoney.ResumeLayout(false);
            this.stsMoney.PerformLayout();
            this.tpOther.ResumeLayout(false);
            this.groupBox3.ResumeLayout(false);
            this.groupBox3.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.tabPage4.ResumeLayout(false);
            this.tabPage4.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvCardOps)).EndInit();
            this.panel5.ResumeLayout(false);
            this.tabPage3.ResumeLayout(false);
            this.panel4.ResumeLayout(false);
            this.panel4.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvOutRec)).EndInit();
            this.tabPage2.ResumeLayout(false);
            this.panel3.ResumeLayout(false);
            this.panel3.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvInRec)).EndInit();
            this.tpUserMng.ResumeLayout(false);
            this.panel2.ResumeLayout(false);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.panel1.ResumeLayout(false);
            this.tabctrOps.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip musMoney;
        private System.Windows.Forms.ToolStrip tlsMoney;
        private System.Windows.Forms.ToolStripMenuItem 管理ToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem tsmiLogin;
        private System.Windows.Forms.ToolStripMenuItem tsmiChangeUser;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator1;
        private System.Windows.Forms.ToolStripMenuItem tsmiExit;
        private System.Windows.Forms.ToolStripMenuItem 帮助ToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem tsmiHelp;
        private System.Windows.Forms.ToolStripMenuItem tsmiAbout;
        private System.Windows.Forms.ToolStripButton tsbtnLogIn;
        private System.Windows.Forms.ToolStripButton tsbtnChangeUser;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator2;
        private System.Windows.Forms.ToolStripButton tsbtnExit;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator3;
        private System.Windows.Forms.StatusStrip stsMoney;
        private System.Windows.Forms.ToolStripStatusLabel tslbCurUser;
        private System.Windows.Forms.TabPage tpOther;
        private System.Windows.Forms.GroupBox groupBox3;
        private System.Windows.Forms.Button btnAddUse;
        private System.Windows.Forms.TextBox tbUsageDes;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox tbUsage;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Button btnDelUse;
        private System.Windows.Forms.Button btnLoadUse;
        private System.Windows.Forms.ListBox lstUsage;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.TextBox tbUseTypeDes;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox tbUseType;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button btnAddType;
        private System.Windows.Forms.Button btnDelType;
        private System.Windows.Forms.Button btnLoadType;
        private System.Windows.Forms.ListBox lstUseType;
        private System.Windows.Forms.TabPage tabPage4;
        private System.Windows.Forms.DataGridView dgvCardOps;
        private System.Windows.Forms.Panel panel5;
        private System.Windows.Forms.Button btnAddCard;
        private System.Windows.Forms.Button btnDelCard;
        private System.Windows.Forms.Button btnMdyBanlance;
        private System.Windows.Forms.Button btnFreshCard;
        private System.Windows.Forms.TreeView treeBankCard;
        private System.Windows.Forms.TabPage tabPage3;
        private System.Windows.Forms.Panel panel4;
        private System.Windows.Forms.RichTextBox richTextBox1;
        private System.Windows.Forms.DateTimePicker date2;
        private System.Windows.Forms.Label lbl2;
        private System.Windows.Forms.DateTimePicker date1;
        private System.Windows.Forms.Button btnAddNewOutRec;
        private System.Windows.Forms.Button btnDelOutRec;
        private System.Windows.Forms.Button btnModifyOutRec;
        private System.Windows.Forms.Button btnLdOutRec;
        private System.Windows.Forms.DataGridView dgvOutRec;
        private System.Windows.Forms.TabPage tabPage2;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.RichTextBox richTextBox2;
        private System.Windows.Forms.DateTimePicker dtpdate2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.DateTimePicker dtpdate1;
        private System.Windows.Forms.Button btnAddNewIncomRec;
        private System.Windows.Forms.Button btnDelIncomRec;
        private System.Windows.Forms.Button btnModifyIncomRec;
        private System.Windows.Forms.Button btnLdIncomRec;
        private System.Windows.Forms.DataGridView dgvInRec;
        private System.Windows.Forms.TabPage tpUserMng;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.ComboBox cmbRight;
        private System.Windows.Forms.TextBox tbPwd;
        private System.Windows.Forms.TextBox tbName;
        private System.Windows.Forms.Label lblPower;
        private System.Windows.Forms.Label lblPassword;
        private System.Windows.Forms.Label lblName;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Button btnDelUser;
        private System.Windows.Forms.Button btnAddUser;
        private System.Windows.Forms.Button btnModifyUser;
        private System.Windows.Forms.Button btnFreshUser;
        private System.Windows.Forms.TreeView treeUser;
        private System.Windows.Forms.TabControl tabctrOps;
        private System.Windows.Forms.DataGridViewTextBoxColumn colOutId;
        private System.Windows.Forms.DataGridViewTextBoxColumn colOutTime;
        private System.Windows.Forms.DataGridViewTextBoxColumn colOutAmount;
        private System.Windows.Forms.DataGridViewTextBoxColumn colOutType;
        private System.Windows.Forms.DataGridViewTextBoxColumn colOutUsage;
        private System.Windows.Forms.DataGridViewTextBoxColumn colOutRecTime;
        private System.Windows.Forms.DataGridViewTextBoxColumn colOutBank;
        private System.Windows.Forms.DataGridViewTextBoxColumn colOutDes;
        private System.Windows.Forms.DataGridViewTextBoxColumn colInID;
        private System.Windows.Forms.DataGridViewTextBoxColumn colInInTime;
        private System.Windows.Forms.DataGridViewTextBoxColumn colInAmount;
        private System.Windows.Forms.DataGridViewTextBoxColumn colInType;
        private System.Windows.Forms.DataGridViewTextBoxColumn colInUsage;
        private System.Windows.Forms.DataGridViewTextBoxColumn colInRecTime;
        private System.Windows.Forms.DataGridViewTextBoxColumn colInBank;
        private System.Windows.Forms.DataGridViewTextBoxColumn colInDes;
        private System.Windows.Forms.DataGridViewTextBoxColumn colBankNo;
        private System.Windows.Forms.DataGridViewTextBoxColumn colBankName;
        private System.Windows.Forms.DataGridViewTextBoxColumn colBankBanlance;
        private System.Windows.Forms.Label label3;
    }
}