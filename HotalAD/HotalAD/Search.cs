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
    public partial class Search : Form
    {
        public Search()
        {
            InitializeComponent();
        }

        private void button_return_Click(object sender, EventArgs e)
        {
          
            Close();
        }

        private void Search_Load(object sender, EventArgs e)
        {
            // TODO:  这行代码将数据加载到表“hotalDataSet.Room”中。您可以根据需要移动或删除它。
            this.roomTableAdapter.Fill(this.hotalDataSet.Room);
            
        }

        
    }
}
