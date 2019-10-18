using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.Data.SqlClient;
namespace SSGL
{
    public partial class _Frm006_报修 : Form
    {
        public _Frm006_报修()
        {
            InitializeComponent();
        }
        //思路根据账号获取此账号的姓名，宿舍号，手机号
        //需要一张报修表
        //先读取此账号学号，姓名，宿舍号再填充到一张报修表中
        //报修表结构  学号，姓名 宿舍号，手机号，报修类型，报修内容
        public _Frm006_报修(string str)
        {
            InitializeComponent();
            txtSno.Text = str;
            txtSno.Enabled = false;
            txtPhone.Enabled = false;
            txtName.Enabled = false;
            txtDor.Enabled = false;
        }
        private void Frm06_报修_Load(object sender, EventArgs e)
        {

        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void textBox5_TextChanged(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            //获取到的账号  再进一步获取姓名，手机号码，宿舍号码
            string str = "server=.;user=sa;pwd=1;database=ssgl";
            string sql = "select *from message where sno='" + txtSno.Text + "'";
            SqlConnection con = new SqlConnection(str);
            con.Open();
            SqlCommand com = new SqlCommand(sql,con);
            SqlDataReader dr = com.ExecuteReader();
            if (dr.HasRows)
            {
                dr.Read();
                txtName.Text = dr["sname"].ToString().Trim();
                txtPhone.Text = dr["sphone"].ToString().Trim();
                txtDor.Text = dr["sdor"].ToString().Trim();
                dr.Close();
            }
            con.Close();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            //将txt控件的信息填充到表repair中,既报修功能完善了
            string str = "server=.;user=sa;pwd=1;database=ssgl";
            string sql = "insert into Repair values('" + txtSno.Text + "','"+txtName.Text.Trim()+"','"+txtPhone.Text.Trim()+"','"+txtDor.Text.Trim()+"','"+txtDorTyte.Text.Trim()+"','"+txtbook.Text.Trim()+"')";
            SqlConnection con = new SqlConnection(str);
            con.Open();
            SqlCommand com = new SqlCommand(sql, con);
            if (com.ExecuteNonQuery()>0)
            {
                MessageBox.Show("提交成功");
            }
            else
            {
                MessageBox.Show("Test");
            }
        }

        private void txtSno_TextChanged(object sender, EventArgs e)
        {

        }

        private void txtName_TextChanged(object sender, EventArgs e)
        {

        }

        private void lbPhone_Click(object sender, EventArgs e)
        {

        }

        private void txtbook_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
