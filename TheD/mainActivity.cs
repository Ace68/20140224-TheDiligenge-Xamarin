using System;

using Android.App;
using Android.Content;
using Android.Runtime;
using Android.Views;
using Android.Widget;
using Android.OS;

using TheD.Activities;

namespace TheD
{
    [Activity(Label = "The Diligenge", Icon = "@drawable/icon")]
    public class MainActivity : Activity
    {
        protected override void OnCreate(Bundle bundle)
        {
            base.OnCreate(bundle);

            // Set our view from the "main" layout resource
            SetContentView(Resource.Layout.Main);

            // Get our button from the layout resource,
            // and attach an event to it
            ImageButton coachesButton = FindViewById<ImageButton>(Resource.Id.coachesButton);
            ImageButton sessionsButton = FindViewById<ImageButton>(Resource.Id.sessionsButton);

            // EventHandler
            coachesButton.Click += coachesButton_Click;
            sessionsButton.Click += sessionsButton_Click;
        }

        private void coachesButton_Click(object sender, EventArgs e)
        {
            StartActivity(typeof(CoachesActivity));
        }

        private void sessionsButton_Click(object sender, EventArgs e)
        {
            StartActivity(typeof(SessionsActivity));
        }

    }
}

