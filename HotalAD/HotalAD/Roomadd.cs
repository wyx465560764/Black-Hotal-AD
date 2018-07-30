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
    public partial class Roomadd : Form
    {
        public Roomadd()
        {
            InitializeComponent();
        }

        private void button_return_Click(object sender, EventArgs e)
        {
            room ROOM = new room();
            ROOM.Show();
            Close();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            string a = textBox_fjID.Text, b = textBox_fjlx.Text, c = textBox_price.Text;
            SqlConnection sqlCon = new SqlConnection();
            sqlCon.ConnectionString = "Data Source=ADMIN;database=Hotal;Trusted_Connection=Yes;Connect Timeout=90";
            sqlCon.Open();
            SqlCommand sqlCmd = sqlCon.CreateCommand();
            SqlCommand cmd = new SqlCommand();
            cmd.Connection = sqlCon;
            sqlCmd.CommandText = "INSERT INTO Room values('" + b + "'," + a + ",'空闲'," + c + ")";
            DataSet DataSet1 = new DataSet();
            sqlCmd.ExecuteNonQuery();
            sqlCon.Close();
            MessageBox.Show("房间添加完成！");
            this.Hide();
        }
    }
}
