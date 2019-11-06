# Sematime Glue

A .NET Dll to allow users to interact with the sematime API

The DLL exploits version 4 of the [Sematime API](http://sematime.com/).

This DLL works with any .NET Framework languages

[For more information see the wiki](https://github.com/mwangepatrick/sematime-glue/wiki)

### Install Sematime Glue

If you want to include Sematime Glue in your project, you can clone the project and build the latest copy the import then import the DLL on your end or you can also add the project as an extension to your main project.
To install ClosedXML, run the following command in the Package Manager Console

### What can you do with this?

With Sematime Glue, Currently, you can only send messages using the sematime API. 

```c#
string _token = "12311**********e7tf";
string _accountId = "my-account-id";
string message = "A sample message"; //this is the message you want to send
string recipients= "0711000000"; //This can be a single phone number or a coma separated string of the recipients
SematimeGlue.SematimeGlue semaGlue = new SematimeGlue.SematimeGlue(_token,_accountId);
semaGlue.SendMessage(message, recipients, out string responseCode, out string responseMessage);
```

The SendMessage function will return botht the responseStatus and the ResponseCode as string. Here is a list of the expected responses as per the Sematime Docs.

| Response Code          | Description               |
| -----------------------|:--------------------------|
| OK	                 | Message Sent Successfully | 
| Bad Request            |Improperly formatted request.                  |
| UnAuthorised           | Request could not be authenticated due to incorrect login credentials or auth token. |
| Forbidden | Request was accepted but could not be processed. For example, when you do not have enough sms units to send a text or the phone number is not correctly formatted.         |
| Not Found.            | Resource you are requesting could not be found.       |
| Internal Server Error | Server is unable to process your request possibly due to a problem on Sematime Servers|
| -1                    | Request Failure due to the error occurring within the Sematime Glue      |


## Minimum Requirements

To run Sematime Glue, you need:

1. A developer account with Sematime, You can get one by registering from their [developer's portal](https://apis.sematime.com/developers/)
2. You then need an account which you will be accessing and sending messages from. This can be a school,hospital,church and so on. 

You can register for this at the [accounts portal](http://account.sematime.com/register);


##Depedencies

Sematime Glue relies on the following Dependencies to work

1. .Net Framework version >= 4.5.2
2. NewtonSoft.Json 12.0.2

