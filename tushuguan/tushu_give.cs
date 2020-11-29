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
    public partial class tushu_give : Form
    {
        public tushu_give()
        {
            InitializeComponent();
        }

        private void txb_gv_bno_TextChanged(object sender, EventArgs e)
        {

        }

        private void btn_gv_ok_Click(object sender, EventArgs e)
        {
            string gv_sno = txb_gv_sno.Text;
            string gv_bno = txb_gv_bno.Text;
            string gv_dateh = txb_gv_dateh.Text;
            SqlConnection cnn = new SqlConnection();
            string strCnn = "Data Source=localhost;Initial Catalog=library1;Integrated Security=True";
            cnn.ConnectionString = strCnn;
            cnn.Open();
            var cmd = cnn.CreateCommand();

            cmd.CommandText = "insert into library.borbooks(学号,书号,借书日期)values('" + ld_sno + "','" + ld_bno + "','" + ld_datel + "')";
            int i = cmd.ExecuteNonQuery();
            MessageBox.Show("增加成功");
        }
    }
}
