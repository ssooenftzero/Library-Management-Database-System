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
    public partial class user_apply : Form
    {
        public user_apply()
        {
            InitializeComponent();
        }

        private void btn_apl_ok_Click(object sender, EventArgs e)
        {
            string apl_sno = txb_apl_sno.Text;
            string apl_class = txb_apl_class.Text;
            string apl_sname = txb_apl_sname.Text;
            //string apl_sex = txb_apl_sex.Text;
            string apl_sex = "";
            bool isChecked = Male.Checked;
            if (isChecked)
                apl_sex = Male.Text;
            else
                apl_sex = Female.Text;
            string apl_phone = txb_apl_phone.Text;

            SqlConnection cnn = new SqlConnection();

            string strCnn = "Data Source=localhost;Initial Catalog=library1;Integrated Security=True";
            cnn.ConnectionString = strCnn;
            cnn.Open();
            var cmd = new SqlCommand("select * from librarylog", cnn);

            cmd.CommandText = "insert into library.borpeople(学号,班级,姓名,性别,联系方式)values('" + apl_sno + "','" + apl_class + "','" + apl_sname + "','" + apl_sex + "','" + apl_phone + "')";
            int i = cmd.ExecuteNonQuery();
            MessageBox.Show("注册成功");
        }

        private void txb_apl_sno_TextChanged(object sender, EventArgs e)
        {

        }

        private void radioButton1_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void radioButton2_CheckedChanged(object sender, EventArgs e)
        {

        }
    }
}
