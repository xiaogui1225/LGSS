using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.Data.SqlClient;
namespace SSGL
{
    public partial class Frm011_查看资料 : Form
    {
        public Frm011_查看资料()
        {
            InitializeComponent();
        }
        //增删查改 更新  方便数据管理 
        //查 查询各com列 com条件  跳到gri控件
        //增加 导入exe文件 ？？？未知
        //修改 要修改的选项 combobox  要修改的内容txt
        //删除 学号
        private void Frm011查看资料_Load(object sender, EventArgs e)
        {
            // TODO: 这行代码将数据加载到表“ssglDataSet.dormitory”中。您可以根据需要移动或删除它。
            this.dormitoryTableAdapter.Fill(this.ssglDataSet.dormitory);
            Dispaly();
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex<0)
            {
                MessageBox.Show("请点击你需要的行");
            }
            else
            {
                int rowIndex = e.RowIndex;//获取当前行数
                txtSno.Text = this.dataGridView1.Rows[rowIndex].Cells[0].Value.ToString();
                txtSname.Text = this.dataGridView1.Rows[rowIndex].Cells[1].Value.ToString();
                txtSdor.Text = this.dataGridView1.Rows[rowIndex].Cells[2].Value.ToString();
                txtShowmp.Text = this.dataGridView1.Rows[rowIndex].Cells[3].Value.ToString();
                txtSser.Text = this.dataGridView1.Rows[rowIndex].Cells[4].Value.ToString();
            }
        }
        DataSet ds = new DataSet();
        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void but5_Click(object sender, EventArgs e)
        {
            txtSdor.Text = "";
            txtShowmp.Text = "";
            txtSno.Text = "";
            txtSser.Text = "";
            txtSname.Text = "";
        }
        public void Dispaly()
        {
            string sqlstr = SQLstr.sqlstr;
            string sqlsele = "select * from dormitory";
            SqlConnection con = new SqlConnection(sqlstr);
            SqlDataAdapter dapt = new SqlDataAdapter(sqlsele,con);//定义一个dapt
            dapt.Fill(ds,"dormitory");//填充数据集
            dataGridView1.DataSource = ds.Tables["dormitory"];//填充数据进控件
        }
        public DataSet Getdata(string sele)
        {
            string sqlstr = SQLstr.sqlstr;
            DataSet ds = new DataSet();
            SqlConnection con = new SqlConnection(sqlstr);
            SqlCommand cmd = new SqlCommand(sele, con);
            SqlDataAdapter dapt = new SqlDataAdapter(cmd);
            dapt.Fill(ds);
            return ds;
        }
        private void but1_Click(object sender, EventArgs e)
        {
            try
            {
                if (txtSdor.Text == "" | txtShowmp.Text == "" | txtSname.Text == "" | txtSno.Text == "" | txtSser.Text == "")
                    MessageBox.Show("请添加信息，错误2");
                else
                {
                    DataTable dor = ds.Tables["dormitory"];
                    string sqlstr = SQLstr.sqlstr;
                    string ins = "insert dormitory(sdor,sno,sname,showmp,sserverpa)values('" + txtSdor.Text.Trim() + "','" + txtSno.Text.Trim() + "','" + txtSname.Text.Trim() + "','" + txtShowmp.Text.Trim() + "','" + txtSser.Text.Trim() + "')";
                    SqlConnection con = new SqlConnection(sqlstr);
                    SqlCommand cmd = new SqlCommand(ins, con);
                    con.Open();
                    if (cmd.ExecuteNonQuery() > 0)
                        MessageBox.Show("添加成功");
                    else
                        MessageBox.Show("添加失败");
                    con.Close();
                    ds.Tables["dormitory"].Clear();
                    Dispaly();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message.ToString());
            }
           
        }

        private void but2_Click(object sender, EventArgs e)
        {
            if (txtShowmp.Text.Trim() == "" | txtSname.Text.Trim() == "" | txtSdor.Text.Trim() == "" | txtSser.Text.Trim() == "" | txtSno.Text.Trim() == "")
                MessageBox.Show("请输入要修改的数值，错误2");
            else
            {
                DataTable dor = ds.Tables["dormitory"];
                string sqlstr = SQLstr.sqlstr;
                string upa = "update  dormitory set sname='" + txtSname.Text.Trim() + "', showmp='" + txtShowmp.Text.Trim() + "',sserverpa='" + txtSser.Text.Trim() + "',sdor='" + txtSdor.Text.Trim() + "'where sno='"+txtSno.Text.Trim()+"'";
                SqlConnection con = new SqlConnection(sqlstr);
                SqlCommand cmd = new SqlCommand(upa, con);
                con.Open();
                if (cmd.ExecuteNonQuery() > 0)
                    MessageBox.Show("修改成功");
                else
                    MessageBox.Show("修改失败");
                ds.Tables["dormitory"].Clear();
                Dispaly();
                con.Close();
            }
        }

        private void but3_Click(object sender, EventArgs e)
        {
            if (txtSno.Text == "" & txtSname.Text == "" & txtSdor.Text == "")
            {
                DataTable dor = ds.Tables["dormitory"];
                MessageBox.Show("请输入查找的学号或姓名，宿舍号的信息，错误1");
                ds.Tables["dormitory"].Clear();
                Dispaly();
            }
            else
            {
                string sqlstr = SQLstr.sqlstr;
                string select = "select * from dormitory where 1=1 ";
                select += txtSno.Text.Trim() == "" ? "" : "and sno like '%" + txtSno.Text.Trim() + "%'";
                select += txtSname.Text.Trim() == "" ? "" : "and sname like '%" + txtSname.Text.Trim() + "%'";
                select += txtSdor.Text.Trim() == "" ? "" : "and sdor like '%" + txtSdor.Text.Trim() + "%'";
                SqlConnection con = new SqlConnection(sqlstr);
                SqlCommand cmd = new SqlCommand(select, con);
                DataSet ds = Getdata(select);
                if (ds != null && ds.Tables[0].Rows.Count > 0)
                { this.dataGridView1.DataSource = ds.Tables[0]; }
                else
                { this.dataGridView1.DataSource = null; }
                con.Open();
                con.Close();
            }
        }
        private void but4_Click(object sender, EventArgs e)
        {
            if (txtSno.Text.Trim()=="")
                MessageBox.Show("请输入要删除的学号");
            DataTable dor = ds.Tables["dormitory"];
            string sqlstr = SQLstr.sqlstr;
            string dele = "delete  from dormitory where sno='" + txtSno.Text.Trim() + "'";
            SqlConnection con = new SqlConnection(sqlstr);
            con.Open();
            SqlCommand cmd = new SqlCommand(dele,con);
            if (cmd.ExecuteNonQuery()>0)
                MessageBox.Show("删除成功");
            else
                MessageBox.Show("删除失败");
            con.Close();
            ds.Tables["dormitory"].Clear();
            Dispaly();
        }
    }
}
