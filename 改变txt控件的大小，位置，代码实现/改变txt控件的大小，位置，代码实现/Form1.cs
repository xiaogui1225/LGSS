using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace 改变txt控件的大小_位置_代码实现
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            textBox1.Width = 320;
            textBox1.Height = 520;
            textBox1.Location =new Point( 150, 31);
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void textBox1_VisibleChanged(object sender, EventArgs e)
        {

        }
    }
}
