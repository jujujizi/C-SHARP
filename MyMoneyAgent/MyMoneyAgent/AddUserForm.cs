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
    public partial class AddUserForm : Form
    {
        
        public AddUserForm()
        {
            InitializeComponent();
            //this.name = name;
            string[] rightTypeString = Enum.GetNames(typeof(UserRights));
            cmbRight.Items.AddRange(rightTypeString);
            cmbRight.SelectedIndex = 1;
        }
        // 取消操作
        private void btnCancle_Click(object sender, EventArgs e)
        {
            this.DialogResult = DialogResult.Cancel;
            this.Close();
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            //进行姓名合法性检查
            string name = this.tbName.Text.Trim( );
            if (string.IsNullOrEmpty(name))
            {
                MessageBox.Show("请输入姓名！", "提示",
                                 MessageBoxButtons.OK, MessageBoxIcon.Information);
                return;
            }
            //进行密码合法性检查
            if (this.tbPwd.Text.Trim() != this.tbPwd2.Text.Trim())
            {
                MessageBox.Show("两次密码不一致，请再次确认新密码！", "提示",
                                MessageBoxButtons.OK, MessageBoxIcon.Information);
                //清空现有密码，并将光标移动到密码输入框
                this.tbPwd.Clear();
                this.tbPwd2.Clear();
                this.tbPwd.Focus();
                return;
            }
            string pwd = tbPwd.Text.Trim();
            UserRights right = (UserRights)this.cmbRight.SelectedIndex;
            //创建用户对象
            UserClass user = new UserClass(name, pwd, right);
            //添加用户到数据库
            if (UserSql .Adduser(user ))
            {
                 MessageBox.Show("添加用户:" + name + "，成功", "提示",
                                MessageBoxButtons.OK, MessageBoxIcon.Information);
                //添加成功，关闭对话框
                this.DialogResult = DialogResult.OK;
            }
            else
            {
                MessageBox.Show("添加用户:" + name + "，失败", "提示",
                                MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
        // 重填操作
        private void btnReset_Click(object sender, EventArgs e)
        {
            this.tbName.Text = "";
            this.tbPwd.Text = "";
            this.tbPwd2.Text = "";
            this.tbName.Focus();
            this.cmbRight.SelectedIndex = 1;
        }
        // 初始化界面
        private void AddUserForm_Load(object sender, EventArgs e)
        {
            this.tbName.Focus();
            this.cmbRight.SelectedIndex = 1;
        }



       /* private void cmbRight_SelectedIndexChanged(object sender, EventArgs e)
        {
            Array temp = Enum.GetValues(typeof(UserRights));
            for (int i = 0; i < temp.Length; i++)
            {
                string item = temp.GetValue(i).ToString();
                cmbRight.Items.Add(item);
            }
        }*/

 

    }

}
