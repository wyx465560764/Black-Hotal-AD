namespace HotalAD
{
    partial class Search
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
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.roomBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.hotalDataSet = new HotalAD.HotalDataSet();
            this.label1 = new System.Windows.Forms.Label();
            this.button_return = new System.Windows.Forms.Button();
            this.roomTableAdapter = new HotalAD.HotalDataSetTableAdapters.RoomTableAdapter();
            this.fjlxDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.fjIDDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.fjztDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.fjjgDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.roomBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.hotalDataSet)).BeginInit();
            this.SuspendLayout();
            // 
            // dataGridView1
            // 
            this.dataGridView1.AutoGenerateColumns = false;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.fjlxDataGridViewTextBoxColumn,
            this.fjIDDataGridViewTextBoxColumn,
            this.fjztDataGridViewTextBoxColumn,
            this.fjjgDataGridViewTextBoxColumn});
            this.dataGridView1.DataSource = this.roomBindingSource;
            this.dataGridView1.Location = new System.Drawing.Point(24, 51);
            this.dataGridView1.Margin = new System.Windows.Forms.Padding(2);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.ReadOnly = true;
            this.dataGridView1.RowTemplate.Height = 27;
            this.dataGridView1.Size = new System.Drawing.Size(443, 208);
            this.dataGridView1.TabIndex = 0;
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
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("宋体", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.label1.Location = new System.Drawing.Point(232, 37);
            this.label1.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(44, 12);
            this.label1.TabIndex = 1;
            this.label1.Text = "房间表";
            // 
            // button_return
            // 
            this.button_return.Location = new System.Drawing.Point(216, 263);
            this.button_return.Margin = new System.Windows.Forms.Padding(2);
            this.button_return.Name = "button_return";
            this.button_return.Size = new System.Drawing.Size(78, 18);
            this.button_return.TabIndex = 2;
            this.button_return.Text = "返回上一层";
            this.button_return.UseVisualStyleBackColor = true;
            this.button_return.Click += new System.EventHandler(this.button_return_Click);
            // 
            // roomTableAdapter
            // 
            this.roomTableAdapter.ClearBeforeFill = true;
            // 
            // fjlxDataGridViewTextBoxColumn
            // 
            this.fjlxDataGridViewTextBoxColumn.DataPropertyName = "Fjlx";
            this.fjlxDataGridViewTextBoxColumn.HeaderText = "房间类型";
            this.fjlxDataGridViewTextBoxColumn.Name = "fjlxDataGridViewTextBoxColumn";
            this.fjlxDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // fjIDDataGridViewTextBoxColumn
            // 
            this.fjIDDataGridViewTextBoxColumn.DataPropertyName = "FjID";
            this.fjIDDataGridViewTextBoxColumn.HeaderText = "房间号";
            this.fjIDDataGridViewTextBoxColumn.Name = "fjIDDataGridViewTextBoxColumn";
            this.fjIDDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // fjztDataGridViewTextBoxColumn
            // 
            this.fjztDataGridViewTextBoxColumn.DataPropertyName = "Fjzt";
            this.fjztDataGridViewTextBoxColumn.HeaderText = "房间状态";
            this.fjztDataGridViewTextBoxColumn.Name = "fjztDataGridViewTextBoxColumn";
            this.fjztDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // fjjgDataGridViewTextBoxColumn
            // 
            this.fjjgDataGridViewTextBoxColumn.DataPropertyName = "Fjjg";
            this.fjjgDataGridViewTextBoxColumn.HeaderText = "房间价格";
            this.fjjgDataGridViewTextBoxColumn.Name = "fjjgDataGridViewTextBoxColumn";
            this.fjjgDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // Search
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(509, 288);
            this.Controls.Add(this.button_return);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.dataGridView1);
            this.Margin = new System.Windows.Forms.Padding(2);
            this.Name = "Search";
            this.Text = "Search";
            this.Load += new System.EventHandler(this.Search_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.roomBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.hotalDataSet)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button button_return;
        private HotalDataSet hotalDataSet;
        private System.Windows.Forms.BindingSource roomBindingSource;
        private HotalDataSetTableAdapters.RoomTableAdapter roomTableAdapter;
        private System.Windows.Forms.DataGridViewTextBoxColumn fjlxDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn fjIDDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn fjztDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn fjjgDataGridViewTextBoxColumn;
    }
}