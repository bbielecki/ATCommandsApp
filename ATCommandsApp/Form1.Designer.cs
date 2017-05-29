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
            this.tabControl1 = new System.Windows.Forms.TabControl();
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
            this.availableNetworksButton = new System.Windows.Forms.Button();
            this.bearerTypeButton = new System.Windows.Forms.Button();
            this.registrationButton = new System.Windows.Forms.Button();
            this.operatorButton = new System.Windows.Forms.Button();
            this.signalButton = new System.Windows.Forms.Button();
            this.imeiButton = new System.Windows.Forms.Button();
            this.batteryButton = new System.Windows.Forms.Button();
            this.brandButton = new System.Windows.Forms.Button();
            this.logTextBox = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.portText = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.baudRateComboBox = new System.Windows.Forms.ComboBox();
            this.connectButton = new System.Windows.Forms.Button();
            this.disconnectButton = new System.Windows.Forms.Button();
            this.clearLogButton = new System.Windows.Forms.Button();
            this.atCommandButton = new System.Windows.Forms.Button();
            this.tabControl1.SuspendLayout();
            this.smsPage.SuspendLayout();
            this.callPage.SuspendLayout();
            this.diagnosticsPage.SuspendLayout();
            this.SuspendLayout();
            // 
            // tabControl1
            // 
            this.tabControl1.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left)));
            this.tabControl1.Controls.Add(this.smsPage);
            this.tabControl1.Controls.Add(this.callPage);
            this.tabControl1.Controls.Add(this.diagnosticsPage);
            this.tabControl1.Location = new System.Drawing.Point(-1, 64);
            this.tabControl1.Name = "tabControl1";
            this.tabControl1.SelectedIndex = 0;
            this.tabControl1.Size = new System.Drawing.Size(275, 362);
            this.tabControl1.TabIndex = 0;
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
            this.diagnosticsPage.Controls.Add(this.atCommandButton);
            this.diagnosticsPage.Controls.Add(this.availableNetworksButton);
            this.diagnosticsPage.Controls.Add(this.bearerTypeButton);
            this.diagnosticsPage.Controls.Add(this.registrationButton);
            this.diagnosticsPage.Controls.Add(this.operatorButton);
            this.diagnosticsPage.Controls.Add(this.signalButton);
            this.diagnosticsPage.Controls.Add(this.imeiButton);
            this.diagnosticsPage.Controls.Add(this.batteryButton);
            this.diagnosticsPage.Controls.Add(this.brandButton);
            this.diagnosticsPage.Location = new System.Drawing.Point(4, 22);
            this.diagnosticsPage.Name = "diagnosticsPage";
            this.diagnosticsPage.Padding = new System.Windows.Forms.Padding(3);
            this.diagnosticsPage.Size = new System.Drawing.Size(267, 336);
            this.diagnosticsPage.TabIndex = 2;
            this.diagnosticsPage.Text = "Diagnostics";
            this.diagnosticsPage.UseVisualStyleBackColor = true;
            // 
            // availableNetworksButton
            // 
            this.availableNetworksButton.Location = new System.Drawing.Point(131, 182);
            this.availableNetworksButton.Name = "availableNetworksButton";
            this.availableNetworksButton.Size = new System.Drawing.Size(120, 23);
            this.availableNetworksButton.TabIndex = 7;
            this.availableNetworksButton.Text = "Available Networks";
            this.availableNetworksButton.UseVisualStyleBackColor = true;
            this.availableNetworksButton.Click += new System.EventHandler(this.availableNetworksButton_Click);
            // 
            // bearerTypeButton
            // 
            this.bearerTypeButton.Location = new System.Drawing.Point(13, 182);
            this.bearerTypeButton.Name = "bearerTypeButton";
            this.bearerTypeButton.Size = new System.Drawing.Size(75, 23);
            this.bearerTypeButton.TabIndex = 6;
            this.bearerTypeButton.Text = "Bearer Type";
            this.bearerTypeButton.UseVisualStyleBackColor = true;
            this.bearerTypeButton.Click += new System.EventHandler(this.bearerTypeButton_Click);
            // 
            // registrationButton
            // 
            this.registrationButton.Location = new System.Drawing.Point(158, 126);
            this.registrationButton.Name = "registrationButton";
            this.registrationButton.Size = new System.Drawing.Size(75, 23);
            this.registrationButton.TabIndex = 5;
            this.registrationButton.Text = "registration";
            this.registrationButton.UseVisualStyleBackColor = true;
            this.registrationButton.Click += new System.EventHandler(this.registrationButton_Click);
            // 
            // operatorButton
            // 
            this.operatorButton.Location = new System.Drawing.Point(13, 126);
            this.operatorButton.Name = "operatorButton";
            this.operatorButton.Size = new System.Drawing.Size(75, 23);
            this.operatorButton.TabIndex = 4;
            this.operatorButton.Text = "operator";
            this.operatorButton.UseVisualStyleBackColor = true;
            this.operatorButton.Click += new System.EventHandler(this.operatorButton_Click);
            // 
            // signalButton
            // 
            this.signalButton.Location = new System.Drawing.Point(149, 76);
            this.signalButton.Name = "signalButton";
            this.signalButton.Size = new System.Drawing.Size(94, 23);
            this.signalButton.TabIndex = 3;
            this.signalButton.Text = "Signal Strength";
            this.signalButton.UseVisualStyleBackColor = true;
            this.signalButton.Click += new System.EventHandler(this.signalButton_Click);
            // 
            // imeiButton
            // 
            this.imeiButton.Location = new System.Drawing.Point(13, 76);
            this.imeiButton.Name = "imeiButton";
            this.imeiButton.Size = new System.Drawing.Size(75, 23);
            this.imeiButton.TabIndex = 2;
            this.imeiButton.Text = "IMEI";
            this.imeiButton.UseVisualStyleBackColor = true;
            this.imeiButton.Click += new System.EventHandler(this.imeiButton_Click);
            // 
            // batteryButton
            // 
            this.batteryButton.Location = new System.Drawing.Point(158, 26);
            this.batteryButton.Name = "batteryButton";
            this.batteryButton.Size = new System.Drawing.Size(75, 23);
            this.batteryButton.TabIndex = 1;
            this.batteryButton.Text = "Battery";
            this.batteryButton.UseVisualStyleBackColor = true;
            this.batteryButton.Click += new System.EventHandler(this.batteryButton_Click);
            // 
            // brandButton
            // 
            this.brandButton.Location = new System.Drawing.Point(13, 27);
            this.brandButton.Name = "brandButton";
            this.brandButton.Size = new System.Drawing.Size(75, 23);
            this.brandButton.TabIndex = 0;
            this.brandButton.Text = "Device";
            this.brandButton.UseVisualStyleBackColor = true;
            this.brandButton.Click += new System.EventHandler(this.brandButton_Click);
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
            // atCommandButton
            // 
            this.atCommandButton.Location = new System.Drawing.Point(13, 233);
            this.atCommandButton.Name = "atCommandButton";
            this.atCommandButton.Size = new System.Drawing.Size(75, 52);
            this.atCommandButton.TabIndex = 8;
            this.atCommandButton.Text = "Supported AT Commands";
            this.atCommandButton.UseVisualStyleBackColor = true;
            this.atCommandButton.Click += new System.EventHandler(this.atCommandButton_Click);
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
            this.Controls.Add(this.tabControl1);
            this.Name = "Form1";
            this.Text = "Form1";
            this.tabControl1.ResumeLayout(false);
            this.smsPage.ResumeLayout(false);
            this.smsPage.PerformLayout();
            this.callPage.ResumeLayout(false);
            this.callPage.PerformLayout();
            this.diagnosticsPage.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TabControl tabControl1;
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
        private System.Windows.Forms.Button brandButton;
        private System.Windows.Forms.Button batteryButton;
        private System.Windows.Forms.Button imeiButton;
        private System.Windows.Forms.Button signalButton;
        private System.Windows.Forms.Button operatorButton;
        private System.Windows.Forms.Button registrationButton;
        private System.Windows.Forms.Button bearerTypeButton;
        private System.Windows.Forms.Button availableNetworksButton;
        private System.Windows.Forms.Button atCommandButton;
    }
}

