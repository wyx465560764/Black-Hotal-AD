namespace HotalAD
{
    partial class Checknow
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
            this.label2 = new System.Windows.Forms.Label();
            this.textBox_kehuName = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.textBox_kufuCall = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.textBox_fjID = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.textBox_intime = new System.Windows.Forms.TextBox();
            this.button1 = new System.Windows.Forms.Button();
            this.button_return = new System.Windows.Forms.Button();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.fjlxDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.fjIDDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.fjjgDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.roomBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.hotalDataSet = new HotalAD.HotalDataSet();
            this.label6 = new System.Windows.Forms.Label();
            this.roomTableAdapter = new HotalAD.HotalDataSetTableAdapters.RoomTableAdapter();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.roomBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.hotalDataSet)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(128, 26);
            this.label1.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(89, 12);
            this.label1.TabIndex = 0;
            this.label1.Text = "请登记入住信息";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(35, 79);
            this.label2.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(53, 12);
            this.label2.TabIndex = 1;
            this.label2.Text = "客户姓名";
            // 
            // textBox_kehuName
            // 
            this.textBox_kehuName.Location = new System.Drawing.Point(98, 77);
            this.textBox_kehuName.Margin = new System.Windows.Forms.Padding(2);
            this.textBox_kehuName.Name = "textBox_kehuName";
            this.textBox_kehuName.Size = new System.Drawing.Size(182, 21);
            this.textBox_kehuName.TabIndex = 2;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(20, 129);
            this.label3.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(77, 12);
            this.label3.TabIndex = 3;
            this.label3.Text = "客户身份证号";
            // 
            // textBox_kufuCall
            // 
            this.textBox_kufuCall.Location = new System.Drawing.Point(98, 126);
            this.textBox_kufuCall.Margin = new System.Windows.Forms.Padding(2);
            this.textBox_kufuCall.Name = "textBox_kufuCall";
            this.textBox_kufuCall.Size = new System.Drawing.Size(182, 21);
            this.textBox_kufuCall.TabIndex = 4;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(24, 178);
            this.label4.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(65, 12);
            this.label4.TabIndex = 5;
            this.label4.Text = "入住房间号";
            // 
            // textBox_fjID
            // 
            this.textBox_fjID.Location = new System.Drawing.Point(98, 175);
            this.textBox_fjID.Margin = new System.Windows.Forms.Padding(2);
            this.textBox_fjID.Name = "textBox_fjID";
            this.textBox_fjID.Size = new System.Drawing.Size(182, 21);
            this.textBox_fjID.TabIndex = 6;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(35, 220);
            this.label5.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(53, 12);
            this.label5.TabIndex = 7;
            this.label5.Text = "入住天数";
            // 
            // textBox_intime
            // 
            this.textBox_intime.Location = new System.Drawing.Point(98, 218);
            this.textBox_intime.Margin = new System.Windows.Forms.Padding(2);
            this.textBox_intime.Name = "textBox_intime";
            this.textBox_intime.Size = new System.Drawing.Size(182, 21);
            this.textBox_intime.TabIndex = 8;
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(64, 262);
            this.button1.Margin = new System.Windows.Forms.Padding(2);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(92, 18);
            this.button1.TabIndex = 9;
            this.button1.Text = "确认信息并入住";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // button_return
            // 
            this.button_return.Location = new System.Drawing.Point(188, 262);
            this.button_return.Margin = new System.Windows.Forms.Padding(2);
            this.button_return.Name = "button_return";
            this.button_return.Size = new System.Drawing.Size(92, 18);
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
            this.fjlxDataGridViewTextBoxColumn,
            this.fjIDDataGridViewTextBoxColumn,
            this.fjjgDataGridViewTextBoxColumn});
            this.dataGridView1.DataSource = this.roomBindingSource;
            this.dataGridView1.Location = new System.Drawing.Point(295, 77);
            this.dataGridView1.Margin = new System.Windows.Forms.Padding(2);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.ReadOnly = true;
            this.dataGridView1.RowTemplate.Height = 27;
            this.dataGridView1.Size = new System.Drawing.Size(344, 162);
            this.dataGridView1.TabIndex = 11;
            // 
            // fjlxDataGridViewTextBoxColumn
            // 
            this.fjlxDataGridViewTextBoxColumn.DataPropertyName = "Fjlx";
            this.fjlxDataGridViewTextBoxColumn.HeaderText = "Fjlx";
            this.fjlxDataGridViewTextBoxColumn.Name = "fjlxDataGridViewTextBoxColumn";
            this.fjlxDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // fjIDDataGridViewTextBoxColumn
            // 
            this.fjIDDataGridViewTextBoxColumn.DataPropertyName = "FjID";
            this.fjIDDataGridViewTextBoxColumn.HeaderText = "FjID";
            this.fjIDDataGridViewTextBoxColumn.Name = "fjIDDataGridViewTextBoxColumn";
            this.fjIDDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // fjjgDataGridViewTextBoxColumn
            // 
            this.fjjgDataGridViewTextBoxColumn.DataPropertyName = "Fjjg";
            this.fjjgDataGridViewTextBoxColumn.HeaderText = "Fjjg";
            this.fjjgDataGridViewTextBoxColumn.Name = "fjjgDataGridViewTextBoxColumn";
            this.fjjgDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // roomBindingSource
            // 
            this.roomBindingSource.DataMember = "Room";
            this.roomBindingSource.DataSource = this.hotalDataSet;
            // 
            // hotalDataSet
            // 
            this.hotalDataSet.DataSetName = "HotalDataSet";
            this.hotalDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(398, 26);
            this.label6.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(53, 12);
            this.label6.TabIndex = 12;
            this.label6.Text = "可用房间";
            // 
            // roomTableAdapter
            // 
            this.roomTableAdapter.ClearBeforeFill = true;
            // 
            // Checknow
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(690, 307);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.button_return);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.textBox_intime);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.textBox_fjID);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.textBox_kufuCall);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.textBox_kehuName);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Margin = new System.Windows.Forms.Padding(2);
            this.Name = "Checknow";
            this.Text = "Checknow";
            this.Load += new System.EventHandler(this.Checknow_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.roomBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.hotalDataSet)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox textBox_kehuName;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox textBox_kufuCall;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox textBox_fjID;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox textBox_intime;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button button_return;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.Label label6;
        private HotalDataSet hotalDataSet;
        private System.Windows.Forms.BindingSource roomBindingSource;
        private HotalDataSetTableAdapters.RoomTableAdapter roomTableAdapter;
        private System.Windows.Forms.DataGridViewTextBoxColumn fjlxDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn fjIDDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn fjjgDataGridViewTextBoxColumn;
    }
}