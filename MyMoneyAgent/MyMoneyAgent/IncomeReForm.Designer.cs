namespace MyMoneyAgent
{
    partial class IncomeReForm
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
            this.dtpInTime = new System.Windows.Forms.DateTimePicker();
            this.lblExplain = new System.Windows.Forms.Label();
            this.lblCard = new System.Windows.Forms.Label();
            this.lblInStyle = new System.Windows.Forms.Label();
            this.lblInFrom = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
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
            this.grbPara.Controls.Add(this.dtpInTime);
            this.grbPara.Controls.Add(this.lblExplain);
            this.grbPara.Controls.Add(this.lblCard);
            this.grbPara.Controls.Add(this.lblInStyle);
            this.grbPara.Controls.Add(this.lblInFrom);
            this.grbPara.Controls.Add(this.label2);
            this.grbPara.Controls.Add(this.label1);
            this.grbPara.Location = new System.Drawing.Point(23, 24);
            this.grbPara.Name = "grbPara";
            this.grbPara.Size = new System.Drawing.Size(364, 364);
            this.grbPara.TabIndex = 0;
            this.grbPara.TabStop = false;
            this.grbPara.Text = "收入记录--1";
            // 
            // rtbDes
            // 
            this.rtbDes.Location = new System.Drawing.Point(45, 254);
            this.rtbDes.Name = "rtbDes";
            this.rtbDes.Size = new System.Drawing.Size(264, 94);
            this.rtbDes.TabIndex = 11;
            this.rtbDes.Text = "";
            // 
            // cmbBankCard
            // 
            this.cmbBankCard.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbBankCard.FormattingEnabled = true;
            this.cmbBankCard.Location = new System.Drawing.Point(109, 188);
            this.cmbBankCard.Name = "cmbBankCard";
            this.cmbBankCard.Size = new System.Drawing.Size(200, 20);
            this.cmbBankCard.TabIndex = 10;
            // 
            // cmbType
            // 
            this.cmbType.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbType.FormattingEnabled = true;
            this.cmbType.Location = new System.Drawing.Point(109, 149);
            this.cmbType.Name = "cmbType";
            this.cmbType.Size = new System.Drawing.Size(200, 20);
            this.cmbType.TabIndex = 9;
            // 
            // cmbUsage
            // 
            this.cmbUsage.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbUsage.FormattingEnabled = true;
            this.cmbUsage.Location = new System.Drawing.Point(109, 119);
            this.cmbUsage.Name = "cmbUsage";
            this.cmbUsage.Size = new System.Drawing.Size(200, 20);
            this.cmbUsage.TabIndex = 9;
            // 
            // nudAmout
            // 
            this.nudAmout.DecimalPlaces = 2;
            this.nudAmout.Increment = new decimal(new int[] {
            10,
            0,
            0,
            0});
            this.nudAmout.Location = new System.Drawing.Point(109, 83);
            this.nudAmout.Maximum = new decimal(new int[] {
            1241513983,
            370409800,
            542101,
            0});
            this.nudAmout.Name = "nudAmout";
            this.nudAmout.Size = new System.Drawing.Size(200, 21);
            this.nudAmout.TabIndex = 8;
            this.nudAmout.Value = new decimal(new int[] {
            1,
            0,
            0,
            0});
            // 
            // dtpInTime
            // 
            this.dtpInTime.CustomFormat = "yyyy年MM月dd日 HH:mm:ss";
            this.dtpInTime.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.dtpInTime.Location = new System.Drawing.Point(109, 46);
            this.dtpInTime.Name = "dtpInTime";
            this.dtpInTime.Size = new System.Drawing.Size(200, 21);
            this.dtpInTime.TabIndex = 2;
            // 
            // lblExplain
            // 
            this.lblExplain.AutoSize = true;
            this.lblExplain.Location = new System.Drawing.Point(43, 230);
            this.lblExplain.Name = "lblExplain";
            this.lblExplain.Size = new System.Drawing.Size(65, 12);
            this.lblExplain.TabIndex = 6;
            this.lblExplain.Text = "收入说明：";
            // 
            // lblCard
            // 
            this.lblCard.AutoSize = true;
            this.lblCard.Location = new System.Drawing.Point(43, 196);
            this.lblCard.Name = "lblCard";
            this.lblCard.Size = new System.Drawing.Size(53, 12);
            this.lblCard.TabIndex = 5;
            this.lblCard.Text = "银行卡：";
            // 
            // lblInStyle
            // 
            this.lblInStyle.AutoSize = true;
            this.lblInStyle.Location = new System.Drawing.Point(43, 157);
            this.lblInStyle.Name = "lblInStyle";
            this.lblInStyle.Size = new System.Drawing.Size(65, 12);
            this.lblInStyle.TabIndex = 4;
            this.lblInStyle.Text = "收入方式：";
            // 
            // lblInFrom
            // 
            this.lblInFrom.AutoSize = true;
            this.lblInFrom.Location = new System.Drawing.Point(43, 119);
            this.lblInFrom.Name = "lblInFrom";
            this.lblInFrom.Size = new System.Drawing.Size(65, 12);
            this.lblInFrom.TabIndex = 3;
            this.lblInFrom.Text = "收入来源：";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(43, 85);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(65, 12);
            this.label2.TabIndex = 2;
            this.label2.Text = "收入金额：";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(43, 52);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(65, 12);
            this.label1.TabIndex = 1;
            this.label1.Text = "收入时间：";
            // 
            // btnOK
            // 
            this.btnOK.Location = new System.Drawing.Point(82, 406);
            this.btnOK.Name = "btnOK";
            this.btnOK.Size = new System.Drawing.Size(81, 37);
            this.btnOK.TabIndex = 1;
            this.btnOK.Text = "确定";
            this.btnOK.UseVisualStyleBackColor = true;
            this.btnOK.Click += new System.EventHandler(this.btnOK_Click);
            // 
            // btnCancle
            // 
            this.btnCancle.Location = new System.Drawing.Point(215, 406);
            this.btnCancle.Name = "btnCancle";
            this.btnCancle.Size = new System.Drawing.Size(81, 37);
            this.btnCancle.TabIndex = 1;
            this.btnCancle.Text = "取消";
            this.btnCancle.UseVisualStyleBackColor = true;
            this.btnCancle.Click += new System.EventHandler(this.btnCancle_Click);
            // 
            // IncomeReForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::MyMoneyAgent.Properties.Resources.收入编辑对话框;
            this.ClientSize = new System.Drawing.Size(410, 455);
            this.Controls.Add(this.btnCancle);
            this.Controls.Add(this.btnOK);
            this.Controls.Add(this.grbPara);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            this.Name = "IncomeReForm";
            this.ShowInTaskbar = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "收入编辑对话框";
            this.Load += new System.EventHandler(this.IncomeReForm_Load);
            this.grbPara.ResumeLayout(false);
            this.grbPara.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.nudAmout)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox grbPara;
        private System.Windows.Forms.RichTextBox rtbDes;
        private System.Windows.Forms.ComboBox cmbBankCard;
        private System.Windows.Forms.ComboBox cmbType;
        private System.Windows.Forms.ComboBox cmbUsage;
        private System.Windows.Forms.NumericUpDown nudAmout;
        private System.Windows.Forms.DateTimePicker dtpInTime;
        private System.Windows.Forms.Label lblExplain;
        private System.Windows.Forms.Label lblCard;
        private System.Windows.Forms.Label lblInStyle;
        private System.Windows.Forms.Label lblInFrom;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btnOK;
        private System.Windows.Forms.Button btnCancle;
    }
}