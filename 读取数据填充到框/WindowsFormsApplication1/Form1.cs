using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.Data.SqlClient;

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
            string strSql = "server=.;database=master;trusted_connection=true";
            string sql = "select * from Table_1 where ID='" + textBox1.Text.Trim() + "'";
            SqlConnection con = new SqlConnection(strSql);
            con.Open();
            SqlCommand com = new SqlCommand(sql,con);
            SqlDataReader dr = com.ExecuteReader();
            if (dr.HasRows)
            {
                dr.Read();
                textBox2.Text = dr["price"].ToString();
                dr.Close();
            }
          
            con.Close();
        }
    }
}
