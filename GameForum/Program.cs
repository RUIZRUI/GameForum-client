using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;
using Newtonsoft.Json;

namespace GameForum
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

            // LoginForm 作为主窗口
            // 返回主窗口实例
            LoginForm loginForm;
            do
            {
                // 模式窗口之间循环，直到密码正确
                loginForm = new LoginForm();
                loginForm.ShowDialog();     // LoginForm 实例窗口显示为对话框模式
                if (loginForm.IsClose)
                {
                    break;
                }
            } while (!loginForm.DialogResult.Equals(DialogResult.OK));

            if (loginForm.DialogResult.Equals(DialogResult.OK))
            {
                // 保存主窗体的引用
                SingleForm singleForm = new SingleForm();
                MainWindow.MainForm = singleForm;
                Application.Run(singleForm);
            }
        }
    }
}
