using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO.Ports;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ATCommandsApp
{
    public partial class Form1 : Form
    {

        private SerialPort serialPort;
        int baudRate = 0;
        string port = "";
        int waitTimeLimit = 2400;

        public Form1()
        {
            InitializeComponent();

            baudRateComboBox.Items.Add(115200);
            baudRateComboBox.Items.Add(9600);
            baudRateComboBox.Items.Add(57600);

            smsNumberComboBox.Items.Add(0048722039871);
            smsNumberComboBox.Items.Add(0048798363893);
            smsNumberComboBox.Items.Add(0048500265550);

            selectNumberComboBox.Items.Add(0048722039871);
            selectNumberComboBox.Items.Add(0048798363893);
            selectNumberComboBox.Items.Add(0048500265550);

            //TODO: usun!
            baudRateComboBox.SelectedItem = 115200;
            portText.Text = "COM3";

        }

        private void sendButton_Click(object sender, EventArgs e)
        {
            string number = numberTextBox.Text;
            string message = messageTextBox.Text;

            if (!isConfigured())
                return;

            if (number.Length > 8)
            {
                if (serialPort == null || !serialPort.IsOpen)
                {
                    if (!openPort())
                        return;
                }

                serialPort.Write("AT+CMGF=1\r");

                Thread.Sleep(1000);

                serialPort.Write("AT+CMGS=\"" + number + "\"\r\n");

                Thread.Sleep(1000);

                serialPort.Write(message + "\x1A");

                string ss = serialPort.ReadExisting();
                if (ss.EndsWith("\r\nOK\r\n"))
                {
                    logTextBox.AppendText("Modem is connected \r Sending message to : " + number + "\n");
                }

                // serialPort.Close();
            }
            else
            {
                logTextBox.AppendText("Wrong phone number : " + number + "\n");
            }

        }

        private void smsNumberComboBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            numberTextBox.Text = smsNumberComboBox.SelectedItem.ToString();
        }


        private bool isConfigured()
        {
            port = portText.Text;

            try
            {
                baudRate = (Int32)baudRateComboBox.SelectedItem;
            }
            catch (NullReferenceException ex)
            {
                Console.WriteLine(ex.ToString());
            }
            if (port.Length > 5 || port.Length < 3)
            {
                logTextBox.AppendText("Provide serial port number \n");
                return false;
            }
            if (baudRate.ToString().Length < 3)
            {
                logTextBox.AppendText("Select Baud Rate \n");
                return false;
            }

            return true;
        }

        private void callButton_Click(object sender, EventArgs e)
        {
            if (!isConfigured())
                return;

            string phoneNumber = callNumberTextBox.Text;

            if (phoneNumber.Length > 8)
            {
                if (serialPort == null || !serialPort.IsOpen)
                {
                    if (!openPort())
                        return;
                }

                Thread.Sleep(1000);

                serialPort.Write("ATD" + phoneNumber + ";\r");
                string ss = serialPort.ReadExisting();
                if (ss.EndsWith("\r\nOK\r\n"))
                {
                    logTextBox.AppendText("Modem is connected \r Calling : " + phoneNumber);
                }
                //serialPort.Close();
            }
            else
            {
                logTextBox.AppendText("Wrong phone number : " + phoneNumber + "\n");
            }
        }

        private void selectNumberComboBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            callNumberTextBox.Text = selectNumberComboBox.SelectedItem.ToString();
        }

        private void brandButton_Click(object sender, EventArgs e)
        {
            if (sendATMessage("AT+CGMI\r", waitTimeLimit, 10) == null)
                logTextBox.AppendText("Manufacturer informaton error" + "\n");

        }

        private void batteryButton_Click(object sender, EventArgs e)
        {
            if (sendATMessage("AT+CBC=?\r", waitTimeLimit, 10) == null)
                logTextBox.AppendText("Battery informaton error" + "\n");

        }
        //connect the device, send AT message and return the request. It takes waitTime 
        //as a maximum waiting time for response and minimum bytesThreshold in buffer
        private string sendATMessage(string ATmessage, int waitTime, int bufferBytesThreshold)
        {
            if (!isConfigured())
                return null;

            if (serialPort == null || !serialPort.IsOpen)
            {
                if (!openPort())
                    return null;
            }

            Thread.Sleep(500);

            serialPort.Write(ATmessage);

            
            string ss = "";
            int counter = waitTime;
            //while (serialPort.BytesToRead < bufferBytesThreshold && counter>0)
            //{
            //    Thread.Sleep(300);
            //    counter -= 300;
                
            //}
            //Thread.Sleep(300);

            while(!ss.EndsWith("\r\nOK\r\n") && !ss.EndsWith("\r\nERROR\r\n")){
                ss += serialPort.ReadExisting();
                Thread.Sleep(300);
                counter -= 300;
            }

            //while(serialPort.BytesToRead>0)
            //    ss += serialPort.ReadExisting();

            if (ss.EndsWith("\r\nOK\r\n"))
            {
                logTextBox.AppendText(ss + "    \n   ");
            }
            else
            {
                return null;
            }
            return ss;
        }

        private void imeiButton_Click(object sender, EventArgs e)
        {
            string response = sendATMessage("AT+GSN=?\r", waitTimeLimit, 15);
            if (response == null || response == "")
                logTextBox.AppendText("IMEI informaton error" + "\n");
            else
            {
                string imei = response.Substring(7);
                logTextBox.AppendText("\n IMEI number: " + imei + "\n");

            }

        }

        private void clearLogButton_Click(object sender, EventArgs e)
        {
            logTextBox.Clear();
        }

        private void connectButton_Click(object sender, EventArgs e)
        {
            openPort();
        }

        private bool openPort()
        {
            port = portText.Text;
            baudRate = (Int32)baudRateComboBox.SelectedItem;
            serialPort = new SerialPort(port, baudRate);
            try
            {
                serialPort.Open();
                logTextBox.AppendText("Port " + port + " is open \n\n");
                return true;
            }
            catch (UnauthorizedAccessException ex)
            {
                logTextBox.AppendText("WARNING: port busy \n\n");
                return false;
            }
        }

        private void disconnectButton_Click(object sender, EventArgs e)
        {
            serialPort.Close();
        }

        private void signalButton_Click(object sender, EventArgs e)
        {
            string response = sendATMessage("AT+CSQ\r", waitTimeLimit, 15);
            if (response == null)
                logTextBox.AppendText("Signal Stregth informaton error" + "\n");

            string[] responseLines = new string[10];
            responseLines = response.Split('\n');
            string signalLine = responseLines[1];
            int coma = signalLine.IndexOf(',');
            int colon = signalLine.IndexOf(':') + 2;
            int strengthLength = coma - colon;
            string signalStregth = signalLine.Substring(colon, strengthLength);
            int signalStrengthValue = Int32.Parse(signalStregth);
            signalStrengthValue = -113 + signalStrengthValue * 2;
            logTextBox.AppendText("Signal stregth = " + signalStrengthValue + "\n");
            logTextBox.AppendText("\n The best stregth level is -53dBm, The worst -109dBm \n");
        }

        private void operatorButton_Click(object sender, EventArgs e)
        {
            string response = sendATMessage("AT+COPS?\r", waitTimeLimit, 15);
            if (response == null)
                logTextBox.AppendText("Operator information error" + "\n");
        }

        private void registrationButton_Click(object sender, EventArgs e)
        {
            string response = sendATMessage("AT+CREG?\r", waitTimeLimit, 10);
            if (response == null)
                logTextBox.AppendText("Registration information error" + "\n");
            else
            {
                string status = response.Substring(response.IndexOf(',') + 1, 1);
                int statusValue = Int32.Parse(status);
                switch (statusValue)
                {
                    case 0:
                        {
                            logTextBox.AppendText("not registered \n");
                            break;
                        }
                    case 1:
                        {
                            logTextBox.AppendText("registered in home network \n");


                            break;
                        }
                    case 2:
                        {
                            logTextBox.AppendText("not registered, searching for network \n");

                            break;
                        }
                    case 3:
                        {
                            logTextBox.AppendText("registration forbidden \n");

                            break;
                        }
                    case 4:
                        {
                            logTextBox.AppendText("unknown status \n");

                            break;
                        }
                    case 5:
                        {
                            logTextBox.AppendText("registered, reoming \n");

                            break;
                        }
                }
            }
        }

        private void bearerTypeButton_Click(object sender, EventArgs e)
        {
            string response = sendATMessage("AT+CBST?\r", waitTimeLimit, 20);
            if (response != null)
            {


                string[] responseRows;
                responseRows = response.Split(' ');
                string infoRow = responseRows[1];
                string[] responseParameters;
                if (infoRow.Contains(','))
                {
                    responseParameters = infoRow.Split(',');
                    if (responseParameters.Length > 2)
                    {
                        int speed = Int32.Parse(responseParameters[0]);
                        int name = Int32.Parse(responseParameters[1]);
                        int mode = Int32.Parse(responseParameters[2].Substring(0, 1));


                        switch (speed)
                        {
                            case 0:
                                logTextBox.AppendText("Data transfer speed = 300b/s \n");
                                break;
                            case 1:
                                logTextBox.AppendText("Data transfer speed = 1200/s \n");
                                break;
                            case 2:
                                logTextBox.AppendText("Data transfer speed = 1200/s \n");
                                break;
                            case 3:
                                logTextBox.AppendText("Data transfer speed = 2400/s \n");
                                break;
                            case 4:
                                logTextBox.AppendText("Data transfer speed = 2400/s \n");
                                break;
                            case 5:
                                logTextBox.AppendText("Data transfer speed = 4800/s \n");
                                break;
                            case 6:
                                logTextBox.AppendText("Data transfer speed = 9600/s \n");
                                break;
                            case 65:
                                logTextBox.AppendText("Data transfer speed = 300/s \n");
                                break;
                            case 66:
                                logTextBox.AppendText("Data transfer speed = 1200/s \n");
                                break;
                            case 68:
                                logTextBox.AppendText("Data transfer speed = 2400/s \n");
                                break;
                            case 70:
                                logTextBox.AppendText("Data transfer speed = 4800/s \n");
                                break;
                            case 71:
                                logTextBox.AppendText("Data transfer speed = 9600/s \n");
                                break;
                        }

                        logTextBox.AppendText("Asynchronous dara circuit mode \n");
                        switch (mode)
                        {
                            case 0:
                                logTextBox.AppendText("Transparent radio connection  \n");
                                break;
                            case 1:
                                logTextBox.AppendText("Not transparent radio connection  \n");
                                break;
                        }
                    }
                }
                else
                {
                    logTextBox.AppendText("Response not valid \n");
                }
            }
            else
            {
                logTextBox.AppendText("Empty response \n");
            }
        }

        private void availableNetworksButton_Click(object sender, EventArgs e)
        {
            logTextBox.Clear();
            logTextBox.AppendText("Please wait, it may take a while... \n");
            logTextBox.AppendText("Up to 25 seconds \n\n");
            string response = sendATMessage("AT+COPS=?\r", 25000, 250);
            if (response == null)
            {
                logTextBox.AppendText("Emty Response \n");
            }
        }

        private void atCommandButton_Click(object sender, EventArgs e)
        {
            logTextBox.Clear();
            logTextBox.AppendText("List of supported AT Commands by this device: \n\n");
            string response = sendATMessage("AT+CLAC\r", waitTimeLimit, 20);

            if (response == null)
                logTextBox.AppendText("Empty Response \n");
        }
    }
}
