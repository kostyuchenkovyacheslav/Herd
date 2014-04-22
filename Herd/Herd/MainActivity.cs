﻿namespace Herd
{
	using System;
	using Android.App;
	using Android.Content;
	using Android.Runtime;
	using Android.Views;
	using Android.Widget;
	using Android.OS;

	[Activity (Label = "Herd")]
	public class MainActivity : Activity
	{
		int count = 1;

		protected override void OnCreate (Bundle bundle)
		{
			base.OnCreate (bundle);

			// Set our view from the "main" layout resource
			SetContentView (Resource.Layout.Main);
			// slava 2222222
			// Get our button from the layout resource,
			// and attach an event to it
			Button button = FindViewById<Button> (Resource.Id.myButton);
			SeekBar seekBar = FindViewById<SeekBar> (Resource.Id.seekBar1); // just for test
			// just for test VKO >>
			button.Click += delegate {
				button.Text = string.Format ("{0} clicks!", count++);
			
			};
		}
	}
}


