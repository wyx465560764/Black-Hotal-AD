namespace HotalAD
{
    partial class Request
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
            this.label1 = new System.Windows.Forms.Label();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.qingqiuDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.fjIDDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.tjsjDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.qingqiuBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.hotalDataSet = new HotalAD.HotalDataSet();
            this.button1 = new System.Windows.Forms.Button();
            this.button_return = new System.Windows.Forms.Button();
            this.dataGridView2 = new System.Windows.Forms.DataGridView();
            this.ygIDDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.yglxDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.yuangongBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.dataGridView3 = new System.Windows.Forms.DataGridView();
            this.fwztDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.fjIDDataGridViewTextBoxColumn1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ygIDDataGridViewTextBoxColumn1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.qingqiuDataGridViewTextBoxColumn1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.anpaiBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.button2 = new System.Windows.Forms.Button();
            this.yuangongTableAdapter = new HotalAD.HotalDataSetTableAdapters.YuangongTableAdapter();
            this.anpaiTableAdapter = new HotalAD.HotalDataSetTableAdapters.AnpaiTableAdapter();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.textBox1_room = new System.Windows.Forms.TextBox();
            this.textBox_yuangong = new System.Windows.Forms.TextBox();
            this.fileSystemWatcher1 = new System.IO.FileSystemWatcher();
            this.textBox_ygid2 = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.qingqiuTableAdapter = new HotalAD.HotalDataSetTableAdapters.QingqiuTableAdapter();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.qingqiuBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.hotalDataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.yuangongBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView3)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.anpaiBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.fileSystemWatcher1)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(101, 20);
            this.label1.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(89, 12);
            this.label1.TabIndex = 0;
            this.label1.Text = "待处理客户请求";
            // 
            // dataGridView1
            // 
            this.dataGridView1.AutoGenerateColumns = false;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.qingqiuDataGridViewTextBoxColumn,
            this.fjIDDataGridViewTextBoxColumn,
            this.tjsjDataGridViewTextBoxColumn});
            this.dataGridView1.DataSource = this.qingqiuBindingSource;
            this.dataGridView1.Location = new System.Drawing.Point(19, 34);
            this.dataGridView1.Margin = new System.Windows.Forms.Padding(2);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.ReadOnly = true;
            this.dataGridView1.RowTemplate.Height = 27;
            this.dataGridView1.Size = new System.Drawing.Size(344, 124);
            this.dataGridView1.TabIndex = 1;
            // 
            // qingqiuDataGridViewTextBoxColumn
            // 
            this.qingqiuDataGridViewTextBoxColumn.DataPropertyName = "Qingqiu";
            this.qingqiuDataGridViewTextBoxColumn.HeaderText = "Qingqiu";
            this.qingqiuDataGridViewTextBoxColumn.Name = "qingqiuDataGridViewTextBoxColumn";
            this.qingqiuDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // fjIDDataGridViewTextBoxColumn
            // 
            this.fjIDDataGridViewTextBoxColumn.DataPropertyName = "FjID";
            this.fjIDDataGridViewTextBoxColumn.HeaderText = "FjID";
            this.fjIDDataGridViewTextBoxColumn.Name = "fjIDDataGridViewTextBoxColumn";
            this.fjIDDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // tjsjDataGridViewTextBoxColumn
            // 
            this.tjsjDataGridViewTextBoxColumn.DataPropertyName = "tjsj";
            this.tjsjDataGridViewTextBoxColumn.HeaderText = "tjsj";
            this.tjsjDataGridViewTextBoxColumn.Name = "tjsjDataGridViewTextBoxColumn";
            this.tjsjDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // qingqiuBindingSource
            // 
            this.qingqiuBindingSource.DataMember = "Qingqiu";
            this.qingqiuBindingSource.DataSource = this.hotalDataSet;
            // 
            // hotalDataSet
            // 
            this.hotalDataSet.DataSetName = "HotalDataSet";
            this.hotalDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(136, 328);
            this.button1.Margin = new System.Windows.Forms.Padding(2);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(125, 32);
            this.button1.TabIndex = 2;
            this.button1.Text = "处理并派遣服务人员";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // button_return
            // 
            this.button_return.Location = new System.Drawing.Point(561, 328);
            this.button_return.Margin = new System.Windows.Forms.Padding(2);
            this.button_return.Name = "button_return";
            this.button_return.Size = new System.Drawing.Size(129, 32);
            this.button_return.TabIndex = 3;
            this.button_return.Text = "返回上一层";
            this.button_return.UseVisualStyleBackColor = true;
            this.button_return.Click += new System.EventHandler(this.button_return_Click);
            // 
            // dataGridView2
            // 
            this.dataGridView2.AutoGenerateColumns = false;
            this.dataGridView2.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView2.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.ygIDDataGridViewTextBoxColumn,
            this.yglxDataGridViewTextBoxColumn});
            this.dataGridView2.DataSource = this.yuangongBindingSource;
            this.dataGridView2.Location = new System.Drawing.Point(19, 175);
            this.dataGridView2.Name = "dataGridView2";
            this.dataGridView2.ReadOnly = true;
            this.dataGridView2.RowTemplate.Height = 23;
            this.dataGridView2.Size = new System.Drawing.Size(245, 95);
            this.dataGridView2.TabIndex = 4;
            this.dataGridView2.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView2_CellContentClick);
            // 
            // ygIDDataGridViewTextBoxColumn
            // 
            this.ygIDDataGridViewTextBoxColumn.DataPropertyName = "YgID";
            this.ygIDDataGridViewTextBoxColumn.HeaderText = "YgID";
            this.ygIDDataGridViewTextBoxColumn.Name = "ygIDDataGridViewTextBoxColumn";
            this.ygIDDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // yglxDataGridViewTextBoxColumn
            // 
            this.yglxDataGridViewTextBoxColumn.DataPropertyName = "Yglx";
            this.yglxDataGridViewTextBoxColumn.HeaderText = "Yglx";
            this.yglxDataGridViewTextBoxColumn.Name = "yglxDataGridViewTextBoxColumn";
            this.yglxDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // yuangongBindingSource
            // 
            this.yuangongBindingSource.DataMember = "Yuangong";
            this.yuangongBindingSource.DataSource = this.hotalDataSet;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(112, 160);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(65, 12);
            this.label2.TabIndex = 5;
            this.label2.Text = "可用服务员";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(506, 19);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(89, 12);
            this.label3.TabIndex = 6;
            this.label3.Text = "正在处理请求表";
            this.label3.Click += new System.EventHandler(this.label3_Click);
            // 
            // dataGridView3
            // 
            this.dataGridView3.AutoGenerateColumns = false;
            this.dataGridView3.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView3.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.fwztDataGridViewTextBoxColumn,
            this.fjIDDataGridViewTextBoxColumn1,
            this.ygIDDataGridViewTextBoxColumn1,
            this.qingqiuDataGridViewTextBoxColumn1});
            this.dataGridView3.DataSource = this.anpaiBindingSource;
            this.dataGridView3.Location = new System.Drawing.Point(400, 34);
            this.dataGridView3.Name = "dataGridView3";
            this.dataGridView3.ReadOnly = true;
            this.dataGridView3.RowTemplate.Height = 23;
            this.dataGridView3.Size = new System.Drawing.Size(444, 159);
            this.dataGridView3.TabIndex = 7;
            this.dataGridView3.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView3_CellContentClick);
            // 
            // fwztDataGridViewTextBoxColumn
            // 
            this.fwztDataGridViewTextBoxColumn.DataPropertyName = "Fwzt";
            this.fwztDataGridViewTextBoxColumn.HeaderText = "Fwzt";
            this.fwztDataGridViewTextBoxColumn.Name = "fwztDataGridViewTextBoxColumn";
            this.fwztDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // fjIDDataGridViewTextBoxColumn1
            // 
            this.fjIDDataGridViewTextBoxColumn1.DataPropertyName = "FjID";
            this.fjIDDataGridViewTextBoxColumn1.HeaderText = "FjID";
            this.fjIDDataGridViewTextBoxColumn1.Name = "fjIDDataGridViewTextBoxColumn1";
            this.fjIDDataGridViewTextBoxColumn1.ReadOnly = true;
            // 
            // ygIDDataGridViewTextBoxColumn1
            // 
            this.ygIDDataGridViewTextBoxColumn1.DataPropertyName = "YgID";
            this.ygIDDataGridViewTextBoxColumn1.HeaderText = "YgID";
            this.ygIDDataGridViewTextBoxColumn1.Name = "ygIDDataGridViewTextBoxColumn1";
            this.ygIDDataGridViewTextBoxColumn1.ReadOnly = true;
            // 
            // qingqiuDataGridViewTextBoxColumn1
            // 
            this.qingqiuDataGridViewTextBoxColumn1.DataPropertyName = "Qingqiu";
            this.qingqiuDataGridViewTextBoxColumn1.HeaderText = "Qingqiu";
            this.qingqiuDataGridViewTextBoxColumn1.Name = "qingqiuDataGridViewTextBoxColumn1";
            this.qingqiuDataGridViewTextBoxColumn1.ReadOnly = true;
            // 
            // anpaiBindingSource
            // 
            this.anpaiBindingSource.DataMember = "Anpai";
            this.anpaiBindingSource.DataSource = this.hotalDataSet;
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(590, 292);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(85, 24);
            this.button2.TabIndex = 8;
            this.button2.Text = "完成服务";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // yuangongTableAdapter
            // 
            this.yuangongTableAdapter.ClearBeforeFill = true;
            // 
            // anpaiTableAdapter
            // 
            this.anpaiTableAdapter.ClearBeforeFill = true;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(16, 298);
            this.label4.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(53, 12);
            this.label4.TabIndex = 9;
            this.label4.Text = "房间号：";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(154, 298);
            this.label5.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(77, 12);
            this.label5.TabIndex = 10;
            this.label5.Text = "派遣员工号：";
            // 
            // textBox1_room
            // 
            this.textBox1_room.Location = new System.Drawing.Point(73, 295);
            this.textBox1_room.Margin = new System.Windows.Forms.Padding(2);
            this.textBox1_room.Name = "textBox1_room";
            this.textBox1_room.Size = new System.Drawing.Size(76, 21);
            this.textBox1_room.TabIndex = 11;
            this.textBox1_room.TextChanged += new System.EventHandler(this.textBox1_room_TextChanged);
            // 
            // textBox_yuangong
            // 
            this.textBox_yuangong.Location = new System.Drawing.Point(235, 295);
            this.textBox_yuangong.Margin = new System.Windows.Forms.Padding(2);
            this.textBox_yuangong.Name = "textBox_yuangong";
            this.textBox_yuangong.Size = new System.Drawing.Size(76, 21);
            this.textBox_yuangong.TabIndex = 12;
            // 
            // fileSystemWatcher1
            // 
            this.fileSystemWatcher1.EnableRaisingEvents = true;
            this.fileSystemWatcher1.SynchronizingObject = this;
            // 
            // textBox_ygid2
            // 
            this.textBox_ygid2.Location = new System.Drawing.Point(590, 249);
            this.textBox_ygid2.Name = "textBox_ygid2";
            this.textBox_ygid2.Size = new System.Drawing.Size(100, 21);
            this.textBox_ygid2.TabIndex = 13;
            this.textBox_ygid2.TextChanged += new System.EventHandler(this.textBox_ygid2_TextChanged);
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(543, 252);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(41, 12);
            this.label6.TabIndex = 14;
            this.label6.Text = "员工号";
            // 
            // qingqiuTableAdapter
            // 
            this.qingqiuTableAdapter.ClearBeforeFill = true;
            // 
            // Request
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(870, 374);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.textBox_ygid2);
            this.Controls.Add(this.textBox_yuangong);
            this.Controls.Add(this.textBox1_room);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.dataGridView3);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.dataGridView2);
            this.Controls.Add(this.button_return);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.label1);
            this.Margin = new System.Windows.Forms.Padding(2);
            this.Name = "Request";
            this.Text = "Request";
            this.Load += new System.EventHandler(this.Request_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.qingqiuBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.hotalDataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.yuangongBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView3)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.anpaiBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.fileSystemWatcher1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button button_return;
        private System.Windows.Forms.DataGridView dataGridView2;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.DataGridView dataGridView3;
        private System.Windows.Forms.Button button2;
        private HotalDataSet hotalDataSet;
        private System.Windows.Forms.BindingSource yuangongBindingSource;
        private HotalDataSetTableAdapters.YuangongTableAdapter yuangongTableAdapter;
        private System.Windows.Forms.BindingSource anpaiBindingSource;
        private HotalDataSetTableAdapters.AnpaiTableAdapter anpaiTableAdapter;
        private System.Windows.Forms.DataGridViewTextBoxColumn fwztDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn fjIDDataGridViewTextBoxColumn1;
        private System.Windows.Forms.DataGridViewTextBoxColumn ygIDDataGridViewTextBoxColumn1;
        private System.Windows.Forms.DataGridViewTextBoxColumn qingqiuDataGridViewTextBoxColumn1;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox textBox1_room;
        private System.Windows.Forms.TextBox textBox_yuangong;
        private System.IO.FileSystemWatcher fileSystemWatcher1;
        private System.Windows.Forms.TextBox textBox_ygid2;
        private System.Windows.Forms.DataGridViewTextBoxColumn ygIDDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn yglxDataGridViewTextBoxColumn;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.BindingSource qingqiuBindingSource;
        private HotalDataSetTableAdapters.QingqiuTableAdapter qingqiuTableAdapter;
        private System.Windows.Forms.DataGridViewTextBoxColumn qingqiuDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn fjIDDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn tjsjDataGridViewTextBoxColumn;
    }
}