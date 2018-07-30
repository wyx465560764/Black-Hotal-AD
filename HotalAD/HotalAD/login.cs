using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;

namespace HotalAD
{
    public partial class login : Form
    {
        public login()
        {
            InitializeComponent();
        }

        private void button_login_Click(object sender, EventArgs e)
        {
            if (maskedTextBox1.Text.Length != 0)
            {
                SqlConnection sqlCon = new SqlConnection();
                sqlCon.ConnectionString = "Data Source=ADMIN;database=Hotal;Trusted_Connection=Yes;Connect Timeout=90";
                sqlCon.Open();
                SqlCommand sqlCmd = sqlCon.CreateCommand();
                SqlCommand cmd = new SqlCommand();
                cmd.Connection = sqlCon;
                sqlCmd.CommandText = "SELECT * FROM login WHERE mm='" + maskedTextBox1.Text + "'";
                SqlDataReader sqlr = sqlCmd.ExecuteReader();
                if (sqlr.Read())
                {
                    MessageBox.Show("登陆成功！");
                    sqlCon.Close();
                    Form1 fm = new Form1();
                    this.Hide();
                    fm.Show();
                }
                else
                {
                    MessageBox.Show("密码错误！请重新输入！");
                    maskedTextBox1.Text = string.Empty;
                }
            }
            else
            {
                MessageBox.Show("密码不能为空！");
            }
            
        }
    }
}
