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
    public partial class room : Form
    {
        public room()
        {
            InitializeComponent();
        }

        private void button_return_Click(object sender, EventArgs e)
        {
           
            Close();
        }

        private void button_roomadd_Click(object sender, EventArgs e)
        {
            Roomadd roomadd = new Roomadd();
            roomadd.Show();
            Close();
        }

        private void button_change_Click(object sender, EventArgs e)
        {
            Roomchange roomchange = new Roomchange();
            roomchange.Show();
            Close();
        }

        private void button_delete_Click(object sender, EventArgs e)
        {
            Roomdelete roomdelete = new Roomdelete();
            roomdelete.Show();
            Close();
        }
    }
}
