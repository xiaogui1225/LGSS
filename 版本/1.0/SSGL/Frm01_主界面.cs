using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace SSGL
{
   
    public partial class Frm01_主界面 : Form
    {

        public Frm01_主界面(bool @checked)
        {
            InitializeComponent();
            
        }
        public Frm01_主界面(string str)
        {
            InitializeComponent();
            txtNO.Text = str;//这句必须放在InitializeComponent();的后面，否则会引起“空引用异常”
        }


        private void 修改密码ToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            if (radAunt01.Checked == true)
            {
                Frm03_修改信息 f30 = new Frm03_修改信息(txtNO.Text);
                f30.Owner = this;
                f30.radaunt03.Checked = true;
                f30.Show();
            }
            if (radKeyuan01.Checked == true)
            {
                Frm03_修改信息 f32 = new Frm03_修改信息(txtNO.Text);
                f32.Owner = this;
                f32.radKey.Checked = true;
                f32.Show();

            }
            if (radStudent01.Checked == true)
            {
                Frm03_修改信息 f31 = new Frm03_修改信息(txtNO.Text);
                f31.Owner = this;
                f31.radStu03.Checked = true;
                f31.Show();
            }
            this.Hide();
        }
        private void f宿舍管理ToolStripMenuItem1_Click(object sender, EventArgs e)
        {

        }

        private void Toolsmt2_Click(object sender, EventArgs e)
        {

        }

        private void 切换用户ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Frm02_登录 f2 = new Frm02_登录();
            f2.Show();
            this.Close();
        }


        private void Frm01_主界面_Load(object sender, EventArgs e)
        {
            Frm02_登录 myFrm02 = new Frm02_登录();
            myFrm02.Owner = this;
            this.Text = myFrm02.txtNo.Text.Trim();
        }

        private void Toolsmt1_Click(object sender, EventArgs e)
        {

        }

        private void 修改密码ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Frm02_登录 myFrm02 = new Frm02_登录();
            Frm03_修改信息 f3 = new Frm03_修改信息();
            myFrm02.Show();
            this.Hide();
        }

        

        private void Tool注销_Click(object sender, EventArgs e)
        {
            Frm04_注销信息 f4 = new Frm04_注销信息(txtNO.Text);
            f4.Owner = this;
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
            this.Hide();
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
            Frm05_查交水电 f5 = new Frm05_查交水电();
            f5.Show();
        }
    }

   
}
