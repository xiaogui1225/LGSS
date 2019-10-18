using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.Data.SqlClient;//一定要添加这样代码

namespace SSGL
{
    public partial class Frm02_登录 : Form
    {
        private void checkBox1_CheckedChanged(object sender, EventArgs e)
        {
            
        }
        public Frm02_登录(object text)
        {
            InitializeComponent();
            //txtPwsd.UseSystemPasswordChar = true;//大圆点
            //uptxtNo储存账号  uptxtPwsd储存密码
            //txtNo.Text = uptxtNo;
            //txtPwsd.Text = uptxtPwsd;
            
           
        }

        public Frm02_登录()
        {
            InitializeComponent();
            txtPwsd.UseSystemPasswordChar = true;//大圆点
        }

        private void groupBox1_Enter(object sender, EventArgs e)
        {

        }

        private void checkBox3_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void radStudent_CheckedChanged(object sender, EventArgs e)
        {
            grb1.Text = radStudent.Text;
        }

        private void btn1_Click(object sender, EventArgs e)
        {
            if ((txtNo.Text!=""&txtPwsd.Text!="")&radAunt.Checked!=true&radKeyuan.Checked!=true&radStudent.Checked!=true)
            {
                MessageBox.Show("嘿（^_^）模式别忘啦");
            }
            //访问数据库
            string strSql = "server=.;user=sa;pwd=1;database=SSGL;";
            SqlConnection myCon = new SqlConnection(strSql);
            string userNo = txtNo.Text.Trim();
            string userPwsd = txtPwsd.Text.Trim();
            //三种模式---学生模式
            /*思路----------连接数据库学生/阿姨/科员信息表------验证账号密码*/
            if (radStudent.Checked == true)
            {
                try
                {
                    bool result = false;
                    myCon.Open();
                    
                    //执行sql语句
                    string sql = "select * from message  where sNo='" + txtNo.Text.Trim() + "'";
                    SqlCommand myCom = new SqlCommand(sql, myCon);//(先写sql，再写myCon)
                    SqlDataReader dr = myCom.ExecuteReader();
                    //Frm01_主界面 f1 = new Frm01_主界面(txtNo.Text);
                    //f1.Show();
                    if (dr.HasRows)
                    {
                        dr.Read();
                        if (txtPwsd.Text.Trim() == dr["sPwsd"].ToString().Trim())
                        {
                            result = true;
                            MessageBox.Show("登录成功");
                            Frm01_主界面 myFrm01 = new Frm01_主界面(txtNo.Text);
                            myFrm01.Owner = this;
                            myFrm01.Toolsmt2.Enabled = true;
                            myFrm01.ToolS登录.Visible = false;
                            myFrm01.Toolmodi修改.Enabled = true;
                            myFrm01.Tool切换用户.Enabled = true;
                            myFrm01.Tool注销.Enabled = true;
                            myFrm01.radStudent01.Checked = true;
                            myFrm01.Show();
                            this.Hide();
                           
                        }
                        else
                        {
                            result = false;
                            MessageBox.Show("请检查账号或密码");
                        }
                    }
                    else
                    {
                        result = false;
                        MessageBox.Show("请检查账号或密码是否存在");
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

            //阿姨模式
            /*思路----------连接数据库学生/阿姨/科员信息表------验证账号密码*/
            if (radAunt.Checked == true)
             {
                try
                {
                    myCon.Open();
                    //执行sql
                    string sql = "select * from aunt  where aNo='" + txtNo.Text.Trim() + "'";
                    SqlCommand myCom = new SqlCommand(sql,myCon);
                    SqlDataReader dr = myCom.ExecuteReader();
                    if (dr.HasRows)
                    {
                        dr.Read();//读取动作
                        if (txtPwsd.Text.Trim()==dr["aPwsd"].ToString().Trim())
                        {
                            MessageBox.Show("登录成功");
                            Frm01_主界面 myFrm01 = new Frm01_主界面(txtNo.Text);
                            myFrm01.Owner = this;
                            myFrm01.Toolsmt2.Enabled = true;
                            myFrm01.ToolS登录.Visible = false;
                            myFrm01.Toolmodi修改.Enabled = true;
                            myFrm01.Tool切换用户.Enabled = true;
                            myFrm01.Tool注销.Enabled = true;
                            myFrm01.Toolsmt2.Enabled = true;
                            myFrm01.Toolsmt3.Enabled = true;
                            myFrm01.radAunt01.Checked = true;
                            myFrm01.Show();
                            this.Hide();
                        }
                        else
                        {
                            MessageBox.Show("请检查账号或密码。");
                        }
                    }
                    else
                    {
                        MessageBox.Show("请检查账号或密码是否存在。");
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
            //科员模式
            /*思路----------连接数据库学生/阿姨/科员信息表------验证账号密码*/
            if (radKeyuan.Checked == true)
            {
                try
                {
                    myCon.Open();
                    string sql = "select *from superuser where sNo='" + txtNo.Text.Trim() + "'";
                    SqlCommand myCom = new SqlCommand(sql,myCon);
                    SqlDataReader dr = myCom.ExecuteReader();
                    if (dr.HasRows)
                    {
                        dr.Read();
                        if (txtPwsd.Text.Trim()==dr["sPwsd"].ToString().Trim())
                        {
                            MessageBox.Show("登录成功");
                            Frm01_主界面 myFrm01 = new Frm01_主界面(txtNo.Text);
                            myFrm01.Owner = this;
                            myFrm01.Toolsmt2.Enabled = true;
                            myFrm01.ToolS登录.Visible = false;
                            myFrm01.Toolmodi修改.Enabled = true;
                            myFrm01.Tool切换用户.Enabled = true;
                            myFrm01.Tool注销.Enabled = true;
                            myFrm01.Toolsmt2.Enabled = true;
                            myFrm01.Toolsmt3.Enabled = true;
                            myFrm01.Toolsmt4.Enabled = true;
                            myFrm01.radKeyuan01.Checked = true;
                            myFrm01.Show();
                            this.Hide();
                        }
                        else
                        {
                            MessageBox.Show("请检查账号或密码。");
                        }
                    }
                    else
                    {
                        MessageBox.Show("请检查账号或密码是否存在。");
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

        private void radAuto_CheckedChanged(object sender, EventArgs e)
        {
            grb1.Text = radAunt.Text;
        }
        private void radKeyuan_CheckedChanged(object sender, EventArgs e)
        {
            grb1.Text = radKeyuan.Text;
        }

        private void Frm02_登录_Load(object sender, EventArgs e)
        {
            //Frm01_主界面 myFrm01 = new Frm01_主界面();
            //myFrm01.Owner = this;
        }
    
    public bool Frm02valueStu
    {
            get
            {
                //return this.radAunt.Checked;
                //return this.radKeyuan.Checked;
                return this.radStudent.Checked;
            }
        set { this.radStudent.Checked = value; }
    }

    public bool Frm02valueAunt
    {
        get
        {
                return this.radAunt.Checked;
                //return this.radKeyuan.Checked;
                //return this.radStudent.Checked;
            }
        set { this.radAunt.Checked = value; }
    }
    public bool Frm02valueKey
    {
        get
        {
                //return this.radAunt.Checked;
                return this.radKeyuan.Checked;
                //return this.radStudent.Checked;
            }
        set { this.radKeyuan.Checked = value; }
    }

    }
}
