namespace Herd
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
		// int count = 1;

		protected override void OnCreate (Bundle bundle)
		{
			Window.RequestFeature(WindowFeatures.NoTitle);	
			base.OnCreate(bundle);

			// Set our view from the "main" layout resource
			SetContentView (Resource.Layout.Main);
<<<<<<< HEAD
=======

>>>>>>> Stash
			// Get our button from the layout resource,
			// and attach an event to it
<<<<<<< HEAD
			Button button = FindViewById<Button> (Resource.Id.myButton);
			// SeekBar seekBar1 = FindViewById<SeekBar> (Resource.Id.seekBar1); 
			button.Click += delegate {
				button.Text = string.Format ("{0} clicks!", count++);
			
			};
=======
			// Button button = FindViewById<Button> (Resource.Id.myButton);
			Button buttonAddHerd = FindViewById<Button> (Resource.Id.AddHerd);
			buttonAddHerd.SetPadding(165, 40, 40, 40);
			// buttonAddHerd.SetBackgroundDrawable();

			Button buttonConnectHerd = FindViewById<Button> (Resource.Id.ConnectHerd);
			buttonConnectHerd.SetPadding(165, 40, 40, 40);

			Button buttonSettings = FindViewById<Button> (Resource.Id.Settings);
			buttonSettings.SetPadding(165, 40, 40, 40);
			// button.Click += delegate {
			// 	button.Text = string.Format ("{0} clicks!", count++);
			// };

>>>>>>> Stash
		}
	}
}


