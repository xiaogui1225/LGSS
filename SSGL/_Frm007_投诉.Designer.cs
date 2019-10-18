namespace SSGL
{
    partial class _Frm007_投诉
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
            this.button1 = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.lbSno = new System.Windows.Forms.Label();
            this.txtSno = new System.Windows.Forms.TextBox();
            this.lbsname = new System.Windows.Forms.Label();
            this.txtName = new System.Windows.Forms.TextBox();
            this.lbPhone = new System.Windows.Forms.Label();
            this.txtPhone = new System.Windows.Forms.TextBox();
            this.lbDor = new System.Windows.Forms.Label();
            this.txtDor = new System.Windows.Forms.TextBox();
            this.lbhave = new System.Windows.Forms.Label();
            this.txthave = new System.Windows.Forms.TextBox();
            this.lbtype = new System.Windows.Forms.Label();
            this.大声道 = new System.Windows.Forms.TextBox();
            this.lbbook = new System.Windows.Forms.Label();
            this.txtbook = new System.Windows.Forms.TextBox();
            this.txttype = new System.Windows.Forms.ComboBox();
            this.SuspendLayout();
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(125, 299);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(83, 25);
            this.button1.TabIndex = 0;
            this.button1.Text = "提交";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(125, 270);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(83, 23);
            this.button2.TabIndex = 1;
            this.button2.Text = "一键获取";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // lbSno
            // 
            this.lbSno.AutoSize = true;
            this.lbSno.Location = new System.Drawing.Point(36, 38);
            this.lbSno.Name = "lbSno";
            this.lbSno.Size = new System.Drawing.Size(35, 12);
            this.lbSno.TabIndex = 2;
            this.lbSno.Text = "学号:";
            this.lbSno.Click += new System.EventHandler(this.label1_Click);
            // 
            // txtSno
            // 
            this.txtSno.Enabled = false;
            this.txtSno.Location = new System.Drawing.Point(125, 34);
            this.txtSno.Name = "txtSno";
            this.txtSno.Size = new System.Drawing.Size(100, 21);
            this.txtSno.TabIndex = 3;
            // 
            // lbsname
            // 
            this.lbsname.AutoSize = true;
            this.lbsname.Location = new System.Drawing.Point(36, 65);
            this.lbsname.Name = "lbsname";
            this.lbsname.Size = new System.Drawing.Size(35, 12);
            this.lbsname.TabIndex = 2;
            this.lbsname.Text = "姓名:";
            // 
            // txtName
            // 
            this.txtName.Location = new System.Drawing.Point(125, 62);
            this.txtName.Name = "txtName";
            this.txtName.Size = new System.Drawing.Size(100, 21);
            this.txtName.TabIndex = 3;
            // 
            // lbPhone
            // 
            this.lbPhone.AutoSize = true;
            this.lbPhone.Location = new System.Drawing.Point(36, 92);
            this.lbPhone.Name = "lbPhone";
            this.lbPhone.Size = new System.Drawing.Size(59, 12);
            this.lbPhone.TabIndex = 2;
            this.lbPhone.Text = "手机号码:";
            // 
            // txtPhone
            // 
            this.txtPhone.Location = new System.Drawing.Point(125, 89);
            this.txtPhone.Name = "txtPhone";
            this.txtPhone.Size = new System.Drawing.Size(100, 21);
            this.txtPhone.TabIndex = 3;
            // 
            // lbDor
            // 
            this.lbDor.AutoSize = true;
            this.lbDor.Location = new System.Drawing.Point(36, 119);
            this.lbDor.Name = "lbDor";
            this.lbDor.Size = new System.Drawing.Size(47, 12);
            this.lbDor.TabIndex = 2;
            this.lbDor.Text = "宿舍号:";
            this.lbDor.Click += new System.EventHandler(this.label4_Click);
            // 
            // txtDor
            // 
            this.txtDor.Location = new System.Drawing.Point(125, 116);
            this.txtDor.Name = "txtDor";
            this.txtDor.Size = new System.Drawing.Size(100, 21);
            this.txtDor.TabIndex = 3;
            // 
            // lbhave
            // 
            this.lbhave.AutoSize = true;
            this.lbhave.Location = new System.Drawing.Point(36, 146);
            this.lbhave.Name = "lbhave";
            this.lbhave.Size = new System.Drawing.Size(83, 12);
            this.lbhave.TabIndex = 2;
            this.lbhave.Text = "要投诉的宿舍:";
            this.lbhave.Click += new System.EventHandler(this.label4_Click);
            // 
            // txthave
            // 
            this.txthave.Location = new System.Drawing.Point(125, 143);
            this.txthave.Name = "txthave";
            this.txthave.Size = new System.Drawing.Size(100, 21);
            this.txthave.TabIndex = 3;
            // 
            // lbtype
            // 
            this.lbtype.AutoSize = true;
            this.lbtype.Location = new System.Drawing.Point(36, 173);
            this.lbtype.Name = "lbtype";
            this.lbtype.Size = new System.Drawing.Size(35, 12);
            this.lbtype.TabIndex = 2;
            this.lbtype.Text = "类型:";
            this.lbtype.Click += new System.EventHandler(this.label4_Click);
            // 
            // 大声道
            // 
            this.大声道.Location = new System.Drawing.Point(401, 187);
            this.大声道.Multiline = true;
            this.大声道.Name = "大声道";
            this.大声道.Size = new System.Drawing.Size(100, 21);
            this.大声道.TabIndex = 3;
            // 
            // lbbook
            // 
            this.lbbook.AutoSize = true;
            this.lbbook.Location = new System.Drawing.Point(36, 200);
            this.lbbook.Name = "lbbook";
            this.lbbook.Size = new System.Drawing.Size(59, 12);
            this.lbbook.TabIndex = 2;
            this.lbbook.Text = "投诉内容:";
            this.lbbook.Click += new System.EventHandler(this.label4_Click);
            // 
            // txtbook
            // 
            this.txtbook.Location = new System.Drawing.Point(125, 197);
            this.txtbook.Multiline = true;
            this.txtbook.Name = "txtbook";
            this.txtbook.Size = new System.Drawing.Size(136, 67);
            this.txtbook.TabIndex = 3;
            // 
            // txttype
            // 
            this.txttype.FormattingEnabled = true;
            this.txttype.Items.AddRange(new object[] {
            "对方宿舍行为影响到我的休息",
            "对方宿舍有不文明现象",
            "自己的宿舍太吵了，影响到我"});
            this.txttype.Location = new System.Drawing.Point(125, 170);
            this.txttype.Name = "txttype";
            this.txttype.Size = new System.Drawing.Size(121, 20);
            this.txttype.TabIndex = 4;
            // 
            // Frm07_投诉
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(270, 462);
            this.Controls.Add(this.txttype);
            this.Controls.Add(this.txtbook);
            this.Controls.Add(this.lbbook);
            this.Controls.Add(this.大声道);
            this.Controls.Add(this.lbtype);
            this.Controls.Add(this.txthave);
            this.Controls.Add(this.lbhave);
            this.Controls.Add(this.txtDor);
            this.Controls.Add(this.lbDor);
            this.Controls.Add(this.txtPhone);
            this.Controls.Add(this.lbPhone);
            this.Controls.Add(this.txtName);
            this.Controls.Add(this.lbsname);
            this.Controls.Add(this.txtSno);
            this.Controls.Add(this.lbSno);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.button1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.Name = "Frm07_投诉";
            this.Text = "Frm07_投诉";
            this.Load += new System.EventHandler(this.Frm07_投诉_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Label lbSno;
        private System.Windows.Forms.TextBox txtSno;
        private System.Windows.Forms.Label lbsname;
        private System.Windows.Forms.TextBox txtName;
        private System.Windows.Forms.Label lbPhone;
        private System.Windows.Forms.TextBox txtPhone;
        private System.Windows.Forms.Label lbDor;
        private System.Windows.Forms.TextBox txtDor;
        private System.Windows.Forms.Label lbhave;
        private System.Windows.Forms.TextBox txthave;
        private System.Windows.Forms.Label lbtype;
        private System.Windows.Forms.TextBox 大声道;
        private System.Windows.Forms.Label lbbook;
        private System.Windows.Forms.TextBox txtbook;
        private System.Windows.Forms.ComboBox txttype;
    }
}