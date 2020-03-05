using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Drawing;
using System.Linq;
using System.Net;
using System.Windows.Forms;

namespace TwitchChatBot
{
	public partial class MainForm : Form
	{
		public static Stopwatch stopwatch;
		public static List<string> StreamersListNames { get; } = new List<string>();
		public static List<string> BannedChannels { get; } = new List<string>();

		private ChatBot chatBot;

		public bool BotConnected { get; set; } = false;

		public MainForm()
		{
			stopwatch = new Stopwatch();
			stopwatch.Start();

			InitializeComponent();

			CheckForSavedData();
		}

		/// <summary>
		/// Check if there are some data saved in Settings.Default and insert it in the corresponding textBox.
		/// </summary>
		private void CheckForSavedData()
		{
			//Options Data
			if (Properties.Settings.Default.minTimeToSpam >= minTimeToSpamNumericUpDown.Minimum && Properties.Settings.Default.minTimeToSpam <= minTimeToSpamNumericUpDown.Maximum)
				minTimeToSpamNumericUpDown.Value = BotSettings.MinTimeToSpam = Properties.Settings.Default.minTimeToSpam;
			else
			{
				minTimeToSpamNumericUpDown.Value = BotSettings.MinTimeToSpam = BotSettings.DefaultMinTimeToSpam;
				Properties.Settings.Default.minTimeToSpam = BotSettings.DefaultMinTimeToSpam;
				Properties.Settings.Default.Save();
			}

			if (Properties.Settings.Default.minMessagesToSpam >= minMessagesToSpamNumericUpDown.Minimum && Properties.Settings.Default.minMessagesToSpam <= minMessagesToSpamNumericUpDown.Maximum)
				minMessagesToSpamNumericUpDown.Value = BotSettings.MinMessagesToSpam = Properties.Settings.Default.minMessagesToSpam;
			else
			{
				minMessagesToSpamNumericUpDown.Value = BotSettings.MinMessagesToSpam = BotSettings.DefaultMinMessagesToSpam;
				Properties.Settings.Default.minMessagesToSpam = BotSettings.DefaultMinMessagesToSpam;
				Properties.Settings.Default.Save();
			}

			//Configuration Data
			if (!string.IsNullOrWhiteSpace(Properties.Settings.Default.channelName))
			{
				channelTextBox.Text = Properties.Settings.Default.channelName;
				clearChannelButton.Enabled = true;
			}
			else
				channelTextBox.Text = BotSettings.ChannelTextBoxPlaceholder;

			if (!string.IsNullOrWhiteSpace(Properties.Settings.Default.userName))
			{
				twithcUserTextBox.Text = Properties.Settings.Default.userName;
				clearUserButton.Enabled = true;
			}
			else
				twithcUserTextBox.Text = BotSettings.TwithcUserTextBoxPlaceholder;

			if (!string.IsNullOrWhiteSpace(Properties.Settings.Default.oAuthToken))
			{
				oAuthTextBox.PasswordChar = '*';
				oAuthTextBox.Text = Properties.Settings.Default.oAuthToken;
				clearOAuthButton.Enabled = true;
			}
			else
				oAuthTextBox.Text = BotSettings.OAuthTextBoxPlaceholder;

			if (!string.IsNullOrWhiteSpace(Properties.Settings.Default.spreadSheetID))
			{
				spreadsheetIdTextBox.Text = Properties.Settings.Default.spreadSheetID;
				clearSpreadsheetIdButton.Enabled = true;
			}
			else
				spreadsheetIdTextBox.Text = BotSettings.SpreadsheetIdPlaceholder;

			if (!string.IsNullOrWhiteSpace(Properties.Settings.Default.bannedChannels))
			{
				bannedChannelsTextBox.Text = Properties.Settings.Default.bannedChannels;
				clearBannedChannelsButton.Enabled = true;
			}
			else
				bannedChannelsTextBox.Text = BotSettings.BannedChannelsPlaceholder;
		}

		/// <summary>
		/// Retrieves the list of users in the given spreadsheet ID.
		/// </summary>
		private bool GetSpreadsheetList()
		{
			string json = string.Empty;

			try
			{
				json = new WebClient().DownloadString("https://spreadsheets.google.com/feeds/list/" + Properties.Settings.Default.spreadSheetID + "/od6/public/values?alt=json");
			}
			catch
			{
				ShowMessageBoxError("Error!", "Error on retrieving data from the spreadsheet.\nPlease, check the spreadsheet ID and try again.");
			}

			if (string.IsNullOrEmpty(json)) return false;

			dynamic jsonObj = JsonConvert.DeserializeObject(json);

			if (jsonObj.feed.entry != null)
			{
				foreach (var entry in jsonObj.feed.entry)
				{
					StreamersListNames.Add(entry["title"]["$t"].ToString().Trim().ToLower());
				}

				if (StreamersListNames.Count <= 0)
				{
					ShowMessageBoxError("Error!", "No entries found in the spreadsheet.");
					return false;
				}
			}
			else
			{
				ShowMessageBoxError("Error!", "Error on retrieving data from the spreadsheet.");
				return false;
			}

			return true;
		}

		/// <summary>
		/// Updates UI and call the ChatBot connect function.
		/// </summary>
		private void ConnectChatBot()
		{
			chatBot = new ChatBot(this);
			ChangeConnectionStatusLabel("Connectant...");
			ChangeUserSettingsPannel(false);
			connectDisconnectButton.Enabled = false;
			chatBot.ConnectBot();
		}

		/// <summary>
		/// Shows a Error Message Box.
		/// </summary>
		/// <param name="caption">Title of the Message Box window.</param>
		/// <param name="message">Text in the Message Box window.</param>
		public void ShowMessageBoxError(string caption, string message)
		{
			MessageBox.Show(message, caption, MessageBoxButtons.OK, MessageBoxIcon.Error);
		}

		#region UI Events
		#region ButtonEvents
		private void ConnectDisconnectButton_Click(object sender, EventArgs e)
		{
			StreamersListNames.Clear();
			BannedChannels.Clear();

			if (!BotConnected)
			{
				List<string> errorMessages = new List<string>();
				if (string.IsNullOrWhiteSpace(channelTextBox.Text) || channelTextBox.Text == BotSettings.ChannelTextBoxPlaceholder)
				{
					errorMessages.Add("- No channel name set.");
					channelTextBox.BackColor = Color.Yellow;
				}

				if (string.IsNullOrWhiteSpace(twithcUserTextBox.Text) || twithcUserTextBox.Text == BotSettings.TwithcUserTextBoxPlaceholder)
				{
					errorMessages.Add("- No username set.");
					twithcUserTextBox.BackColor = Color.Yellow;
				}

				if (string.IsNullOrWhiteSpace(oAuthTextBox.Text) || oAuthTextBox.Text == BotSettings.OAuthTextBoxPlaceholder)
				{
					errorMessages.Add("- No OAuth token set.");
					oAuthTextBox.BackColor = Color.Yellow;
				}

				if (((sayHelloCheckBox.Checked && sayHelloRadioButton2.Checked) || promoteChannelsCheckBox.Checked) && (string.IsNullOrWhiteSpace(spreadsheetIdTextBox.Text) || spreadsheetIdTextBox.Text == BotSettings.SpreadsheetIdPlaceholder))
				{
					errorMessages.Add("- No spreadsheet ID set.");
					spreadsheetIdTextBox.BackColor = Color.Yellow;
				}

				if (errorMessages.Count > 0)
				{
					string error = string.Empty;

					foreach (string msg in errorMessages)
						error += msg + "\n";

					error += "\nPlease, fix it and try again.";

					ChangeConnectionStatusLabel("Error!", true);
					ShowMessageBoxError("Configuration Error", error);
				}
				else
				{
					Properties.Settings.Default.channelName = channelTextBox.Text.Trim();
					Properties.Settings.Default.userName = twithcUserTextBox.Text.Trim();
					Properties.Settings.Default.oAuthToken = oAuthTextBox.Text.Trim();
					Properties.Settings.Default.spreadSheetID = spreadsheetIdTextBox.Text.Trim();
					Properties.Settings.Default.bannedChannels = bannedChannelsTextBox.Text.Trim();
					Properties.Settings.Default.Save();

					if (!string.IsNullOrWhiteSpace(bannedChannelsTextBox.Text) && bannedChannelsTextBox.Text != BotSettings.BannedChannelsPlaceholder)
					{
						if (Properties.Settings.Default.bannedChannels.Contains(','))
						{
							string[] bannedUsers = Properties.Settings.Default.bannedChannels.ToLower().Split(',');

							foreach (string user in bannedUsers)
							{
								if (!string.IsNullOrWhiteSpace(user))
									BannedChannels.Add(user.Trim());
							}
						}
						else
						{
							BannedChannels.Add(Properties.Settings.Default.bannedChannels.ToLower());
						}
					}

					if (string.IsNullOrWhiteSpace(spreadsheetIdTextBox.Text) || spreadsheetIdTextBox.Text == BotSettings.SpreadsheetIdPlaceholder)
					{
						promoteChannelsCheckBox.Enabled = false;
						sayHelloRadioButton2.Enabled = false;
					}

					if (Properties.Settings.Default.spreadSheetID.Contains(','))
					{
						string[] users = Properties.Settings.Default.spreadSheetID.ToLower().Split(',');

						foreach (string user in users)
						{
							if (!string.IsNullOrWhiteSpace(user))
								StreamersListNames.Add(user.Trim());
						}

						if (StreamersListNames.Count <= 0)
							ShowMessageBoxError("Error!", "No names found.");
						else
							ConnectChatBot();
					}
					else if (Properties.Settings.Default.spreadSheetID.Length <= 25)
					{
						StreamersListNames.Add(Properties.Settings.Default.spreadSheetID.ToLower());
						ConnectChatBot();
					}
					else
					{
						if (GetSpreadsheetList())
							ConnectChatBot();
					}
				}
			}
			else
			{
				promoteChannelsCheckBox.Enabled = true;
				sayHelloRadioButton2.Enabled = true;
				connectionStatusLabel.Text = "Desconnectant...";
				chatBot.DisconnectBot();
			}
		}

		private void ClearChannelButton_Click(object sender, EventArgs e)
		{
			Properties.Settings.Default.channelName = string.Empty;
			Properties.Settings.Default.Save();

			clearChannelButton.Enabled = false;
			channelTextBox.Text = string.Empty;
		}

		private void ClearUserButton_Click(object sender, EventArgs e)
		{
			Properties.Settings.Default.userName = string.Empty;
			Properties.Settings.Default.Save();

			clearUserButton.Enabled = false;
			twithcUserTextBox.Text = string.Empty;
		}

		private void ClearOAuthButton_Click(object sender, EventArgs e)
		{
			Properties.Settings.Default.oAuthToken = string.Empty;
			Properties.Settings.Default.Save();

			clearOAuthButton.Enabled = false;
			oAuthTextBox.Text = string.Empty;
		}

		private void ClearSpreadsheetIdButton_Click(object sender, EventArgs e)
		{
			Properties.Settings.Default.spreadSheetID = string.Empty;
			Properties.Settings.Default.Save();

			clearSpreadsheetIdButton.Enabled = false;
			spreadsheetIdTextBox.Text = string.Empty;
		}

		private void ClearBannedChannelsButton_Click(object sender, EventArgs e)
		{
			Properties.Settings.Default.bannedChannels = string.Empty;
			Properties.Settings.Default.Save();

			clearBannedChannelsButton.Enabled = false;
			bannedChannelsTextBox.Text = string.Empty;
		}

		private void OAuthLinkLabel_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
		{
			Process.Start(BotSettings.OAuthUrl);
		}

		private void CreatorNameLinkLabel_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
		{
			Process.Start("https://my.bio/devilquest");
		}
		#endregion

		#region CheckBox
		private void SayHelloCheckBox_CheckedChanged(object sender, EventArgs e)
		{
			if (sayHelloCheckBox.Checked)
			{
				BotSettings.SayHelloChecked = true;
				sayHelloRadioButton1.Enabled = true;
				if (!string.IsNullOrWhiteSpace(spreadsheetIdTextBox.Text) && spreadsheetIdTextBox.Text != BotSettings.SpreadsheetIdPlaceholder)
					sayHelloRadioButton2.Enabled = true;
			}
			else
			{
				BotSettings.SayHelloChecked = false;
				sayHelloRadioButton1.Enabled = false;
				sayHelloRadioButton2.Enabled = false;
			}
		}

		private void SayHelloRadioButton_CheckedChanged(object sender, EventArgs e)
		{
			if (sayHelloRadioButton1.Checked)
				BotSettings.SayHelloToEveryoneChecked = true;
			else
				BotSettings.SayHelloToEveryoneChecked = false;
		}

		private void PromoteChannelsCheckBox_CheckedChanged(object sender, EventArgs e)
		{
			if (promoteChannelsCheckBox.Checked)
			{
				BotSettings.PromoteChannelsChecked = true;
				minTimeToSpamLabel.Enabled = true;
				minMessagesToSpamLabel.Enabled = true;
				minTimeToSpamNumericUpDown.Enabled = true;
				minMessagesToSpamNumericUpDown.Enabled = true;
			}
			else
			{
				BotSettings.PromoteChannelsChecked = false;
				minTimeToSpamLabel.Enabled = false;
				minMessagesToSpamLabel.Enabled = false;
				minTimeToSpamNumericUpDown.Enabled = false;
				minMessagesToSpamNumericUpDown.Enabled = false;
			}
		}
		#endregion

		#region TextBoxEvents
		private void ConfigurationTextBox_TextChanged(object sender, EventArgs e)
		{
			TextBox box = (TextBox)sender;
			if (!string.IsNullOrWhiteSpace(box.Text))
			{
				switch (box.Name)
				{
					case "channelTextBox":
						if (channelTextBox.Text != BotSettings.ChannelTextBoxPlaceholder)
						{
							clearChannelButton.Enabled = true;
							box.ForeColor = Color.Black;
						}
						break;
					case "twithcUserTextBox":
						if (twithcUserTextBox.Text != BotSettings.TwithcUserTextBoxPlaceholder)
						{
							clearUserButton.Enabled = true;
							box.ForeColor = Color.Black;
						}
						break;
					case "oAuthTextBox":
						if (oAuthTextBox.Text != BotSettings.OAuthTextBoxPlaceholder)
						{
							box.PasswordChar = '*';
							clearOAuthButton.Enabled = true;
							box.ForeColor = Color.Black;
						}
						break;
					case "spreadsheetIdTextBox":
						if (spreadsheetIdTextBox.Text != BotSettings.SpreadsheetIdPlaceholder)
						{
							clearSpreadsheetIdButton.Enabled = true;
							box.ForeColor = Color.Black;
						}
						break;
					case "bannedChannelsTextBox":
						if (bannedChannelsTextBox.Text != BotSettings.BannedChannelsPlaceholder)
						{
							clearBannedChannelsButton.Enabled = true;
							box.ForeColor = Color.Black;
						}
						break;
				}
			}
		}

		private void ConfigurationTextBox_Enter(object sender, EventArgs e)
		{
			TextBox box = (TextBox)sender;
			switch (box.Name)
			{
				case "channelTextBox":
					if (channelTextBox.Text == BotSettings.ChannelTextBoxPlaceholder)
						box.Text = string.Empty;
					break;
				case "twithcUserTextBox":
					if (twithcUserTextBox.Text == BotSettings.TwithcUserTextBoxPlaceholder)
						box.Text = string.Empty;
					break;
				case "oAuthTextBox":
					if (oAuthTextBox.Text == BotSettings.OAuthTextBoxPlaceholder)
						box.Text = string.Empty;
					break;
				case "spreadsheetIdTextBox":
					if (spreadsheetIdTextBox.Text == BotSettings.SpreadsheetIdPlaceholder)
						box.Text = string.Empty;
					break;
				case "bannedChannelsTextBox":
					if (bannedChannelsTextBox.Text == BotSettings.BannedChannelsPlaceholder)
						box.Text = string.Empty;
					break;
			}

			box.BackColor = SystemColors.Window;
		}

		private void ConfigurationTextBox_Leave(object sender, EventArgs e)
		{
			TextBox box = (TextBox)sender;
			if (string.IsNullOrWhiteSpace(box.Text))
			{
				switch (box.Name)
				{
					case "channelTextBox":
						box.Text = BotSettings.ChannelTextBoxPlaceholder;
						break;
					case "twithcUserTextBox":
						box.Text = BotSettings.TwithcUserTextBoxPlaceholder;
						break;
					case "oAuthTextBox":
						box.PasswordChar = '\0';
						box.Text = BotSettings.OAuthTextBoxPlaceholder;
						break;
					case "spreadsheetIdTextBox":
						box.Text = BotSettings.SpreadsheetIdPlaceholder;
						break;
					case "bannedChannelsTextBox":
						box.Text = BotSettings.BannedChannelsPlaceholder;
						break;
				}
				box.ForeColor = Color.DarkGray;
			}
		}
		#endregion

		#region NumericUpDown
		private void MinTimeToSpamNumericUpDown_ValueChanged(object sender, EventArgs e)
		{
			Properties.Settings.Default.minTimeToSpam = BotSettings.MinTimeToSpam = (int) minTimeToSpamNumericUpDown.Value;
			Properties.Settings.Default.Save();
		}

		private void MinMessagesToSpamNumericUpDown_ValueChanged(object sender, EventArgs e)
		{
			Properties.Settings.Default.minMessagesToSpam = BotSettings.MinMessagesToSpam = (int) minMessagesToSpamNumericUpDown.Value;
			Properties.Settings.Default.Save();
		}
		#endregion
		#endregion

		#region Invoked
		public void ChangeConnectionStatusLabel(string message, bool error = false)
		{
			connectionStatusLabel.BeginInvoke(new Action(() =>
			{
				ChangeConnectionStatusLabelInvoked(message, error);
			}));
		}

		private void ChangeConnectionStatusLabelInvoked(string text, bool error)
		{
			if (error)
				connectionStatusLabel.ForeColor = Color.Red;
			else
				connectionStatusLabel.ForeColor = SystemColors.ControlText;

			connectionStatusLabel.Text = text;
		}

		public void ChangeConnectDisconnectButton(string message)
		{
			connectDisconnectButton.BeginInvoke(new Action(() =>
			{
				ChangeConnectDisconnectButtonInvoked(message);
			}));
		}

		private void ChangeConnectDisconnectButtonInvoked(string text)
		{
			connectDisconnectButton.Text = text;
			connectDisconnectButton.Enabled = true;
		}

		public void ChangeUserSettingsPannel(bool enabled)
		{
			connectDisconnectButton.BeginInvoke(new Action(() =>
			{
				ChangeUserSettingsPannelInvoked(enabled);
			}));
		}

		private void ChangeUserSettingsPannelInvoked(bool enabled)
		{
			userSettingsPanel.Enabled = enabled;
		}


		#endregion
	}
}