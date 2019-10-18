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
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            Form3 f3 = new Form3(textBox1.Text);
            Form3 f31 = new Form3(rad1.Checked);
            Form3 f311 = new Form3( rad2.Checked);
            f31.Owner = this;
            f311.Owner = this;
            f3.Show();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void rad2_CheckedChanged(object sender, EventArgs e)
        {

        }
    }
}
