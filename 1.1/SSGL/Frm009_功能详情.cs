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
    public partial class Frm009_功能详情 : Form
    {
        public Frm009_功能详情()
        {
            InitializeComponent();
        }
        public Frm009_功能详情(string str)
        {
            InitializeComponent();
            textBox1.Text = str;
            label2.Text = "学号_____:";
            label3.Text = "姓名_____:";
            label4.Text = "宿舍号___:";
            label5.Text = "电费_____:";//ef
            label6.Text = "水费_____:";//we
            label7.Text = "已交电费_:";
            label8.Text = "已交水费_:";
            comboBox2.Visible = false;


        }

        private void Frm09_功能详情_Load(object sender, EventArgs e)
        {

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (comboBox1.Text == "")
            {
                MessageBox.Show("请选择功能");
            }
            else
            {
                if (comboBox1.Text == "查缴水电")
                {
                    button2.Enabled = true;
                    label2.Text = "学号______:";
                    label3.Text = "姓名______:";
                    label4.Text = "宿舍号____:";
                    label5.Text = "电费______:";//ef
                    label6.Text = "水费______:";//we
                    label7.Text = "已交电费__:";
                    label8.Text = "已交水费__:";
                    label8.Visible = true;
                    comboBox2.Visible = false;
                    textBox7.Text = "";
                    textBox7.Visible = true;
                    textBox5.Visible = true;
                    textBox5.Height = 21;
                    textBox5.Width = 121;
                    textBox6.Height = 21;
                    textBox6.Width = 121;
                    textBox6.Text = "";
                    textBox7.Height = 21;
                    //string str = "server=.;user=sa;pwd=1;database=ssgl";
                    string strSql = SqlStr.constr;
                    // 访问数据库
                    string sql = "select *from dormitory where sno='" + textBox1.Text.Trim() + "'";
                    //执行sql查询语句
                    SqlConnection con = new SqlConnection(strSql);
                    //创建连接数据库
                    con.Open();
                    SqlCommand com = new SqlCommand(sql, con);
                    //创建操作对象
                    SqlDataReader dr = com.ExecuteReader();
                    //读取
                    //读取数据填充到txtbox控件中
                    if (dr.HasRows)
                    {
                        dr.Read();//打开阅读之后要对应的关闭阅读

                        textBox1.Text = textBox1.Text.Trim();
                        textBox3.Text = dr["sDor"].ToString();
                        textBox2.Text = dr["sname"].ToString();
                        textBox4.Text = dr["sEf"].ToString();
                        textBox5.Text = dr["sWatera"].ToString();
                        con.Close();
                        dr.Close();
                    }
                }
                if (comboBox1.Text == "报修")
                {
                    button2.Enabled = true;
                    label2.Text = "学号______:";
                    label3.Text = "姓名______:";
                    label4.Text = "宿舍号____:";
                    label5.Text = "手机号码__:";
                    label6.Text = "报修类型__:";
                    label7.Text = "报修详情__:";
                    label8.Visible = false;
                    comboBox2.Visible = true;
                    comboBox2.Text = "";
                    comboBox2.Items.Clear();
                    comboBox2.Items.AddRange(new object[] { "门", "窗", "床", "桌", "柜子", "热水器", "风扇", "电线短路", "水管", "网线" });

                    textBox5.Visible = false;
                    textBox7.Visible = false;
                    textBox5.Height = 121;
                    textBox5.Width = 74;
                    //textBox5.MaxLength = 60;
                    textBox6.Height = 74;
                    textBox6.Width = 121;
                    textBox6.MaxLength = 60;
                    textBox6.Text = "";
                    string str = "server=.;user=sa;pwd=1;database=ssgl";
                    string sql = "select *from message where sno='" + textBox1.Text + "'";
                    SqlConnection con = new SqlConnection(str);
                    con.Open();
                    SqlCommand com = new SqlCommand(sql, con);
                    SqlDataReader dr = com.ExecuteReader();
                    if (dr.HasRows)
                    {
                        dr.Read();
                        textBox2.Text = dr["sname"].ToString().Trim();
                        textBox3.Text = dr["sdor"].ToString().Trim();
                        textBox4.Text = dr["sphone"].ToString().Trim();
                        dr.Close();
                    }
                    con.Close();
                }

                if (comboBox1.Text == "投诉")
                {
                    label2.Location = new Point(20, 89);
                    label3.Location = new Point(20, 116);
                    label4.Location = new Point(20, 143);
                    label5.Location = new Point(20, 170);
                    label6.Location = new Point(20, 197);
                    label7.Location = new Point(20, 224);
                    label8.Location = new Point(20, 251);

                    label2.Text = "学号______:";
                    label3.Text = "姓名______:";
                    label4.Text = "手机号码__:";
                    label5.Text = "宿舍号____:";
                    label6.Text = "类型______:";
                    label7.Text = "对方的宿舍:";
                    label8.Visible = false;
                    //comboBox2.Items.AddRange(new object[] { "12","54548","ad"});
                    comboBox2.Text = "";
                    comboBox2.Items.Clear();
                    comboBox2.Items.AddRange(new object[] { "影响到我的休息", "有不文明现象", "宿舍太吵" }/* "对方宿舍行为影响到我的休息","对方宿舍有不文明现象","自己的宿舍太吵了，影响到我"*/);
                    textBox6.Visible = true;
                    comboBox2.Visible = true;
                    textBox6.Text = "";
                    textBox6.Width = 121;
                    textBox6.Height = 74;
                    textBox6.MaxLength = 60;
                    textBox7.Visible = false;
                    button2.Enabled = true;
                    //14,89
                    //label8.Text = "投诉内容:";


                    string str = "server=.;user=sa;pwd=1;database=ssgl";
                    string sql = "select *from message where sno='" + textBox1.Text + "'";
                    SqlConnection con = new SqlConnection(str);
                    con.Open();
                    SqlCommand com = new SqlCommand(sql, con);
                    SqlDataReader dr = com.ExecuteReader();
                    if (dr.HasRows)
                    {
                        dr.Read();
                        textBox2.Text = dr["sname"].ToString().Trim();
                        textBox3.Text = dr["sphone"].ToString().Trim();
                        textBox4.Text = dr["sdor"].ToString().Trim();
                        dr.Close();
                    }
                    con.Close();
                }
                if (comboBox1.Text== "申请换宿舍")
                {
                    label2.Text = "学号:"; 
                    label3.Text = "姓名:";
                    label4.Text = "宿舍:";
                    label5.Text = "系部:";
                    label6.Text = "班级:"; comboBox2.Visible = false; textBox5.Visible = true; textBox5.Height = 20;textBox5.Width = 121;
                    label7.Text = "申请理由:"; textBox6.Height = 74; textBox6.Width = 121; textBox6.Text = "";
                    label8.Visible = false;  textBox7.Visible = false;

                    string str = "server=.;user=sa;pwd=1;database=ssgl";
                    string sql = "select *from message where sno='" + textBox1.Text + "'";
                    SqlConnection con = new SqlConnection(str);
                    con.Open();
                    SqlCommand com = new SqlCommand(sql, con);
                    SqlDataReader dr = com.ExecuteReader();
                    if (dr.HasRows)
                    {
                        dr.Read();
                        textBox2.Text = dr["sname"].ToString().Trim();
                        textBox3.Text = dr["sdor"].ToString().Trim();
                        textBox4.Text = dr["sClass"].ToString().Trim();
                        textBox5.Text = dr["sSystem"].ToString().Trim();
                        dr.Close();
                    }
                    con.Close();
                }
            }
        }
        private void button1_Click(object sender, EventArgs e)
        {
            //            查缴水电
            //报修
            //投诉
            //申请换宿舍
            //if (comboBox1.Text == "")
            //{
            //    MessageBox.Show("请选择功能");
            //}
            //else
            //{
            //    if (comboBox1.Text == "查缴水电")
            //    {
            //        button2.Enabled = true;
            //        label2.Text = "学号_____:";
            //        label3.Text = "姓名_____:";
            //        label4.Text = "宿舍号___:";
            //        label5.Text = "电费_____:";//ef
            //        label6.Text = "水费_____:";//we
            //        label7.Text = "已交电费_:";
            //        label8.Text = "已交水费_:";
            //        label8.Visible = true;
            //        comboBox2.Visible = false;
            //        textBox7.Text = "";
            //        textBox7.Visible = true;
            //        textBox5.Visible = true;
            //        textBox5.Height = 21;
            //        textBox5.Width = 121;
            //        textBox6.Height = 21;
            //        textBox6.Width = 121;
            //        textBox6.Text = "";
            //        string str = "server=.;user=sa;pwd=1;database=ssgl";
            //        // 访问数据库
            //        string sql = "select *from dormitory where sno='" + textBox1.Text.Trim() + "'";
            //        //执行sql查询语句
            //        SqlConnection con = new SqlConnection(str);
            //        //创建连接数据库
            //        con.Open();
            //        SqlCommand com = new SqlCommand(sql, con);
            //        //创建操作对象
            //        SqlDataReader dr = com.ExecuteReader();
            //        //读取
            //        //读取数据填充到txtbox控件中
            //        if (dr.HasRows)
            //        {
            //            dr.Read();//打开阅读之后要对应的关闭阅读

            //            textBox1.Text = textBox1.Text.Trim();
            //            textBox3.Text = dr["sDor"].ToString();
            //            textBox2.Text = dr["sname"].ToString();
            //            textBox4.Text = dr["sEf"].ToString();
            //            textBox5.Text = dr["sWatera"].ToString();
            //            con.Close();
            //            dr.Close();
            //        }
            //    }
            //    if (comboBox1.Text == "报修")
            //    {
            //        button2.Enabled = true;
            //        label2.Text = "学号____:";
            //        label3.Text = "姓名____:";
            //        label4.Text = "宿舍号__:";
            //        label5.Text = "手机号码:";
            //        label6.Text = "报修类型:";
            //        label7.Text = "报修详情:";
            //        label8.Visible = false;
            //        comboBox2.Visible = true;
            //        comboBox2.Text = "";
            //        comboBox2.Items.Clear();
            //        comboBox2.Items.AddRange(new object[] { "门" , "窗", "床", "桌", "柜子", "热水器", "风扇", "电线短路", "水管", "网线" });

            //        textBox5.Visible = false;
            //        textBox7.Visible = false;
            //        textBox5.Height = 121;
            //        textBox5.Width = 74;
            //        //textBox5.MaxLength = 60;
            //        textBox6.Height = 74;
            //        textBox6.Width = 121;
            //        textBox6.MaxLength = 60;
            //        textBox6.Text = "";
            //        string str = "server=.;user=sa;pwd=1;database=ssgl";
            //        string sql = "select *from message where sno='" + textBox1.Text + "'";
            //        SqlConnection con = new SqlConnection(str);
            //        con.Open();
            //        SqlCommand com = new SqlCommand(sql, con);
            //        SqlDataReader dr = com.ExecuteReader();
            //        if (dr.HasRows)
            //        {
            //            dr.Read();
            //            textBox2.Text = dr["sname"].ToString().Trim();
            //            textBox3.Text = dr["sdor"].ToString().Trim();
            //            textBox4.Text = dr["sphone"].ToString().Trim();
            //            dr.Close();
            //        }
            //        con.Close();
            //    }

            //    if (comboBox1.Text == "投诉")
            //    {
            //        label2.Location = new Point(20,89);
            //        label3.Location = new Point(20,116);
            //        label4.Location = new Point(20, 143);
            //        label5.Location = new Point(20, 170);
            //        label6.Location = new Point(20, 197);
            //        label7.Location = new Point(20, 224);
            //        label8.Location = new Point(20, 251);

            //        label2.Text = "学号______:";
            //        label3.Text = "姓名______:";
            //        label4.Text = "手机号码__:";
            //        label5.Text = "宿舍号____:";
            //        label6.Text = "类型______:";
            //        label7.Text = "对方的宿舍:";
            //        //comboBox2.Items.AddRange(new object[] { "12","54548","ad"});
            //        comboBox2.Text = "";
            //        comboBox2.Items.Clear();
            //        comboBox2.Items.AddRange (new object[] { "影响到我的休息", "有不文明现象", "宿舍太吵" }/* "对方宿舍行为影响到我的休息","对方宿舍有不文明现象","自己的宿舍太吵了，影响到我"*/);
            //        textBox6.Visible = true;
            //        comboBox2.Visible = true;
            //        textBox6.Text = "";
            //        textBox7.Width = 121;
            //        textBox7.Height = 74;
            //        textBox7.MaxLength = 60;
            //        //14,89
            //        //label8.Text = "投诉内容:";


            //        string str = "server=.;user=sa;pwd=1;database=ssgl";
            //        string sql = "select *from message where sno='" + textBox1.Text + "'";
            //        SqlConnection con = new SqlConnection(str);
            //        con.Open();
            //        SqlCommand com = new SqlCommand(sql, con);
            //        SqlDataReader dr = com.ExecuteReader();
            //        if (dr.HasRows)
            //        {
            //            dr.Read();
            //            textBox2.Text = dr["sname"].ToString().Trim();
            //            textBox3.Text = dr["sphone"].ToString().Trim();
            //            textBox4.Text = dr["sdor"].ToString().Trim();
            //            dr.Close();
            //        }
            //        con.Close();
            //    }
            //}
        }

        private void button2_Click(object sender, EventArgs e)
        {
            if (comboBox1.Text == "查缴水电")
            {
                if (textBox6.Text != textBox4.Text | textBox7.Text != textBox5.Text)
                {
                    MessageBox.Show("请缴相对应的金额");
                }
                else
                {
                    string str = "server=.;user=sa;pwd=1;database=ssgl";
                    SqlConnection con = new SqlConnection(str);

                    con.Open();
                    string sqlup = "update dormitory set soverwe='" + textBox4.Text.Trim() + "', soveref='" + textBox5.Text.Trim() + "'where sno='" + textBox1.Text.Trim() + "'";
                    SqlCommand com01 = new SqlCommand(sqlup, con);
                    if (com01.ExecuteNonQuery() > 0)
                    {
                        MessageBox.Show("已缴清");
                    }
                    else
                    {
                        MessageBox.Show("请缴相对应的金额");
                    }
                    con.Close();
                }
            }
            if (comboBox1.Text == "报修")
            {
                if (textBox6.Text == "" | comboBox2.Text == "")
                {
                    MessageBox.Show("请完善信息");
                }
                else
                {
                    string str = "server=.;user=sa;pwd=1;database=ssgl";
                    string sql = "insert into Repair values('" + textBox1.Text + "','" + textBox2.Text.Trim() + "','" + textBox4.Text.Trim() + "','" + textBox3.Text.Trim() + "','" + comboBox2.Text.Trim() + "','" + textBox6.Text.Trim() + "')";
                    SqlConnection con = new SqlConnection(str);
                    con.Open();
                    SqlCommand com = new SqlCommand(sql, con);
                    if (com.ExecuteNonQuery() > 0)
                    {
                        MessageBox.Show("提交成功");
                    }
                    else
                    {
                        MessageBox.Show("Test");
                    }
                }
            }
            if (comboBox1.Text == "投诉")
            {
                if ( textBox6.Text == "" | textBox5.Text == "")
                {
                    MessageBox.Show("请完善信息");
                }
                else
                {
                    string str = "server=.;user=sa;pwd=1;database=ssgl";
                    string sql = "insert into  Complaint values('" + textBox1.Text + "','" + textBox2.Text.Trim() + "','" + textBox3.Text.Trim() + "','" + textBox4.Text.Trim() + "','" + textBox5.Text.Trim() + "','" + textBox6.Text.Trim() + "','" + textBox7.Text.Trim() + "')";
                    SqlConnection con = new SqlConnection(str);
                    con.Open();
                    SqlCommand com = new SqlCommand(sql, con);
                    if (com.ExecuteNonQuery() > 0)
                    {
                        MessageBox.Show("提交成功");
                    }
                    else
                    {
                        MessageBox.Show("Test");
                    }
                }
            }
            if (comboBox1.Text=="申请换宿舍")
            {
                if (textBox6.Text != "")
                {
                    string str = "server=.;user=sa;pwd=1;database=ssgl";
                    string sql = "insert into  changeDor values('" + textBox1.Text + "','" + textBox2.Text.Trim() + "','" + textBox3.Text.Trim() + "','" + textBox4.Text.Trim() + "','" + textBox5.Text.Trim() + "','" + textBox6.Text.Trim() + "')";
                    SqlConnection con = new SqlConnection(str);
                    con.Open();
                    SqlCommand com = new SqlCommand(sql, con);
                    if (com.ExecuteNonQuery() > 0)
                    {
                        MessageBox.Show("提交成功");
                    }
                }
                else
                {
                    MessageBox.Show("请完善信息");
                }
            }
        }
    }
}

