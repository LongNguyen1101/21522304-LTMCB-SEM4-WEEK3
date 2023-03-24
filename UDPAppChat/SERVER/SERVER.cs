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
        private readonly Thread receiveThread;

        public SERVERForm()
        {
            InitializeComponent();
            receiveThread = new Thread(ReceiveThreadFunction);
            rTxtBMessageDisplay.ReadOnly = true;
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

                    // Add message to Message Display
                    string message = Encoding.UTF8.GetString(buffer, 0, byteRead);
                    string displayMessage = $"[{DateTime.Now:HH:mm:ss}] CLIENT -> : {message}\r\n";

                    Invoke(new Action(() => rTxtBMessageDisplay.AppendText(displayMessage)));
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
                receiveThread.Start();

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

            string message = txtBMessageSend.Text;
            byte[] data = Encoding.UTF8.GetBytes(message);
            IPEndPoint sendEndPoint = new IPEndPoint(serverIP, serverPortNumber);
            udpServer.SendTo(data, sendEndPoint);

            // Add message to Message Display
            string displayMessage = $"[{DateTime.Now:HH:mm:ss}] YOU -> : {message}\r\n";
            rTxtBMessageDisplay.AppendText(displayMessage);

            txtBMessageSend.Clear();
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
        
        private void txtBMessageSend_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            { 
                 btnSend_Click(sender, e);
            }
        }
    }
}
