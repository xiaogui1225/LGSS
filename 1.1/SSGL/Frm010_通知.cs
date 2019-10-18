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
    public partial class Frm010_通知 : Form
    {
        public Frm010_通知()
        {
            InitializeComponent();
            button1.Enabled = false;
        }
        //发通知这个功能
        /* 以阿姨发停水停电来台风既其他通知，为方便通知  一个是群发的通知，一个是单发的通知，单发通知就例如408宿舍你们吵到别人了宿舍
         怎么实现这个功能。。。对象就一个宿舍或全部宿舍使用对象就阿姨。阿姨输入内容存在数据库，再传递到对象这边，
         需要阿姨这边用控件输出，对象那边需要控件接受信息。根据宿舍号来发送信息*/

        private void Frm010_通知_Load(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {
            //2,80
        }

        private void txtDor_TextChanged(object sender, EventArgs e)
        {
            //81,78
        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

            if (comboxBook.Text=="单发")
            {
                button1.Enabled = true;
                lbDor.Location = new Point(4,63);
                lbDor.Visible = true;
                //81 78   81  99 119   2  138 2 88
                txtDor.Location = new Point(81,60);
                txtDor.Visible = true;
                button1.Location = new Point(81, 90);
                button1.Visible = true;
                label3.Location = new Point(4,94);
                label3.Visible = true;
                label1.Location = new Point(4,124);
                txtbook.Location=new  Point(81,121);
                txtbook.Visible = true;
                txtbook.Text = "";
            }
            if (comboxBook.Text=="群发")
            {
                button1.Enabled = true;
                label3.Location = new Point(4, 63);
                label1.Location = new Point(4,94);
                button1.Location = new Point(81,60);
                txtbook.Location = new Point(81, 90);
                lbDor.Visible = false;
                txtDor.Visible = false;
                txtbook.Text = "";
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (comboxBook.Text=="")
            {
                button1.Enabled = false;
            }
            else
            {
                button1.Enabled = true;
                if (comboxBook.Text == "群发")
                {
                   // string str = "server=103.46.128.43,40243;database=SSGL;uid=sa;pwd=QQqq1343000";
                    string str = SqlStr.constr;
                    string sql = "update  dormitory set sbook='" + txtbook.Text.Trim() + "'";
                    SqlConnection con = new SqlConnection(str);
                    con.Open();
                    SqlCommand com = new SqlCommand(sql, con);
                    if (com.ExecuteNonQuery() > 0)
                    {
                        MessageBox.Show("发送成功");
                    }
                    else
                    {
                        MessageBox.Show("发送失败");
                    }
                    con.Close();
                }
                if (comboxBook.Text == "单发")
                {
                    //访问数据库 ADO操作
                    string str = "server=.;user=sa;pwd=1;database=ssgl";
                    string sql = "update  dormitory set sbook='" + txtbook.Text.Trim() + "'where sdor='" + txtDor.Text.Trim() + "'";
                    SqlConnection con = new SqlConnection(str);
                    con.Open();
                    SqlCommand com = new SqlCommand(sql, con);
                    if (com.ExecuteNonQuery() > 0)
                    {
                        MessageBox.Show("发送成功");
                    }
                    else
                    {
                        MessageBox.Show("发送失败");
                    }
                    con.Close();
                }
            }
        }

        private void txtbook_TextChanged(object sender, EventArgs e)
        {
            //81,119
        }
    }
}
