using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.Data.SqlClient;

namespace 学生宿舍管理系统更新版
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        static string count = @"Data Source=.\SQLEXPRESS;AttachDbFilename=D:\文档\更新版\学生宿舍管理系统更新版\学生宿舍管理系统更新版\Database1.mdf;Integrated Security=True;User Instance=True";

        string sql;
        SqlCommand cmd;
        SqlDataReader dr;
        SqlConnection con = new SqlConnection(count);
        private void Form1_Resize(object sender, EventArgs e)
        {
            if (this.WindowState == FormWindowState.Minimized)
            {
                notifyIcon1.Visible = true;
            }
            else
            {
                notifyIcon1.Visible = false;
            }
        }

        private void notifyIcon1_MouseDoubleClick(object sender, MouseEventArgs e)
        {
            this.Visible = true;
            this.WindowState = FormWindowState.Normal;
        }

        private void 显示ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Visible = true;
            this.WindowState = FormWindowState.Normal;
        }

        private void 退出ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            
            con.Open(); //user_id
            //Select * from table1 where id=@id and pwd=@pwd",con)
            SqlCommand cmd = new SqlCommand("select * from myuser where u_id=@u_id and u_pwd=@u_pwd", con);
            cmd.Parameters.Add("@u_id", SqlDbType.VarChar).Value = textBox1.Text.Trim();
            cmd.Parameters.Add("@u_pwd", SqlDbType.VarChar).Value = textBox2.Text.Trim();
            try
            {
                SqlDataReader dr = cmd.ExecuteReader();
                dr.Read();
                MessageBox.Show("登录成功");
                if ((int)dr[2]==1)//1为管理员  //2为学生   //然后传递出去管理员这个消息
                {
                    MessageBox.Show("欢迎管理员");
                    Frm主界面 f1 = new Frm主界面(1);
                    f1.Show();
                } if ((int)dr[2] == 2)//1为管理员  //2为学生   //然后传递出去管理员这个消息
                {
                    MessageBox.Show("欢迎同学");
                    Frm主界面 f1 = new Frm主界面(2);
                    f1.Show();
                }
                
            }
            catch{
                MessageBox.Show("登录失败");
            }
            finally {
                con.Close();
                cmd.Dispose();
            }
        
        }
    }
}
