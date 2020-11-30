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
    public partial class tushu_search : Form
    {

        public tushu_search()
        {
            InitializeComponent();
        }

        private void Loadall()
        {
            List<books> books = DBUtils.QueryDB().Sql("select * from library.books").QueryMany<books>();
            this.view.DataSource = books;
        }

        private void btn_sea_ok_Click(object sender, EventArgs e)
        {
            string sea_bname = this.txt_sea_bname.Text;
            int count = DBUtils.QueryDB()
                    .Sql("select count(*) from library.books where 书名 = @booksno")
                    .Parameter("booksno", sea_bname)
                    .QuerySingle<int>();
            List<books> books1 = DBUtils.QueryDB().Sql("select * from library.books where 书名 = @booksno")
                .Parameter("booksno", sea_bname)
                .QueryMany<books>();
            if (count > 0)
            {
                view.DataSource = books1;
                MessageBox.Show("查询成功");
            }
            else
            {
                MessageBox.Show("没有查到相关信息");
            }          
        }

        private void tushu_search_Load(object sender, EventArgs e)
        {
            Loadall();
        }

    }
}
