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
    public partial class Frm003_修改信息 : Form
    {
        public Frm003_修改信息()
        {
            InitializeComponent();
        }
        public  string str;
        public Frm003_修改信息(string str)
        {
            InitializeComponent();
            txtNO.Text = str;//这句必须放在InitializeComponent();的后面，否则会引起“空引用异常”
            txtPwsd.UseSystemPasswordChar = true;
            txtrePwsd.UseSystemPasswordChar = true;
        }
        private void groupBox1_Enter(object sender, EventArgs e)
        {

        }

        private void txtPwsd_TextChanged(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            //思路  ，，，数据库里面一共有三张用户的表，所以需要判断此账号是哪一个表的数据，这样才能相对应的注销账号，而不是表1的账号拿到表2去注销。
            //首先要先判断是哪一张表的数据，用frm02的rad控件进行判断，传递过来得到这是哪一那张表的数据。大概就这样
            if (radStu03.Checked == true)
            {
                if (txtPwsd.Text != txtrePwsd.Text&txtPwsd.Text==""&txtrePwsd.Text=="")
                {
                    MessageBox.Show("信息不对");
                }
                else
                {
                    string strSql = "server=.;user=sa;pwd=1;database=SSGL;";
                    SqlConnection myCon = new SqlConnection(strSql);
                    try
                    {
                        if (true)
                        {
                            myCon.Open();
                            //执行sql update语句
                            string sql = "update message set sPwsd ='" + txtPwsd.Text.Trim() + "'where sno='" + txtNO.Text.Trim() + "'";
                            SqlCommand myCom = new SqlCommand(sql, myCon);//创建对象
                            if (myCom.ExecuteNonQuery() > 0)
                            {
                                MessageBox.Show("修改成功,请重新登录");
                                this.Close();
                                Frm002_登录 f02 = new Frm002_登录();
                                f02.Show();
                            }
                            else
                            {
                                MessageBox.Show("修改失败2");

                            }
                        }
                    }
                    catch (Exception ex)
                    {
                        MessageBox.Show(ex.Message.ToString());
                    }
                    finally
                    {
                        myCon.Close();
                    }
                }
            }
            else
            {
                //MessageBox.Show("Test2");
                //kong  表示空，  承上启下
            }


            if (radaunt03.Checked == true)
            {
                if (true)
                {
                    if (txtPwsd.Text != txtrePwsd.Text)
                    {
                        MessageBox.Show("两次填写的密码不一致");
                    }
                    else
                    {
                        string strSql = "server=.;user=sa;pwd=1;database=SSGL;";
                        SqlConnection myCon = new SqlConnection(strSql);
                        try
                        {
                            if (true)
                            {
                                myCon.Open();
                                //执行sql update语句
                                string sql = "update aunt set aPwsd ='" + txtPwsd.Text.Trim() + "'where ano='" + txtNO.Text.Trim() + "'";
                                SqlCommand myCom = new SqlCommand(sql, myCon);//创建对象
                                if (myCom.ExecuteNonQuery() > 0)
                                {
                                    MessageBox.Show("修改成功,请重新登录");
                                    this.Close();
                                    Frm002_登录 f02 = new Frm002_登录();
                                    f02.Show();
                                }
                                else
                                {
                                    MessageBox.Show("修改失败1");

                                }

                            }
                        }
                        catch (Exception ex)
                        {
                            MessageBox.Show(ex.Message.ToString());
                        }
                        finally
                        {
                            myCon.Close();
                        }
                        //kong表示空，直接跳到下面代码

                    }
                }
            }
            if (radKey.Checked == true)
            {
                if (txtPwsd.Text != txtrePwsd.Text)
                {
                    MessageBox.Show("两次填写的密码不一致");
                }
                else
                {
                    string strSql = "server=.;user=sa;pwd=1;database=SSGL;";
                    SqlConnection myCon = new SqlConnection(strSql);
                    try
                    {
                        if (true)
                        {
                            myCon.Open();
                            //执行sql update语句
                            string sql = "update superuser set sPwsd ='" + txtPwsd.Text.Trim() + "'where sno='" + txtNO.Text.Trim() + "'";
                            SqlCommand myCom = new SqlCommand(sql, myCon);//创建对象
                            if (myCom.ExecuteNonQuery() > 0)
                            {
                                MessageBox.Show("修改成功,请重新登录");
                                this.Close();
                                Frm002_登录 f02 = new Frm002_登录();
                                f02.Show();
                            }
                            else
                            {
                                MessageBox.Show("修改失败");
                            }
                        }
                    }
                    catch (Exception ex)
                    {
                        MessageBox.Show(ex.Message.ToString());
                    }
                    finally
                    {
                        myCon.Close();
                    }
                }
            }

        }
        private void Frm03_修改信息_Load(object sender, EventArgs e)
        {
            
        }

        private void lbPhone_Click(object sender, EventArgs e)
        {

        }

        private void txtNo_TextChanged(object sender, EventArgs e)
        {

        }

        private void txtrePwsd_TextChanged(object sender, EventArgs e)
        {

        }

        private void lbrePwsd_Click(object sender, EventArgs e)
        {

        }

        private void radioButton1_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void radSuper_CheckedChanged(object sender, EventArgs e)
        {

        }
    }
}
