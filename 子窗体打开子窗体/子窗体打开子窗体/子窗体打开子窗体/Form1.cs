﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace 子窗体打开子窗体
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Form2 f2 = new Form2();
            f2.MdiParent = this;
            f2.Show();
            button1.Visible = false;
        }
    }
}
//Form1 frm1 = new Form1();
//frm1.MdiParent = this;
//frm1.Show();

//-------------------------------------------
//Form2 frm2 = new Form2();
//frm2.MdiParent = this.MdiParent;
//frm2.Show();