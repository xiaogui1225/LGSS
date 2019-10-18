namespace SSGL
{
    partial class Frm004_注销信息
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
            this.btn1 = new System.Windows.Forms.Button();
            this.lbNo = new System.Windows.Forms.Label();
            this.txtNo = new System.Windows.Forms.TextBox();
            this.lbPwsd = new System.Windows.Forms.Label();
            this.txtPwsd = new System.Windows.Forms.TextBox();
            this.s = new System.Windows.Forms.RadioButton();
            this.a = new System.Windows.Forms.RadioButton();
            this.key = new System.Windows.Forms.RadioButton();
            this.SuspendLayout();
            // 
            // btn1
            // 
            this.btn1.Location = new System.Drawing.Point(122, 117);
            this.btn1.Name = "btn1";
            this.btn1.Size = new System.Drawing.Size(100, 23);
            this.btn1.TabIndex = 0;
            this.btn1.Text = "确定注销";
            this.btn1.UseVisualStyleBackColor = true;
            this.btn1.Click += new System.EventHandler(this.btn1_Click);
            // 
            // lbNo
            // 
            this.lbNo.AutoSize = true;
            this.lbNo.Location = new System.Drawing.Point(49, 42);
            this.lbNo.Name = "lbNo";
            this.lbNo.Size = new System.Drawing.Size(35, 12);
            this.lbNo.TabIndex = 1;
            this.lbNo.Text = "账号:";
            // 
            // txtNo
            // 
            this.txtNo.Enabled = false;
            this.txtNo.Location = new System.Drawing.Point(122, 39);
            this.txtNo.Name = "txtNo";
            this.txtNo.Size = new System.Drawing.Size(100, 21);
            this.txtNo.TabIndex = 2;
            // 
            // lbPwsd
            // 
            this.lbPwsd.AutoSize = true;
            this.lbPwsd.Location = new System.Drawing.Point(49, 80);
            this.lbPwsd.Name = "lbPwsd";
            this.lbPwsd.Size = new System.Drawing.Size(35, 12);
            this.lbPwsd.TabIndex = 1;
            this.lbPwsd.Text = "密码:";
            // 
            // txtPwsd
            // 
            this.txtPwsd.Location = new System.Drawing.Point(122, 77);
            this.txtPwsd.Name = "txtPwsd";
            this.txtPwsd.Size = new System.Drawing.Size(100, 21);
            this.txtPwsd.TabIndex = 2;
            // 
            // s
            // 
            this.s.AutoSize = true;
            this.s.Location = new System.Drawing.Point(268, 41);
            this.s.Name = "s";
            this.s.Size = new System.Drawing.Size(95, 16);
            this.s.TabIndex = 3;
            this.s.TabStop = true;
            this.s.Text = "radioButton1";
            this.s.UseVisualStyleBackColor = true;
            this.s.Visible = false;
            this.s.CheckedChanged += new System.EventHandler(this.s_CheckedChanged);
            // 
            // a
            // 
            this.a.AutoSize = true;
            this.a.Location = new System.Drawing.Point(268, 80);
            this.a.Name = "a";
            this.a.Size = new System.Drawing.Size(95, 16);
            this.a.TabIndex = 4;
            this.a.TabStop = true;
            this.a.Text = "radioButton2";
            this.a.UseVisualStyleBackColor = true;
            this.a.Visible = false;
            this.a.CheckedChanged += new System.EventHandler(this.radioButton2_CheckedChanged);
            // 
            // key
            // 
            this.key.AutoSize = true;
            this.key.Location = new System.Drawing.Point(272, 117);
            this.key.Name = "key";
            this.key.Size = new System.Drawing.Size(95, 16);
            this.key.TabIndex = 5;
            this.key.TabStop = true;
            this.key.Text = "radioButton3";
            this.key.UseVisualStyleBackColor = true;
            this.key.Visible = false;
            this.key.CheckedChanged += new System.EventHandler(this.key_CheckedChanged);
            // 
            // Frm04_注销信息
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(391, 145);
            this.Controls.Add(this.key);
            this.Controls.Add(this.a);
            this.Controls.Add(this.s);
            this.Controls.Add(this.txtPwsd);
            this.Controls.Add(this.lbPwsd);
            this.Controls.Add(this.txtNo);
            this.Controls.Add(this.lbNo);
            this.Controls.Add(this.btn1);
            this.Name = "Frm04_注销信息";
            this.Text = "Frm04_注销信息";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btn1;
        private System.Windows.Forms.Label lbNo;
        private System.Windows.Forms.TextBox txtNo;
        private System.Windows.Forms.Label lbPwsd;
        private System.Windows.Forms.TextBox txtPwsd;
        public System.Windows.Forms.RadioButton s;
        public System.Windows.Forms.RadioButton a;
        public System.Windows.Forms.RadioButton key;
    }
}