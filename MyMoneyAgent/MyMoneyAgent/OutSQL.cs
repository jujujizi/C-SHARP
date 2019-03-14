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
    class OutSQL
    {
        public static List<OutRecord> LoadOutRcdList(string name)
        {
            string connString = @"Data Source=(LocalDB)\v11.0;AttachDbFilename=""E:\c++练习\MyMoneyAgent - 副本 (2) - 副本\MyMoneyAgent\MyMoney.mdf"";Integrated Security=True";
            SqlConnection conn = new SqlConnection(connString);//创建链接对象
            try
            {
                conn.Open();
                //查询数据库中
                string cmdTxt = "SELECT [支出编号], [姓名], [支出时间], [记录时间], [支出方式], " +
                                "[支出类型], [金额], [银行卡号], [支出说明] FROM [支出记录] " +
                                "WHERE [姓名]='" + name + "'";
                SqlCommand comm = new SqlCommand(cmdTxt, conn);
                List<OutRecord> recLst = new List<OutRecord>();
                SqlDataReader dr = comm.ExecuteReader();
                while (dr.Read())
                {
                    OutRecord rec = new OutRecord();
                    rec.ID = dr.GetInt32(0);
                    rec.OutTime = dr.GetDateTime(2);
                    rec.RecordTime = dr.GetDateTime(3);
                    rec.OutType = dr.GetString(4);
                    rec.OutUsage = dr.GetString(5);
                    rec.Amount = dr.GetDecimal(6);
                    rec.BankCard = dr.GetString(7);
                    rec.Description = dr.GetString(8);
                    recLst.Add(rec);
                }
                return recLst;
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
        public static List<OutRecord> LoadOutRcdListSearch(string name, string date1, string date2)
        {
            SqlDataAdapter da = new SqlDataAdapter();
            DataSet ds = new DataSet("MyMoney");
            string connString = @"Data Source=(LocalDB)\v11.0;AttachDbFilename=""E:\c++练习\MyMoneyAgent - 副本 (2) - 副本\MyMoneyAgent\MyMoney.mdf"";Integrated Security=True";
            SqlConnection conn = new SqlConnection(connString);//创建链接对象
            try
            {
                conn.Open();
                //查询数据库中
                string cmdTxt = "SELECT [支出编号], [姓名], [支出时间], [记录时间], [支出方式], " +
                                "[支出类型], [金额], [银行卡号], [支出说明] FROM [支出记录] " +
                                "WHERE [姓名]='" + name + "' AND ([支出时间] >=#" + date1 + "# AND [支出时间] <=#" + date2 + "#)";
                SqlCommand comm = new SqlCommand(cmdTxt, conn);
                da.SelectCommand = comm;
                SqlCommandBuilder builder = new SqlCommandBuilder(da);
                da.Fill(ds ,"支出记录");
                List<OutRecord> recList = new List<OutRecord>();
                SqlDataReader dr = comm.ExecuteReader();
                while (dr.Read())
                {
                    OutRecord rec = new OutRecord();
                    rec.ID = dr.GetInt32(0);
                    rec.OutTime = dr.GetDateTime(2);
                    rec.RecordTime = dr.GetDateTime(3);
                    rec.OutType = dr.GetString(4);
                    rec.OutUsage = dr.GetString(5);
                    rec.Amount = dr.GetDecimal(6);
                    rec.BankCard = dr.GetString(7);
                    rec.Description = dr.GetString(8);
                    recList.Add(rec);
                }
                return recList;
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
        public static bool DeleteOutRec(string name, int id)
        {
            string connString = @"Data Source=(LocalDB)\v11.0;AttachDbFilename=""E:\c++练习\MyMoneyAgent - 副本 (2) - 副本\MyMoneyAgent\MyMoney.mdf"";Integrated Security=True";
            SqlConnection conn = new SqlConnection(connString);//创建链接对象
            try
            {
                conn.Open();
                string cmdText;
                //删除命令
                cmdText = "DELETE FROM [支出记录] WHERE ([姓名]='" + name +
                          "' AND [支出编号]=" + id.ToString() + ")";
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
        //
        public static int GetUsableOutID(string name)
        {
            string connString = @"Data Source=(LocalDB)\v11.0;AttachDbFilename=""E:\c++练习\MyMoneyAgent - 副本 (2) - 副本\MyMoneyAgent\MyMoney.mdf"";Integrated Security=True";
            SqlConnection conn = new SqlConnection(connString);//创建链接对象
            try
            {
                conn.Open();
                //查询数据库中最大值
                string cmdTxt = "SELECT MAX([支出编号]) FROM [支出记录] " +
                                "WHERE [姓名]='" + name + "'";
                //查询命令
                SqlCommand comm = new SqlCommand(cmdTxt, conn);
                int id = 1;
                //读取数据
                SqlDataReader dr = comm.ExecuteReader();
                if (dr.Read())
                {
                    //不为DBNULL，则转换成int类型，并加1
                    if (!dr.IsDBNull(0))
                    {
                        id = dr.GetInt32(0);
                        id++;
                    }
                }
                return id;
            }
            catch (Exception)
            {
                return 0;
            }
            finally
            {
                //关闭连接
                conn.Close();
            }
        }
        //
        public static bool AddOutRec(string name, OutRecord rec)
        {
            string connString = @"Data Source=(LocalDB)\v11.0;AttachDbFilename=""E:\c++练习\MyMoneyAgent - 副本 (2) - 副本\MyMoneyAgent\MyMoney.mdf"";Integrated Security=True";
            SqlConnection conn = new SqlConnection(connString);//创建链接对象
            try
            {
                conn.Open();
                //插入新支出记录命令
                string cmdTxt;
                cmdTxt = string.Format("INSERT INTO [支出记录] VALUES({0}, '{1}', '{2}', '{3}', '{4}', '{5}', {6}, '{7}', '{8}')",
                                        rec.ID, name, rec.OutTime, rec.RecordTime, rec.OutType,
                                        rec.OutUsage, rec.Amount, rec.BankCard, rec.Description);
                //查询命令
                SqlCommand comm= new SqlCommand(cmdTxt, conn);
                comm.ExecuteNonQuery();
                return true;
            }
            catch (Exception e)
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
        public static bool ModifyOutRec(string name, OutRecord rec)
        {
            string connString = @"Data Source=(LocalDB)\v11.0;AttachDbFilename=""E:\c++练习\MyMoneyAgent - 副本 (2) - 副本\MyMoneyAgent\MyMoney.mdf"";Integrated Security=True";
            SqlConnection conn = new SqlConnection(connString);//创建链接对象
            try
            {
                conn.Open();
                //插入新支出记录命令
                string cmdTxt;
                cmdTxt = string.Format("UPDATE [支出记录] SET [支出时间]='{0}', [记录时间]='{1}', [支出方式]='{2}', [支出类型]='{3}', 金额={4}, [银行卡号]='{5}', [支出说明]='{6}' WHERE ([支出编号]={7} AND [姓名]='{8}')",
                                        rec.OutTime, rec.RecordTime, rec.OutType, rec.OutUsage,
                                        rec.Amount, rec.BankCard, rec.Description, rec.ID, name);
                //查询命令
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
