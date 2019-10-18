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
    public partial class Form3 : Form
    {
        private RadioButton rad2;
        private RadioButton rad1;

        public Form3(bool @checked)
        {
            InitializeComponent();
            Form1 f1 = new Form1();
            f1.Owner = this;
            this.radioButton2.Checked =f1.rad2.Checked;
            this.radioButton1.Checked =f1.rad1.Checked;
            this.button1.Enabled =f1.button1.Enabled ;

        }
        public Form3(string str)
        {
            InitializeComponent();
            textBox3.Text = str;//这句必须放在InitializeComponent();的后面，否则会引起“空引用异常”
        }

        public Form3(RadioButton rad2)
        {
            this.rad2 = rad2;
        }

        public void Button1_Click(object sender, EventArgs e)
        {
            //Form2 f2 = new Form2(textBox3.Text);
            //f2.Show();
            MessageBox.Show("Te1st");
            button1.Text = "12";
            if (button1.Text=="12")
            {
                Form1 f1 = new Form1();
                f1.Hide();
            }
            else
            {
                MessageBox.Show("Test");
            }
        }

        private void Form3_Load(object sender, EventArgs e)
        {

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void radioButton1_CheckedChanged(object sender, EventArgs e)
        {

        }
    }
}
