using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace tushuguan
{
    public partial class user_logout : Form
    {
        public user_logout()
        {
            InitializeComponent();
        }

        private void btn_dlt_delete_Click(object sender, EventArgs e)
        {
            SqlConnection cnn = new SqlConnection();
            string strCnn = "Data Source=localhost;Initial Catalog=library1;Integrated Security=True";
            cnn.ConnectionString = strCnn;
            cnn.Open();
            var cmd = cnn.CreateCommand();
            string dlt_sno = txb_dlt_sno.Text;
            string dlt_name = txb_dlt_name.Text;
            string dlt_class = txb_dlt_class.Text;

        }
    }
}
