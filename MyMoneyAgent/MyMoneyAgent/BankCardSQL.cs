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
    class BankCardSQL
    {
        public static List<BankCardClass> LoadBankCardList(string name)
        {
            string connString = @"Data Source=(LocalDB)\v11.0;AttachDbFilename=""E:\c++练习\MyMoneyAgent - 副本 (2) - 副本\MyMoneyAgent\MyMoney.mdf"";Integrated Security=True";
            SqlConnection conn = new SqlConnection(connString);//创建链接对象
            try
            {
                conn.Open();
                List<BankCardClass> bkLst = new List<BankCardClass>();
                string cmdTxt = "SELECT [卡号], [开户银行], [余额] FROM [银行卡] WHERE [姓名]='" + name + "'";
                SqlCommand comm = new SqlCommand(cmdTxt, conn);
                SqlDataReader dr = comm.ExecuteReader();
                while (dr.Read())
                {
                    string id = dr.GetString(0);
                    string bk = dr.GetString(1);
                    decimal balance = dr.GetDecimal(2);
                    BankCardClass bkinfo = new BankCardClass();
                    bkinfo.Balance = balance;
                    bkinfo.BankName = bk;
                    bkinfo.CardNo = id;
                    bkinfo.Name = name;
                    bkLst.Add(bkinfo);
                }
                return bkLst;
            }
            catch (Exception)
            {
                return null;
            }
            finally
            {
                //关闭连接
                conn.Close();
            }
        }
        // 删除指定的银行卡
        public static bool DeleteBankCard(string cardno)
        {
            string connString = @"Data Source=(LocalDB)\v11.0;AttachDbFilename=""E:\c++练习\MyMoneyAgent - 副本 (2) - 副本\MyMoneyAgent\MyMoney.mdf"";Integrated Security=True";
            SqlConnection conn = new SqlConnection(connString);
            try
            {
                conn.Open();
                //执行删除命令
                string cmdTxt = "DELETE FROM [银行卡记录] WHERE [银行卡]='" + cardno + "'";
                SqlCommand comm = new SqlCommand(cmdTxt, conn);
                comm.ExecuteNonQuery();
                comm.CommandText = "DELETE FROM [银行卡] WHERE [卡号] = '" + cardno + "'";
                comm.ExecuteNonQuery();
                return true;
            }
            catch (Exception)
            {
                return false;
            }
            finally
            {
                //关闭连接
                conn.Close();
            }
        }
        // 加载指定银行卡的操作信息
        public static DataTable LoadBankOps(string cardno)
        {
            string connString = @"Data Source=(LocalDB)\v11.0;AttachDbFilename=""E:\c++练习\MyMoneyAgent - 副本 (2) - 副本\MyMoneyAgent\MyMoney.mdf"";Integrated Security=True";
            SqlConnection conn = new SqlConnection(connString);
            try
            {
                conn.Open();
                //查询数据库中
                List<BankCardClass> bkLst = new List<BankCardClass>();
                string cmdTxt = "SELECT [时间], [操作类型], [金额], [说明] FROM [银行卡记录] "
                                 + "WHERE [银行卡]='" + cardno + "'";
                SqlDataAdapter da = new SqlDataAdapter(cmdTxt, conn);
                DataTable dt = new DataTable();
                da.FillSchema(dt, SchemaType.Mapped);
                da.Fill(dt);
                return dt;
            }
            catch (Exception)
            {
                return null;
            }
            finally
            {
                //关闭连接
                conn.Close();
            }
        }

        public static bool DeleteBank(string cardno)
        {
            string connString = @"Data Source=(LocalDB)\v11.0;AttachDbFilename=""E:\c++练习\MyMoneyAgent - 副本 (2) - 副本\MyMoneyAgent\MyMoney.mdf"";Integrated Security=True";
            SqlConnection conn = new SqlConnection(connString);//创建链接对象
            try
            {
                conn.Open();
                string cmdText;
                //删除命令
                cmdText = "DELETE FROM [银行卡] WHERE ([卡号]='" +cardno+")";
                SqlCommand comm = new SqlCommand(cmdText, conn);
                //执行删除操作
                comm.ExecuteNonQuery();
                return true;
            }
            catch (Exception)
            {
                return false;
            }
            finally
            {
                conn.Close();
            }
        }

        public static bool MdyBankCards(BankCardClass bkInfo)
        {
            string connString = @"Data Source=(LocalDB)\v11.0;AttachDbFilename=""E:\c++练习\MyMoneyAgent - 副本 (2) - 副本\MyMoneyAgent\MyMoney.mdf"";Integrated Security=True";
            SqlConnection conn = new SqlConnection(connString);
            try
            {
                conn.Open();
                //执行删除命令
                string cmdTxt = string.Format("UPDATE [银行卡] SET [余额]={0} WHERE [卡号]='{1}'",
                                                bkInfo.Balance, bkInfo.CardNo);
                SqlCommand comm = new SqlCommand(cmdTxt, conn);
                comm.ExecuteNonQuery();
                return true;
            }
            catch (Exception)
            {
                return false;
            }
            finally
            {
                //关闭连接
                conn.Close();
            }
        }

        public static bool AddBankCards(BankCardClass bkInfo)
        {
            string connString = @"Data Source=(LocalDB)\v11.0;AttachDbFilename=""E:\c++练习\MyMoneyAgent - 副本 (2) - 副本\MyMoneyAgent\MyMoney.mdf"";Integrated Security=True";
            SqlConnection conn = new SqlConnection(connString);
            try
            {
                conn.Open();
                //执行删除命令
                string cmdTxt = string.Format("INSERT INTO [银行卡] VALUES('{0}','{1}','{2}',{3})",
                                               bkInfo.CardNo, bkInfo.Name, bkInfo.BankName, bkInfo.Balance);
                SqlCommand comm = new SqlCommand(cmdTxt, conn);
                comm.ExecuteNonQuery();
                return true;
            }
            catch (Exception)
            {
                return false;
            }
            finally
            {
                //关闭连接
                conn.Close();
            }
        }
        // 获取数据库中已有的方式列表
        public static List<PayTypeItem> LoadPayTypeList()
        {
            string connString = @"Data Source=(LocalDB)\v11.0;AttachDbFilename=""E:\c++练习\MyMoneyAgent - 副本 (2) - 副本\MyMoneyAgent\MyMoney.mdf"";Integrated Security=True";
            SqlConnection conn = new SqlConnection(connString);//创建链接对象
            try
            {
                conn.Open();
                //查询数据库中
                string cmdTxt = "SELECT [方式], [说明] FROM [方式表] ";
                SqlCommand comm = new SqlCommand(cmdTxt, conn);
                SqlDataReader dr;
                dr = comm.ExecuteReader();
                List<PayTypeItem> typeList = new List<PayTypeItem>();
                while (dr.Read())
                {
                    PayTypeItem item = new PayTypeItem();
                    item.PayType = dr.GetString(0);
                    item.Description = dr.GetString(1);
                    typeList.Add(item);
                }
                return typeList;
            }
            catch (Exception)
            {
                return null;
            }
            finally
            {
                //关闭连接
                conn.Close();
            }
        }
        //
        public static bool DeletePayType(string ty)
        {
            string connString = @"Data Source=(LocalDB)\v11.0;AttachDbFilename=""E:\c++练习\MyMoneyAgent - 副本 (2) - 副本\MyMoneyAgent\MyMoney.mdf"";Integrated Security=True";
            SqlConnection conn = new SqlConnection(connString);//创建链接对象
            try
            {
                conn.Open();
                //执行删除命令
                string cmdTxt = string.Format("DELETE FROM [方式表] WHERE [方式]='{0}'", ty);
                SqlCommand comm = new SqlCommand(cmdTxt, conn);
                comm.ExecuteNonQuery();
                return true;
            }
            catch (Exception)
            {
                return false;
            }
            finally
            {
                //关闭连接
                conn.Close();
            }
        }
        //
        public static bool AddPayType(PayTypeItem item)
        {

            string connString = @"Data Source=(LocalDB)\v11.0;AttachDbFilename=""E:\c++练习\MyMoneyAgent - 副本 (2) - 副本\MyMoneyAgent\MyMoney.mdf"";Integrated Security=True";
            SqlConnection conn = new SqlConnection(connString);//创建链接对象
            try
            {
                conn.Open();
                //执行删除命令
                string cmdTxt = string.Format("INSERT INTO [方式表] VALUES('{0}','{1}')",
                                               item.PayType, item.Description);
                SqlCommand comm = new SqlCommand(cmdTxt, conn);
                comm.ExecuteNonQuery();
                return true;
            }
            catch (Exception)
            {
                return false;
            }
            finally
            {
                //关闭连接
                conn.Close();
            }
        }
        //
        public static List<UsageItem> LoadUseageList()
        {
            string connString = @"Data Source=(LocalDB)\v11.0;AttachDbFilename=""E:\c++练习\MyMoneyAgent - 副本 (2) - 副本\MyMoneyAgent\MyMoney.mdf"";Integrated Security=True";
            SqlConnection conn = new SqlConnection(connString);//创建链接对象
            try
            {
                conn.Open();
                //查询数据库中
                string cmdTxt = "SELECT [用途], [说明] FROM [用途表] ";
                SqlCommand comm = new SqlCommand(cmdTxt, conn);
                SqlDataReader dr;
                dr = comm.ExecuteReader();
                List<UsageItem> usageLst = new List<UsageItem>();
                while (dr.Read())
                {
                    UsageItem item = new UsageItem();
                    item.Usage = dr.GetString(0);
                    item.Description = dr.GetString(1);
                    usageLst.Add(item);
                }
                return usageLst;
            }
            catch (Exception)
            {
                return null;
            }
            finally
            {
                //关闭连接
                conn.Close();
            }
        }
        //
        public static bool DeleteUsage(string usage)
        {
            string connString = @"Data Source=(LocalDB)\v11.0;AttachDbFilename=""E:\c++练习\MyMoneyAgent - 副本 (2) - 副本\MyMoneyAgent\MyMoney.mdf"";Integrated Security=True";
            SqlConnection conn = new SqlConnection(connString);//创建链接对象
            try
            {
                conn.Open();
                //执行删除命令
                string cmdTxt = string.Format("DELETE FROM [用途表] WHERE [用途]='{0}'", usage);
                SqlCommand comm = new SqlCommand(cmdTxt, conn);
                comm.ExecuteNonQuery();
                return true;
            }
            catch (Exception)
            {
                return false;
            }
            finally
            {
                //关闭连接
                conn.Close();
            }
        }
        //
        public static bool AddUsage(UsageItem item)
        {

            string connString = @"Data Source=(LocalDB)\v11.0;AttachDbFilename=""E:\c++练习\MyMoneyAgent - 副本 (2) - 副本\MyMoneyAgent\MyMoney.mdf"";Integrated Security=True";
            SqlConnection conn = new SqlConnection(connString);//创建链接对象
            try
            {
                conn.Open();
                //执行删除命令
                string cmdTxt = string.Format("INSERT INTO [用途表] VALUES('{0}','{1}')",
                                               item.Usage, item.Description);
                SqlCommand comm = new SqlCommand(cmdTxt, conn);
                comm.ExecuteNonQuery();
                return true;
            }
            catch (Exception)
            {
                return false;
            }
            finally
            {
                //关闭连接
                conn.Close();
            }

        }
    }
}
