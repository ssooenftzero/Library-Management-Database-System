using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace tushuguan
{
    public partial class mainopen : Form
    {
        public mainopen()
        {
            InitializeComponent();
        }

        private void toolStripLabel1_Click(object sender, EventArgs e)
        {

        }

        private void tsl_add_Click(object sender, EventArgs e)
        {
            tushu_add ts_add = new tushu_add();
            ts_add.ShowDialog();
        }

        private void tsl_lend_Click(object sender, EventArgs e)
        {
            tushu_lend ts_lend = new tushu_lend();
            ts_lend.ShowDialog();
        }

        private void tsl_search_Click(object sender, EventArgs e)
        {
            tushu_search ts_search = new tushu_search();
            ts_search.ShowDialog();
        }

        private void tsl_give_Click(object sender, EventArgs e)
        {
            tushu_give ts_give = new tushu_give();
            ts_give.ShowDialog();
        }

        private void tsl_delete_Click(object sender, EventArgs e)
        {
            user_logout us_logout = new user_logout();
            us_logout.ShowDialog();
        }

        private void tsl_apply_Click(object sender, EventArgs e)
        {
            user_apply us_apply = new user_apply();
            us_apply.ShowDialog();
        }

        private void tsl_alter_Click(object sender, EventArgs e)
        {
            user_alter us_alter = new user_alter();
            us_alter.ShowDialog();
        }
    }
}
