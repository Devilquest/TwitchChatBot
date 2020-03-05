using System;

namespace TwitchChatBot
{
    class ChatUser
    {
        private ChatBot chatBot;

        private int messagesCount = 0;
        private int messagesCountFromLastSpam = 0;
        private double messageTime = 0;
        private double lastSpamMessageTime = 0;

        private string userName;
        private string displayName;

        private bool sayedHello = false;

        public ChatUser(ChatBot bot, string userName, string displayName)
        {
            chatBot = bot;
            this.userName = userName;
            this.displayName = displayName;
            NewMessage();
        }

        public void NewMessage()
        {
            if (MainForm.StreamersListNames.Contains(userName))
            {
                if (!sayedHello) SayHello();

                if (BotSettings.PromoteChannelsChecked)
                {
                    messageTime = MainForm.stopwatch.Elapsed.TotalSeconds;

                    if (messagesCount <= 0 || (messagesCountFromLastSpam >= BotSettings.MinMessagesToSpam && (lastSpamMessageTime + (BotSettings.MinTimeToSpam * 60)) < messageTime))
                    {
                        lastSpamMessageTime = messageTime;
                        messagesCountFromLastSpam = 0;

                        Random random = new Random();
                        chatBot.SendChatMessage(displayName + " a: http://twitch.tv/" + userName + " és " + BotSettings.Elogis[random.Next(0, BotSettings.Elogis.Length)] + "!!!");
                    }
                    messagesCountFromLastSpam++;
                    messagesCount++;
                }
            }
            else if (BotSettings.SayHelloToEveryoneChecked && !sayedHello)
            {
                SayHello();
            }
        }

        private void SayHello()
        {
            if (BotSettings.SayHelloChecked)
            {
                chatBot.SendChatMessage(BotSettings.HelloWord + " " + displayName + "!");
                sayedHello = true;
            }
        }
    }
}
