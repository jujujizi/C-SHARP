using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace MyMoneyAgent
{
    public enum UserRights
    {
        // 管理员权限
        Administrator = 0,
        // 普通用户权限
        NormalUser = 1,
        // 只读用户权限
        ReadOnlyUser = 1,
    };
    public class UserClass
    {
        //私有字段
        private string name;
        private string password;
        private UserRights right;
        public UserClass (string name,string pwd,UserRights right)
        {
            this.name = name;
            this.password = pwd;
            this.right = right;
        }
        public string Name
        {
            get
            {
                return this.name;
            }
        }
        public string Password
        {
            get { return this.password; }
            set { this.password = value; }
        }
        public UserRights Right
        {
            get { return this.right; }
            set { this.right = value; }
        }
        //更改密码
        public bool ChangePwd(string oldpwd,string newpwd)
        {
            if(this .password !=oldpwd )
            {
                return false;
            }
            this.password = newpwd;
            return true;
        }
        public override string ToString()
        {
            return this.name ;
        }
    }

}
