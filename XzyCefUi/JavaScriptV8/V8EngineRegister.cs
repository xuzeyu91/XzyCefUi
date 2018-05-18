using Chromium.WebBrowser;
using XzyCefUi.JavaScriptV8.Module;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace XzyCefUi.JavaScriptV8
{
    public static class V8EngineRegister
    {
        private static List<IV8EngineRegister> Registers { get; set; }
        /// <summary>
        /// 加入注册模块
        /// </summary>
        static V8EngineRegister() => Registers = new List<IV8EngineRegister>
        {
           new Demo()
        };

        /// <summary>
        /// 循环注册
        /// </summary>
        /// <param name="object"></param>
        public static void Register(JSObject @object)
        {
            foreach (var item in Registers)
            {
                item.Register(@object);
            }
        }
    }
}
