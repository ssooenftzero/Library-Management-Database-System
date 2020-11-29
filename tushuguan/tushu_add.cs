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
    public partial class tushu_add : Form
    {
        public tushu_add()
        {
            InitializeComponent();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void btn_ok_Click(object sender, EventArgs e)
        {
            string ts_num = txb_num.Text;
            string ts_name = txb_name.Text;
            string ts_kind = txb_kind.Text;
            int ts_amount = Convert.ToInt32(txb_amount.Text);
            string ts_place = txb_place.Text;
            SqlConnection cnn = new SqlConnection();
            string strCnn = "Data Source=localhost;Initial Catalog=library1;Integrated Security=True";
            cnn.ConnectionString = strCnn;
            cnn.Open();
            var cmd = new SqlCommand("select * from librarylog", cnn);
            cmd.CommandText = "insert into library.books(书号,书名,种类,数量,存放位置)values(" + ts_num + "," + ts_name + "," + ts_kind + "," + ts_amount + "," + ts_place + ")";
            int i = cmd.ExecuteNonQuery();
            MessageBox.Show("增加成功");
        }
    }
}
