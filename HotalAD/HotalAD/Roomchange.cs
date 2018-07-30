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
    public partial class Roomchange : Form
    {
        public Roomchange()
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
            string b = textBox_price.Text,c=comboBox1.SelectedItem.ToString();
            SqlConnection sqlCon = new SqlConnection();
            sqlCon.ConnectionString = "Data Source=ADMIN;database=Hotal;Trusted_Connection=Yes;Connect Timeout=90";
            sqlCon.Open();
            SqlCommand sqlCmd = sqlCon.CreateCommand();
            SqlCommand cmd = new SqlCommand();
            cmd.Connection = sqlCon;
            sqlCmd.CommandText = "UPDATE Room SET Fjjg=" + b + " WHERE Fjlx='"+c+"'";
            sqlCmd.ExecuteNonQuery();
            sqlCon.Close();
            this.Hide();
        }
    }
}
