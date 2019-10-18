using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.Data.SqlClient;
//还差  申请换宿舍 ，投诉归纳，发通知，这些做完了之后就重新设计数据库结构，再然后优化界面  yes
namespace SSGL
{
   
    public partial class Frm001_主界面 : Form
    {

        public Frm001_主界面(/*bool @checked*/)
        {
            InitializeComponent();
        }
        public Frm001_主界面(string str)
        {
            InitializeComponent();
            txtNO.Text = str;//这句必须放在InitializeComponent();的后面，否则会引起“空引用异常”
        }

        //public Frm001_主界面(Frm001_主界面 f1)
        //{
        //    InitializeComponent();
        //   //Frm001_主界面 f001 =new Frm001_主界面(f1);
        //}

        private void 修改密码ToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            if (radAunt01.Checked == true)
            {
                Frm003_修改信息 f30 = new Frm003_修改信息(txtNO.Text);
                f30.Owner = this;
                f30.MdiParent = this;
                f30.radaunt03.Checked = true;
                f30.Show();
            }
            if (radKeyuan01.Checked == true)
            {
                Frm003_修改信息 f32 = new Frm003_修改信息(txtNO.Text);
                f32.MdiParent = this;
                f32.Owner = this;
                f32.radKey.Checked = true;
                f32.Show();

            }
            if (radStudent01.Checked == true)
            {
                Frm003_修改信息 f31 = new Frm003_修改信息(txtNO.Text);
                f31.MdiParent = this;
                f31.Owner = this;
                f31.radStu03.Checked = true;
                f31.Show();
            }
        }
        private void f宿舍管理ToolStripMenuItem1_Click(object sender, EventArgs e)
        {

        }

        private void Toolsmt2_Click(object sender, EventArgs e)
        {

        }

        private void 切换用户ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Frm002_登录 f2 = new Frm002_登录(this);
            f2.MdiParent = this;
            f2.Show();
            this.Toolmodi修改.Enabled = false;
            this.Tool注销.Enabled = false;
            this.Tool切换用户.Enabled = false;
            this.Toolsmt2.Enabled = false;
            this.Toolsmt3.Enabled = false;
            this.Toolsmt4.Enabled = false;
        }


        private void Frm01_主界面_Load(object sender, EventArgs e)
        {
            Frm002_登录 myFrm02 = new Frm002_登录();
            myFrm02.Owner = this;
            this.Text = myFrm02.txtNo.Text.Trim();
        }

        private void Toolsmt1_Click(object sender, EventArgs e)
        {

        }

      
        

        private void Tool注销_Click(object sender, EventArgs e)
        {
            Frm004_注销信息 f4 = new Frm004_注销信息(txtNO.Text);
            f4.Owner = this;
            f4.MdiParent = this;
            if (radStudent01.Checked==true)
            {
                f4.s.Checked = true;
                f4.Show();
            }
            if (radAunt01.Checked==true)
            {
                f4.a.Checked = true;
                f4.Show();
            }
            if (radKeyuan01.Checked==true)
            {
                f4.key.Checked = true;
                f4.Show();
            }
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void radioButton1_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void radKeyuan01_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void 查水电ToolStripMenuItem_Click(object sender, EventArgs e)
        {

            if (radAunt01.Checked==true)
            {
                Frm005_查交水电 f5 = new Frm005_查交水电(txtNO.Text);
                f5.Owner = this;
                f5.MdiParent = this;
                f5.radAunt.Checked = true;
                f5.Show();
            }
            if (radStudent01.Checked == true)
            {
                Frm005_查交水电 f5 = new Frm005_查交水电(txtNO.Text);
                f5.Owner = this;
                f5.MdiParent = this;
                f5.radStu.Checked = true;
                f5.Show();
            }
            if (radKeyuan01.Checked == true)
            {
                Frm005_查交水电 f5 = new Frm005_查交水电(txtNO.Text);
                f5.Owner = this;
                f5.MdiParent = this;
                f5.radKey.Checked = true;
                f5.Show();
            }

        }

        private void 报修ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Frm006_报修 f6 = new Frm006_报修(txtNO.Text);
            f6.MdiParent = this;
            f6.Show();
        }

        private void 投诉ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Frm007_投诉 f7 = new Frm007_投诉(txtNO.Text);
            f7.MdiParent = this;
            f7.Show();
        }

        private void 申请换宿舍ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Frm008_换宿舍 f8 = new Frm008_换宿舍(txtNO.Text);
            f8.MdiParent = this;
            f8.Show();
        }

        private void 功能详情ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Frm009_功能详情 f9 = new Frm009_功能详情(txtNO.Text);
            f9.MdiParent = this;
            f9.Show();
        }

        private void groupBox1_Enter(object sender, EventArgs e)
        {

        }

        private void textBox1_TextChanged_1(object sender, EventArgs e)
        {

        }

        private void 通知ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            groupBox1.Visible=true;
            if (groupBox1.Enabled !=true)
            {
                groupBox1.Enabled=true;
                return;
            }
            else
            {
                groupBox1.Enabled = false;
            }
            if (radStudent01.Checked == true)
            {
                try
                {
                    string s = "server=.;user=sa;pwd=1;database=ssgl";
                    string sql = "select *from dormitory where sno='" +  txtNO.Text.Trim() + "'";
                    SqlConnection con = new SqlConnection(s);
                    con.Open();
                    SqlCommand com = new SqlCommand(sql, con);
                    SqlDataReader dr = com.ExecuteReader();
                    if (dr.HasRows)
                    {
                        dr.Read();
                        txtbook.Text = dr["sbook"].ToString().Trim();
                        dr.Close();
                    }
                    con.Close();
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message.ToString());
                }
            }
        }

        private void Toolsmt4_Click(object sender, EventArgs e)
        {

        }

        private void 查看资料ToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            Frm011查看资料 f11 = new Frm011查看资料();
            f11.MdiParent = this;
            f11.Show();
        }

        private void ToolS登录_Click(object sender, EventArgs e)
        {
            //Frm001_主界面 f1 = new Frm001_主界面();
            Frm002_登录 myFrm02 = new Frm002_登录(this);
            Frm003_修改信息 f3 = new Frm003_修改信息();
            myFrm02.MdiParent = this;
            //this.Hide();
            myFrm02.Show();
        }
    }

   
}
