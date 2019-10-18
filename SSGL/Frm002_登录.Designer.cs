namespace SSGL
{
    partial class Frm002_登录
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.chkb1 = new System.Windows.Forms.CheckBox();
            this.grb1 = new System.Windows.Forms.GroupBox();
            this.radKeyuan = new System.Windows.Forms.RadioButton();
            this.radAunt = new System.Windows.Forms.RadioButton();
            this.radStudent = new System.Windows.Forms.RadioButton();
            this.btn1 = new System.Windows.Forms.Button();
            this.txtPwsd = new System.Windows.Forms.TextBox();
            this.lbPwsd = new System.Windows.Forms.Label();
            this.txtNo = new System.Windows.Forms.TextBox();
            this.lbID = new System.Windows.Forms.Label();
            this.groupBox1.SuspendLayout();
            this.grb1.SuspendLayout();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.chkb1);
            this.groupBox1.Controls.Add(this.grb1);
            this.groupBox1.Controls.Add(this.btn1);
            this.groupBox1.Controls.Add(this.txtPwsd);
            this.groupBox1.Controls.Add(this.lbPwsd);
            this.groupBox1.Controls.Add(this.txtNo);
            this.groupBox1.Controls.Add(this.lbID);
            this.groupBox1.Location = new System.Drawing.Point(57, 58);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(398, 217);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "登录";
            // 
            // chkb1
            // 
            this.chkb1.AutoSize = true;
            this.chkb1.Location = new System.Drawing.Point(284, 160);
            this.chkb1.Name = "chkb1";
            this.chkb1.Size = new System.Drawing.Size(72, 16);
            this.chkb1.TabIndex = 5;
            this.chkb1.Text = "记住密码";
            this.chkb1.UseVisualStyleBackColor = true;
            this.chkb1.CheckedChanged += new System.EventHandler(this.checkBox1_CheckedChanged);
            // 
            // grb1
            // 
            this.grb1.Controls.Add(this.radKeyuan);
            this.grb1.Controls.Add(this.radAunt);
            this.grb1.Controls.Add(this.radStudent);
            this.grb1.Location = new System.Drawing.Point(24, 15);
            this.grb1.Name = "grb1";
            this.grb1.Size = new System.Drawing.Size(144, 149);
            this.grb1.TabIndex = 4;
            this.grb1.TabStop = false;
            this.grb1.Text = "选择模式";
            // 
            // radKeyuan
            // 
            this.radKeyuan.AutoSize = true;
            this.radKeyuan.Location = new System.Drawing.Point(33, 96);
            this.radKeyuan.Name = "radKeyuan";
            this.radKeyuan.Size = new System.Drawing.Size(77, 16);
            this.radKeyuan.TabIndex = 0;
            this.radKeyuan.TabStop = true;
            this.radKeyuan.Text = "科员模式:";
            this.radKeyuan.UseVisualStyleBackColor = true;
            this.radKeyuan.CheckedChanged += new System.EventHandler(this.radKeyuan_CheckedChanged);
            // 
            // radAunt
            // 
            this.radAunt.AutoSize = true;
            this.radAunt.Location = new System.Drawing.Point(33, 70);
            this.radAunt.Name = "radAunt";
            this.radAunt.Size = new System.Drawing.Size(77, 16);
            this.radAunt.TabIndex = 0;
            this.radAunt.TabStop = true;
            this.radAunt.Text = "阿姨模式:";
            this.radAunt.UseVisualStyleBackColor = true;
            this.radAunt.CheckedChanged += new System.EventHandler(this.radAuto_CheckedChanged);
            // 
            // radStudent
            // 
            this.radStudent.AutoSize = true;
            this.radStudent.Location = new System.Drawing.Point(33, 45);
            this.radStudent.Name = "radStudent";
            this.radStudent.Size = new System.Drawing.Size(77, 16);
            this.radStudent.TabIndex = 0;
            this.radStudent.TabStop = true;
            this.radStudent.Text = "学生模式:";
            this.radStudent.UseVisualStyleBackColor = true;
            this.radStudent.CheckedChanged += new System.EventHandler(this.radStudent_CheckedChanged);
            // 
            // btn1
            // 
            this.btn1.Location = new System.Drawing.Point(284, 189);
            this.btn1.Name = "btn1";
            this.btn1.Size = new System.Drawing.Size(75, 23);
            this.btn1.TabIndex = 2;
            this.btn1.Text = "登录";
            this.btn1.UseVisualStyleBackColor = true;
            this.btn1.Click += new System.EventHandler(this.btn1_Click);
            // 
            // txtPwsd
            // 
            this.txtPwsd.Location = new System.Drawing.Point(284, 118);
            this.txtPwsd.Name = "txtPwsd";
            this.txtPwsd.Size = new System.Drawing.Size(100, 21);
            this.txtPwsd.TabIndex = 1;
            this.txtPwsd.TextChanged += new System.EventHandler(this.txtPwsd_TextChanged);
            // 
            // lbPwsd
            // 
            this.lbPwsd.AutoSize = true;
            this.lbPwsd.Location = new System.Drawing.Point(215, 121);
            this.lbPwsd.Name = "lbPwsd";
            this.lbPwsd.Size = new System.Drawing.Size(35, 12);
            this.lbPwsd.TabIndex = 0;
            this.lbPwsd.Text = "密码:";
            // 
            // txtNo
            // 
            this.txtNo.Location = new System.Drawing.Point(284, 71);
            this.txtNo.Name = "txtNo";
            this.txtNo.Size = new System.Drawing.Size(100, 21);
            this.txtNo.TabIndex = 1;
            // 
            // lbID
            // 
            this.lbID.AutoSize = true;
            this.lbID.Location = new System.Drawing.Point(215, 74);
            this.lbID.Name = "lbID";
            this.lbID.Size = new System.Drawing.Size(35, 12);
            this.lbID.TabIndex = 0;
            this.lbID.Text = "账号:";
            // 
            // Frm002_登录
            // 
            this.AcceptButton = this.btn1;
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(506, 321);
            this.Controls.Add(this.groupBox1);
            this.Name = "Frm002_登录";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Frm02_登录";
            this.Load += new System.EventHandler(this.Frm02_登录_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.grb1.ResumeLayout(false);
            this.grb1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Button btn1;
        private System.Windows.Forms.TextBox txtPwsd;
        private System.Windows.Forms.Label lbPwsd;
        private System.Windows.Forms.Label lbID;
        private System.Windows.Forms.GroupBox grb1;
        private System.Windows.Forms.CheckBox chkb1;
        public System.Windows.Forms.TextBox txtNo;
        public System.Windows.Forms.RadioButton radKeyuan;
        public System.Windows.Forms.RadioButton radAunt;
        public System.Windows.Forms.RadioButton radStudent;
    }
}