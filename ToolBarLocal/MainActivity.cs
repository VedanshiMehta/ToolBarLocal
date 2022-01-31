using Android.App;
using Android.OS;
using Android.Runtime;
using Android.Widget;
using AndroidX.AppCompat.App;
using System;

namespace ToolBarLocal
{
    [Activity(Label = "@string/app_name", Theme = "@style/AppTheme", MainLauncher = true)]
    public class MainActivity : AppCompatActivity
    {

        private Button mybutton;
        private Toolbar myToolbar;
        protected override void OnCreate(Bundle savedInstanceState)
        {
            base.OnCreate(savedInstanceState);
            Xamarin.Essentials.Platform.Init(this, savedInstanceState);
            // Set our view from the "main" layout resource
            SetContentView(Resource.Layout.activity_main);
            UIReference();
            SetActionBar(myToolbar);
            mybutton.Click += Mybutton_Click;
        }

        private void UIReference()
        {
            mybutton = FindViewById<Button>(Resource.Id.button1);
            myToolbar = FindViewById<Toolbar>(Resource.Id.toolbar1);
        }

        private void Mybutton_Click(object sender, System.EventArgs e)
        {
            StartActivity(intent: new Android.Content.Intent(this, typeof(SecondActivity)));
        }

        public override void OnRequestPermissionsResult(int requestCode, string[] permissions, [GeneratedEnum] Android.Content.PM.Permission[] grantResults)
        {
            Xamarin.Essentials.Platform.OnRequestPermissionsResult(requestCode, permissions, grantResults);

            base.OnRequestPermissionsResult(requestCode, permissions, grantResults);
        }
    }
}