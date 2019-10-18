using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Data.SqlClient;

namespace 学生宿舍管理系统更新版
{
    class sqlsql
    {

       public static string count = @"Data Source=.\SQLEXPRESS;AttachDbFilename=D:\文档\更新版\学生宿舍管理系统更新版\学生宿舍管理系统更新版\Database1.mdf;Integrated Security=True;User Instance=True";
       public SqlConnection con = new SqlConnection(count);
    }
}
