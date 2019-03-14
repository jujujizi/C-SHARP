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
    public partial class LoginForm : Form
    {
        public LoginForm()
        {
            InitializeComponent();
        }
        private List<UserClass> UserList;
        public UserClass GetCurUser()
        {
              if (this.cmbUser.SelectedItem != null)
              {
                  return (UserClass)this.cmbUser.SelectedItem;
              }
              else
              {
                  return null;
              }
        }

        private void btnOK_Click(object sender, EventArgs e)
        {
            //检查是否有选中用户
            if (this.cmbUser.SelectedItem == null)
            {
                MessageBox.Show("请选择一个可用的用户名!!!", "提示", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }
            //检查输入用户和密码是否正确
            string pwd = this.tbPwd.Text.Trim();
            UserClass user = (UserClass)this.cmbUser.SelectedItem;
            if (user.Password != pwd)
            {
                MessageBox.Show("输入密码不正确!!!!", "提示", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                //默认重新输入密码
                this.tbPwd.SelectAll();
                this.tbPwd.Focus();
                return;
            }
            //密码验证通过，返回OK，并关闭对话框
            this.DialogResult = DialogResult.OK;
        }

        private void btnCancle_Click(object sender, EventArgs e)
        {
            //直接取消，并退出对话框
            this.DialogResult = DialogResult.Cancel;
   
        }
        private void LoadUserList( )
        {
            //从数据库加载所有可用的用户
            this.UserList = UserSql.LoadUserList();
            this.cmbUser.Items.Clear();
            if (this.UserList !=null )
            {
                foreach (UserClass user in this.UserList )
                {
                    this.cmbUser.Items.Add(user);
                }
                //默认选中第一个用户
                if (this.cmbUser.Items.Count > 0)
                {
                    this.cmbUser.SelectedIndex = 0;
                }
            }
        }
        //界面初始化
        private void LoginForm_Load(object sender, EventArgs e)
        {
            this.LoadUserList();
        }
        // 添加用户操作
        private void lnklbCreatUser_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {//创建添加用户对话框
            AddUserForm adf = new AddUserForm();
            //添加用户操作成功，则重新更新用户列表
            if(adf.ShowDialog(this)==DialogResult.OK  )
            {
                this.LoadUserList();
            }
        }
    }
}
