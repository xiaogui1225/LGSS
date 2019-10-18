using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace MDI环境下
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
           foreach (Form f in this.MdiChildren)
            {
                if (f.Name=="f2")
                    MessageBox.Show("请关闭其他窗体"); return;
            }
            f1 f01 =new  f1();
            f01.MdiParent = this;
            f01.Show();

        }

        private void button2_Click(object sender, EventArgs e)
        {
            foreach (Form f in this.MdiChildren)
            {
                if (f.Name == "f2" | f.Name == "f1")
                    MessageBox.Show("请关闭其他窗体"); return;
            }
            f2 f02 = new f2();
            f02.MdiParent = this;
            f02.Show();
        }
    }
}
