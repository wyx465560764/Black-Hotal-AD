namespace HotalAD
{
    partial class room
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
            this.button_roomadd = new System.Windows.Forms.Button();
            this.button_change = new System.Windows.Forms.Button();
            this.button_delete = new System.Windows.Forms.Button();
            this.button_return = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // button_roomadd
            // 
            this.button_roomadd.Location = new System.Drawing.Point(12, 38);
            this.button_roomadd.Name = "button_roomadd";
            this.button_roomadd.Size = new System.Drawing.Size(92, 54);
            this.button_roomadd.TabIndex = 0;
            this.button_roomadd.Text = "添加房间";
            this.button_roomadd.UseVisualStyleBackColor = true;
            this.button_roomadd.Click += new System.EventHandler(this.button_roomadd_Click);
            // 
            // button_change
            // 
            this.button_change.Location = new System.Drawing.Point(120, 38);
            this.button_change.Name = "button_change";
            this.button_change.Size = new System.Drawing.Size(94, 54);
            this.button_change.TabIndex = 1;
            this.button_change.Text = "编辑现有房间";
            this.button_change.UseVisualStyleBackColor = true;
            this.button_change.Click += new System.EventHandler(this.button_change_Click);
            // 
            // button_delete
            // 
            this.button_delete.Location = new System.Drawing.Point(229, 38);
            this.button_delete.Name = "button_delete";
            this.button_delete.Size = new System.Drawing.Size(92, 54);
            this.button_delete.TabIndex = 2;
            this.button_delete.Text = "删除房间";
            this.button_delete.UseVisualStyleBackColor = true;
            this.button_delete.Click += new System.EventHandler(this.button_delete_Click);
            // 
            // button_return
            // 
            this.button_return.Location = new System.Drawing.Point(129, 121);
            this.button_return.Name = "button_return";
            this.button_return.Size = new System.Drawing.Size(75, 23);
            this.button_return.TabIndex = 3;
            this.button_return.Text = "返回上一层";
            this.button_return.UseVisualStyleBackColor = true;
            this.button_return.Click += new System.EventHandler(this.button_return_Click);
            // 
            // room
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(332, 156);
            this.Controls.Add(this.button_return);
            this.Controls.Add(this.button_delete);
            this.Controls.Add(this.button_change);
            this.Controls.Add(this.button_roomadd);
            this.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.Name = "room";
            this.Text = "room";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button button_roomadd;
        private System.Windows.Forms.Button button_change;
        private System.Windows.Forms.Button button_delete;
        private System.Windows.Forms.Button button_return;
    }
}