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

namespace SERVER
{
    public partial class CreateForm : Form
    {
        IPAddress ipAddress;
        int portNumber;

        public CreateForm()
        {
            InitializeComponent();
        }

        private void btnCreate_Click(object sender, EventArgs e)
        {
            // validate IP Address and port number
            if (string.IsNullOrEmpty(txtBIPAddress.Text) && string.IsNullOrEmpty(txtBLocalPort.Text) && string.IsNullOrEmpty(txtBRemotePort.Text))
            {
                MessageBox.Show("Please fill in the missing place.", "WARNING", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }
            else
            {
                if (string.IsNullOrEmpty(txtBIPAddress.Text))
                {
                    MessageBox.Show("Please fill the IP address.", "WARNING", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    return;
                }
                if (string.IsNullOrEmpty(txtBLocalPort.Text))
                {
                    MessageBox.Show("Please fill the Port.", "WARNING", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    return;
                }
                if (string.IsNullOrEmpty(txtBRemotePort.Text))
                {
                    MessageBox.Show("Please fill the Port.", "WARNING", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    return;
                }
            }


            if (IPAddress.TryParse(txtBIPAddress.Text, out ipAddress) == false)
            {
                MessageBox.Show("INVALID IP ADDRESS!", "ERROR", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
            this.Close();
        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            DialogResult res = MessageBox.Show("Are you want to close?",
                            "Confirm",
                            MessageBoxButtons.OKCancel,
                            MessageBoxIcon.Question);
            if (res == DialogResult.Cancel)
            {
                return;
            }
            this.Close();
        }

        public string getIPAddress () { return txtBIPAddress.Text; }
        public string getLocalPortNumber () { return txtBLocalPort.Text; }
        public string getRemotePortNumber() { return txtBRemotePort.Text; }
    }
}
