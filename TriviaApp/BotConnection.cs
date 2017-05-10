// Copyright (c) Microsoft Corporation. All rights reserved.

namespace TrivaApp
{
    public static class BotConnection
    {
        #error You must specify the direct line secret of the bot to talk to
        #error This requires first publishing the TriviaBot project and configuring it on https://dev.botframework.com/
        public static string DirectLineSecret { get; } = null;

        public static string ApplicationName { get; }  = "TriviaApp";
    }
}
