namespace HotalAD
{
    partial class Checkchoice
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
            this.button_checknet = new System.Windows.Forms.Button();
            this.button_checknow = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.button_return = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // button_checknet
            // 
            this.button_checknet.ForeColor = System.Drawing.SystemColors.ControlText;
            this.button_checknet.Location = new System.Drawing.Point(38, 78);
            this.button_checknet.Name = "button_checknet";
            this.button_checknet.Size = new System.Drawing.Size(120, 53);
            this.button_checknet.TabIndex = 0;
            this.button_checknet.Text = "互联网预订入住";
            this.button_checknet.UseVisualStyleBackColor = true;
            this.button_checknet.Click += new System.EventHandler(this.button_checknet_Click);
            // 
            // button_checknow
            // 
            this.button_checknow.Location = new System.Drawing.Point(191, 78);
            this.button_checknow.Name = "button_checknow";
            this.button_checknow.Size = new System.Drawing.Size(120, 53);
            this.button_checknow.TabIndex = 1;
            this.button_checknow.Text = "现场预订入住";
            this.button_checknow.UseVisualStyleBackColor = true;
            this.button_checknow.Click += new System.EventHandler(this.button_checknow_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(110, 34);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(112, 15);
            this.label1.TabIndex = 2;
            this.label1.Text = "请选择预订方式";
            // 
            // button_return
            // 
            this.button_return.Location = new System.Drawing.Point(133, 169);
            this.button_return.Name = "button_return";
            this.button_return.Size = new System.Drawing.Size(75, 23);
            this.button_return.TabIndex = 3;
            this.button_return.Text = "返回首页";
            this.button_return.UseVisualStyleBackColor = true;
            this.button_return.Click += new System.EventHandler(this.button_return_Click);
            // 
            // Checkchoice
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(340, 228);
            this.Controls.Add(this.button_return);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.button_checknow);
            this.Controls.Add(this.button_checknet);
            this.Name = "Checkchoice";
            this.Text = "Checkchoice";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button button_checknet;
        private System.Windows.Forms.Button button_checknow;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button button_return;
    }
}