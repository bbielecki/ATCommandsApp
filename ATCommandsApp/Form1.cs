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
                    logTextBox.AppendText("Modem is connected \r Sending message to : " + number);
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
            if (sendATMessage("AT+CGMI\r") == null)
                logTextBox.AppendText("Manufacturer informaton error" + "\n");

        }

        private void batteryButton_Click(object sender, EventArgs e)
        {
            if (sendATMessage("AT+CBC=?\r") == null)
                logTextBox.AppendText("Battery informaton error" + "\n");

        }
        //connect the device, send AT message and return the request
        private string sendATMessage(string ATmessage)
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
            Thread.Sleep(1700);
            string ss = serialPort.ReadExisting();
            if (ss.EndsWith("\r\nOK\r\n"))
            {
                logTextBox.AppendText(ss + "    \n   ");
            }
            else
            {
                return null;
            }
            //TODO: wyciagniej z odpowiedzi tylko info o producencie

            //serialPort.Close();

            return ss;
        }

        private void imeiButton_Click(object sender, EventArgs e)
        {
            string response = sendATMessage("AT+GSN=?\r");
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
            serialPort = new SerialPort(port, baudRate);
            try
            {
                serialPort.Open();
                return true;
            }
            catch (UnauthorizedAccessException ex)
            {
                logTextBox.AppendText("WARNING: port busy \n");
                return false;
            }
        }

        private void disconnectButton_Click(object sender, EventArgs e)
        {
            serialPort.Close();
        }

        private void signalButton_Click(object sender, EventArgs e)
        {
            string response = sendATMessage("AT+CSQ\r");
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
            string response = sendATMessage("AT+COPS?\r");
            if (response == null)
                logTextBox.AppendText("Operator informaton error" + "\n");
        }

        private void registrationButton_Click(object sender, EventArgs e)
        {
            string response = sendATMessage("AT+CREG?\r");
            if (response == null)
                logTextBox.AppendText("Registration informaton error" + "\n");

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
}
