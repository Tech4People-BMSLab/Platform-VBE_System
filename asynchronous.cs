using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Sockets;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Controls;

namespace VBEApp_v1._0
{
    class asynchronous
        {
            // ManualResetEvent instances signal completion.
            private readonly ManualResetEvent ConnectDone = new ManualResetEvent(false);
            private readonly ManualResetEvent SendDone = new ManualResetEvent(false);
            private readonly ManualResetEvent ReceiveDone = new ManualResetEvent(false);

            // The response from the remote device.
            private Socket client = null;
            private TextBox tab = null;
            private string device_id = null;
            private string command = null;

            public asynchronous()
            {
                pushToLogi("Starting new connection");
                client = new Socket(AddressFamily.InterNetwork, SocketType.Stream, ProtocolType.Tcp);
                client.BeginConnect(MainWindow.remoteEP, (ConnectCallback), client);
                ConnectDone.WaitOne();

            }
            ~asynchronous()
            {
                client.Close();
            }

            private void ConnectCallback(IAsyncResult ar)
            {
                try
                {
                    // Retrieve the socket from the state object.
                    var client = (Socket)ar.AsyncState;

                    // Complete the connection.
                    client.EndConnect(ar);

                    // Signal that the connection has been made.
                    ConnectDone.Set();

                    pushToLogi("Socket connected to {0}" + client.RemoteEndPoint.ToString());
                }
                catch (Exception exc)
                {
                    pushToLogi(exc.ToString());
                }
            }
            public void Send(String data)
            {
                Thread.Sleep(1000);
                // Convert the string data to byte data using ASCII encoding.
                byte[] byteData = Encoding.ASCII.GetBytes(data + Environment.NewLine);

                // Begin sending the data to the remote device.
                client.BeginSend(byteData, 0, byteData.Length, 0, SendCallback, client);
            }

            private void SendCallback(IAsyncResult ar)
            {
                try
                {
                    // Retrieve the socket from the state object.
                    var client = (Socket)ar.AsyncState;
                    // Complete sending the data to the remote device.
                    client.EndSend(ar);
                    // Signal that all bytes have been sent.
                    SendDone.Set();
                }
                catch (Exception e)
                {
                    pushToLogi(e.ToString());
                }
            }

            public void Receive(String device_id, String command)
            {
                try
                {
                    this.device_id = device_id;
                    this.command = command;
                    // Create the state object.
                    var state = new StateObject { WorkSocket = client };

                    // Begin receiving the data from the remote device.
                    client.BeginReceive(state.Buffer, 0, StateObject.BufferSize, 0, ReceiveCallback, state);
                }
                catch (Exception e)
                {
                    pushToLogi(e.ToString());
                }
            }
            private void ReceiveCallback(IAsyncResult ar)
            {
                try
                {
                    String _response = String.Empty;
                    // Retrieve the state object and the client socket 
                    // from the asynchronous state object.
                    var state = (StateObject)ar.AsyncState;
                    var client = state.WorkSocket;

                    // Read data from the remote device.
                    var bytesRead = client.EndReceive(ar);

                    if (bytesRead > 0)
                    {
                        // There might be more data, so store the data received so far.
                        state.Sb.Append(Encoding.ASCII.GetString(state.Buffer, 0, bytesRead));
                        _response = state.Sb.ToString();

                        //################################
                        RecordData.writeEmpatica(device_id, command, _response);
                        state.Sb.Clear();                        

                        ReceiveDone.Set();

                        // Get the rest of the data.
                        client.BeginReceive(state.Buffer, 0, StateObject.BufferSize, 0, ReceiveCallback, state);
                    }
                    else
                    {
                        // All the data has arrived; put it in response.
                        if (state.Sb.Length > 1)
                        {
                            _response = state.Sb.ToString();
                        }
                        // Signal that all bytes have been received.
                        ReceiveDone.Set();
                    }
                }
                catch (Exception e)
                {
                    pushToLogi(e.ToString());
                }
            }

            



           
            private void pushToLogi(string st)
            {
                try
                {
                    MainWindow.form.tbConsole.AppendText(st + Environment.NewLine);
                }
                catch (Exception e)
                {
                    Console.WriteLine("there was a error" + e.ToString());
                }
            }
           
            private void pushToTabi(string st)
            {
                try
                {
                    tab.AppendText(st + Environment.NewLine);
                }
                catch (Exception e)
                {
                    Console.WriteLine("there was a error" + e.ToString());
                }
            }
        }
    }

