using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Net.NetworkInformation;
using System.Net;
using System.Threading;


namespace NetworkScannerHome
{
    public partial class Form1 : Form
    {
        string[] maskedIp;
        string[] maskedSubnet;
        int s1=0, s2=0, s3=0, s4=0;
        int[] maskedIpDigit = new int[4] { 010,011,020,188};
        int[] maskedSubnetDigit = new int[4] { 255,255,255,000};
        Ping p = new Ping();
        PingReply preply;
        String ipAdd;
        public Form1()
        {
            InitializeComponent();
        }

        private void button_Check_Status_Click(object sender, EventArgs e)
        {
            
           
            //ipAdd = maskedTextBoxIP.Text;
            // class c subnet mask
            

            ThreadStart threadCall = delegate {
                callIpMask(maskedIpDigit, maskedSubnetDigit);
            };
            Thread threadObj = new Thread(threadCall);
            threadObj.Start();
        }

        private void callIpMask(int[] maskedIpDigit, int[] maskedSubnetDigit)
        {
            try
            {
                if (maskedSubnetDigit[0] == 255 && maskedSubnetDigit[1] == 255
                && maskedSubnetDigit[2] == 255
                && maskedSubnetDigit[3] == 0)
                {
                    for (int i = 187; i <= 195; i++)
                    {

                        ipAdd = maskedIpDigit[0].ToString() + "." +
                            maskedIpDigit[1].ToString() + "." +
                            maskedIpDigit[2].ToString() + "." +
                            i.ToString();



                        preply = p.Send(ipAdd);

                        if (preply.Status == IPStatus.Success)

                        {
                            this.Invoke((MethodInvoker)delegate ()
                            {
                                listResult.Items.Add(ipAdd + "-[UP]");
                            });

                        }
                        else
                        {
                            this.Invoke((MethodInvoker)delegate ()
                            {
                                listResult.Items.Add(ipAdd.ToString() + "-[Down]");
                            });

                        }



                    }
                }
            }
            catch
            {
                MessageBox.Show("range of ip address is out ");
            }
            
        }

        private void maskedTextBoxIP_Leave(object sender, EventArgs e)
        {

            string ipaddress = maskedTextBoxIP.Text;
            maskedIp = ipaddress.Split('.');
            
          
                
                maskedIpDigit[0] = Convert.ToInt32(maskedIp[0]);
                maskedIpDigit[1] = Convert.ToInt32(maskedIp[1]);
                maskedIpDigit[2] = Convert.ToInt32(maskedIp[2]);
                maskedIpDigit[3] = Convert.ToInt32(maskedIp[3]);
         

                for (int i = 0; i < maskedIp.Length; i++)
                {
                    if ((maskedIpDigit[i] < 0) || (maskedIpDigit[i] > 255))
                    {
                        maskedTextBoxIP.Text = "000000000000";
                        maskedTextBoxIP.ForeColor = Color.Red;

                        MessageBox.Show("enter valid ip");
                    }
                    else
                    {
                        maskedTextBoxIP.ForeColor = Color.Black;
                    }
                }
            
         
            
        }

        private void maskedTextBoxIP_Enter(object sender, EventArgs e)
        {
            maskedTextBoxIP.ForeColor = Color.Black;
        }

        private void maskedTextBoxIP_MaskInputRejected(object sender, MaskInputRejectedEventArgs e)
        {

        }

        private void listResult_SelectedIndexChanged(object sender, EventArgs e)
        {
            string selectedIpAddress = listResult.SelectedItem.ToString();
            string[] selectedIpOnly = selectedIpAddress.Split('-');

            lblResult.Text = selectedIpOnly[0];
        }

        private void btnCheckPort_Click(object sender, EventArgs e)
        {

            IPGlobalProperties ipProperties = IPGlobalProperties.GetIPGlobalProperties();

            IPEndPoint[] endPoints = ipProperties.GetActiveTcpListeners();
            TcpConnectionInformation[] tcpConnections = ipProperties.GetActiveTcpConnections();



            string selectedIP = lblResult.Text.ToString();
            listPort.Items.Clear();

            foreach (TcpConnectionInformation item in tcpConnections)
            {

                
               if (selectedIP == item.LocalEndPoint.Address.ToString())
                {
                    listPort.Items.Add(item.LocalEndPoint.Address.ToString() + ":" 
                        + item.LocalEndPoint.Port.ToString());
               }
                if (selectedIP == item.RemoteEndPoint.Address.ToString())
                {
                    listPort.Items.Add(item.RemoteEndPoint.Address.ToString() + ":"
                        + item.RemoteEndPoint.Port.ToString());
                }


            }
          /*
            foreach (TcpConnectionInformation info in tcpConnections)
            {
                Console.WriteLine("Local : " + info.LocalEndPoint.Address.ToString()
                + ":" + info.LocalEndPoint.Port.ToString()

                + "\nRemote : " + info.RemoteEndPoint.Address.ToString()
                + ":" + info.RemoteEndPoint.Port.ToString()

                + "\nState : " + info.State.ToString() + "\n\n");
            }
          */
        }

        private void maskedTextBoxSubnetMask_MaskInputRejected(object sender, MaskInputRejectedEventArgs e)
        {

        }

        private void maskedTextBoxSubnetMask_Leave(object sender, EventArgs e)
        {
            maskedSubnet = maskedTextBoxSubnetMask .Text.Split('.');
            

            for (int i = 0; i < maskedSubnet.Length; i++)
            {
                
            }
            int a = maskedSubnetDigit[0] = Convert.ToInt32(maskedSubnet[0]);
            int b = maskedSubnetDigit[1] = Convert.ToInt32(maskedSubnet[1]);
            int c = maskedSubnetDigit[2] = Convert.ToInt32(maskedSubnet[2]);
            int d = maskedSubnetDigit[3] = Convert.ToInt32(maskedSubnet[3]);

            for (int i = 0; i < maskedSubnet.Length; i++)
            {
                if ( (maskedSubnetDigit[i] != 255) && (maskedSubnetDigit[i] != 0))
                {
                    maskedTextBoxSubnetMask.Text = "000000000000";
                    maskedTextBoxSubnetMask.ForeColor = Color.Red;

                    MessageBox.Show("enter valid Subnet Mask");
                }
                else
                {
                    maskedTextBoxSubnetMask.ForeColor = Color.Black;
                }
            }
        }

        private void maskedTextBoxSubnetMask_Enter(object sender, EventArgs e)
        {
            maskedTextBoxSubnetMask.ForeColor = Color.Black;
        }
    }
}
