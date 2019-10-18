using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace data001
{
    public partial class Form001 : Form
    {
        public Form001()
        {
            InitializeComponent();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {

        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void Form1_Load(object sender, EventArgs e)
        {
            // TODO: 这行代码将数据加载到表“sSGLDataSet1.dormitory”中。您可以根据需要移动或删除它。
            this.dormitoryTableAdapter.Fill(this.sSGLDataSet1.dormitory);
            // TODO: 这行代码将数据加载到表“ssglDataSet.dormitory”中。您可以根据需要移动或删除它。

        }
    }
}
