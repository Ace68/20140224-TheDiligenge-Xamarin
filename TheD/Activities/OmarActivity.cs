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

namespace TheD.Activities
{
    [Activity(Label = "Omar")]
    public class OmarActivity : Activity
    {
        protected override void OnCreate(Bundle bundle)
        {
            base.OnCreate(bundle);

            // Set our view from the "main" layout resource
            SetContentView(Resource.Layout.OmarLayout);

            ImageButton callOmar = FindViewById<ImageButton>(Resource.Id.callOmarButton);

            callOmar.Click += callOmar_Click;
        }

        private void callOmar_Click(object sender, EventArgs e)
        {
            var uri = Android.Net.Uri.Parse("tel:123123123");
            var intent = new Intent(Intent.ActionView, uri);
            StartActivity(intent); 
        }
    }
}