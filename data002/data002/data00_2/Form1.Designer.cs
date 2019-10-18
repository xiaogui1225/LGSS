namespace data00_2
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
            this.dormitoryBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.dordadta = new data00_2.dordadta();
            this.label1 = new System.Windows.Forms.Label();
            this.txtSno = new System.Windows.Forms.TextBox();
            this.button1 = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.txtName = new System.Windows.Forms.TextBox();
            this.button2 = new System.Windows.Forms.Button();
            this.label3 = new System.Windows.Forms.Label();
            this.txtSdor = new System.Windows.Forms.TextBox();
            this.button3 = new System.Windows.Forms.Button();
            this.label4 = new System.Windows.Forms.Label();
            this.txtHowmp = new System.Windows.Forms.TextBox();
            this.button4 = new System.Windows.Forms.Button();
            this.label5 = new System.Windows.Forms.Label();
            this.txtSer = new System.Windows.Forms.TextBox();
            this.button5 = new System.Windows.Forms.Button();
            this.dormitoryTableAdapter = new data00_2.dordadtaTableAdapters.dormitoryTableAdapter();
            this.sNoDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.sNameDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.sDorDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.sHowmpDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.sServerpaDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dormitoryBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dordadta)).BeginInit();
            this.SuspendLayout();
            // 
            // dataGridView1
            // 
            this.dataGridView1.AutoGenerateColumns = false;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.sNoDataGridViewTextBoxColumn,
            this.sNameDataGridViewTextBoxColumn,
            this.sDorDataGridViewTextBoxColumn,
            this.sHowmpDataGridViewTextBoxColumn,
            this.sServerpaDataGridViewTextBoxColumn});
            this.dataGridView1.DataSource = this.dormitoryBindingSource;
            this.dataGridView1.Location = new System.Drawing.Point(35, 203);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.RowTemplate.Height = 23;
            this.dataGridView1.Size = new System.Drawing.Size(670, 133);
            this.dataGridView1.TabIndex = 0;
            this.dataGridView1.CellDoubleClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellDoubleClick);
            // 
            // dormitoryBindingSource
            // 
            this.dormitoryBindingSource.DataMember = "dormitory";
            this.dormitoryBindingSource.DataSource = this.dordadta;
            // 
            // dordadta
            // 
            this.dordadta.DataSetName = "dordadta";
            this.dordadta.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(33, 56);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(41, 12);
            this.label1.TabIndex = 1;
            this.label1.Text = "label1";
            // 
            // txtSno
            // 
            this.txtSno.Location = new System.Drawing.Point(85, 53);
            this.txtSno.Name = "txtSno";
            this.txtSno.Size = new System.Drawing.Size(100, 21);
            this.txtSno.TabIndex = 2;
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(85, 97);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(100, 23);
            this.button1.TabIndex = 3;
            this.button1.Text = "添加";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(212, 56);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(41, 12);
            this.label2.TabIndex = 1;
            this.label2.Text = "label1";
            // 
            // txtName
            // 
            this.txtName.Location = new System.Drawing.Point(264, 53);
            this.txtName.Name = "txtName";
            this.txtName.Size = new System.Drawing.Size(100, 21);
            this.txtName.TabIndex = 2;
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(264, 97);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(100, 23);
            this.button2.TabIndex = 3;
            this.button2.Text = "修改";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(390, 56);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(41, 12);
            this.label3.TabIndex = 1;
            this.label3.Text = "label1";
            // 
            // txtSdor
            // 
            this.txtSdor.Location = new System.Drawing.Point(442, 53);
            this.txtSdor.Name = "txtSdor";
            this.txtSdor.Size = new System.Drawing.Size(100, 21);
            this.txtSdor.TabIndex = 2;
            // 
            // button3
            // 
            this.button3.Location = new System.Drawing.Point(442, 97);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(100, 23);
            this.button3.TabIndex = 3;
            this.button3.Text = "删除";
            this.button3.UseVisualStyleBackColor = true;
            this.button3.Click += new System.EventHandler(this.button3_Click);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(552, 56);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(41, 12);
            this.label4.TabIndex = 1;
            this.label4.Text = "label1";
            // 
            // txtHowmp
            // 
            this.txtHowmp.Location = new System.Drawing.Point(604, 53);
            this.txtHowmp.Name = "txtHowmp";
            this.txtHowmp.Size = new System.Drawing.Size(100, 21);
            this.txtHowmp.TabIndex = 2;
            // 
            // button4
            // 
            this.button4.Location = new System.Drawing.Point(604, 97);
            this.button4.Name = "button4";
            this.button4.Size = new System.Drawing.Size(100, 23);
            this.button4.TabIndex = 3;
            this.button4.Text = "查询";
            this.button4.UseVisualStyleBackColor = true;
            this.button4.Click += new System.EventHandler(this.button4_Click_1);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(711, 56);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(41, 12);
            this.label5.TabIndex = 1;
            this.label5.Text = "label1";
            // 
            // txtSer
            // 
            this.txtSer.Location = new System.Drawing.Point(763, 53);
            this.txtSer.Name = "txtSer";
            this.txtSer.Size = new System.Drawing.Size(100, 21);
            this.txtSer.TabIndex = 2;
            // 
            // button5
            // 
            this.button5.Location = new System.Drawing.Point(763, 97);
            this.button5.Name = "button5";
            this.button5.Size = new System.Drawing.Size(100, 23);
            this.button5.TabIndex = 3;
            this.button5.Text = "清空";
            this.button5.UseVisualStyleBackColor = true;
            this.button5.Click += new System.EventHandler(this.button5_Click);
            // 
            // dormitoryTableAdapter
            // 
            this.dormitoryTableAdapter.ClearBeforeFill = true;
            // 
            // sNoDataGridViewTextBoxColumn
            // 
            this.sNoDataGridViewTextBoxColumn.DataPropertyName = "sNo";
            this.sNoDataGridViewTextBoxColumn.HeaderText = "sNo";
            this.sNoDataGridViewTextBoxColumn.Name = "sNoDataGridViewTextBoxColumn";
            // 
            // sNameDataGridViewTextBoxColumn
            // 
            this.sNameDataGridViewTextBoxColumn.DataPropertyName = "sName";
            this.sNameDataGridViewTextBoxColumn.HeaderText = "sName";
            this.sNameDataGridViewTextBoxColumn.Name = "sNameDataGridViewTextBoxColumn";
            // 
            // sDorDataGridViewTextBoxColumn
            // 
            this.sDorDataGridViewTextBoxColumn.DataPropertyName = "sDor";
            this.sDorDataGridViewTextBoxColumn.HeaderText = "sDor";
            this.sDorDataGridViewTextBoxColumn.Name = "sDorDataGridViewTextBoxColumn";
            // 
            // sHowmpDataGridViewTextBoxColumn
            // 
            this.sHowmpDataGridViewTextBoxColumn.DataPropertyName = "sHowmp";
            this.sHowmpDataGridViewTextBoxColumn.HeaderText = "sHowmp";
            this.sHowmpDataGridViewTextBoxColumn.Name = "sHowmpDataGridViewTextBoxColumn";
            // 
            // sServerpaDataGridViewTextBoxColumn
            // 
            this.sServerpaDataGridViewTextBoxColumn.DataPropertyName = "sServerpa";
            this.sServerpaDataGridViewTextBoxColumn.HeaderText = "sServerpa";
            this.sServerpaDataGridViewTextBoxColumn.Name = "sServerpaDataGridViewTextBoxColumn";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(856, 450);
            this.Controls.Add(this.button5);
            this.Controls.Add(this.button4);
            this.Controls.Add(this.button3);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.txtSer);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.txtHowmp);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.txtSdor);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.txtName);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.txtSno);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.dataGridView1);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dormitoryBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dordadta)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txtName;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox txtSdor;
        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox txtHowmp;
        private System.Windows.Forms.Button button4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox txtSer;
        private System.Windows.Forms.Button button5;
        private dordadta dordadta;
        private System.Windows.Forms.BindingSource dormitoryBindingSource;
        private dordadtaTableAdapters.dormitoryTableAdapter dormitoryTableAdapter;
        public System.Windows.Forms.TextBox txtSno;
        private System.Windows.Forms.DataGridViewTextBoxColumn sNoDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn sNameDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn sDorDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn sHowmpDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn sServerpaDataGridViewTextBoxColumn;
    }
}

