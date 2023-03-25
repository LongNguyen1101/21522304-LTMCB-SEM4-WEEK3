using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Net.Sockets;
using System.Net;
using System.Threading;

namespace CLIENT
{
    public partial class CLIENT : Form
    {
        private UdpClient udpClient;
        private IPAddress IP;
        private int remotePortNumber;
        private int localPortNumber;

        public CLIENT()
        { 
            InitializeComponent();

            udpClient = new UdpClient();
            rTxtBMessageDisplay.ReadOnly = true;
        }

        private void CLIENT_Load(object sender, EventArgs e)
        {
            txtBMessageSend.Focus();
        }

        private void ReceiveCallback(IAsyncResult ar)
        {
            try
            {
                IPEndPoint remoteEP = new IPEndPoint(IPAddress.Any, 0);
                byte[] byteRead = udpClient.EndReceive(ar, ref remoteEP);

                // Add message to Message Display
                string message = Encoding.UTF8.GetString(byteRead);
                string displayMessage = $"[{DateTime.Now:HH:mm:ss}] SERVER -> : {message}\r\n";

                Invoke(new Action(() => rTxtBMessageDisplay.AppendText(displayMessage)));

                udpClient.BeginReceive(new AsyncCallback(ReceiveCallback), null);
            }
            catch (Exception ex)
            {
                MessageBox.Show($"An error occurred while receiving messages: {ex.Message}",
                                "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
        private void btnCreate_Click(object sender, EventArgs e)
        {

            CreateForm addEndPointServer = new CreateForm();
            addEndPointServer.ShowDialog();

            if (string.IsNullOrEmpty(addEndPointServer.getIPAddress()) ||
                string.IsNullOrEmpty(addEndPointServer.getLocalPortNumber()) ||
                string.IsNullOrEmpty(addEndPointServer.getLocalPortNumber())) return;
            else
            {
                IP = IPAddress.Parse(addEndPointServer.getIPAddress());
                remotePortNumber = Convert.ToInt32(addEndPointServer.getRemotePortNumber());
                localPortNumber = Convert.ToInt32(addEndPointServer.getLocalPortNumber());
            }

            try
            {
                udpClient = new UdpClient(localPortNumber);
                udpClient.BeginReceive(new AsyncCallback(ReceiveCallback), null);

                MessageBox.Show($"Start listening on port: {localPortNumber}", "CONNECT SUCCESSFUL", MessageBoxButtons.OK);
            }
            catch (Exception ex)
            {
                MessageBox.Show("CANNOT CREATE ENDPOINT\n\n" + ex.ToString(), "ERROR", MessageBoxButtons.OK, MessageBoxIcon.Error);
                btnCreate_Click(sender, e);
            }
        }
        private void btnInformation_Click(object sender, EventArgs e)
        {
            if (udpClient != null)
            {
                InformationForm inforForm = new InformationForm(IP.ToString(), localPortNumber.ToString(), remotePortNumber.ToString());
                inforForm.ShowDialog();
            }
            else
            {
                MessageBox.Show("Please create an end point.", "Warning", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }

        private void btnSend_Click(object sender, EventArgs e)
        {
            if (udpClient == null)
            {
                MessageBox.Show("Please create an end point.", "Warning", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }
            if (string.IsNullOrEmpty(txtBMessageSend.Text)) return;

            string message = txtBMessageSend.Text;
            byte[] data = Encoding.UTF8.GetBytes(message);
            IPEndPoint sendEndPoint = new IPEndPoint(IP, remotePortNumber);
            udpClient.Send(data, data.Length, sendEndPoint);

            // Add message to Message Display
            string displayMessage = $"[{DateTime.Now:HH:mm:ss}] YOU -> : {message}\r\n";
            rTxtBMessageDisplay.AppendText(displayMessage);

            txtBMessageSend.Clear();
        }

        private void txtBMessageSend_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                btnSend_Click(sender, e);
            }
        }

        private void CLIENT_FormClosing(object sender, FormClosingEventArgs e)
        {
            DialogResult res = MessageBox.Show("Are you want to close?",
                                               "Confirm",
                                               MessageBoxButtons.YesNo,
                                               MessageBoxIcon.Question);
            if (res == DialogResult.No)
            {
                e.Cancel = true;
            }
            else
            {
                if (udpClient != null)
                {
                    try
                    {
                        udpClient.Close();
                        //receiveThread.Abort();
                    }
                    catch
                    {
                        MessageBox.Show("CAN CLOSE THE APPLICATION!\n" + e.ToString(), "ERROR", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                }
            }
        }
    }
}
