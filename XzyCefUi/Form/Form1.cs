using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Xzy.UI.Core;
using XzyCefUi.JavaScriptV8;

namespace XzyCefUi
{
    public partial class Form1 : Formium
    {
        public Form1():base("http://ss.custom.local/www/index.html")
        {
            InitializeComponent();
            //注册后端方法
            V8EngineRegister.Register(GlobalObject);
            this.LoadHandler.OnLoadStart += LoadHandler_OnLoadStart;
        }

        private void ExecJS() {
            this.ExecuteJavascript("alert('111');");
            string a = "hahahaha";
            this.ExecuteJavascript($"testExecJs('{a}');");
        }

        /// <summary>
        /// cef加载完成 如果是调试打开调试工具
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void LoadHandler_OnLoadStart(object sender, Chromium.Event.CfxOnLoadStartEventArgs e)
        {
            //#if DEBUG
            Chromium.ShowDevTools();
            //#endif
        }

    }
}
