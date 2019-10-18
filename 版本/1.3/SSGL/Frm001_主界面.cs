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
//设一个全局变量，为0；如果有打开窗体就为1；以此来判断有没有窗体打开过，如果为1了
namespace SSGL
{
   
    public partial class Frm001_主界面 : Form
    {
        public Frm001_主界面()
        {
            InitializeComponent();
        }
        public Frm001_主界面(string str)
        {
            InitializeComponent();
            txtNO.Text = str;//这句必须放在InitializeComponent();的后面，否则会引起“空引用异常”
        }

        private void 修改密码ToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            foreach (Form f in this.MdiChildren)
            {
                if (f.Name == "Frm004_注销信息" | f.Name == "Frm002_登录" | f.Name == "Frm009_功能详情" | f.Name == "Frm010_通知" | f.Name == "Frm011_查看资料" | f.Name == "Frm012_申请表" | f.Name == "Frm013_投诉归纳")
                    MessageBox.Show("请关闭其他窗体"); return;
            }
            
            Frm003_修改信息 f30 = new Frm003_修改信息(txtNO.Text);
            f30.Owner = this; //与下一句顺序不可调
            f30.MdiParent = this;

            if (radAunt01.Checked == true)
            {
                f30.radaunt03.Checked = true;
                f30.Show();
            }
            if (radKeyuan01.Checked == true)
            {
                f30.radKey.Checked = true;
                f30.Show();

            }
            if (radStudent01.Checked == true)
            {
                f30.radStu03.Checked = true;
                f30.Show();
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
            foreach (Form f in this.MdiChildren)
            {
                if (f.Name == "Frm003_修改信息" | f.Name == "Frm004_注销信息" | f.Name == "Frm009_功能详情" | f.Name == "Frm010_通知" | f.Name == "Frm011_查看资料" | f.Name == "Frm012_申请表"|f.Name=="Frm013_投诉归纳")
                 MessageBox.Show("请关闭其他窗体"); return; 
            }
            Frm002_登录 f2 = new Frm002_登录(this);
            f2.MdiParent = this;
            f2.Show();
            this.Toolmodi修改.Enabled = false;
            this.Tool注销.Enabled = false;
            this.Tool切换用户.Enabled = false;
            groupBox1.Visible = false;
            this.Toolsmt2.Enabled = false;
            this.Toolsmt3.Enabled = false;
            this.Toolsmt4.Enabled = false;
            this.ToolS登录.Visible = true;

        }

        private void Frm01_主界面_Load(object sender, EventArgs e)
        {
            Frm002_登录 myFrm02 = new Frm002_登录();
            myFrm02.Owner = this;
            this.Text = myFrm02.txtNo.Text.Trim();
        }

        //private void Toolsmt1_Click(object sender, EventArgs e)
        //{

        //}

        private void Tool注销_Click(object sender, EventArgs e)
        {
            foreach (Form f in this.MdiChildren)
            {
                if (f.Name == "Frm003_修改信息" | f.Name == "Frm002_登录" | f.Name == "Frm009_功能详情" | f.Name == "Frm010_通知" | f.Name == "Frm011_查看资料" | f.Name == "Frm012_申请表" | f.Name == "Frm013_投诉归纳")
                 MessageBox.Show("请关闭其他窗体"); return;
            }
            Frm004_注销信息 f4 = new Frm004_注销信息(txtNO.Text);
            f4.Owner = this;
            f4.MdiParent = this;
            if (radStudent01.Checked == true)
            {
                f4.s.Checked = true;
                f4.Show();
            }
            if (radAunt01.Checked == true)
            {
                f4.a.Checked = true;
                f4.Show();
            }
            if (radKeyuan01.Checked == true)
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
                
                _Frm005_查交水电 f5 = new _Frm005_查交水电(txtNO.Text);
                f5.Owner = this;
                f5.MdiParent = this;
                f5.radAunt.Checked = true;
                f5.Show();
            }
            if (radStudent01.Checked == true)
            {
                _Frm005_查交水电 f5 = new _Frm005_查交水电(txtNO.Text);
                f5.Owner = this;
                f5.MdiParent = this;
                f5.radStu.Checked = true;
                f5.Show();
            }
            if (radKeyuan01.Checked == true)
            {
                _Frm005_查交水电 f5 = new _Frm005_查交水电(txtNO.Text);
                f5.Owner = this;
                f5.MdiParent = this;
                f5.radKey.Checked = true;
                f5.Show();
            }

        }

        private void 报修ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            _Frm006_报修 f6 = new _Frm006_报修(txtNO.Text);
            f6.MdiParent = this;
            f6.Show();
        }

        private void 投诉ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            _Frm007_投诉 f7 = new _Frm007_投诉(txtNO.Text);
            f7.MdiParent = this;
            f7.Show();
        }

        private void 申请换宿舍ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            _Frm008_换宿舍 f8 = new _Frm008_换宿舍(txtNO.Text);
            f8.MdiParent = this;
            f8.Show();
        }

        private void 功能详情ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            foreach (Form f in this.MdiChildren)
            {
                if(f.Name == "Frm003_修改信息" | f.Name == "Frm004_注销信息" | f.Name == "Frm012_申请表" | f.Name == "Frm011_查看资料" | f.Name == "Frm013_投诉归纳" |f.Name == "Frm010_通知")
                    MessageBox.Show("请关闭其他窗体");return;
            }
            Frm009_功能详情 f9 = new Frm009_功能详情(txtNO.Text);
            //Frm009_功能详情 f91 = new Frm009_功能详情(this);
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
            foreach (Form f in this.MdiChildren)
            {
                if (f.Name == "Frm003_修改信息" |  f.Name == "Frm009_功能详情" | f.Name == "Frm004_注销信息" | f.Name == "Frm011查看资料" |f.Name == "Frm013_投诉归纳"| f.Name == "Frm012_申请表")
                    MessageBox.Show("请关闭其他窗体"); return;
            }
                
            if (groupBox1.Visible == false)
                groupBox1.Visible = true;
            else
                groupBox1.Visible = false;
            if (radStudent01.Checked == true)
            {
                try
                {
                    string sqlstr = SQLstr.sqlstr;
                    string sql = "select *from dormitory where sno='" + txtNO.Text.Trim() + "'";
                    SqlConnection con = new SqlConnection(sqlstr);
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

        private void ToolS登录_Click(object sender, EventArgs e)
        {
            //Frm001_主界面 f1 = new Frm001_主界面();
            Frm002_登录 myFrm02 = new Frm002_登录(this);
            Frm003_修改信息 f3 = new Frm003_修改信息();
            myFrm02.MdiParent = this;
            //this.Hide();
            myFrm02.Show();
        }

        private void 发小通知ToolStripMenuItem_Click_1(object sender, EventArgs e)
        {

            foreach (Form f in this.MdiChildren)
            {
                if (f.Name == "Frm003_修改信息"| f.Name == "Frm004_注销信息" | f.Name == "Frm009_功能详情" | f.Name == "Frm011_查看资料" | f.Name == "Frm013_投诉归纳" | f.Name == "Frm010_通知"|f.Name == "Frm012_申请表")
                    MessageBox.Show("请关闭其他窗体"); return;
            }
            Frm010_通知 f10 = new Frm010_通知();
            f10.MdiParent = this;
            f10.Show();
        }

        private void 换宿舍意见ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            foreach (Form f in this.MdiChildren)
            {
                if (f.Name=="Frm003_修改信息"| f.Name == "Frm004_注销信息" | f.Name == "Frm009_功能详情" | f.Name == "Frm011_查看资料" | f.Name == "Frm013_投诉归纳" |  f.Name == "Frm010_通知")
                    MessageBox.Show("请关闭其他窗体");return;
            }
            Frm012_申请表 f12 = new Frm012_申请表();
            f12.MdiParent = this;
            f12.Show();
        }

        private void 投诉归纳ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            foreach (Form f in this.MdiChildren)
            {
                if (f.Name == "Frm003_修改信息" | f.Name == "Frm004_注销信息" | f.Name == "Frm009_功能详情" | f.Name == "Frm011_查看资料" | f.Name == "Frm012_申请表" | f.Name == "Frm010_通知"|f.Name=="Frm011_查看资料")
                    MessageBox.Show("请关闭其他窗体");return;
            }
            Frm013_投诉归纳 f13 = new Frm013_投诉归纳();
            f13.MdiParent = this;
            f13.Show();
        }

        private void 查看ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            foreach (Form f in this.MdiChildren)
            {
                if (f.Name == "Frm003_修改信息" | f.Name == "Frm004_注销信息" | f.Name == "Frm009_功能详情" | f.Name == "Frm011_查看资料" | f.Name == "Frm012_申请表" | f.Name == "Frm010_通知"|f.Name=="Frm013_投诉归纳")
                    MessageBox.Show("请关闭其他窗体");
                return;
            }
            Frm011_查看资料 f11 = new Frm011_查看资料();
            f11.MdiParent = this;
            f11.Show();
        }
    }
}
