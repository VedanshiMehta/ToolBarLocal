using Android.App;
using Android.Content;
using Android.OS;
using Android.Runtime;
using Android.Views;
using AndroidX.AppCompat.App;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Toolbar = AndroidX.AppCompat.Widget.Toolbar;


namespace ToolBarLocal
{
    [Activity(Label = "@string/app_name", Theme = "@style/AppTheme")]
    class SecondActivity: AppCompatActivity
    {

        Toolbar tool;

        protected override void OnCreate(Bundle savedInstanceState)
        {
            base.OnCreate(savedInstanceState);
            SetContentView(Resource.Layout.ToolBar);
            tool = FindViewById<AndroidX.AppCompat.Widget.Toolbar>(Resource.Id.toolbar2);
            SetSupportActionBar(tool);
            SupportActionBar.SetDisplayHomeAsUpEnabled(showHomeAsUp: true);
            tool.NavigationClick += Toolbar_NavigationClick;

        }

        

        private void Toolbar_NavigationClick(object sender, Toolbar.NavigationClickEventArgs e)
        {
            Finish();
        }
    }
}