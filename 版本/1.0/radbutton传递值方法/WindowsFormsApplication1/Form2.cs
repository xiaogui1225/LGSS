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
            if (radioButton1.Checked=true)
            {
                Form3 frm = new Form3();
                frm.Owner = this;
                frm.radioButton1.Checked = true;
                frm.Show();
            }
            if (radioButton2.Checked = true)
            {
                Form3 frm = new Form3();
                frm.Owner = this;
                frm.radioButton2.Checked = true;
                frm.Show();
            }

        }

        private void radioButton1_CheckedChanged(object sender, EventArgs e)
        {
        }
    }
}
