using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Net;
using System.Net.Sockets;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Threading;

namespace ClassTestUDPClient
{
    public partial class Client : Form
    {
        Socket clientSocket = new Socket(AddressFamily.InterNetwork, SocketType.Dgram, ProtocolType.Udp);
        IPAddress ipaddrServer;
        IPAddress ipaddrClient;
        IPEndPoint ipEPointClient;
        IPEndPoint ipEPointServer;
        EndPoint remotePoint;


        IPEndPoint ipEPointSend;
        EndPoint remotePointSend;
        int PORTClient;
        int PORTServer;
        int recvBit;

        bool connectServer = false;
        public Client()
        {
            InitializeComponent();


            

            Thread recvThread = new Thread(ReceiveCall);
            recvThread.Start();
            
            

            
        }
        public void ReceiveCall()
        {

            while (connectServer == false) ;

                try
                {

                    ipEPointClient = new IPEndPoint(ipaddrClient, PORTClient);
                    //remotePoint = new IPEndPoint(ipaddr, PORT);
                    remotePoint = (EndPoint)ipEPointClient;
                    clientSocket.Bind(ipEPointClient);

                    while (true)
                    {
                        byte[] buffRecv = new byte[64];

                        recvBit = clientSocket.ReceiveFrom(buffRecv, buffRecv.Length, SocketFlags.None, ref remotePoint);

                        this.Invoke((MethodInvoker)delegate ()
                        {
                            txtBoxHistory.Text = txtBoxHistory.Text + "Server :" + Encoding.ASCII.GetString(buffRecv, 0, recvBit) + Environment.NewLine;
                        });

                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show("error in " + ex.Message);
                }
            
        }

        private void btnSend_Click(object sender, EventArgs e)
        {

            if (!IPAddress.TryParse(txtBoxIpAddress.Text, out ipaddrServer))
            {
                MessageBox.Show("enter a correct ip address");
                txtBoxIpAddress.Focus();
            }


            if (!int.TryParse(txtBoxServerPortNo.Text.Trim(), out PORTServer) && Convert.ToInt32(txtBoxServerPortNo.Text) > 20000)
            {
                MessageBox.Show("enter a Server correct port No");
                txtBoxServerPortNo.Focus();
            }

            ipEPointSend = new IPEndPoint(ipaddrServer, PORTServer);
            remotePointSend = (EndPoint)ipEPointSend;

            byte[] buffSend = new byte[64];
            buffSend = Encoding.ASCII.GetBytes(this.txtBoxMessage.Text);

            clientSocket.SendTo(buffSend,buffSend.Length,SocketFlags.None, remotePointSend);
            txtBoxHistory.Text = txtBoxHistory.Text + "Client :" + txtBoxMessage.Text + Environment.NewLine;
            txtBoxMessage.Text = "";

        }

        private void Client_Load(object sender, EventArgs e)
        {

        }

        private void btnConnectServer_Click(object sender, EventArgs e)
        {
         


            if (!IPAddress.TryParse(IPAddress.Any.ToString(), out ipaddrClient))
            {
                MessageBox.Show("client IP address is not correct");
                txtBoxIpAddress.Focus();
            }

            if (!int.TryParse(txtBoxClientPortNo.Text.Trim(), out PORTClient) && Convert.ToInt32(txtBoxServerPortNo.Text) > 20000)
            {
                MessageBox.Show("enter a Client correct port No");
                txtBoxClientPortNo.Focus();
            }
            connectServer = true;

        }

        private void Client_FormClosed(object sender, FormClosedEventArgs e)
        {
            if(clientSocket != null)
            {
                if (clientSocket.Connected)
                    clientSocket.Shutdown(SocketShutdown.Both);
                clientSocket.Close();
                clientSocket.Dispose();
            }
        }
    }
}
