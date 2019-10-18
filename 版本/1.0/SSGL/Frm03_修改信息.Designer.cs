namespace SSGL
{
    partial class Frm03_修改信息
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
            this.radKey = new System.Windows.Forms.RadioButton();
            this.radaunt03 = new System.Windows.Forms.RadioButton();
            this.radStu03 = new System.Windows.Forms.RadioButton();
            this.txtrePwsd = new System.Windows.Forms.TextBox();
            this.lbPhone = new System.Windows.Forms.Label();
            this.txtPwsd = new System.Windows.Forms.TextBox();
            this.lbrePwsd = new System.Windows.Forms.Label();
            this.txtNO = new System.Windows.Forms.TextBox();
            this.lbNo = new System.Windows.Forms.Label();
            this.button1 = new System.Windows.Forms.Button();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.BackColor = System.Drawing.Color.Transparent;
            this.groupBox1.Controls.Add(this.radKey);
            this.groupBox1.Controls.Add(this.radaunt03);
            this.groupBox1.Controls.Add(this.radStu03);
            this.groupBox1.Controls.Add(this.txtrePwsd);
            this.groupBox1.Controls.Add(this.lbPhone);
            this.groupBox1.Controls.Add(this.txtPwsd);
            this.groupBox1.Controls.Add(this.lbrePwsd);
            this.groupBox1.Controls.Add(this.txtNO);
            this.groupBox1.Controls.Add(this.lbNo);
            this.groupBox1.Controls.Add(this.button1);
            this.groupBox1.Location = new System.Drawing.Point(-5, 2);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(269, 181);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "修改密码";
            this.groupBox1.Enter += new System.EventHandler(this.groupBox1_Enter);
            // 
            // radKey
            // 
            this.radKey.AutoSize = true;
            this.radKey.Location = new System.Drawing.Point(288, 69);
            this.radKey.Name = "radKey";
            this.radKey.Size = new System.Drawing.Size(41, 16);
            this.radKey.TabIndex = 3;
            this.radKey.TabStop = true;
            this.radKey.Text = "key";
            this.radKey.UseVisualStyleBackColor = true;
            this.radKey.Visible = false;
            this.radKey.CheckedChanged += new System.EventHandler(this.radSuper_CheckedChanged);
            // 
            // radaunt03
            // 
            this.radaunt03.AutoSize = true;
            this.radaunt03.Location = new System.Drawing.Point(288, 47);
            this.radaunt03.Name = "radaunt03";
            this.radaunt03.Size = new System.Drawing.Size(77, 16);
            this.radaunt03.TabIndex = 3;
            this.radaunt03.TabStop = true;
            this.radaunt03.Text = "radaunt03";
            this.radaunt03.UseVisualStyleBackColor = true;
            this.radaunt03.Visible = false;
            // 
            // radStu03
            // 
            this.radStu03.AutoSize = true;
            this.radStu03.Location = new System.Drawing.Point(288, 25);
            this.radStu03.Name = "radStu03";
            this.radStu03.Size = new System.Drawing.Size(59, 16);
            this.radStu03.TabIndex = 3;
            this.radStu03.TabStop = true;
            this.radStu03.Text = "radStu";
            this.radStu03.UseVisualStyleBackColor = true;
            this.radStu03.Visible = false;
            this.radStu03.CheckedChanged += new System.EventHandler(this.radioButton1_CheckedChanged);
            // 
            // txtrePwsd
            // 
            this.txtrePwsd.Location = new System.Drawing.Point(146, 98);
            this.txtrePwsd.Name = "txtrePwsd";
            this.txtrePwsd.Size = new System.Drawing.Size(100, 21);
            this.txtrePwsd.TabIndex = 2;
            // 
            // lbPhone
            // 
            this.lbPhone.AutoSize = true;
            this.lbPhone.Location = new System.Drawing.Point(53, 101);
            this.lbPhone.Name = "lbPhone";
            this.lbPhone.Size = new System.Drawing.Size(59, 12);
            this.lbPhone.TabIndex = 1;
            this.lbPhone.Text = "确认密码:";
            this.lbPhone.Click += new System.EventHandler(this.lbPhone_Click);
            // 
            // txtPwsd
            // 
            this.txtPwsd.Location = new System.Drawing.Point(146, 59);
            this.txtPwsd.Name = "txtPwsd";
            this.txtPwsd.Size = new System.Drawing.Size(100, 21);
            this.txtPwsd.TabIndex = 2;
            this.txtPwsd.TextChanged += new System.EventHandler(this.txtrePwsd_TextChanged);
            // 
            // lbrePwsd
            // 
            this.lbrePwsd.AutoSize = true;
            this.lbrePwsd.Location = new System.Drawing.Point(53, 62);
            this.lbrePwsd.Name = "lbrePwsd";
            this.lbrePwsd.Size = new System.Drawing.Size(59, 12);
            this.lbrePwsd.TabIndex = 1;
            this.lbrePwsd.Text = "密    码:";
            this.lbrePwsd.Click += new System.EventHandler(this.lbrePwsd_Click);
            // 
            // txtNO
            // 
            this.txtNO.Location = new System.Drawing.Point(146, 20);
            this.txtNO.Name = "txtNO";
            this.txtNO.ReadOnly = true;
            this.txtNO.Size = new System.Drawing.Size(100, 21);
            this.txtNO.TabIndex = 2;
            this.txtNO.TextChanged += new System.EventHandler(this.txtNo_TextChanged);
            // 
            // lbNo
            // 
            this.lbNo.AutoSize = true;
            this.lbNo.Location = new System.Drawing.Point(53, 23);
            this.lbNo.Name = "lbNo";
            this.lbNo.Size = new System.Drawing.Size(59, 12);
            this.lbNo.TabIndex = 1;
            this.lbNo.Text = "账    号:";
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(146, 136);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(75, 23);
            this.button1.TabIndex = 0;
            this.button1.Text = "修改";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // Frm03_修改信息
            // 
            this.AcceptButton = this.button1;
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(258, 178);
            this.Controls.Add(this.groupBox1);
            this.Name = "Frm03_修改信息";
            this.Text = "Frm03_修改密码";
            this.Load += new System.EventHandler(this.Frm03_修改信息_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.TextBox txtrePwsd;
        private System.Windows.Forms.Label lbPhone;
        private System.Windows.Forms.TextBox txtPwsd;
        private System.Windows.Forms.Label lbrePwsd;
        private System.Windows.Forms.Label lbNo;
        private System.Windows.Forms.Button button1;
        public System.Windows.Forms.TextBox txtNO;
        public System.Windows.Forms.RadioButton radKey;
        public System.Windows.Forms.RadioButton radaunt03;
        public System.Windows.Forms.RadioButton radStu03;
    }
}