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

    public partial class Password : Form
    {
        public Password()
        {
            InitializeComponent();
        }

        private void button_return_Click(object sender, EventArgs e)
        {

            Close();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (textBox_old.Text.Length != 0)
            {

                SqlConnection sqlCon = new SqlConnection();
                sqlCon.ConnectionString = "Data Source=ADMIN;database=Hotal;Trusted_Connection=Yes;Connect Timeout=90";
                sqlCon.Open();
                SqlCommand sqlCmd = sqlCon.CreateCommand();
                SqlCommand cmd = new SqlCommand();
                cmd.Connection = sqlCon;
                sqlCmd.CommandText = "SELECT * FROM login ;";
                SqlDataReader sqlr = sqlCmd.ExecuteReader();
                string c = null;
                while (sqlr.Read() == true)
                {
                    c = sqlr["mm"].ToString();
                    break;
                }
                sqlr.Close();
                if (c==textBox_old.Text)
                {
                    if (textBox_new.Text == textBox_again.Text)
                    {
                        sqlCmd.CommandText = "UPDATE login SET mm="+textBox_new.Text;
                        int i = sqlCmd.ExecuteNonQuery();
                        MessageBox.Show("修改成功！");
                        this.Hide();
                    }
                    else
                    {
                        MessageBox.Show("确认密码与新密码不对！");
                        textBox_again.Text = string.Empty;
                    }
                }
                else
                {
                    MessageBox.Show("原密码不对！");
                    textBox_old.Text = string.Empty;
                }
                sqlCon.Close();
            }
            else
            {
                MessageBox.Show("原密码不能为空！");
            }
        }
    }
}

