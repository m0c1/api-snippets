// Download the twilio-csharp library from twilio.com/docs/libraries/csharp
using System;
using Twilio;
using Twilio.Rest.Notify.V1;

public class Example
{
    public static void Main(string[] args)
    {
        // Find your Account SID and Auth Token at twilio.com/console
        // To set up environmental variables, see http://twil.io/secure
        const string accountSid = Environment.GetEnvironmentVariable("TWILIO_ACCOUNT_SID");
        const string authToken = Environment.GetEnvironmentVariable("TWILIO_AUTH_TOKEN");
        const string credentialSid = "CRXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXX";

        TwilioClient.Init(accountSid, authToken);

        var credential = CredentialResource.Fetch(credentialSid);

        Console.WriteLine(credential.FriendlyName);
    }
}
