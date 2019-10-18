namespace data
{
    partial class Form1
    {
        /// <summary>
        /// 必需的设计器变量。
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// 清理所有正在使用的资源。
        /// </summary>
        /// <param name="disposing">如果应释放托管资源，为 true；否则为 false。</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows 窗体设计器生成的代码

        /// <summary>
        /// 设计器支持所需的方法 - 不要修改
        /// 使用代码编辑器修改此方法的内容。
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.button1 = new System.Windows.Forms.Button();
            this.学号 = new System.Windows.Forms.Label();
            this.txtsno = new System.Windows.Forms.TextBox();
            this.姓名 = new System.Windows.Forms.Label();
            this.txtname = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.txtdor = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.txthmp = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.txtsserver = new System.Windows.Forms.TextBox();
            this.button2 = new System.Windows.Forms.Button();
            this.button3 = new System.Windows.Forms.Button();
            this.button4 = new System.Windows.Forms.Button();
            this.button5 = new System.Windows.Forms.Button();
            this.ssglDataSet1 = new data.ssglDataSet1();
            this.dormitoryBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.dormitoryTableAdapter = new data.ssglDataSet1TableAdapters.dormitoryTableAdapter();
            this.sDorDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.sNoDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.sNameDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.sHowmpDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.sServerpaDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.sWateraDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.sEFDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.soverEfDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.soverWEDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.ssglDataSet1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dormitoryBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // dataGridView1
            // 
            this.dataGridView1.AutoGenerateColumns = false;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.sDorDataGridViewTextBoxColumn,
            this.sNoDataGridViewTextBoxColumn,
            this.sNameDataGridViewTextBoxColumn,
            this.sHowmpDataGridViewTextBoxColumn,
            this.sServerpaDataGridViewTextBoxColumn,
            this.sWateraDataGridViewTextBoxColumn,
            this.sEFDataGridViewTextBoxColumn,
            this.soverEfDataGridViewTextBoxColumn,
            this.soverWEDataGridViewTextBoxColumn});
            this.dataGridView1.DataSource = this.dormitoryBindingSource;
            this.dataGridView1.Location = new System.Drawing.Point(77, 192);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.RowTemplate.Height = 23;
            this.dataGridView1.Size = new System.Drawing.Size(642, 150);
            this.dataGridView1.TabIndex = 0;
            this.dataGridView1.CellDoubleClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellDoubleClick);
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(77, 95);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(75, 23);
            this.button1.TabIndex = 1;
            this.button1.Text = "添加";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // 学号
            // 
            this.学号.AutoSize = true;
            this.学号.Location = new System.Drawing.Point(16, 34);
            this.学号.Name = "学号";
            this.学号.Size = new System.Drawing.Size(29, 12);
            this.学号.TabIndex = 2;
            this.学号.Text = "学号";
            // 
            // txtsno
            // 
            this.txtsno.Location = new System.Drawing.Point(77, 31);
            this.txtsno.Name = "txtsno";
            this.txtsno.Size = new System.Drawing.Size(75, 21);
            this.txtsno.TabIndex = 3;
            // 
            // 姓名
            // 
            this.姓名.AutoSize = true;
            this.姓名.Location = new System.Drawing.Point(184, 34);
            this.姓名.Name = "姓名";
            this.姓名.Size = new System.Drawing.Size(29, 12);
            this.姓名.TabIndex = 2;
            this.姓名.Text = "姓名";
            // 
            // txtname
            // 
            this.txtname.Location = new System.Drawing.Point(245, 31);
            this.txtname.Name = "txtname";
            this.txtname.Size = new System.Drawing.Size(75, 21);
            this.txtname.TabIndex = 3;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(330, 34);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(29, 12);
            this.label3.TabIndex = 2;
            this.label3.Text = "宿舍";
            // 
            // txtdor
            // 
            this.txtdor.Location = new System.Drawing.Point(391, 31);
            this.txtdor.Name = "txtdor";
            this.txtdor.Size = new System.Drawing.Size(75, 21);
            this.txtdor.TabIndex = 3;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(472, 34);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(53, 12);
            this.label4.TabIndex = 2;
            this.label4.Text = "可住几人";
            // 
            // txthmp
            // 
            this.txthmp.Location = new System.Drawing.Point(533, 31);
            this.txthmp.Name = "txthmp";
            this.txthmp.Size = new System.Drawing.Size(75, 21);
            this.txthmp.TabIndex = 3;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(618, 34);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(53, 12);
            this.label5.TabIndex = 2;
            this.label5.Text = "已住几人";
            // 
            // txtsserver
            // 
            this.txtsserver.Location = new System.Drawing.Point(679, 31);
            this.txtsserver.Name = "txtsserver";
            this.txtsserver.Size = new System.Drawing.Size(75, 21);
            this.txtsserver.TabIndex = 3;
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(245, 95);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(75, 23);
            this.button2.TabIndex = 1;
            this.button2.Text = "修改";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // button3
            // 
            this.button3.Location = new System.Drawing.Point(391, 95);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(75, 23);
            this.button3.TabIndex = 1;
            this.button3.Text = "删除";
            this.button3.UseVisualStyleBackColor = true;
            this.button3.Click += new System.EventHandler(this.button3_Click);
            // 
            // button4
            // 
            this.button4.Location = new System.Drawing.Point(533, 95);
            this.button4.Name = "button4";
            this.button4.Size = new System.Drawing.Size(75, 23);
            this.button4.TabIndex = 1;
            this.button4.Text = "查询";
            this.button4.UseVisualStyleBackColor = true;
            this.button4.Click += new System.EventHandler(this.button4_Click);
            // 
            // button5
            // 
            this.button5.Location = new System.Drawing.Point(679, 95);
            this.button5.Name = "button5";
            this.button5.Size = new System.Drawing.Size(75, 23);
            this.button5.TabIndex = 1;
            this.button5.Text = "清空";
            this.button5.UseVisualStyleBackColor = true;
            this.button5.Click += new System.EventHandler(this.button5_Click);
            // 
            // ssglDataSet1
            // 
            this.ssglDataSet1.DataSetName = "ssglDataSet1";
            this.ssglDataSet1.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // dormitoryBindingSource
            // 
            this.dormitoryBindingSource.DataMember = "dormitory";
            this.dormitoryBindingSource.DataSource = this.ssglDataSet1;
            // 
            // dormitoryTableAdapter
            // 
            this.dormitoryTableAdapter.ClearBeforeFill = true;
            // 
            // sDorDataGridViewTextBoxColumn
            // 
            this.sDorDataGridViewTextBoxColumn.DataPropertyName = "sDor";
            this.sDorDataGridViewTextBoxColumn.HeaderText = "sDor";
            this.sDorDataGridViewTextBoxColumn.Name = "sDorDataGridViewTextBoxColumn";
            this.sDorDataGridViewTextBoxColumn.Width = 60;
            // 
            // sNoDataGridViewTextBoxColumn
            // 
            this.sNoDataGridViewTextBoxColumn.DataPropertyName = "sNo";
            this.sNoDataGridViewTextBoxColumn.HeaderText = "sNo";
            this.sNoDataGridViewTextBoxColumn.Name = "sNoDataGridViewTextBoxColumn";
            this.sNoDataGridViewTextBoxColumn.Width = 60;
            // 
            // sNameDataGridViewTextBoxColumn
            // 
            this.sNameDataGridViewTextBoxColumn.DataPropertyName = "sName";
            this.sNameDataGridViewTextBoxColumn.HeaderText = "sName";
            this.sNameDataGridViewTextBoxColumn.Name = "sNameDataGridViewTextBoxColumn";
            this.sNameDataGridViewTextBoxColumn.Width = 60;
            // 
            // sHowmpDataGridViewTextBoxColumn
            // 
            this.sHowmpDataGridViewTextBoxColumn.DataPropertyName = "sHowmp";
            this.sHowmpDataGridViewTextBoxColumn.HeaderText = "sHowmp";
            this.sHowmpDataGridViewTextBoxColumn.Name = "sHowmpDataGridViewTextBoxColumn";
            this.sHowmpDataGridViewTextBoxColumn.Width = 60;
            // 
            // sServerpaDataGridViewTextBoxColumn
            // 
            this.sServerpaDataGridViewTextBoxColumn.DataPropertyName = "sServerpa";
            this.sServerpaDataGridViewTextBoxColumn.HeaderText = "sServerpa";
            this.sServerpaDataGridViewTextBoxColumn.Name = "sServerpaDataGridViewTextBoxColumn";
            this.sServerpaDataGridViewTextBoxColumn.Width = 60;
            // 
            // sWateraDataGridViewTextBoxColumn
            // 
            this.sWateraDataGridViewTextBoxColumn.DataPropertyName = "sWatera";
            this.sWateraDataGridViewTextBoxColumn.HeaderText = "sWatera";
            this.sWateraDataGridViewTextBoxColumn.Name = "sWateraDataGridViewTextBoxColumn";
            this.sWateraDataGridViewTextBoxColumn.Width = 60;
            // 
            // sEFDataGridViewTextBoxColumn
            // 
            this.sEFDataGridViewTextBoxColumn.DataPropertyName = "sEF";
            this.sEFDataGridViewTextBoxColumn.HeaderText = "sEF";
            this.sEFDataGridViewTextBoxColumn.Name = "sEFDataGridViewTextBoxColumn";
            this.sEFDataGridViewTextBoxColumn.Width = 60;
            // 
            // soverEfDataGridViewTextBoxColumn
            // 
            this.soverEfDataGridViewTextBoxColumn.DataPropertyName = "soverEf";
            this.soverEfDataGridViewTextBoxColumn.HeaderText = "soverEf";
            this.soverEfDataGridViewTextBoxColumn.Name = "soverEfDataGridViewTextBoxColumn";
            this.soverEfDataGridViewTextBoxColumn.Width = 60;
            // 
            // soverWEDataGridViewTextBoxColumn
            // 
            this.soverWEDataGridViewTextBoxColumn.DataPropertyName = "soverWE";
            this.soverWEDataGridViewTextBoxColumn.HeaderText = "soverWE";
            this.soverWEDataGridViewTextBoxColumn.Name = "soverWEDataGridViewTextBoxColumn";
            this.soverWEDataGridViewTextBoxColumn.Width = 60;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.txtsserver);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.txthmp);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.txtdor);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.txtname);
            this.Controls.Add(this.姓名);
            this.Controls.Add(this.txtsno);
            this.Controls.Add(this.学号);
            this.Controls.Add(this.button5);
            this.Controls.Add(this.button4);
            this.Controls.Add(this.button3);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.dataGridView1);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.ssglDataSet1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dormitoryBindingSource)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Label 学号;
        private System.Windows.Forms.TextBox txtsno;
        private System.Windows.Forms.Label 姓名;
        private System.Windows.Forms.TextBox txtname;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox txtdor;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox txthmp;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox txtsserver;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.Button button4;
        private System.Windows.Forms.Button button5;
        private ssglDataSet1 ssglDataSet1;
        private System.Windows.Forms.BindingSource dormitoryBindingSource;
        private ssglDataSet1TableAdapters.dormitoryTableAdapter dormitoryTableAdapter;
        private System.Windows.Forms.DataGridViewTextBoxColumn sDorDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn sNoDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn sNameDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn sHowmpDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn sServerpaDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn sWateraDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn sEFDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn soverEfDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn soverWEDataGridViewTextBoxColumn;
    }
}

