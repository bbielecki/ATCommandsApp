namespace ATCommandsApp
{
    partial class Form1
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
            this.modes = new System.Windows.Forms.TabControl();
            this.smsPage = new System.Windows.Forms.TabPage();
            this.label7 = new System.Windows.Forms.Label();
            this.smsNumberComboBox = new System.Windows.Forms.ComboBox();
            this.sendButton = new System.Windows.Forms.Button();
            this.label4 = new System.Windows.Forms.Label();
            this.messageTextBox = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.numberTextBox = new System.Windows.Forms.TextBox();
            this.callPage = new System.Windows.Forms.TabPage();
            this.label6 = new System.Windows.Forms.Label();
            this.selectNumberComboBox = new System.Windows.Forms.ComboBox();
            this.hangUpButton = new System.Windows.Forms.Button();
            this.callButton = new System.Windows.Forms.Button();
            this.label5 = new System.Windows.Forms.Label();
            this.callNumberTextBox = new System.Windows.Forms.TextBox();
            this.diagnosticsPage = new System.Windows.Forms.TabPage();
            this.conncectionComboBox = new System.Windows.Forms.ComboBox();
            this.networkComboBox = new System.Windows.Forms.ComboBox();
            this.deviceInfoComboBox = new System.Windows.Forms.ComboBox();
            this.atCommandButton = new System.Windows.Forms.Button();
            this.logTextBox = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.portText = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.baudRateComboBox = new System.Windows.Forms.ComboBox();
            this.connectButton = new System.Windows.Forms.Button();
            this.disconnectButton = new System.Windows.Forms.Button();
            this.clearLogButton = new System.Windows.Forms.Button();
            this.commandPage = new System.Windows.Forms.TabPage();
            this.commandTextBox = new System.Windows.Forms.TextBox();
            this.commandModeSendButton = new System.Windows.Forms.Button();
            this.label8 = new System.Windows.Forms.Label();
            this.modes.SuspendLayout();
            this.smsPage.SuspendLayout();
            this.callPage.SuspendLayout();
            this.diagnosticsPage.SuspendLayout();
            this.commandPage.SuspendLayout();
            this.SuspendLayout();
            // 
            // modes
            // 
            this.modes.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left)));
            this.modes.Controls.Add(this.smsPage);
            this.modes.Controls.Add(this.callPage);
            this.modes.Controls.Add(this.diagnosticsPage);
            this.modes.Controls.Add(this.commandPage);
            this.modes.Location = new System.Drawing.Point(-1, 64);
            this.modes.Name = "modes";
            this.modes.SelectedIndex = 0;
            this.modes.Size = new System.Drawing.Size(275, 362);
            this.modes.TabIndex = 0;
            // 
            // smsPage
            // 
            this.smsPage.Controls.Add(this.label7);
            this.smsPage.Controls.Add(this.smsNumberComboBox);
            this.smsPage.Controls.Add(this.sendButton);
            this.smsPage.Controls.Add(this.label4);
            this.smsPage.Controls.Add(this.messageTextBox);
            this.smsPage.Controls.Add(this.label3);
            this.smsPage.Controls.Add(this.numberTextBox);
            this.smsPage.Location = new System.Drawing.Point(4, 22);
            this.smsPage.Name = "smsPage";
            this.smsPage.Padding = new System.Windows.Forms.Padding(3);
            this.smsPage.Size = new System.Drawing.Size(267, 336);
            this.smsPage.TabIndex = 0;
            this.smsPage.Text = "SMS";
            this.smsPage.UseVisualStyleBackColor = true;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(10, 74);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(80, 13);
            this.label7.TabIndex = 6;
            this.label7.Text = "Select Number:";
            // 
            // smsNumberComboBox
            // 
            this.smsNumberComboBox.ForeColor = System.Drawing.SystemColors.WindowFrame;
            this.smsNumberComboBox.FormattingEnabled = true;
            this.smsNumberComboBox.Location = new System.Drawing.Point(103, 71);
            this.smsNumberComboBox.Name = "smsNumberComboBox";
            this.smsNumberComboBox.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.smsNumberComboBox.Size = new System.Drawing.Size(150, 21);
            this.smsNumberComboBox.TabIndex = 5;
            this.smsNumberComboBox.Text = "select number...";
            this.smsNumberComboBox.SelectedIndexChanged += new System.EventHandler(this.smsNumberComboBox_SelectedIndexChanged);
            // 
            // sendButton
            // 
            this.sendButton.Location = new System.Drawing.Point(178, 230);
            this.sendButton.Name = "sendButton";
            this.sendButton.Size = new System.Drawing.Size(75, 23);
            this.sendButton.TabIndex = 4;
            this.sendButton.Text = "Send";
            this.sendButton.UseVisualStyleBackColor = true;
            this.sendButton.Click += new System.EventHandler(this.sendButton_Click);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(23, 131);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(53, 13);
            this.label4.TabIndex = 3;
            this.label4.Text = "Message:";
            // 
            // messageTextBox
            // 
            this.messageTextBox.Location = new System.Drawing.Point(13, 147);
            this.messageTextBox.Multiline = true;
            this.messageTextBox.Name = "messageTextBox";
            this.messageTextBox.Size = new System.Drawing.Size(240, 77);
            this.messageTextBox.TabIndex = 2;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(10, 38);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(78, 13);
            this.label3.TabIndex = 1;
            this.label3.Text = "Phone Number";
            // 
            // numberTextBox
            // 
            this.numberTextBox.Location = new System.Drawing.Point(103, 35);
            this.numberTextBox.Name = "numberTextBox";
            this.numberTextBox.Size = new System.Drawing.Size(150, 20);
            this.numberTextBox.TabIndex = 0;
            // 
            // callPage
            // 
            this.callPage.Controls.Add(this.label6);
            this.callPage.Controls.Add(this.selectNumberComboBox);
            this.callPage.Controls.Add(this.hangUpButton);
            this.callPage.Controls.Add(this.callButton);
            this.callPage.Controls.Add(this.label5);
            this.callPage.Controls.Add(this.callNumberTextBox);
            this.callPage.Location = new System.Drawing.Point(4, 22);
            this.callPage.Name = "callPage";
            this.callPage.Padding = new System.Windows.Forms.Padding(3);
            this.callPage.Size = new System.Drawing.Size(267, 336);
            this.callPage.TabIndex = 1;
            this.callPage.Text = "Call";
            this.callPage.UseVisualStyleBackColor = true;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(23, 75);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(80, 13);
            this.label6.TabIndex = 5;
            this.label6.Text = "Select Number:";
            // 
            // selectNumberComboBox
            // 
            this.selectNumberComboBox.FormattingEnabled = true;
            this.selectNumberComboBox.Location = new System.Drawing.Point(109, 72);
            this.selectNumberComboBox.Name = "selectNumberComboBox";
            this.selectNumberComboBox.Size = new System.Drawing.Size(146, 21);
            this.selectNumberComboBox.TabIndex = 4;
            this.selectNumberComboBox.SelectedIndexChanged += new System.EventHandler(this.selectNumberComboBox_SelectedIndexChanged);
            // 
            // hangUpButton
            // 
            this.hangUpButton.Location = new System.Drawing.Point(180, 110);
            this.hangUpButton.Name = "hangUpButton";
            this.hangUpButton.Size = new System.Drawing.Size(75, 23);
            this.hangUpButton.TabIndex = 3;
            this.hangUpButton.Text = "Hang Up";
            this.hangUpButton.UseVisualStyleBackColor = true;
            // 
            // callButton
            // 
            this.callButton.Location = new System.Drawing.Point(70, 110);
            this.callButton.Name = "callButton";
            this.callButton.Size = new System.Drawing.Size(75, 23);
            this.callButton.TabIndex = 2;
            this.callButton.Text = "Call";
            this.callButton.UseVisualStyleBackColor = true;
            this.callButton.Click += new System.EventHandler(this.callButton_Click);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(29, 39);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(67, 13);
            this.label5.TabIndex = 1;
            this.label5.Text = "Call Number:";
            // 
            // callNumberTextBox
            // 
            this.callNumberTextBox.Location = new System.Drawing.Point(109, 36);
            this.callNumberTextBox.Name = "callNumberTextBox";
            this.callNumberTextBox.Size = new System.Drawing.Size(146, 20);
            this.callNumberTextBox.TabIndex = 0;
            // 
            // diagnosticsPage
            // 
            this.diagnosticsPage.Controls.Add(this.conncectionComboBox);
            this.diagnosticsPage.Controls.Add(this.networkComboBox);
            this.diagnosticsPage.Controls.Add(this.deviceInfoComboBox);
            this.diagnosticsPage.Controls.Add(this.atCommandButton);
            this.diagnosticsPage.Location = new System.Drawing.Point(4, 22);
            this.diagnosticsPage.Name = "diagnosticsPage";
            this.diagnosticsPage.Padding = new System.Windows.Forms.Padding(3);
            this.diagnosticsPage.Size = new System.Drawing.Size(267, 336);
            this.diagnosticsPage.TabIndex = 2;
            this.diagnosticsPage.Text = "Diagnostics";
            this.diagnosticsPage.UseVisualStyleBackColor = true;
            // 
            // conncectionComboBox
            // 
            this.conncectionComboBox.FormattingEnabled = true;
            this.conncectionComboBox.Items.AddRange(new object[] {
            "IP Address",
            "Bearer Type",
            "Price per Unit",
            "Connection Status"});
            this.conncectionComboBox.Location = new System.Drawing.Point(66, 168);
            this.conncectionComboBox.Name = "conncectionComboBox";
            this.conncectionComboBox.Size = new System.Drawing.Size(143, 21);
            this.conncectionComboBox.TabIndex = 11;
            this.conncectionComboBox.Text = "Connection Informations";
            this.conncectionComboBox.SelectedIndexChanged += new System.EventHandler(this.conncectionComboBox_SelectedIndexChanged);
            // 
            // networkComboBox
            // 
            this.networkComboBox.FormattingEnabled = true;
            this.networkComboBox.Items.AddRange(new object[] {
            "Signal Strength",
            "Operator Info",
            "Available Networks",
            "Registration",
            "IMSI"});
            this.networkComboBox.Location = new System.Drawing.Point(66, 99);
            this.networkComboBox.Name = "networkComboBox";
            this.networkComboBox.Size = new System.Drawing.Size(143, 21);
            this.networkComboBox.TabIndex = 10;
            this.networkComboBox.Text = "Network Informations";
            this.networkComboBox.SelectedIndexChanged += new System.EventHandler(this.networkComboBox_SelectedIndexChanged);
            // 
            // deviceInfoComboBox
            // 
            this.deviceInfoComboBox.FormattingEnabled = true;
            this.deviceInfoComboBox.Items.AddRange(new object[] {
            "Device Info",
            "IMEI Number",
            "Battery Level"});
            this.deviceInfoComboBox.Location = new System.Drawing.Point(66, 32);
            this.deviceInfoComboBox.Name = "deviceInfoComboBox";
            this.deviceInfoComboBox.Size = new System.Drawing.Size(143, 21);
            this.deviceInfoComboBox.TabIndex = 9;
            this.deviceInfoComboBox.Text = "Device Informations";
            this.deviceInfoComboBox.SelectedIndexChanged += new System.EventHandler(this.deviceInfoComboBox_SelectedIndexChanged);
            // 
            // atCommandButton
            // 
            this.atCommandButton.Location = new System.Drawing.Point(77, 275);
            this.atCommandButton.Name = "atCommandButton";
            this.atCommandButton.Size = new System.Drawing.Size(113, 52);
            this.atCommandButton.TabIndex = 8;
            this.atCommandButton.Text = "List All Supported AT Commands";
            this.atCommandButton.UseVisualStyleBackColor = true;
            this.atCommandButton.Click += new System.EventHandler(this.atCommandButton_Click);
            // 
            // logTextBox
            // 
            this.logTextBox.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.logTextBox.Location = new System.Drawing.Point(276, 86);
            this.logTextBox.Multiline = true;
            this.logTextBox.Name = "logTextBox";
            this.logTextBox.ReadOnly = true;
            this.logTextBox.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.logTextBox.Size = new System.Drawing.Size(207, 308);
            this.logTextBox.TabIndex = 1;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(13, 13);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(66, 13);
            this.label1.TabIndex = 2;
            this.label1.Text = "Port Number";
            // 
            // portText
            // 
            this.portText.ForeColor = System.Drawing.SystemColors.WindowFrame;
            this.portText.Location = new System.Drawing.Point(112, 10);
            this.portText.Name = "portText";
            this.portText.Size = new System.Drawing.Size(100, 20);
            this.portText.TabIndex = 3;
            this.portText.Text = "provide numer";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(13, 39);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(84, 13);
            this.label2.TabIndex = 4;
            this.label2.Text = "Baud Rate [bps]";
            // 
            // baudRateComboBox
            // 
            this.baudRateComboBox.ForeColor = System.Drawing.SystemColors.WindowFrame;
            this.baudRateComboBox.FormattingEnabled = true;
            this.baudRateComboBox.Location = new System.Drawing.Point(112, 36);
            this.baudRateComboBox.Name = "baudRateComboBox";
            this.baudRateComboBox.Size = new System.Drawing.Size(100, 21);
            this.baudRateComboBox.TabIndex = 5;
            this.baudRateComboBox.Text = "select rate...";
            // 
            // connectButton
            // 
            this.connectButton.Location = new System.Drawing.Point(233, 10);
            this.connectButton.Name = "connectButton";
            this.connectButton.Size = new System.Drawing.Size(71, 20);
            this.connectButton.TabIndex = 6;
            this.connectButton.Text = "Connect";
            this.connectButton.UseVisualStyleBackColor = true;
            this.connectButton.Click += new System.EventHandler(this.connectButton_Click);
            // 
            // disconnectButton
            // 
            this.disconnectButton.Location = new System.Drawing.Point(233, 39);
            this.disconnectButton.Name = "disconnectButton";
            this.disconnectButton.Size = new System.Drawing.Size(71, 20);
            this.disconnectButton.TabIndex = 7;
            this.disconnectButton.Text = "Disconnect";
            this.disconnectButton.UseVisualStyleBackColor = true;
            this.disconnectButton.Click += new System.EventHandler(this.disconnectButton_Click);
            // 
            // clearLogButton
            // 
            this.clearLogButton.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.clearLogButton.Location = new System.Drawing.Point(340, 400);
            this.clearLogButton.Name = "clearLogButton";
            this.clearLogButton.Size = new System.Drawing.Size(75, 23);
            this.clearLogButton.TabIndex = 8;
            this.clearLogButton.Text = "Clear Log";
            this.clearLogButton.UseVisualStyleBackColor = true;
            this.clearLogButton.Click += new System.EventHandler(this.clearLogButton_Click);
            // 
            // commandPage
            // 
            this.commandPage.Controls.Add(this.label8);
            this.commandPage.Controls.Add(this.commandModeSendButton);
            this.commandPage.Controls.Add(this.commandTextBox);
            this.commandPage.Location = new System.Drawing.Point(4, 22);
            this.commandPage.Name = "commandPage";
            this.commandPage.Padding = new System.Windows.Forms.Padding(3);
            this.commandPage.Size = new System.Drawing.Size(267, 336);
            this.commandPage.TabIndex = 3;
            this.commandPage.Text = "Command Mode";
            this.commandPage.UseVisualStyleBackColor = true;
            // 
            // commandTextBox
            // 
            this.commandTextBox.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.commandTextBox.Location = new System.Drawing.Point(38, 62);
            this.commandTextBox.Name = "commandTextBox";
            this.commandTextBox.Size = new System.Drawing.Size(195, 20);
            this.commandTextBox.TabIndex = 0;
            // 
            // commandModeSendButton
            // 
            this.commandModeSendButton.Location = new System.Drawing.Point(98, 141);
            this.commandModeSendButton.Name = "commandModeSendButton";
            this.commandModeSendButton.Size = new System.Drawing.Size(75, 23);
            this.commandModeSendButton.TabIndex = 1;
            this.commandModeSendButton.Text = "Send";
            this.commandModeSendButton.UseVisualStyleBackColor = true;
            this.commandModeSendButton.Click += new System.EventHandler(this.commandModeSendButton_Click);
            // 
            // label8
            // 
            this.label8.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(80, 46);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(113, 13);
            this.label8.TabIndex = 2;
            this.label8.Text = "Provide AT Command:";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(481, 425);
            this.Controls.Add(this.clearLogButton);
            this.Controls.Add(this.disconnectButton);
            this.Controls.Add(this.connectButton);
            this.Controls.Add(this.baudRateComboBox);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.portText);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.logTextBox);
            this.Controls.Add(this.modes);
            this.Name = "Form1";
            this.Text = "Form1";
            this.modes.ResumeLayout(false);
            this.smsPage.ResumeLayout(false);
            this.smsPage.PerformLayout();
            this.callPage.ResumeLayout(false);
            this.callPage.PerformLayout();
            this.diagnosticsPage.ResumeLayout(false);
            this.commandPage.ResumeLayout(false);
            this.commandPage.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TabControl modes;
        private System.Windows.Forms.TabPage smsPage;
        private System.Windows.Forms.TabPage callPage;
        private System.Windows.Forms.TextBox logTextBox;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox portText;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.ComboBox baudRateComboBox;
        private System.Windows.Forms.Button connectButton;
        private System.Windows.Forms.Button disconnectButton;
        private System.Windows.Forms.Button sendButton;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox messageTextBox;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox numberTextBox;
        private System.Windows.Forms.TabPage diagnosticsPage;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.ComboBox selectNumberComboBox;
        private System.Windows.Forms.Button hangUpButton;
        private System.Windows.Forms.Button callButton;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox callNumberTextBox;
        private System.Windows.Forms.Button clearLogButton;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.ComboBox smsNumberComboBox;
        private System.Windows.Forms.Button atCommandButton;
        private System.Windows.Forms.ComboBox deviceInfoComboBox;
        private System.Windows.Forms.ComboBox conncectionComboBox;
        private System.Windows.Forms.ComboBox networkComboBox;
        private System.Windows.Forms.TabPage commandPage;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Button commandModeSendButton;
        private System.Windows.Forms.TextBox commandTextBox;
    }
}

