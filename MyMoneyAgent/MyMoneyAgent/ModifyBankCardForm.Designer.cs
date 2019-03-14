namespace MyMoneyAgent
{
    partial class ModifyBankCardForm
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
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.nudBalance = new System.Windows.Forms.NumericUpDown();
            this.mtbCardNo = new System.Windows.Forms.MaskedTextBox();
            this.tbBank = new System.Windows.Forms.TextBox();
            this.tbName = new System.Windows.Forms.TextBox();
            this.lblBalance = new System.Windows.Forms.Label();
            this.lblBankNo = new System.Windows.Forms.Label();
            this.lblBank = new System.Windows.Forms.Label();
            this.lblName = new System.Windows.Forms.Label();
            this.btnAdd = new System.Windows.Forms.Button();
            this.btnReset = new System.Windows.Forms.Button();
            this.btnCancle = new System.Windows.Forms.Button();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.nudBalance)).BeginInit();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.BackColor = System.Drawing.Color.Transparent;
            this.groupBox1.Controls.Add(this.nudBalance);
            this.groupBox1.Controls.Add(this.mtbCardNo);
            this.groupBox1.Controls.Add(this.tbBank);
            this.groupBox1.Controls.Add(this.tbName);
            this.groupBox1.Controls.Add(this.lblBalance);
            this.groupBox1.Controls.Add(this.lblBankNo);
            this.groupBox1.Controls.Add(this.lblBank);
            this.groupBox1.Controls.Add(this.lblName);
            this.groupBox1.Location = new System.Drawing.Point(28, 21);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(311, 228);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "银行卡参数";
            // 
            // nudBalance
            // 
            this.nudBalance.DecimalPlaces = 2;
            this.nudBalance.Location = new System.Drawing.Point(109, 163);
            this.nudBalance.Maximum = new decimal(new int[] {
            1000000000,
            0,
            0,
            0});
            this.nudBalance.Minimum = new decimal(new int[] {
            1000000000,
            0,
            0,
            -2147483648});
            this.nudBalance.Name = "nudBalance";
            this.nudBalance.Size = new System.Drawing.Size(155, 21);
            this.nudBalance.TabIndex = 7;
            // 
            // mtbCardNo
            // 
            this.mtbCardNo.Location = new System.Drawing.Point(109, 127);
            this.mtbCardNo.Mask = "000000000000000000";
            this.mtbCardNo.Name = "mtbCardNo";
            this.mtbCardNo.ReadOnly = true;
            this.mtbCardNo.Size = new System.Drawing.Size(155, 21);
            this.mtbCardNo.TabIndex = 6;
            // 
            // tbBank
            // 
            this.tbBank.Location = new System.Drawing.Point(109, 85);
            this.tbBank.Name = "tbBank";
            this.tbBank.ReadOnly = true;
            this.tbBank.Size = new System.Drawing.Size(155, 21);
            this.tbBank.TabIndex = 5;
            // 
            // tbName
            // 
            this.tbName.Location = new System.Drawing.Point(109, 45);
            this.tbName.Name = "tbName";
            this.tbName.ReadOnly = true;
            this.tbName.Size = new System.Drawing.Size(155, 21);
            this.tbName.TabIndex = 4;
            // 
            // lblBalance
            // 
            this.lblBalance.AutoSize = true;
            this.lblBalance.Location = new System.Drawing.Point(38, 172);
            this.lblBalance.Name = "lblBalance";
            this.lblBalance.Size = new System.Drawing.Size(41, 12);
            this.lblBalance.TabIndex = 3;
            this.lblBalance.Text = "余额：";
            // 
            // lblBankNo
            // 
            this.lblBankNo.AutoSize = true;
            this.lblBankNo.Location = new System.Drawing.Point(38, 130);
            this.lblBankNo.Name = "lblBankNo";
            this.lblBankNo.Size = new System.Drawing.Size(41, 12);
            this.lblBankNo.TabIndex = 2;
            this.lblBankNo.Text = "卡号：";
            // 
            // lblBank
            // 
            this.lblBank.AutoSize = true;
            this.lblBank.Location = new System.Drawing.Point(38, 88);
            this.lblBank.Name = "lblBank";
            this.lblBank.Size = new System.Drawing.Size(41, 12);
            this.lblBank.TabIndex = 1;
            this.lblBank.Text = "银行：";
            // 
            // lblName
            // 
            this.lblName.AutoSize = true;
            this.lblName.Location = new System.Drawing.Point(38, 48);
            this.lblName.Name = "lblName";
            this.lblName.Size = new System.Drawing.Size(41, 12);
            this.lblName.TabIndex = 0;
            this.lblName.Text = "姓名：";
            // 
            // btnAdd
            // 
            this.btnAdd.Location = new System.Drawing.Point(51, 283);
            this.btnAdd.Name = "btnAdd";
            this.btnAdd.Size = new System.Drawing.Size(75, 23);
            this.btnAdd.TabIndex = 8;
            this.btnAdd.Text = "修改";
            this.btnAdd.UseVisualStyleBackColor = true;
            this.btnAdd.Click += new System.EventHandler(this.btnAdd_Click);
            // 
            // btnReset
            // 
            this.btnReset.Location = new System.Drawing.Point(150, 283);
            this.btnReset.Name = "btnReset";
            this.btnReset.Size = new System.Drawing.Size(75, 23);
            this.btnReset.TabIndex = 9;
            this.btnReset.Text = "清零";
            this.btnReset.UseVisualStyleBackColor = true;
            this.btnReset.Click += new System.EventHandler(this.btnReset_Click);
            // 
            // btnCancle
            // 
            this.btnCancle.Location = new System.Drawing.Point(240, 283);
            this.btnCancle.Name = "btnCancle";
            this.btnCancle.Size = new System.Drawing.Size(75, 23);
            this.btnCancle.TabIndex = 10;
            this.btnCancle.Text = "取消";
            this.btnCancle.UseVisualStyleBackColor = true;
            this.btnCancle.Click += new System.EventHandler(this.btnCancle_Click);
            // 
            // ModifyBankCardForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::MyMoneyAgent.Properties.Resources.修改银行卡余额;
            this.ClientSize = new System.Drawing.Size(378, 328);
            this.Controls.Add(this.btnCancle);
            this.Controls.Add(this.btnReset);
            this.Controls.Add(this.btnAdd);
            this.Controls.Add(this.groupBox1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            this.Name = "ModifyBankCardForm";
            this.ShowInTaskbar = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "修改银行卡余额";
            this.Load += new System.EventHandler(this.ModifyBankCardForm_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.nudBalance)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.NumericUpDown nudBalance;
        private System.Windows.Forms.MaskedTextBox mtbCardNo;
        private System.Windows.Forms.TextBox tbBank;
        private System.Windows.Forms.TextBox tbName;
        private System.Windows.Forms.Label lblBalance;
        private System.Windows.Forms.Label lblBankNo;
        private System.Windows.Forms.Label lblBank;
        private System.Windows.Forms.Label lblName;
        private System.Windows.Forms.Button btnAdd;
        private System.Windows.Forms.Button btnReset;
        private System.Windows.Forms.Button btnCancle;
    }
}