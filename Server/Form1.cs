using System;
using System.Windows.Forms;
using System.Net.Sockets;
using System.Net;
using System.Collections.Generic;
using System.Text;

namespace Server {
    public partial class Form1 : Form {

        public static bool ISAlarmeON = false;

        private static byte[] _buffer = new byte[1024];
        private static List<Socket> _ClientSockets = new List<Socket>();
        private static Socket _ServerSocket = new Socket(AddressFamily.InterNetwork, SocketType.Stream, ProtocolType.Tcp);

        public Form1() {
            InitializeComponent();
            SetupServer();
        }

        private static void SetupServer() {
            _ServerSocket.Bind(new IPEndPoint(IPAddress.Any, 1996));
            _ServerSocket.Listen(1);
            _ServerSocket.BeginAccept(new AsyncCallback(AcceptCallBack), null);
        }

        private static void AcceptCallBack(IAsyncResult AR) {
            Socket socket = _ServerSocket.EndAccept(AR);
            _ClientSockets.Add(socket);
            socket.BeginReceive(_buffer, 0, _buffer.Length, SocketFlags.None, new AsyncCallback(ReceiveCallBack), socket);
            _ServerSocket.BeginAccept(new AsyncCallback(AcceptCallBack), null);
        }
        private static void ReceiveCallBack(IAsyncResult AR) {
            Socket socket = (Socket)AR.AsyncState;
            int received = socket.EndReceive(AR);
            byte[] dataBuff = new byte[received];
            Array.Copy(_buffer, dataBuff, received);
            string text = Encoding.ASCII.GetString(dataBuff);

            string Response = string.Empty;

            if (text.ToLower() != "ISAlarmeON") {
                Response = "Invalid";
            } else {
                if (ISAlarmeON == true) {
                    Response = "yes";
                } else {
                    Response = "no";
                }
            }

            byte[] data = Encoding.ASCII.GetBytes(text);
            socket.BeginSend(data, 0, data.Length, SocketFlags.None, new AsyncCallback(SendCallBack), socket);
            socket.BeginReceive(_buffer, 0, _buffer.Length, SocketFlags.None, new AsyncCallback(ReceiveCallBack), socket);
        }

        private static void SendCallBack(IAsyncResult AR) {
            Socket socket = (Socket)AR.AsyncState;
            socket.EndSend(AR);
        }

        private void CMD_BTN_Click(object sender, EventArgs e) {
            ISAlarmeON = true;
        }
    }
}
