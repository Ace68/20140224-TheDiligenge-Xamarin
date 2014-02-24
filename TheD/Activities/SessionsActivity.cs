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
    [Activity(Label = "Sessions")]
    public class SessionsActivity : ListActivity
    {
        string[] sessions;

        protected override void OnCreate(Bundle bundle)
        {
            base.OnCreate(bundle);

            //SetContentView(Resource.Layout.SessionsLayout);

            sessions = new string[] { "KnockOut", "Angular", "Durandal", "Personas", "Faccette", "Xamarin" };
            ListAdapter = new ArrayAdapter<String>(this, Android.Resource.Layout.SimpleListItem1, sessions);
        }

        protected override void OnListItemClick(ListView l, View v, int position, long id)
        {
            var t = sessions[position];

            switch (t)
            {
                case "KnockOut":
                    StartActivity(typeof(OmarActivity));
                    break;

                case "Angular":
                    StartActivity(typeof(GianniActivity));
                    break;

                default:
                    Android.Widget.Toast.MakeText(this, t, Android.Widget.ToastLength.Short).Show();
                    break;
            }
            
        }
    }
}