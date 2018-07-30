using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace HotalAD
{
    public partial class Checkchoice : Form
    {
        public Checkchoice()
        {
            InitializeComponent();
        }

        private void button_checknet_Click(object sender, EventArgs e)
        {
            Checknet checknet = new Checknet();
            checknet.Show();
            this.Hide();
        }

        private void button_checknow_Click(object sender, EventArgs e)
        {
            Checknow checknow = new Checknow();
            checknow.Show();
            this.Hide();
        }

        private void button_return_Click(object sender, EventArgs e)
        {
            Close();
        }
    }
}
