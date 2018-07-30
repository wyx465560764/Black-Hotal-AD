namespace HotalAD
{
    partial class Checkout
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
            this.label2 = new System.Windows.Forms.Label();
            this.textBox_number = new System.Windows.Forms.TextBox();
            this.button1 = new System.Windows.Forms.Button();
            this.button_return = new System.Windows.Forms.Button();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.label6 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.label_name = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.textBox_money = new System.Windows.Forms.TextBox();
            this.button2 = new System.Windows.Forms.Button();
            this.hotalDataSet = new HotalAD.HotalDataSet();
            this.kehuBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.kehuTableAdapter = new HotalAD.HotalDataSetTableAdapters.kehuTableAdapter();
            this.xmDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.rzrq = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ldrq = new System.Windows.Forms.DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.hotalDataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.kehuBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(28, 69);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(67, 15);
            this.label2.TabIndex = 1;
            this.label2.Text = "房间编号";
            // 
            // textBox_number
            // 
            this.textBox_number.Location = new System.Drawing.Point(101, 66);
            this.textBox_number.Name = "textBox_number";
            this.textBox_number.Size = new System.Drawing.Size(146, 25);
            this.textBox_number.TabIndex = 2;
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(135, 286);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(112, 23);
            this.button1.TabIndex = 9;
            this.button1.Text = "退房";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // button_return
            // 
            this.button_return.Location = new System.Drawing.Point(414, 286);
            this.button_return.Name = "button_return";
            this.button_return.Size = new System.Drawing.Size(112, 23);
            this.button_return.TabIndex = 10;
            this.button_return.Text = "返回上一层";
            this.button_return.UseVisualStyleBackColor = true;
            this.button_return.Click += new System.EventHandler(this.button_return_Click);
            // 
            // dataGridView1
            // 
            this.dataGridView1.AutoGenerateColumns = false;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.xmDataGridViewTextBoxColumn,
            this.rzrq,
            this.ldrq});
            this.dataGridView1.DataSource = this.kehuBindingSource;
            this.dataGridView1.Location = new System.Drawing.Point(317, 62);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.RowTemplate.Height = 27;
            this.dataGridView1.Size = new System.Drawing.Size(340, 218);
            this.dataGridView1.TabIndex = 11;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(388, 31);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(37, 15);
            this.label6.TabIndex = 12;
            this.label6.Text = "找到";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(468, 31);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(37, 15);
            this.label1.TabIndex = 13;
            this.label1.Text = "信息";
            // 
            // label_name
            // 
            this.label_name.AutoSize = true;
            this.label_name.Location = new System.Drawing.Point(431, 31);
            this.label_name.Name = "label_name";
            this.label_name.Size = new System.Drawing.Size(31, 15);
            this.label_name.TabIndex = 14;
            this.label_name.Text = "***";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(118, 31);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(82, 15);
            this.label3.TabIndex = 15;
            this.label3.Text = "输入房间号";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(28, 178);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(67, 15);
            this.label7.TabIndex = 18;
            this.label7.Text = "应收金额";
            // 
            // textBox_money
            // 
            this.textBox_money.Location = new System.Drawing.Point(101, 175);
            this.textBox_money.Name = "textBox_money";
            this.textBox_money.ReadOnly = true;
            this.textBox_money.Size = new System.Drawing.Size(146, 25);
            this.textBox_money.TabIndex = 20;
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(101, 113);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(99, 35);
            this.button2.TabIndex = 21;
            this.button2.Text = "查询";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // hotalDataSet
            // 
            this.hotalDataSet.DataSetName = "HotalDataSet";
            this.hotalDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // kehuBindingSource
            // 
            this.kehuBindingSource.DataMember = "kehu";
            this.kehuBindingSource.DataSource = this.hotalDataSet;
            // 
            // kehuTableAdapter
            // 
            this.kehuTableAdapter.ClearBeforeFill = true;
            // 
            // xmDataGridViewTextBoxColumn
            // 
            this.xmDataGridViewTextBoxColumn.DataPropertyName = "xm";
            this.xmDataGridViewTextBoxColumn.HeaderText = "xm";
            this.xmDataGridViewTextBoxColumn.Name = "xmDataGridViewTextBoxColumn";
            // 
            // rzrq
            // 
            this.rzrq.DataPropertyName = "rzrq";
            this.rzrq.HeaderText = "rzrq";
            this.rzrq.Name = "rzrq";
            // 
            // ldrq
            // 
            this.ldrq.DataPropertyName = "ldrq";
            this.ldrq.HeaderText = "ldrq";
            this.ldrq.Name = "ldrq";
            // 
            // Checkout
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(669, 337);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.textBox_money);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label_name);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.button_return);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.textBox_number);
            this.Controls.Add(this.label2);
            this.Name = "Checkout";
            this.Text = "Checkout";
            this.Load += new System.EventHandler(this.Checkout_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.hotalDataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.kehuBindingSource)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox textBox_number;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button button_return;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label_name;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.TextBox textBox_money;
        private System.Windows.Forms.Button button2;
        private HotalDataSet hotalDataSet;
        private System.Windows.Forms.BindingSource kehuBindingSource;
        private HotalDataSetTableAdapters.kehuTableAdapter kehuTableAdapter;
        private System.Windows.Forms.DataGridViewTextBoxColumn xmDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn rzrq;
        private System.Windows.Forms.DataGridViewTextBoxColumn ldrq;
    }
}