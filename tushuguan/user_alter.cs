using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;

namespace tushuguan
{
    public partial class user_alter : Form
    {
        public user_alter()
        {
            InitializeComponent();
        }

        public string apl_sex;
        private void textBox2_TextChanged(object sender, EventArgs e)
        {

        }

        private void btn_alt_ok_Click(object sender, EventArgs e)
        {
            string sno = this.txt_alt_sno.Text;
            string Pclass = this.txt_alt_class.Text;
            string name = this.txt_alt_sname.Text;
            string sex = this.apl_sex;
            string phone_num = this.txt_alt_phone.Text;
            SqlConnection cnn = new SqlConnection();

            string strCnn = "Data Source=localhost;Initial Catalog=library1;Integrated Security=True";
            cnn.ConnectionString = strCnn;
            cnn.Open();
            var cmd = cnn.CreateCommand();
            cmd.CommandText = "update library.borpeople set 班级 = '" + Pclass + "',姓名 ='" + name + "',性别 = '" + sex + "',联系方式 = '" + phone_num + "' where 学号 = '" + sno + "'" ;
            int i = cmd.ExecuteNonQuery();
            bool a = Convert.ToBoolean(i);
            if (a)
            {
                MessageBox.Show("修改成功！");
            }
            else
            MessageBox.Show("修改失败！");
        }

        private void user_alter_Load(object sender, EventArgs e)
        {
            
            bool isChecked = rbt_alt_woman.Checked;
            if (isChecked)
                apl_sex = rbt_alt_woman.Text;
            else
                apl_sex = rbt_alt_man.Text;
        }
    }
}
