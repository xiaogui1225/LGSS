using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace love
{
    public partial class Form1 : Form
    {
        int x = 64; int y = 256;
        public Form1()
        {
            InitializeComponent();
            
        }

        private void button1_Click(object sender, EventArgs e)
        {

        }

        private static int times; //定义静态变量
        private void button1_MouseEnter(object sender, EventArgs e)
        {
            int x = this.ClientSize.Width - button1.Width;
            int y = this.ClientSize.Height - button1.Height;
            Random r = new Random();
            button1.Location = new Point(r.Next(0, x + 1), r.Next(0, y + 1));
            times++;
            if (times == 1)
                MessageBox.Show("保大！", "(>▽<)");
            else if (times == 2)
                MessageBox.Show("房产证写你名！", "(>▽<)");
            else if (times == 3)
                MessageBox.Show("工资全给你！", "(>▽<)");
            else if (times == 4)
                MessageBox.Show("只爱你一个！", "(>▽<)");
            else if (times == 5)
            { MessageBox.Show("我妈不去河边", "(>▽<)"); times = 0; }
        }

        private void Form1_FormClosing(object sender, FormClosingEventArgs e)
        {
            MessageBox.Show("不回答不能退出哦！", "(╯_╰)╭");
            e.Cancel = true;
        }

        private void button2_Click(object sender, EventArgs e)
        {
            MessageBox.Show("恭喜你拥有一名超级无敌可爱的男朋友~~", "^v^");
            this.Dispose();
            button1.SendToBack();

        }

        private void groupBox1_Enter(object sender, EventArgs e)
        {

        }

        private void Form1_Load(object sender, EventArgs e)
        {
            pictureBox1.SendToBack();
            //label1.SendToBack();
            //button1.SendToBack();
            //groupBox1.SendToBack();
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {
            label1.SendToBack();
        }
    }
}
