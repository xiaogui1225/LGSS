using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace WindowsFormsApplication1
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (radioButton1.Checked==true)
            {
                Form2 f2 = new Form2();
                f2.Owner = this;
                f2.radioButton1.Checked = true;
                f2.Show();
            }
            if (radioButton2.Checked == true)
            {
                Form2 f2 = new Form2();
                f2.Owner = this;
                f2.radioButton2.Checked = true;
                f2.Show();
            }
        }
    }
}
