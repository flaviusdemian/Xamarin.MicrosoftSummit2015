using System;
using Android.App;
using Android.Content;
using Android.Runtime;
using Android.Views;
using Android.Widget;
using Android.OS;
using MsSummit.Core;

namespace MsSummit.Android
{
    [Activity(Label = "MsSummit.Android", MainLauncher = true, Icon = "@drawable/icon")]
    public class MainActivity : Activity
    {
        private TextView tv1, tv2, tv3;
        private MockService _mockService = new MockService();

        protected override void OnCreate(Bundle bundle)
        {
            base.OnCreate(bundle);

            // Set our view from the "main" layout resource
            SetContentView(Resource.Layout.Main);

            // Get our button from the layout resource,
            // and attach an event to it
            tv1 = FindViewById<TextView>(Resource.Id.textView1);
            tv2 = FindViewById<TextView>(Resource.Id.textView2);
            tv3 = FindViewById<TextView>(Resource.Id.textView3);

            tv1.Text = _mockService.RetrieveMockString();
            tv2.Text = _mockService.RetrievePartialStringWrapper();
            tv3.Text = _mockService.RetrieveIFDEFString();

            //button.Click += delegate { button.Text = string.Format("{0} clicks!", count++); };

#if __MOBILE__
            Console.WriteLine("__MOBILE__ is defined");
#endif

#if __ANDROID__
            Console.WriteLine("__ANDROID__ is defined");
#endif

#if __IOS__
            Console.WriteLine("__ANDROID__ is defined");
#endif
        }

    }
}

