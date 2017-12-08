using System;
using System.Net;
using System.Net.Sockets;
using System.Text;
using System.Threading;
using System.Windows.Forms;

namespace UDPClientAndServer
{
    public partial class Form1 : Form
    {
        private bool _stopThreads;
        private UdpClient _udpClient;
        private UdpClient _udpServer;
        private const int ErrorCodeSocketClosed = 10004;
        private const int ErrorCodeOnlyOneInstance = 10048;
        public Form1()
        {
            InitializeComponent();
        }

        private void btSend_Click(object sender, EventArgs e)
        {
            var data = Encoding.UTF8.GetBytes(tbMessageSend.Text);
            _udpClient.Send(data, data.Length);
        }

        protected virtual void OnDataReceivedEvent(ReceivedDataArgs args)
        {
            //DataReceivedEvent?.Invoke(this, args);
            BeginInvoke((MethodInvoker)delegate
            {
                lbMessageReceived.Text = "Message received: " + Encoding.UTF8.GetString(args.ReceivedBytes);
            });
        }

        private void btConnect_Click(object sender, EventArgs e)
        {
            var ipSend = tbIpSend.Text;
            var portSend = Convert.ToInt32(tbPortListen.Text);
            var epClient = new IPEndPoint(IPAddress.Parse(ipSend), portSend);
            _udpClient = new UdpClient();
            _udpClient.Connect(epClient);

            try
            {
                var portListen = Convert.ToInt32(tbPortSend.Text);
                _udpServer = new UdpClient(portListen);
                var epServer = new IPEndPoint(IPAddress.Any, portListen);
                new Thread(() =>
                {
                    while (!_stopThreads)
                    {
                        try
                        {
                            var data = _udpServer.Receive(ref epServer);
                            OnDataReceivedEvent(new ReceivedDataArgs(epServer.Address, epServer.Port, data));
                        }
                        catch (SocketException ex)
                        {
                            if (ex.ErrorCode != ErrorCodeSocketClosed)
                            {
                                throw;
                            }
                        }

                    }
                }).Start();
            }
            catch (SocketException ex)
            {
                if (ex.ErrorCode == ErrorCodeOnlyOneInstance)
                {
                    MessageBox.Show("Listen and send ports of instances must be different!\n" + ex.Message);
                }
                else
                {
                    throw;
                }
            }
        }

        private void Form1_FormClosing(object sender, FormClosingEventArgs e)
        {
            _stopThreads = true;
            if (_udpClient == null || _udpServer == null) return;
            _udpClient.Close();
            _udpServer.Close();
        }
    }

    public class ReceivedDataArgs
    {
        public IPAddress IpAddress { get; set; }
        public int Port { get; set; }
        public byte[] ReceivedBytes;

        public ReceivedDataArgs(IPAddress ipAddress, int port, byte[] data)
        {
            IpAddress = ipAddress;
            Port = port;
            ReceivedBytes = data;
        }
    }
}
