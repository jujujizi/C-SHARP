namespace MyMoneyAgent
{
    partial class OutReForm
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
            this.grbPara = new System.Windows.Forms.GroupBox();
            this.rtbDes = new System.Windows.Forms.RichTextBox();
            this.cmbBankCard = new System.Windows.Forms.ComboBox();
            this.cmbType = new System.Windows.Forms.ComboBox();
            this.cmbUsage = new System.Windows.Forms.ComboBox();
            this.nudAmout = new System.Windows.Forms.NumericUpDown();
            this.dtpOutTime = new System.Windows.Forms.DateTimePicker();
            this.lblOExplain = new System.Windows.Forms.Label();
            this.lblCard = new System.Windows.Forms.Label();
            this.lblOType = new System.Windows.Forms.Label();
            this.lblOUsage = new System.Windows.Forms.Label();
            this.lblOMoney = new System.Windows.Forms.Label();
            this.lblOutime = new System.Windows.Forms.Label();
            this.btnOK = new System.Windows.Forms.Button();
            this.btnCancle = new System.Windows.Forms.Button();
            this.grbPara.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.nudAmout)).BeginInit();
            this.SuspendLayout();
            // 
            // grbPara
            // 
            this.grbPara.BackColor = System.Drawing.Color.Transparent;
            this.grbPara.Controls.Add(this.rtbDes);
            this.grbPara.Controls.Add(this.cmbBankCard);
            this.grbPara.Controls.Add(this.cmbType);
            this.grbPara.Controls.Add(this.cmbUsage);
            this.grbPara.Controls.Add(this.nudAmout);
            this.grbPara.Controls.Add(this.dtpOutTime);
            this.grbPara.Controls.Add(this.lblOExplain);
            this.grbPara.Controls.Add(this.lblCard);
            this.grbPara.Controls.Add(this.lblOType);
            this.grbPara.Controls.Add(this.lblOUsage);
            this.grbPara.Controls.Add(this.lblOMoney);
            this.grbPara.Controls.Add(this.lblOutime);
            this.grbPara.Location = new System.Drawing.Point(25, 31);
            this.grbPara.Name = "grbPara";
            this.grbPara.Size = new System.Drawing.Size(362, 349);
            this.grbPara.TabIndex = 0;
            this.grbPara.TabStop = false;
            this.grbPara.Text = "支出记录--1";
            // 
            // rtbDes
            // 
            this.rtbDes.Location = new System.Drawing.Point(44, 259);
            this.rtbDes.Name = "rtbDes";
            this.rtbDes.Size = new System.Drawing.Size(269, 74);
            this.rtbDes.TabIndex = 9;
            this.rtbDes.Text = "";
            // 
            // cmbBankCard
            // 
            this.cmbBankCard.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbBankCard.FormattingEnabled = true;
            this.cmbBankCard.Location = new System.Drawing.Point(99, 194);
            this.cmbBankCard.Name = "cmbBankCard";
            this.cmbBankCard.Size = new System.Drawing.Size(200, 20);
            this.cmbBankCard.TabIndex = 8;
            // 
            // cmbType
            // 
            this.cmbType.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbType.FormattingEnabled = true;
            this.cmbType.Location = new System.Drawing.Point(99, 160);
            this.cmbType.Name = "cmbType";
            this.cmbType.Size = new System.Drawing.Size(200, 20);
            this.cmbType.TabIndex = 8;
            // 
            // cmbUsage
            // 
            this.cmbUsage.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbUsage.FormattingEnabled = true;
            this.cmbUsage.Location = new System.Drawing.Point(99, 127);
            this.cmbUsage.Name = "cmbUsage";
            this.cmbUsage.Size = new System.Drawing.Size(200, 20);
            this.cmbUsage.TabIndex = 8;
            // 
            // nudAmout
            // 
            this.nudAmout.DecimalPlaces = 2;
            this.nudAmout.Increment = new decimal(new int[] {
            10,
            0,
            0,
            0});
            this.nudAmout.Location = new System.Drawing.Point(99, 92);
            this.nudAmout.Maximum = new decimal(new int[] {
            1241513983,
            370409800,
            542101,
            0});
            this.nudAmout.Name = "nudAmout";
            this.nudAmout.Size = new System.Drawing.Size(200, 21);
            this.nudAmout.TabIndex = 7;
            this.nudAmout.Value = new decimal(new int[] {
            1,
            0,
            0,
            0});
            // 
            // dtpOutTime
            // 
            this.dtpOutTime.CustomFormat = "yyyy年MM月dd日 HH:mm:ss";
            this.dtpOutTime.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.dtpOutTime.Location = new System.Drawing.Point(99, 43);
            this.dtpOutTime.Name = "dtpOutTime";
            this.dtpOutTime.Size = new System.Drawing.Size(200, 21);
            this.dtpOutTime.TabIndex = 2;
            // 
            // lblOExplain
            // 
            this.lblOExplain.AutoSize = true;
            this.lblOExplain.Location = new System.Drawing.Point(28, 230);
            this.lblOExplain.Name = "lblOExplain";
            this.lblOExplain.Size = new System.Drawing.Size(65, 12);
            this.lblOExplain.TabIndex = 5;
            this.lblOExplain.Text = "支出说明：";
            // 
            // lblCard
            // 
            this.lblCard.AutoSize = true;
            this.lblCard.Location = new System.Drawing.Point(28, 194);
            this.lblCard.Name = "lblCard";
            this.lblCard.Size = new System.Drawing.Size(53, 12);
            this.lblCard.TabIndex = 4;
            this.lblCard.Text = "银行卡：";
            // 
            // lblOType
            // 
            this.lblOType.AutoSize = true;
            this.lblOType.Location = new System.Drawing.Point(28, 160);
            this.lblOType.Name = "lblOType";
            this.lblOType.Size = new System.Drawing.Size(65, 12);
            this.lblOType.TabIndex = 3;
            this.lblOType.Text = "支出方式：";
            // 
            // lblOUsage
            // 
            this.lblOUsage.AutoSize = true;
            this.lblOUsage.Location = new System.Drawing.Point(28, 127);
            this.lblOUsage.Name = "lblOUsage";
            this.lblOUsage.Size = new System.Drawing.Size(65, 12);
            this.lblOUsage.TabIndex = 2;
            this.lblOUsage.Text = "支出用途：";
            // 
            // lblOMoney
            // 
            this.lblOMoney.AutoSize = true;
            this.lblOMoney.Location = new System.Drawing.Point(28, 92);
            this.lblOMoney.Name = "lblOMoney";
            this.lblOMoney.Size = new System.Drawing.Size(65, 12);
            this.lblOMoney.TabIndex = 1;
            this.lblOMoney.Text = "支出金额：";
            // 
            // lblOutime
            // 
            this.lblOutime.AutoSize = true;
            this.lblOutime.Location = new System.Drawing.Point(28, 49);
            this.lblOutime.Name = "lblOutime";
            this.lblOutime.Size = new System.Drawing.Size(65, 12);
            this.lblOutime.TabIndex = 0;
            this.lblOutime.Text = "支出时间：";
            // 
            // btnOK
            // 
            this.btnOK.Location = new System.Drawing.Point(69, 403);
            this.btnOK.Name = "btnOK";
            this.btnOK.Size = new System.Drawing.Size(80, 39);
            this.btnOK.TabIndex = 10;
            this.btnOK.Text = "确定";
            this.btnOK.UseVisualStyleBackColor = true;
            this.btnOK.Click += new System.EventHandler(this.btnOK_Click);
            // 
            // btnCancle
            // 
            this.btnCancle.Location = new System.Drawing.Point(258, 403);
            this.btnCancle.Name = "btnCancle";
            this.btnCancle.Size = new System.Drawing.Size(80, 39);
            this.btnCancle.TabIndex = 10;
            this.btnCancle.Text = "取消";
            this.btnCancle.UseVisualStyleBackColor = true;
            this.btnCancle.Click += new System.EventHandler(this.btnCancle_Click);
            // 
            // OutReForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::MyMoneyAgent.Properties.Resources.支出编辑对话框;
            this.ClientSize = new System.Drawing.Size(411, 454);
            this.Controls.Add(this.btnCancle);
            this.Controls.Add(this.btnOK);
            this.Controls.Add(this.grbPara);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            this.Name = "OutReForm";
            this.ShowInTaskbar = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "支出编辑对话框";
            this.Load += new System.EventHandler(this.OutReForm_Load);
            this.grbPara.ResumeLayout(false);
            this.grbPara.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.nudAmout)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox grbPara;
        private System.Windows.Forms.Label lblOExplain;
        private System.Windows.Forms.Label lblCard;
        private System.Windows.Forms.Label lblOType;
        private System.Windows.Forms.Label lblOUsage;
        private System.Windows.Forms.Label lblOMoney;
        private System.Windows.Forms.Label lblOutime;
        private System.Windows.Forms.DateTimePicker dtpOutTime;
        private System.Windows.Forms.RichTextBox rtbDes;
        private System.Windows.Forms.ComboBox cmbBankCard;
        private System.Windows.Forms.ComboBox cmbType;
        private System.Windows.Forms.ComboBox cmbUsage;
        private System.Windows.Forms.NumericUpDown nudAmout;
        private System.Windows.Forms.Button btnOK;
        private System.Windows.Forms.Button btnCancle;
    }
}