using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace tushuguan
{
    static class Program
    {
        /// <summary>
        /// 应用程序的主入口点。
        /// </summary>
        [STAThread]
        static void Main()
        {
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            denglu dopen = new denglu();
            //dopen.ShowDialog();
            if (DialogResult.OK == dopen.ShowDialog())
            {
                Application.Run(new mainopen());
            }
        }
    }
}
