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

        private void btn_sc_ok_Click(object sender, EventArgs e)
        {
            
            SqlConnection cnn = new SqlConnection();
            string strCnn = "Data Source=localhost;Initial Catalog=library1;Integrated Security=True";
            cnn.ConnectionString = strCnn;
            cnn.Open();
            var cmd = new SqlCommand("select * from librarylog", cnn);
            //cmd.CommandText = "insert into library.books(书号,书名,种类,数量,存放位置)values(" + ts_num + "," + ts_name + "," + ts_kind + "," + ts_amount + "," + ts_place + ")";
            int i = cmd.ExecuteNonQuery();
            MessageBox.Show("增加成功");
        }
    }
}
