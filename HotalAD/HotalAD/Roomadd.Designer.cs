namespace HotalAD
{
    partial class Roomadd
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
            this.label1 = new System.Windows.Forms.Label();
            this.textBox_fjID = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.button1 = new System.Windows.Forms.Button();
            this.button_return = new System.Windows.Forms.Button();
            this.textBox_fjlx = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.textBox_price = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(16, 40);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(97, 15);
            this.label1.TabIndex = 0;
            this.label1.Text = "新建房间编号";
            // 
            // textBox_fjID
            // 
            this.textBox_fjID.Location = new System.Drawing.Point(127, 36);
            this.textBox_fjID.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.textBox_fjID.Name = "textBox_fjID";
            this.textBox_fjID.Size = new System.Drawing.Size(167, 25);
            this.textBox_fjID.TabIndex = 1;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(16, 91);
            this.label2.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(97, 15);
            this.label2.TabIndex = 2;
            this.label2.Text = "新建房间类型";
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(29, 199);
            this.button1.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(100, 29);
            this.button1.TabIndex = 4;
            this.button1.Text = "完成新建";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // button_return
            // 
            this.button_return.Location = new System.Drawing.Point(181, 199);
            this.button_return.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.button_return.Name = "button_return";
            this.button_return.Size = new System.Drawing.Size(100, 29);
            this.button_return.TabIndex = 5;
            this.button_return.Text = "返回上一层";
            this.button_return.UseVisualStyleBackColor = true;
            this.button_return.Click += new System.EventHandler(this.button_return_Click);
            // 
            // textBox_fjlx
            // 
            this.textBox_fjlx.Location = new System.Drawing.Point(128, 81);
            this.textBox_fjlx.Name = "textBox_fjlx";
            this.textBox_fjlx.Size = new System.Drawing.Size(167, 25);
            this.textBox_fjlx.TabIndex = 6;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(16, 144);
            this.label3.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(97, 15);
            this.label3.TabIndex = 2;
            this.label3.Text = "新建房间价格";
            // 
            // textBox_price
            // 
            this.textBox_price.Location = new System.Drawing.Point(128, 134);
            this.textBox_price.Name = "textBox_price";
            this.textBox_price.Size = new System.Drawing.Size(167, 25);
            this.textBox_price.TabIndex = 6;
            // 
            // Roomadd
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(348, 279);
            this.Controls.Add(this.textBox_price);
            this.Controls.Add(this.textBox_fjlx);
            this.Controls.Add(this.button_return);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.textBox_fjID);
            this.Controls.Add(this.label1);
            this.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.Name = "Roomadd";
            this.Text = "Roomadd";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox textBox_fjID;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button button_return;
        private System.Windows.Forms.TextBox textBox_fjlx;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox textBox_price;
    }
}