using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

using Android.App;
using Android.Content;
using Android.Content.PM;
using Android.OS;
using Android.Runtime;
using Android.Views;
using Android.Widget;

namespace SMSGH.Auth
{
    public  class SMSGHUnityConstants
    {
        private Activity activity;

        public readonly string ClientID;
        public readonly string Scope;
        public const string AuthorizeUrl = "https://unity.smsgh.com/oauth";
        public readonly string RedirectUrl;

        public SMSGHUnityConstants(Activity this_activity)
        {
            activity = this_activity;
            ClientID = getMetaData(activity, "UnityClientID");
            Scope = getMetaData(activity, "UnityAppScope");
            RedirectUrl = getMetaData(activity, "UnityRedirectUrl");
        }

        private static string getMetaData(Context context, String name)
        {
            try
            {
                ApplicationInfo ai = context.PackageManager.GetApplicationInfo(context.PackageName, PackageInfoFlags.MetaData);
                Bundle bundle = ai.MetaData;
                return bundle.GetString(name);
            }
            catch (Exception ex)
            {
                
                throw;
            }
        }
        

       


    }
}