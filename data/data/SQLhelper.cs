using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using System.Data.SqlClient;
using System.Configuration;

namespace data
{
    class SQLhelper
    {
        public static string ConStr = ConfigurationManager.ConnectionStrings["ConStr"].ConnectionString;

        //通过sql查询语句获取数据  返回数据集对象
        public DataSet GetData(string SqlStr)
        {
            try
            {
                DataSet ds = new DataSet();
                SqlConnection con = new SqlConnection(ConStr);
                SqlCommand com = new SqlCommand(SqlStr,con);
                SqlDataAdapter dapt = new SqlDataAdapter(com);
                dapt.Fill(ds);
                return ds;
            }
            catch (Exception)
            {
                return null;
            }

            //更新 增删改操作，返回受影响的行数
        }
        public int Excute(string SqlStr)
        {
            try
            {
                int result = 0;
                SqlConnection con = new SqlConnection(ConStr);
                con.Open();
                SqlCommand com = new SqlCommand(SqlStr ,con);
                result = com.ExecuteNonQuery();
                con.Close();
                return result;
            }
            catch (Exception)
            {
                return 0;
            }
        }

        //param 参数  
        public int Excute(string SqlStr, SqlParameter[] param)
        {
            try
            {
                SqlConnection con = new SqlConnection(ConStr);
                con.Open();
                SqlCommand cmd = new SqlCommand(SqlStr,con);
                cmd.Parameters.AddRange(param);
                int result = cmd.ExecuteNonQuery();
                return result;
            }
            catch (Exception)
            {
                return 0;
            }
        }
    }
}
