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
    public partial class user_delete : Form
    {
        public user_delete()
        {
            InitializeComponent();
        }

        private void btn_del_ok_Click(object sender, EventArgs e)
        {
            string del_sno = this.txt_del_sno.Text;
            string del_sname = this.txt_del_sname.Text;
            SqlConnection cnn = new SqlConnection();
            string strCnn = "Data Source=localhost;Initial Catalog=library1;Integrated Security=True";
            cnn.ConnectionString = strCnn;
            cnn.Open();
            var cmd = cnn.CreateCommand();
            cmd.CommandType = CommandType.Text;
            cmd.CommandText = "delete from library.borpeople where 学号 ='" + del_sno + "'and 姓名 ='" + del_sname + "'";
            int i = cmd.ExecuteNonQuery();
            bool d = Convert.ToBoolean(i);
            if (d)
            {
                MessageBox.Show("注销成功");
            }
            else
            MessageBox.Show("填写错误或该账号未注册！");
        }



        private void txt_del_sno_TextChanged(object sender, EventArgs e)
        {

        }

        private void txt_del_sname_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
