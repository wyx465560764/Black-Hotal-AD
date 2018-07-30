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
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button_check_Click(object sender, EventArgs e)
        {
            Checkchoice checkchoice = new Checkchoice();
            checkchoice.Show();

        }

        private void button_change_Click(object sender, EventArgs e)
        {
            Change change = new Change();
            change.Show();

        }

        private void button_checkout_Click(object sender, EventArgs e)
        {
            Checkout checkout = new Checkout();
            checkout.Show();
 
        }

        private void button_search_Click(object sender, EventArgs e)
        {
            Search search = new Search();
            search.Show();

        }

        private void button_request_Click(object sender, EventArgs e)
        {
            Request request = new Request();
            request.Show();

        }

        private void button_password_Click(object sender, EventArgs e)
        {
            Password password = new Password();
            password.Show();

        }

        private void Form1_Load(object sender, EventArgs e)
        {
            SqlConnection sqlCon = new SqlConnection();
            sqlCon.ConnectionString = "Data Source=ADMIN;database=Hotal;Trusted_Connection=Yes;Connect Timeout=90";
            sqlCon.Open();

            SqlCommand sqlCmd = sqlCon.CreateCommand();
            SqlCommand cmd = new SqlCommand();
            cmd.Connection = sqlCon;
            sqlCmd.CommandText = "SELECT * FROM Room WHERE Fjlx='单间'";
            SqlDataReader reader = sqlCmd.ExecuteReader();
            while (reader.Read() == true)
            {
                label001.Text = reader["Fjjg"].ToString();
                break;
            }
            reader.Close();
            sqlCmd.CommandText = "SELECT * FROM Room WHERE Fjlx='标准间'";
            SqlDataReader reader2 = sqlCmd.ExecuteReader();
            while (reader2.Read() == true)
            {
                label002.Text = reader2["Fjjg"].ToString();
                break;
            }
            reader2.Close();
            sqlCmd.CommandText = "SELECT * FROM Room WHERE Fjlx='豪华套间'";
            SqlDataReader reader3 = sqlCmd.ExecuteReader();
            while (reader3.Read() == true)
            {
                label003.Text = reader3["Fjjg"].ToString();
                break;
            }
            reader3.Close();
            sqlCmd.CommandText = "SELECT * FROM Room WHERE Fjlx='总统套房'";
            SqlDataReader reader4 = sqlCmd.ExecuteReader();
            while (reader4.Read() == true)
            {
                label004.Text = reader4["Fjjg"].ToString();
                break;
            }
            reader4.Close();
            sqlCon.Close();
        }

        private void button_room_Click(object sender, EventArgs e)
        {
            room ROOM = new room();
            ROOM.Show();
   
        }
    }
}
