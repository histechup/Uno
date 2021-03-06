#if __ANDROID__
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

using Android.App;
using Android.Content;
using Android.OS;
using Android.Runtime;
using Android.Views;
using Android.Widget;

namespace Uno.UI
{
	public static class ContextHelper
	{
		private static Android.Content.Context _current;

		/// <summary>
		/// Get the current android content context
		/// </summary>
		public static Android.Content.Context Current
		{
			get
			{
				return _current;
			}
			set
			{
				_current = value;
			}
		}
	}
}
#endif