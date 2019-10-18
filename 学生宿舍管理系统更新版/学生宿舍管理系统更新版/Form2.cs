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
    public partial class Form2 : Form
    {
        public Form2()
        {
            InitializeComponent();
        }

        SqlConnection con;
        //SqlCommand cmd;
        SqlDataAdapter da;
        DataSet ds;
        BindingManagerBase bm;
        SqlCommandBuilder cb;
        //DataTable dt;
        DataRow dr;
        private void Form2_Load(object sender, EventArgs e)
        {
            string count = @"Data Source=.\SQLEXPRESS;AttachDbFilename=D:\文档\更新版\学生宿舍管理系统更新版\学生宿舍管理系统更新版\Database1.mdf;Integrated Security=True;User Instance=True";
            con = new SqlConnection(count);
            da = new SqlDataAdapter("select * from stu_message",con);
            ds = new DataSet();
            da.Fill(ds,"mytable");
            bm = this.BindingContext[ds, "mytable"];//绑定要操作的对象及内容
        }

        private void button1_Click(object sender, EventArgs e)
        {
            //dataGridView1.DataSource = ds.Tables["mytable"];
            dataGridView1.DataSource = ds;
            dataGridView1.DataMember = "mytable";//绑定控件
        }

        private void button2_Click(object sender, EventArgs e)
        {
            bm.Position = 0;
        }

        private void button3_Click(object sender, EventArgs e)
        {
            bm.Position ++;
        }

        private void button4_Click(object sender, EventArgs e)
        {
            bm.Position --;
        }

        private void button5_Click(object sender, EventArgs e)
        {
            bm.Position = bm.Count - 1;
        }
        private void button6_Click(object sender, EventArgs e)
        {
            string count = @"Data Source=.\SQLEXPRESS;AttachDbFilename=D:\文档\更新版\学生宿舍管理系统更新版\学生宿舍管理系统更新版\Database1.mdf;Integrated Security=True;User Instance=True";
            con = new SqlConnection(count);
            da = new SqlDataAdapter("select * from stu_message", con);
            cb = new SqlCommandBuilder(da);
            ds = new DataSet();
            da.Fill(ds, "mytable");
            DataTable dt = ds.Tables["mytable"];
            DataRow dr = dt.NewRow();
            dr[0] = textBox1.Text.Trim();
            dr[1] = textBox2.Text.Trim();
            dt.Rows.Add(dr);
            try
            {
                da.Update(ds, "mytable");
                MessageBox.Show("添加成功");
            }
            catch (Exception ex)
            {
                MessageBox.Show("添加失败"/*ex.Message.ToString()*/);
            }
        }
        private void button7_Click(object sender, EventArgs e)
        {
            string count = @"Data Source=.\SQLEXPRESS;AttachDbFilename=D:\文档\更新版\学生宿舍管理系统更新版\学生宿舍管理系统更新版\Database1.mdf;Integrated Security=True;User Instance=True";
            con = new SqlConnection(count);
            da = new SqlDataAdapter("select * from stu_message", con);
            cb = new SqlCommandBuilder(da);
            ds = new DataSet();
            da.Fill(ds, "mytable");
            DataTable dt = ds.Tables["mytable"];
            DataRow dr;
            for (int i = 0; i < dt.Rows.Count; i++)
            {
                dr = dt.Rows[i];
                if (Convert.ToInt32(dr[0])==Convert.ToInt32(textBox1.Text))
                {
                    dr[1] = textBox2.Text;

                }
            }
            try
            {
                MessageBox.Show("修改成功");
                da.Update(ds, "mytable");
            }
            catch (Exception)
            {
                MessageBox.Show("修改失败");
            }
        }

        private void button8_Click(object sender, EventArgs e)
        {
            string count = @"Data Source=.\SQLEXPRESS;AttachDbFilename=D:\文档\更新版\学生宿舍管理系统更新版\学生宿舍管理系统更新版\Database1.mdf;Integrated Security=True;User Instance=True";
            con = new SqlConnection(count);
            da = new SqlDataAdapter("select * from stu_message", con);
            cb = new SqlCommandBuilder(da);
            ds = new DataSet();
            da.Fill(ds, "mytable");
            DataTable dt = ds.Tables["mytable"];
            DataRow dr;
            for (int i = 0; i < dt.Rows.Count; i++)
            {
                dr = dt.Rows[i];
                if (Convert.ToInt32(dr[0]) ==Convert.ToInt32( textBox1.Text.Trim()))
                {
                    dt.Rows[i].Delete();
                    MessageBox.Show("删除成功");
                }
            }
            da.Update(ds, "mytable");
        }

        private void textBox1_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsDigit(e.KeyChar) && e.KeyChar != '\b')
            {
                e.Handled = true;  //非以上键则禁止输入
            }
        }

        private void textBox2_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsDigit(e.KeyChar) && e.KeyChar != '\b')
            {
                e.Handled = true;  //非以上键则禁止输入
            }
        }
    }
}
