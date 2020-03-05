namespace TwitchChatBot
{
	partial class MainForm
	{
		/// <summary>
		/// Required designer variable.
		/// </summary>
		private System.ComponentModel.IContainer components = null;

		/// <summary>
		/// Clean up any resources being used.
		/// </summary>
		/// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
		protected override void Dispose(bool disposing)
		{
			if (disposing && (components != null))
			{
				components.Dispose();
			}
			base.Dispose(disposing);
		}

		#region Windows Form Designer generated code

		/// <summary>
		/// Required method for Designer support - do not modify
		/// the contents of this method with the code editor.
		/// </summary>
		private void InitializeComponent()
		{
			this.components = new System.ComponentModel.Container();
			System.Windows.Forms.Panel OptionsPanel;
			System.Windows.Forms.Label optionsLabel;
			System.Windows.Forms.Label configLabel;
			System.Windows.Forms.Label channelLabel;
			System.Windows.Forms.Label twitchUserLabel;
			System.Windows.Forms.Label oAuthLabel;
			System.Windows.Forms.Label spreadsheetIdLabel;
			System.Windows.Forms.ToolTip infoToolTip;
			System.Windows.Forms.Label madeBylabel;
			System.Windows.Forms.Label bannedChannelsLabel;
			System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MainForm));
			this.minMessagesToSpamNumericUpDown = new System.Windows.Forms.NumericUpDown();
			this.minMessagesToSpamLabel = new System.Windows.Forms.Label();
			this.promoteChannelsCheckBox = new System.Windows.Forms.CheckBox();
			this.sayHelloRadioButton2 = new System.Windows.Forms.RadioButton();
			this.sayHelloRadioButton1 = new System.Windows.Forms.RadioButton();
			this.minTimeToSpamNumericUpDown = new System.Windows.Forms.NumericUpDown();
			this.minTimeToSpamLabel = new System.Windows.Forms.Label();
			this.sayHelloCheckBox = new System.Windows.Forms.CheckBox();
			this.spreadsheetIdTextBox = new System.Windows.Forms.TextBox();
			this.oAuthLinkLabel = new System.Windows.Forms.LinkLabel();
			this.oAuthTextBox = new System.Windows.Forms.TextBox();
			this.twithcUserTextBox = new System.Windows.Forms.TextBox();
			this.channelTextBox = new System.Windows.Forms.TextBox();
			this.connectDisconnectButton = new System.Windows.Forms.Button();
			this.connectionStatusLabel = new System.Windows.Forms.Label();
			this.userSettingsPanel = new System.Windows.Forms.Panel();
			this.clearSpreadsheetIdButton = new System.Windows.Forms.Button();
			this.clearOAuthButton = new System.Windows.Forms.Button();
			this.clearUserButton = new System.Windows.Forms.Button();
			this.clearChannelButton = new System.Windows.Forms.Button();
			this.creatorNameLinkLabel = new System.Windows.Forms.LinkLabel();
			this.clearBannedChannelsButton = new System.Windows.Forms.Button();
			this.bannedChannelsTextBox = new System.Windows.Forms.TextBox();
			OptionsPanel = new System.Windows.Forms.Panel();
			optionsLabel = new System.Windows.Forms.Label();
			configLabel = new System.Windows.Forms.Label();
			channelLabel = new System.Windows.Forms.Label();
			twitchUserLabel = new System.Windows.Forms.Label();
			oAuthLabel = new System.Windows.Forms.Label();
			spreadsheetIdLabel = new System.Windows.Forms.Label();
			infoToolTip = new System.Windows.Forms.ToolTip(this.components);
			madeBylabel = new System.Windows.Forms.Label();
			bannedChannelsLabel = new System.Windows.Forms.Label();
			OptionsPanel.SuspendLayout();
			((System.ComponentModel.ISupportInitialize)(this.minMessagesToSpamNumericUpDown)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.minTimeToSpamNumericUpDown)).BeginInit();
			this.userSettingsPanel.SuspendLayout();
			this.SuspendLayout();
			// 
			// OptionsPanel
			// 
			OptionsPanel.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
			OptionsPanel.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
			OptionsPanel.Controls.Add(this.minMessagesToSpamNumericUpDown);
			OptionsPanel.Controls.Add(this.minMessagesToSpamLabel);
			OptionsPanel.Controls.Add(this.promoteChannelsCheckBox);
			OptionsPanel.Controls.Add(this.sayHelloRadioButton2);
			OptionsPanel.Controls.Add(this.sayHelloRadioButton1);
			OptionsPanel.Controls.Add(this.minTimeToSpamNumericUpDown);
			OptionsPanel.Controls.Add(this.minTimeToSpamLabel);
			OptionsPanel.Controls.Add(this.sayHelloCheckBox);
			OptionsPanel.Location = new System.Drawing.Point(12, 110);
			OptionsPanel.Margin = new System.Windows.Forms.Padding(10);
			OptionsPanel.Name = "OptionsPanel";
			OptionsPanel.Size = new System.Drawing.Size(255, 167);
			OptionsPanel.TabIndex = 2;
			// 
			// minMessagesToSpamNumericUpDown
			// 
			this.minMessagesToSpamNumericUpDown.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
			this.minMessagesToSpamNumericUpDown.Location = new System.Drawing.Point(167, 131);
			this.minMessagesToSpamNumericUpDown.Name = "minMessagesToSpamNumericUpDown";
			this.minMessagesToSpamNumericUpDown.Size = new System.Drawing.Size(81, 20);
			this.minMessagesToSpamNumericUpDown.TabIndex = 6;
			this.minMessagesToSpamNumericUpDown.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
			infoToolTip.SetToolTip(this.minMessagesToSpamNumericUpDown, "Mínim número de missatges que un usuari ha d’enviar al xat perquè el “Bot” torni " +
        "a promocionar el seu canal.");
			this.minMessagesToSpamNumericUpDown.Value = new decimal(new int[] {
            5,
            0,
            0,
            0});
			this.minMessagesToSpamNumericUpDown.ValueChanged += new System.EventHandler(this.MinMessagesToSpamNumericUpDown_ValueChanged);
			// 
			// minMessagesToSpamLabel
			// 
			this.minMessagesToSpamLabel.AutoSize = true;
			this.minMessagesToSpamLabel.Location = new System.Drawing.Point(38, 133);
			this.minMessagesToSpamLabel.Margin = new System.Windows.Forms.Padding(3);
			this.minMessagesToSpamLabel.Name = "minMessagesToSpamLabel";
			this.minMessagesToSpamLabel.Size = new System.Drawing.Size(109, 13);
			this.minMessagesToSpamLabel.TabIndex = 6;
			this.minMessagesToSpamLabel.Text = "Interval de missatges:";
			infoToolTip.SetToolTip(this.minMessagesToSpamLabel, "Mínim número de missatges que un usuari ha d’enviar al xat perquè el “Bot” torni " +
        "a promocionar el seu canal.");
			// 
			// promoteChannelsCheckBox
			// 
			this.promoteChannelsCheckBox.AutoSize = true;
			this.promoteChannelsCheckBox.Checked = true;
			this.promoteChannelsCheckBox.CheckState = System.Windows.Forms.CheckState.Checked;
			this.promoteChannelsCheckBox.Location = new System.Drawing.Point(8, 86);
			this.promoteChannelsCheckBox.Margin = new System.Windows.Forms.Padding(8, 8, 8, 1);
			this.promoteChannelsCheckBox.Name = "promoteChannelsCheckBox";
			this.promoteChannelsCheckBox.Size = new System.Drawing.Size(122, 17);
			this.promoteChannelsCheckBox.TabIndex = 4;
			this.promoteChannelsCheckBox.Text = "Promocionar canals:";
			this.promoteChannelsCheckBox.UseVisualStyleBackColor = true;
			this.promoteChannelsCheckBox.CheckedChanged += new System.EventHandler(this.PromoteChannelsCheckBox_CheckedChanged);
			// 
			// sayHelloRadioButton2
			// 
			this.sayHelloRadioButton2.AutoSize = true;
			this.sayHelloRadioButton2.Location = new System.Drawing.Point(38, 58);
			this.sayHelloRadioButton2.Name = "sayHelloRadioButton2";
			this.sayHelloRadioButton2.Size = new System.Drawing.Size(156, 17);
			this.sayHelloRadioButton2.TabIndex = 3;
			this.sayHelloRadioButton2.Text = "Només als usuaris del llistat.";
			infoToolTip.SetToolTip(this.sayHelloRadioButton2, "La funció de saludar només s’activarà si l’usuari que parla per primer cop en el " +
        "xat és al llistat configurat a l’apartat “Nom dels Canals o Spreadsheet ID”.");
			this.sayHelloRadioButton2.UseVisualStyleBackColor = true;
			// 
			// sayHelloRadioButton1
			// 
			this.sayHelloRadioButton1.AutoSize = true;
			this.sayHelloRadioButton1.Checked = true;
			this.sayHelloRadioButton1.Location = new System.Drawing.Point(38, 35);
			this.sayHelloRadioButton1.Name = "sayHelloRadioButton1";
			this.sayHelloRadioButton1.Size = new System.Drawing.Size(70, 17);
			this.sayHelloRadioButton1.TabIndex = 2;
			this.sayHelloRadioButton1.TabStop = true;
			this.sayHelloRadioButton1.Text = "A tothom.";
			infoToolTip.SetToolTip(this.sayHelloRadioButton1, "Saludarà a tots els usuaris que parlin per primer cop al xat.");
			this.sayHelloRadioButton1.UseVisualStyleBackColor = true;
			this.sayHelloRadioButton1.CheckedChanged += new System.EventHandler(this.SayHelloRadioButton_CheckedChanged);
			// 
			// minTimeToSpamNumericUpDown
			// 
			this.minTimeToSpamNumericUpDown.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
			this.minTimeToSpamNumericUpDown.Location = new System.Drawing.Point(167, 105);
			this.minTimeToSpamNumericUpDown.Name = "minTimeToSpamNumericUpDown";
			this.minTimeToSpamNumericUpDown.Size = new System.Drawing.Size(81, 20);
			this.minTimeToSpamNumericUpDown.TabIndex = 5;
			this.minTimeToSpamNumericUpDown.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
			infoToolTip.SetToolTip(this.minTimeToSpamNumericUpDown, "Mínim numero de minuts que han de passar per que el “Bot” promocioni el canal per" +
        " segon cop.");
			this.minTimeToSpamNumericUpDown.Value = new decimal(new int[] {
            5,
            0,
            0,
            0});
			this.minTimeToSpamNumericUpDown.ValueChanged += new System.EventHandler(this.MinTimeToSpamNumericUpDown_ValueChanged);
			// 
			// minTimeToSpamLabel
			// 
			this.minTimeToSpamLabel.AutoSize = true;
			this.minTimeToSpamLabel.Location = new System.Drawing.Point(38, 107);
			this.minTimeToSpamLabel.Margin = new System.Windows.Forms.Padding(3);
			this.minTimeToSpamLabel.Name = "minTimeToSpamLabel";
			this.minTimeToSpamLabel.Size = new System.Drawing.Size(93, 13);
			this.minTimeToSpamLabel.TabIndex = 1;
			this.minTimeToSpamLabel.Text = "Interval en minuts:";
			infoToolTip.SetToolTip(this.minTimeToSpamLabel, "Mínim numero de minuts que han de passar per que el “Bot” promocioni el canal per" +
        " segon cop.");
			// 
			// sayHelloCheckBox
			// 
			this.sayHelloCheckBox.AutoSize = true;
			this.sayHelloCheckBox.Checked = true;
			this.sayHelloCheckBox.CheckState = System.Windows.Forms.CheckState.Checked;
			this.sayHelloCheckBox.Location = new System.Drawing.Point(8, 14);
			this.sayHelloCheckBox.Margin = new System.Windows.Forms.Padding(8, 8, 8, 1);
			this.sayHelloCheckBox.Name = "sayHelloCheckBox";
			this.sayHelloCheckBox.Size = new System.Drawing.Size(65, 17);
			this.sayHelloCheckBox.TabIndex = 1;
			this.sayHelloCheckBox.Text = "Saludar:";
			infoToolTip.SetToolTip(this.sayHelloCheckBox, "Si està marcada el “Bot” enviarà al xat el missatge “Hola + (Nom de l’usuari del " +
        "Xat)” el primer cop que un usuari parli pel xat del canal configurat.");
			this.sayHelloCheckBox.UseVisualStyleBackColor = true;
			this.sayHelloCheckBox.CheckedChanged += new System.EventHandler(this.SayHelloCheckBox_CheckedChanged);
			// 
			// optionsLabel
			// 
			optionsLabel.AutoSize = true;
			optionsLabel.Location = new System.Drawing.Point(18, 103);
			optionsLabel.Name = "optionsLabel";
			optionsLabel.Size = new System.Drawing.Size(49, 13);
			optionsLabel.TabIndex = 3;
			optionsLabel.Text = "Opcions:";
			// 
			// configLabel
			// 
			configLabel.AutoSize = true;
			configLabel.Location = new System.Drawing.Point(18, 283);
			configLabel.Name = "configLabel";
			configLabel.Size = new System.Drawing.Size(66, 13);
			configLabel.TabIndex = 5;
			configLabel.Text = "Configuració";
			// 
			// channelLabel
			// 
			channelLabel.AutoSize = true;
			channelLabel.Location = new System.Drawing.Point(5, 15);
			channelLabel.Margin = new System.Windows.Forms.Padding(3, 5, 3, 0);
			channelLabel.Name = "channelLabel";
			channelLabel.Size = new System.Drawing.Size(37, 13);
			channelLabel.TabIndex = 1;
			channelLabel.Text = "Canal:";
			infoToolTip.SetToolTip(channelLabel, "Nom del canal de xat de Twitch al que es vol connectar.");
			// 
			// twitchUserLabel
			// 
			twitchUserLabel.AutoSize = true;
			twitchUserLabel.Location = new System.Drawing.Point(5, 60);
			twitchUserLabel.Margin = new System.Windows.Forms.Padding(3, 5, 3, 0);
			twitchUserLabel.Name = "twitchUserLabel";
			twitchUserLabel.Size = new System.Drawing.Size(40, 13);
			twitchUserLabel.TabIndex = 3;
			twitchUserLabel.Text = "Usuari:";
			infoToolTip.SetToolTip(twitchUserLabel, "El teu nom d’usuari de Twitch.");
			// 
			// oAuthLabel
			// 
			oAuthLabel.AutoSize = true;
			oAuthLabel.Location = new System.Drawing.Point(5, 105);
			oAuthLabel.Margin = new System.Windows.Forms.Padding(3, 5, 3, 0);
			oAuthLabel.Name = "oAuthLabel";
			oAuthLabel.Size = new System.Drawing.Size(70, 13);
			oAuthLabel.TabIndex = 5;
			oAuthLabel.Text = "OAuth token:";
			infoToolTip.SetToolTip(oAuthLabel, "Cadena d’autentificació amb els permisos de `chat:read` i `chat:edit`.");
			// 
			// spreadsheetIdLabel
			// 
			spreadsheetIdLabel.AutoSize = true;
			spreadsheetIdLabel.Location = new System.Drawing.Point(5, 150);
			spreadsheetIdLabel.Margin = new System.Windows.Forms.Padding(3, 5, 3, 0);
			spreadsheetIdLabel.Name = "spreadsheetIdLabel";
			spreadsheetIdLabel.Size = new System.Drawing.Size(174, 13);
			spreadsheetIdLabel.TabIndex = 7;
			spreadsheetIdLabel.Text = "Nom dels canals o Spreadsheet ID:";
			infoToolTip.SetToolTip(spreadsheetIdLabel, "Nom del canal o canals a promocionar (separats per comes).\r\nTambé es pot utilitza" +
        "r un Spreadsheet ID (Google Spreadsheets) amb el llistat de canals a promocionar" +
        " a la primera columna.");
			// 
			// infoToolTip
			// 
			infoToolTip.AutoPopDelay = 20000;
			infoToolTip.InitialDelay = 500;
			infoToolTip.ReshowDelay = 100;
			// 
			// spreadsheetIdTextBox
			// 
			this.spreadsheetIdTextBox.ForeColor = System.Drawing.Color.DarkGray;
			this.spreadsheetIdTextBox.Location = new System.Drawing.Point(5, 165);
			this.spreadsheetIdTextBox.Margin = new System.Windows.Forms.Padding(5, 2, 5, 5);
			this.spreadsheetIdTextBox.Name = "spreadsheetIdTextBox";
			this.spreadsheetIdTextBox.Size = new System.Drawing.Size(216, 20);
			this.spreadsheetIdTextBox.TabIndex = 14;
			infoToolTip.SetToolTip(this.spreadsheetIdTextBox, "Nom del canal o canals a promocionar (separats per comes).\r\nTambé es pot utilitza" +
        "r un Spreadsheet ID (Google Spreadsheets) amb el llistat de canals a promocionar" +
        " a la primera columna.");
			this.spreadsheetIdTextBox.TextChanged += new System.EventHandler(this.ConfigurationTextBox_TextChanged);
			this.spreadsheetIdTextBox.Enter += new System.EventHandler(this.ConfigurationTextBox_Enter);
			this.spreadsheetIdTextBox.Leave += new System.EventHandler(this.ConfigurationTextBox_Leave);
			// 
			// oAuthLinkLabel
			// 
			this.oAuthLinkLabel.AutoSize = true;
			this.oAuthLinkLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.oAuthLinkLabel.LinkBehavior = System.Windows.Forms.LinkBehavior.HoverUnderline;
			this.oAuthLinkLabel.Location = new System.Drawing.Point(74, 104);
			this.oAuthLinkLabel.Name = "oAuthLinkLabel";
			this.oAuthLinkLabel.Size = new System.Drawing.Size(19, 13);
			this.oAuthLinkLabel.TabIndex = 6;
			this.oAuthLinkLabel.TabStop = true;
			this.oAuthLinkLabel.Text = "(?)";
			infoToolTip.SetToolTip(this.oAuthLinkLabel, "Clic per obtenir el codi OAuth.\r\nTambé pots visitar: https://twitchtokengenerator" +
        ".com\r\nPermisos necessaris:\r\n- chat:read\r\n- chat:edit");
			this.oAuthLinkLabel.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.OAuthLinkLabel_LinkClicked);
			// 
			// oAuthTextBox
			// 
			this.oAuthTextBox.ForeColor = System.Drawing.Color.DarkGray;
			this.oAuthTextBox.Location = new System.Drawing.Point(5, 120);
			this.oAuthTextBox.Margin = new System.Windows.Forms.Padding(5, 2, 5, 5);
			this.oAuthTextBox.Name = "oAuthTextBox";
			this.oAuthTextBox.Size = new System.Drawing.Size(216, 20);
			this.oAuthTextBox.TabIndex = 12;
			infoToolTip.SetToolTip(this.oAuthTextBox, "Cadena d’autentificació amb els permisos de `chat:read` i `chat:edit`.");
			this.oAuthTextBox.TextChanged += new System.EventHandler(this.ConfigurationTextBox_TextChanged);
			this.oAuthTextBox.Enter += new System.EventHandler(this.ConfigurationTextBox_Enter);
			this.oAuthTextBox.Leave += new System.EventHandler(this.ConfigurationTextBox_Leave);
			// 
			// twithcUserTextBox
			// 
			this.twithcUserTextBox.ForeColor = System.Drawing.Color.DarkGray;
			this.twithcUserTextBox.Location = new System.Drawing.Point(5, 75);
			this.twithcUserTextBox.Margin = new System.Windows.Forms.Padding(5, 2, 5, 5);
			this.twithcUserTextBox.Name = "twithcUserTextBox";
			this.twithcUserTextBox.Size = new System.Drawing.Size(216, 20);
			this.twithcUserTextBox.TabIndex = 10;
			infoToolTip.SetToolTip(this.twithcUserTextBox, "El teu nom d’usuari de Twitch.");
			this.twithcUserTextBox.TextChanged += new System.EventHandler(this.ConfigurationTextBox_TextChanged);
			this.twithcUserTextBox.Enter += new System.EventHandler(this.ConfigurationTextBox_Enter);
			this.twithcUserTextBox.Leave += new System.EventHandler(this.ConfigurationTextBox_Leave);
			// 
			// channelTextBox
			// 
			this.channelTextBox.ForeColor = System.Drawing.Color.DarkGray;
			this.channelTextBox.Location = new System.Drawing.Point(5, 30);
			this.channelTextBox.Margin = new System.Windows.Forms.Padding(5, 2, 5, 5);
			this.channelTextBox.Name = "channelTextBox";
			this.channelTextBox.Size = new System.Drawing.Size(216, 20);
			this.channelTextBox.TabIndex = 8;
			infoToolTip.SetToolTip(this.channelTextBox, "Nom del canal de xat de Twitch al que es vol connectar.");
			this.channelTextBox.TextChanged += new System.EventHandler(this.ConfigurationTextBox_TextChanged);
			this.channelTextBox.Enter += new System.EventHandler(this.ConfigurationTextBox_Enter);
			this.channelTextBox.Leave += new System.EventHandler(this.ConfigurationTextBox_Leave);
			// 
			// madeBylabel
			// 
			madeBylabel.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
			madeBylabel.AutoSize = true;
			madeBylabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 6.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			madeBylabel.Location = new System.Drawing.Point(93, 538);
			madeBylabel.Name = "madeBylabel";
			madeBylabel.Size = new System.Drawing.Size(43, 12);
			madeBylabel.TabIndex = 6;
			madeBylabel.Text = "Made by ";
			// 
			// connectDisconnectButton
			// 
			this.connectDisconnectButton.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
			this.connectDisconnectButton.BackColor = System.Drawing.SystemColors.ControlLight;
			this.connectDisconnectButton.FlatAppearance.BorderColor = System.Drawing.SystemColors.ControlDarkDark;
			this.connectDisconnectButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
			this.connectDisconnectButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.connectDisconnectButton.Location = new System.Drawing.Point(60, 40);
			this.connectDisconnectButton.Name = "connectDisconnectButton";
			this.connectDisconnectButton.Size = new System.Drawing.Size(159, 57);
			this.connectDisconnectButton.TabIndex = 0;
			this.connectDisconnectButton.Text = "Connectar";
			this.connectDisconnectButton.UseVisualStyleBackColor = false;
			this.connectDisconnectButton.Click += new System.EventHandler(this.ConnectDisconnectButton_Click);
			// 
			// connectionStatusLabel
			// 
			this.connectionStatusLabel.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
			this.connectionStatusLabel.AutoEllipsis = true;
			this.connectionStatusLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.connectionStatusLabel.Location = new System.Drawing.Point(12, 9);
			this.connectionStatusLabel.Name = "connectionStatusLabel";
			this.connectionStatusLabel.Size = new System.Drawing.Size(255, 21);
			this.connectionStatusLabel.TabIndex = 1;
			this.connectionStatusLabel.Text = "Desconnectat";
			this.connectionStatusLabel.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
			// 
			// userSettingsPanel
			// 
			this.userSettingsPanel.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
			this.userSettingsPanel.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
			this.userSettingsPanel.Controls.Add(this.clearBannedChannelsButton);
			this.userSettingsPanel.Controls.Add(bannedChannelsLabel);
			this.userSettingsPanel.Controls.Add(this.bannedChannelsTextBox);
			this.userSettingsPanel.Controls.Add(this.clearSpreadsheetIdButton);
			this.userSettingsPanel.Controls.Add(this.clearOAuthButton);
			this.userSettingsPanel.Controls.Add(this.clearUserButton);
			this.userSettingsPanel.Controls.Add(this.clearChannelButton);
			this.userSettingsPanel.Controls.Add(spreadsheetIdLabel);
			this.userSettingsPanel.Controls.Add(this.spreadsheetIdTextBox);
			this.userSettingsPanel.Controls.Add(oAuthLabel);
			this.userSettingsPanel.Controls.Add(this.oAuthTextBox);
			this.userSettingsPanel.Controls.Add(twitchUserLabel);
			this.userSettingsPanel.Controls.Add(this.twithcUserTextBox);
			this.userSettingsPanel.Controls.Add(channelLabel);
			this.userSettingsPanel.Controls.Add(this.channelTextBox);
			this.userSettingsPanel.Controls.Add(this.oAuthLinkLabel);
			this.userSettingsPanel.Location = new System.Drawing.Point(12, 290);
			this.userSettingsPanel.Name = "userSettingsPanel";
			this.userSettingsPanel.Size = new System.Drawing.Size(255, 245);
			this.userSettingsPanel.TabIndex = 4;
			// 
			// clearSpreadsheetIdButton
			// 
			this.clearSpreadsheetIdButton.Enabled = false;
			this.clearSpreadsheetIdButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.clearSpreadsheetIdButton.Location = new System.Drawing.Point(226, 164);
			this.clearSpreadsheetIdButton.Margin = new System.Windows.Forms.Padding(0, 3, 3, 3);
			this.clearSpreadsheetIdButton.Name = "clearSpreadsheetIdButton";
			this.clearSpreadsheetIdButton.Size = new System.Drawing.Size(22, 22);
			this.clearSpreadsheetIdButton.TabIndex = 13;
			this.clearSpreadsheetIdButton.Text = "X";
			this.clearSpreadsheetIdButton.UseVisualStyleBackColor = true;
			this.clearSpreadsheetIdButton.Click += new System.EventHandler(this.ClearSpreadsheetIdButton_Click);
			// 
			// clearOAuthButton
			// 
			this.clearOAuthButton.Enabled = false;
			this.clearOAuthButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.clearOAuthButton.Location = new System.Drawing.Point(226, 119);
			this.clearOAuthButton.Margin = new System.Windows.Forms.Padding(0, 3, 3, 3);
			this.clearOAuthButton.Name = "clearOAuthButton";
			this.clearOAuthButton.Size = new System.Drawing.Size(22, 22);
			this.clearOAuthButton.TabIndex = 11;
			this.clearOAuthButton.Text = "X";
			this.clearOAuthButton.UseVisualStyleBackColor = true;
			this.clearOAuthButton.Click += new System.EventHandler(this.ClearOAuthButton_Click);
			// 
			// clearUserButton
			// 
			this.clearUserButton.Enabled = false;
			this.clearUserButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.clearUserButton.Location = new System.Drawing.Point(226, 74);
			this.clearUserButton.Margin = new System.Windows.Forms.Padding(0, 3, 3, 3);
			this.clearUserButton.Name = "clearUserButton";
			this.clearUserButton.Size = new System.Drawing.Size(22, 22);
			this.clearUserButton.TabIndex = 9;
			this.clearUserButton.Text = "X";
			this.clearUserButton.UseVisualStyleBackColor = true;
			this.clearUserButton.Click += new System.EventHandler(this.ClearUserButton_Click);
			// 
			// clearChannelButton
			// 
			this.clearChannelButton.Enabled = false;
			this.clearChannelButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.clearChannelButton.Location = new System.Drawing.Point(226, 29);
			this.clearChannelButton.Margin = new System.Windows.Forms.Padding(0, 3, 3, 3);
			this.clearChannelButton.Name = "clearChannelButton";
			this.clearChannelButton.Size = new System.Drawing.Size(22, 22);
			this.clearChannelButton.TabIndex = 7;
			this.clearChannelButton.Text = "X";
			this.clearChannelButton.UseVisualStyleBackColor = true;
			this.clearChannelButton.Click += new System.EventHandler(this.ClearChannelButton_Click);
			// 
			// creatorNameLinkLabel
			// 
			this.creatorNameLinkLabel.ActiveLinkColor = System.Drawing.Color.DarkGreen;
			this.creatorNameLinkLabel.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
			this.creatorNameLinkLabel.AutoSize = true;
			this.creatorNameLinkLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 6.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.creatorNameLinkLabel.LinkColor = System.Drawing.Color.LimeGreen;
			this.creatorNameLinkLabel.Location = new System.Drawing.Point(131, 538);
			this.creatorNameLinkLabel.Name = "creatorNameLinkLabel";
			this.creatorNameLinkLabel.Size = new System.Drawing.Size(60, 12);
			this.creatorNameLinkLabel.TabIndex = 7;
			this.creatorNameLinkLabel.TabStop = true;
			this.creatorNameLinkLabel.Text = "Devilquest";
			this.creatorNameLinkLabel.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.CreatorNameLinkLabel_LinkClicked);
			// 
			// clearBannedChannelsButton
			// 
			this.clearBannedChannelsButton.Enabled = false;
			this.clearBannedChannelsButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.clearBannedChannelsButton.Location = new System.Drawing.Point(226, 209);
			this.clearBannedChannelsButton.Margin = new System.Windows.Forms.Padding(0, 3, 3, 3);
			this.clearBannedChannelsButton.Name = "clearBannedChannelsButton";
			this.clearBannedChannelsButton.Size = new System.Drawing.Size(22, 22);
			this.clearBannedChannelsButton.TabIndex = 16;
			this.clearBannedChannelsButton.Text = "X";
			this.clearBannedChannelsButton.UseVisualStyleBackColor = true;
			this.clearBannedChannelsButton.Click += new System.EventHandler(this.ClearBannedChannelsButton_Click);
			// 
			// bannedChannelsLabel
			// 
			bannedChannelsLabel.AutoSize = true;
			bannedChannelsLabel.Location = new System.Drawing.Point(5, 195);
			bannedChannelsLabel.Margin = new System.Windows.Forms.Padding(3, 5, 3, 0);
			bannedChannelsLabel.Name = "bannedChannelsLabel";
			bannedChannelsLabel.Size = new System.Drawing.Size(86, 13);
			bannedChannelsLabel.TabIndex = 15;
			bannedChannelsLabel.Text = "Canals a ignorar:";
			infoToolTip.SetToolTip(bannedChannelsLabel, "Nom del canal o canals a ignorar (separats per comes).");
			// 
			// bannedChannelsTextBox
			// 
			this.bannedChannelsTextBox.ForeColor = System.Drawing.Color.DarkGray;
			this.bannedChannelsTextBox.Location = new System.Drawing.Point(5, 209);
			this.bannedChannelsTextBox.Margin = new System.Windows.Forms.Padding(5, 2, 5, 5);
			this.bannedChannelsTextBox.Name = "bannedChannelsTextBox";
			this.bannedChannelsTextBox.Size = new System.Drawing.Size(216, 20);
			this.bannedChannelsTextBox.TabIndex = 17;
			infoToolTip.SetToolTip(this.bannedChannelsTextBox, "Nom del canal o canals a ignorar (separats per comes).");
			this.bannedChannelsTextBox.TextChanged += new System.EventHandler(this.ConfigurationTextBox_TextChanged);
			this.bannedChannelsTextBox.Enter += new System.EventHandler(this.ConfigurationTextBox_Enter);
			this.bannedChannelsTextBox.Leave += new System.EventHandler(this.ConfigurationTextBox_Leave);
			// 
			// MainForm
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.ClientSize = new System.Drawing.Size(279, 557);
			this.Controls.Add(this.creatorNameLinkLabel);
			this.Controls.Add(madeBylabel);
			this.Controls.Add(configLabel);
			this.Controls.Add(this.userSettingsPanel);
			this.Controls.Add(optionsLabel);
			this.Controls.Add(this.connectionStatusLabel);
			this.Controls.Add(this.connectDisconnectButton);
			this.Controls.Add(OptionsPanel);
			this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
			this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
			this.MaximizeBox = false;
			this.Name = "MainForm";
			this.Text = "Twitch Chat Bot";
			OptionsPanel.ResumeLayout(false);
			OptionsPanel.PerformLayout();
			((System.ComponentModel.ISupportInitialize)(this.minMessagesToSpamNumericUpDown)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.minTimeToSpamNumericUpDown)).EndInit();
			this.userSettingsPanel.ResumeLayout(false);
			this.userSettingsPanel.PerformLayout();
			this.ResumeLayout(false);
			this.PerformLayout();

		}

		#endregion

		private System.Windows.Forms.Button connectDisconnectButton;
		private System.Windows.Forms.Label connectionStatusLabel;
		private System.Windows.Forms.RadioButton sayHelloRadioButton2;
		private System.Windows.Forms.RadioButton sayHelloRadioButton1;
		private System.Windows.Forms.CheckBox sayHelloCheckBox;
		private System.Windows.Forms.Label minTimeToSpamLabel;
		private System.Windows.Forms.NumericUpDown minTimeToSpamNumericUpDown;
		private System.Windows.Forms.CheckBox promoteChannelsCheckBox;
		private System.Windows.Forms.NumericUpDown minMessagesToSpamNumericUpDown;
		private System.Windows.Forms.Label minMessagesToSpamLabel;
		private System.Windows.Forms.Panel userSettingsPanel;
		private System.Windows.Forms.TextBox channelTextBox;
		private System.Windows.Forms.TextBox spreadsheetIdTextBox;
		private System.Windows.Forms.TextBox oAuthTextBox;
		private System.Windows.Forms.TextBox twithcUserTextBox;
		private System.Windows.Forms.Button clearChannelButton;
		private System.Windows.Forms.Button clearSpreadsheetIdButton;
		private System.Windows.Forms.Button clearOAuthButton;
		private System.Windows.Forms.Button clearUserButton;
		private System.Windows.Forms.LinkLabel oAuthLinkLabel;
		private System.Windows.Forms.LinkLabel creatorNameLinkLabel;
		private System.Windows.Forms.Button clearBannedChannelsButton;
		private System.Windows.Forms.TextBox bannedChannelsTextBox;
	}
}

