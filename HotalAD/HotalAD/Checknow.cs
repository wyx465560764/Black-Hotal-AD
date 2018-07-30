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
    public partial class Checknow : Form
    {
        public Checknow()
        {
            InitializeComponent();
        }

        private void button_return_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void Checknow_Load(object sender, EventArgs e)
        {
            // TODO: 这行代码将数据加载到表“hotalDataSet.Room”中。您可以根据需要移动或删除它。
            this.roomTableAdapter.Fill(this.hotalDataSet.Room);
            // TODO:  这行代码将数据加载到表“hotalDataSet.Room”中。您可以根据需要移动或删除它。
            this.roomTableAdapter.Fill(this.hotalDataSet.Room);
                SqlConnection sqlCon = new SqlConnection();
                sqlCon.ConnectionString = "Data Source=ADMIN;database=Hotal;Trusted_Connection=Yes;Connect Timeout=90";
                sqlCon.Open();
                SqlCommand sqlCmd = sqlCon.CreateCommand();
                SqlCommand cmd = new SqlCommand();
                cmd.Connection = sqlCon;
                sqlCmd.CommandText = "SELECT * FROM Room WHERE Fjzt='空闲'";
                SqlDataReader readerdata = sqlCmd.ExecuteReader();
                DataTable dt = new DataTable();
                DataSet dateset = new DataSet();
                dt.Load(readerdata);
                readerdata.Close();
                dataGridView1.DataSource = dt;
                sqlCon.Close();
        }

        

        private void button1_Click(object sender, EventArgs e)
        {
            if (textBox_kehuName.Text.Length == 0)
            {
                MessageBox.Show("客户姓名不能为空，请重新输入！");
                return;
            }
            else if (textBox_kufuCall.Text.Length == 0)
            {
                MessageBox.Show("客户身份证号不能为空，请重新输入！");
                return;
            }
            else if (textBox_fjID.Text.Length == 0)
            {
                MessageBox.Show("入住房间不能为空，请重新输入！");
                return;
            }
            else if (textBox_intime.Text.Length == 0)
            {
                MessageBox.Show("入住时间不能为空，请重新输入！");
                return;
            }
            else
            {

                string a = textBox_kehuName.Text, c = textBox_kufuCall.Text, b = textBox_fjID.Text, d = textBox_intime.Text,g=null;
                SqlConnection sqlCon = new SqlConnection();
                sqlCon.ConnectionString = "Data Source=ADMIN;database=Hotal;Trusted_Connection=Yes;Connect Timeout=90";
                sqlCon.Open();

                SqlCommand sqlCmd = sqlCon.CreateCommand();
                SqlCommand cmd = new SqlCommand();
                cmd.Connection = sqlCon;
                sqlCmd.CommandText = "SELECT * FROM Room WHERE FjID='"+b+"'";
                SqlDataReader reader = sqlCmd.ExecuteReader();
                    while (reader.Read() == true)
                    {
                        g = reader["Fjzt"].ToString();
                        break;
                    }
                    if (g == "空闲")
                    {
                        reader.Close();
                        sqlCmd.CommandText = "SELECT * FROM kehu WHERE xm='" + textBox_kehuName.Text + "'";
                        SqlDataReader reader01 = sqlCmd.ExecuteReader();
                        string h = null, l = null;
                        while (reader01.Read() == true)
                        {
                            h = reader01["rzts"].ToString();
                            break;
                        }
                        reader01.Close();
                        sqlCmd.CommandText = "SELECT * FROM Room WHERE FjID='" + textBox_fjID + "'";
                        SqlDataReader reader02 = sqlCmd.ExecuteReader();
                        while (reader02.Read() == true)
                        {
                            l = reader02["Fjjg"].ToString();
                            break;
                        }
                        reader02.Close();
                    double u = double.Parse(h);
                    double j = double.Parse(l);
                    double hb = u * j;
                        sqlCmd.CommandText = "INSERT INTO kehuruzhu values('" + a + "'," + c + "," + b + "," + d + ","+hb+");UPDATE Room SET Fjzt='已入住' WHERE FjID='" + b + "'";
                        sqlCmd.CommandText = "SELECT * FROM Room WHERE Fjzt='空闲'";
                        SqlDataReader readerdata = sqlCmd.ExecuteReader();
                        DataTable dt = new DataTable();
                        DataSet dateset = new DataSet();
                        dt.Load(readerdata);
                        readerdata.Close();
                        dataGridView1.DataSource = dt;
                        sqlCmd.ExecuteNonQuery();
                        sqlCon.Close();
                        this.Hide();
                    MessageBox.Show("订房成功！");
                    }
                    else
                    {
                        MessageBox.Show("该房间目前不是空闲！");
                        textBox_fjID.Text = string.Empty;
                    }
                
            }
        }
    }
}
