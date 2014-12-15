using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Android.App;
using Android.Content;
using Android.OS;
using Android.Runtime;
using Android.Views;
using Android.Widget;
using Xamarin.Auth;
using SMSGH.Auth;

namespace UnityTest
{
    [Activity(Label = "UserProfileActivity")]
    public class UserProfileActivity : Activity
    {
        protected override void OnCreate(Bundle bundle)
        {
            base.OnCreate(bundle);

            // Create your application here
            IEnumerable<Account> account = AccountStore.Create(this).FindAccountsForService("UnityAccount");

            SetContentView(Resource.Layout.Profile);

            var credit = FindViewById<TextView>(Resource.Id.credit); 

			//var service = new SMSGH.Auth.SMSGHUnityService();
            //Task<SMSGH.Auth.UnityAccountProfile> accountProfile =   service.GetUnityAccountProfileAsync(account.Last());
			
           // if (accountProfile.IsCompleted)
	          // credit.Text = accountProfile.Result._Credit.ToString();
            
        }
    }
}