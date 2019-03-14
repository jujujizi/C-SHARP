namespace MyMoneyAgent
{
    partial class ModifyPasswardForm
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
            this.lblUser = new System.Windows.Forms.Label();
            this.lblForPwd = new System.Windows.Forms.Label();
            this.lblNPwd = new System.Windows.Forms.Label();
            this.lblRePwd = new System.Windows.Forms.Label();
            this.btnCPwd = new System.Windows.Forms.Button();
            this.btnCancle = new System.Windows.Forms.Button();
            this.cmbUser = new System.Windows.Forms.ComboBox();
            this.tbPwd = new System.Windows.Forms.TextBox();
            this.tbNewPwd1 = new System.Windows.Forms.TextBox();
            this.tbNewPwd2 = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // lblUser
            // 
            this.lblUser.AutoSize = true;
            this.lblUser.BackColor = System.Drawing.Color.Transparent;
            this.lblUser.Location = new System.Drawing.Point(67, 36);
            this.lblUser.Name = "lblUser";
            this.lblUser.Size = new System.Drawing.Size(41, 12);
            this.lblUser.TabIndex = 0;
            this.lblUser.Text = "用户：";
            // 
            // lblForPwd
            // 
            this.lblForPwd.AutoSize = true;
            this.lblForPwd.BackColor = System.Drawing.Color.Transparent;
            this.lblForPwd.Location = new System.Drawing.Point(67, 89);
            this.lblForPwd.Name = "lblForPwd";
            this.lblForPwd.Size = new System.Drawing.Size(53, 12);
            this.lblForPwd.TabIndex = 1;
            this.lblForPwd.Text = "原密码：";
            // 
            // lblNPwd
            // 
            this.lblNPwd.AutoSize = true;
            this.lblNPwd.BackColor = System.Drawing.Color.Transparent;
            this.lblNPwd.Location = new System.Drawing.Point(67, 140);
            this.lblNPwd.Name = "lblNPwd";
            this.lblNPwd.Size = new System.Drawing.Size(53, 12);
            this.lblNPwd.TabIndex = 2;
            this.lblNPwd.Text = "新密码：";
            // 
            // lblRePwd
            // 
            this.lblRePwd.AutoSize = true;
            this.lblRePwd.BackColor = System.Drawing.Color.Transparent;
            this.lblRePwd.Location = new System.Drawing.Point(55, 195);
            this.lblRePwd.Name = "lblRePwd";
            this.lblRePwd.Size = new System.Drawing.Size(77, 12);
            this.lblRePwd.TabIndex = 3;
            this.lblRePwd.Text = "重复新密码：";
            // 
            // btnCPwd
            // 
            this.btnCPwd.Location = new System.Drawing.Point(57, 241);
            this.btnCPwd.Name = "btnCPwd";
            this.btnCPwd.Size = new System.Drawing.Size(75, 23);
            this.btnCPwd.TabIndex = 4;
            this.btnCPwd.Text = "改密码";
            this.btnCPwd.UseVisualStyleBackColor = true;
            this.btnCPwd.Click += new System.EventHandler(this.btnCPwd_Click);
            // 
            // btnCancle
            // 
            this.btnCancle.Location = new System.Drawing.Point(221, 241);
            this.btnCancle.Name = "btnCancle";
            this.btnCancle.Size = new System.Drawing.Size(75, 23);
            this.btnCancle.TabIndex = 5;
            this.btnCancle.Text = "取消";
            this.btnCancle.UseVisualStyleBackColor = true;
            this.btnCancle.Click += new System.EventHandler(this.btnCancle_Click);
            // 
            // cmbUser
            // 
            this.cmbUser.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbUser.FormattingEnabled = true;
            this.cmbUser.Location = new System.Drawing.Point(135, 33);
            this.cmbUser.Name = "cmbUser";
            this.cmbUser.Size = new System.Drawing.Size(146, 20);
            this.cmbUser.TabIndex = 6;
            this.cmbUser.SelectedIndexChanged += new System.EventHandler(this.cmbUser_SelectedIndexChanged);
            // 
            // tbPwd
            // 
            this.tbPwd.Location = new System.Drawing.Point(135, 89);
            this.tbPwd.Name = "tbPwd";
            this.tbPwd.Size = new System.Drawing.Size(146, 21);
            this.tbPwd.TabIndex = 7;
            // 
            // tbNewPwd1
            // 
            this.tbNewPwd1.Location = new System.Drawing.Point(135, 140);
            this.tbNewPwd1.Name = "tbNewPwd1";
            this.tbNewPwd1.Size = new System.Drawing.Size(146, 21);
            this.tbNewPwd1.TabIndex = 7;
            // 
            // tbNewPwd2
            // 
            this.tbNewPwd2.Location = new System.Drawing.Point(135, 192);
            this.tbNewPwd2.Name = "tbNewPwd2";
            this.tbNewPwd2.Size = new System.Drawing.Size(146, 21);
            this.tbNewPwd2.TabIndex = 7;
            // 
            // ModifyPasswardForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::MyMoneyAgent.Properties.Resources.修改密码;
            this.ClientSize = new System.Drawing.Size(348, 296);
            this.Controls.Add(this.tbNewPwd2);
            this.Controls.Add(this.tbNewPwd1);
            this.Controls.Add(this.tbPwd);
            this.Controls.Add(this.cmbUser);
            this.Controls.Add(this.btnCancle);
            this.Controls.Add(this.btnCPwd);
            this.Controls.Add(this.lblRePwd);
            this.Controls.Add(this.lblNPwd);
            this.Controls.Add(this.lblForPwd);
            this.Controls.Add(this.lblUser);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            this.Name = "ModifyPasswardForm";
            this.ShowInTaskbar = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "修改密码";
            this.Load += new System.EventHandler(this.ModifyPasswardForm_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblUser;
        private System.Windows.Forms.Label lblForPwd;
        private System.Windows.Forms.Label lblNPwd;
        private System.Windows.Forms.Label lblRePwd;
        private System.Windows.Forms.Button btnCPwd;
        private System.Windows.Forms.Button btnCancle;
        private System.Windows.Forms.ComboBox cmbUser;
        private System.Windows.Forms.TextBox tbPwd;
        private System.Windows.Forms.TextBox tbNewPwd1;
        private System.Windows.Forms.TextBox tbNewPwd2;
    }
}