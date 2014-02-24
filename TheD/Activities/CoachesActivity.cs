using System;

using Android.App;
using Android.OS;
using Android.Widget;

namespace TheD.Activities
{
    [Activity(Label = "The Coaches")]
    public class CoachesActivity : Activity
    {
        protected override void OnCreate(Bundle bundle)
        {
            base.OnCreate(bundle);

            SetContentView(Resource.Layout.CoachesLayout);

            Button omarButton = FindViewById<Button>(Resource.Id.omarButton);
            Button gianniButton = FindViewById<Button>(Resource.Id.gianniButton);
            Button albertoButton = FindViewById<Button>(Resource.Id.albertoButton);
            Button marcoButton = FindViewById<Button>(Resource.Id.marcoButton);
            Button sergioButton = FindViewById<Button>(Resource.Id.sergioButton);

            omarButton.Click += omarButton_Click;
            gianniButton.Click += gianniButton_Click;
            albertoButton.Click += albertoButton_Click;
            marcoButton.Click += marcoButton_Click;
            sergioButton.Click += sergioButton_Click;
        }

        private void omarButton_Click(object sender, EventArgs e)
        {
            StartActivity(typeof(OmarActivity));
        }

        private void gianniButton_Click(object sender, EventArgs e)
        {
            StartActivity(typeof(GianniActivity));
        }

        private void albertoButton_Click(object sender, EventArgs e)
        {
            
        }

        private void marcoButton_Click(object sender, EventArgs e)
        {
            
        }

        void sergioButton_Click(object sender, EventArgs e)
        {
            
        }
    }
}