using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WinformTest
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
            FrmUserLogin objLoginForm = new FrmUserLogin();
            DialogResult result = objLoginForm.ShowDialog();
            //判断登陆是否成功
            if (result == DialogResult.OK)
            {
                if (objLoginForm.radioButton1.Checked)
                {
                    Application.Run(new FrmManager());
                }
                else
                {
                    Application.Run(new FrmMain());
                }
            }
            else
            {
                Application.Exit();//退出整个应用程序
            }
        }
    }
}
