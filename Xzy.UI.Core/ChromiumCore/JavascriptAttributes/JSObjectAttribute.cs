﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Chromium.WebBrowser;

namespace Xzy.UI.Core
{
	[AttributeUsage(AttributeTargets.Class, Inherited = true)]
	public class JSObjectAttribute : JSPropertyAttribute
	{
		//public JSObjectAttribute(string jsName) : base(jsName) { }
	}
}