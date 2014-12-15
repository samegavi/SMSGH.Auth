using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Http.Headers;
using System.Text;
using System.Net.Http;
using System.Threading.Tasks;
using Android.App;
using Xamarin.Auth;



namespace SMSGH.Auth
{
    public class SMSGHUnityService
    {
         public async Task<AuthenticatorCompletedEventArgs> LoginAsync(Activity activity)
        {
            Account unity_user = null;
            var Constants = new SMSGHUnityConstants(activity);

            var auth = new OAuth2Authenticator(
                clientId: Constants.ClientID,
                scope: Constants.Scope,
                authorizeUrl: new Uri(SMSGHUnityConstants.AuthorizeUrl),
                redirectUrl: new Uri(Constants.RedirectUrl)
                
                );


            var tcs = new TaskCompletionSource<AuthenticatorCompletedEventArgs>();
            EventHandler<AuthenticatorCompletedEventArgs> dl = (o, e) =>
            {
                try
                { 
                    tcs.TrySetResult(e);
                }
                catch (Exception ex)
                {
                    tcs.TrySetResult(new AuthenticatorCompletedEventArgs(null));


                }
            };


            auth.Completed += dl;
            var intent = auth.GetUI(activity);
            activity.StartActivity(intent);
            var result = await tcs.Task;
            auth.Completed -= dl;

            return result;

        }

       
        /*
        public async Task<UnityAccountProfile> GetUnityAccountProfileAsync(Account account)
        { 
            using (var client = setupHttpClient())
            { 

            string json_string;
            HttpResponseMessage response;
				UnityAccountProfile profile = null;
            try
            {
                //var request = new OAuth2Request("GET", new Uri("", null, account);
                
                client.DefaultRequestHeaders.Authorization = new AuthenticationHeaderValue("Bearer", account.Properties["access_token"]);

                response = await client.GetAsync("https://api.smsgh.com/v3/account/profile");

                //var result = await request.GetResponseAsync();

					json_string = await response.Content.ReadAsStringAsync(); // result.GetResponseText();

					profile = JsonConvert.DeserializeObject<UnityAccountProfile>(json_string);

					return profile;

            }
            catch (Exception)
            {
					return profile;
                
                //throw;
            }

            }
        }


        private HttpClient setupHttpClient()
        {
            var client = new HttpClient
            {
                BaseAddress = new Uri("https://api.smsgh.com", UriKind.Absolute)
            };

            client.DefaultRequestHeaders.Accept.Clear();
            return client;
        }
      */
    
    }
}
