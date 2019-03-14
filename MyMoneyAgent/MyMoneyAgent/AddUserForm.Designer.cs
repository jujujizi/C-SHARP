namespace MyMoneyAgent
{
    partial class AddUserForm
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
            this.cmbRight = new System.Windows.Forms.ComboBox();
            this.tbPwd2 = new System.Windows.Forms.TextBox();
            this.tbPwd = new System.Windows.Forms.TextBox();
            this.tbName = new System.Windows.Forms.TextBox();
            this.lblRight = new System.Windows.Forms.Label();
            this.lblRePassward = new System.Windows.Forms.Label();
            this.lblPassward = new System.Windows.Forms.Label();
            this.lblName = new System.Windows.Forms.Label();
            this.btnAdd = new System.Windows.Forms.Button();
            this.btnReset = new System.Windows.Forms.Button();
            this.btnCancle = new System.Windows.Forms.Button();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.BackColor = System.Drawing.Color.Transparent;
            this.groupBox1.Controls.Add(this.cmbRight);
            this.groupBox1.Controls.Add(this.tbPwd2);
            this.groupBox1.Controls.Add(this.tbPwd);
            this.groupBox1.Controls.Add(this.tbName);
            this.groupBox1.Controls.Add(this.lblRight);
            this.groupBox1.Controls.Add(this.lblRePassward);
            this.groupBox1.Controls.Add(this.lblPassward);
            this.groupBox1.Controls.Add(this.lblName);
            this.groupBox1.Location = new System.Drawing.Point(12, 11);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(322, 221);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "用户参数";
            // 
            // cmbRight
            // 
            this.cmbRight.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbRight.FormattingEnabled = true;
            this.cmbRight.Location = new System.Drawing.Point(108, 152);
            this.cmbRight.Name = "cmbRight";
            this.cmbRight.Size = new System.Drawing.Size(150, 20);
            this.cmbRight.TabIndex = 8;
            // 
            // tbPwd2
            // 
            this.tbPwd2.Location = new System.Drawing.Point(108, 111);
            this.tbPwd2.Name = "tbPwd2";
            this.tbPwd2.PasswordChar = '〇';
            this.tbPwd2.Size = new System.Drawing.Size(150, 21);
            this.tbPwd2.TabIndex = 7;
            // 
            // tbPwd
            // 
            this.tbPwd.Location = new System.Drawing.Point(108, 71);
            this.tbPwd.Name = "tbPwd";
            this.tbPwd.PasswordChar = '〇';
            this.tbPwd.Size = new System.Drawing.Size(150, 21);
            this.tbPwd.TabIndex = 7;
            // 
            // tbName
            // 
            this.tbName.ForeColor = System.Drawing.SystemColors.WindowText;
            this.tbName.Location = new System.Drawing.Point(108, 31);
            this.tbName.Name = "tbName";
            this.tbName.Size = new System.Drawing.Size(150, 21);
            this.tbName.TabIndex = 7;
            // 
            // lblRight
            // 
            this.lblRight.AutoSize = true;
            this.lblRight.Location = new System.Drawing.Point(39, 155);
            this.lblRight.Name = "lblRight";
            this.lblRight.Size = new System.Drawing.Size(41, 12);
            this.lblRight.TabIndex = 6;
            this.lblRight.Text = "权限：";
            // 
            // lblRePassward
            // 
            this.lblRePassward.AutoSize = true;
            this.lblRePassward.Location = new System.Drawing.Point(39, 114);
            this.lblRePassward.Name = "lblRePassward";
            this.lblRePassward.Size = new System.Drawing.Size(65, 12);
            this.lblRePassward.TabIndex = 5;
            this.lblRePassward.Text = "重复密码：";
            // 
            // lblPassward
            // 
            this.lblPassward.AutoSize = true;
            this.lblPassward.Location = new System.Drawing.Point(39, 74);
            this.lblPassward.Name = "lblPassward";
            this.lblPassward.Size = new System.Drawing.Size(41, 12);
            this.lblPassward.TabIndex = 4;
            this.lblPassward.Text = "密码：";
            // 
            // lblName
            // 
            this.lblName.AutoSize = true;
            this.lblName.Location = new System.Drawing.Point(39, 34);
            this.lblName.Name = "lblName";
            this.lblName.Size = new System.Drawing.Size(41, 12);
            this.lblName.TabIndex = 3;
            this.lblName.Text = "姓名：";
            // 
            // btnAdd
            // 
            this.btnAdd.Location = new System.Drawing.Point(30, 250);
            this.btnAdd.Name = "btnAdd";
            this.btnAdd.Size = new System.Drawing.Size(71, 31);
            this.btnAdd.TabIndex = 1;
            this.btnAdd.Text = "添加";
            this.btnAdd.UseVisualStyleBackColor = true;
            this.btnAdd.Click += new System.EventHandler(this.btnAdd_Click);
            // 
            // btnReset
            // 
            this.btnReset.Location = new System.Drawing.Point(130, 250);
            this.btnReset.Name = "btnReset";
            this.btnReset.Size = new System.Drawing.Size(71, 31);
            this.btnReset.TabIndex = 1;
            this.btnReset.Text = "重填";
            this.btnReset.UseVisualStyleBackColor = true;
            this.btnReset.Click += new System.EventHandler(this.btnReset_Click);
            // 
            // btnCancle
            // 
            this.btnCancle.Location = new System.Drawing.Point(233, 250);
            this.btnCancle.Name = "btnCancle";
            this.btnCancle.Size = new System.Drawing.Size(75, 31);
            this.btnCancle.TabIndex = 2;
            this.btnCancle.Text = "取消";
            this.btnCancle.UseVisualStyleBackColor = true;
            this.btnCancle.Click += new System.EventHandler(this.btnCancle_Click);
            // 
            // AddUserForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::MyMoneyAgent.Properties.Resources.添加用户;
            this.ClientSize = new System.Drawing.Size(346, 303);
            this.Controls.Add(this.btnCancle);
            this.Controls.Add(this.btnReset);
            this.Controls.Add(this.btnAdd);
            this.Controls.Add(this.groupBox1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            this.Name = "AddUserForm";
            this.ShowInTaskbar = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "添加用户";
            this.Load += new System.EventHandler(this.AddUserForm_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.ComboBox cmbRight;
        private System.Windows.Forms.TextBox tbPwd2;
        private System.Windows.Forms.TextBox tbPwd;
        private System.Windows.Forms.TextBox tbName;
        private System.Windows.Forms.Label lblRight;
        private System.Windows.Forms.Label lblRePassward;
        private System.Windows.Forms.Label lblPassward;
        private System.Windows.Forms.Label lblName;
        private System.Windows.Forms.Button btnAdd;
        private System.Windows.Forms.Button btnReset;
        private System.Windows.Forms.Button btnCancle;
    }
}