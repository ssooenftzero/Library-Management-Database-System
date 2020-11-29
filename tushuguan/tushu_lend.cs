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
    public partial class tushu_lend : Form
    {
        private string dateTimePicker2_Value;

        public tushu_lend()
        {
            InitializeComponent();
        }

        private void btn_ld_ok_Click(object sender, EventArgs e)
        {
            string ld_sno = txb_ld_sno.Text;
            string ld_bno = txb_ld_bno.Text;
            string ld_datel = dateTimePicker2_Value;
            SqlConnection cnn = new SqlConnection();
            string strCnn = "Data Source=localhost;Initial Catalog=library1;Integrated Security=True";
            cnn.ConnectionString = strCnn;
            cnn.Open();
            var cmd = new SqlCommand("select * from librarylog", cnn);
            
            cmd.CommandText = "insert into library.borbooks(学号,书号,借书日期)values('" + ld_sno + "','" + ld_bno + "','" + ld_datel + "')";
            int i = cmd.ExecuteNonQuery();
            MessageBox.Show("出库成功");
        }

        private void tushu_lend_Load(object sender, EventArgs e)
        {

        }
    }
}
