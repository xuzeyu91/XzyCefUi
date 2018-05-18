﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Xzy.UI.Core
{
	[AttributeUsage(AttributeTargets.Property, Inherited = true)]
	public class JSPropertyAttribute : Attribute
	{
		public string JSName { get; set; }

		//public JSPropertyAttribute(string jsName)
		//{
		//	JSName = jsName;
		//}
	}
}
