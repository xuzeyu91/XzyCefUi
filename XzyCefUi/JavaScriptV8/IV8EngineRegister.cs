using Chromium.WebBrowser;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace XzyCefUi.JavaScriptV8
{
    public interface IV8EngineRegister
    {
        void Register(JSObject @object);
    }
}
