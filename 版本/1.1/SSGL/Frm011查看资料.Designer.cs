namespace SSGL
{
    partial class Frm011查看资料
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
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Frm011查看资料));
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.sNoDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.sNameDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.sDorDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.sHowmpDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.sServerpaDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dormitoryBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.ssglDataSet = new SSGL.ssglDataSet();
            this.dormitoryTableAdapter = new SSGL.ssglDataSetTableAdapters.dormitoryTableAdapter();
            this.but1 = new System.Windows.Forms.Button();
            this.txtSno = new System.Windows.Forms.TextBox();
            this.panel1 = new System.Windows.Forms.Panel();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.姓名 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.but5 = new System.Windows.Forms.Button();
            this.but4 = new System.Windows.Forms.Button();
            this.but3 = new System.Windows.Forms.Button();
            this.but2 = new System.Windows.Forms.Button();
            this.txtSser = new System.Windows.Forms.TextBox();
            this.txtShowmp = new System.Windows.Forms.TextBox();
            this.txtSdor = new System.Windows.Forms.TextBox();
            this.txtSname = new System.Windows.Forms.TextBox();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dormitoryBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.ssglDataSet)).BeginInit();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // dataGridView1
            // 
            this.dataGridView1.AllowUserToAddRows = false;
            this.dataGridView1.AllowUserToDeleteRows = false;
            this.dataGridView1.AutoGenerateColumns = false;
            this.dataGridView1.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.Raised;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.sNoDataGridViewTextBoxColumn,
            this.sNameDataGridViewTextBoxColumn,
            this.sDorDataGridViewTextBoxColumn,
            this.sHowmpDataGridViewTextBoxColumn,
            this.sServerpaDataGridViewTextBoxColumn});
            this.dataGridView1.DataSource = this.dormitoryBindingSource;
            this.dataGridView1.Location = new System.Drawing.Point(30, 202);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.ReadOnly = true;
            this.dataGridView1.RowTemplate.Height = 23;
            this.dataGridView1.Size = new System.Drawing.Size(721, 221);
            this.dataGridView1.TabIndex = 0;
            this.dataGridView1.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellContentClick);
            // 
            // sNoDataGridViewTextBoxColumn
            // 
            this.sNoDataGridViewTextBoxColumn.DataPropertyName = "sNo";
            this.sNoDataGridViewTextBoxColumn.HeaderText = "sNo";
            this.sNoDataGridViewTextBoxColumn.Name = "sNoDataGridViewTextBoxColumn";
            this.sNoDataGridViewTextBoxColumn.ReadOnly = true;
            this.sNoDataGridViewTextBoxColumn.Width = 60;
            // 
            // sNameDataGridViewTextBoxColumn
            // 
            this.sNameDataGridViewTextBoxColumn.DataPropertyName = "sName";
            this.sNameDataGridViewTextBoxColumn.HeaderText = "sName";
            this.sNameDataGridViewTextBoxColumn.Name = "sNameDataGridViewTextBoxColumn";
            this.sNameDataGridViewTextBoxColumn.ReadOnly = true;
            this.sNameDataGridViewTextBoxColumn.Width = 60;
            // 
            // sDorDataGridViewTextBoxColumn
            // 
            this.sDorDataGridViewTextBoxColumn.DataPropertyName = "sDor";
            this.sDorDataGridViewTextBoxColumn.HeaderText = "sDor";
            this.sDorDataGridViewTextBoxColumn.MinimumWidth = 2;
            this.sDorDataGridViewTextBoxColumn.Name = "sDorDataGridViewTextBoxColumn";
            this.sDorDataGridViewTextBoxColumn.ReadOnly = true;
            this.sDorDataGridViewTextBoxColumn.Width = 60;
            // 
            // sHowmpDataGridViewTextBoxColumn
            // 
            this.sHowmpDataGridViewTextBoxColumn.DataPropertyName = "sHowmp";
            this.sHowmpDataGridViewTextBoxColumn.HeaderText = "sHowmp";
            this.sHowmpDataGridViewTextBoxColumn.Name = "sHowmpDataGridViewTextBoxColumn";
            this.sHowmpDataGridViewTextBoxColumn.ReadOnly = true;
            this.sHowmpDataGridViewTextBoxColumn.Width = 60;
            // 
            // sServerpaDataGridViewTextBoxColumn
            // 
            this.sServerpaDataGridViewTextBoxColumn.DataPropertyName = "sServerpa";
            this.sServerpaDataGridViewTextBoxColumn.HeaderText = "sServerpa";
            this.sServerpaDataGridViewTextBoxColumn.Name = "sServerpaDataGridViewTextBoxColumn";
            this.sServerpaDataGridViewTextBoxColumn.ReadOnly = true;
            this.sServerpaDataGridViewTextBoxColumn.Width = 75;
            // 
            // dormitoryBindingSource
            // 
            this.dormitoryBindingSource.DataMember = "dormitory";
            this.dormitoryBindingSource.DataSource = this.ssglDataSet;
            // 
            // ssglDataSet
            // 
            this.ssglDataSet.DataSetName = "ssglDataSet";
            this.ssglDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // dormitoryTableAdapter
            // 
            this.dormitoryTableAdapter.ClearBeforeFill = true;
            // 
            // but1
            // 
            this.but1.AllowDrop = true;
            this.but1.BackColor = System.Drawing.SystemColors.AppWorkspace;
            this.but1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.but1.Location = new System.Drawing.Point(52, 61);
            this.but1.Name = "but1";
            this.but1.Size = new System.Drawing.Size(75, 23);
            this.but1.TabIndex = 1;
            this.but1.Text = "添加";
            this.but1.UseCompatibleTextRendering = true;
            this.but1.UseVisualStyleBackColor = true;
            this.but1.Click += new System.EventHandler(this.but1_Click);
            // 
            // txtSno
            // 
            this.txtSno.BackColor = System.Drawing.SystemColors.AppWorkspace;
            this.txtSno.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtSno.Cursor = System.Windows.Forms.Cursors.Default;
            this.txtSno.Location = new System.Drawing.Point(42, 21);
            this.txtSno.Name = "txtSno";
            this.txtSno.Size = new System.Drawing.Size(100, 21);
            this.txtSno.TabIndex = 2;
            this.txtSno.TextChanged += new System.EventHandler(this.textBox1_TextChanged);
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.Transparent;
            this.panel1.Controls.Add(this.label5);
            this.panel1.Controls.Add(this.label4);
            this.panel1.Controls.Add(this.label3);
            this.panel1.Controls.Add(this.姓名);
            this.panel1.Controls.Add(this.label1);
            this.panel1.Controls.Add(this.but5);
            this.panel1.Controls.Add(this.but4);
            this.panel1.Controls.Add(this.but3);
            this.panel1.Controls.Add(this.but2);
            this.panel1.Controls.Add(this.but1);
            this.panel1.Controls.Add(this.txtSser);
            this.panel1.Controls.Add(this.txtShowmp);
            this.panel1.Controls.Add(this.txtSdor);
            this.panel1.Controls.Add(this.txtSname);
            this.panel1.Controls.Add(this.txtSno);
            this.panel1.Location = new System.Drawing.Point(30, 40);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(721, 156);
            this.panel1.TabIndex = 3;
            
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.ForeColor = System.Drawing.SystemColors.AppWorkspace;
            this.label5.Location = new System.Drawing.Point(581, 29);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(29, 12);
            this.label5.TabIndex = 3;
            this.label5.Text = "已住";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.ForeColor = System.Drawing.SystemColors.AppWorkspace;
            this.label4.Location = new System.Drawing.Point(438, 28);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(29, 12);
            this.label4.TabIndex = 3;
            this.label4.Text = "可住";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.ForeColor = System.Drawing.SystemColors.AppWorkspace;
            this.label3.Location = new System.Drawing.Point(291, 28);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(29, 12);
            this.label3.TabIndex = 3;
            this.label3.Text = "宿舍";
            // 
            // 姓名
            // 
            this.姓名.AutoSize = true;
            this.姓名.ForeColor = System.Drawing.SystemColors.AppWorkspace;
            this.姓名.Location = new System.Drawing.Point(148, 26);
            this.姓名.Name = "姓名";
            this.姓名.Size = new System.Drawing.Size(29, 12);
            this.姓名.TabIndex = 3;
            this.姓名.Text = "姓名";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.ForeColor = System.Drawing.SystemColors.AppWorkspace;
            this.label1.Location = new System.Drawing.Point(5, 26);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(29, 12);
            this.label1.TabIndex = 3;
            this.label1.Text = "学号";
            // 
            // but5
            // 
            this.but5.AllowDrop = true;
            this.but5.BackColor = System.Drawing.SystemColors.AppWorkspace;
            this.but5.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.but5.Location = new System.Drawing.Point(628, 64);
            this.but5.Name = "but5";
            this.but5.Size = new System.Drawing.Size(75, 23);
            this.but5.TabIndex = 1;
            this.but5.Text = "清空";
            this.but5.UseCompatibleTextRendering = true;
            this.but5.UseVisualStyleBackColor = true;
            this.but5.Click += new System.EventHandler(this.but5_Click);
            // 
            // but4
            // 
            this.but4.AllowDrop = true;
            this.but4.BackColor = System.Drawing.SystemColors.AppWorkspace;
            this.but4.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.but4.Location = new System.Drawing.Point(485, 63);
            this.but4.Name = "but4";
            this.but4.Size = new System.Drawing.Size(75, 23);
            this.but4.TabIndex = 1;
            this.but4.Text = "删除";
            this.but4.UseCompatibleTextRendering = true;
            this.but4.UseVisualStyleBackColor = true;
            this.but4.Click += new System.EventHandler(this.but4_Click);
            // 
            // but3
            // 
            this.but3.AllowDrop = true;
            this.but3.BackColor = System.Drawing.SystemColors.AppWorkspace;
            this.but3.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.but3.Location = new System.Drawing.Point(338, 63);
            this.but3.Name = "but3";
            this.but3.Size = new System.Drawing.Size(75, 23);
            this.but3.TabIndex = 1;
            this.but3.Text = "查询";
            this.but3.UseCompatibleTextRendering = true;
            this.but3.UseVisualStyleBackColor = true;
            this.but3.Click += new System.EventHandler(this.but3_Click);
            // 
            // but2
            // 
            this.but2.AllowDrop = true;
            this.but2.BackColor = System.Drawing.SystemColors.AppWorkspace;
            this.but2.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.but2.Location = new System.Drawing.Point(195, 61);
            this.but2.Name = "but2";
            this.but2.Size = new System.Drawing.Size(75, 23);
            this.but2.TabIndex = 1;
            this.but2.Text = "修改";
            this.but2.UseCompatibleTextRendering = true;
            this.but2.UseVisualStyleBackColor = true;
            this.but2.Click += new System.EventHandler(this.but2_Click);
            // 
            // txtSser
            // 
            this.txtSser.BackColor = System.Drawing.SystemColors.AppWorkspace;
            this.txtSser.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtSser.Cursor = System.Windows.Forms.Cursors.Default;
            this.txtSser.Location = new System.Drawing.Point(618, 24);
            this.txtSser.Name = "txtSser";
            this.txtSser.Size = new System.Drawing.Size(100, 21);
            this.txtSser.TabIndex = 2;
            this.txtSser.TextChanged += new System.EventHandler(this.textBox1_TextChanged);
            // 
            // txtShowmp
            // 
            this.txtShowmp.BackColor = System.Drawing.SystemColors.AppWorkspace;
            this.txtShowmp.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtShowmp.Cursor = System.Windows.Forms.Cursors.Default;
            this.txtShowmp.Location = new System.Drawing.Point(473, 23);
            this.txtShowmp.Name = "txtShowmp";
            this.txtShowmp.Size = new System.Drawing.Size(100, 21);
            this.txtShowmp.TabIndex = 2;
            this.txtShowmp.TextChanged += new System.EventHandler(this.textBox1_TextChanged);
            // 
            // txtSdor
            // 
            this.txtSdor.BackColor = System.Drawing.SystemColors.AppWorkspace;
            this.txtSdor.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtSdor.Cursor = System.Windows.Forms.Cursors.Default;
            this.txtSdor.Location = new System.Drawing.Point(328, 23);
            this.txtSdor.Name = "txtSdor";
            this.txtSdor.Size = new System.Drawing.Size(100, 21);
            this.txtSdor.TabIndex = 2;
            this.txtSdor.TextChanged += new System.EventHandler(this.textBox1_TextChanged);
            // 
            // txtSname
            // 
            this.txtSname.BackColor = System.Drawing.SystemColors.AppWorkspace;
            this.txtSname.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtSname.Cursor = System.Windows.Forms.Cursors.Default;
            this.txtSname.Location = new System.Drawing.Point(185, 21);
            this.txtSname.Name = "txtSname";
            this.txtSname.Size = new System.Drawing.Size(100, 21);
            this.txtSname.TabIndex = 2;
            this.txtSname.TextChanged += new System.EventHandler(this.textBox1_TextChanged);
            // 
            // Frm011查看资料
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.ClientSize = new System.Drawing.Size(833, 435);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.dataGridView1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.Name = "Frm011查看资料";
            this.Opacity = 0.95D;
            this.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.Text = "Frm011查看资料";
            this.Load += new System.EventHandler(this.Frm011查看资料_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dormitoryBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.ssglDataSet)).EndInit();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView dataGridView1;
        private ssglDataSet ssglDataSet;
        private System.Windows.Forms.BindingSource dormitoryBindingSource;
        private ssglDataSetTableAdapters.dormitoryTableAdapter dormitoryTableAdapter;
        private System.Windows.Forms.Button but1;
        private System.Windows.Forms.TextBox txtSno;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.DataGridViewTextBoxColumn sNoDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn sNameDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn sDorDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn sHowmpDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn sServerpaDataGridViewTextBoxColumn;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label 姓名;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button but5;
        private System.Windows.Forms.Button but4;
        private System.Windows.Forms.Button but3;
        private System.Windows.Forms.Button but2;
        private System.Windows.Forms.TextBox txtSser;
        private System.Windows.Forms.TextBox txtShowmp;
        private System.Windows.Forms.TextBox txtSdor;
        private System.Windows.Forms.TextBox txtSname;
    }
}