using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Net;
using System.Net.Sockets;
using System.Threading;
using System.Text.RegularExpressions;
using System.Diagnostics;
using CaptureManagerToCSharpProxy;
using CaptureManagerToCSharpProxy.Interfaces;


namespace WindowsFormsApplication1
{
    public partial class Form1 : Form
    {
        public static Form1 form = null;
        public static IPEndPoint remoteEP = null;
        public delegate void agr0();
        public delegate void agr1(string st);
        public static bool record = false;

        public Form1()
        {
            InitializeComponent();
            Form1.form = this;
            this.AutoSize = true;
            this.AutoSizeMode = AutoSizeMode.GrowAndShrink;
            IPAddress ipAddress = IPAddress.Parse(tbServerIP.Text);
            int port = Convert.ToInt32(tbServerPort.Text);
            Form1.remoteEP = new IPEndPoint(ipAddress, port);
        }

        private void btnLaunchBLEServer_Click(object sender, EventArgs e)
        {
            System.Diagnostics.Process.Start(@"C:\Program Files (x86)\Empatica\EmpaticaBLEServer\EmpaticaBLEServer.exe");
        }
        
        public void btnConnect_Click(object sender, EventArgs e)
        {
            var mesg = "device_list";
            string data = synchronousConnect(mesg);
            string deviceNo = getNumberOfDevices(data);
            Form1.form.pushToLog("Number Of devices =" + deviceNo);
            if (deviceNo != null)
            {
                //get device IDs of device detected and display in Combo box
                int numberOfDevice = Convert.ToInt16(deviceNo);
                string[] deviceIDs = new string[numberOfDevice];
                deviceIDs = getDeviceIDList(data);
                for (int i = 0; i < numberOfDevice; i++)
                {
                    cbDeviceList.Items.Add(deviceIDs[i]);
                }
            }
            else
            {
                Form1.form.pushToLog("No Empatica detected");
            }
        }



            //CONNECT DEVICES TO EMPATICA BLE SERVER                                
            // for (int i = 0; i <Convert.ToInt16(deviceNo); i++)
            // {
            //     String connectMsgString = "device_connect " + deviceIDs[i] + Environment.NewLine;

            //     // Send the data through the socket.
            //     byte[] connectMsg = Encoding.ASCII.GetBytes(connectMsgString);
            //     bytesSent = client.Send(connectMsg);
            //     rTxtBox.AppendText(Encoding.ASCII.GetString(connectMsg, 0, bytesSent) + Environment.NewLine);

            //     // Receive the response from the remote device.
            //     bytesRec = client.Receive(bytes);
            //     data = Encoding.ASCII.GetString(bytes, 0, bytesRec);
            //     rTxtBox.AppendText(data+Environment.NewLine);
            // }

        private void btnStart_Click(object sender, EventArgs e)
        {
            string device_id = cbDeviceList.SelectedItem.ToString();
            string type = cbCmdList.SelectedItem.ToString();
            try
            {
                asynchronous cl = new asynchronous();

                TabPage tabPage = new System.Windows.Forms.TabPage();
                this.tabControl1.Controls.Add(tabPage);

                // 
                // tabPage1
                // 
                tabPage.Location = new System.Drawing.Point(4, 25);
                tabPage.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
                tabPage.Name = device_id;
                tabPage.Padding = new System.Windows.Forms.Padding(3, 2, 3, 2);
                tabPage.Size = new System.Drawing.Size(549, 224);
                tabPage.TabIndex = 0;
                tabPage.Text = device_id;
                tabPage.UseVisualStyleBackColor = true;

                TextBox textBox = new System.Windows.Forms.TextBox();
                tabPage.Controls.Add(textBox);
                textBox.Location = new System.Drawing.Point(6, 6);
                textBox.Multiline = true;
                textBox.Name = device_id;
                textBox.Size = new System.Drawing.Size(537, 212);
                textBox.TabIndex = 0;

                cl.Send("device_connect " + device_id);
                cl.ReceiveOnTab(textBox, device_id, type);
                cl.Send("device_subscribe " + type + " ON");
            }
            catch (Exception exc)
            {
                Form1.form.pushToLog(exc.ToString());
            }
        }
        private void btnStartAll_Click(object sender, EventArgs e)
        {
            for (int i = 0; i < cbDeviceList.Items.Count; i++)
            //foreach ( var d in cbDeviceList.Items )
            {
                string device = cbDeviceList.GetItemText(cbDeviceList.Items[i]);
                foreach (var c in cbCmdList.Items)
                {
                    string command = c.ToString();
                    try
                    {
                        asynchronous cl = new asynchronous();
                        TabPage tabPage = new System.Windows.Forms.TabPage();
                        this.tabControl1.Controls.Add(tabPage);
                        //tabPage1
                        tabPage.Location = new System.Drawing.Point(4, 25);
                        tabPage.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
                        tabPage.Name = device + "-" + command;
                        tabPage.Padding = new System.Windows.Forms.Padding(3, 2, 3, 2);
                        tabPage.Size = new System.Drawing.Size(549, 224);
                        tabPage.TabIndex = 0;
                        tabPage.Text = device + "-" + command;
                        tabPage.UseVisualStyleBackColor = true;

                        TextBox textBox = new System.Windows.Forms.TextBox();
                        tabPage.Controls.Add(textBox);
                        textBox.Location = new System.Drawing.Point(6, 6);
                        textBox.Multiline = true;
                        textBox.Name = device;
                        textBox.Size = new System.Drawing.Size(537, 212);
                        textBox.TabIndex = 0;
                        tbConsole.AppendText("connecting device-" + device);

                        cl.Send("device_connect " + device);
                        cl.ReceiveOnTab(textBox, device, command);
                        cl.Send("device_subscribe " + command + " ON");

                    }
                    catch (Exception exc)
                    {
                        Form1.form.pushToLog(exc.ToString());
                    }
                }
            }
        }
        private void btnRecordSession_Click(object sender, EventArgs e)
        {
            //startAll();
            RecordData.start((System.Diagnostics.Stopwatch.GetTimestamp()).ToString());
            record = true;
        }

        private void btnStopSession_Click(object sender, EventArgs e)
        {
            record = false;
        }
        
        private string getNumberOfDevices(string input)
        {
            if (input != null)
            {
                string numberOfDevicesPattern = (@"\s\d\s");
                foreach (Match match in Regex.Matches(input, numberOfDevicesPattern))
                    return (match.Value);
            }
            else
            {
                return null;
            }
            return "Socket not connected";
        }
        private string[] getDeviceIDList(string input)
        {
            if (input != null)
            {

                string deviceIdPattern = (@"(?<!\S)(\w{6})(?!\S)");
                string[] deviceIDArray;
                List<String> listTemp = new List<string>();
                int i = 0;
                foreach (Match match in Regex.Matches(input, deviceIdPattern))
                {
                    listTemp.Add(match.ToString());
                    i++;
                }
                deviceIDArray = listTemp.ToArray<String>();
                return deviceIDArray;
            }
            else
            {
                return null;
            }
        }
        private string synchronousConnect(string mesg)
        {
            byte[] bytes = new byte[1024];

            // Create a TCP/IP  socket.
            Socket client = new Socket(AddressFamily.InterNetwork, SocketType.Stream, ProtocolType.Tcp);
            try
            {
                client.Connect(Form1.remoteEP);
                Form1.form.pushToLog("Socket Connected to" + client.RemoteEndPoint.ToString());
                // Encode the data string into a byte array.
                string msg = mesg + Environment.NewLine;
                // Send the data through the socket.
                int bytesSent = client.Send(Encoding.ASCII.GetBytes(msg));
                // Receive the response from the remote device.
                int bytesRec = client.Receive(bytes);
                var data = Encoding.ASCII.GetString(bytes, 0, bytesRec);
                //show messgae received from Server on Form Console
                Form1.form.pushToLog(data);
                //get number of devices detected and show on form console
                client.Close();
                return data;

            }
            catch (Exception exc)
            {
                Form1.form.pushToLog(exc.ToString());
                return null;
            }
        }        


        private void pushToLog(string mesg)
        {
            tbConsole.AppendText(mesg + Environment.NewLine);
        }
        
        private void startAll()
        {
            int i = 0;
            do
            {
                string device = cbDeviceList.GetItemText(cbDeviceList.Items[i]);
                foreach (var c in cbCmdList.Items)
                {
                    string command = c.ToString();
                    try
                    {
                        asynchronous cl = new asynchronous();
                        cl.Send("device_connect " + device);
                        cl.Receive(device, command);
                        cl.Send("device_subscribe " + command + " ON");
                    }
                    catch (Exception exc)
                    {
                        Form1.form.pushToLog(exc.ToString());
                    }
                }
                i++;
            }
            while (i < cbDeviceList.Items.Count);
            if (i == (cbDeviceList.Items.Count))
            {
                Form1.form.pushToLog("Device initialization Complete!!");
            }
        }

        
    }
}

