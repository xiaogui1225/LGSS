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

namespace data
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
       
        public void DataBind()
        {
            string sdor = txtdor.Text;
            string sno = txtsno.Text;
            string sname = txtname.Text;
            string shmp =this.txthmp.Text;
            string sserver =this.txtsserver.Text;
            //查询条件
            string sqlStr = "select * from dormitory where 1=1";//返回trun
            sqlStr += sdor == "" ? "" : "and sdor='" + sdor+"'" ;
            sqlStr += sno==""?"":"and sno like '%"+sno+"%'";//??
            sqlStr += sname== "" ? "" : "and sname=" + sname ;
            sqlStr += shmp == "" ? "" : "and showmp=" + shmp;
            sqlStr += sserver == "" ? "" : "and sserver=" +sserver;
            SQLhelper help = new SQLhelper();
            DataSet ds = help.GetData(sqlStr);//调用sqlhelp对象的getdata方法获取查询数据
            //若数据集对象的第一个表中存在数据，则绑定datagridview控件
            if (ds!=null&&ds.Tables[0].Rows.Count>0)
            {
                this.dataGridView1.DataSource = ds.Tables[0];
            }
            else
            {
                this.dataGridView1.DataSource = null;
            }
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            // TODO: 这行代码将数据加载到表“ssglDataSet1.dormitory”中。您可以根据需要移动或删除它。
            DataBind();//绑定
        }

        private void button1_Click(object sender, EventArgs e)
        {
            try
            {
                string Sdor = txtdor.Text;
                string Sno = txtsno.Text;
                string Sname = txtname.Text;
                string Shmp = txthmp.Text;
                string Sserver = txtsserver.Text;
                string sqlStr = "insert into dormitory(sdor,sno,sname,showmp,sserverpa)values(@ Sd,@Sn,@Sna,@Sh,@Sse)";

                //sql参数
                SqlParameter[] param =
                {
              new SqlParameter ("@Sd",Sdor),
              new SqlParameter ("@Sn",Sno),
              new SqlParameter ("@Sna",Sname),
              new SqlParameter ("@Sh",Shmp),
              new SqlParameter ("@Sse",Sserver)
                 };
                SQLhelper help = new SQLhelper();
                //调用sqlhelp对象excute方法执行更新操作
                //必须声明标量变量 "@"。
                MessageBox.Show("Test");
                if (help.Excute(sqlStr, param) > 0)
                {
                    DataBind();//调用数据绑定方法
                    MessageBox.Show("添加成功");
                }
                else
                {
                    MessageBox.Show("添加失败");
                    //MessageBox.Show("添加失败","错误",MessageBoxButtons.OKCancel,MessageBoxIcon.Error);
                }

            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message.ToString());
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            string Sdor = txtdor.Text;
            string Sno = txtsno.Text;
            string Sname = txtname.Text;
            string Shmp = txthmp.Text;
            string Sserver = txtsserver.Text;
            //@sno,@sname,@sdor,@shmp,@sserver
            string sqlStr = "update dormitorys set sName=@Sna,Sdor=@Sd,Shmp=@Sh.Sserver=@Sse"+"where sNo=@Sn";
            //sql语句有带有@的是调通Excute(sqlStr,param)
            //sql语句没有带的是调通Excute(sqlStr)

            SqlParameter[] param =
            {
                new SqlParameter("@Sd",Sdor),
                new SqlParameter("@Sn",Sno),
                new SqlParameter("@Sna",Sname),
                new SqlParameter("@Sh",Shmp),
                new SqlParameter("@Sse",Sserver)
            };
            SQLhelper help = new SQLhelper();
            //调用sqlhelp对象的excute方法执行更新操作
            if (help.Excute(sqlStr,param)>0)
            {
                MessageBox.Show("修改成功");
                DataBind();
            }
            else
            {
                MessageBox.Show("修改失败");
            }
        }

        private void button3_Click(object sender, EventArgs e)
        {
            string Sno = txtsno.Text;
            string sqlStr = "Delete from dormitorys where sno='" + Sno + "'";
            SQLhelper help = new SQLhelper();
            if (help.Excute(sqlStr)>0)
            //help.Excute(sqlStr ,param)没有调用param 是应为上一句没有带@所有不用param
            {
                MessageBox.Show("删除成功");
                DataBind();//绑定方法
            }
            else
            {
                MessageBox.Show("删除失败12");
            }
        }

        private void button4_Click(object sender, EventArgs e)
        {
            DataBind();//查询
        }

        private void button5_Click(object sender, EventArgs e)
        {
            //清空
            txtsno.Text = "";
            txtname.Text = "";
            txtdor.Text = "";
            txthmp.Text = "";
            txtsserver.Text = "";
        }

        private void dataGridView1_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            int rowIndex = e.RowIndex;//获取当前的索引值
            txtsno.Text = this.dataGridView1.Rows[rowIndex].Cells[1].Value.ToString();
            txtname.Text = this.dataGridView1.Rows[rowIndex].Cells[2].Value.ToString();
            txtdor.Text = this.dataGridView1.Rows[rowIndex].Cells[0].Value.ToString();
            txthmp.Text = this.dataGridView1.Rows[rowIndex].Cells[3].Value.ToString();
            txtsserver.Text = this.dataGridView1.Rows[rowIndex].Cells[4].Value.ToString();
        }
    }
}
