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
    public partial class _Frm008_换宿舍 : Form
    {
        public _Frm008_换宿舍()
        {
            InitializeComponent();
        }
        //思路  学号 姓名，宿舍，班级，系 ，理由，

        public _Frm008_换宿舍(string str)
        {
            InitializeComponent();
            txtSno.Text = str;
        }
        private void Frm07_换宿舍_Load(object sender, EventArgs e)
        {

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void but1_Click(object sender, EventArgs e)
        {
            string str = "server=.;user=sa;pwd=1;database=ssgl";
            string sql = "select *from message where sno='" + txtSno.Text + "'";
            SqlConnection con = new SqlConnection(str);
            con.Open();
            SqlCommand com = new SqlCommand(sql, con);
            SqlDataReader dr = com.ExecuteReader();
            if (dr.HasRows)
            {
                dr.Read();
                txtName.Text = dr["sname"].ToString().Trim();
                txtDor.Text = dr["sdor"].ToString().Trim();
                txtClass.Text = dr["sClass"].ToString().Trim();
                txtSyt.Text = dr["sSystem"].ToString().Trim();
                dr.Close();
            }
            con.Close();
        }

        private void textBox6_TextChanged(object sender, EventArgs e)
        {

        }

        private void btn2_Click(object sender, EventArgs e)
        {
            if (textBox6.Text != "" )
            {
                string str = "server=.;user=sa;pwd=1;database=ssgl";
                string sql = "insert into  changeDor values('" + txtSno.Text + "','" + txtName.Text.Trim() + "','" + txtDor.Text.Trim() + "','" + txtSyt.Text.Trim() + "','" + txtClass.Text.Trim() + "','" + textBox6.Text.Trim() + "')";
                SqlConnection con = new SqlConnection(str);
                con.Open();
                SqlCommand com = new SqlCommand(sql, con);
                if (com.ExecuteNonQuery() > 0)
                {
                    MessageBox.Show("提交成功");
                    but2.Enabled = false;

                }
                else
                {
                    MessageBox.Show("Test");
                }
            }
            else
            {
                MessageBox.Show("请完善信息");
            }
        }
    }
}
