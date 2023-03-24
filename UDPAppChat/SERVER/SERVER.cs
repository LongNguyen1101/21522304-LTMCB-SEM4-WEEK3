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

namespace SERVER
{
    public partial class SERVERForm : Form
    {
        private Socket udpServer;
        private IPAddress serverIP;
        private int serverPortNumber;
        private Dictionary<IPEndPoint, string> clients; // for client list
        private readonly Thread receiveThread;

        public SERVERForm()
        {
            InitializeComponent();
            clients = new Dictionary<IPEndPoint, string>();
            receiveThread = new Thread(ReceiveThreadFunction);
        }

        private void ReceiveThreadFunction()
        {
            try
            {
                while (true)
                {
                    // Receive data from client
                    byte[] buffer = new byte[1024];
                    EndPoint remoteEP = new IPEndPoint(IPAddress.Any, 0);
                    int byteRead = udpServer.ReceiveFrom(buffer, ref remoteEP);
                    IPEndPoint clientEP = (IPEndPoint)remoteEP;

                    // Add client to list Box if not already connected
                    if (!clients.ContainsKey(clientEP))
                    {
                        clients.Add(clientEP, clientEP.ToString());
                        updateClientList();
                    }

                    // Add message to Message Display
                    string message = Encoding.UTF8.GetString(buffer, 0, byteRead);
                    string displayMessage = $"[{DateTime.Now:HH:mm:ss}] -> {clients[clientEP]}: {message}\r\n";
                   
                    this.Invoke(new Action(() => rTxtBMessageDisplay.AppendText(displayMessage)));
                }
            }
            catch (SocketException ex)
            {
                MessageBox.Show($"An error occurred while receiving messages: {ex.Message}",
                                "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btnCreate_Click(object sender, EventArgs e)
        {
            CreateForm createForm = new CreateForm();
            createForm.ShowDialog();

            if (string.IsNullOrEmpty(createForm.getIPAddress()) || string.IsNullOrEmpty(createForm.getPortNumber())) return;
            else
            {
                serverIP = IPAddress.Parse(createForm.getIPAddress());
                serverPortNumber = Convert.ToInt32(createForm.getPortNumber());
            }

            try
            {
                udpServer = new Socket(AddressFamily.InterNetwork, SocketType.Dgram, ProtocolType.Udp);
                udpServer.Bind(new IPEndPoint(serverIP, serverPortNumber));

                MessageBox.Show($"Start listening on port: {serverPortNumber}", "CONNECT SUCCESSFUL", MessageBoxButtons.OK);
            }
            catch (Exception ex)
            {
                MessageBox.Show("CANNOT CREATE ENDPOINT\n\n" + ex.ToString(), "ERROR", MessageBoxButtons.OK, MessageBoxIcon.Error);
                btnCreate_Click(sender, e);
            }
        }

        private void btnSend_Click(object sender, EventArgs e)
        {
            if (udpServer == null)
            {
                MessageBox.Show("Please create an end point.", "Warning", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }
            if (string.IsNullOrEmpty(txtBMessageSend.Text)) return;

            // Send message to all connected clients
            string message = txtBMessageSend.Text;
            byte[] data = Encoding.UTF8.GetBytes(message);
            foreach (var client in clients.Keys)
                udpServer.SendTo(data, client);

            // Add message to Message Display
            string displayMessage = string.Format("Server: {0}\n", message);
            rTxtBMessageDisplay.AppendText(displayMessage);

            txtBMessageSend.Clear();
        }

        private void updateClientList()
        {
            this.Invoke(new Action(() =>
            {
                lstBClientList.Items.Clear();
                foreach (var client in clients.Values)
                    lstBClientList.Items.Add(client);
            }));
        }

        private void SERVERForm_Load(object sender, EventArgs e)
        {
            txtBMessageSend.Focus();
        }

        private void SERVERForm_FormClosing(object sender, FormClosingEventArgs e)
        {
            DialogResult res = MessageBox.Show("Are you want to close?",
                            "Confirm",
                            MessageBoxButtons.OKCancel,
                            MessageBoxIcon.Question);
            if (res == DialogResult.Cancel)
            {
                return;
            }

            if (udpServer != null) 
            {
                try
                {
                    udpServer.Close();
                    receiveThread.Abort();
                }
                catch 
                {
                    MessageBox.Show("CAN CLOSE THE APPLICATION!\n" + e.ToString(), "ERROR", MessageBoxButtons.OK, MessageBoxIcon.Error); 
                }
                
            }
            
        }

        private void btnInformation_Click(object sender, EventArgs e)
        {
            if (udpServer != null)
            {
                InformationForm inforForm = new InformationForm(serverIP.ToString(), serverPortNumber.ToString());
                inforForm.ShowDialog();
            }
            else
            {
                MessageBox.Show("Please create an end point.", "Warning", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }
    }
}
