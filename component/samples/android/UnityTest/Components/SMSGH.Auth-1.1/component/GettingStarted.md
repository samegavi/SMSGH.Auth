## Getting Started with SMSGH.Auth

#Setup your SMSGH Unity App Settings 

Before you can use SMSGH.Auth to provide 'Login with SMSGH'functionality in your app you need
to register your app with [SMSGH Unity Platform](https://unity.smsgh.com)

Once you have successfully done so you and have generated your *ClientID*, *Scope*
and *RedirectUrl* you need to add these values to your android manifest as MetaData. Do this by adding the following assembly attribute code:

```
[assembly: MetaData ("UnityClientID", Value="ClientID-goes-here")]
[assembly: MetaData ("UnityAppScope", Value="Scope-goes-here")]
[assembly: MetaData ("UnityRedirectUrl", Value="url-goes-here")]
```

##Implement the Login Flow

#####Android
SomeActivity.cs

````c#
using SMSGH.Auth;

loginButton.Click += async delegate
   {
        var service = new SMSGHUnityService();
        var result = await service.LoginAsync(this);

        if (result.IsAuthenticated)
           {  
           //Login successful! can save Account object which contains access_token
            AccountStore.Create(this).Save(result.Account,"UnityAccount");
           //do all you want for successful login here! 
            }
     };
````