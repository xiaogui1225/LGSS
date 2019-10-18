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
            //Frm001_主界面 f1 = frm001;
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
                    string sqlstr = SQLstr.sqlstr;
                    SqlConnection myCon = new SqlConnection(sqlstr);
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
                                //Frm002_登录 f02 = new Frm002_登录();
                                //Frm001_主界面 f1 = new Frm001_主界面();
                                //可以先把主窗体传给子窗体，然后在子窗体里面当单击按钮时 this.再下一级窗体.MdiParent = 传过来的主窗体 这样就能达到效果
                                //f02.MdiParent = this.MdiParent;
                                //f02.Show();
                                //this.f02();//绑定
                                //button2 = true;
                                //this.button3.Click += new System.EventHandler(button2_Click);
                                this.button1.Click +=new System.EventHandler (button2_Click);
                                //this.button2.Click += new System.EventHandler(button2_Click);
//                                给你解释下~前面的this.button3.Click就是调用了button2的点击事件！
//明白了吧~这段代码就写在button3的点击事件里面就ok了！
//(button2_Click)就是要调用的点击事件方法！

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
                                    f02.MdiParent = this.MdiParent;
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
                                f02.MdiParent = this.MdiParent;
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

        private void button2_Click(object sender, EventArgs e)
        {
            Frm002_登录 f02 = new Frm002_登录();
            //Frm001_主界面 f1 = new Frm001_主界面();
            //可以先把主窗体传给子窗体，然后在子窗体里面当单击按钮时 this.再下一级窗体.MdiParent = 传过来的主窗体 这样就能达到效果
            f02.MdiParent = this.MdiParent;
            f02.Show();
        }
        public void f02()
        {
            Frm002_登录 f2 = new Frm002_登录();
            f2.MdiParent = this.MdiParent;
            f2.Show();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            this.button3.Click += new System.EventHandler(button2_Click);
        }
    }
}
