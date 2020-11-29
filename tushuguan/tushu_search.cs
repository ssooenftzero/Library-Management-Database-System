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
    public partial class tushu_search : Form
    {

        public tushu_search()
        {
            InitializeComponent();
        }

        private void btn_sea_ok_Click(object sender, EventArgs e)
        {
            string sea_bname = this.txt_sea_bname.Text;
            
            SqlConnection cnn = new SqlConnection();

            string strCnn = "Data Source=127.0.0.1;Initial Catalog=library1;Integrated Security=True";
            cnn.ConnectionString = strCnn;
            cnn.Open();
            var cmd =cnn.CreateCommand();
            cmd.CommandType = CommandType.Text;

            cmd.CommandText = "select" + " *" + " from" + " library.books" + " where" + " 书名 =" + sea_bname;

            SqlDataReader redslt = null;
            redslt = cmd.ExecuteReader();
            MessageBox.Show(redslt.ToString());
            MessageBox.Show("查询成功");
        }

        private void txtBno_TextChanged(object sender, EventArgs e)
        {
           
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }
    }
}
