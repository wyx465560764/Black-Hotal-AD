namespace HotalAD
{
    partial class Password
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
            this.textBox_old = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.textBox_new = new System.Windows.Forms.TextBox();
            this.button1 = new System.Windows.Forms.Button();
            this.button_return = new System.Windows.Forms.Button();
            this.label3 = new System.Windows.Forms.Label();
            this.textBox_again = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(22, 59);
            this.label1.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(41, 12);
            this.label1.TabIndex = 0;
            this.label1.Text = "原密码";
            // 
            // textBox_old
            // 
            this.textBox_old.Location = new System.Drawing.Point(65, 57);
            this.textBox_old.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.textBox_old.Name = "textBox_old";
            this.textBox_old.Size = new System.Drawing.Size(121, 21);
            this.textBox_old.TabIndex = 1;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(22, 122);
            this.label2.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(41, 12);
            this.label2.TabIndex = 2;
            this.label2.Text = "新密码";
            // 
            // textBox_new
            // 
            this.textBox_new.Location = new System.Drawing.Point(65, 119);
            this.textBox_new.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.textBox_new.Name = "textBox_new";
            this.textBox_new.Size = new System.Drawing.Size(121, 21);
            this.textBox_new.TabIndex = 3;
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(24, 235);
            this.button1.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(76, 25);
            this.button1.TabIndex = 4;
            this.button1.Text = "确认更改";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // button_return
            // 
            this.button_return.Location = new System.Drawing.Point(124, 235);
            this.button_return.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.button_return.Name = "button_return";
            this.button_return.Size = new System.Drawing.Size(76, 25);
            this.button_return.TabIndex = 5;
            this.button_return.Text = "返回上一层";
            this.button_return.UseVisualStyleBackColor = true;
            this.button_return.Click += new System.EventHandler(this.button_return_Click);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(10, 182);
            this.label3.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(53, 12);
            this.label3.TabIndex = 6;
            this.label3.Text = "确认密码";
            // 
            // textBox_again
            // 
            this.textBox_again.Location = new System.Drawing.Point(65, 179);
            this.textBox_again.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.textBox_again.Name = "textBox_again";
            this.textBox_again.Size = new System.Drawing.Size(121, 21);
            this.textBox_again.TabIndex = 7;
            // 
            // Password
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(225, 271);
            this.Controls.Add(this.textBox_again);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.button_return);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.textBox_new);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.textBox_old);
            this.Controls.Add(this.label1);
            this.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.Name = "Password";
            this.Text = "Password";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox textBox_old;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox textBox_new;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button button_return;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox textBox_again;
    }
}