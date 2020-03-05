using System;
using System.Collections.Generic;
using TwitchLib.Client;
using TwitchLib.Client.Events;
using TwitchLib.Client.Models;
using TwitchLib.Communication.Clients;
using TwitchLib.Communication.Events;
using TwitchLib.Communication.Models;

namespace TwitchChatBot
{
    class ChatBot
	{
        private MainForm mainForm;
        private TwitchClient client;
        private Dictionary<string, ChatUser> chatUsersDict = new Dictionary<string, ChatUser>();

        private bool loginError = false;

        public ChatBot(MainForm form)
        {
            mainForm = form;

            ConnectionCredentials credentials = new ConnectionCredentials(Properties.Settings.Default.userName, Properties.Settings.Default.oAuthToken); //20b29n3we4pwn9m26qrw44unp30fpg
            var clientOptions = new ClientOptions
            {
                MessagesAllowedInPeriod = 750,
                ThrottlingPeriod = TimeSpan.FromSeconds(30)
            };
            WebSocketClient customClient = new WebSocketClient(clientOptions);
            client = new TwitchClient(customClient);
            client.Initialize(credentials, Properties.Settings.Default.channelName.ToLower());

            client.OnConnected += Client_OnConnected;
            client.OnJoinedChannel += Client_OnJoinedChannel;
            client.OnMessageReceived += Client_OnMessageReceived;
            client.OnDisconnected += Client_OnDisconnected;

            client.OnIncorrectLogin += Client_OnIncorrectLogin;
            client.OnFailureToReceiveJoinConfirmation += Client_OnFailureToReceiveJoinConfirmation;
            client.OnError += Client_OnError;
        }

        public void ConnectBot()
        {
            client.Connect();
        }

        public void DisconnectBot()
        {
            client.Disconnect();
        }

        public void SendChatMessage(string message)
        {
            client.SendMessage(Properties.Settings.Default.channelName.ToLower(), message);
        }

        #region Client Events
		private void Client_OnConnected(object sender, OnConnectedArgs e)
        {
            mainForm.ChangeConnectionStatusLabel("Entrant al canal...");
            mainForm.ChangeConnectDisconnectButton("Desconnectar");
            mainForm.BotConnected = true;
        }

        private void Client_OnJoinedChannel(object sender, OnJoinedChannelArgs e)
        {
            mainForm.ChangeConnectionStatusLabel("Connectat a: " + char.ToUpper(e.Channel[0]) + e.Channel.Substring(1));
        }

        private void Client_OnMessageReceived(object sender, OnMessageReceivedArgs e)
        {
            if (e.ChatMessage.Username == e.ChatMessage.Channel) return;
            if (MainForm.BannedChannels.Contains(e.ChatMessage.Username.ToLower())) return;

            if (!chatUsersDict.ContainsKey(e.ChatMessage.UserId))
            {
                ChatUser chatUser = new ChatUser(this, e.ChatMessage.Username ,e.ChatMessage.DisplayName);
                chatUsersDict.Add(e.ChatMessage.UserId, chatUser);
            }
            else
                chatUsersDict[e.ChatMessage.UserId].NewMessage();
        }

        private void Client_OnDisconnected(object sender, OnDisconnectedEventArgs e)
        {
            mainForm.BotConnected = false;
            mainForm.ChangeUserSettingsPannel(true);
            mainForm.ChangeConnectionStatusLabel("Desconnectat");
            mainForm.ChangeConnectDisconnectButton("Connectar");
        }
        #endregion

        #region Error Client Events
        private void Client_OnIncorrectLogin(object sender, OnIncorrectLoginArgs e)
        {
            loginError = true;
            mainForm.ChangeConnectionStatusLabel("Error!", true);
            mainForm.ShowMessageBoxError("Authentication Error!", "Login authentication failed!\nPlease, check your credentials and try again.");
        }

        private void Client_OnFailureToReceiveJoinConfirmation(object sender, OnFailureToReceiveJoinConfirmationArgs e)
        {
            if (!loginError && mainForm.BotConnected)
            {
                mainForm.ChangeConnectionStatusLabel("Error!", true);
                mainForm.ShowMessageBoxError("Connection Error!", "Can't connect to " + Properties.Settings.Default.channelName.ToLower() + " channel's!\nPlease, check channel's name and try again.");
                client.Disconnect();
            }
        }

        private void Client_OnError(object sender, OnErrorEventArgs e)
        {
            mainForm.ShowMessageBoxError("Unknown Error!", "Error unknown:\n" + e.Exception.ToString());
        }
        #endregion
    }
}