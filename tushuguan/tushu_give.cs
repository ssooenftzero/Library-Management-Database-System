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
        private object dateTime;
        private object txtDriverId;
        private object txt_giv_date;
        private string dateTimePicker1_Value;

        public tushu_give()
        {
            InitializeComponent();
        }

        private void btn_giv_ok_Click(object sender, EventArgs e)
        {
            string giv_date = dateTimePicker1_Value;
            string giv_sno = txt_giv_sno.Text;
            string giv_bno = txt_giv_bno.Text;
            SqlConnection cnn = new SqlConnection();

            string strCnn = "Data Source=localhost;Initial Catalog=library1;Integrated Security=True";
            cnn.ConnectionString = strCnn;
            cnn.Open();
            var cmd = new SqlCommand("select * from librarylog", cnn);

            cmd.CommandText = "update library.borbooks set 还书日期 = "+ giv_date + "where 学号 =" + giv_sno + "and 书号 =" + giv_bno +"'";
            int i = cmd.ExecuteNonQuery();
            MessageBox.Show("归还成功");
        }


        private void txt_giv_bno_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
