using System.Collections.Generic;

namespace TwitchChatBot
{
	public static class BotSettings
	{
		//Ban List
		//public static List<string> BanedChannels { get; } = new List<string>() { "streamlabs" };

		//Missatges de Xat
		public static string HelloWord { get; } = "Hola";
		public static string[] Elogis { get; } = new string[] { "Brutal", "Genial", "Súper Guai", "Espectacular", "Bestial" };

		//Default Settings
		public static int DefaultMinTimeToSpam { get; } = 5;
		public static int DefaultMinMessagesToSpam { get; } = 5;

		//Settings
		public static string OAuthUrl { get; } = "https://twitchtokengenerator.com/quick/nAkaeqVL46";
		public static bool SayHelloChecked { get; set; } = true;
		public static bool SayHelloToEveryoneChecked { get; set; } = true;
		public static bool PromoteChannelsChecked { get; set; } = true;
		public static int MinTimeToSpam { get; set; } = DefaultMinTimeToSpam;
		public static int MinMessagesToSpam { get; set; } = DefaultMinMessagesToSpam;

		//UI Strings
		public static string ChannelTextBoxPlaceholder { get; } = "Nom del canal";
		public static string TwithcUserTextBoxPlaceholder { get; } = "Nom d'usuari";
		public static string OAuthTextBoxPlaceholder { get; } = "OAuth Token";
		public static string SpreadsheetIdPlaceholder { get; } = "Canals o Spreadsheet ID";
		public static string BannedChannelsPlaceholder { get; } = "Canals a ignorar";
	}
}