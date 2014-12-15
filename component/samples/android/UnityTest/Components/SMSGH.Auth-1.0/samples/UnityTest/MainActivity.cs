using System;
using System.Threading.Tasks;
using Android.App;
using Android.Content;
using Android.Runtime;
using Android.Views;
using Android.Widget;
using Android.OS;
using SMSGH.Auth;
using Xamarin.Auth;


namespace UnityTest
{
    [Activity(Label = "UnityTest", MainLauncher = true, Icon = "@drawable/icon")]
    public class MainActivity : Activity
    {
        int count = 1;

        protected override void OnCreate(Bundle bundle)
        {
            base.OnCreate(bundle);

            // Set our view from the "main" layout resource
            SetContentView(Resource.Layout.Main);

            // Get our button from the layout resource,
            // and attach an event to it
            Button button = FindViewById<Button>(Resource.Id.MyButton);

            button.Click += async delegate
            {
               
                var service = new SMSGHUnityService();
                var result = await service.LoginAsync(this);

                if (result.IsAuthenticated)
                {
                    AccountStore.Create(this).Save(result.Account, "UnityAccount");
                    StartActivity(typeof(UserProfileActivity));
                }



            };
        }

        
    }
}

