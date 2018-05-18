
using Chromium.WebBrowser;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace XzyCefUi.JavaScriptV8.Module
{
    public class Demo : IV8EngineRegister
    {
        public void Register(JSObject @object)
        {
            //注册模块
            var funcObj = @object.AddObject("V8Demo");
            TestLogin(funcObj);
        }

        private void TestLogin(JSObject jfunc) {
            //注册方法
            jfunc.AddFunction("TestLogin").Execute += (sender, args) =>
            {
                var name = args.Arguments[0].StringValue;
                var pwd = args.Arguments[1].StringValue;
                MessageBox.Show($"账号:{name},密码:{pwd}");
            };
        }
    }


}
