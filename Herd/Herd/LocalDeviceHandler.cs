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

namespace Herd
{
	class LocalDeviceHandler
	{
		public string GetDeviceUID() 
		{
			TelephonyManager tManager = (TelephonyManager)getSystemService(Context.TELEPHONY_SERVICE);
			return(tManager.getDeviceId());
		}
	
	}
}

