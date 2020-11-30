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

        private void btn_giv_ok_Click(object sender, EventArgs e)
        {
            string giv_sno = txt_giv_sno.Text;
            string giv_bno = txt_giv_bno.Text;
            //string giv_date = txt_giv_date.Text;
            
            SqlConnection cnn = new SqlConnection();

            string strCnn = "Data Source=localhost;Initial Catalog=library1;Integrated Security=True";
            cnn.ConnectionString = strCnn;
            cnn.Open();
            var cmd = new SqlCommand("select * from librarylog", cnn);

            cmd.CommandText = "update library.borbooks set 还书日期 = '" + date_give.Value.ToString() + "'where 学号 ='" + giv_sno + "'and 书号 ='" + giv_bno + "'";

            //cmd.CommandText = "update library.borbooks set 还书日期 = '2020.85.58' where (学号 = '170110') and (书号 = 'E005')";//可以成功
            int i = cmd.ExecuteNonQuery();
            bool h = Convert.ToBoolean(i);
            if(h)
            {
                MessageBox.Show("还书成功！");
            }
            MessageBox.Show("还书失败！");
        }
    }
}
