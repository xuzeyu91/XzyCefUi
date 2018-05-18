using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;
using Xzy.UI.Core;

namespace XzyCefUi
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
            //初始化CEF: 设置CEF的相关Path
            //如果要使用Nuget自动下载的fx文件夹结构，需要手动指定各个文件夹的路径
            System.Threading.Thread.CurrentThread.CurrentUICulture = new System.Globalization.CultureInfo("zh-CN");
            if (Bootstrap.Load())
            {
                Bootstrap.RegisterFolderResources(Application.StartupPath);
                //嵌入资源使用虚拟域名
                Bootstrap.RegisterAssemblyResources(System.Reflection.Assembly.GetExecutingAssembly(), null, "ss.custom.local");    
                Application.Run(new Form1());
            }
        }
    }
}
