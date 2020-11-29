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
            //while (redslt.Read()) {
            //    this.txtBno.Text = redslt.GetString(0);
            //    this.txtType.Text = redslt.GetString(2);
            //    this.txtNum.Text = redslt.GetString(3);
            //    this.txtLoc.Text = redslt.GetString(4);
            //    break;
            //}
            //int i = cmd.ExecuteNonQuery();
            MessageBox.Show("查询成功");
        }

        private void txtBno_TextChanged(object sender, EventArgs e)
        {
           
        }
    }
}
