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
    public partial class Request : Form
    {
        public Request()
        {
            InitializeComponent();
        }

        private void button_return_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void Request_Load(object sender, EventArgs e)
        {
            // TODO: 这行代码将数据加载到表“hotalDataSet.Qingqiu”中。您可以根据需要移动或删除它。
            this.qingqiuTableAdapter.Fill(this.hotalDataSet.Qingqiu);
            // TODO:  这行代码将数据加载到表“hotalDataSet.Anpai”中。您可以根据需要移动或删除它。
            this.anpaiTableAdapter.Fill(this.hotalDataSet.Anpai);
            // TODO:  这行代码将数据加载到表“hotalDataSet.Qingqiu”中。您可以根据需要移动或删除它。
            this.qingqiuTableAdapter.Fill(this.hotalDataSet.Qingqiu);
            // TODO:  这行代码将数据加载到表“hotalDataSet.Yuangong”中。您可以根据需要移动或删除它。
            this.yuangongTableAdapter.Fill(this.hotalDataSet.Yuangong);
            SqlConnection sqlCon = new SqlConnection();
            sqlCon.ConnectionString = "Data Source=ADMIN;database=Hotal;Trusted_Connection=Yes;Connect Timeout=90";
            sqlCon.Open();
            SqlCommand sqlCmd = sqlCon.CreateCommand();
            SqlCommand cmd = new SqlCommand();
            cmd.Connection = sqlCon;
            sqlCmd.CommandText = "SELECT * FROM Yuangong WHERE Ygzt='空闲'";
            SqlDataReader readerdata = sqlCmd.ExecuteReader();
            DataTable dt = new DataTable();
            DataSet dateset = new DataSet();
            dt.Load(readerdata);
            readerdata.Close();
            dataGridView2.DataSource = dt;
            sqlCon.Close();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            string k = textBox_ygid2.Text;
            SqlConnection sqlCon = new SqlConnection();
            sqlCon.ConnectionString = "Data Source=ADMIN;database=Hotal;Trusted_Connection=Yes;Connect Timeout=90";
            sqlCon.Open();
            SqlCommand sqlCmd = sqlCon.CreateCommand();
            SqlCommand cmd = new SqlCommand();
            cmd.Connection = sqlCon;
            sqlCmd.CommandText = "delete from Qingqiu where YgID=" + k +";UPDATE Yuangong set Ygzt='空闲' WHERE YgID="+k+"";
            sqlCmd.CommandText = "select * from Anpai" ;
            SqlDataReader readerdata = sqlCmd.ExecuteReader();
            DataTable dt = new DataTable();
            DataSet dateset = new DataSet();
            dt.Load(readerdata);
            readerdata.Close();
            dataGridView3.DataSource = dt;
            sqlCmd.CommandText = "select * from Qingqiu" ;
            SqlDataReader readerdata1 = sqlCmd.ExecuteReader();
            DataTable dt1 = new DataTable();
            DataSet dateset1 = new DataSet();
            dt1.Load(readerdata1);
            readerdata1.Close();
            dataGridView1.DataSource = dt;
            sqlCon.Close();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            string a = textBox1_room.Text;
            string b = textBox_yuangong.Text;
            string c = null;
            SqlConnection sqlCon = new SqlConnection();
            sqlCon.ConnectionString = "Data Source=ADMIN;database=Hotal;Trusted_Connection=Yes;Connect Timeout=90";
            sqlCon.Open();
            SqlCommand sqlCmd = sqlCon.CreateCommand();
            SqlCommand cmd = new SqlCommand();
            cmd.Connection = sqlCon;
            sqlCmd.CommandText = "select Qingqiu from Qingqiu where FjID=" + a + "";
            SqlDataReader reader = sqlCmd.ExecuteReader();
            while (reader.Read() == true)
            {
                c = reader["Qingqiu"].ToString();
                break;
            }
            reader.Close();
            sqlCmd.CommandText = "delete from Qingqiu where FjID=" + a + ";insert into Anpai values('正在进行'," + a+",'"+b+"','"+c+"');select * from Anpai";
            SqlDataReader readerdata = sqlCmd.ExecuteReader();
            DataTable dt = new DataTable();
            DataSet dateset = new DataSet();
            dt.Load(readerdata);
            readerdata.Close();
            dataGridView3.DataSource = dt;
            sqlCmd.CommandText = "update Yuangong set Ygzt='忙碌'where YgID='"+b+"';SELECT * FROM Yuangong WHERE Ygzt='空闲'";
            SqlDataReader readerdata01 = sqlCmd.ExecuteReader();
            DataTable dt01 = new DataTable();
            DataSet dateset01 = new DataSet();
            dt01.Load(readerdata01);
            readerdata01.Close();
            dataGridView2.DataSource = dt01;
            sqlCon.Close();
        }

        private void dataGridView3_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void textBox1_room_TextChanged(object sender, EventArgs e)
        {

        }

        private void dataGridView2_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void textBox_ygid2_TextChanged(object sender, EventArgs e)
        {

        }

        private void label3_Click(object sender, EventArgs e)
        {

        }
    }
}
