using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.Data.SqlClient;
// 整个思路，   txtsno绑定数据库sno，其他也是用selec，已交水费，电费 用update 限制不能输入负数，也不能输入多，只能输入符合的金额。其他都无效。
namespace SSGL
{
    public partial class Frm005_查交水电 : Form
    {
        public Frm005_查交水电()
        {
            InitializeComponent();
            //获取账号，和数据库中的表

         
        }
        /*接受来自主界面的txtNo.text的参数的方法  ，前提则需要，在new 出这个窗体是传出txtNo.Text这个参数。应该不难*/
        public Frm005_查交水电(string str)
        {
            InitializeComponent();
            textBox1.Text = str;
        }

        private void Frm05_查交水电_Load(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            // 思路，参照书里那个百货读取信息，添加进货量，
            //这个就读取个人信息，学号，姓名，宿舍号，水电费，已交水费，已交电费，添加已交功能。。。。 over
            if (txtOverE.Text != txtEf.Text | txtOverW.Text != txtWater.Text)
            {
                MessageBox.Show("请缴相对应的金额");
            }
            else
            {
                string str = "server=.;user=sa;pwd=1;database=ssgl";
                SqlConnection con = new SqlConnection(str);

                con.Open();
                string sqlup = "update dormitory set soverwe='" + txtWater.Text.Trim() + "', soveref='" + txtEf.Text.Trim() + "'where sno='" + txtSno.Text.Trim() + "'";
                SqlCommand com01 = new SqlCommand(sqlup, con);
                if (com01.ExecuteNonQuery() > 0)
                {
                    MessageBox.Show("已缴清");
                }
                else
                {
                    MessageBox.Show("请缴相对应的金额");
                }
                con.Close();
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            string str = "server=.;user=sa;pwd=1;database=ssgl";
            // 访问数据库
            string sql = "select *from dormitory where sno='" + textBox1.Text.Trim() + "'";
            //执行sql查询语句
            SqlConnection con = new SqlConnection(str);
            //创建连接数据库
            con.Open();
            SqlCommand com = new SqlCommand(sql, con);
            //创建操作对象
            SqlDataReader dr = com.ExecuteReader();
            //读取
            //读取数据填充到txtbox控件中
            if (dr.HasRows)
            {
                dr.Read();//打开阅读之后要对应的关闭阅读

                txtSno.Text = textBox1.Text.Trim();
                txtDor.Text = dr["sDor"].ToString();
                txtName.Text = dr["sname"].ToString();
                txtEf.Text = dr["sEf"].ToString();
                txtWater.Text = dr["sWatera"].ToString();
                con.Close();
                dr.Close();
            }
        }

        private void txtOverE_TextChanged(object sender, EventArgs e)
        {

        }
    }
}

