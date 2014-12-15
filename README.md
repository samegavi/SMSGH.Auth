SMSGH.Auth
==========

A Xamarin.Android Library for Authentication with SMSGH's Unity Platform via OAuth2.0

# Login with SMSGH

SMSGH.Auth allows your Xamarin.Android apps to securely implement a 'Login with SMSGH' feature that allows you to get authorization from the millions of SMSGH Unity customers to perform various activities such as sending bulk sms in your app.

SMSGH.Auth will let you take advantage of the [Unity API RESTFULL HTTP](http://developers.smsgh.com/documentations/unity) service using OAuth2.0 Protocols with minimal code.

The [SMSGH Unity API] (http://developers.smsgh.com/documentations/unity) exposes messaging and other related functions of the main SMSGH Unity platform and can be used for a variety of purposes such as sending bulk Sms, receiving inbound Sms to managing your short code subscriptions and setting up actions on your premium Sms campaigns.

## Getting Started with SMSGH.Auth

#Setup your SMSGH Unity App Settings 

Before you can use SMSGH.Auth to provide 'Login with SMSGH'functionality in your app you need
to register your app with [SMSGH Unity Platform](https://unity.smsgh.com)

Once you have successfully done so and have generated your *ClientID*, *Scope*
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
