﻿using System;
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
    public partial class denglu : Form
    {
        public denglu()
        {
            InitializeComponent();
        }

        private void but_denglu_Click(object sender, EventArgs e)
        {
            string sno= this.txt_sno.Text;
            string sname = this.txt_sname.Text;
            SqlConnection cnn = new SqlConnection();
            string strCnn = "Data Source=localhost;Initial Catalog=library1;Integrated Security=True";
            cnn.ConnectionString = strCnn;
            cnn.Open();
            var s_cmd = cnn.CreateCommand();
            s_cmd.CommandType = CommandType.Text;           
            s_cmd.CommandText = "select" + " *" + " from" + " " + "librarylog";
            SqlDataReader reader = s_cmd.ExecuteReader();
      
            bool xinxi = false;
            while (reader.Read())
            {
              
                if (sno == reader.GetString(0) && sname == reader.GetString(1) )
                {
                    xinxi = true;
                    break;
                }
            }
            if (xinxi)
            {
                MessageBox.Show("您所输入的信息正确,正在登陆，请稍等！");
                this.DialogResult = DialogResult.OK;
                this.Close();
            }
            else
            {
                MessageBox.Show("您所输入的信息错误，请重新输入");
            }
        }

        private void txt_sno_Enter(object sender, EventArgs e)
        {
            if (txt_sno.Text == "请输入管理员账户")
            {
                txt_sno.Text = "";
                txt_sno.ForeColor = Color.Black;
            }
        }

        private void txt_sno_Leave(object sender, EventArgs e)
        {
            if (txt_sno.Text == "")
            {
                txt_sno.Text = "请输入管理员账户";
                txt_sno.ForeColor = Color.Gray;

            }
        }

        private void txt_sname_Enter(object sender, EventArgs e)
        {
            if (txt_sname.Text == "请输入管理员密码")
            {
                txt_sname.Text = "";
                txt_sname.PasswordChar = '*';
                txt_sname.ForeColor = Color.Black;
            }
        }

        private void txt_sname_Leave(object sender, EventArgs e)
        {
            if (txt_sname.Text == "")
            {
                txt_sname.PasswordChar = '\0';
                txt_sname.Text = "请输入管理员密码";
                txt_sname.ForeColor = Color.Gray;

            }
        }
    }
}