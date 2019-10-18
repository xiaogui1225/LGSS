namespace SSGL
{
    partial class Frm010_通知
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
            this.lbDor = new System.Windows.Forms.Label();
            this.txtDor = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.txtbook = new System.Windows.Forms.TextBox();
            this.comboxBook = new System.Windows.Forms.ComboBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(81, 90);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(169, 20);
            this.button1.TabIndex = 0;
            this.button1.Text = "发送";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // lbDor
            // 
            this.lbDor.AutoSize = true;
            this.lbDor.Location = new System.Drawing.Point(4, 63);
            this.lbDor.Name = "lbDor";
            this.lbDor.Size = new System.Drawing.Size(71, 12);
            this.lbDor.TabIndex = 1;
            this.lbDor.Text = "宿舍号____:";
            this.lbDor.Click += new System.EventHandler(this.label1_Click);
            // 
            // txtDor
            // 
            this.txtDor.Location = new System.Drawing.Point(81, 60);
            this.txtDor.Name = "txtDor";
            this.txtDor.Size = new System.Drawing.Size(169, 21);
            this.txtDor.TabIndex = 2;
            this.txtDor.TextChanged += new System.EventHandler(this.txtDor_TextChanged);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(4, 124);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(71, 12);
            this.label1.TabIndex = 1;
            this.label1.Text = "发送内容__:";
            this.label1.Click += new System.EventHandler(this.label1_Click);
            // 
            // txtbook
            // 
            this.txtbook.Location = new System.Drawing.Point(81, 121);
            this.txtbook.Multiline = true;
            this.txtbook.Name = "txtbook";
            this.txtbook.Size = new System.Drawing.Size(169, 103);
            this.txtbook.TabIndex = 2;
            this.txtbook.TextChanged += new System.EventHandler(this.txtbook_TextChanged);
            // 
            // comboxBook
            // 
            this.comboxBook.FormattingEnabled = true;
            this.comboxBook.Items.AddRange(new object[] {
            "单发",
            "群发"});
            this.comboxBook.Location = new System.Drawing.Point(81, 33);
            this.comboxBook.Name = "comboxBook";
            this.comboxBook.Size = new System.Drawing.Size(169, 20);
            this.comboxBook.TabIndex = 3;
            this.comboxBook.SelectedIndexChanged += new System.EventHandler(this.comboBox1_SelectedIndexChanged);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(4, 36);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(71, 12);
            this.label2.TabIndex = 1;
            this.label2.Text = "发送模式__:";
            this.label2.Click += new System.EventHandler(this.label1_Click);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(4, 94);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(71, 12);
            this.label3.TabIndex = 1;
            this.label3.Text = "发送______:";
            this.label3.Click += new System.EventHandler(this.label1_Click);
            // 
            // Frm010_通知
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(254, 229);
            this.Controls.Add(this.comboxBook);
            this.Controls.Add(this.txtbook);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.txtDor);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.lbDor);
            this.Controls.Add(this.button1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.Fixed3D;
            this.HelpButton = true;
            this.MaximizeBox = false;
            this.Name = "Frm010_通知";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Frm010_通知";
            this.Load += new System.EventHandler(this.Frm010_通知_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Label lbDor;
        private System.Windows.Forms.TextBox txtDor;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtbook;
        private System.Windows.Forms.ComboBox comboxBook;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
    }
}