using System;
using Android.App;
using Android.Content.PM;
using Android.OS;

namespace CentroPosgrados.Droid
{
	[Activity(Label = "Posgrados", Icon = "@drawable/icon",NoHistory=true, Theme = "@style/SplashTheme", MainLauncher = true, ConfigurationChanges = ConfigChanges.ScreenSize | ConfigChanges.Orientation)]
    public class SplashActivity: Activity
    {
        protected override void OnCreate(Bundle savedInstanceState)
        {
            base.OnCreate(savedInstanceState);
            StartActivity(typeof(MainActivity));
            Finish();
            OverridePendingTransition(0,0);
        }
    }
}
