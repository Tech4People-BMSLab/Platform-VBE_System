using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Net.Sockets;

namespace WindowsFormsApplication1
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