using System.Threading;

using Android.App;
using Android.OS;

namespace TheD
{
    [Activity(Theme = "@style/Theme.Splash", MainLauncher = true, NoHistory = true)]
    public class SplashActivity : Activity
    {
        protected override void OnCreate(Bundle bundle)
        {
            base.OnCreate(bundle);

            Thread.Sleep(5000); // Simulate a long loading process on app startup.

            StartActivity(typeof(MainActivity));
        }
    }
}