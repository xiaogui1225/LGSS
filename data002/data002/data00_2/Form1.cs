using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;

namespace data00_2
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            string Sname = txtName.Text;
            string Sdor = txtSdor.Text;
            string Showp = txtHowmp.Text;
            string Sser = txtSer.Text;
        }
        DataSet dataset = new DataSet();
        public void Display()
        {
            //dataSet.Tables["BuyDetialTemp"].Clear();
            string sql = "server=.;user=sa;pwd=1;database=ssgl";
            string sqlselect = "select * from dormitory ";
            SqlConnection con = new SqlConnection(sql);
            SqlDataAdapter dataAdapter = new SqlDataAdapter(sqlselect, con);   //定义一个dataAdapter
            dataAdapter.Fill(dataset, "dormitory");   //填充数据集
            dataGridView1.DataSource = dataset.Tables["dormitory"];  //填充数据进控件
        }

            //public static string sql = "server=.;user=sa;pwd=1;dabatase=ssgl";
            //public static SqlConnectioncon con= new SqlConnection(sql);
        private void button4_Click(object sender, EventArgs e)
        {
          
        }
        

        private void Form1_Load(object sender, EventArgs e)
        {
            // TODO: 这行代码将数据加载到表“dordadta.dormitory”中。您可以根据需要移动或删除它。
            this.dormitoryTableAdapter.Fill(this.dordadta.dormitory);
            Display();

        }
        private void button1_Click(object sender, EventArgs e)
        {
            if (txtSno.Text == "" | txtName.Text == "" | txtSdor.Text == "" | txtHowmp.Text == "" | txtSer.Text == "")
            {
                MessageBox.Show("请添加信息，错误2");
            }
            else
            {
                try
                {
                    DataTable dor = dataset.Tables["dormitory"];
                    string sqlStr = "server=.;user=sa;pwd=1;database=ssgl";
                    string ins = "insert  dormitory(sdor,sno,sname,showmp,sserverpa)values('" + txtSdor.Text.Trim() + "','" + txtSno.Text.Trim() + "','" + txtName.Text.Trim() + "','" + txtHowmp.Text.Trim() + "','" + txtSer.Text.Trim() + "')";
                    ////插入信息
                    SqlConnection con = new SqlConnection(sqlStr);
                    SqlCommand cmd = new SqlCommand(ins, con);
                    con.Open();
                    cmd.ExecuteNonQuery();
                    con.Close();
                    dataset.Tables["dormitory"].Clear();
                    Display();
                    MessageBox.Show("添加成功");
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message.ToString());
                }
            }
        }

        public DataSet Getdata(string sele) {
            string sqlStr = "server=.;user=sa;pwd=1;database=ssgl";
            DataSet ds = new DataSet();
            SqlConnection con = new SqlConnection(sqlStr);
            SqlCommand cmd = new SqlCommand(sele, con);
            SqlDataAdapter dapt = new SqlDataAdapter(cmd);
            dapt.Fill(ds);
            return ds;
        }
        private void button4_Click_1(object sender, EventArgs e)
        {
            //模糊查询
            if (txtSno.Text == "" & txtName.Text == "" & txtSdor.Text == "")
            {
                MessageBox.Show("请输入查找的学号或姓名，宿舍号的信息，错误1");
            }
            else
            {
                string sqlStr = "server=.;user=sa;pwd=1;database=ssgl";
                string sele = "select * from dormitory where 1=1";
                sele += txtSno.Text.Trim() == "" ? "" : "and sno like '%" + txtSno.Text.Trim() + "%'";
                sele += txtName.Text.Trim() == "" ? "" : "and sname like '%" + txtName.Text.Trim() + "%'";
                sele += txtSdor.Text.Trim() == "" ? "" : "and sdor like '%" + txtSdor.Text.Trim() + "%'";
                SqlConnection con = new SqlConnection(sqlStr);
                SqlCommand cmd = new SqlCommand(sele, con);
                DataSet ds = Getdata(sele);
                if (ds != null && ds.Tables[0].Rows.Count > 0)
                {
                    this.dataGridView1.DataSource = ds.Tables[0];
                }
                else
                {
                    this.dataGridView1.DataSource = null;
                }
                con.Open();
                con.Close();
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            if (txtHowmp.Text.Trim()==""| txtName.Text.Trim() == "" | txtSdor.Text.Trim() == "" | txtSer.Text.Trim() == "" | txtSno.Text.Trim() == "" )
            {
                MessageBox.Show("请输入要修改的数值，错误2");
            }
            else
            {
                DataTable dor = dataset.Tables["dormitory"];
                string sqlStr = "server=.;user=sa;pwd=1;database=ssgl";
                string update = "update  dormitory set sdor=' " + txtSdor.Text.Trim() + "',sname='" + txtName.Text.Trim() + "',showmp='" + txtHowmp.Text.Trim() + "',sserverpa='" + txtSer.Text.Trim() + "'where sno='" + txtSno.Text.Trim() + "'";
                ////插入信息
                SqlConnection con = new SqlConnection(sqlStr);
                SqlCommand cmd = new SqlCommand(update, con);
                con.Open();
                if (cmd.ExecuteNonQuery()>0)
                {
                    con.Close();
                    dataset.Tables["dormitory"].Clear();
                    Display();
                    MessageBox.Show("添加成功");
                }
                else
                {
                    MessageBox.Show("学号不可更改，错误3");
                }
               
            }
        }

        private void dataGridView1_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex<0)
            {
                MessageBox.Show("请点击您需要的行");
            }
            else
            {
                int rowIndex = e.RowIndex;//获取当前行的索引值
                txtSno.Text = this.dataGridView1.Rows[rowIndex].Cells[0].Value.ToString();
                txtName.Text = this.dataGridView1.Rows[rowIndex].Cells
                [1].Value.ToString();
                txtSdor.Text = this.dataGridView1.Rows[rowIndex].Cells
                [2].Value.ToString();
                txtHowmp.Text = this.dataGridView1.Rows[rowIndex].Cells
                [3].Value.ToString();
                txtSer.Text = this.dataGridView1.Rows[rowIndex].Cells
                [4].Value.ToString();
            }
        }
        private void button3_Click(object sender, EventArgs e)
        {
            if (txtHowmp.Text.Trim() == "" | txtName.Text.Trim() == "" | txtSdor.Text.Trim() == "" | txtSer.Text.Trim() == "" | txtSno.Text.Trim() == "")
            {
                MessageBox.Show("请输入要删除的数值，错误2");
            }
            else
            {
                string sqlStr = "server=.;user=sa;pwd=1;database=ssgl";
                string dele = "delete from dormitory where sno='" + txtSno.Text.Trim() + "'";
                SqlConnection con = new SqlConnection(sqlStr);
                SqlCommand cmd = new SqlCommand(dele, con);
                con.Open();
                if (cmd.ExecuteNonQuery()>0)
                {
                    MessageBox.Show("删除成功");
                    con.Close();
                    dataset.Tables["dormitory"].Clear();
                    Display();
                }
                else
                {
                    MessageBox.Show("学号不存在不可删除，错误3");
                }
            }
        }
        private void button5_Click(object sender, EventArgs e)
        {
            txtSno.Text = "";
            txtName.Text = "";
            txtSdor.Text = "";
            txtHowmp.Text = "";
            txtSer.Text = "";
        }
    }
}

    //public string sno /*Sdor, Sname, Showp, Sser*/;
     
