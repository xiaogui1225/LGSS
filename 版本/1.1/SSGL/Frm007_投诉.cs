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
    public partial class Frm007_投诉 : Form
    {
        public Frm007_投诉()
        {
            InitializeComponent();
        }
        public Frm007_投诉(string str)
        {
            InitializeComponent();
            txtSno.Text = str;
            txtSno.Enabled = false;
            txtPhone.Enabled = false;
            txtName.Enabled = false;
            txtDor.Enabled = false;
        }
        //投诉，以宿舍投诉宿舍，既要获取学号，姓名宿舍号，手机号，要投诉的宿舍号，投诉理由 提交
        private void Frm07_投诉_Load(object sender, EventArgs e)
        {

        }

        private void label4_Click(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
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
                txtPhone.Text = dr["sphone"].ToString().Trim();
                txtDor.Text = dr["sdor"].ToString().Trim();
                dr.Close();
            }
            con.Close();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (txthave.Text != "" | txttype.Text != "" | txtbook.Text != "")
            {
                string str = "server=.;user=sa;pwd=1;database=ssgl";
                string sql = "insert into  Complaint values('" + txtSno.Text + "','" + txtName.Text.Trim() + "','" + txtPhone.Text.Trim() + "','" + txtDor.Text.Trim() + "','" + txttype.Text.Trim() + "','" + txthave.Text.Trim() + "','" + txtbook.Text.Trim() + "')";
                SqlConnection con = new SqlConnection(str);
                con.Open();
                SqlCommand com = new SqlCommand(sql, con);
                if (com.ExecuteNonQuery() > 0)
                {
                    MessageBox.Show("提交成功");
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
