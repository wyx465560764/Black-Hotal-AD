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
    public partial class Checkout : Form
    {
        public Checkout()
        {
            InitializeComponent();
        }

        private void button_return_Click(object sender, EventArgs e)
        {
           
            Close();
        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox4_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox3_TextChanged(object sender, EventArgs e)
        {

        }

        private void label4_Click(object sender, EventArgs e)
        {

        }

        private void label5_Click(object sender, EventArgs e)
        {

        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void Checkout_Load(object sender, EventArgs e)
        {
            // TODO:  这行代码将数据加载到表“hotalDataSet.kehu”中。您可以根据需要移动或删除它。
            this.kehuTableAdapter.Fill(this.hotalDataSet.kehu);

        }

        private void button1_Click(object sender, EventArgs e)
        {
            SqlConnection sqlCon = new SqlConnection();
            sqlCon.ConnectionString = "Data Source=ADMIN;database=Hotal;Trusted_Connection=Yes;Connect Timeout=90";
            sqlCon.Open();
            SqlCommand sqlCmd = sqlCon.CreateCommand();
            SqlCommand cmd = new SqlCommand();
            cmd.Connection = sqlCon;
            int a = Convert.ToInt32(textBox_number.Text);
            sqlCmd.CommandText = "UPDATE Room SET Fjzt='空闲' WHERE FjID="+a;
            MessageBox.Show("退房成功！");
            sqlCon.Close();
            this.Hide();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            
            SqlConnection sqlCon = new SqlConnection();
            sqlCon.ConnectionString = "Data Source=ADMIN;database=Hotal;Trusted_Connection=Yes;Connect Timeout=90";
            sqlCon.Open();
            SqlCommand sqlCmd = sqlCon.CreateCommand();
            SqlCommand cmd = new SqlCommand();
            cmd.Connection = sqlCon;
            sqlCmd.CommandText = "SELECT * FROM kehuruzhu WHERE fjID='" + textBox_number.Text + "'";
            SqlDataReader readerdata = sqlCmd.ExecuteReader();
            DataTable dt = new DataTable();
            DataSet dateset = new DataSet();
            dt.Load(readerdata);
            readerdata.Close();
            dataGridView1.DataSource = dt;
            sqlCon.Close();
            //textBox_money.Text
        }
    }
}
