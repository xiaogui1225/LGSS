using System;
using System.Collections.Generic;
using System.Linq;
using System.Windows.Forms;

namespace 学生宿舍管理系统更新版
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
            Application.Run(new Frm主界面());
        }
    }
}
