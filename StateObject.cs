﻿using System.Net.Sockets;
using System.Text;

namespace VBEApp_v1._0
{
    public class StateObject
    {
        // Client socket.
        public Socket WorkSocket;
        // Size of receive buffer.
        public const int BufferSize = 4096;
        // Receive buffer.
        public readonly byte[] Buffer = new byte[BufferSize];
        // Received data string.
        public readonly StringBuilder Sb = new StringBuilder();
    }
}