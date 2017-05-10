# TriviaBotSpeechSample
A sample trivia bot, leveraging the Microsoft Bot Framework and https://opentdb.com/ that showcases the use of the new speech-enabled Microsoft.Bot.Client NuGet package and Microsoft Bot Framework C# Builder SDK features.

This sample contains two projects, a trivia bot built on top of the Microsoft Bot Framework C# Builder SDK, and a UWP app that talks to the bot using the Microsoft.Bot.Client NuGet package.

As this is a combined client/sample demo, there is a bit of setup required.

1) Register a bot with the Bot Framework at http://dev.botframework.com/ and add the AppId and AppPassword to TriviaBot\Web.config.
2) Enable the Direct Line channel in the bot settings page, and paste a Direct Line secret in TriviaApp\BotConnection.cs.
3) Create a LUIS app on http://luis.ai/ and import TriviaBotLU.json as a new app. Train and publish the model, and add the app id and subscription key in TriviaBot\TriviaDialog.cs (there is an error pointing to the location).
    The LUIS app id and subscription key can be extracted from the Endpoint Url provided on the "Publish App" page at http://luis.ai/
    The link format is: https://westus.api.cognitive.microsoft.com/luis/v2.0/apps/<appid>?subscription-key=<subscription key>&verbose=true&q=.
4) Publish the Bot as an Azure App Service, and add the public endpoint (<hosturl>/api/messages) to the Bot Framework portal settings page.
5) To talk to the bot from Cortana, enable the Cortana channel and provide an invokation phrase.