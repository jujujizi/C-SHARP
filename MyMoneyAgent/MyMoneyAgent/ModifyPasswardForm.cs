using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace MyMoneyAgent
{
    public partial class ModifyPasswardForm : Form
    {
        public ModifyPasswardForm()
        {
            InitializeComponent();
        }

        private void btnCancle_Click(object sender, EventArgs e)
        {
            this.DialogResult = DialogResult.Cancel;
        }

        private void ModifyPasswardForm_Load(object sender, EventArgs e)
        {

            List<UserClass> userLst = UserSql.LoadUserList();
            foreach (UserClass user in userLst)
            {
                this.cmbUser.Items.Add(user);
            }
        }

        private void btnCPwd_Click(object sender, EventArgs e)
        {

            //获取当前选中用户
            UserClass user = (UserClass)this.cmbUser.SelectedItem;
            //检查旧密码的输入合法性
            if (this.tbPwd.Text.Trim() != user.Password)
            {
                MessageBox.Show("请输入正确的原密码！", "提示",
                                MessageBoxButtons.OK, MessageBoxIcon.Information);
                //清空原密码输入框，并获取焦点
                this.tbPwd.Clear();
                this.tbPwd.Focus();
                return;
            }
            //检查新密码的合法性
            if (this.tbNewPwd1.Text.Trim() != this.tbNewPwd2.Text.Trim())
            {
                MessageBox.Show("两次新密码不一致，请再次确认新密码！", "提示",
                               MessageBoxButtons.OK, MessageBoxIcon.Information);
                //清空现有密码，并将光标移动到密码输入框
                this.tbNewPwd1.Clear();
                this.tbNewPwd2.Clear();
                this.tbNewPwd1.Focus();
                return;
            }
            user.Password = tbNewPwd1.Text;
            if (UserSql.ModifyUser(user))
            {
                MessageBox.Show("修改用户信息:" + user.ToString() + "，成功", "提示",
                               MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            else
            {
                MessageBox.Show("修改用户信息:" + user.ToString() + "，失败", "提示",
                                MessageBoxButtons.OK, MessageBoxIcon.Information);
                user.Password = tbPwd.Text.Trim();
            }
        }

        private void cmbUser_SelectedIndexChanged(object sender, EventArgs e)
        {
            //清空原有密码
            this.tbPwd.Clear();
        }



    }
}
