using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace 子窗体打开子窗体
{
    public partial class Form2 : Form
    {
        public Form2()
        {
            InitializeComponent();
        }
        Form form1;
        //public Form2(Form1 form01)
        //{
        //    form1 = form01;
        //    InitializeComponent();
        //}

        private void button1_Click(object sender, EventArgs e)
        {
            Form3 f3 = new Form3();
            f3.MdiParent = this.MdiParent;
            f3.Show();
        }
    }
}
