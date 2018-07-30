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
    public partial class Checknet : Form
    {
        public Checknet()
        {
            InitializeComponent();
        }

        internal void show()
        {
            throw new NotImplementedException();
        }

        private void button_return_Click(object sender, EventArgs e)
        {
            Checkchoice checkchoice=new Checkchoice();
            checkchoice.Show();
            Close();
        }

        private void Checknet_Load(object sender, EventArgs e)
        {
            // TODO: 这行代码将数据加载到表“hotalDataSet1.kehu”中。您可以根据需要移动或删除它。
            this.kehuTableAdapter1.Fill(this.hotalDataSet1.kehu);
            // TODO: 这行代码将数据加载到表“hotalDataSet1.kehuruzhu”中。您可以根据需要移动或删除它。

            // TODO: 这行代码将数据加载到表“hotalDataSet1.Room”中。您可以根据需要移动或删除它。
            this.roomTableAdapter1.Fill(this.hotalDataSet1.Room);
            // TODO: 这行代码将数据加载到表“hotalDataSet1.kehu”中。您可以根据需要移动或删除它。
            this.kehuTableAdapter1.Fill(this.hotalDataSet1.kehu);
            // TODO: 这行代码将数据加载到表“hotalDataSet.Room”中。您可以根据需要移动或删除它。

            // TODO: 这行代码将数据加载到表“hotalDataSet.kuhuruzhu”中。您可以根据需要移动或删除它。


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
            dataGridView2.DataSource = dt;
            sqlCon.Close();
            
           
       
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (textBox_kehu.Text.Length == 0)
            {
                MessageBox.Show("客户姓名不能为空，请重新输入！");
                return;
            }
            else if (textBox_sfz.Text.Length == 0)
            {
                MessageBox.Show("客户身份证号不能为空，请重新输入！");
                return;
            }
            else if (textBox_fanjian.Text.Length == 0)
            {
                MessageBox.Show("房间号不能为空，请重新输入！");
                return;
            }
            else
            {

                SqlConnection sqlCon = new SqlConnection();
                sqlCon.ConnectionString = "Data Source=ADMIN;database=Hotal;Trusted_Connection=Yes;Connect Timeout=90";
                sqlCon.Open();

                SqlCommand sqlCmd = sqlCon.CreateCommand();
                SqlCommand cmd = new SqlCommand();
                cmd.Connection = sqlCon;
                sqlCmd.CommandText = "SELECT * FROM Room WHERE FjID='" + textBox_fanjian.Text + "'";
                SqlDataReader reader = sqlCmd.ExecuteReader();
                string g = null;
                while (reader.Read() == true)
                {
                    g = reader["Fjzt"].ToString();
                    break;
                }
                if (g == "空闲")
                {
                    reader.Close();
                    sqlCmd.CommandText = "SELECT * FROM kehu WHERE xm='" + textBox_kehu.Text + "'";
                    SqlDataReader reader01 = sqlCmd.ExecuteReader();
                    string h = null, l = null;
                    while (reader01.Read() == true)
                    {
                        h = reader01["rzts"].ToString();
                        break;
                    }
                    reader01.Close();
                    sqlCmd.CommandText = "SELECT * FROM Room WHERE FjID='" + textBox_fanjian.Text + "'";
                    SqlDataReader reader02 = sqlCmd.ExecuteReader();
                    while (reader02.Read() == true)
                    {
                        l = reader02["Fjjg"].ToString();
                        break;
                    }
                    reader02.Close();
                    double hb = double.Parse(h) * double.Parse(l);
                    sqlCmd.CommandText = "INSERT INTO kehuruzhu values('" + textBox_kehu.Text + "'," + textBox_sfz.Text + "," + textBox_fanjian.Text + "," + h + "," + hb + ")";
                    sqlCmd.CommandText= "UPDATE Room SET Fjzt='已入住' WHERE FjID='" + textBox_fanjian.Text + "'";
                    sqlCmd.CommandText = "SELECT * FROM Room WHERE Fjzt='空闲'";
                    SqlDataReader readerdata = sqlCmd.ExecuteReader();
                    DataTable dt = new DataTable();
                    DataSet dateset = new DataSet();
                    dt.Load(readerdata);
                    readerdata.Close();
                    dataGridView2.DataSource = dt;
                    sqlCmd.ExecuteNonQuery();
                    sqlCon.Close();
                    this.Hide();
                    MessageBox.Show("订房成功！");
                }
                else
                {
                    MessageBox.Show("该房间目前不是空闲！");
                    textBox_fanjian.Text = string.Empty;
                }


            }
        }

        private void dataGridView2_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void textBox_fanjian_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
