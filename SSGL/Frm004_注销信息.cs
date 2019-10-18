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
    //思路  先验证账号密码正不正确，正确就继续下一步注销，如果不正确就就提示账号或密码错误
    public partial class Frm004_注销信息 : Form
    {
        public Frm004_注销信息()
        {
            InitializeComponent();
        }
        public Frm004_注销信息(string str)
        {
            InitializeComponent();
            txtNo.Text = str;
            txtPwsd.UseSystemPasswordChar = true;
            MessageBox.Show("只允许毕业时进行注销，否则后果自负", "重要通知");

        }

        private void btn1_Click(object sender, EventArgs e)
        {
            if (s.Checked == true)
            {
                try
                {

                    if (txtNo.Text == "" | txtPwsd.Text == "")
                    {
                        MessageBox.Show("请检查账号或密码");
                    }
                    else
                    {
                        string sqlstr = SQLstr.sqlstr;
                        SqlConnection myCon = new SqlConnection(sqlstr);
                        myCon.Open();
                        string sql = "select *from message where sNo='" + txtNo.Text.Trim() + "'";
                        SqlCommand myCom = new SqlCommand(sql, myCon);
                        SqlDataReader dr = myCom.ExecuteReader();
                        if (dr.HasRows)
                        {
                            dr.Read();
                            if (txtPwsd.Text.Trim() == dr["sPwsd"].ToString().Trim())
                            {
                                string delete = "delete message where sno='" + txtNo.Text.Trim() + "'";
                                SqlCommand comdelete = new SqlCommand(delete, myCon);
                                dr.Close();//及时开启/及时关闭
                                comdelete.ExecuteNonQuery();
                                myCon.Close();
                                MessageBox.Show("注销成功");
                                this.Close();
                            }
                            else
                            {
                                MessageBox.Show("请检查密码");
                                myCon.Close();
                            }

                        }

                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message.ToString());
                }
                finally
                {

                }
            }
            if (a.Checked == true)
            {
                try
                {

                    if (txtNo.Text == "" | txtPwsd.Text == "")
                    {
                        MessageBox.Show("请检查账号或密码");
                    }
                    else
                    {
                        string sqlstr = SQLstr.sqlstr;
                        SqlConnection myCon = new SqlConnection(sqlstr);
                        myCon.Open();
                        string sql = "select *from aunt where aNo='" + txtNo.Text.Trim() + "'";
                        SqlCommand myCom = new SqlCommand(sql, myCon);
                        SqlDataReader dr = myCom.ExecuteReader();
                        if (dr.HasRows)
                        {
                            dr.Read();
                            if (txtPwsd.Text.Trim() == dr["aPwsd"].ToString().Trim())
                            {
                                string delete = "delete aunt where ano='" + txtNo.Text.Trim() + "'";
                                SqlCommand comdelete = new SqlCommand(delete, myCon);
                                dr.Close();//及时开启/及时关闭
                                comdelete.ExecuteNonQuery();
                                myCon.Close();
                                MessageBox.Show("注销成功");
                                this.Close();
                            }
                            else
                            {
                                MessageBox.Show("请检查密码");
                                myCon.Close();
                            }

                        }

                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message.ToString());
                }
                finally
                {

                }
            }
            if (key.Checked == true)
            {
                try
                {

                    if (txtNo.Text == "" | txtPwsd.Text == "")
                    {
                        MessageBox.Show("请检查账号或密码");
                    }
                    else
                    {
                        string sqlstr = SQLstr.sqlstr;
                        SqlConnection myCon = new SqlConnection(sqlstr);
                        myCon.Open();
                        string sql = "select *from supeuser where sNo='" + txtNo.Text.Trim() + "'";
                        SqlCommand myCom = new SqlCommand(sql, myCon);
                        SqlDataReader dr = myCom.ExecuteReader();
                        if (dr.HasRows)
                        {
                            dr.Read();
                            if (txtPwsd.Text.Trim() == dr["sPwsd"].ToString().Trim())
                            {
                                string delete = "delete supeuser where sno='" + txtNo.Text.Trim() + "'";
                                SqlCommand comdelete = new SqlCommand(delete, myCon);
                                dr.Close();//及时开启/及时关闭
                                comdelete.ExecuteNonQuery();
                                myCon.Close();
                                MessageBox.Show("注销成功");
                                this.Close();
                            }
                            else
                            {
                                MessageBox.Show("请检查密码");
                                myCon.Close();
                            }

                        }

                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message.ToString());
                }
                finally
                {

                }
            }
        }
        

        private void radioButton2_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void s_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void key_CheckedChanged(object sender, EventArgs e)
        {

        }
    }
}

