using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace 学生宿舍管理系统更新版
{
    public partial class Frm主界面 : Form
    {
        public Frm主界面()
        {
            InitializeComponent();
        } int srt;
        public Frm主界面(int str)
        {
            srt = str;//1为管理员
            InitializeComponent();
        }

        private void Frm主界面_Load(object sender, EventArgs e)
        {
            this.button1.Enabled = false;
            if (srt==1)
            {
                label1.Text = "欢迎管理员";
            } if (srt ==2)
            {
                label1.Text = "欢迎同学";
            }
        }

        private void checkBox1_CheckedChanged(object sender, EventArgs e)
        {
            if (checkBox1.Checked==true)
            {
                checkBox1.Text = "展开";
                //666, 508
                this.Width = 666;
                this.Height = 508;
                this.button1.Enabled = true;
                this.button2.Enabled = true;
                //this.button1.Enabled = true;

            }
            else
            {
                checkBox1.Text = "收缩";
                this.Width = 306;
                this.Height = 508;
                this.button1.Enabled = false;
                //this.button2.Enabled = false;

            }
        }
    }
}
