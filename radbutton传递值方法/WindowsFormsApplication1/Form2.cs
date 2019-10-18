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
    public partial class Form2 : Form
    {
        public Form2()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (radioButton1.Checked == true)
            {
                Form3 f3 = new Form3();
                f3.Owner = this;//获取
                f3.radioButton1.Checked = true;
                f3.Show();
            }
            if (radioButton2.Checked == true)
            {
                Form3 f3 = new Form3();
                f3.Owner = this;//获取
                f3.radioButton2.Checked = true;
                f3.Show();
            }




        }

        private void radioButton1_CheckedChanged(object sender, EventArgs e)
        {
        }
    }
}
