using System;
using System.Collections.Generic;
using System.Linq;
using System.Windows.Forms;

namespace 只打开一个子窗体
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
            Application.Run(new 父窗体());
        }
    }
}
