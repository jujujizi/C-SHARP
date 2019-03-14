using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;

namespace MyMoneyAgent
{
    class UserSql
    {
        //获取用户列表
        public static List <UserClass >LoadUserList()
        {
            string connString = @"Data Source=(LocalDB)\v11.0;AttachDbFilename=""E:\c++练习\MyMoneyAgent - 副本 (2) - 副本\MyMoneyAgent\MyMoney.mdf"";Integrated Security=True";
            SqlConnection conn = new SqlConnection(connString);//创建链接对象
            try
            {
                conn.Open();
                List<UserClass> userlist = new List<UserClass>();
                string cmdTxt = "SELECT [姓名], [密码], [权限] FROM [用户]";
                SqlCommand comm = new SqlCommand(cmdTxt, conn);//创建Commond的对象
                SqlDataReader dr = comm.ExecuteReader();
                while (dr.Read ())
                {
                    string name = dr.GetString(0);
                    string pwd = dr.GetString(1);
                    UserRights rt = (UserRights)dr.GetInt32(2);
                    UserClass user = new UserClass(name ,pwd ,rt);
                    userlist.Add(user);
                }
                return userlist;
            }
                catch (Exception )
                {
                    return null;
                }
            finally 
            {
                conn .Close ();
            }
            

        }
        //删除用户
         public static bool DeleteUser(string name)
        {
            string connString = @"Data Source=(LocalDB)\v11.0;AttachDbFilename=""E:\c++练习\MyMoneyAgent - 副本 (2) - 副本\MyMoneyAgent\MyMoney.mdf"";Integrated Security=True";
            SqlConnection conn = new SqlConnection(connString);
             try
             {
                 conn.Open();
                 string cmdTxt = "DELETE FROM [用户] WHERE [姓名]='" + name + "'";
                 SqlCommand comm = new SqlCommand(cmdTxt, conn);
                 comm.ExecuteNonQuery();
                 return true;
             }
             catch (Exception )
             {
                 return false;
             }
             finally
             {
                 conn.Close();
             }
        }
        //添加用户
        public static bool Adduser(UserClass user)
         {
             string connString = @"Data Source=(LocalDB)\v11.0;AttachDbFilename=""E:\c++练习\MyMoneyAgent - 副本 (2) - 副本\MyMoneyAgent\MyMoney.mdf"";Integrated Security=True";
             SqlConnection conn = new SqlConnection(connString);
            try
            {
                conn.Open();
                string cmdTxt = string.Format("INSERT INTO [用户] VALUES('{0}','{1}',{2})",
                                               user.Name, user.Password, (int)user.Right);
                SqlCommand comm = new SqlCommand(cmdTxt, conn);
                comm.ExecuteNonQuery();
                return true;
            }
            catch  (Exception)
            {
                return false;
            }
            finally
            {
                conn.Close();
            }
         }
        //修改用户密码和权限
        public static bool ModifyUser(UserClass user)
        {
            string connString = @"Data Source=(LocalDB)\v11.0;AttachDbFilename=""E:\c++练习\MyMoneyAgent - 副本 (2) - 副本\MyMoneyAgent\MyMoney.mdf"";Integrated Security=True";
            SqlConnection conn = new SqlConnection(connString);
            try
            {
                conn.Open();
                string cmdTxt = string.Format("UPDATE [用户] SET [密码]='{0}', [权限] = {1} WHERE [姓名]='{2}'",
                                              user.Password, (int)user.Right, user.Name);
                SqlCommand comm = new SqlCommand(cmdTxt, conn);
                comm.ExecuteNonQuery();
                return true;
            }
            catch (Exception )
            {
                return false;
            }
            finally
            {
                conn.Close();
            }
        }

    }
}
