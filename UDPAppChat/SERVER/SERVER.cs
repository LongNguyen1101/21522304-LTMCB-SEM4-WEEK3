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

namespace SERVER
{
    public partial class SERVERForm : Form
    {
        private Socket udpServer;
        private IPAddress serverIP;
        private int serverPortNumber;
        private Dictionary<IPEndPoint, string> clients; // for client list
        private BackgroundWorker bwReceiver; 

        public SERVERForm()
        {
            InitializeComponent();
            clients = new Dictionary<IPEndPoint, string>();
            bwReceiver = new BackgroundWorker();
            bwReceiver.WorkerSupportsCancellation = true;
        }

        private void BwReceiver_DoWork(object sender, DoWorkEventArgs e)
        {
            while (!bwReceiver.CancellationPending)
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
            e.Cancel = true;
        }

        private void BwReceiver_RunWorkerCompleted(object sender, RunWorkerCompletedEventArgs e)
        {
            if (e.Cancelled)
            {
                MessageBox.Show("Cancel thread complete!\nYou can close form now", "SUCESSFUL", MessageBoxButtons.OK);
            }
            else if (e.Error != null)
            {
                MessageBox.Show("Can close thread!\n" + e.Error.ToString(), "ERROR", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else
            {
                MessageBox.Show("The background operation completed successfully!\nYou can close form now", "SUCESSFUL", MessageBoxButtons.OK);
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
                bwReceiver.DoWork += BwReceiver_DoWork;
                bwReceiver.RunWorkerCompleted += BwReceiver_RunWorkerCompleted;
                bwReceiver.RunWorkerAsync();

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
                    bwReceiver.CancelAsync();
                    udpServer.Shutdown(SocketShutdown.Receive);
                    udpServer.Close();
                }
                catch 
                {
                    MessageBox.Show("CAN CLOSE THE APPLICATION!\n" + e.ToString(), "ERROR", MessageBoxButtons.OK, MessageBoxIcon.Error); 
                }
                
            }
            
        }
    }
}
