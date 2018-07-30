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
    public partial class Change : Form
    {
        public Change()
        {
            InitializeComponent();
        }

        private void button_return_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            string b = textBox_old.Text, c = textBox_new.Text;
            SqlConnection sqlCon = new SqlConnection();
            sqlCon.ConnectionString = "Data Source=ADMIN;database=Hotal;Trusted_Connection=Yes;Connect Timeout=90";
            sqlCon.Open();
            if (textBox_old.Text.Length != 0)
            {
                if (textBox_new.Text.Length != 0)
                {
                    SqlCommand sqlCmd = sqlCon.CreateCommand();
                    SqlCommand cmd = new SqlCommand();
                    cmd.Connection = sqlCon;
                    sqlCmd.CommandText = "UPDATE kehuruzhu SET fjID=" + c + " WHERE fjID='" + b + "';UPDATE Room SET Fjzt='已入住' WHERE FjID=" + c + ";UPDATE Room SET Fjzt='空闲' WHERE FjID=" + b;
                    sqlCmd.ExecuteNonQuery();
                    sqlCon.Close();
                    this.Hide();
                }
                else
                {
                    MessageBox.Show("新换的房间号不能为空！");
                }
            }
            else
            {
                MessageBox.Show("旧的房间号不能为空！");
            }
        }
    }
}
